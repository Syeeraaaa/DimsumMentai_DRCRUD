namespace CRUDMahasiswaADO
{
    partial class Rekap_Data_Mhscs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Prodi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Tahun = new System.Windows.Forms.DateTimePicker();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.Btn_Cetak = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "REKAP DATA MAHASISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prodi";
            // 
            // cmb_Prodi
            // 
            this.cmb_Prodi.FormattingEnabled = true;
            this.cmb_Prodi.Location = new System.Drawing.Point(249, 97);
            this.cmb_Prodi.Name = "cmb_Prodi";
            this.cmb_Prodi.Size = new System.Drawing.Size(121, 28);
            this.cmb_Prodi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tahun Masuk";
            // 
            // dtp_Tahun
            // 
            this.dtp_Tahun.Location = new System.Drawing.Point(529, 97);
            this.dtp_Tahun.Name = "dtp_Tahun";
            this.dtp_Tahun.Size = new System.Drawing.Size(200, 26);
            this.dtp_Tahun.TabIndex = 4;
            // 
            // Btn_Load
            // 
            this.Btn_Load.Location = new System.Drawing.Point(776, 90);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(91, 31);
            this.Btn_Load.TabIndex = 5;
            this.Btn_Load.Text = "Load";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // Btn_Cetak
            // 
            this.Btn_Cetak.Location = new System.Drawing.Point(776, 589);
            this.Btn_Cetak.Name = "Btn_Cetak";
            this.Btn_Cetak.Size = new System.Drawing.Size(91, 31);
            this.Btn_Cetak.TabIndex = 6;
            this.Btn_Cetak.Text = "Cetak";
            this.Btn_Cetak.UseVisualStyleBackColor = true;
            this.Btn_Cetak.Click += new System.EventHandler(this.Btn_Cetak_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(91, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(808, 416);
            this.dataGridView1.TabIndex = 7;
            // 
            // Rekap_Data_Mhscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 632);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Cetak);
            this.Controls.Add(this.Btn_Load);
            this.Controls.Add(this.dtp_Tahun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Prodi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Rekap_Data_Mhscs";
            this.Text = "Rekap_Data_Mhscs";
            this.Load += new System.EventHandler(this.Rekap_Data_Mhscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Prodi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Tahun;
        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.Button Btn_Cetak;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}