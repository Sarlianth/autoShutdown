namespace CWK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.themeSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.themeDefaultSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.themeBlackSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.lockMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelH = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxM
            // 
            this.textBoxM.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxM.Location = new System.Drawing.Point(102, 44);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(30, 26);
            this.textBoxM.TabIndex = 1;
            this.textBoxM.Tag = "";
            this.textBoxM.Text = "30";
            this.textBoxM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenu,
            this.lockMenu});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(227, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsMenu
            // 
            this.settingsMenu.BackColor = System.Drawing.SystemColors.Control;
            this.settingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopSettings,
            this.themeSettings,
            this.aboutSettings});
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(61, 23);
            this.settingsMenu.Text = "Settings";
            // 
            // alwaysOnTopSettings
            // 
            this.alwaysOnTopSettings.Name = "alwaysOnTopSettings";
            this.alwaysOnTopSettings.Size = new System.Drawing.Size(152, 22);
            this.alwaysOnTopSettings.Text = "AlwaysOnTop";
            this.alwaysOnTopSettings.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem1_Click);
            // 
            // themeSettings
            // 
            this.themeSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeDefaultSettings,
            this.themeBlackSettings});
            this.themeSettings.Name = "themeSettings";
            this.themeSettings.Size = new System.Drawing.Size(152, 22);
            this.themeSettings.Text = "Theme";
            // 
            // themeDefaultSettings
            // 
            this.themeDefaultSettings.Name = "themeDefaultSettings";
            this.themeDefaultSettings.Size = new System.Drawing.Size(152, 22);
            this.themeDefaultSettings.Text = "Light";
            this.themeDefaultSettings.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // themeBlackSettings
            // 
            this.themeBlackSettings.Name = "themeBlackSettings";
            this.themeBlackSettings.Size = new System.Drawing.Size(152, 22);
            this.themeBlackSettings.Text = "Dark";
            this.themeBlackSettings.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // aboutSettings
            // 
            this.aboutSettings.Name = "aboutSettings";
            this.aboutSettings.Size = new System.Drawing.Size(152, 22);
            this.aboutSettings.Text = "About";
            this.aboutSettings.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lockMenu
            // 
            this.lockMenu.Name = "lockMenu";
            this.lockMenu.Size = new System.Drawing.Size(62, 23);
            this.lockMenu.Text = "Lock PC";
            this.lockMenu.Click += new System.EventHandler(this.moreToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(157, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 65);
            this.button3.TabIndex = 5;
            this.button3.TabStop = false;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(85, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 4;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(12, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxS
            // 
            this.textBoxS.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxS.Location = new System.Drawing.Point(138, 44);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(30, 26);
            this.textBoxS.TabIndex = 2;
            this.textBoxS.Tag = "";
            this.textBoxS.Text = "00";
            this.textBoxS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxH
            // 
            this.textBoxH.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxH.Location = new System.Drawing.Point(66, 44);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(30, 26);
            this.textBoxH.TabIndex = 0;
            this.textBoxH.Tag = "";
            this.textBoxH.Text = "01";
            this.textBoxH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelH
            // 
            this.labelH.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelH.AutoSize = true;
            this.labelH.BackColor = System.Drawing.Color.Transparent;
            this.labelH.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.ForeColor = System.Drawing.Color.Black;
            this.labelH.Location = new System.Drawing.Point(-4, 14);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(0, 55);
            this.labelH.TabIndex = 13;
            this.labelH.Visible = false;
            // 
            // labelM
            // 
            this.labelM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelM.AutoSize = true;
            this.labelM.BackColor = System.Drawing.Color.Transparent;
            this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.ForeColor = System.Drawing.Color.Black;
            this.labelM.Location = new System.Drawing.Point(72, 15);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(0, 55);
            this.labelM.TabIndex = 14;
            this.labelM.Visible = false;
            // 
            // labelS
            // 
            this.labelS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelS.AutoSize = true;
            this.labelS.BackColor = System.Drawing.Color.Transparent;
            this.labelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.ForeColor = System.Drawing.Color.Black;
            this.labelS.Location = new System.Drawing.Point(152, 14);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(0, 55);
            this.labelS.TabIndex = 15;
            this.labelS.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(104, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(140, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sec";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(61, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = ":";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(138, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = ":";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 147);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoShutdown";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.ToolStripMenuItem lockMenu;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem themeSettings;
        private System.Windows.Forms.ToolStripMenuItem aboutSettings;
        private System.Windows.Forms.ToolStripMenuItem themeDefaultSettings;
        private System.Windows.Forms.ToolStripMenuItem themeBlackSettings;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopSettings;
    }
}

