namespace FirstChart
{
    partial class DataForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.button1 = new System.Windows.Forms.Button();
            this.ajoutMesure = new System.Windows.Forms.Button();
            this.paneldata = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.typeCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AmpereTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VoltTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TempTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.MesureDtv = new System.Windows.Forms.DataGridView();
            this.panelCourbe = new System.Windows.Forms.Panel();
            this.CourbeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.paneldata.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesureDtv)).BeginInit();
            this.panelCourbe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourbeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(72, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Afficher le courbe";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ajoutMesure
            // 
            this.ajoutMesure.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ajoutMesure.Location = new System.Drawing.Point(540, 12);
            this.ajoutMesure.Name = "ajoutMesure";
            this.ajoutMesure.Size = new System.Drawing.Size(349, 36);
            this.ajoutMesure.TabIndex = 4;
            this.ajoutMesure.Text = "Ajouter des mésures";
            this.ajoutMesure.UseVisualStyleBackColor = false;
            this.ajoutMesure.Click += new System.EventHandler(this.ajoutMesure_Click);
            // 
            // paneldata
            // 
            this.paneldata.Controls.Add(this.groupBox1);
            this.paneldata.Controls.Add(this.MesureDtv);
            this.paneldata.Location = new System.Drawing.Point(10, 54);
            this.paneldata.Name = "paneldata";
            this.paneldata.Size = new System.Drawing.Size(914, 381);
            this.paneldata.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typeCmb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AmpereTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.VoltTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TempTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Location = new System.Drawing.Point(62, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter une valeur";
            // 
            // typeCmb
            // 
            this.typeCmb.FormattingEnabled = true;
            this.typeCmb.Location = new System.Drawing.Point(644, 31);
            this.typeCmb.Name = "typeCmb";
            this.typeCmb.Size = new System.Drawing.Size(104, 21);
            this.typeCmb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(578, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type :";
            // 
            // AmpereTxt
            // 
            this.AmpereTxt.Location = new System.Drawing.Point(468, 29);
            this.AmpereTxt.Name = "AmpereTxt";
            this.AmpereTxt.Size = new System.Drawing.Size(76, 20);
            this.AmpereTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ampere :";
            // 
            // VoltTxt
            // 
            this.VoltTxt.Location = new System.Drawing.Point(275, 28);
            this.VoltTxt.Name = "VoltTxt";
            this.VoltTxt.Size = new System.Drawing.Size(76, 20);
            this.VoltTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Voltage:";
            // 
            // TempTxt
            // 
            this.TempTxt.Location = new System.Drawing.Point(80, 28);
            this.TempTxt.Name = "TempTxt";
            this.TempTxt.Size = new System.Drawing.Size(80, 20);
            this.TempTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temp : ";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(346, 68);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(128, 32);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Ajouter un valeur";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // MesureDtv
            // 
            this.MesureDtv.AllowDrop = true;
            this.MesureDtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MesureDtv.Location = new System.Drawing.Point(204, 146);
            this.MesureDtv.Name = "MesureDtv";
            this.MesureDtv.Size = new System.Drawing.Size(484, 188);
            this.MesureDtv.TabIndex = 4;
            // 
            // panelCourbe
            // 
            this.panelCourbe.Controls.Add(this.CourbeChart);
            this.panelCourbe.Location = new System.Drawing.Point(13, 67);
            this.panelCourbe.Name = "panelCourbe";
            this.panelCourbe.Size = new System.Drawing.Size(911, 367);
            this.panelCourbe.TabIndex = 6;
            this.panelCourbe.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCourbe_Paint);
            // 
            // CourbeChart
            // 
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.CourbeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CourbeChart.Legends.Add(legend1);
            this.CourbeChart.Location = new System.Drawing.Point(13, 51);
            this.CourbeChart.Name = "CourbeChart";
            this.CourbeChart.Size = new System.Drawing.Size(877, 303);
            this.CourbeChart.TabIndex = 0;
            this.CourbeChart.Text = "chart1";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 437);
            this.Controls.Add(this.panelCourbe);
            this.Controls.Add(this.paneldata);
            this.Controls.Add(this.ajoutMesure);
            this.Controls.Add(this.button1);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.paneldata.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesureDtv)).EndInit();
            this.panelCourbe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourbeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ajoutMesure;
        private System.Windows.Forms.Panel paneldata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox typeCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AmpereTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VoltTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TempTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView MesureDtv;
        private System.Windows.Forms.Panel panelCourbe;
        private System.Windows.Forms.DataVisualization.Charting.Chart CourbeChart;
    }
}