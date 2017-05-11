using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstChart.Model
{
    class Mesure_Model
    {
        public int Id { get; set; }
        public DateTime Temps { get; set; }
        public decimal Volt { get; set; }
        public decimal Amper { get; set; }
        public string Type { get; set; }

        public Mesure_Model() { }
        public Mesure_Model(DataRow dr)
        {
            Id = (int)dr["Id"];
            Temps = (DateTime)dr["Temps"];
            Volt = (decimal)dr["Volt"];
            Amper = (decimal)dr["Amper"];
            Type = (string)dr["Type"];
        }
        public static List<Mesure_Model> GetList(DataTable dt)
        {

            List<Mesure_Model> a = new List<Mesure_Model>();
            foreach (DataRow dr in dt.Rows)
            {
                a.Add(new Mesure_Model(dr));
            }
            return a;

        }

    }
}
