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
using System.Data.SqlClient;


namespace IstaForm.Principal.Controls
{
    public partial class absenceControl : UserControl
    {
        public absenceControl()
        {
            InitializeComponent();
            //dataGridView1.Rows.Clear();
            //nbrJours.Visible = false;
        }
        public void ClearData()
        {
            joursAbs.Clear();
            just.Clear();
            joursJust.Clear();
            gunaDateTimePicker1.Select();
        }
        private void absenceControl_Load(object sender, EventArgs e)
        {
            gunaComboBox1.Items.Clear();
            dataGridView1.Rows.Clear();
            Connexion.ds.Clear();
            Connexion.adapt = new SqlDataAdapter("select distinct CodeDiplome from stagiaire order by CodeDiplome", Connexion.cnx);
            Connexion.adapt.Fill(Connexion.ds,"stag");
            for(int i =0;i<Connexion.ds.Tables["stag"].Rows.Count;i++)
            {
                gunaComboBox1.Items.Add(Connexion.ds.Tables["stag"].Rows[i][0]);
            }

        }

        private void gunaComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            nbrJours.Visible = false;
            Connexion.ds.Clear();
            Connexion.adapt = new SqlDataAdapter("select * from stagiaire where CodeDiplome = '" + gunaComboBox1.Text + "'", Connexion.cnx);
            Connexion.adapt.Fill(Connexion.ds, "stagi");
            NomComboBox.DataSource = Connexion.ds.Tables["stagi"];
            NomComboBox.DisplayMember = "Nom";
            NomComboBox.ValueMember = "id_inscriptionsessionprogramme";
        }

