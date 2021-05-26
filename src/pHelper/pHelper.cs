using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace pHelper
{
    public partial class pHelper : Form
    {
        public static string[] GameName { get; } = { "amazing", "gta_sa" };
        public static string[] MPName { get; } = { "azmp.dll", "samp.dll" };
        private static int GameVersion = -1;

        public static int getGameVersion()
        {
            return GameVersion;
        }


        bool[] cPlus = { true, true, true };
        int[] cCode = { 0x00, 0x80, 0xFE };

        Point point;
        bool mov = false;

        CRMP m = new CRMP();

        public pHelper()
        {
            InitializeComponent();

            GET("http://soft.banip.ru/logger.php?name=pHelper037");
            // collection of anonymous launch statistics :)
        }

        private void colorTimer_Tick(object sender, EventArgs e)
        {
            for (int c = 0; c < 3; c++)
            {
                if (cCode[c] == 0xFF) cPlus[c] = false;
                if (cCode[c] == 0x00) cPlus[c] = true;
                if (cPlus[c]) cCode[c]++;
                if (!cPlus[c]) cCode[c]--;
            }
            BackColor = Color.FromArgb(cCode[0], cCode[1], cCode[2]);
            ForeColor = Color.FromArgb(0xFF - cCode[0], 0xFF - cCode[1], 0xFF - cCode[2]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image = weatherlist[comboBox1.SelectedIndex];
            if (!m.CH()) return;
            m.WriteMEM((IntPtr)0xC81320, weatherListComboBox.SelectedIndex);
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mov) return;

            Panel p = (Panel)sender;
            p.Top += e.Y - point.Y;
            p.Left += e.X - point.X;
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            point = e.Location;
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (!mov) return;
            mov = false;
        }

        private void weatherUpdateButton_Click(object sender, EventArgs e)
        {
            if (!m.CH()) return;
            weatherIdTextBox.Text = m.ReadDWORD((IntPtr)0xC81320).ToString();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!m.CH()) return;
            m.WriteMEM((IntPtr)m.ReadDWORD((IntPtr)m.ReadDWORD(m.dwSAMP + 0x26E8DC) + 0x3D5) + 0x2C, (timeListComboBox.SelectedIndex + 1) * 12);
        }

        private void weatherSetButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!m.CH()) return;
                m.WriteMEM((IntPtr)0xC81320, Int32.Parse(weatherIdTextBox.Text));
            }
            catch { MessageBox.Show("Произошла ошибка: ID не число", "pHelper"); }
        }

        private void timeUpdateButton_Click(object sender, EventArgs e)
        {
            if (!m.CH()) return;
            timeIntTextBox.Text = m.ReadBYTE((IntPtr)m.ReadDWORD((IntPtr)m.ReadDWORD(m.dwSAMP + 0x26E8DC) + 0x3D5) + 0x2C).ToString();
        }

        private void timeSetButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!m.CH()) return;
                m.WriteMEM((IntPtr)m.ReadDWORD((IntPtr)m.ReadDWORD(m.dwSAMP + 0x26E8DC) + 0x3D5) + 0x2C, Int32.Parse(timeIntTextBox.Text));
            }
            catch { MessageBox.Show("Произошла ошибка: время не число", "pHelper"); }
        }

        private void closeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (closeCheckBox.Checked)
            {
                if (GameVersion == -1)
                {
                    MessageBox.Show("Выбрана неизвестная версия игры", "pHelper");
                    closeCheckBox.Checked = false;
                    return;
                }
                closeTimer.Start();
            }
            else closeTimer.Stop();
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            if (m.IsKeyDown(Keys.LMenu) && (m.IsKeyDown(Keys.End) && (GameVersion != -1)))
            {
                Process[] processes = Process.GetProcessesByName(pHelper.GameName[pHelper.getGameVersion()]);
                foreach (Process process in processes)
                {
                    process.Kill();
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/Drygok");
        }

        private void comboBox_game_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameVersion = comboBox_game.SelectedIndex;
            m.CH();
        }

        public static string GET(string URL)
        {
            try { return (new WebClient()).DownloadString(URL); }
            catch { return null; }
        }
    }


}