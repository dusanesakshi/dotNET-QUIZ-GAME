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
    
    public partial class Login : Form
    {
        MainMenu mainMenu = new MainMenu();
        public static string userName = "user12";
        public static string userPass = "0000";
        public static string Uname;
        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Application.Exit();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uname= txtUser.Text;
            if (txtUser.Text == userName && txtPass.Text == userPass)
            {
               
                mainMenu.Show(this);
                this.Hide();
               // MessageBox.Show("ADD MAIN MENU");
            }

            else if(txtUser.Text != userName && txtPass.Text == userPass)
            {
                MessageBox.Show("INVALID USERNAME");
            }

            else if (txtUser.Text == userName && txtPass.Text != userPass)
            {
                MessageBox.Show("INVALID PASSWORD");
            }
            else
            {
                MessageBox.Show("INVALID INFORMATION!\nTRY LOGGING IN AS GUEST!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            mainMenu.Show(this);
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor= Color.White;
        }
    }
}
