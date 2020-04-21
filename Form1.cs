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

namespace ClearSky_LauncherR1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            /*c.login = new MLogin();

            session = login.TryAutoLogin();
            Console.WriteLine(session.Result);

            if (session.Result != MLoginResult.Success)
            {
                session = login.Authenticate(
                     EmAIL.Text,
                     password.Text);

                if (session.Result != MLoginResult.Success)
                    throw new Exception("로그인 실패 : " + session.Result.ToString());
            }*/


            //c.maxRam = 2480;
            c.screenHeight = int.Parse(c.getConfig("screenHeight"));
            c.screenWidth = int.Parse(c.getConfig("screenWidth"));
            c.maxRam = int.Parse(c.getConfig("maxMem"));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            c.session = c.login.Authenticate(
                     EmAIL.Text,
                     password.Text);

            if (c.session.Result != MLoginResult.Success)
            {
                c.error("로그인에 실패하였습니다. 사유: " + c.session.Result);
            }
            else {

                

                c.info("환영합니다! " + c.session.Username + "님!");
                c.loginSuccess(this);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
