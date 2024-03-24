using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace dotNET_QUIZ_GAME
{
    public partial class MediumLevel : Form
    {
        public MediumLevel()
        {
            InitializeComponent();
        }
        //array of questions
        string[] questions = {"Q1 - The name of person in the image is",
                              "Q2 - Following image depicts what kind of collection?",
                              "Q3 - ___ allows us to make changes in a code without changing source code?",
                              "Q4 - Which of the following type of syntax does LINQ support?",
                              "Q5 - In a connection string __represents name of the database.",
                              };

        //array of options
        string[,] options = new string[5, 5] {     {"Dennis MacAlistair Ritchie", "Tim Berners-Lee", "James Gosling OC", "Anders Hejlsberg", "Anders Hejlsberg" },
                                                    {"Generic", "Non-Generic", "Both", "None of these", "Both"  },
                                                    {"Private method", "Extension method", "void method", "All of the above", "Extension method" },
                                                    {"Method Syntax only", "Query Syntax","None", "Both", "Both" },
                                                    {"Database", "Initial catalog", "Data Source", "Server name", "Initial catalog" },
                                                    };
        
        //array of imgs
        Image[] imgArray = { Properties.Resources.Anders_Hejlsberg, Properties.Resources.Stack,Properties.Resources.extensionMethod, Properties.Resources.linq,Properties.Resources.db2};

        //variables
        int index = 0, correct = 0;

        //function to check correct answers
        public void checkAnswer( RadioButton rbtn)
        {
            if (rbtn.Text.Equals(options[index,4]))
            {
                correct++;
            }
            index++;
            setEnable(false);
        }

        //function to uncheck radio button
        public void uncheck()
        {
            rBtnA1.Checked = false; 
            rBtnB1.Checked = false;
            rBtnC1.Checked = false; 
            rbtnD1.Checked= false;
        }

        //function to enable radio button

        public void setEnable(Boolean yes_or_no)
        {
            rBtnA1.Enabled = yes_or_no;
            rBtnB1.Enabled = yes_or_no;
            rBtnC1.Enabled = yes_or_no; 
            rbtnD1.Enabled = yes_or_no;
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            if (btnNext1.Text.Equals("Restart the Quiz"))
            {
                index = 0;
                correct = 0;
                btnNext1.Text = "Next";
                timeLeft1 = 31;
                lblSeconds2.ForeColor = Color.Black;
                if (timerm.Enabled == false)
                {
                    timerm.Start();
                }
            }
            if (index == questions.Length)
            {
                qlblquestM.Text = ("You have scored:" + correct + "/" + questions.Length);

                btnNext1.Text = "Restart the Quiz";
                timerm.Stop();
                pictureBox1.Visible = false;
            }
            else
            {
                //enable radio button
                setEnable(true);
                uncheck();
                pictureBox1.Visible= true;
                pictureBox1.Image = imgArray[index];
                qlblquestM.Text = questions[index];
                rBtnA1.Text = options[index, 0];
                rBtnB1.Text = options[index, 1];
                rBtnC1.Text = options[index, 2];
                rbtnD1.Text = options[index, 3];

                if (index == questions.Length - 1)
                {
                    btnNext1.Text = "FINISH TEST";


                }
            }
        }

        private void MediumLevel_Load(object sender, EventArgs e)
        {
            btnNext1.PerformClick();
        }
        int timeLeft1 = 31;
        private void timerm_Tick(object sender, EventArgs e)
        {
            if (timeLeft1 > 0)
            {
                //timerm.Enabled = true;
                
                timeLeft1 = timeLeft1 - 1;
                lblSeconds2.Text = timeLeft1.ToString();
                
                if (timeLeft1 <= 10)
                {
                    lblSeconds2.ForeColor = Color.Red;
                }
                if (timeLeft1 == 0)
                {
                    rBtnA1.Enabled = false;
                    rBtnB1.Enabled = false;
                    rBtnC1.Enabled = false;
                    rbtnD1.Enabled = false;
                    
                    
                    btnNext1.Text = "Restart the Quiz";
                    MessageBox.Show("TIME IS UP! \nRESTART THE QUIZ TO PLAY AGAIN!", "GAMEOVER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rBtnA1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtnA1_Click(object sender, EventArgs e)
        {
            checkAnswer(rBtnA1);
        }

        private void rBtnB1_Click(object sender, EventArgs e)
        {
            checkAnswer(rBtnB1);
        }

        private void rBtnC1_Click(object sender, EventArgs e)
        {
            checkAnswer(rBtnC1);
        }

        private void rbtnD1_Click(object sender, EventArgs e)
        {
            checkAnswer(rbtnD1);
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?","Exit message",MessageBoxButtons.YesNo, MessageBoxIcon.Question )==DialogResult.Yes)
            {
                
                MainMenu MN = new MainMenu();
                MN.Show(this);
                this.Hide();
                timerm.Enabled = false; 
            }
            
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor= Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
