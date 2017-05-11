using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstChart.DAL
{
    class CodeDB
    {

        //variable connection
        protected static SqlConnection con;
        //open connection*
        public static SqlConnection Open()
        {
            con = new SqlConnection(@"Data Source=MEJDI\SQLEXPRESS;Initial Catalog=Mesure;Integrated Security=True;Pooling=False");
            try
            {
                if (con.State.ToString() != "Open")
                {
                    con.Open();

                }
                return con;
            }
            catch (SqlException ex)
            {
                return null;

            }
        }


        public static void GetConnection()
        {
            con.Open();
        }
        //close connection
        public static bool Close()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
