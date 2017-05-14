namespace FirstChart
{
    partial class Courbe1Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnCourbe1 = new System.Windows.Forms.Button();
            this.AjouterBtnCourb1 = new System.Windows.Forms.Button();
            this.panelCourbe = new System.Windows.Forms.Panel();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.combType = new System.Windows.Forms.ComboBox();
            this.TextAmper = new System.Windows.Forms.TextBox();
            this.TextVolt = new System.Windows.Forms.TextBox();
            this.TxtTemp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridCourb1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CourbeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelCourbe.SuspendLayout();
            this.PanelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourb1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourbeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCourbe1
            // 
            this.btnCourbe1.Location = new System.Drawing.Point(13, 9);
            this.btnCourbe1.Name = "btnCourbe1";
            this.btnCourbe1.Size = new System.Drawing.Size(283, 39);
            this.btnCourbe1.TabIndex = 0;
            this.btnCourbe1.Text = "Afficher courbe";
            this.btnCourbe1.UseVisualStyleBackColor = true;
            this.btnCourbe1.Click += new System.EventHandler(this.btnCourbe1_Click);
            // 
            // AjouterBtnCourb1
            // 
            this.AjouterBtnCourb1.Location = new System.Drawing.Point(459, 12);
            this.AjouterBtnCourb1.Name = "AjouterBtnCourb1";
            this.AjouterBtnCourb1.Size = new System.Drawing.Size(319, 36);
            this.AjouterBtnCourb1.TabIndex = 1;
            this.AjouterBtnCourb1.Text = "Ajouter in valeur";
            this.AjouterBtnCourb1.UseVisualStyleBackColor = true;
            this.AjouterBtnCourb1.Click += new System.EventHandler(this.AjouterBtnCourb1_Click);
            // 
            // panelCourbe
            // 
            this.panelCourbe.Controls.Add(this.CourbeChart);
            this.panelCourbe.Location = new System.Drawing.Point(13, 69);
            this.panelCourbe.Name = "panelCourbe";
            this.panelCourbe.Size = new System.Drawing.Size(765, 305);
            this.panelCourbe.TabIndex = 2;
            this.panelCourbe.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCourbe_Paint);
            // 
            // PanelAdd
            // 
            this.PanelAdd.Controls.Add(this.groupBox1);
            this.PanelAdd.Controls.Add(this.dataGridCourb1);
            this.PanelAdd.Location = new System.Drawing.Point(16, 72);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(762, 302);
            this.PanelAdd.TabIndex = 3;
            // 
            // combType
            // 
            this.combType.FormattingEnabled = true;
            this.combType.Items.AddRange(new object[] {
            "U",
            "V",
            "W"});
            this.combType.Location = new System.Drawing.Point(514, 22);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(129, 21);
            this.combType.TabIndex = 8;
            // 
            // TextAmper
            // 
            this.TextAmper.Location = new System.Drawing.Point(366, 23);
            this.TextAmper.Name = "TextAmper";
            this.TextAmper.Size = new System.Drawing.Size(65, 20);
            this.TextAmper.TabIndex = 7;
            // 
            // TextVolt
            // 
            this.TextVolt.Location = new System.Drawing.Point(200, 23);
            this.TextVolt.Name = "TextVolt";
            this.TextVolt.Size = new System.Drawing.Size(65, 20);
            this.TextVolt.TabIndex = 6;
            // 
            // TxtTemp
            // 
            this.TxtTemp.Location = new System.Drawing.Point(57, 23);
            this.TxtTemp.Name = "TxtTemp";
            this.TxtTemp.Size = new System.Drawing.Size(65, 20);
            this.TxtTemp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ampère :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Volt :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temps :";
            // 
            // dataGridCourb1
            // 
            this.dataGridCourb1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCourb1.Location = new System.Drawing.Point(145, 125);
            this.dataGridCourb1.Name = "dataGridCourb1";
            this.dataGridCourb1.Size = new System.Drawing.Size(417, 163);
            this.dataGridCourb1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.combType);
            this.groupBox1.Controls.Add(this.TextAmper);
            this.groupBox1.Controls.Add(this.TextVolt);
            this.groupBox1.Controls.Add(this.TxtTemp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 103);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter une valeur";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ajouter valeur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CourbeChart
            // 
            this.CourbeChart.BackColor = System.Drawing.Color.Transparent;
            this.CourbeChart.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.CourbeChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.CourbeChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Silver;
            chartArea2.Name = "ChartArea1";
            this.CourbeChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.CourbeChart.Legends.Add(legend2);
            this.CourbeChart.Location = new System.Drawing.Point(36, 42);
            this.CourbeChart.Name = "CourbeChart";
            this.CourbeChart.Size = new System.Drawing.Size(477, 229);
            this.CourbeChart.TabIndex = 0;
            this.CourbeChart.Text = "chart1";
            // 
            // Courbe1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 376);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.panelCourbe);
            this.Controls.Add(this.AjouterBtnCourb1);
            this.Controls.Add(this.btnCourbe1);
            this.Name = "Courbe1Form";
            this.Text = "Courbe1Form";
            this.Load += new System.EventHandler(this.Courbe1Form_Load);
            this.panelCourbe.ResumeLayout(false);
            this.PanelAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourb1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourbeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCourbe1;
        private System.Windows.Forms.Button AjouterBtnCourb1;
        private System.Windows.Forms.Panel panelCourbe;
        private System.Windows.Forms.Panel PanelAdd;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.TextBox TextAmper;
        private System.Windows.Forms.TextBox TextVolt;
        private System.Windows.Forms.TextBox TxtTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridCourb1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CourbeChart;
    }
}