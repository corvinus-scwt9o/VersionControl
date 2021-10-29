
namespace SOAP
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartRateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TolPicker = new System.Windows.Forms.DateTimePicker();
            this.IgPicker = new System.Windows.Forms.DateTimePicker();
            this.cbxValuta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // chartRateData
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRateData.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRateData.Legends.Add(legend3);
            this.chartRateData.Location = new System.Drawing.Point(286, 46);
            this.chartRateData.Name = "chartRateData";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRateData.Series.Add(series3);
            this.chartRateData.Size = new System.Drawing.Size(300, 300);
            this.chartRateData.TabIndex = 1;
            this.chartRateData.Text = "chart1";
            // 
            // TolPicker
            // 
            this.TolPicker.Location = new System.Drawing.Point(13, 20);
            this.TolPicker.Name = "TolPicker";
            this.TolPicker.Size = new System.Drawing.Size(200, 20);
            this.TolPicker.TabIndex = 2;
            this.TolPicker.Value = new System.DateTime(2020, 1, 1, 21, 56, 0, 0);
            this.TolPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // IgPicker
            // 
            this.IgPicker.Location = new System.Drawing.Point(220, 19);
            this.IgPicker.Name = "IgPicker";
            this.IgPicker.Size = new System.Drawing.Size(200, 20);
            this.IgPicker.TabIndex = 3;
            this.IgPicker.Value = new System.DateTime(2020, 6, 30, 21, 56, 0, 0);
            this.IgPicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // cbxValuta
            // 
            this.cbxValuta.FormattingEnabled = true;
            this.cbxValuta.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.cbxValuta.Location = new System.Drawing.Point(427, 18);
            this.cbxValuta.Name = "cbxValuta";
            this.cbxValuta.Size = new System.Drawing.Size(121, 21);
            this.cbxValuta.TabIndex = 4;
            this.cbxValuta.Text = "EUR";
            this.cbxValuta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxValuta);
            this.Controls.Add(this.IgPicker);
            this.Controls.Add(this.TolPicker);
            this.Controls.Add(this.chartRateData);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRateData;
        private System.Windows.Forms.DateTimePicker TolPicker;
        private System.Windows.Forms.DateTimePicker IgPicker;
        private System.Windows.Forms.ComboBox cbxValuta;
    }
}

