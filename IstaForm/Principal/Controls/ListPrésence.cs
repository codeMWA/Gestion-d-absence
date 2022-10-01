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
    public partial class ListPrésence : UserControl
    {
        public ListPrésence()
        {
            InitializeComponent();
        }
        DataSet1 ds = new DataSet1();
        Linq.DataClasses1DataContext lnq = new Linq.DataClasses1DataContext();
        private void ListPrésence_Load(object sender, EventArgs e)
        {
            //var stagiaires = from stg in lnq.stagiaire
            //                 select stg;
            //foreach(var v in stagiaires)
            //{
            //    comboBox1.Items.Add(v.CodeDiplome);
            //}
            comboBox1.Items.Clear();
            Connexion.ds.Clear();
            Connexion.adapt = new SqlDataAdapter("select distinct CodeDiplome from stagiaire order by CodeDiplome", Connexion.cnx);
            Connexion.adapt.Fill(Connexion.ds, "stag");
            for (int i = 0; i < Connexion.ds.Tables["stag"].Rows.Count; i++)
            {
                comboBox1.Items.Add(Connexion.ds.Tables["stag"].Rows[i][0]);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet1TableAdapters.stagiaire1TableAdapter adapt1 = new DataSet1TableAdapters.stagiaire1TableAdapter();
            adapt1.FillByCode(ds.stagiaire1,comboBox1.Text);
            CrystalReport1 rapport = new CrystalReport1();
            rapport.SetDataSource (ds);
            crystalReportViewer1.ReportSource = rapport;
        }
    }
}
