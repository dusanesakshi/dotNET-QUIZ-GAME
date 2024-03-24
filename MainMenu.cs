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
    public partial class MainMenu : Form
    {
      

        
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            

        }

        private void eASYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleLevel sl = new SimpleLevel();
            sl.Show(this);
            this.Hide();
        }

        private void MainMenu_Load_1(object sender, EventArgs e)
        {
            if(Login.Uname=="user12")
            {
                lblDisplayName.Text = "WELCOME "+ Login.Uname +" !";
                
            }
            else
            {
                lblDisplayName.Text = "WELCOME GUEST USER!";
            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show(this);
            this.Hide();
        }

        private void mEDIUMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediumLevel ml = new MediumLevel(); 
            ml.Show(this);
            this.Hide();
        }

        private void dIFFICULTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultLevel difficult = new DifficultLevel();
            difficult.Show(this);
            this.Hide();    
        }

        private void oPTIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instructions ins = new instructions();   
            ins.Show(this);
            this.Hide();    

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

            button1.BackColor = Color.White;
        }
    }
}
