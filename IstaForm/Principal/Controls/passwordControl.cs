using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IstaClass;

namespace IstaForm.Principal.Controls
{
    public partial class passwordControl : UserControl
    {
        public passwordControl()
        {
            InitializeComponent();
        }
        Principal.Linq.DataClasses1DataContext lnq = new Linq.DataClasses1DataContext();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordControl_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox3.Clear();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(textBox4.Text == textBox3.Text)
            { 
                var passwords = from pass in lnq.administrateur
                                select pass;
                foreach(var v in passwords)
                {
                    if((v.userA == adminsClass.userADM)&&(v.passwordA == textBox1.Text))
                    {
                        Linq.administrateur admin = lnq.administrateur.First(x=>x.userA == adminsClass.userADM);
                        admin.passwordA = textBox4.Text;
                        lnq.SubmitChanges();
                        MessageBox.Show("bien modifié");
                        i++;
                    }
                }
                if(i == 0)
                    MessageBox.Show("le mot de passe actuel est incorrect!");
            }
            else
            {
                MessageBox.Show("Mot de passe non confirmè");
            }
        }
    }
}
