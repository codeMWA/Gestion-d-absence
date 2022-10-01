using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IstaClass;

namespace IstaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread th = new Thread(new ThreadStart(StartForm));
            th.Start();            
            InitializeComponent();
            for (int i = 0; i <= 900; i++)
            {
                Thread.Sleep(10);
            }
            th.Abort();
        }
        public void StartForm()
        {
            splashscreen sp = new splashscreen();
            Application.Run(sp);
        }
        Principal.Linq.DataClasses1DataContext lnq = new Principal.Linq.DataClasses1DataContext();
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            int t = 0;
            var admins = from adm in lnq.administrateur
                         select adm;
            foreach(var v in admins)
            {
                if((v.userA == txtUser.Text) && (v.passwordA == txtPassword.Text))
                {
                    adminsClass.userADM = txtUser.Text;
                    new Principal.Homepage().Show();
                    this.Hide();
                    t++;
                }
            }
            if(t == 0)
            {
                MessageBox.Show("L'utilisateur ou le mot de passe sont incorrects!");
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "Utilisateur") { 
                txtUser.Clear();
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            { 
                txtUser.ForeColor = Color.DimGray;
                txtUser.Text = "Utilisateur";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "Mot de passe") { 
                txtPassword.Clear();
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*' ;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text == "") { 
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.Text = "Mot de passe";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void DisplayEye_Click(object sender, EventArgs e)
        {
            DisplayEye.Visible = false;
            HideEye.Visible = true;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void HideEye_Click(object sender, EventArgs e)
        {
            DisplayEye.Visible = true;
            HideEye.Visible = false;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int t = 0;
                var admins = from adm in lnq.administrateur
                             select adm;
                foreach (var v in admins)
                {
                    if ((v.userA == txtUser.Text) && (v.passwordA == txtPassword.Text))
                    {
                        adminsClass.userADM = txtUser.Text;
                        new Principal.Homepage().Show();
                        this.Hide();
                        t++;
                    }
                }
                if (t == 0)
                {
                    MessageBox.Show("L'utilisateur ou le mot de passe sont incorrects!");
                }
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int t = 0;
                var admins = from adm in lnq.administrateur
                             select adm;
                foreach (var v in admins)
                {
                    if ((v.userA == txtUser.Text) && (v.passwordA == txtPassword.Text))
                    {
                        adminsClass.userADM = txtUser.Text;
                        new Principal.Homepage().Show();
                        this.Hide();
                        t++;
                    }
                }
                if (t == 0)
                {
                    MessageBox.Show("L'utilisateur ou le mot de passe sont incorrects!");
                }
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