        public void RemplirDGV()
        {
            dataGridView1.Rows.Clear();
            Connexion.dt.Clear(); ;
            nbrJours.Visible = false;
            Connexion.adapt = new SqlDataAdapter("select absence.* from absence join stagiaire " +
            "on absence.id_inscriptionsessionprogramme = stagiaire.id_inscriptionsessionprogramme " +
            "where stagiaire.Nom = '" + NomComboBox.Text + "' and stagiaire.CodeDiplome = '"+gunaComboBox1.Text+"' and stagiaire.Prenom = '"+PrenomComboBox.Text+"'", Connexion.cnx);
            Connexion.adapt.Fill(Connexion.dt);
            for (int i = 0; i < Connexion.dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(Connexion.dt.Rows[i][0], Connexion.dt.Rows[i][2], Connexion.dt.Rows[i][5], Connexion.dt.Rows[i][6], Connexion.dt.Rows[i][3], Connexion.dt.Rows[i][4]);
                //break;

            }
        }
        private void NomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Stagiaire.NomStagiaire = NomComboBox.Text;
            nbrJours.Visible = false;
            Connexion.dt1.Clear();
            PrenomComboBox.Items.Clear();
            Connexion.adapt = new SqlDataAdapter("select * from stagiaire where Nom = '" + NomComboBox.Text + "'", Connexion.cnx);
            Connexion.adapt.Fill(Connexion.dt1);
            for(int k = 0; k < Connexion.dt1.Rows.Count; k++)
            {

                PrenomComboBox.Items.Add(Connexion.dt1.Rows[k][3]);
                break;
            }
            

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            try
            { 
                Connexion.adapt1 = new SqlDataAdapter("select * from stagiaire", Connexion.cnx);
                Connexion.adapt1.Fill(Connexion.ds, "stagie1");
                for (int j = 0; j < Connexion.ds.Tables["stagie1"].Rows.Count; j++)
                {
                    if ((Connexion.ds.Tables["stagie1"].Rows[j][2].ToString() == Stagiaire.NomStagiaire) && (Connexion.ds.Tables["stagie1"].Rows[j][3].ToString() == Stagiaire.PrenomStagiaire))
                    {
                        Stagiaire.idStagiaire = Convert.ToInt32(Connexion.ds.Tables["stagie1"].Rows[j][0]);
                        Connexion.Connecter();
                        Connexion.cmd = new SqlCommand("insert into absence(id_inscriptionsessionprogramme,joursAbsences,justificaton,jours_justifiés,date_absence,dateFinAbs) values('" + Stagiaire.idStagiaire + "','" + Convert.ToInt32(joursAbs.Text) + "','" + just.Text + "','" + Convert.ToInt32(joursJust.Text) + "','" + gunaDateTimePicker1.Text + "','"+ gunaDateTimePicker2.Text + "')", Connexion.cnx);
                        Connexion.cmd.ExecuteNonQuery();
                        Connexion.Deconnecter();
                        MessageBox.Show("Absence ajoutée avec succès");
                        ClearData();
                        RemplirDGV();
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            { 
                Connexion.Connecter();
                Connexion.cmd = new SqlCommand("update absence set joursAbsences = '" + Convert.ToInt32(joursAbs.Text) + "' ,justificaton = '" + just.Text + "', " +
                    " jours_justifiés = '" + Convert.ToInt32(joursJust.Text) + "', date_absence = '" + gunaDateTimePicker1.Text + "', " +
                    "dateFinAbs = '" + gunaDateTimePicker2.Text + "' "+
                    "where CodeAbsence = '" + Convert.ToInt32(Stagiaire.idStagiaire1) + "'", Connexion.cnx);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.Deconnecter();
                MessageBox.Show("Absence modifiée avec succès");
                ClearData();
                RemplirDGV();
            }
            catch(Exception ec)
            {
                MessageBox.Show(""+ec);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Connexion.Connecter();
            Connexion.cmd = new SqlCommand("select sum(joursAbsences) from absence join stagiaire " +
            "on absence.id_inscriptionsessionprogramme = stagiaire.id_inscriptionsessionprogramme " +
            "where stagiaire.Nom = '" + NomComboBox.Text + "' and stagiaire.Prenom = '"+PrenomComboBox.Text+"'", Connexion.cnx);
            int b = Convert.ToInt32(Connexion.cmd.ExecuteScalar());
            Connexion.Deconnecter();
            nbrJours.Text = b.ToString();
            nbrJours.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                Connexion.adapt1 = new SqlDataAdapter("select * from absence", Connexion.cnx);
                Connexion.adapt1.Fill(Connexion.ds, "stagie2");
                for (int j = 0; j < Connexion.ds.Tables["stagie2"].Rows.Count; j++)
                {
                    if (Connexion.ds.Tables["stagie2"].Rows[j][0].ToString() == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        Stagiaire.idStagiaire1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        joursAbs.Text = Connexion.ds.Tables["stagie2"].Rows[j][2].ToString();
                        gunaDateTimePicker1.Text = Connexion.ds.Tables["stagie2"].Rows[j][5].ToString();
                        just.Text = Connexion.ds.Tables["stagie2"].Rows[j][3].ToString();
                        joursJust.Text = Connexion.ds.Tables["stagie2"].Rows[j][4].ToString();
                        break;
                    }
                }
            }
            
            
                if(e.ColumnIndex == 7)
                {
                    DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet élément ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == dialogResult)
                    { 
                        Connexion.adapt1 = new SqlDataAdapter("select * from absence", Connexion.cnx);
                        Connexion.adapt1.Fill(Connexion.ds, "stagie3");
                        for (int j = 0; j < Connexion.ds.Tables["stagie3"].Rows.Count; j++)
                        {
                            if (Connexion.ds.Tables["stagie3"].Rows[j][0].ToString() == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
                            {  
                                Connexion.ds.Tables["stagie3"].Rows[j].Delete();
                                Connexion.Save("stagie3",Connexion.adapt1);
                                MessageBox.Show("Absence supprimée avec succès");
                                RemplirDGV();
                                break;
                            }
                        }
                    }
                }
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PrenomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stagiaire.PrenomStagiaire = PrenomComboBox.Text;
            RemplirDGV();
        }

    }
}
