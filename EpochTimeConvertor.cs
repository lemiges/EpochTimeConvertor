using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class EpochTimeConvertor : Form
    {
        public EpochTimeConvertor()
        {
            //AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();

            //---------------------

            float scale = CreateGraphics().DpiX / 96f;
            int scaled30 = (int)(30 * scale);

            for (int i = 1970; i <= 2070; i++)
            {
                listBoxYear.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                RadioButton radioButton = new();
                RadioButton rb = radioButton;
                rb.Appearance = Appearance.Button;
                rb.FlatAppearance.CheckedBackColor = Color.LightGreen;
                rb.Location = new Point((i - 1) * scaled30 - 1, -1);
                rb.Margin = new Padding(0);
                rb.Padding = new Padding(0);
                rb.Size = new Size(scaled30, scaled30);
                rb.TabIndex = 200 + i;
                rb.TabStop = false;
                rb.Text = i.ToString();
                rb.TextAlign = ContentAlignment.MiddleCenter;
                rb.UseVisualStyleBackColor = true;
                rb.CheckedChanged += radioButtonMonth_CheckedChanged;
                panelMonth.Controls.Add(rb);
            }

            for (int i = 1; i <= 31; i++)
            {
                RadioButton radioButton = new();
                RadioButton rb = radioButton;
                rb.Appearance = Appearance.Button;
                rb.FlatAppearance.CheckedBackColor = Color.LightGreen;
                rb.Location = new Point((i - 1) * scaled30 - 1, -1);
                rb.Margin = new Padding(0);
                rb.Padding = new Padding(0);
                rb.Size = new Size(scaled30, scaled30);
                rb.TabIndex = 300 + i;
                rb.TabStop = false;
                rb.Text = i.ToString();
                rb.TextAlign = ContentAlignment.MiddleCenter;
                rb.UseVisualStyleBackColor = true;
                rb.CheckedChanged += radioButtonDay_CheckedChanged;
                panelDay.Controls.Add(rb);
            }

            for (int i = 1; i <= 24; i++)
            {
                RadioButton radioButton = new();
                RadioButton rb = radioButton;
                rb.Appearance = Appearance.Button;
                rb.FlatAppearance.CheckedBackColor = Color.LightGreen;
                rb.Location = new Point((i - 1) * scaled30 - 1, -1);
                rb.Margin = new Padding(0);
                rb.Padding = new Padding(0);
                rb.Size = new Size(scaled30, scaled30);
                rb.TabIndex = 400 + i; 
                rb.TabStop = false;
                rb.Text = i.ToString();
                rb.TextAlign = ContentAlignment.MiddleCenter;
                rb.UseVisualStyleBackColor = true;
                rb.CheckedChanged += radioButtonHour_CheckedChanged;
                panelHour.Controls.Add(rb);
            }

            for (int i = 1; i <= 60; i++)
            {
                RadioButton radioButton = new();
                RadioButton rb = radioButton;
                rb.Appearance = Appearance.Button;
                rb.FlatAppearance.CheckedBackColor = Color.LightGreen;
                if (i <= 30)
                    rb.Location = new Point((i - 1) * scaled30 - 1, -1);
                else
                    rb.Location = new Point((i - 31) * scaled30 - 1, scaled30 - 1);
                rb.Margin = new Padding(0);
                rb.Padding = new Padding(0);
                rb.Size = new Size(scaled30, scaled30);
                rb.TabIndex = 500 + i;
                rb.TabStop = false;
                rb.Text = i.ToString();
                rb.TextAlign = ContentAlignment.MiddleCenter;
                rb.UseVisualStyleBackColor = true;
                rb.CheckedChanged += radioButtonMinute_CheckedChanged;
                panelMinute.Controls.Add(rb);
            }


            for (int i = 1; i <= 60; i++)
            {
                RadioButton radioButton = new();
                RadioButton rb = radioButton;
                rb.Appearance = Appearance.Button;
                rb.FlatAppearance.CheckedBackColor = Color.LightGreen;
                if (i <= 30)
                    rb.Location = new Point((i - 1) * scaled30 - 1, -1);
                else
                    rb.Location = new Point((i - 31) * scaled30 - 1, scaled30 - 1);
                rb.Margin = new Padding(0);
                rb.Padding = new Padding(0);
                rb.Size = new Size(scaled30, scaled30);
                rb.TabIndex = 600 + i;
                rb.TabStop = false;
                rb.Text = i.ToString();
                rb.TextAlign = ContentAlignment.MiddleCenter;
                rb.UseVisualStyleBackColor = true;
                rb.CheckedChanged += radioButtonSecond_CheckedChanged;
                panelSecond.Controls.Add(rb);
            }
            
            //------------------------


        }

        private void EpochTimeConvertor_Load(object sender, EventArgs e)
        {
            var config = ConfigManager.LoadConfig();
            textBoxFormat1.Text = config.Format1;
            textBoxFormat2.Text = config.Format2;
            RefreshControls("other");
        }

        public void RefreshControls(string sender)
        {
            DateTime dt;
            try
            {
                dt = new DateTime(InternalDT.yy, InternalDT.MM, InternalDT.dd, InternalDT.HH, InternalDT.mm, InternalDT.ss, InternalDT.ff);
            }
            catch
            {
                return;
            }

            if (sender == "other" || sender != "DirectEntry1")
            {
                try
                {
                    textBoxDirectEntry1.Text = dt.ToString(textBoxFormat1.Text);
                } 
                catch
                {
                    textBoxDirectEntry1.Text = "wrong format";
                    return ;
                }
            }

            if (sender == "other" || sender != "DirectEntry2")
            {
                try
                {
                    textBoxDirectEntry2.Text = dt.ToString(textBoxFormat2.Text);
                }
                catch
                {
                    textBoxDirectEntry2.Text = "wrong format";
                    return;
                }
            }

            if (sender == "other" || sender != "Epoch")
            {
                DateTimeOffset dateTimeOffset = new(dt, TimeSpan.Zero);
                textBoxEpoch.Text = dateTimeOffset.ToUnixTimeSeconds().ToString();
            }

            if (sender == "other" || sender != "EpochMS")
            {
                DateTimeOffset dateTimeOffset = new(dt, TimeSpan.Zero);
                textBoxEpochMS.Text = dateTimeOffset.ToUnixTimeMilliseconds().ToString();
            }

            if (sender == "other" || sender != "listBoxYear")
            {
                listBoxYear.SelectedItem = InternalDT.yy;
            }


            if (sender == "other" || sender != "radioButtonMonth")
            {
                foreach (RadioButton rb in panelMonth.Controls)
                {
                    if (rb.Text == InternalDT.MM.ToString())
                    {
                        rb.Checked = true;
                    }
                }
            }

            if (sender == "other" || sender != "radioButtonDay")
            {
                foreach (RadioButton rb in panelDay.Controls)
                {
                    if (rb.Text == InternalDT.dd.ToString())
                    {
                        rb.Checked = true;
                    }
                }
            }

            if (sender == "other" || sender != "radioButtonHour")
            {
                foreach (RadioButton rb in panelHour.Controls)
                {
                    if (rb.Text == InternalDT.HH.ToString())
                    {
                        rb.Checked = true;
                    }
                }
            }

            if (sender == "other" || sender != "radioButtonMinute")
            {
                foreach (RadioButton rb in panelMinute.Controls)
                {
                    if (rb.Text == InternalDT.mm.ToString())
                    {
                        rb.Checked = true;
                    }
                }
            }

            if (sender == "other" || sender != "radioButtonSecond")
            {
                foreach (RadioButton rb in panelSecond.Controls)
                {
                    if (rb.Text == InternalDT.ss.ToString())
                    {
                        rb.Checked = true;
                    }
                }
            }

            if (sender == "other" || sender != "textBoxMilisecond")
            {
                textBoxMilisecond.Text = InternalDT.ff.ToString().PadLeft(3, '0');
            }

            if (sender == "other" || sender != "BigCalendar")
            {

                BigCalendar.SelectionStart = dt;
            }
        }

        private void CurrentTimeTimer_Tick(object sender, EventArgs e)
        {
            textBoxCurrentTimeLocal.Text = DateTime.Now.ToString(textBoxFormat1.Text);
            textBoxCurrentTimeUTC.Text = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString(textBoxFormat1.Text);
        }

        private void buttonUseLocal_Click(object sender, EventArgs e)
        {
            InternalDT.yy = DateTime.Now.Year;
            InternalDT.MM = DateTime.Now.Month;
            InternalDT.dd = DateTime.Now.Day;
            InternalDT.HH = DateTime.Now.Hour;
            InternalDT.mm = DateTime.Now.Minute;
            InternalDT.ss = DateTime.Now.Second;
            InternalDT.ff = DateTime.Now.Millisecond;

            RefreshControls("other");
        }

        private void buttonUseUTC_Click(object sender, EventArgs e)
        {
            textBoxDirectEntry1.Text = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString(textBoxFormat1.Text);

            InternalDT.yy = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).Year;
            InternalDT.MM = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).Month;
            InternalDT.dd = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).Day;
            InternalDT.HH = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).Hour;
            InternalDT.mm = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).Minute;
            InternalDT.ss = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).Second;
            InternalDT.ff = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).Millisecond;

            RefreshControls("other");
        }


        private void textBoxDirectEntry1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDirectEntry1.Focused)
            {
                try
                {
                    DateTime dt = DateTime.ParseExact(textBoxDirectEntry1.Text, textBoxFormat1.Text, CultureInfo.InvariantCulture);
                    InternalDT.yy = dt.Year;
                    InternalDT.MM = dt.Month;
                    InternalDT.dd = dt.Day;
                    InternalDT.HH = dt.Hour;
                    InternalDT.mm = dt.Minute;
                    InternalDT.ss = dt.Second;
                    InternalDT.ff = dt.Millisecond;

                    RefreshControls("DirectEntry1");
                }
                catch
                {
                    return;
                }
            }

        }


        private void textBoxDirectEntry2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDirectEntry2.Focused)
            {
                try
                {
                    DateTime dt = DateTime.ParseExact(textBoxDirectEntry2.Text, textBoxFormat2.Text, CultureInfo.InvariantCulture);
                    InternalDT.yy = dt.Year;
                    InternalDT.MM = dt.Month;
                    InternalDT.dd = dt.Day;
                    InternalDT.HH = dt.Hour;
                    InternalDT.mm = dt.Minute;
                    InternalDT.ss = dt.Second;
                    InternalDT.ff = dt.Millisecond;

                    RefreshControls("DirectEntry2");
                }
                catch
                {
                    return;
                }
            }

        }

        private void textBoxEpoch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEpoch.Focused)
            {
                try
                {
                    int iss = int.Parse(textBoxEpoch.Text);
                    DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local).AddSeconds(iss);

                    InternalDT.yy = dt.Year;
                    InternalDT.MM = dt.Month;
                    InternalDT.dd = dt.Day;
                    InternalDT.HH = dt.Hour;
                    InternalDT.mm = dt.Minute;
                    InternalDT.ss = dt.Second;
                    InternalDT.ff = dt.Millisecond;

                    RefreshControls("Epoch");
                }
                catch
                {
                    return;
                }
            }
        }

        private void textBoxEpochMS_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEpochMS.Focused)
            {
                try
                {
                    int iss = int.Parse(textBoxEpochMS.Text);
                    DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local).AddSeconds(iss);

                    InternalDT.yy = dt.Year;
                    InternalDT.MM = dt.Month;
                    InternalDT.dd = dt.Day;
                    InternalDT.HH = dt.Hour;
                    InternalDT.mm = dt.Minute;
                    InternalDT.ss = dt.Second;
                    InternalDT.ff = dt.Millisecond;

                    RefreshControls("EpochMS");
                }
                catch
                {
                    return;
                }
            }
        }

        private void listBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxYear.Focused)
            {
                try
                {
                    int iyy = int.Parse(listBoxYear.Text);
                    InternalDT.yy = iyy;
                    RefreshControls("listBoxYear");
                }
                catch
                {
                    return;
                }

            }
        }


        private void radioButtonMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is not RadioButton rb)
            {
                return;
            }

            if (rb.Focused && rb.Checked)
            {
                int iMM = int.Parse(rb.Text);
                InternalDT.MM = iMM;

                RefreshControls("radioButtonMonth");

            }
        }

        private void radioButtonDay_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is not RadioButton rb)
            {
                return;
            }

            if (rb.Focused && rb.Checked)
            {
                int idd = int.Parse(rb.Text);
                InternalDT.dd = idd;

                RefreshControls("radioButtonDay");

            }
        }


        private void radioButtonHour_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is not RadioButton rb)
            {
                return;
            }

            if (rb.Focused && rb.Checked)
            {
                int iHH = int.Parse(rb.Text);
                InternalDT.HH = iHH;

                RefreshControls("radioButtonHour");

            }
        }

        private void radioButtonMinute_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is not RadioButton rb)
            {
                return;
            }

            if (rb.Focused && rb.Checked)
            {
                int imm = int.Parse(rb.Text);
                InternalDT.mm = imm;

                RefreshControls("radioButtonMinute");

            }
        }

        private void radioButtonSecond_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is not RadioButton rb)
            {
                return;
            }

            if (rb.Focused && rb.Checked)
            {
                int iss = int.Parse(rb.Text);
                InternalDT.ss = iss;

                RefreshControls("radioButtonSecond");

            }
        }

        private void textBoxMilisecond_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMilisecond.Focused)
            {
                try
                {
                    int iff = int.Parse(textBoxMilisecond.Text);
                    InternalDT.ff = iff;
                    RefreshControls("textBoxMilisecond");
                }
                catch
                {
                    return;
                }

            }
        }

        private void BigCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (BigCalendar.Focused)
            {
                DateTime dt = BigCalendar.SelectionStart;
                InternalDT.yy = dt.Year;
                InternalDT.MM = dt.Month;
                InternalDT.dd = dt.Day;

                RefreshControls("BigCalendar");
            }
        }

        private void textBoxFormat_TextChanged(object sender, EventArgs e)
        {
            var currentConfig = new AppConfig
            {
                Format1 = textBoxFormat1.Text,
                Format2 = textBoxFormat2.Text,
            };
            ConfigManager.SaveConfig(currentConfig);
            RefreshControls("other");
        }

        private void buttonCopyDirectEntry1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDirectEntry1.Text);
        }

        private void buttonCopyDirectEntry2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDirectEntry2.Text);
        }

        private void buttonCopyEpoch_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxEpoch.Text);
        }

        private void buttonCopyEpochMS_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxEpochMS.Text);
        }

        private void buttonPasteDirectEntry1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBoxDirectEntry1.Focus();
                textBoxDirectEntry1.Text = Clipboard.GetText();
            }
        }

        private void buttonPasteDirectEntry2_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBoxDirectEntry2.Focus();
                textBoxDirectEntry2.Text = Clipboard.GetText();
            }
        }

        private void buttonPasteEpoch_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBoxEpoch.Focus();
                textBoxEpoch.Text = Clipboard.GetText();
            }
        }

        private void buttonPasteEpochMS_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBoxEpochMS.Focus();
                textBoxEpochMS.Text = Clipboard.GetText();
            }
        }
    }
}


