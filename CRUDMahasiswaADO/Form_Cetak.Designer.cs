namespace CRUDMahasiswaADO
{
    partial class frm_CetakData
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Rprt_ctk = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cetakk1 = new CRUDMahasiswaADO.cetakk();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1220, 681);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Rprt_ctk
            // 
            this.Rprt_ctk.ActiveViewIndex = 0;
            this.Rprt_ctk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rprt_ctk.Cursor = System.Windows.Forms.Cursors.Default;
            this.Rprt_ctk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rprt_ctk.Location = new System.Drawing.Point(0, 0);
            this.Rprt_ctk.Name = "Rprt_ctk";
            this.Rprt_ctk.ReportSource = this.cetakk1;
            this.Rprt_ctk.ShowCloseButton = false;
            this.Rprt_ctk.ShowCopyButton = false;
            this.Rprt_ctk.ShowGroupTreeButton = false;
            this.Rprt_ctk.ShowParameterPanelButton = false;
            this.Rprt_ctk.ShowRefreshButton = false;
            this.Rprt_ctk.Size = new System.Drawing.Size(1397, 658);
            this.Rprt_ctk.TabIndex = 0;
            this.Rprt_ctk.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_CetakData
            // 
            this.ClientSize = new System.Drawing.Size(1397, 658);
            this.Controls.Add(this.Rprt_ctk);
            this.Name = "frm_CetakData";
            this.Text = "CETAK DATA";
            this.Load += new System.EventHandler(this.frm_CetakData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer Rprt_ctk;
        private Rekap_Data_Mhscs Report1;
        private cetakk cetakk1;
    }
}