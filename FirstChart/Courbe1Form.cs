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
    public partial class Courbe1Form : Form
    {
        public Courbe1Form()
        {
            InitializeComponent();
        }

        private void Courbe1Form_Load(object sender, EventArgs e)
        {

            dataGridCourb1.DataSource = DAL.Dal_Courbe1.GetAll();
            refreshDTgv();
            PanelAdd.Hide();
            panelCourbe.Hide();
        }

        private void btnCourbe1_Click(object sender, EventArgs e)
        {
            List<float> listUVoltValues = new List<float>();
            List<float> listUAmpValues = new List<float>();

            List<Courbe1_Model> list = new List<Courbe1_Model>();
            list = Dal_Courbe1.GetAll();
            CourbeChart.ChartAreas[0].BackColor = Color.LightGray;
            CourbeChart.ChartAreas[0].AxisY.Maximum = 4;
            CourbeChart.ChartAreas[0].AxisY.Minimum = 0.00;
            CourbeChart.ChartAreas[0].AxisY.Interval = 0.5;

            CourbeChart.ChartAreas[0].AxisX.Maximum = 11;
            CourbeChart.ChartAreas[0].AxisX.Minimum = 0.00;
            CourbeChart.ChartAreas[0].AxisX.Interval = 1;
            CourbeChart.ChartAreas[0].CursorX.AutoScroll = true;

            // let's zoom to [0,blockSize] (e.g. [0,100])
            CourbeChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            CourbeChart.ChartAreas[0].CursorY.AutoScroll = true;

            // let's zoom to [0,blockSize] (e.g. [0,100])
            CourbeChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            CourbeChart.ChartAreas[0].AxisX.Interval = 1;
            CourbeChart.ChartAreas[0].AxisY.Title = "mA";

            CourbeChart.ChartAreas[0].AxisX.Title = "Temps";

            var serie = new Series("U");
            serie.Color = Color.Blue;
            serie.ChartType = SeriesChartType.Line;
            serie.MarkerStyle = MarkerStyle.Diamond;



            //serie.Points.DataBindXY(listUVoltValues.ToArray(),listUAmpertalues.ToArray());

            var serie1 = new Series("V");
            serie1.Color = Color.HotPink;
            serie1.ChartType = SeriesChartType.Line;
            serie1.MarkerStyle = MarkerStyle.Square;

            var serie2 = new Series("W");
            serie2.Color = Color.Yellow;
            serie2.ChartType = SeriesChartType.Line;
            serie2.MarkerStyle = MarkerStyle.Triangle;
            foreach (var mesure in list)
            {
                if (mesure.Type == "U")
                {
                    serie.Points.AddXY(mesure.Temps, mesure.Volt);

                }
                else
                if (mesure.Type == "V")
                {
                    serie1.Points.AddXY(mesure.Temps, mesure.Volt);

                }
                else
                if (mesure.Type == "W")
                {
                    serie2.Points.AddXY(mesure.Temps, mesure.Volt);

                }

            }
            CourbeChart.Series.Add(serie);
            CourbeChart.Series.Add(serie1);
            CourbeChart.Series.Add(serie2);
            CourbeChart.Legends.Add(new Legend("Automatiser des mésures"));
            PanelAdd.Hide();
            panelCourbe.Show();
           
        }

        private void AjouterBtnCourb1_Click(object sender, EventArgs e)
        {

            CourbeChart.Series.Clear();
            CourbeChart.Legends.Clear();
            panelCourbe.Hide();
            PanelAdd.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshDTgv();
        }

        private void refreshDTgv()
        {
            dataGridCourb1.DataSource = DAL.Dal_Courbe1.GetAll();
            dataGridCourb1.Columns[0].Visible = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TextAmper_TextChanged(object sender, EventArgs e)
        {

        }

        private void combType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PanelAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void combType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void TextAmper_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridCourb1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelCourbe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextVolt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (TxtTemp.Text.Length != 0 && TextVolt.Text.Length != 0 && TextAmper.Text.Length != 0 && combType.Text.Length != 0)
            {

                Courbe1_Model m = new Courbe1_Model();
                try
                {
                    m.Amper = float.Parse(TextAmper.Text);
                    m.Volt = float.Parse(TextVolt.Text);
                    m.Type = combType.Text.Trim();
                    m.Temps = float.Parse(TxtTemp.Text);
                    DAL.Dal_Courbe1.Create(m);
                    dataGridCourb1.DataSource = DAL.Dal_Courbe1.GetAll();
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
