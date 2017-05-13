using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FirstChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {    // ordonnée
            
            FirstChart.ChartAreas[0].AxisY.Maximum = 30.00;
            FirstChart.ChartAreas[0].AxisY.Minimum = 0.00;
            FirstChart.ChartAreas[0].AxisX.Maximum = 25;
            FirstChart.ChartAreas[0].AxisX.Minimum = 0.00;
            FirstChart.ChartAreas[0].AxisY.Title = "kV";

            FirstChart.ChartAreas[0].AxisX.Title = "mA";

            var serie = new Series("U");
            serie.Color = Color.Blue;
            serie.ChartType = SeriesChartType.Line;
            serie.Points.DataBindXY(new[] { 4.4, 8.8 , 13.2, 15.84,18.48,20.24,22},
                                            new[] { 0.34, 0.52, 1.06, 1.58,10.53,17.18,28.38 });
            var serie1 = new Series("V");
            serie1.Color = Color.Red;
            serie1.ChartType = SeriesChartType.Line;
            serie1.Points.DataBindXY(new[] { 4.4, 8.8, 13.2, 15.84, 18.48,20.24,22 },
                                            new[] { 0.52,0.94, 1.45,2.11,2.90,4.24,6.03 });
            var serie2 = new Series("W");
            serie2.Color = Color.Green;
            serie2.ChartType = SeriesChartType.Line;
            serie2.Points.DataBindXY(new[] { 4.4, 8.8, 13.2, 15.84, 18.48, 20.24, 22 },
                                            new[] { 0.45,0.57,1.67,3.12,4.93,6.59,8.18 });
            serie.IsVisibleInLegend = true;
            FirstChart.Series.Add(serie);
            FirstChart.Series.Add(serie1);
            FirstChart.Series.Add(serie2);
            FirstChart.Legends.Add(new Legend("Automatiser des mésures"));

            button2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FirstChart.Show();
            this.button1.Hide();
            button2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirstChart.Hide();
            button1.Show();
            button2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataForm d = new DataForm();
            d.Show();
            
        }

        private void FirstChart_Click(object sender, EventArgs e)
        {

        }
    }
}
