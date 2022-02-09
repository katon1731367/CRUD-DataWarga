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

namespace UAS_IMELDA_202111547
{
    public partial class FormDesaPenarik : Form
    {
        SqlConnection con = new SqlConnection("Data Source=GYPSIDANGER367\\CHOWDER1731367;Initial Catalog=UAS;Integrated Security=True");

        public class Data
        {
            public string NIK, NamaLengkap, JenisKelamin, TempatLahir, Agama, Pendidikan, Pekerjaan;
            public DateTime TanggalLahir;
            public Nullable<int> Umur, Penghasilan;
        }

        public FormDesaPenarik()
        {
            InitializeComponent();
            InitPendidikan();
            InitAgama();
            InitFormatDate();
            InitPenghasilan();

            void InitPendidikan()
            {
                dupPendidikan.Items.Add("SD");
                dupPendidikan.Items.Add("SMP");
                dupPendidikan.Items.Add("SMA");
                dupPendidikan.Items.Add("S1");
                dupPendidikan.Items.Add("S2");
                dupPendidikan.ReadOnly = true;
            }

            void InitAgama()
            {
                comboAgama.Items.Add("Islam");
                comboAgama.Items.Add("Kristen");
                comboAgama.Items.Add("Katolik");
                comboAgama.Items.Add("Hindu");
                comboAgama.Items.Add("Buddha");
                comboAgama.Items.Add("Khonghucu");
                comboAgama.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            void InitFormatDate()
            {
                DtpTanggalLahir.CustomFormat = "dd/MM/yyyy";
                DtpTanggalLahir.Format = DateTimePickerFormat.Custom;
            }

            void InitPenghasilan()
            {
                nudPenghasilan.Maximum = 100000000;
                nudPenghasilan.ThousandsSeparator = true;
                nudPenghasilan.ReadOnly = true;
                nudPenghasilan.Increment = 500000;
            }
        }

        #region SetUi

        public Data GetDataFromUi()
        {
            Data tambahData = new Data();
            tambahData.NIK = txboxNIK.Text;
            tambahData.NamaLengkap = txboxNamaLengkap.Text;
            tambahData.JenisKelamin = JenisKelamin;
            tambahData.TempatLahir = txboxTempatLahir.Text;
            tambahData.TanggalLahir = DtpTanggalLahir.Value;
            tambahData.Umur = Convert.ToInt32(nudUmur.Value);
            tambahData.Agama = comboAgama.Text;
            tambahData.Pendidikan = dupPendidikan.Text;
            tambahData.Pekerjaan = txboxPekerjaan.Text;
            tambahData.Penghasilan = Convert.ToInt32(nudPenghasilan.Value);

            return tambahData;
        }

        public void ClearInput()
        {
            txboxNIK.Text = null;
            txboxNamaLengkap.Text = null;
            rbPerempuan.Checked = false;
            rbPria.Checked = false;
            txboxTempatLahir.Text = null;
            DtpTanggalLahir.Value = DateTime.Today;
            nudUmur.Value = 0;
            comboAgama.Text = null;
            dupPendidikan.Text = null;
            txboxPekerjaan.Text = null;
            nudPenghasilan.Value = 0;
        }

        #endregion

        #region CRUD

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                var data = GetDataFromUi();
                var check = Validate_Input();
                if (!(check.Count > 0))
                {
                    con.Open();
                    string query = "insert into warga Values ('"
                              + data.NIK +
                        "','" + data.NamaLengkap +
                        "','" + data.JenisKelamin +
                        "','" + data.TempatLahir +
                        "','" + data.TanggalLahir +
                        "','" + data.Umur +
                        "','" + data.Agama +
                        "','" + data.Pendidikan +
                        "','" + data.Pekerjaan +
                        "','" + data.Penghasilan +
                        "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ClearInput();
                    MessageBox.Show("Successfully Inserted");
                    FormDesaPenarik_Load(null, null);
                }
                else
                {
                    string error = "Tedapat Error Pada Kolom";
                    string last = check.Last();
                    foreach (string item in check)
                    {
                        if (!item.Equals(last))
                            error = error + item + ", ";
                        else
                            error = error + item;
                    }
                    MessageBox.Show(error);
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                var data = GetDataFromUi();
                var check = Validate_Input();
                if (!(check.Count > 0))
                {
                    con.Open();
                    string query = "update warga set NIK = '" + data.NIK +
                        "', NamaLengkap = '" + data.NamaLengkap +
                        "', JenisKelamin = '" + data.JenisKelamin +
                        "', TempatLahir = '" + data.TempatLahir +
                        "', TanggalLahir = '" + data.TanggalLahir +
                        "', Umur = '" + data.Umur +
                        "', Agama = '" + data.Agama +
                        "', PendidikanTerakhir = '" + data.Pendidikan +
                        "', Pekerjaan = '" + data.Pekerjaan +
                        "', Penghasilan = '" + data.Penghasilan +
                        "'where NIK = '" + data.NIK + "'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ClearInput();
                    MessageBox.Show("Successfully Updated");
                    FormDesaPenarik_Load(null, null);
                }
                else
                {
                    string error = "Tedapat Error Pada Kolom";
                    string last = check.Last();
                    foreach (string item in check)
                    {
                        if (!item.Equals(last))
                            error = error + item + ", ";
                        else
                            error = error + item;
                    }
                    MessageBox.Show(error);
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            var data = GetDataFromUi();
            try
            {
                if (!(data.NIK == ""))
                {
                    if (!(MessageBox.Show("Are u sure to Delete?", "delete Record", MessageBoxButtons.YesNo) == DialogResult))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Delete warga where NIK = '" + data.NIK + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ClearInput();
                        MessageBox.Show("Successfully Updated Deleted");
                        FormDesaPenarik_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Masukkan NIK untuk menghapus");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        void FormDesaPenarik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet1.warga' table. You can move, or remove it, as needed.
            this.wargaTableAdapter1.Fill(this.uASDataSet1.warga);
            // TODO: This line of code loads data into the 'uASDataSet.warga' table. You can move, or remove it, as needed.
            this.wargaTableAdapter.Fill(this.uASDataSet.warga);
        }

        private List<string> Validate_Input()
        {
            List<string> error = new List<string>();
            var data = GetDataFromUi();
            int NIK;

            if (string.IsNullOrWhiteSpace(data.NIK))
            {
                errorProvider.SetError(lblNIK, "Kolom NIK Harus Terisi!");
                error.Add("NIK");
            }
            else
            {
                errorProvider.SetError(lblNIK, "");
            }

            if (!int.TryParse(txboxNIK.Text, out NIK))
            {
                errorProvider.SetError(lblNIK, "Nilai NIK Berupa Angka!");
            }
            else
            {
                errorProvider.SetError(lblNIK, "");
            }

            if (txboxNIK.Text.Length != 9)
            {
                errorProvider.SetError(lblNIK, "Nilai NIK Harus 9!");
            }
            else
            {
                errorProvider.SetError(lblNIK, "");
            }

            if (string.IsNullOrWhiteSpace(data.NamaLengkap))
            {
                errorProvider.SetError(lblNamaLengkap, "Kolom Nama Lengkap Harus Terisi!");
                error.Add("Nama Lengkap");
            }
            else
            {
                errorProvider.SetError(lblNamaLengkap, "");
            }

            if (string.IsNullOrWhiteSpace(data.JenisKelamin))
            {
                errorProvider.SetError(lblJenisKelamin, "Kolom Jenis Kelamin Harus Terisi!");
                error.Add("Jenis Kelamin");
            }
            else
            {
                errorProvider.SetError(lblJenisKelamin, "");
            }

            if (string.IsNullOrWhiteSpace(data.TempatLahir))
            {
                errorProvider.SetError(lblTempatLahir, "Kolom Tempat Lahir Harus Terisi!");
                error.Add("Tempat Lahir");
            }
            else
            {
                errorProvider.SetError(lblTempatLahir, "");
            }

            if (data.TanggalLahir == null)
            {
                errorProvider.SetError(lblTanggalLahir, "Kolom Tanggal Lahir Harus Terisi!");
                error.Add("Tanggal Lahir");
            }
            else
            {
                errorProvider.SetError(lblTanggalLahir, "");
            }

            if (string.IsNullOrWhiteSpace(data.Agama))
            {
                errorProvider.SetError(lblAgama, "Kolom Kolom Agama Harus Terisi!");
                error.Add("Agama");
            }
            else
            {
                errorProvider.SetError(lblAgama, "");
            }

            if (string.IsNullOrWhiteSpace(data.Pendidikan))
            {
                errorProvider.SetError(lblPendidikanTerakhir, "Kolom Pendidikan Terakhir Harus Terisi!");
                error.Add("Pendidikan Terakhir");
            }
            else
            {
                errorProvider.SetError(lblPendidikanTerakhir, "");
            }

            if (string.IsNullOrWhiteSpace(data.Pekerjaan))
            {
                errorProvider.SetError(lblPekerjaan, "Kolom Pekerjaan Harus Terisi!");
                error.Add("Pekerjaan");
            }
            else
            {
                errorProvider.SetError(lblPekerjaan, "");
            }

            if (data.Penghasilan == null)
            {
                errorProvider.SetError(lblPenghasilan, "Kolom Penghasilan Harus Terisi!");
                error.Add("Penghasilan");
            }
            else
            {
                errorProvider.SetError(lblPenghasilan, "");
            }

            if (data.Umur == null)
            {
                errorProvider.SetError(lblUmur, "Kolom Umur Harus Terisi!");
                error.Add("Umur");
            }

            if (data.Umur == 0)
            {
                errorProvider.SetError(lblUmur, "Nilai umur harus diatas 0!");
                error.Add("Umur");
            }

            else
            {
                errorProvider.SetError(lblUmur, "");
            }

            return error;
        }

        #endregion

        #region EventUi

        private void txboxNIK_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(lblNIK, "");
        }

        private void txboxNamaLengkap_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(lblNamaLengkap, "");
        }

        private void txboxTempatLahir_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(lblTempatLahir, "");
        }

        private void DtpTanggalLahir_ValueChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(lblTanggalLahir, "");
        }

