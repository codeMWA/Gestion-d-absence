using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IstaClass;

namespace IstaForm.Principal.Controls
{
    public partial class absence2Control : UserControl
    {
        public absence2Control()
        {
            InitializeComponent();
        }
        public void RempliDGVS()
        {
            Connexion.ds.Clear();
            Connexion.adapt = new SqlDataAdapter("select stagiaire.Nom, stagiaire.Prenom, absence.* from absence join stagiaire " +
            "on absence.id_inscriptionsessionprogramme = stagiaire.id_inscriptionsessionprogramme ", Connexion.cnx);
            Connexion.adapt.Fill(Connexion.ds, "stagie1");
            dataGridView1.DataSource = Connexion.ds.Tables["stagie1"];
        }
        public void RempliDGVGroupe()
        {
            Connexion.ds.Clear();
            Connexion.adapt = new SqlDataAdapter("select stagiaire.Nom, stagiaire.Prenom, absence.* from absence join stagiaire " +
            "on absence.id_inscriptionsessionprogramme = stagiaire.id_inscriptionsessionprogramme " +
            "where stagiaire.CodeDiplome = '" + gunaComboBox1.Text + "'", Connexion.cnx);
            Connexion.adapt.Fill(Connexion.ds, "stagie");
            dataGridView1.DataSource = Connexion.ds.Tables["stagie"];
        }
        public void RempliDGVNom()
        {
            Connexion.ds.Clear();
            Connexion.adapt = new SqlDataAdapter("select stagiaire.Nom, stagiaire.Prenom, absence.* from absence join stagiaire " +
            "on absence.id_inscriptionsessionprogramme = stagiaire.id_inscriptionsessionprogramme " +
            "where stagiaire.Nom = '" + gunaComboBox2.Text + "'", Connexion.cnx);
            Connexion.adapt.Fill(Connexion.ds, "stagie2");
            dataGridView1.DataSource = Connexion.ds.Tables["stagie2"];
        }
        public void RempliDGVDate()
        {
            Connexion.ds.Clear();
            Connexion.adapt = new SqlDataAdapter("select stagiaire.Nom, stagiaire.Prenom, absence.* from absence join stagiaire " +
            "on absence.id_inscriptionsessionprogramme = stagiaire.id_inscriptionsessionprogramme " +
            "where date_absence between '"+gunaDateTimePicker1.Text+"' and '"+gunaDateTimePicker2.Text+"'", Connexion.cnx);
            Connexion.adapt.Fill(Connexion.ds, "stagie3");
            dataGridView1.DataSource = Connexion.ds.Tables["stagie3"];
        }
        private void absence2Control_Load(object sender, EventArgs e)
        {
            Connexion.ds.Clear();
            Connexion.adapt = new SqlDataAdapter("select distinct CodeDiplome from stagiaire order by CodeDiplome", Connexion.cnx);
            Connexion.adapt.Fill(Connexion.ds, "stag1");
            for (int i = 0; i < Connexion.ds.Tables["stag1"].Rows.Count; i++)
            {
                gunaComboBox1.Items.Add(Connexion.ds.Tables["stag1"].Rows[i][0]);
            }
            Connexion.adapt1 = new SqlDataAdapter("select distinct Nom from stagiaire order by Nom", Connexion.cnx);
            Connexion.adapt1.Fill(Connexion.ds, "stag2");
            for (int i = 0; i < Connexion.ds.Tables["stag2"].Rows.Count; i++)
            {
                gunaComboBox2.Items.Add(Connexion.ds.Tables["stag2"].Rows[i][0]);
            }
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stagiaire.groupStagiaire = gunaComboBox1.Text;
            RempliDGVGroupe();
            Connexion.Connecter();
            Connexion.cmd = new SqlCommand("select count(absence.id_inscriptionsessionprogramme) from absence join stagiaire "+
            "on absence.id_inscriptionsessionprogramme = stagiaire.id_inscriptionsessionprogramme "+
            "where stagiaire.CodeDiplome = '"+gunaComboBox1.Text+"'",Connexion.cnx);
            int a = Convert.ToInt32(Connexion.cmd.ExecuteScalar());
            Connexion.Deconnecter();
            label5.Text = a.ToString();
            label6.Visible = true;
            label5.Visible = true;
            Connexion.Connecter();
            Connexion.cmd = new SqlCommand("select count(absence.jours_justifiés) from absence join stagiaire " +
            "on absence.id_inscriptionsessionprogramme = stagiaire.id_inscriptionsessionprogramme " +
            "where stagiaire.CodeDiplome = '" + gunaComboBox1.Text + "' and absence.jours_justifiés != 0", Connexion.cnx);
            int b = Convert.ToInt32(Connexion.cmd.ExecuteScalar());
            Connexion.Deconnecter();
            label8.Text = b.ToString();
            label7.Visible = true;
            label8.Visible = true;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void gunaButton3_Click(object sender, EventArgs e)
        {
            try
            { 
                DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer ces éléments ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dialogResult)
                {
                    Connexion.Connecter();
                    Connexion.cmd = new SqlCommand("delete from absence where absence.id_inscriptionsessionprogramme "+
                    "in (select stagiaire.id_inscriptionsessionprogramme from stagiaire join absence "+
                    "on stagiaire.id_inscriptionsessionprogramme = absence.id_inscriptionsessionprogramme "+
                    "where CodeDiplome = '"+Stagiaire.groupStagiaire+"')",Connexion.cnx);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.Deconnecter();
                    MessageBox.Show("Absence supprimée avec succès");
                    RempliDGVGroupe();
                    label6.Visible = false;
                    label5.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                }
            }
            catch(Exception es)
            {
                MessageBox.Show(""+es);
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            RempliDGVS();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            label6.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            RempliDGVNom();
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            
            label6.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            RempliDGVDate();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            try
            { 
                DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer ces éléments ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dialogResult)
                {
                    Connexion.Connecter();
                    Connexion.cmd = new SqlCommand("delete from absence where absence.id_inscriptionsessionprogramme " +
                    "in (select stagiaire.id_inscriptionsessionprogramme from stagiaire join absence " +
                    "on stagiaire.id_inscriptionsessionprogramme = absence.id_inscriptionsessionprogramme " +
                    "where Nom = '" + gunaComboBox2.Text + "')", Connexion.cnx);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.Deconnecter();
                    MessageBox.Show("Absence supprimée avec succès");
                    RempliDGVNom();
                    label6.Visible = false;
                    label5.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(""+er);
            }
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer tous les éléments ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == dialogResult)
            {
                Connexion.Connecter();
                Connexion.cmd = new SqlCommand("delete from absence", Connexion.cnx);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.Deconnecter();
                MessageBox.Show("Toutes les absences ont été effacées");
                RempliDGVS();
            }
        }
    }
}