[Serializable]
public class AppConfig
{
    public string Format1 { get; set; } = "";
    public string Format2 { get; set; } = "";
}

public static class ConfigManager
{
    public static string ConfigFilePath => Path.Combine(AppContext.BaseDirectory, "config.xml");

    public static AppConfig LoadConfig()
    {
        var defaultConfig = new AppConfig
        {
            Format1 = "d.M.yyyy HH:mm:ss.fff",
            Format2 = "yyyy-MM-dd HH:mm:ss"
        };

        if (!File.Exists(ConfigFilePath))
        {
            return defaultConfig;
        }

        using var stream = File.OpenRead(ConfigFilePath);
        XmlSerializer serializer = new(typeof(AppConfig));
        AppConfig? loadedConfig = serializer.Deserialize(stream) as AppConfig;

        if (loadedConfig != null)
        {
            return loadedConfig as AppConfig;
        }
        else
        {
            return defaultConfig;
        }
    }

    public static void SaveConfig(AppConfig config)
    {
        using (var stream = File.Create(ConfigFilePath))
        {
            XmlSerializer serializer = new(typeof(AppConfig));
            serializer.Serialize(stream, config);
        }
    }
}

public class InternalDT
{
    public static int yy { get; set; } = DateTime.Now.Year;
    public static int MM { get; set; } = DateTime.Now.Month;
    public static int dd { get; set; } = DateTime.Now.Day;
    public static int HH { get; set; } = DateTime.Now.Hour;
    public static int mm { get; set; } = DateTime.Now.Minute;
    public static int ss { get; set; } = DateTime.Now.Second;
    public static int ff { get; set; } = DateTime.Now.Millisecond;
}

