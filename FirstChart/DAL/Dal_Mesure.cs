using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstChart.Model;
using System.Data.SqlClient;
using System.Data;

namespace FirstChart.DAL
{
    class Dal_Mesure
    {
        public static List<Mesure_Model> GetAll()
        {
            List<Mesure_Model> b = new List<Mesure_Model>();
            CodeDB.Open();
            String req = "SELECT * FROM [Mesur]";
            SqlCommand getcom = new SqlCommand(req, CodeDB.Open());
            SqlDataAdapter da = new SqlDataAdapter(getcom);
            DataTable dt = new DataTable("Mesure");
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                b = Mesure_Model.GetList(dt);
            }
            CodeDB.Close();
            return b;
        }
        public static List<Mesure_Model> GetAllUValues()
        {
            List<Mesure_Model> b = new List<Mesure_Model>();
            CodeDB.Open();
            String req = "SELECT * FROM [Mesur] Type = \"U\"";
            SqlCommand getcom = new SqlCommand(req, CodeDB.Open());
            SqlDataAdapter da = new SqlDataAdapter(getcom);
            DataTable dt = new DataTable("Mesure");
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                b = Mesure_Model.GetList(dt);
            }
            CodeDB.Close();
            return b;
        }
        public static List<Mesure_Model> GetAllVValues()
        {
            List<Mesure_Model> b = new List<Mesure_Model>();
            CodeDB.Open();
            String req = "SELECT * FROM [Mesur] Type = \"V\"";
            SqlCommand getcom = new SqlCommand(req, CodeDB.Open());
            SqlDataAdapter da = new SqlDataAdapter(getcom);
            DataTable dt = new DataTable("Mesure");
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                b = Mesure_Model.GetList(dt);
            }
            CodeDB.Close();
            return b;
        }

        public static void Create(Mesure_Model b)
        {
            CodeDB.Open();
            string req = "INSERT INTO [Mesur] (Temps,Volt,Amper,Type) Values (@Temps,@Volt,@Amper,@Type)";
            SqlCommand cmd = new SqlCommand(req, CodeDB.Open());
            //declaration des prarmetre
            SqlParameter Titre = new SqlParameter("", DbType.String);
            SqlParameter Description = new SqlParameter("Description", DbType.String);
            SqlParameter Lieu = new SqlParameter("Lieu", DbType.String);
            SqlParameter pdate = new SqlParameter("pdate", DbType.DateTime);
            SqlParameter pIdcongre = new SqlParameter("@pIdCongre", DbType.Int16);
            //Remplissage des es param
            cmd.Parameters.AddWithValue("Temps", b.Temps);
            cmd.Parameters.AddWithValue("Volt", b.Volt);
            cmd.Parameters.AddWithValue("Amper", b.Amper);
            cmd.Parameters.AddWithValue("Type", b.Type);
            //excuter la requette 
            cmd.ExecuteNonQuery();
            CodeDB.Close();

        }


    }
}
