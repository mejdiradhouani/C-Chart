using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstChart.Model;
using FirstChart.DAL;
using System.Windows.Forms.DataVisualization.Charting;

namespace FirstChart
{
    public partial class DataForm : Form
    {
        public List<float> listUVoltalues = new List<float>();
        public List<float> listUAmpertalues = new List<float>();
        public DataForm()
        {
            InitializeComponent();
            typeCmb.Items.Add("U");
            typeCmb.Items.Add("V");
            typeCmb.Items.Add("W");

          
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            MesureDtv.DataSource = DAL.Dal_Mesure.GetAll();
            MesureDtv.Columns[0].Visible = false;
            paneldata.Hide();
            panelCourbe.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<float> listUVoltValues = new List<float>();
            List<float> listUAmpValues = new List<float>();

            List<Mesure_Model> list = new List<Mesure_Model>();
            list = Dal_Mesure.GetAll();

            CourbeChart.ChartAreas[0].AxisY.Maximum = 30.00;
            CourbeChart.ChartAreas[0].AxisY.Minimum = 0.00;
            CourbeChart.ChartAreas[0].AxisY.Interval = 5;

            CourbeChart.ChartAreas[0].AxisX.Maximum = 30.00;
            CourbeChart.ChartAreas[0].AxisX.Minimum = 0.00;
            CourbeChart.ChartAreas[0].AxisX.Interval = 5;
            CourbeChart.ChartAreas[0].CursorX.AutoScroll = true;

            // let's zoom to [0,blockSize] (e.g. [0,100])
            CourbeChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            CourbeChart.ChartAreas[0].CursorY.AutoScroll = true;

            // let's zoom to [0,blockSize] (e.g. [0,100])
            CourbeChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            CourbeChart.ChartAreas[0].AxisX.Interval = 5;
            CourbeChart.ChartAreas[0].AxisY.Title = "mA";

            CourbeChart.ChartAreas[0].AxisX.Title = "KV";

            var serie = new Series("U");
            serie.Color = Color.Blue;
            serie.ChartType = SeriesChartType.Line;
            serie.MarkerStyle = MarkerStyle.Circle;



            //serie.Points.DataBindXY(listUVoltValues.ToArray(),listUAmpertalues.ToArray());

            var serie1 = new Series("V");
            serie1.Color = Color.Red;
            serie1.ChartType = SeriesChartType.Line;
            serie1.MarkerStyle = MarkerStyle.Star5;

            var serie2 = new Series("W");
            serie2.Color = Color.Green;
            serie2.ChartType = SeriesChartType.Line;
            serie2.MarkerStyle = MarkerStyle.Circle;
            foreach (var mesure in list)
            {
                if (mesure.Type == "U")
                {
                    serie.Points.AddXY(mesure.Volt, mesure.Amper);

                }
                else
                if (mesure.Type == "V")
                {
                    serie1.Points.AddXY(mesure.Volt, mesure.Amper);

                }
                else
                if (mesure.Type == "W")
                {
                    serie2.Points.AddXY(mesure.Volt, mesure.Amper);

                }

            }
            CourbeChart.Series.Add(serie);
            CourbeChart.Series.Add(serie1);
            CourbeChart.Series.Add(serie2);
            CourbeChart.Legends.Add(new Legend("Automatiser des mésures"));
            panelCourbe.Show();
            paneldata.Hide();

        }

        private void ajoutMesure_Click(object sender, EventArgs e)
        {
            paneldata.Show();
            panelCourbe.Hide();
            CourbeChart.Series.Clear();
            CourbeChart.Legends.Clear();


        }

        private void panelCourbe_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            if (TempTxt.Text.Length != 0 && VoltTxt.Text.Length != 0 && AmpereTxt.Text.Length != 0 && typeCmb.Text.Length != 0)
            {

                Mesure_Model m = new Mesure_Model();
                try
                {
                    m.Amper = float.Parse(AmpereTxt.Text);
                    m.Volt = float.Parse(VoltTxt.Text);
                    m.Type = typeCmb.Text.Trim();
                    m.Temps = float.Parse(TempTxt.Text);
                    DAL.Dal_Mesure.Create(m);
                    MesureDtv.DataSource = DAL.Dal_Mesure.GetAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Svp entrer des valeur valide");
                }


            }
            else
                MessageBox.Show("Svp entrer des valeur valide");
        }
    }
}
