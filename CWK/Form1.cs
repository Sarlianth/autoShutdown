using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Timers;

namespace CWK
{
    public partial class Form1 : Form
    {
        public ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd.exe");
        public Process proc = new Process();
        public int time, i;
        public int totalTime;
        public int hr, min, sec;

        public Form1()
        {
            InitializeComponent();
            ThemeLoader();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxH.Text.Length == 0 || !int.TryParse(textBoxM.Text, out i))
            {
                 MessageBox.Show("Only numbers allowed, try again",
                   "Warning",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation,
                   MessageBoxDefaultButton.Button1);

                textBoxH.Clear();
            }
            else if(textBoxM.Text.Length == 0 || !int.TryParse(textBoxM.Text, out i))
            {
                MessageBox.Show("Only numbers allowed, try again",
                  "Warning",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Exclamation,
                  MessageBoxDefaultButton.Button1);

                textBoxM.Clear();
            }
            else if (textBoxS.Text.Length == 0 || !int.TryParse(textBoxM.Text, out i))
            {
                MessageBox.Show("Only numbers allowed, try again",
                  "Warning",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Exclamation,
                  MessageBoxDefaultButton.Button1);

                textBoxS.Clear();
            }
            else 
            {
                //Countdown
                hr = Convert.ToInt32(textBoxH.Text);
                min = Convert.ToInt32(textBoxM.Text);
                sec = Convert.ToInt32(textBoxS.Text);
                totalTime = (hr * 60 * 60) + (min * 60) + sec;

                label4.Visible = true;
                label5.Visible = true;
                labelH.Visible = true;
                labelM.Visible = true;
                labelS.Visible = true;
                textBoxH.Visible = false;
                textBoxM.Visible = false;
                textBoxS.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                menuStrip1.Visible = false;

                timer1.Start();

                //Process
                procStartInfo.Arguments = "/C shutdown /s /t " + (totalTime);
                proc.StartInfo = procStartInfo;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();

                //Buttons + textBoxes
                textBoxM.Enabled = false;
                textBoxH.Enabled = false;
                textBoxS.Enabled = false;
                button2.Enabled = true;
                button1.Enabled = false;
                button2.Focus();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec = sec - 1;
            if (sec < 0)
            {
                min = min - 1;
                sec = 59;
            }
            else if (min < 0)
            {
                hr = hr - 1;
                min = 59;
            }

            if (hr == 0 && min == 0 && sec == 0)
            {
                timer1.Stop();
                MessageBox.Show("Times up, goodbye!", "Goodbye");
            }

            string hh = Convert.ToString(hr);
            string mm = Convert.ToString(min);
            string ss = Convert.ToString(sec);

            labelH.Text = hr.ToString("D2");
            labelM.Text = min.ToString("D2");
            labelS.Text = sec.ToString("D2");
        }   

        private void button2_Click(object sender, EventArgs e)
        {
            //Process
            procStartInfo.Arguments = "/C shutdown /a ";
            proc.StartInfo = procStartInfo;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Start();

            //GUI visibility
            button2.Enabled = false;
            labelH.Visible = false;
            labelM.Visible = false;
            labelS.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            textBoxH.Visible = true;
            textBoxM.Visible = true;
            textBoxS.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            menuStrip1.Visible = true;
            textBoxM.Enabled = true;
            textBoxS.Enabled = true;
            textBoxH.Enabled = true;
            button1.Enabled = true;
            
            timer1.Stop();
            button1.Focus();
        }


