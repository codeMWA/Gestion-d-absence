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
    public partial class attestation : UserControl
    {
        public attestation()
        {
            InitializeComponent();
        }

        private void attestation_Load(object sender, EventArgs e)
        {
            Connexion.ds.Clear();
            Connexion.adapt1 = new SqlDataAdapter("select distinct Nom from stagiaire order by Nom", Connexion.cnx);
            Connexion.adapt1.Fill(Connexion.ds, "stag12");
            for (int i = 0; i < Connexion.ds.Tables["stag12"].Rows.Count; i++)
            {
                comboBox1.Items.Add(Connexion.ds.Tables["stag12"].Rows[i][0]);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            comboBox2.Items.Clear();
            Connexion.adapt = new SqlDataAdapter("select * from stagiaire where Nom = '" + comboBox1.Text + "'", Connexion.cnx);
            Connexion.adapt.Fill(dt2);
            for (int k = 0; k < dt2.Rows.Count; k++)
            {

                comboBox2.Items.Add(dt2.Rows[k][3]);
                break;
            }
        }
        DataSet1 ds1 = new DataSet1();
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet1TableAdapters.stagiaire2TableAdapter stg = new DataSet1TableAdapters.stagiaire2TableAdapter();
            stg.FillByNom(ds1.stagiaire2, comboBox1.Text, comboBox2.Text);
            CrystalReport2 rapport = new CrystalReport2();
            rapport.SetDataSource(ds1);
            crystalReportViewer1.ReportSource = rapport;
        }
    }
}
