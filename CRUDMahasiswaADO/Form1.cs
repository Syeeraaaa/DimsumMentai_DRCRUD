using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace CRUDMahasiswaADO
{
    DAL dbLogic = new DAL();
    public partial class Form1 : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private DataTable dtMahasiswa = new DataTable();
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=DESKTOP-A1J1BDF\\SYEERA;Initial Catalog=DBAkademikADO;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void ConnectDatabase()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                MessageBox.Show("Koneksi Berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal: " + ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBAkademikADODataSet.Mahasiswa' table. You can move, or remove it, as needed.
            //this.mahasiswaTableAdapter.Fill(this.dBAkademikADODataSet.Mahasiswa);
            //cmbJK.Items.Clear();
            //cmbJK.Items.Add("L");
            //cmbJK.Items.Add("P");

            // ComboBox JK manual
            cmbJK.DataSource = new string[] { "L", "p" };

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dataGridView1.CellClick += dataGridView1_CellClick;

            //BindingNavigator
            bindingNavigator1.BindingSource = bindingSource;
            LoadData();

        }

        private void LoadData()
        {
            try
            {
                bindingSource.DataSource = dbLogic.GetMhs();
                dataGridView1.DataSource = bindingSource;
                DataGridViewImageColumn fotoColumn = (DataGridViewImageColumn)dataGridView1.Columns["Foto"];
                fotoColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                HitungTotal();
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    Console.WriteLine("Name: " + col.Name + " | DataPropertyName: " + col.DataPropertyName);
                }
                dataGridView1.Enabled = true;
                btn_ImprtDB.Enabled = false;
                btn_ImprtExcel.Enabled = true;
                btnDelete.Enabled = true;
                btn_Cari.Enabled = true;
                btnLoad.Enabled = true;
                btnResetData.Enabled = true;
                btnTestInjection.Enabled = true;

            }
            
            catch (Exception ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("Gagal load data: " + ex.Message);
            }
        }

        private void BindControls()
        {
            txtNIM.DataBindings.Clear();
            txtNama.DataBindings.Clear();
            cmbJK.DataBindings.Clear();
            dtpTanggalLahir.DataBindings.Clear();
            txtAlamat.DataBindings.Clear();
            txtKodeProdi.DataBindings.Clear();

            txtNIM.DataBindings.Add("Text", bindingSource, "NIM");
            txtNama.DataBindings.Add("Text", bindingSource, "Nama");
            cmbJK.DataBindings.Add("Text", bindingSource, "JenisKelamin");
            dtpTanggalLahir.DataBindings.Add("Text", bindingSource, "TanggalLahir");
            txtAlamat.DataBindings.Add("Text", bindingSource, "Alamat");
            txtKodeProdi.DataBindings.Add("Text", bindingSource, "KodeProdi");
        }

        // ===================
        // CONNECT TEST
        // ====================
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(dbLogic.GetConnectionString()))
                {
                    conn.Open();
                    MessageBox.Show("Koneksi Berhasil!");
                }
            }
            catch(SqlException ex)
            {
                simpanLog(ex.Message);
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                simpanLog(ex.Message);
                MessageBox.Show("General Error: " + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlTransaction trans = conn.BeginTransaction();
            try
            {

                
                    //conn.Open();
                    //string query = @"insert into Mahasiswa (NIM, Nama, JenisKelamin, TanggalLahir, Alamat, KodeProdi, TanggalDaftar)
                    //values (@NIM, @Nama, @JK, @TanggalLahir, @Alamat, @KodeProdi, @TanggalDaftar)";


                    {
                        SqlCommand cmd = new SqlCommand("sp_InsertMahasiswa", conn, trans);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NIM", txtNIM.Text);

                        cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
                        cmd.Parameters.AddWithValue("@JenisKelamin", cmbJK.Text);
                        cmd.Parameters.AddWithValue("@TanggalLahir", dtpTanggalLahir.Value.Date);
                        cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
                        cmd.Parameters.AddWithValue("@KodeProdi", txtKodeProdi.Text);
                        cmd.Parameters.AddWithValue("@TanggalDafat", DateTime.Now);
                        
                        cmd.ExecuteNonQuery();

                    SqlCommand cmdLog = new SqlCommand(@"insert into LogAktivitasSalah (aktivitas, waktu) values (@aktivitas,getdate())",
                        conn, trans);

                    cmdLog.Parameters.AddWithValue("@aktivitas", "insert Mahasiswa : " + txtNIM.Text);

                    cmdLog.ExecuteNonQuery();

                    trans.Commit();

                    MessageBox.Show("Data berhasil disimpan!");

                    LoadData();
                    }
                
            }
            catch (SqlException ex)
            {
                trans.Rollback();

                SimpanLog("Rollback Insert : " + ex.Message);

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                trans.Rollback();
                SimpanLog("General Error : " + ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //if (conn.State == System.Data.ConnectionState.Closed)
                //{
                    //conn.Open();
                //}

                //string query = @"Update Mahasiswa set Nama = @Nama, JenisKelamin = @JK, TanggalLahir = @TanggalLahir,
                //Alamat = @Alamat,
                //KodeProdi = @KodeProdi where NIM = @NIM";

                using (SqlCommand cmd = new SqlCommand("sp_UpdateMahasiswaa", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NIM", txtNIM.Text);
                    cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@JenisKelamin", cmbJK.Text);
                    cmd.Parameters.AddWithValue("@TanggalLahir", dtpTanggalLahir.Value.Date);
                    cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@KodeProdi", txtKodeProdi.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result < 0)
                    {
                        MessageBox.Show("Data berhasil diupdate!");
                        ClearForm();
                        btnLoad.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                DialogResult resultConfirm = MessageBox.Show(
                    "Yakin ingin menghapus data?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultConfirm == DialogResult.Yes)
                {
                    //string query = "delete from Mahasiswa where NIM = @NIM";
                    //SqlCommand cmd = new SqlCommand(query, conn);
                    //cmd.Parameters.AddWithValue("@NIM", txtNIM.Text);

                    //int result = cmd.ExecuteNonQuery();
                    using (SqlCommand cmd = new SqlCommand("sp_DeleteMahasiswa", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@NIM", SqlDbType.Char, 11).Value = txtNIM.Text;
                        //conn.Open();
                        int rowsAffected = cmd. ExecuteNonQuery();

                        if (rowsAffected < 0)
                            MessageBox.Show("Data berhasil dihapus!");
                        else
                            MessageBox.Show("Data tidak ditemukan!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtNIM.Text = row.Cells["NIM"].Value.ToString();
                txtNama.Text = row.Cells["Nama"].Value.ToString();
                cmbJK.Text = row.Cells["JenisKelamin"].Value.ToString();
                dtpTanggalLahir.Value = Convert.ToDateTime(row.Cells["TanggalLahir"].Value);
                txtAlamat.Text = row.Cells["Alamat"].Value.ToString();
                txtKodeProdi.Text = row.Cells["KodeProdi"].Value.ToString();

            }
        }

        private void ClearForm()
        {
            txtNIM.Enabled = true;
            txtNIM.Clear();
            txtNama.Clear();
            cmbJK.SelectedIndex = -1;
            txtAlamat.Clear();
            txtKodeProdi.Clear();
            dtpTanggalLahir.Value = DateTime.Now;
            fotoMhs.Image = null;
            txtNIM.Focus();
        }
        public void simpanLog(string message)
        {
            dbLogic.InsertLog(message);
        }


        private void cmbJK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @" if object_id('dbo.Mahasiswa_Backup') is not null 
                            begin delete from dbo.Mahasiswa; insert into dbo.Mahasiswa select * from dbo.Mahasiswa_backup; end";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Data berhasil direset!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reset gagal: " + ex.Message);
            }
        }

        private void btnTestInjection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "Update Mahasiswa SET Nama='" + txtNama.Text + "'where NIM='" + txtNIM.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update berhasil");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void HitungTotal()
        {
            try
            {
                int total = (dbLogic.CountMhs().Equals(DBNull.Value)) ? 0 : dbLogic.CountMhs();
                lblCountMhs.Text = "Total Mahasiswa : " + total;
            }
            catch(Exception ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("Gagal menghitung total: " + ex.Message);
            }
        }

        private void SimpanLog(string pesan)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"insert into LogError values(getdate(), @pesan)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pesan", pesan);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rekap_Data_Mhscs fm3 = new Rekap_Data_Mhscs();
            fm3.Show();
            this.Hide();
        }
    }
}
