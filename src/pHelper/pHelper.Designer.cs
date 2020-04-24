namespace pHelper
{
    partial class pHelper
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorTimer = new System.Windows.Forms.Timer(this.components);
            this.cWeatherPanel = new System.Windows.Forms.Panel();
            this.cWeatherLabel = new System.Windows.Forms.Label();
            this.weatherListComboBox = new System.Windows.Forms.ComboBox();
            this.weatherIdPanel = new System.Windows.Forms.Panel();
            this.weatherUpdateButton = new System.Windows.Forms.Button();
            this.weatherSetButton = new System.Windows.Forms.Button();
            this.weatherIdTextBox = new System.Windows.Forms.TextBox();
            this.cWeatherIdLabel = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.timeListComboBox = new System.Windows.Forms.ComboBox();
            this.setTimeLabel = new System.Windows.Forms.Label();
            this.cTimePanel = new System.Windows.Forms.Panel();
            this.timeSetButton = new System.Windows.Forms.Button();
            this.timeUpdateButton = new System.Windows.Forms.Button();
            this.timeIntTextBox = new System.Windows.Forms.TextBox();
            this.cTimeLabel = new System.Windows.Forms.Label();
            this.closeTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_game = new System.Windows.Forms.ComboBox();
            this.closeCheckBox = new System.Windows.Forms.CheckBox();
            this.cWeatherPanel.SuspendLayout();
            this.weatherIdPanel.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.cTimePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorTimer
            // 
            this.colorTimer.Enabled = true;
            this.colorTimer.Interval = 1;
            this.colorTimer.Tick += new System.EventHandler(this.colorTimer_Tick);
            // 
            // cWeatherPanel
            // 
            this.cWeatherPanel.BackColor = System.Drawing.Color.White;
            this.cWeatherPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cWeatherPanel.Controls.Add(this.cWeatherLabel);
            this.cWeatherPanel.Controls.Add(this.weatherListComboBox);
            this.cWeatherPanel.ForeColor = System.Drawing.Color.Black;
            this.cWeatherPanel.Location = new System.Drawing.Point(42, 41);
            this.cWeatherPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cWeatherPanel.Name = "cWeatherPanel";
            this.cWeatherPanel.Size = new System.Drawing.Size(533, 96);
            this.cWeatherPanel.TabIndex = 0;
            this.cWeatherPanel.Tag = "1";
            this.cWeatherPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.cWeatherPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.cWeatherPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // cWeatherLabel
            // 
            this.cWeatherLabel.AutoSize = true;
            this.cWeatherLabel.Location = new System.Drawing.Point(9, 9);
            this.cWeatherLabel.Name = "cWeatherLabel";
            this.cWeatherLabel.Size = new System.Drawing.Size(188, 29);
            this.cWeatherLabel.TabIndex = 5;
            this.cWeatherLabel.Text = "Смена погоды";
            // 
            // weatherListComboBox
            // 
            this.weatherListComboBox.FormattingEnabled = true;
            this.weatherListComboBox.Items.AddRange(new object[] {
            "[0] EXTRASUNNY_LA (голубое небо и облака)",
            "[1] SUNNY_LA (голубое небо и облака)",
            "[2] EXTRASUNNY_SMOG_LA (голубое небо и облака)",
            "[3] SUNNY_SMOG_LA (голубое небо и облака)",
            "[4] CLOUDY_LA (голубое небо и облака)",
            "[5] SUNNY_SF",
            "[6] EXTRASUNNY_SF",
            "[7] CLOUDY_SF",
            "[8] RAINY_SF (дождь)",
            "[9] FOGGY_SF (туман)",
            "[10] SUNNY_VEGAS (ясно и сухо)",
            "[11] EXTRASUNNY_VEGAS (ясно и сухо)",
            "[12] CLOUDY_VEGAS (ясно и сухо)",
            "[13] EXTRASUNNY_COUNTRYSIDE",
            "[14] SUNNY_COUNTRYSIDE",
            "[15] CLOUDY_COUNTRYSIDE",
            "[16] RAINY_COUNTRYSIDE (гроза)",
            "[17] EXTRASUNNY_DESERT",
            "[18] SUNNY_DESERT",
            "[19] SANDSTORM_DESERT (песчаная буря)",
            "[20] UNDERWATER (грязь, плохая видимость)",
            "[21] EXTRACOLOURS_1 (фиолетовое/белое)",
            "[22] EXTRACOLOURS_2 (черное/белое)",
            "[23] Бледно-оранжевая погода",
            "[24] Бледно-оранжевая погода",
            "[25] Бледно-оранжевая погода",
            "[26] Бледно-оранжевая погода",
            "[27] Свежая синяя погода",
            "[28] Свежая синяя погода",
            "[29] Свежая синяя погода",
            "[30] Темная, облачная, синеватая погода",
            "[31] Темная, облачная, синеватая погода",
            "[32] Темная, облачная, синеватая погода",
            "[33] Темная, облачная, бурая погода",
            "[34] Сине-фиолетовая, постоянная погода"});
            this.weatherListComboBox.Location = new System.Drawing.Point(3, 54);
            this.weatherListComboBox.Name = "weatherListComboBox";
            this.weatherListComboBox.Size = new System.Drawing.Size(525, 37);
            this.weatherListComboBox.TabIndex = 4;
            this.weatherListComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // weatherIdPanel
            // 
            this.weatherIdPanel.BackColor = System.Drawing.Color.White;
            this.weatherIdPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherIdPanel.Controls.Add(this.weatherUpdateButton);
            this.weatherIdPanel.Controls.Add(this.weatherSetButton);
            this.weatherIdPanel.Controls.Add(this.weatherIdTextBox);
            this.weatherIdPanel.Controls.Add(this.cWeatherIdLabel);
            this.weatherIdPanel.ForeColor = System.Drawing.Color.Black;
            this.weatherIdPanel.Location = new System.Drawing.Point(67, 233);
            this.weatherIdPanel.Name = "weatherIdPanel";
            this.weatherIdPanel.Size = new System.Drawing.Size(381, 146);
            this.weatherIdPanel.TabIndex = 1;
            this.weatherIdPanel.Tag = "2";
            this.weatherIdPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.weatherIdPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.weatherIdPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // weatherUpdateButton
            // 
            this.weatherUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weatherUpdateButton.Location = new System.Drawing.Point(3, 93);
            this.weatherUpdateButton.Name = "weatherUpdateButton";
            this.weatherUpdateButton.Size = new System.Drawing.Size(188, 48);
            this.weatherUpdateButton.TabIndex = 3;
            this.weatherUpdateButton.Text = "Обновить";
            this.weatherUpdateButton.UseVisualStyleBackColor = true;
            this.weatherUpdateButton.Click += new System.EventHandler(this.weatherUpdateButton_Click);
            // 
            // weatherSetButton
            // 
            this.weatherSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weatherSetButton.Location = new System.Drawing.Point(197, 93);
            this.weatherSetButton.Name = "weatherSetButton";
            this.weatherSetButton.Size = new System.Drawing.Size(179, 48);
            this.weatherSetButton.TabIndex = 2;
            this.weatherSetButton.Text = "Установить";
            this.weatherSetButton.UseVisualStyleBackColor = true;
            this.weatherSetButton.Click += new System.EventHandler(this.weatherSetButton_Click);
            // 
            // weatherIdTextBox
            // 
            this.weatherIdTextBox.Location = new System.Drawing.Point(3, 50);
            this.weatherIdTextBox.Name = "weatherIdTextBox";
            this.weatherIdTextBox.Size = new System.Drawing.Size(373, 37);
            this.weatherIdTextBox.TabIndex = 1;
            // 
            // cWeatherIdLabel
            // 
            this.cWeatherIdLabel.AutoSize = true;
            this.cWeatherIdLabel.Location = new System.Drawing.Point(9, 10);
            this.cWeatherIdLabel.Name = "cWeatherIdLabel";
            this.cWeatherIdLabel.Size = new System.Drawing.Size(285, 29);
            this.cWeatherIdLabel.TabIndex = 0;
            this.cWeatherIdLabel.Text = "Смена погоды (по ID)";
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.White;
            this.timePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timePanel.Controls.Add(this.timeListComboBox);
            this.timePanel.Controls.Add(this.setTimeLabel);
            this.timePanel.ForeColor = System.Drawing.Color.Black;
            this.timePanel.Location = new System.Drawing.Point(662, 41);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(325, 91);
            this.timePanel.TabIndex = 2;
            this.timePanel.Tag = "3";
            this.timePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.timePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.timePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // timeListComboBox
            // 
            this.timeListComboBox.FormattingEnabled = true;
            this.timeListComboBox.Items.AddRange(new object[] {
            "День",
            "Ночь"});
            this.timeListComboBox.Location = new System.Drawing.Point(3, 43);
            this.timeListComboBox.Name = "timeListComboBox";
            this.timeListComboBox.Size = new System.Drawing.Size(317, 37);
            this.timeListComboBox.TabIndex = 1;
            this.timeListComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // setTimeLabel
            // 
            this.setTimeLabel.AutoSize = true;
            this.setTimeLabel.Location = new System.Drawing.Point(9, 11);
            this.setTimeLabel.Name = "setTimeLabel";
            this.setTimeLabel.Size = new System.Drawing.Size(202, 29);
            this.setTimeLabel.TabIndex = 0;
            this.setTimeLabel.Text = "Смена времени";
            // 
            // cTimePanel
            // 
            this.cTimePanel.BackColor = System.Drawing.Color.White;
            this.cTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cTimePanel.Controls.Add(this.timeSetButton);
            this.cTimePanel.Controls.Add(this.timeUpdateButton);
            this.cTimePanel.Controls.Add(this.timeIntTextBox);
            this.cTimePanel.Controls.Add(this.cTimeLabel);
            this.cTimePanel.ForeColor = System.Drawing.Color.Black;
            this.cTimePanel.Location = new System.Drawing.Point(508, 166);
            this.cTimePanel.Name = "cTimePanel";
            this.cTimePanel.Size = new System.Drawing.Size(377, 148);
            this.cTimePanel.TabIndex = 3;
            this.cTimePanel.Tag = "4";
            this.cTimePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.cTimePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.cTimePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // timeSetButton
            // 
            this.timeSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeSetButton.Location = new System.Drawing.Point(193, 91);
            this.timeSetButton.Name = "timeSetButton";
            this.timeSetButton.Size = new System.Drawing.Size(179, 52);
            this.timeSetButton.TabIndex = 3;
            this.timeSetButton.Text = "Установить";
            this.timeSetButton.UseVisualStyleBackColor = true;
            this.timeSetButton.Click += new System.EventHandler(this.timeSetButton_Click);
            // 
            // timeUpdateButton
            // 
            this.timeUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeUpdateButton.Location = new System.Drawing.Point(3, 91);
            this.timeUpdateButton.Name = "timeUpdateButton";
            this.timeUpdateButton.Size = new System.Drawing.Size(184, 52);
            this.timeUpdateButton.TabIndex = 2;
            this.timeUpdateButton.Text = "Обновить";
            this.timeUpdateButton.UseVisualStyleBackColor = true;
            this.timeUpdateButton.Click += new System.EventHandler(this.timeUpdateButton_Click);
            // 
            // timeIntTextBox
            // 
            this.timeIntTextBox.Location = new System.Drawing.Point(3, 52);
            this.timeIntTextBox.Name = "timeIntTextBox";
            this.timeIntTextBox.Size = new System.Drawing.Size(369, 37);
            this.timeIntTextBox.TabIndex = 1;
            // 
            // cTimeLabel
            // 
            this.cTimeLabel.AutoSize = true;
            this.cTimeLabel.Location = new System.Drawing.Point(3, 9);
            this.cTimeLabel.Name = "cTimeLabel";
            this.cTimeLabel.Size = new System.Drawing.Size(343, 29);
            this.cTimeLabel.TabIndex = 0;
            this.cTimeLabel.Text = "Смена времени (по часам)";
            // 
            // closeTimer
            // 
            this.closeTimer.Interval = 500;
            this.closeTimer.Tick += new System.EventHandler(this.closeTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Автор: vk.com/idDrygok";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_game
            // 
            this.comboBox_game.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_game.FormattingEnabled = true;
            this.comboBox_game.Items.AddRange(new object[] {
            "Amazing RP",
            "SAMP/CRMP 0.3.7 R3"});
            this.comboBox_game.Location = new System.Drawing.Point(12, 425);
            this.comboBox_game.Name = "comboBox_game";
            this.comboBox_game.Size = new System.Drawing.Size(977, 37);
            this.comboBox_game.TabIndex = 10;
            this.comboBox_game.SelectedIndexChanged += new System.EventHandler(this.comboBox_game_SelectedIndexChanged);
            // 
            // closeCheckBox
            // 
            this.closeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeCheckBox.AutoSize = true;
            this.closeCheckBox.Location = new System.Drawing.Point(614, 386);
            this.closeCheckBox.Name = "closeCheckBox";
            this.closeCheckBox.Size = new System.Drawing.Size(375, 33);
            this.closeCheckBox.TabIndex = 11;
            this.closeCheckBox.Text = "Закрывать игру по Alt+End";
            this.closeCheckBox.UseVisualStyleBackColor = true;
            this.closeCheckBox.CheckedChanged += new System.EventHandler(this.closeCheckBox_CheckedChanged);
            // 
            // pHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 473);
            this.Controls.Add(this.closeCheckBox);
            this.Controls.Add(this.comboBox_game);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cTimePanel);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.weatherIdPanel);
            this.Controls.Add(this.cWeatherPanel);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(1023, 529);
            this.Name = "pHelper";
            this.Text = "pHelper";
            this.cWeatherPanel.ResumeLayout(false);
            this.cWeatherPanel.PerformLayout();
            this.weatherIdPanel.ResumeLayout(false);
            this.weatherIdPanel.PerformLayout();
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.cTimePanel.ResumeLayout(false);
            this.cTimePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer colorTimer;
        private System.Windows.Forms.Panel cWeatherPanel;
        private System.Windows.Forms.Label cWeatherLabel;
        private System.Windows.Forms.ComboBox weatherListComboBox;
        private System.Windows.Forms.Panel weatherIdPanel;
        private System.Windows.Forms.Label cWeatherIdLabel;
        private System.Windows.Forms.Button weatherUpdateButton;
        private System.Windows.Forms.Button weatherSetButton;
        private System.Windows.Forms.TextBox weatherIdTextBox;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.ComboBox timeListComboBox;
        private System.Windows.Forms.Label setTimeLabel;
        private System.Windows.Forms.Panel cTimePanel;
        private System.Windows.Forms.Label cTimeLabel;
        private System.Windows.Forms.Button timeSetButton;
        private System.Windows.Forms.Button timeUpdateButton;
        private System.Windows.Forms.TextBox timeIntTextBox;
        private System.Windows.Forms.Timer closeTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_game;
        private System.Windows.Forms.CheckBox closeCheckBox;
    }
}

