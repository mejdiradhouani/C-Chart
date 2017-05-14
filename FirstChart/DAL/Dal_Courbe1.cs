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
    class Dal_Courbe1
    {
        public static List<Courbe1_Model> GetAll()
        {
            List<Courbe1_Model> b = new List<Courbe1_Model>();
            CodeDB.Open();
            String req = "SELECT * FROM [Courbe]";
            SqlCommand getcom = new SqlCommand(req, CodeDB.Open());
            SqlDataAdapter da = new SqlDataAdapter(getcom);
            DataTable dt = new DataTable("Courbe1");
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                b = Courbe1_Model.GetList(dt);
            }
            CodeDB.Close();
            return b;
        }
        public static void Create(Courbe1_Model b)
        {
            CodeDB.Open();
            string req = "INSERT INTO [Courbe] (Temps,Volt,Amper,Type) Values (@Temps,@Volt,@Amper,@Type)";
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
