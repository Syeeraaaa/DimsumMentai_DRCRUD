using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class Rekap_Data_Mhscs : Form
    {
        static string connectionString = "Data Source=DESKTOP-A1J1BDF\\SYEERA;Initial Catalog=DBAkademikADO;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlDataAdapter da;
        DataTable dtMahasiswa;
        DataTable dtProdi;

        public Rekap_Data_Mhscs()
        {
            InitializeComponent();
        }

        private void Rekap_Data_Mhscs_Load(object sender, EventArgs e)
        {
           dtp_Tahun.Format = DateTimePickerFormat.Custom;
           dtp_Tahun.CustomFormat = "yyyy";
           dtp_Tahun.ShowUpDown = true;
           dtp_Tahun.MinDate = new DateTime(2000, 1, 1);
           dtp_Tahun.MaxDate = DateTime.Now;

            cmb_Prodi.DropDownStyle = ComboBoxStyle.DropDownList;

            Btn_Cetak.Enabled = false;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("Select NamaProdi from programstudi", conn);
                cmd.CommandType = CommandType.Text;
                dtProdi = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dtProdi);
                cmb_Prodi.DataSource = dtProdi;
                cmb_Prodi.DisplayMember = "NamaProdi";
                cmb_Prodi.ValueMember = "NamaProdi";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data: " + ex.Message);
            }
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("sp_Report", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@inProdi", SqlDbType.VarChar, 50).Value = cmb_Prodi.SelectedValue;
                cmd.Parameters.Add("@inTglMsuk", SqlDbType.VarChar, 4).Value = dtp_Tahun.Value.Year.ToString();

                da = new SqlDataAdapter(cmd);
                dtMahasiswa = new DataTable();
                da.Fill(dtMahasiswa);

                dataGridView1.DataSource = dtMahasiswa;

                if (dtMahasiswa.Rows.Count > 0)
                {
                    Btn_Cetak.Enabled = true;
                    
                }   
                else
                {   
                    Btn_Cetak.Enabled = false;
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Load data: " + ex.Message);
            }
        }

        private void Btn_Cetak_Click(object sender, EventArgs e)
        {
            frm_CetakData frm2 = new frm_CetakData(cmb_Prodi.SelectedValue.ToString(), dtp_Tahun.Value);
            frm2.Show();
            this.Hide();
        }
    }
}
