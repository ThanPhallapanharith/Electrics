using ElectricAssignmentyear2.Classes;
using ElectricAssignmentyear2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricAssignmentyear2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Declare
            UserLogin user = new UserLogin();
            //input
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            //process
            if(user.CheckUser())
            {
                MessageBox.Show("Successful");
                FormMain main = new FormMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid!");
            }
       }

        private void lblCreateUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateUsers createUsers = new CreateUsers();
            createUsers.Show();

        }
    }
}