        private void comboAgama_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(lblAgama, "");
        }

        private void dupPendidikan_SelectedItemChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(lblPendidikanTerakhir, "");
        }

        private void txboxPekerjaan_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(lblPekerjaan, "");
        }

        private void nudPenghasilan_ValueChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(lblPenghasilan, "");
        }

        private void nudUmur_ValueChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(lblUmur, "");
        }

        string JenisKelamin;
        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(lblJenisKelamin, "");
            JenisKelamin = "Perempuan";
        }

        private void rbPria_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(lblJenisKelamin, "");
            JenisKelamin = "Pria";
        }

        private void dtgWarga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgWarga.Rows[e.RowIndex];

                txboxNIK.Text = row.Cells[0].Value.ToString();
                txboxNamaLengkap.Text = row.Cells[1].Value.ToString();
                JenisKelamin = row.Cells[2].Value.ToString();
                txboxTempatLahir.Text = row.Cells[3].Value.ToString();
                DtpTanggalLahir.Text = row.Cells[4].Value.ToString();
                nudUmur.Value = Convert.ToDecimal(row.Cells[5].Value.ToString());
                comboAgama.Text = row.Cells[6].Value.ToString();
                dupPendidikan.Text = row.Cells[7].Value.ToString();
                txboxPekerjaan.Text = row.Cells[8].Value.ToString();
                nudPenghasilan.Value = Convert.ToDecimal(row.Cells[9].Value.ToString());
            }
        }

        #endregion
    }
}
