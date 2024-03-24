using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace dotNET_QUIZ_GAME
{
    public partial class SimpleLevel : Form
    {
        public SimpleLevel()
        {
            InitializeComponent();
        }

        //array of questions
        string[] questions = {"Q1 - Which company developed the .NET software?",
                              "Q2 - A variable which is declared inside a method is called a ___ variable?",
                              "Q3 - The .com indicates  website of _____ type of organization ?",
                              "Q4 - C# first appeared in what year?",
                              "Q5 - What is the full form ASP?",
                              "Q6 - Which of the following programming language can be used with ASP.NET?",
                              "Q7 - MVC stands for?",
                              "Q8 - Which protocol is used to call a web service?",
                              "Q9 - Which of the following tag is used for the HTML checkbox?",
                              "Q10 - The AutoPostBack is?"};

        //array of options
        string[,] options = new string[10, 5] {     {"Apple", "IBM", "Microsoft", "Google", "Microsoft" },
                                                    {"Local","Static","Global", "Private", "Local" },
                                                    {"Company", "Complex", "Commercial", "Group", "Commercial" },
                                                    {"1998", "1999","2000", "2001", "2000" },
                                                    {"Access Server Pages", "Active Server Pages", "Active Service Pages", "Access Service Pages", "Active Server Pages" },
                                                    {"C#.NET", "VB.NET", "None", "Both", "Both" },
                                                    {"Model Vocal Controller","Model View Controller", "Model View Count","Mode View Controller", "Model View Controller" },
                                                    {"SOAP Protocol", "FTP Protocol", "TCP Protocol", "HTTP Protocol", "HTTP Protocol" },
                                                    {"<check>", "<checkbox>", "<input>","None of the above", "<checkbox>" },
                                                    {"A property", "An Event", "A Method", "None of the above", "A property"}};
        int index = 0, correct = 0;

        //Function to check whether user have selected correct answer 
        public void checkAnswer(RadioButton rbt)
        {
            if (rbt.Text.Equals(options[index,4]))
            {
                correct++;
            }
            index++;
            SetEnable(false);
        }

        //function to uncheck radio buttons
        public void unCheck()
        {
            rBtnA.Checked = false;
            rBtnB.Checked = false;
            rBtnC.Checked = false;  
            rbtnD.Checked = false;
        }
        //function to enable radio buttons
        public void SetEnable(Boolean yes_or_no)
        {
            rBtnA.Enabled = yes_or_no;
            rBtnB.Enabled = yes_or_no;
            rBtnC.Enabled = yes_or_no;
            rbtnD.Enabled = yes_or_no;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        
        int timeLeft = 61;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                lblSeconds.Text = timeLeft.ToString();
                if(timeLeft<=10)
                {
                    lblSeconds.ForeColor=Color.Red;
                }
                if(timeLeft==0)
                {
                    rBtnA.Enabled = false;  
                    rBtnB.Enabled = false;
                    rBtnC.Enabled = false;
                    rbtnD.Enabled = false;
                    //btnNext.Enabled = false;
                    btnNext.Text = "Restart the Quiz";
                    MessageBox.Show("TIME IS UP! \nRESTART THE QUIZ TO PLAY AGAIN!", "GAMEOVER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SimpleLevel_Load(object sender, EventArgs e)
        {
            btnNext.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to exit?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MainMenu mn = new MainMenu();
                mn.Show(this);
                this.Hide();
                timer1.Enabled= false;
            }
        }

        private void btnNext_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }


        //=============================================================================================================================================================
        public void rBtnA_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rBtnA_Click(object sender, EventArgs e)
        {
            checkAnswer(rBtnA);
        }
        public void rBtnB_Click(object sender, EventArgs e)
        {
            
        }
        private void rBtnB_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rBtnC_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnD_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rBtnB_Click_1(object sender, EventArgs e)
        {
            checkAnswer(rBtnB);
        }

        private void rbtnD_Click(object sender, EventArgs e)
        {
            checkAnswer(rbtnD);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(btnNext.Text.Equals("Restart the Quiz"))
            {
                index = 0;
                correct = 0;
                btnNext.Text = "Next";
                timeLeft = 61;
                lblSeconds.ForeColor = Color.Black;
                if(timer1.Enabled==false)
                {
                    timer1.Start();
                }
            }
            if (index == questions.Length)
            {
                qlblquest.Text=("You have scored:" + correct +"/" + questions.Length);

                btnNext.Text = "Restart the Quiz";
                timer1.Stop();
            }

            
            else
            {
                //enable radio button
                SetEnable(true);
                unCheck();
                qlblquest.Text = questions[index];
                rBtnA.Text = options[index, 0];
                rBtnB.Text = options[index, 1];
                rBtnC.Text = options[index, 2];
                rbtnD.Text = options[index, 3];

                if(index==questions.Length - 1)
                {
                    btnNext.Text = "FINISH TEST";
                    
                    
                }
            }
        }

        private void rBtnC_Click(object sender, EventArgs e)
        {
            checkAnswer(rBtnC);
        }
    }

   
}
