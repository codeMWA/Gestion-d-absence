using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IstaClass
{
    public class Connexion
    {
        public static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-QV3FUH3\SQLEXPRESS;Initial Catalog=IstaAinAtiq;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader dr;
        public static SqlDataAdapter adapt = new SqlDataAdapter();
        public static SqlDataAdapter adapt1 = new SqlDataAdapter();
        public static DataSet ds = new DataSet();
        public static DataTable dt = new DataTable();
        public static DataTable dt1 = new DataTable();
        public static void Save(string tableName, SqlDataAdapter adapt)
        {
            SqlCommandBuilder com = new SqlCommandBuilder(adapt);
            adapt.Update(ds.Tables[tableName]);
        }
        public static void Connecter()
        {
            if (cnx.State == ConnectionState.Closed)
                cnx.Open();  
        }
        public static void Deconnecter()
        {
                cnx.Close();
        }

    }
}
