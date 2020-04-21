using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib;
using CmlLib.Core;
using System.Diagnostics;

namespace ClearSky_LauncherR1
{
    public partial class LauncherMain : Form
    {

        Process p;

        public LauncherMain()
        {
            InitializeComponent();
        }

        private void LauncherMain_Load(object sender, EventArgs e)
        {
        }

        private void launch_Click(object sender, EventArgs e)
        {
            launch.Enabled = false;

            //var path = new Minecraft("your minecraft directory);
            var path = Minecraft.GetOSDefaultPath(); // mc directory
            
            var launcher = new CmlLib.CMLauncher(path);
            launcher.ProgressChanged += (s, ev) =>
            {
                Console.WriteLine("{0}%", ev.ProgressPercentage);
                progressBar1.Value = ev.ProgressPercentage;
            };
            launcher.FileChanged += (ev) =>
            {
                string txt = String.Format("[{0}] {1} - {2}/{3}", ev.FileKind.ToString(), ev.FileName, ev.ProgressedFileCount, ev.TotalFileCount);
                Console.WriteLine(txt);
                progress.Text = txt;
            };


            var launchOption = new MLaunchOption
            {
                MaximumRamMb = c.maxRam,
                Session = c.session, // Login Session. ex) Session = MSession.GetOfflineSession("hello")

                GameLauncherName = "ClearSky",
                ScreenHeight = c.screenHeight,
                ScreenWidth = c.screenWidth,
                //ServerIp = "chocu.kro.kr"
            };

            // launch forge
            //var process = launcher.Launch("1.12.2", "14.23.5.2768", launchOption);

            p = launcher.CreateProcess("1.15.2", launchOption);

            p.Exited += P_Exited;

            p.Start();
        }

        private void P_Exited(object sender, EventArgs e)
        {
            launch.Enabled = true;
            MessageBox.Show("마인크래프트가 꺼졌습니다. Code: " + p.ExitCode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                Int32.Parse(maxMemText.Text);
                Int32.Parse(screenSizeXText.Text);
                Int32.Parse(screenSizeYText.Text);

                MessageBox.Show(c.getConfig("screenWidth"));

                c.setConfig("maxMem", maxMemText.Text);
                c.setConfig("screenWidth", screenSizeXText.Text);
                c.setConfig("screenHeight", screenSizeYText.Text);

                c.info("작업을 완료하였습니다.");
            }
            catch (FormatException ex) {
                c.error("올바르지 않은 정수입니다.");
            }

        }

        private void setting_Click(object sender, EventArgs e)
        {

        }

        private void Check_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
