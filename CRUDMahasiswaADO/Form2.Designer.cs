namespace CRUDMahasiswaADO
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cmbTipe = new System.Windows.Forms.ComboBox();
            this.btn_Data_Mhs = new System.Windows.Forms.Button();
            this.chartProdi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahun Masuk";
            // 
            // dtpTanggalMasuk
            // 
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(181, 80);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(200, 26);
            this.dtpTanggalMasuk.TabIndex = 1;
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Load.Location = new System.Drawing.Point(414, 77);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(97, 32);
            this.btn_Load.TabIndex = 2;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Red;
            this.btn_Reset.Location = new System.Drawing.Point(530, 77);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(97, 32);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // cmbTipe
            // 
            this.cmbTipe.FormattingEnabled = true;
            this.cmbTipe.Location = new System.Drawing.Point(973, 85);
            this.cmbTipe.Name = "cmbTipe";
            this.cmbTipe.Size = new System.Drawing.Size(145, 28);
            this.cmbTipe.TabIndex = 4;
            this.cmbTipe.SelectedValueChanged += new System.EventHandler(this.cmbTipe_SelectedValueChanged);
            // 
            // btn_Data_Mhs
            // 
            this.btn_Data_Mhs.BackColor = System.Drawing.Color.White;
            this.btn_Data_Mhs.Location = new System.Drawing.Point(973, 678);
            this.btn_Data_Mhs.Name = "btn_Data_Mhs";
            this.btn_Data_Mhs.Size = new System.Drawing.Size(157, 32);
            this.btn_Data_Mhs.TabIndex = 5;
            this.btn_Data_Mhs.Text = "Data Mahasiswa";
            this.btn_Data_Mhs.UseVisualStyleBackColor = false;
            this.btn_Data_Mhs.Click += new System.EventHandler(this.btn_Data_Mhs_Click);
            // 
            // chartProdi
            // 
            chartArea3.Name = "ChartArea1";
            this.chartProdi.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartProdi.Legends.Add(legend3);
            this.chartProdi.Location = new System.Drawing.Point(72, 165);
            this.chartProdi.Name = "chartProdi";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartProdi.Series.Add(series3);
            this.chartProdi.Size = new System.Drawing.Size(1103, 473);
            this.chartProdi.TabIndex = 6;
            this.chartProdi.Text = "chart1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 786);
            this.Controls.Add(this.chartProdi);
            this.Controls.Add(this.btn_Data_Mhs);
            this.Controls.Add(this.cmbTipe);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.dtpTanggalMasuk);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.ComboBox cmbTipe;
        private System.Windows.Forms.Button btn_Data_Mhs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdi;
    }
}