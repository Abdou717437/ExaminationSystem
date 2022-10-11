using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System_ITI.Views
{
    public partial class Login_Frm : Form
    {
        public Login_Frm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Frm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.User_Name = txtUsername.Text;
            user.Password = txtPassword.Text;
            User.Login(user);
            if(User.IsSuccessful)
            {
                MessageBox.Show(User.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainFrm frm = new MainFrm();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(User.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
