namespace ClearSky_LauncherR1
{
    partial class LauncherMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherMain));
            this.mainText = new System.Windows.Forms.Label();
            this.launch = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.Announcement = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Update = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.BBS = new System.Windows.Forms.TabPage();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.KMC = new System.Windows.Forms.TabPage();
            this.webBrowser5 = new System.Windows.Forms.WebBrowser();
            this.setting = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.screenSizeYText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.screenSizeXText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxMemText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tab.SuspendLayout();
            this.Announcement.SuspendLayout();
            this.Update.SuspendLayout();
            this.BBS.SuspendLayout();
            this.KMC.SuspendLayout();
            this.setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.mainText.Location = new System.Drawing.Point(88, 14);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(234, 37);
            this.mainText.TabIndex = 0;
            this.mainText.Text = "환영합니다! {0}님!";
            // 
            // launch
            // 
            this.launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.launch.Location = new System.Drawing.Point(280, 456);
            this.launch.Name = "launch";
            this.launch.Size = new System.Drawing.Size(265, 45);
            this.launch.TabIndex = 1;
            this.launch.Text = "오늘도 모험하러 가볼까요?";
            this.launch.UseVisualStyleBackColor = true;
            this.launch.Click += new System.EventHandler(this.launch_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.Announcement);
            this.tab.Controls.Add(this.Update);
            this.tab.Controls.Add(this.BBS);
            this.tab.Controls.Add(this.KMC);
            this.tab.Controls.Add(this.setting);
            this.tab.Location = new System.Drawing.Point(21, 61);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(767, 329);
            this.tab.TabIndex = 2;
            // 
            // Announcement
            // 
            this.Announcement.Controls.Add(this.webBrowser1);
            this.Announcement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Announcement.Location = new System.Drawing.Point(4, 22);
            this.Announcement.Name = "Announcement";
            this.Announcement.Padding = new System.Windows.Forms.Padding(3);
            this.Announcement.Size = new System.Drawing.Size(759, 303);
            this.Announcement.TabIndex = 0;
            this.Announcement.Text = "게임소식";
            this.Announcement.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(753, 297);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://clearsky.xyz/introduction.jsp", System.UriKind.Absolute);
            // 
            // Update
            // 
            this.Update.Controls.Add(this.webBrowser2);
            this.Update.Location = new System.Drawing.Point(4, 22);
            this.Update.Name = "Update";
            this.Update.Padding = new System.Windows.Forms.Padding(3);
            this.Update.Size = new System.Drawing.Size(759, 303);
            this.Update.TabIndex = 1;
            this.Update.Text = "업데이트";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(753, 297);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.Url = new System.Uri("http://clearsky.xyz/bbs.jsp?tag=업데이트", System.UriKind.Absolute);
            // 
            // BBS
            // 
            this.BBS.Controls.Add(this.webBrowser3);
            this.BBS.Location = new System.Drawing.Point(4, 22);
            this.BBS.Name = "BBS";
            this.BBS.Size = new System.Drawing.Size(759, 303);
            this.BBS.TabIndex = 2;
            this.BBS.Text = "사이트 새 글";
            this.BBS.UseVisualStyleBackColor = true;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(0, 0);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(759, 303);
            this.webBrowser3.TabIndex = 0;
            this.webBrowser3.Url = new System.Uri("http://clearsky.xyz/bbs.jsp", System.UriKind.Absolute);
            // 
            // KMC
            // 
            this.KMC.Controls.Add(this.webBrowser5);
            this.KMC.Location = new System.Drawing.Point(4, 22);
            this.KMC.Name = "KMC";
            this.KMC.Size = new System.Drawing.Size(759, 303);
            this.KMC.TabIndex = 4;
            this.KMC.Text = "한마포 커뮤니티";
            this.KMC.UseVisualStyleBackColor = true;
            // 
            // webBrowser5
            // 
            this.webBrowser5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser5.Location = new System.Drawing.Point(0, 0);
            this.webBrowser5.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser5.Name = "webBrowser5";
            this.webBrowser5.Size = new System.Drawing.Size(759, 303);
            this.webBrowser5.TabIndex = 0;
            this.webBrowser5.Url = new System.Uri("https://www.koreaminecraft.net/jellyrpg", System.UriKind.Absolute);
            // 
            // setting
            // 
            this.setting.Controls.Add(this.label3);
            this.setting.Controls.Add(this.screenSizeYText);
            this.setting.Controls.Add(this.label2);
            this.setting.Controls.Add(this.screenSizeXText);
            this.setting.Controls.Add(this.label1);
            this.setting.Controls.Add(this.maxMemText);
            this.setting.Controls.Add(this.button2);
            this.setting.Location = new System.Drawing.Point(4, 22);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(759, 303);
            this.setting.TabIndex = 5;
            this.setting.Text = "설정";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(227, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // screenSizeYText
            // 
            this.screenSizeYText.Location = new System.Drawing.Point(254, 87);
            this.screenSizeYText.Name = "screenSizeYText";
            this.screenSizeYText.Size = new System.Drawing.Size(41, 21);
            this.screenSizeYText.TabIndex = 5;
            this.screenSizeYText.Text = "600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(176, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "화면 크기";
            // 
            // screenSizeXText
            // 
            this.screenSizeXText.Location = new System.Drawing.Point(180, 87);
            this.screenSizeXText.Name = "screenSizeXText";
            this.screenSizeXText.Size = new System.Drawing.Size(41, 21);
            this.screenSizeXText.TabIndex = 3;
            this.screenSizeXText.Text = "800";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "최대 메모리(MB)";
            // 
            // maxMemText
            // 
            this.maxMemText.Location = new System.Drawing.Point(16, 87);
            this.maxMemText.Name = "maxMemText";
            this.maxMemText.Size = new System.Drawing.Size(121, 21);
            this.maxMemText.TabIndex = 1;
            this.maxMemText.Text = "2480";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 44);
            this.button2.TabIndex = 0;
            this.button2.Text = "적용";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.progress.Location = new System.Drawing.Point(23, 393);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(185, 24);
            this.progress.TabIndex = 3;
            this.progress.Text = "실행중인 프로그래스 없음";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 427);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(764, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = global::ClearSky_LauncherR1.Properties.Resources.d2b8a7a677edbcab;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(681, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClearSky_LauncherR1.Properties.Resources.server_icon;
            this.pictureBox1.Location = new System.Drawing.Point(612, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LauncherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.launch);
            this.Controls.Add(this.mainText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LauncherMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClearSky";
            this.Load += new System.EventHandler(this.LauncherMain_Load);
            this.tab.ResumeLayout(false);
            this.Announcement.ResumeLayout(false);
            this.Update.ResumeLayout(false);
            this.BBS.ResumeLayout(false);
            this.KMC.ResumeLayout(false);
            this.setting.ResumeLayout(false);
            this.setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainText;
        private System.Windows.Forms.Button launch;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage Announcement;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage Update;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.TabPage BBS;
        private System.Windows.Forms.TabPage KMC;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.WebBrowser webBrowser5;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage setting;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxMemText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox screenSizeYText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox screenSizeXText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}