        private void moreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "user32.dll, LockWorkStation";
            ProcessStartInfo procStartInfo = new ProcessStartInfo("rundll32.exe");
            Process proc = new Process();
            procStartInfo.Arguments = strCmdText;
            proc.StartInfo = procStartInfo;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Start();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TopMost == true)
            {
                this.TopMost = false;
            }
            else if (this.TopMost == false)
            {
                this.TopMost = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 helpForm = new Form2();
            helpForm.Show();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //////background//////
            this.BackColor = SystemColors.InactiveCaptionText;
            menuStrip1.BackColor = SystemColors.InactiveCaptionText;
            /////button1 - set/////
            button1.BackColor = System.Drawing.Color.Orange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Desktop;
            button1.Font = new Font(this.Font, FontStyle.Bold);
            button1.FlatAppearance.BorderSize = 0;
            //////button2 - stop//////
            button2.BackColor = System.Drawing.Color.Orange;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Desktop;
            button2.Font = new Font(this.Font, FontStyle.Bold);
            button2.FlatAppearance.BorderSize = 0;
            //////button3 - quit//////
            button3.BackColor = System.Drawing.Color.Orange;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.Desktop;
            button3.Font = new Font(this.Font, FontStyle.Bold);
            button3.FlatAppearance.BorderSize = 0;
            //////labels//////
            label1.ForeColor = System.Drawing.Color.Orange;
            label2.ForeColor = System.Drawing.Color.Orange;
            label3.ForeColor = System.Drawing.Color.Orange;
            label1.Font = new Font(this.Font, FontStyle.Bold);
            label2.Font = new Font(this.Font, FontStyle.Bold);
            label3.Font = new Font(this.Font, FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.Orange;
            label5.ForeColor = System.Drawing.Color.Orange;
            labelH.ForeColor = System.Drawing.Color.Orange;
            labelM.ForeColor = System.Drawing.Color.Orange;
            labelS.ForeColor = System.Drawing.Color.Orange;
            //////textboxes//////
            textBoxH.BackColor = SystemColors.InactiveCaption;
            textBoxM.BackColor = SystemColors.InactiveCaption;
            textBoxS.BackColor = SystemColors.InactiveCaption;
            textBoxH.BorderStyle = BorderStyle.None;
            textBoxM.BorderStyle = BorderStyle.None;
            textBoxS.BorderStyle = BorderStyle.None;
            ///////menus//////
            settingsMenu.BackColor = SystemColors.InactiveCaptionText;
            alwaysOnTopSettings.BackColor = SystemColors.InactiveCaptionText;
            themeSettings.BackColor = SystemColors.InactiveCaptionText;
            aboutSettings.BackColor = SystemColors.InactiveCaptionText;
            themeDefaultSettings.BackColor = SystemColors.InactiveCaptionText;
            themeBlackSettings.BackColor = SystemColors.InactiveCaptionText;
            alwaysOnTopSettings.ForeColor = System.Drawing.Color.Orange;
            themeSettings.ForeColor = System.Drawing.Color.Orange;
            aboutSettings.ForeColor = System.Drawing.Color.Orange;
            themeDefaultSettings.ForeColor = System.Drawing.Color.Orange;
            themeBlackSettings.ForeColor = System.Drawing.Color.Orange;
            settingsMenu.ForeColor = System.Drawing.Color.Orange;
            lockMenu.ForeColor = System.Drawing.Color.Orange;
            themeDefaultSettings.Checked = false;
            themeBlackSettings.Checked = true;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //////background//////
            this.BackColor = SystemColors.Control;
            menuStrip1.BackColor = SystemColors.Control;
            /////button1 - set/////
            button1.BackColor = SystemColors.Control;
            button1.FlatStyle = FlatStyle.Standard;
            button1.ForeColor = System.Drawing.Color.Green;
            button1.Font = default(Font);
            button1.FlatAppearance.BorderSize = 1;
            //////button2 - stop//////
            button2.BackColor = SystemColors.Control;
            button2.FlatStyle = FlatStyle.Standard;
            button2.ForeColor = System.Drawing.Color.Green;
            button2.Font = default(Font);
            button2.FlatAppearance.BorderSize = 1;
            //////button3 - quit//////
            button3.BackColor = SystemColors.Control;
            button3.FlatStyle = FlatStyle.Standard;
            button3.ForeColor = System.Drawing.Color.Green;
            button3.Font = default(Font);
            button3.FlatAppearance.BorderSize = 1;
            //////labels//////
            label1.ForeColor = System.Drawing.Color.Black;
            label2.ForeColor = System.Drawing.Color.Black;
            label3.ForeColor = System.Drawing.Color.Black;
            label1.Font = default(Font);
            label2.Font = default(Font);
            label3.Font = default(Font);
            label4.ForeColor = System.Drawing.Color.Black;
            label5.ForeColor = System.Drawing.Color.Black;
            labelH.ForeColor = System.Drawing.Color.Black;
            labelM.ForeColor = System.Drawing.Color.Black;
            labelS.ForeColor = System.Drawing.Color.Black;
            //////textboxes//////
            textBoxH.BackColor = SystemColors.Window;
            textBoxM.BackColor = SystemColors.Window;
            textBoxS.BackColor = SystemColors.Window;
            textBoxH.BorderStyle = BorderStyle.Fixed3D;
            textBoxM.BorderStyle = BorderStyle.Fixed3D;
            textBoxS.BorderStyle = BorderStyle.Fixed3D;
            ///////menus//////
            settingsMenu.BackColor = SystemColors.Control;
            alwaysOnTopSettings.BackColor = SystemColors.Control;
            themeSettings.BackColor = SystemColors.Control;
            aboutSettings.BackColor = SystemColors.Control;
            themeDefaultSettings.BackColor = SystemColors.Control;
            themeBlackSettings.BackColor = SystemColors.Control;
            settingsMenu.ForeColor = SystemColors.ControlText;
            alwaysOnTopSettings.ForeColor = SystemColors.ControlText;
            themeSettings.ForeColor = SystemColors.ControlText;
            aboutSettings.ForeColor = SystemColors.ControlText;
            themeDefaultSettings.ForeColor = SystemColors.ControlText;
            themeBlackSettings.ForeColor = SystemColors.ControlText;
            lockMenu.ForeColor = SystemColors.ControlText;
            themeDefaultSettings.Checked = true;
            themeBlackSettings.Checked = false;
        }

        private void alwaysOnTopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.TopMost == true)
            {
                this.TopMost = false;
                alwaysOnTopSettings.Checked = false;
            }
            else if (this.TopMost == false)
            {
                this.TopMost = true;
                alwaysOnTopSettings.Checked = true;
            }
        }
        public void ThemeLoader()
        {
            //////background//////
            this.BackColor = SystemColors.InactiveCaptionText;
            menuStrip1.BackColor = SystemColors.InactiveCaptionText;
            /////button1 - set/////
            button1.BackColor = System.Drawing.Color.Orange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Desktop;
            button1.Font = new Font(this.Font, FontStyle.Bold);
            button1.FlatAppearance.BorderSize = 0;
            //////button2 - stop//////
            button2.BackColor = System.Drawing.Color.Orange;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Desktop;
            button2.Font = new Font(this.Font, FontStyle.Bold);
            button2.FlatAppearance.BorderSize = 0;
            //////button3 - quit//////
            button3.BackColor = System.Drawing.Color.Orange;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.Desktop;
            button3.Font = new Font(this.Font, FontStyle.Bold);
            button3.FlatAppearance.BorderSize = 0;
            //////labels//////
            label1.ForeColor = System.Drawing.Color.Orange;
            label2.ForeColor = System.Drawing.Color.Orange;
            label3.ForeColor = System.Drawing.Color.Orange;
            label1.Font = new Font(this.Font, FontStyle.Bold);
            label2.Font = new Font(this.Font, FontStyle.Bold);
            label3.Font = new Font(this.Font, FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.Orange;
            label5.ForeColor = System.Drawing.Color.Orange;
            labelH.ForeColor = System.Drawing.Color.Orange;
            labelM.ForeColor = System.Drawing.Color.Orange;
            labelS.ForeColor = System.Drawing.Color.Orange;
            //////textboxes//////
            textBoxH.BackColor = SystemColors.InactiveCaption;
            textBoxM.BackColor = SystemColors.InactiveCaption;
            textBoxS.BackColor = SystemColors.InactiveCaption;
            textBoxH.BorderStyle = BorderStyle.None;
            textBoxM.BorderStyle = BorderStyle.None;
            textBoxS.BorderStyle = BorderStyle.None;
            ///////menus//////
            settingsMenu.BackColor = SystemColors.InactiveCaptionText;
            alwaysOnTopSettings.BackColor = SystemColors.InactiveCaptionText;
            themeSettings.BackColor = SystemColors.InactiveCaptionText;
            aboutSettings.BackColor = SystemColors.InactiveCaptionText;
            themeDefaultSettings.BackColor = SystemColors.InactiveCaptionText;
            themeBlackSettings.BackColor = SystemColors.InactiveCaptionText;
            alwaysOnTopSettings.ForeColor = System.Drawing.Color.Orange;
            themeSettings.ForeColor = System.Drawing.Color.Orange;
            aboutSettings.ForeColor = System.Drawing.Color.Orange;
            themeDefaultSettings.ForeColor = System.Drawing.Color.Orange;
            themeBlackSettings.ForeColor = System.Drawing.Color.Orange;
            settingsMenu.ForeColor = System.Drawing.Color.Orange;
            lockMenu.ForeColor = System.Drawing.Color.Orange;
            themeDefaultSettings.Checked = false;
            themeBlackSettings.Checked = true;
        }
        
    }
}
