using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IstaClass;

namespace IstaForm.Principal
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent(); 
        }
       
        public void OpenTitles()
        {
            if (panelTitles.Width == 50)
            {
                closeP.Visible = true;
                pictureBox1.Visible = false;
                profileIMG.Visible = true;
                labelUser.Visible = true;
                panel2.BackColor = Color.White;
                panelTitles.Width = 218;
            }
                
            else
                panelTitles.Width = 50;
        }
        public void CloseTitles()
        {
            if (panelTitles.Width == 218)
            {
                closeP.Visible = false;
                profileIMG.Visible = false;
                labelUser.Visible = false;
                pictureBox1.Visible = true;
                panel2.BackColor = Color.BurlyWood;
                panelTitles.Width = 50;
            }
                
            else
                panelTitles.Width = 218;
        }
        public void DisplayPanelAbs()
        {
            if (absencePanel.Visible == false)
                absencePanel.Visible = true;
            else
                absencePanel.Visible = false;
        }
        public void HidePanelAbs()
        {
            if (absencePanel.Visible == true)
                absencePanel.Visible = false;
        }
        public void DisplayContent(Control ctr)
        {
            
            CloseTitles();
            importedXsl1.Visible = false;
            absenceControl1.Visible = false;
            absence2Control1.Visible = false;
            passwordControl1.Visible = false;
            listPrésence1.Visible = false;
            attestation1.Visible = false;
            ctr.Visible = true;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HidePanelAbs();
            OpenTitles();
        }

        private void closeP_Click(object sender, EventArgs e)
        {

            HidePanelAbs();
            CloseTitles();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            HidePanelAbs();
            DisplayContent(importedXsl1);
        }

        private void absence_Click(object sender, EventArgs e)
        {
            DisplayPanelAbs();
        }

        private void ajouterAbs_Click(object sender, EventArgs e)
        {
            HidePanelAbs();
            DisplayContent(absenceControl1);
        }

        private void toutesAbs_Click(object sender, EventArgs e)
        {
            HidePanelAbs();
            DisplayContent(absence2Control1);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment déconnecter ?","",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(DialogResult.OK == dialogResult)
            {
                this.Close();
                new Form1().Show();
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            HidePanelAbs();
            DisplayContent(passwordControl1);
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            labelUser.Text = adminsClass.userADM;
        }

        private void presence_Click(object sender, EventArgs e)
        {
            HidePanelAbs();
            DisplayContent(listPrésence1);
        }

        private void btnAttestation_Click(object sender, EventArgs e)
        {
            HidePanelAbs();
            DisplayContent(attestation1);
        }
    }
}
