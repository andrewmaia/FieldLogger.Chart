namespace FieldLogger.Chart
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
            this.ChartPrincipal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpDataFiltro = new System.Windows.Forms.DateTimePicker();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.cbTag = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartPrincipal
            // 
            chartArea3.Name = "ChartArea1";
            this.ChartPrincipal.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartPrincipal.Legends.Add(legend3);
            this.ChartPrincipal.Location = new System.Drawing.Point(102, 32);
            this.ChartPrincipal.Name = "ChartPrincipal";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ChartPrincipal.Series.Add(series3);
            this.ChartPrincipal.Size = new System.Drawing.Size(562, 298);
            this.ChartPrincipal.TabIndex = 0;
            this.ChartPrincipal.Text = "chart1";
            // 
            // dtpDataFiltro
            // 
            this.dtpDataFiltro.Location = new System.Drawing.Point(286, 358);
            this.dtpDataFiltro.Name = "dtpDataFiltro";
            this.dtpDataFiltro.Size = new System.Drawing.Size(212, 20);
            this.dtpDataFiltro.TabIndex = 1;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(345, 415);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // cbTag
            // 
            this.cbTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTag.FormattingEnabled = true;
            this.cbTag.Items.AddRange(new object[] {
            "Umidade - %",
            "Radiação Solar - W/m²",
            "Velocidade.Vento - m/s",
            "Direção.Vento - °",
            "Temperatura.Ar - °C",
            "Temp.Contato - °C"});
            this.cbTag.Location = new System.Drawing.Point(320, 388);
            this.cbTag.Name = "cbTag";
            this.cbTag.Size = new System.Drawing.Size(136, 21);
            this.cbTag.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.cbTag);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.dtpDataFiltro);
            this.Controls.Add(this.ChartPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FieldLogger";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPrincipal;
        private System.Windows.Forms.DateTimePicker dtpDataFiltro;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ComboBox cbTag;
    }
}

