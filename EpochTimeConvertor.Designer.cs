namespace WinFormsApp1
{
    partial class EpochTimeConvertor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelMonth = new Panel();
            textBoxFormat1 = new TextBox();
            textBoxEpoch = new TextBox();
            textBoxFormat2 = new TextBox();
            labelDay = new Label();
            labelEpoch = new Label();
            textBoxDirectEntry1 = new TextBox();
            textBoxDirectEntry2 = new TextBox();
            BigCalendar = new MonthCalendar();
            buttonUseLocal = new Button();
            buttonCopyDirectEntry1 = new Button();
            textBoxCurrentTimeLocal = new TextBox();
            CurrentTimeTimer = new System.Windows.Forms.Timer(components);
            labelCurrentTime = new Label();
            textBoxCurrentTimeUTC = new TextBox();
            labelCurrentTimeUTC = new Label();
            labelMonth = new Label();
            labelYear = new Label();
            labelHour = new Label();
            labelMinute = new Label();
            labelSecond = new Label();
            labelMS = new Label();
            labelEpochMS = new Label();
            textBoxEpochMS = new TextBox();
            panelDay = new Panel();
            panelHour = new Panel();
            panelMinute = new Panel();
            panelSecond = new Panel();
            listBoxYear = new ListBox();
            textBoxMilisecond = new TextBox();
            buttonCopyEpoch = new Button();
            buttonCopyDirectEntry2 = new Button();
            buttonCopyEpochMS = new Button();
            buttonUseUTC = new Button();
            buttonPasteDirectEntry1 = new Button();
            buttonPasteDirectEntry2 = new Button();
            buttonPasteEpoch = new Button();
            buttonPasteEpochMS = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // panelMonth
            // 
            panelMonth.Location = new Point(10, 189);
            panelMonth.Margin = new Padding(0);
            panelMonth.Name = "panelMonth";
            panelMonth.Size = new Size(480, 40);
            panelMonth.TabIndex = 100;
            // 
            // textBoxFormat1
            // 
            textBoxFormat1.Location = new Point(12, 27);
            textBoxFormat1.Margin = new Padding(2);
            textBoxFormat1.Name = "textBoxFormat1";
            textBoxFormat1.Size = new Size(180, 23);
            textBoxFormat1.TabIndex = 101;
            textBoxFormat1.TabStop = false;
            textBoxFormat1.TextAlign = HorizontalAlignment.Right;
            textBoxFormat1.TextChanged += textBoxFormat_TextChanged;
            // 
            // textBoxEpoch
            // 
            textBoxEpoch.Location = new Point(198, 95);
            textBoxEpoch.Margin = new Padding(2);
            textBoxEpoch.Name = "textBoxEpoch";
            textBoxEpoch.Size = new Size(180, 23);
            textBoxEpoch.TabIndex = 3;
            textBoxEpoch.TextAlign = HorizontalAlignment.Right;
            textBoxEpoch.TextChanged += textBoxEpoch_TextChanged;
            // 
            // textBoxFormat2
            // 
            textBoxFormat2.Location = new Point(12, 54);
            textBoxFormat2.Margin = new Padding(2);
            textBoxFormat2.Name = "textBoxFormat2";
            textBoxFormat2.Size = new Size(180, 23);
            textBoxFormat2.TabIndex = 102;
            textBoxFormat2.TabStop = false;
            textBoxFormat2.TextAlign = HorizontalAlignment.Right;
            textBoxFormat2.TextChanged += textBoxFormat_TextChanged;
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Location = new Point(10, 229);
            labelDay.Margin = new Padding(2, 0, 2, 0);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(26, 15);
            labelDay.TabIndex = 103;
            labelDay.Text = "day";
            // 
            // labelEpoch
            // 
            labelEpoch.AutoSize = true;
            labelEpoch.Location = new Point(51, 95);
            labelEpoch.Margin = new Padding(2, 0, 2, 0);
            labelEpoch.Name = "labelEpoch";
            labelEpoch.Size = new Size(110, 15);
            labelEpoch.TabIndex = 104;
            labelEpoch.Text = "epoch time w/o ms";
            // 
            // textBoxDirectEntry1
            // 
            textBoxDirectEntry1.Location = new Point(198, 27);
            textBoxDirectEntry1.Margin = new Padding(2);
            textBoxDirectEntry1.Name = "textBoxDirectEntry1";
            textBoxDirectEntry1.Size = new Size(180, 23);
            textBoxDirectEntry1.TabIndex = 1;
            textBoxDirectEntry1.TextAlign = HorizontalAlignment.Right;
            textBoxDirectEntry1.TextChanged += textBoxDirectEntry1_TextChanged;
            // 
            // textBoxDirectEntry2
            // 
            textBoxDirectEntry2.Location = new Point(198, 54);
            textBoxDirectEntry2.Margin = new Padding(2);
            textBoxDirectEntry2.Name = "textBoxDirectEntry2";
            textBoxDirectEntry2.Size = new Size(180, 23);
            textBoxDirectEntry2.TabIndex = 2;
            textBoxDirectEntry2.TextAlign = HorizontalAlignment.Right;
            textBoxDirectEntry2.TextChanged += textBoxDirectEntry2_TextChanged;
            // 
            // BigCalendar
            // 
            BigCalendar.Location = new Point(828, 82);
            BigCalendar.Margin = new Padding(6, 5, 6, 5);
            BigCalendar.MaxDate = new DateTime(2070, 12, 31, 0, 0, 0, 0);
            BigCalendar.MaxSelectionCount = 1;
            BigCalendar.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            BigCalendar.Name = "BigCalendar";
            BigCalendar.ShowToday = false;
            BigCalendar.TabIndex = 105;
            BigCalendar.TabStop = false;
            BigCalendar.DateChanged += BigCalendar_DateChanged;
            // 
            // buttonUseLocal
            // 
            buttonUseLocal.Location = new Point(904, 24);
            buttonUseLocal.Margin = new Padding(2);
            buttonUseLocal.Name = "buttonUseLocal";
            buttonUseLocal.Size = new Size(84, 24);
            buttonUseLocal.TabIndex = 106;
            buttonUseLocal.TabStop = false;
            buttonUseLocal.Text = "apply";
            buttonUseLocal.UseVisualStyleBackColor = true;
            buttonUseLocal.Click += buttonUseLocal_Click;
            // 
            // buttonCopyDirectEntry1
            // 
            buttonCopyDirectEntry1.Location = new Point(382, 24);
            buttonCopyDirectEntry1.Margin = new Padding(2);
            buttonCopyDirectEntry1.Name = "buttonCopyDirectEntry1";
            buttonCopyDirectEntry1.Size = new Size(120, 24);
            buttonCopyDirectEntry1.TabIndex = 107;
            buttonCopyDirectEntry1.TabStop = false;
            buttonCopyDirectEntry1.Text = "copy to clipboard";
            buttonCopyDirectEntry1.UseVisualStyleBackColor = true;
            buttonCopyDirectEntry1.Click += buttonCopyDirectEntry1_Click;
            // 
            // textBoxCurrentTimeLocal
            // 
            textBoxCurrentTimeLocal.Location = new Point(752, 27);
            textBoxCurrentTimeLocal.Margin = new Padding(2);
            textBoxCurrentTimeLocal.Name = "textBoxCurrentTimeLocal";
            textBoxCurrentTimeLocal.ReadOnly = true;
            textBoxCurrentTimeLocal.Size = new Size(148, 23);
            textBoxCurrentTimeLocal.TabIndex = 108;
            textBoxCurrentTimeLocal.TabStop = false;
            textBoxCurrentTimeLocal.TextAlign = HorizontalAlignment.Right;
            // 
            // CurrentTimeTimer
            // 
            CurrentTimeTimer.Enabled = true;
            CurrentTimeTimer.Interval = 1000;
            CurrentTimeTimer.Tick += CurrentTimeTimer_Tick;
            // 
            // labelCurrentTime
            // 
            labelCurrentTime.AutoSize = true;
            labelCurrentTime.Location = new Point(632, 29);
            labelCurrentTime.Margin = new Padding(2, 0, 2, 0);
            labelCurrentTime.Name = "labelCurrentTime";
            labelCurrentTime.Size = new Size(100, 15);
            labelCurrentTime.TabIndex = 109;
            labelCurrentTime.Text = "current local time";
            // 
            // textBoxCurrentTimeUTC
            // 
            textBoxCurrentTimeUTC.Location = new Point(752, 54);
            textBoxCurrentTimeUTC.Margin = new Padding(2);
            textBoxCurrentTimeUTC.Name = "textBoxCurrentTimeUTC";
            textBoxCurrentTimeUTC.ReadOnly = true;
            textBoxCurrentTimeUTC.Size = new Size(148, 23);
            textBoxCurrentTimeUTC.TabIndex = 110;
            textBoxCurrentTimeUTC.TabStop = false;
            textBoxCurrentTimeUTC.TextAlign = HorizontalAlignment.Right;
            // 
            // labelCurrentTimeUTC
            // 
            labelCurrentTimeUTC.AutoSize = true;
            labelCurrentTimeUTC.Location = new Point(635, 56);
            labelCurrentTimeUTC.Margin = new Padding(2, 0, 2, 0);
            labelCurrentTimeUTC.Name = "labelCurrentTimeUTC";
            labelCurrentTimeUTC.Size = new Size(97, 15);
            labelCurrentTimeUTC.TabIndex = 111;
            labelCurrentTimeUTC.Text = "current UTC time";
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.Location = new Point(10, 171);
            labelMonth.Margin = new Padding(2, 0, 2, 0);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(43, 15);
            labelMonth.TabIndex = 112;
            labelMonth.Text = "month";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(697, 101);
            labelYear.Margin = new Padding(2, 0, 2, 0);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(29, 15);
            labelYear.TabIndex = 113;
            labelYear.Text = "year";
            // 
            // labelHour
            // 
            labelHour.AutoSize = true;
            labelHour.Location = new Point(10, 290);
            labelHour.Margin = new Padding(2, 0, 2, 0);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(32, 15);
            labelHour.TabIndex = 114;
            labelHour.Text = "hour";
            // 
            // labelMinute
            // 
            labelMinute.AutoSize = true;
            labelMinute.Location = new Point(10, 351);
            labelMinute.Margin = new Padding(2, 0, 2, 0);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(45, 15);
            labelMinute.TabIndex = 115;
            labelMinute.Text = "minute";
            // 
            // labelSecond
            // 
            labelSecond.AutoSize = true;
            labelSecond.Location = new Point(10, 452);
            labelSecond.Margin = new Padding(2, 0, 2, 0);
            labelSecond.Name = "labelSecond";
            labelSecond.Size = new Size(45, 15);
            labelSecond.TabIndex = 116;
            labelSecond.Text = "second";
            // 
            // labelMS
            // 
            labelMS.AutoSize = true;
            labelMS.Location = new Point(10, 553);
            labelMS.Margin = new Padding(2, 0, 2, 0);
            labelMS.Name = "labelMS";
            labelMS.Size = new Size(23, 15);
            labelMS.TabIndex = 117;
            labelMS.Text = "ms";
            // 
            // labelEpochMS
            // 
            labelEpochMS.AutoSize = true;
            labelEpochMS.Location = new Point(58, 124);
            labelEpochMS.Margin = new Padding(2, 0, 2, 0);
            labelEpochMS.Name = "labelEpochMS";
            labelEpochMS.Size = new Size(103, 15);
            labelEpochMS.TabIndex = 118;
            labelEpochMS.Text = "epoch time w/ ms";
            // 
            // textBoxEpochMS
            // 
            textBoxEpochMS.Location = new Point(198, 122);
            textBoxEpochMS.Margin = new Padding(2);
            textBoxEpochMS.Name = "textBoxEpochMS";
            textBoxEpochMS.Size = new Size(180, 23);
            textBoxEpochMS.TabIndex = 4;
            textBoxEpochMS.TextAlign = HorizontalAlignment.Right;
            textBoxEpochMS.TextChanged += textBoxEpochMS_TextChanged;
            // 
            // panelDay
            // 
            panelDay.Location = new Point(10, 247);
            panelDay.Margin = new Padding(0);
            panelDay.Name = "panelDay";
            panelDay.Size = new Size(1240, 40);
            panelDay.TabIndex = 119;
            // 
            // panelHour
            // 
            panelHour.Location = new Point(10, 308);
            panelHour.Margin = new Padding(0);
            panelHour.Name = "panelHour";
            panelHour.Size = new Size(960, 40);
            panelHour.TabIndex = 120;
            // 
            // panelMinute
            // 
            panelMinute.Location = new Point(10, 369);
            panelMinute.Margin = new Padding(0);
            panelMinute.Name = "panelMinute";
            panelMinute.Size = new Size(1200, 80);
            panelMinute.TabIndex = 121;
            // 
            // panelSecond
            // 
            panelSecond.Location = new Point(10, 470);
            panelSecond.Margin = new Padding(0);
            panelSecond.Name = "panelSecond";
            panelSecond.Size = new Size(1200, 80);
            panelSecond.TabIndex = 122;
            // 
            // listBoxYear
            // 
            listBoxYear.FormattingEnabled = true;
            listBoxYear.Location = new Point(697, 119);
            listBoxYear.Name = "listBoxYear";
            listBoxYear.Size = new Size(61, 94);
            listBoxYear.TabIndex = 123;
            listBoxYear.TabStop = false;
            listBoxYear.SelectedIndexChanged += listBoxYear_SelectedIndexChanged;
            // 
            // textBoxMilisecond
            // 
            textBoxMilisecond.Location = new Point(10, 570);
            textBoxMilisecond.Margin = new Padding(2);
            textBoxMilisecond.Name = "textBoxMilisecond";
            textBoxMilisecond.Size = new Size(61, 23);
            textBoxMilisecond.TabIndex = 124;
            textBoxMilisecond.TabStop = false;
            textBoxMilisecond.TextAlign = HorizontalAlignment.Right;
            textBoxMilisecond.TextChanged += textBoxMilisecond_TextChanged;
            // 
            // buttonCopyEpoch
            // 
            buttonCopyEpoch.Location = new Point(382, 92);
            buttonCopyEpoch.Margin = new Padding(2);
            buttonCopyEpoch.Name = "buttonCopyEpoch";
            buttonCopyEpoch.Size = new Size(120, 24);
            buttonCopyEpoch.TabIndex = 125;
            buttonCopyEpoch.TabStop = false;
            buttonCopyEpoch.Text = "copy to clipboard";
            buttonCopyEpoch.UseVisualStyleBackColor = true;
            buttonCopyEpoch.Click += buttonCopyEpoch_Click;
            // 
            // buttonCopyDirectEntry2
            // 
            buttonCopyDirectEntry2.Location = new Point(382, 51);
            buttonCopyDirectEntry2.Margin = new Padding(2);
            buttonCopyDirectEntry2.Name = "buttonCopyDirectEntry2";
            buttonCopyDirectEntry2.Size = new Size(120, 24);
            buttonCopyDirectEntry2.TabIndex = 126;
            buttonCopyDirectEntry2.TabStop = false;
            buttonCopyDirectEntry2.Text = "copy to clipboard";
            buttonCopyDirectEntry2.UseVisualStyleBackColor = true;
            buttonCopyDirectEntry2.Click += buttonCopyDirectEntry2_Click;
            // 
            // buttonCopyEpochMS
            // 
            buttonCopyEpochMS.Location = new Point(382, 119);
            buttonCopyEpochMS.Margin = new Padding(2);
            buttonCopyEpochMS.Name = "buttonCopyEpochMS";
            buttonCopyEpochMS.Size = new Size(120, 24);
            buttonCopyEpochMS.TabIndex = 127;
            buttonCopyEpochMS.TabStop = false;
            buttonCopyEpochMS.Text = "copy to clipboard";
            buttonCopyEpochMS.UseVisualStyleBackColor = true;
            buttonCopyEpochMS.Click += buttonCopyEpochMS_Click;
            // 
            // buttonUseUTC
            // 
            buttonUseUTC.Location = new Point(904, 51);
            buttonUseUTC.Margin = new Padding(2);
            buttonUseUTC.Name = "buttonUseUTC";
            buttonUseUTC.Size = new Size(84, 24);
            buttonUseUTC.TabIndex = 128;
            buttonUseUTC.TabStop = false;
            buttonUseUTC.Text = "apply";
            buttonUseUTC.UseVisualStyleBackColor = true;
            buttonUseUTC.Click += buttonUseUTC_Click;
            // 
            // buttonPasteDirectEntry1
            // 
            buttonPasteDirectEntry1.Location = new Point(506, 24);
            buttonPasteDirectEntry1.Margin = new Padding(2);
            buttonPasteDirectEntry1.Name = "buttonPasteDirectEntry1";
            buttonPasteDirectEntry1.Size = new Size(120, 24);
            buttonPasteDirectEntry1.TabIndex = 129;
            buttonPasteDirectEntry1.TabStop = false;
            buttonPasteDirectEntry1.Text = "paste here";
            buttonPasteDirectEntry1.UseVisualStyleBackColor = true;
            buttonPasteDirectEntry1.Click += buttonPasteDirectEntry1_Click;
            // 
            // buttonPasteDirectEntry2
            // 
            buttonPasteDirectEntry2.Location = new Point(506, 51);
            buttonPasteDirectEntry2.Margin = new Padding(2);
            buttonPasteDirectEntry2.Name = "buttonPasteDirectEntry2";
            buttonPasteDirectEntry2.Size = new Size(120, 24);
            buttonPasteDirectEntry2.TabIndex = 130;
            buttonPasteDirectEntry2.TabStop = false;
            buttonPasteDirectEntry2.Text = "paste here";
            buttonPasteDirectEntry2.UseVisualStyleBackColor = true;
            buttonPasteDirectEntry2.Click += buttonPasteDirectEntry2_Click;
            // 
            // buttonPasteEpoch
            // 
            buttonPasteEpoch.Location = new Point(506, 92);
            buttonPasteEpoch.Margin = new Padding(2);
            buttonPasteEpoch.Name = "buttonPasteEpoch";
            buttonPasteEpoch.Size = new Size(120, 24);
            buttonPasteEpoch.TabIndex = 131;
            buttonPasteEpoch.TabStop = false;
            buttonPasteEpoch.Text = "paste here";
            buttonPasteEpoch.UseVisualStyleBackColor = true;
            buttonPasteEpoch.Click += buttonPasteEpoch_Click;
            // 
            // buttonPasteEpochMS
            // 
            buttonPasteEpochMS.Location = new Point(506, 119);
            buttonPasteEpochMS.Margin = new Padding(2);
            buttonPasteEpochMS.Name = "buttonPasteEpochMS";
            buttonPasteEpochMS.Size = new Size(120, 24);
            buttonPasteEpochMS.TabIndex = 132;
            buttonPasteEpochMS.TabStop = false;
            buttonPasteEpochMS.Text = "paste here";
            buttonPasteEpochMS.UseVisualStyleBackColor = true;
            buttonPasteEpochMS.Click += buttonPasteEpochMS_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(689, 570);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(299, 15);
            linkLabel1.TabIndex = 133;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/lemiges/Epoch-Time-Converter.git";
            // 
            // EpochTimeConvertor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1000, 600);
            Controls.Add(linkLabel1);
            Controls.Add(buttonPasteEpochMS);
            Controls.Add(buttonPasteEpoch);
            Controls.Add(buttonPasteDirectEntry2);
            Controls.Add(buttonPasteDirectEntry1);
            Controls.Add(buttonUseUTC);
            Controls.Add(buttonCopyEpochMS);
            Controls.Add(buttonCopyDirectEntry2);
            Controls.Add(buttonCopyEpoch);
            Controls.Add(panelDay);
            Controls.Add(textBoxMilisecond);
            Controls.Add(listBoxYear);
            Controls.Add(panelSecond);
            Controls.Add(panelMinute);
            Controls.Add(panelHour);
            Controls.Add(panelMonth);
            Controls.Add(labelEpochMS);
            Controls.Add(textBoxEpochMS);
            Controls.Add(labelMS);
            Controls.Add(labelSecond);
            Controls.Add(labelMinute);
            Controls.Add(labelHour);
            Controls.Add(labelYear);
            Controls.Add(labelMonth);
            Controls.Add(labelCurrentTimeUTC);
            Controls.Add(labelCurrentTime);
            Controls.Add(textBoxCurrentTimeUTC);
            Controls.Add(textBoxCurrentTimeLocal);
            Controls.Add(buttonCopyDirectEntry1);
            Controls.Add(buttonUseLocal);
            Controls.Add(BigCalendar);
            Controls.Add(textBoxDirectEntry2);
            Controls.Add(labelEpoch);
            Controls.Add(labelDay);
            Controls.Add(textBoxFormat2);
            Controls.Add(textBoxEpoch);
            Controls.Add(textBoxFormat1);
            Controls.Add(textBoxDirectEntry1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(0);
            MaximizeBox = false;
            Name = "EpochTimeConvertor";
            Text = "Epoch Time Converter";
            Load += EpochTimeConvertor_Load;
            ResumeLayout(false);
            PerformLayout();
        }






        #endregion
        private TextBox textBoxFormat1;
        private TextBox textBoxEpoch;
        private TextBox textBoxFormat2;
        private Label labelDay;
        private Label labelEpoch;
        private TextBox textBoxDirectEntry1;
        private TextBox textBoxDirectEntry2;
        private MonthCalendar BigCalendar;
        private Button buttonUseLocal;
        private Button buttonCopyDirectEntry1;
        private TextBox textBoxCurrentTimeLocal;
        private System.Windows.Forms.Timer CurrentTimeTimer;
        private Label labelCurrentTime;
        private TextBox textBoxCurrentTimeUTC;
        private Label labelCurrentTimeUTC;
        private Label labelMonth;
        private Label labelYear;
        private Label labelHour;
        private Label labelMinute;
        private Label labelSecond;
        private Label labelMS;
        private Label labelEpochMS;
        private TextBox textBoxEpochMS;
        private Panel panelDay;
        private Panel panelHour;
        private Panel panelMinute;
        private Panel panelSecond;
        private ListBox listBoxYear;
        private TextBox textBoxMilisecond;
        private Button buttonCopyEpoch;
        private Button buttonCopyDirectEntry2;
        private Button buttonCopyEpochMS;
        private Button buttonUseUTC;
        private Button buttonPasteDirectEntry1;
        private Button buttonPasteDirectEntry2;
        private Button buttonPasteEpoch;
        private Button buttonPasteEpochMS;
        private Panel panelMonth;
        private LinkLabel linkLabel1;
    }
}
