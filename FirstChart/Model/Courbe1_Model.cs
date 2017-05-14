using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstChart.Model
{
    class Courbe1_Model
    {
        public int Id { get; set; }
        public float Temps { get; set; }
        public float Volt { get; set; }
        public float Amper { get; set; }
        public string Type { get; set; }

        public Courbe1_Model() { }
        public Courbe1_Model(DataRow dr)
        {
            Id = (int)dr["Id"];
            Temps = float.Parse(dr["Temps"].ToString());
            Volt = float.Parse(dr["Volt"].ToString());
            Amper = float.Parse(dr["Amper"].ToString());
            Type = (string)dr["Type"];
        }
        public static List<Courbe1_Model> GetList(DataTable dt)
        {

            List<Courbe1_Model> a = new List<Courbe1_Model>();
            foreach (DataRow dr in dt.Rows)
            {
                a.Add(new Courbe1_Model(dr));
            }
            return a;

        }
    }
}
