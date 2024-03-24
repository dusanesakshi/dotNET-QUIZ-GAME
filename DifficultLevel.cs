using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNET_QUIZ_GAME
{
    public partial class DifficultLevel : Form
    {
        public DifficultLevel()
        {
            InitializeComponent();
        }
        //array of questions
        string[] questions = { "Q1 - Which of the following is not the way to maintain state?",
                               "Q2 - Which of the following is the way to monitor the web application?",
                               "Q3 - What class does the ASP.NET Web Form class inherit from by default?" };

        //array of options

        string[,] options = new string[3, 5] { {"View state", "Cookies","Hidden fields","Request object","View state" },
                                             {"MMC Event viewers", "Performance logs","Alerts Snap-ins","All of the above","All of the above" },
                                             {"System.Web.UI.Page", "System.Web.UI.Form","System.Web.GUI.Page","System.Web.Form","System.Web.GUI.Page" }};

        //variables 
        int index = 0, correct = 0;

        //functions to check correct answers

        public void checkAnswer(RadioButton rbtn2)
        {
            if (rbtn2.Text.Equals(options[index,4]))
            {
                correct++;
            }
            index++;
            setEnable2(false);
        }

        //functions to uncheck radio button
        public void unCheck2()
        {
            rBtnA1D.Checked = false;
            rBtnB1D.Checked = false;
            rBtnC1D.Checked = false;
            rbtnD1D.Checked = false;
        }

        //functions to enable radio button

        public void setEnable2(Boolean yes_or_no)
        {
            rBtnA1D.Enabled = yes_or_no;
            rBtnB1D.Enabled = yes_or_no;
            rBtnC1D.Enabled = yes_or_no;
            rbtnD1D.Enabled = yes_or_no;
        }
        private void btnExit1D_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit message",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                MainMenu mn = new MainMenu();
                mn.Show(this);
                this.Hide();
                timerD.Enabled = false;
            }

        }

        int timeLeft2 = 16;

        private void btnNext1D_Click(object sender, EventArgs e)
        {
            if(btnNext1D.Text.Equals("Restart the Quiz"))
            {
                index = 0;
                correct = 0;
                btnNext1D.Text = "Next";
                timeLeft2 = 16;
                lblSecondsD.ForeColor = Color.Black;
                if(timerD.Enabled==false)
                {
                    timerD.Start();
                }
            }
            if (timerD.Enabled == false)
            {
                timerD.Start();
            }

            if (index == questions.Length)
            {
                qlblquestD.Text = ("You have scored:" + correct + "/" + questions.Length);
                btnNext1D.Text = "Restart the Quiz";
                timerD.Stop();
            }

            else
            {
                //enable radio button
                setEnable2(true);
                unCheck2();
                qlblquestD.Text = questions[index];
                rBtnA1D.Text = options[index, 0];
                rBtnB1D.Text = options[index, 1];
                rBtnC1D.Text = options[index, 2];
                rbtnD1D.Text = options[index, 3];

                if (index == questions.Length - 1)
                {
                    btnNext1D.Text = "FINISH TEST";


                }
            }
        }

        private void DifficultLevel_Load(object sender, EventArgs e)
        {
            btnNext1D.PerformClick();
        }

        private void rBtnA1D_Click(object sender, EventArgs e)
        {
            checkAnswer(rBtnA1D);
        }

        private void rBtnB1D_Click(object sender, EventArgs e)
        {
            checkAnswer(rBtnB1D);
        }

        private void rBtnC1D_Click(object sender, EventArgs e)
        {
            checkAnswer(rBtnC1D);
        }

        private void rbtnD1D_Click(object sender, EventArgs e)
        {
            checkAnswer(rbtnD1D);
        }

        private void btnCloseD_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCloseD_MouseHover(object sender, EventArgs e)
        {
            btnCloseD.BackColor = Color.Red;
        }

        private void btnCloseD_MouseLeave(object sender, EventArgs e)
        {
            btnCloseD.BackColor = Color.White;
        }

        private void timerD_Tick(object sender, EventArgs e)
        {
            if(timeLeft2>0)
            {
                timeLeft2=timeLeft2 - 1;
                lblSecondsD.Text = timeLeft2.ToString();

                if(timeLeft2<=5)
                {
                    lblSecondsD.ForeColor = Color.Red;
                }
                if(timeLeft2==0)
                {
                    rBtnA1D.Enabled = false;
                    rBtnB1D.Enabled = false;
                    rBtnC1D.Enabled = false;
                    rbtnD1D.Enabled = false;

                    btnNext1D.Text = "Restart the Quiz";
                    MessageBox.Show("TIME IS UP! \nRESTART THE QUIZ TO PLAY AGAIN!", "GAMEOVER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
