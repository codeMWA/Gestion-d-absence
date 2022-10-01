using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstaClass
{
    public class Class1
    {
        public static DataTable dt = new DataTable();
        public static DataTable dt1 = new DataTable();
        public static SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QV3FUH3\SQLEXPRESS;Initial Catalog=IstaAinAtiq;Integrated Security=True");
        public static void RenvoyerDt() 
        {
            OleDbConnection cnx = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\Custom Office Templates\BASE DE DONNEES 2021 2022.xlsx;Extended Properties=""Excel 12.0 Xml; HDR = YES"";");
            cnx.Open();
            OleDbCommand com = new OleDbCommand("select * from [Export$]", cnx);
            OleDbDataReader dr = com.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            cnx.Close();
        }
        public static void RenvoyerDt1()
        {
            OleDbConnection cnx = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\Custom Office Templates\absence.xls;Extended Properties=""Excel 12.0 Xml; HDR = YES"";");
            cnx.Open();
            OleDbCommand com = new OleDbCommand("select * from [absence$]", cnx);
            OleDbDataReader dr = com.ExecuteReader();
            dt1.Load(dr);
            dr.Close();
            cnx.Close();
        }
        public static void FillDataBase()
        {
            RenvoyerDt();
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QV3FUH3\SQLEXPRESS;Initial Catalog=IstaAinAtiq;Integrated Security=True");
            cn.Open();
            SqlBulkCopy copy = new SqlBulkCopy(cn);
            copy.DestinationTableName = "stagiaire";
            copy.BulkCopyTimeout = 0;
            copy.WriteToServer(dt);
            cn.Close();
        }
        public static void FillDataBaseAbs()
        {
            RenvoyerDt1();
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QV3FUH3\SQLEXPRESS;Initial Catalog=IstaAinAtiq;Integrated Security=True");
            cn.Open();
            SqlBulkCopy copy = new SqlBulkCopy(cn);
            copy.DestinationTableName = "absence";
            copy.BulkCopyTimeout = 0;
            copy.WriteToServer(dt1);
            cn.Close();
        }
        public static DataTable AfficherDataBase()
        {
            DataTable dt1 = new DataTable();
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QV3FUH3\SQLEXPRESS;Initial Catalog=IstaAinAtiq;Integrated Security=True");
            SqlDataAdapter adapt = new SqlDataAdapter("select * from stagiaire",cn);
            adapt.Fill(dt1);
            return dt1;
        }
        public static void ClearDataBase()
        {
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QV3FUH3\SQLEXPRESS;Initial Catalog=IstaAinAtiq;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("delete from stagiaire",cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static DataTable ChercherDataBase(string ch)
        {
            DataTable dt2 = new DataTable();
            //SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QV3FUH3\SQLEXPRESS;Initial Catalog=IstaAinAtiq;Integrated Security=True");
            SqlDataAdapter adapt2 = new SqlDataAdapter("select * from stagiaire where id_inscriptionsessionprogramme like '%"+ch+ "%' or MatriculeEtudiant like '%" + ch + "%' " +
            "or Nom like '%" + ch + "%' or Prenom like '%" + ch + "%' or Sexe like '%" + ch + "%' " +
            "or EtudiantActif like '%" + ch + "%' or Principale like '%" + ch + "%' or LibelleLong like '%" + ch + "%' " +
            "or CodeDiplome like '%" + ch + "%' or EtudiantPayant like '%" + ch + "%' or codediplome1 like '%" + ch + "%' " +
            "or prenom2 like '%" + ch + "%' or DateNaissance like '%" + ch + "%' or Site like '%" + ch + "%' " +
            "or DateInscription like '%" + ch + "%' or DateDossierComplet like '%" + ch + "%' or LieuNaissance like '%" + ch + "%' " +
            "or MotifAdmission like '%" + ch + "%' or CIN like '%" + ch + "%' or NTelelephone like '%" + ch + "%' " +
            "or Adresse like '%" + ch + "%' or anneeEtude like '%" + ch + "%' or NiveauScolaire like '%" + ch + "%' " +
            "or Nationalite like '%" + ch + "%'", cn);
            adapt2.SelectCommand.Parameters.AddWithValue("@ch", ch);
            adapt2.Fill(dt2);
            return dt2;
        }
    }
}
