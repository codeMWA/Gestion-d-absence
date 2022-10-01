using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using IstaClass;
using System.Data.SqlClient;
using System.IO;

namespace IstaForm.Principal.Controls
{
    public partial class ImportedXsl : UserControl
    {
        public ImportedXsl()
        {
            InitializeComponent();
        }

      
        private void ImportedBtn_Click(object sender, EventArgs e)
        {
            Class1.FillDataBase();
            dataGridView1.DataSource = Class1.AfficherDataBase();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer tous les éléments ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == dialogResult)
            {
                Class1.ClearDataBase();
                dataGridView1.DataSource = Class1.AfficherDataBase();
            }
            
        }

        private void ImportedXsl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Class1.AfficherDataBase();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            if(gunaTextBox1.Text != "")
            {
                if(gunaTextBox1.Text != "Chercher")
                    dataGridView1.DataSource = Class1.ChercherDataBase(gunaTextBox1.Text);
                else
                    dataGridView1.DataSource = Class1.AfficherDataBase();
            }
            else
            {
                dataGridView1.DataSource = Class1.AfficherDataBase();
            }
        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {
            if(gunaTextBox1.Text == "Chercher")
            {
                gunaTextBox1.Clear();
                gunaTextBox1.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            if(gunaTextBox1.Text == "")
            {
                gunaTextBox1.ForeColor = Color.DimGray;
                gunaTextBox1.Text = "Chercher";
            }
        }

        private void gunaTextBox1_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void gunaTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaTextBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void gunaTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
        void ExporterText()
        {
            DataTable data = new DataTable();
            Connexion.Connecter();
            Connexion.cmd = new SqlCommand("select Nom, Prenom, absence.* from absence join stagiaire on absence.id_inscriptionsessionprogramme = stagiaire.id_inscriptionsessionprogramme", Connexion.cnx);
            Connexion.dr = Connexion.cmd.ExecuteReader();
            data.Load(Connexion.dr);
            string chemin = "";
            saveFileDialog1.Filter = "Text Files | .*txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                chemin = saveFileDialog1.FileName;
            }
            StreamWriter st = new StreamWriter(chemin);
            st.WriteLine("Nom" + "\t" + "Prenom" + "\t" + "CodeAbsence" + "\t" + "id_inscriptionsessionprogramme" + "\t" + "joursAbsences" + "\t" + "justificaton" + "\t" + "jours_justifiés" + "\t" + "date_absence" + "\t" + "dateFinAbs");
            for (int i =0; i< data.Rows.Count;i++)
            {
                st.WriteLine(data.Rows[i][0] + "\t" + data.Rows[i][1] + "\t" + data.Rows[i][2] + "\t" + data.Rows[i][3] + "\t" + data.Rows[i][4] + "\t" + data.Rows[i][5] + "\t" + data.Rows[i][6] + "\t" + data.Rows[i][7] + "\t" + data.Rows[i][8]);
            }
            st.Close();
            MessageBox.Show("Données Enregistrer avec succes !", "Confirmation",MessageBoxButtons.OK);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //DataSet dtt = new DataSet();
            //Connexion.adapt = new SqlDataAdapter("select * from absence",Connexion.cnx);
            //Connexion.adapt.Fill(dtt,"ss");
            //dtt.WriteXml("doss.xlsx");
            ExporterText();
        }

        private void btnImporterAbs_Click(object sender, EventArgs e)
        {
            Class1.FillDataBaseAbs();
            MessageBox.Show("Données Enregistrer avec succes !");
        }
    }
}
