using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pHelper
{
    class CRMP
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize,
            out UIntPtr lpNumberOfBytesWritten);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool CloseHandle(IntPtr hObject);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern short GetKeyState(int nVirtKey);
        [DllImport("user32.dll")]
        static extern int GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(int hWnd, StringBuilder text, int count);

        public IntPtr dwSAMP = (IntPtr)0x0, handle = (IntPtr)0x0;
        public int pID = 0;

        private bool InitCR()
        {
            if (handle != (IntPtr)0x0) CloseHandle(handle);

            dwSAMP = (IntPtr)0x0;
            handle = (IntPtr)0x0;
            
            Process[] processes = Process.GetProcessesByName(pHelper.GameName[pHelper.getGameVersion()]);
            for (int p = 0; p < processes.Length; p++)
            {
                Process process = processes[p];
                pID = process.Id;
                handle = OpenProcess(0x001F0FFF, false, pID);
                ProcessModuleCollection modules = process.Modules;
                foreach (ProcessModule i in modules)
                {
                    if (i.ModuleName == pHelper.MPName[pHelper.getGameVersion()]) dwSAMP = (IntPtr)i.BaseAddress.ToInt32();
                    // сюда можно добавить другие модули при необходимости
                    if ((pID != 0) && (dwSAMP != (IntPtr)0x0)) return true; 
                    // вряд ли кто-то запустит два процесса игры одновременно (она этого не позволит), поэтому считаем за игру первый процесс с подходящим именем и подгруженным модулем мультиплеера
                }
                if (p == processes.Length - 1) // если процессов с таким именем больше одного - переберать следует все, а ошибку выдать только на последнем
                {
                    MessageBox.Show($"Модуль мультиплеера \"{pHelper.MPName[pHelper.getGameVersion()]}\" не найден.\nВозможно, Вы зашли в одиночную игру?\n\nПодробности:\npID: {pID}\ndwSAMP: {dwSAMP}", "pHelper");
                    return false;
                }
            }
            MessageBox.Show($"Процесс \"{pHelper.GameName[pHelper.getGameVersion()]}\" не найден.\nВозможно, игра закрыта?", "pHelper");
            return false;
        }

        public bool CH()
        {
            if (pHelper.getGameVersion() == -1)
            {
                MessageBox.Show("Выбрана неизвестная версия игры", "pHelper");
                return false;
            }
            try
            {
                if (Process.GetProcessById(pID).ProcessName == pHelper.GameName[pHelper.getGameVersion()])
                {
                    return true;
                }
                return (InitCR());
            }
            catch
            {
                return false;
            }
        }

        public int ReadMem(IntPtr address, uint size)
        {
            byte[] buffer = new byte[size];
            ReadProcessMemory(handle, address, buffer, size, out IntPtr lpNumberOfBytesRead);
            return BitConverter.ToInt32(buffer, 0);
        }
        public int ReadDWORD(IntPtr address)
        {
            byte[] buffer = new byte[4];
            ReadProcessMemory(handle, address, buffer, 4, out IntPtr lpNumberOfBytesRead);
            return BitConverter.ToInt32(buffer, 0);
        }
        public byte[] ReadBYTES(IntPtr address)
        {
            byte[] buffer = new byte[4];
            ReadProcessMemory(handle, address, buffer, 4, out IntPtr lpNumberOfBytesRead);
            return buffer;
        }
        public byte ReadBYTE(IntPtr address)
        {
            return ReadBYTES(address)[0];
        }
        public float ReadFLOAT(IntPtr address)
        {
            byte[] buffer = new byte[4];
            ReadProcessMemory(handle, address, buffer, 4, out IntPtr lpNumberOfBytesRead);
            return BitConverter.ToSingle(buffer, 0);
        }
        public void WriteMEM(IntPtr address, int value)
        {
            byte[] wBytes = BitConverter.GetBytes(value);
            WriteProcessMemory(handle, address, wBytes, (uint)wBytes.Length, out UIntPtr ptrBytesRead);
        }
        public void WriteMEM(IntPtr address, float value)
        {
            byte[] wBytes = BitConverter.GetBytes(value);
            WriteProcessMemory(handle, address, wBytes, (uint)wBytes.Length, out UIntPtr ptrBytesRead);
        }
        public void WriteMEM(IntPtr address, byte[] wBytes)
        {
            WriteProcessMemory(handle, address, wBytes, (uint)wBytes.Length, out UIntPtr ptrBytesRead);
        }
        public void WriteMEM(IntPtr address, string text)
        {
            byte[] wBytes = Encoding.ASCII.GetBytes(text);
            WriteProcessMemory(handle, address, wBytes, (uint)wBytes.Length, out UIntPtr ptrBytesRead);
        }


        private enum KeyStates
        {
            None = 0,
            Down = 1,
            Toggled = 2
        }
        private static KeyStates GetKeyState(Keys key)
        {
            KeyStates state = KeyStates.None;

            short retVal = GetKeyState((int)key);

            //If the high-order bit is 1, the key is down
            //otherwise, it is up.
            if ((retVal & 0x8000) == 0x8000)
                state |= KeyStates.Down;

            //If the low-order bit is 1, the key is toggled.
            if ((retVal & 1) == 1)
                state |= KeyStates.Toggled;

            return state;
        }
        public bool IsKeyDown(Keys key)
        {
            return KeyStates.Down == (GetKeyState(key) & KeyStates.Down);
        }
        public bool IsKeyToggled(Keys key)
        {
            return KeyStates.Toggled == (GetKeyState(key) & KeyStates.Toggled);
        }
        public string GetActiveWindow()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);


            if (GetWindowText(GetForegroundWindow(), Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return "ERROR";
        }
    }
}
