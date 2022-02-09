
namespace UAS_IMELDA_202111547
{
    partial class FormDesaPenarik
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
            this.components = new System.ComponentModel.Container();
            this.uASDataSet = new UAS_IMELDA_202111547.UASDataSet();
            this.wargaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wargaTableAdapter = new UAS_IMELDA_202111547.UASDataSetTableAdapters.wargaTableAdapter();
            this.dtgWarga = new System.Windows.Forms.DataGridView();
            this.nIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaLengkapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempatLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendidikanTerakhirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pekerjaanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penghasilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wargaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uASDataSet1 = new UAS_IMELDA_202111547.UASDataSet1();
            this.wargaTableAdapter1 = new UAS_IMELDA_202111547.UASDataSet1TableAdapters.wargaTableAdapter();
            this.groupBoxDataWarga = new System.Windows.Forms.GroupBox();
            this.comboAgama = new System.Windows.Forms.ComboBox();
            this.nudUmur = new System.Windows.Forms.NumericUpDown();
            this.lblUmur = new System.Windows.Forms.Label();
            this.nudPenghasilan = new System.Windows.Forms.NumericUpDown();
            this.lblPenghasilan = new System.Windows.Forms.Label();
            this.dupPendidikan = new System.Windows.Forms.DomainUpDown();
            this.txboxPekerjaan = new System.Windows.Forms.TextBox();
            this.lblPekerjaan = new System.Windows.Forms.Label();
            this.lblPendidikanTerakhir = new System.Windows.Forms.Label();
            this.lblAgama = new System.Windows.Forms.Label();
            this.DtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.txboxTempatLahir = new System.Windows.Forms.TextBox();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.rbPria = new System.Windows.Forms.RadioButton();
            this.txboxNamaLengkap = new System.Windows.Forms.TextBox();
            this.txboxNIK = new System.Windows.Forms.TextBox();
            this.lblTanggalLahir = new System.Windows.Forms.Label();
            this.lblTempatLahir = new System.Windows.Forms.Label();
            this.lblJenisKelamin = new System.Windows.Forms.Label();
            this.lblNamaLengkap = new System.Windows.Forms.Label();
            this.lblNIK = new System.Windows.Forms.Label();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wargaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgWarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wargaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet1)).BeginInit();
            this.groupBoxDataWarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUmur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPenghasilan)).BeginInit();
            this.groupBoxAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // uASDataSet
            // 
            this.uASDataSet.DataSetName = "UASDataSet";
            this.uASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wargaBindingSource
            // 
            this.wargaBindingSource.DataMember = "warga";
            this.wargaBindingSource.DataSource = this.uASDataSet;
            // 
            // wargaTableAdapter
            // 
            this.wargaTableAdapter.ClearBeforeFill = true;
            // 
            // dtgWarga
            // 
            this.dtgWarga.AllowUserToAddRows = false;
            this.dtgWarga.AllowUserToDeleteRows = false;
            this.dtgWarga.AllowUserToResizeColumns = false;
            this.dtgWarga.AllowUserToResizeRows = false;
            this.dtgWarga.AutoGenerateColumns = false;
            this.dtgWarga.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgWarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgWarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIKDataGridViewTextBoxColumn,
            this.namaLengkapDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.tempatLahirDataGridViewTextBoxColumn,
            this.tanggalLahirDataGridViewTextBoxColumn,
            this.umurDataGridViewTextBoxColumn,
            this.agamaDataGridViewTextBoxColumn,
            this.pendidikanTerakhirDataGridViewTextBoxColumn,
            this.pekerjaanDataGridViewTextBoxColumn,
            this.penghasilanDataGridViewTextBoxColumn});
            this.dtgWarga.DataSource = this.wargaBindingSource1;
            this.dtgWarga.Location = new System.Drawing.Point(65, 11);
            this.dtgWarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgWarga.Name = "dtgWarga";
            this.dtgWarga.ReadOnly = true;
            this.dtgWarga.RowHeadersWidth = 51;
            this.dtgWarga.RowTemplate.Height = 24;
            this.dtgWarga.Size = new System.Drawing.Size(1286, 188);
            this.dtgWarga.TabIndex = 0;
            this.dtgWarga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgWarga_CellContentClick);
            // 
            // nIKDataGridViewTextBoxColumn
            // 
            this.nIKDataGridViewTextBoxColumn.DataPropertyName = "NIK";
            this.nIKDataGridViewTextBoxColumn.HeaderText = "NIK";
            this.nIKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nIKDataGridViewTextBoxColumn.Name = "nIKDataGridViewTextBoxColumn";
            this.nIKDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaLengkapDataGridViewTextBoxColumn
            // 
            this.namaLengkapDataGridViewTextBoxColumn.DataPropertyName = "NamaLengkap";
            this.namaLengkapDataGridViewTextBoxColumn.HeaderText = "Nama Lengkap";
            this.namaLengkapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaLengkapDataGridViewTextBoxColumn.Name = "namaLengkapDataGridViewTextBoxColumn";
            this.namaLengkapDataGridViewTextBoxColumn.Width = 125;
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "JenisKelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            this.jenisKelaminDataGridViewTextBoxColumn.Width = 125;
            // 
            // tempatLahirDataGridViewTextBoxColumn
            // 
            this.tempatLahirDataGridViewTextBoxColumn.DataPropertyName = "TempatLahir";
            this.tempatLahirDataGridViewTextBoxColumn.HeaderText = "Tempat Lahir";
            this.tempatLahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tempatLahirDataGridViewTextBoxColumn.Name = "tempatLahirDataGridViewTextBoxColumn";
            this.tempatLahirDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalLahirDataGridViewTextBoxColumn
            // 
            this.tanggalLahirDataGridViewTextBoxColumn.DataPropertyName = "TanggalLahir";
            this.tanggalLahirDataGridViewTextBoxColumn.HeaderText = "Tanggal Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalLahirDataGridViewTextBoxColumn.Name = "tanggalLahirDataGridViewTextBoxColumn";
            this.tanggalLahirDataGridViewTextBoxColumn.Width = 125;
            // 
            // umurDataGridViewTextBoxColumn
            // 
            this.umurDataGridViewTextBoxColumn.DataPropertyName = "Umur";
            this.umurDataGridViewTextBoxColumn.HeaderText = "Umur";
            this.umurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.umurDataGridViewTextBoxColumn.Name = "umurDataGridViewTextBoxColumn";
            this.umurDataGridViewTextBoxColumn.Width = 80;
            // 
            // agamaDataGridViewTextBoxColumn
            // 
            this.agamaDataGridViewTextBoxColumn.DataPropertyName = "Agama";
            this.agamaDataGridViewTextBoxColumn.HeaderText = "Agama";
            this.agamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agamaDataGridViewTextBoxColumn.Name = "agamaDataGridViewTextBoxColumn";
            this.agamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pendidikanTerakhirDataGridViewTextBoxColumn
            // 
            this.pendidikanTerakhirDataGridViewTextBoxColumn.DataPropertyName = "PendidikanTerakhir";
            this.pendidikanTerakhirDataGridViewTextBoxColumn.HeaderText = "Pendidikan Terakhir";
            this.pendidikanTerakhirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pendidikanTerakhirDataGridViewTextBoxColumn.Name = "pendidikanTerakhirDataGridViewTextBoxColumn";
            this.pendidikanTerakhirDataGridViewTextBoxColumn.Width = 150;
            // 
            // pekerjaanDataGridViewTextBoxColumn
            // 
            this.pekerjaanDataGridViewTextBoxColumn.DataPropertyName = "Pekerjaan";
            this.pekerjaanDataGridViewTextBoxColumn.HeaderText = "Pekerjaan";
            this.pekerjaanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pekerjaanDataGridViewTextBoxColumn.Name = "pekerjaanDataGridViewTextBoxColumn";
            this.pekerjaanDataGridViewTextBoxColumn.Width = 125;
            // 
            // penghasilanDataGridViewTextBoxColumn
            // 
            this.penghasilanDataGridViewTextBoxColumn.DataPropertyName = "Penghasilan";
            this.penghasilanDataGridViewTextBoxColumn.HeaderText = "Penghasilan";
            this.penghasilanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.penghasilanDataGridViewTextBoxColumn.Name = "penghasilanDataGridViewTextBoxColumn";
            this.penghasilanDataGridViewTextBoxColumn.Width = 125;
            // 
            // wargaBindingSource1
            // 
            this.wargaBindingSource1.DataMember = "warga";
            this.wargaBindingSource1.DataSource = this.uASDataSet1;
            // 
            // uASDataSet1
            // 
            this.uASDataSet1.DataSetName = "UASDataSet1";
            this.uASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wargaTableAdapter1
            // 
            this.wargaTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBoxDataWarga
            // 
            this.groupBoxDataWarga.Controls.Add(this.comboAgama);
            this.groupBoxDataWarga.Controls.Add(this.nudUmur);
            this.groupBoxDataWarga.Controls.Add(this.lblUmur);
            this.groupBoxDataWarga.Controls.Add(this.nudPenghasilan);
            this.groupBoxDataWarga.Controls.Add(this.lblPenghasilan);
            this.groupBoxDataWarga.Controls.Add(this.dupPendidikan);
            this.groupBoxDataWarga.Controls.Add(this.txboxPekerjaan);
            this.groupBoxDataWarga.Controls.Add(this.lblPekerjaan);
            this.groupBoxDataWarga.Controls.Add(this.lblPendidikanTerakhir);
            this.groupBoxDataWarga.Controls.Add(this.lblAgama);
            this.groupBoxDataWarga.Controls.Add(this.DtpTanggalLahir);
            this.groupBoxDataWarga.Controls.Add(this.txboxTempatLahir);
            this.groupBoxDataWarga.Controls.Add(this.rbPerempuan);
            this.groupBoxDataWarga.Controls.Add(this.rbPria);
            this.groupBoxDataWarga.Controls.Add(this.txboxNamaLengkap);
            this.groupBoxDataWarga.Controls.Add(this.txboxNIK);
            this.groupBoxDataWarga.Controls.Add(this.lblTanggalLahir);
            this.groupBoxDataWarga.Controls.Add(this.lblTempatLahir);
            this.groupBoxDataWarga.Controls.Add(this.lblJenisKelamin);
            this.groupBoxDataWarga.Controls.Add(this.lblNamaLengkap);
            this.groupBoxDataWarga.Controls.Add(this.lblNIK);
            this.groupBoxDataWarga.Location = new System.Drawing.Point(12, 214);
            this.groupBoxDataWarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDataWarga.Name = "groupBoxDataWarga";
            this.groupBoxDataWarga.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDataWarga.Size = new System.Drawing.Size(1197, 229);
            this.groupBoxDataWarga.TabIndex = 1;
            this.groupBoxDataWarga.TabStop = false;
            this.groupBoxDataWarga.Text = "Data Warga";
            // 
            // comboAgama
            // 
            this.comboAgama.FormattingEnabled = true;
            this.comboAgama.Location = new System.Drawing.Point(768, 26);
            this.comboAgama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboAgama.Name = "comboAgama";
            this.comboAgama.Size = new System.Drawing.Size(405, 24);
            this.comboAgama.TabIndex = 23;
            this.comboAgama.SelectedIndexChanged += new System.EventHandler(this.comboAgama_SelectedIndexChanged);
            // 
            // nudUmur
            // 
            this.nudUmur.Location = new System.Drawing.Point(768, 167);
            this.nudUmur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudUmur.Name = "nudUmur";
            this.nudUmur.Size = new System.Drawing.Size(160, 22);
            this.nudUmur.TabIndex = 21;
            this.nudUmur.ValueChanged += new System.EventHandler(this.nudUmur_ValueChanged);
            // 
            // lblUmur
            // 
            this.lblUmur.AutoSize = true;
            this.lblUmur.Location = new System.Drawing.Point(595, 170);
            this.lblUmur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUmur.Name = "lblUmur";
            this.lblUmur.Size = new System.Drawing.Size(42, 17);
            this.lblUmur.TabIndex = 20;
            this.lblUmur.Text = "Umur";
            // 
            // nudPenghasilan
            // 
            this.nudPenghasilan.Location = new System.Drawing.Point(768, 135);
            this.nudPenghasilan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudPenghasilan.Name = "nudPenghasilan";
            this.nudPenghasilan.Size = new System.Drawing.Size(160, 22);
            this.nudPenghasilan.TabIndex = 19;
            this.nudPenghasilan.ValueChanged += new System.EventHandler(this.nudPenghasilan_ValueChanged);
            // 
            // lblPenghasilan
            // 
            this.lblPenghasilan.AutoSize = true;
            this.lblPenghasilan.Location = new System.Drawing.Point(595, 139);
            this.lblPenghasilan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPenghasilan.Name = "lblPenghasilan";
            this.lblPenghasilan.Size = new System.Drawing.Size(86, 17);
            this.lblPenghasilan.TabIndex = 18;
            this.lblPenghasilan.Text = "Penghasilan";
            // 
            // dupPendidikan
            // 
            this.dupPendidikan.Location = new System.Drawing.Point(768, 64);
            this.dupPendidikan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dupPendidikan.Name = "dupPendidikan";
            this.dupPendidikan.Size = new System.Drawing.Size(407, 22);
            this.dupPendidikan.TabIndex = 2;
            this.dupPendidikan.SelectedItemChanged += new System.EventHandler(this.dupPendidikan_SelectedItemChanged);
            // 
            // txboxPekerjaan
            // 
            this.txboxPekerjaan.Location = new System.Drawing.Point(768, 101);
            this.txboxPekerjaan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txboxPekerjaan.Name = "txboxPekerjaan";
            this.txboxPekerjaan.Size = new System.Drawing.Size(405, 22);
            this.txboxPekerjaan.TabIndex = 17;
            this.txboxPekerjaan.TextChanged += new System.EventHandler(this.txboxPekerjaan_TextChanged);
            // 
            // lblPekerjaan
            // 
            this.lblPekerjaan.AutoSize = true;
            this.lblPekerjaan.Location = new System.Drawing.Point(595, 106);
            this.lblPekerjaan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPekerjaan.Name = "lblPekerjaan";
            this.lblPekerjaan.Size = new System.Drawing.Size(72, 17);
            this.lblPekerjaan.TabIndex = 16;
            this.lblPekerjaan.Text = "Pekerjaan";
            // 
            // lblPendidikanTerakhir
            // 
            this.lblPendidikanTerakhir.AutoSize = true;
            this.lblPendidikanTerakhir.Location = new System.Drawing.Point(595, 66);
            this.lblPendidikanTerakhir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPendidikanTerakhir.Name = "lblPendidikanTerakhir";
            this.lblPendidikanTerakhir.Size = new System.Drawing.Size(135, 17);
            this.lblPendidikanTerakhir.TabIndex = 14;
            this.lblPendidikanTerakhir.Text = "Pendidikan Terakhir";
            // 
            // lblAgama
            // 
            this.lblAgama.AutoSize = true;
            this.lblAgama.Location = new System.Drawing.Point(595, 31);
            this.lblAgama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgama.Name = "lblAgama";
            this.lblAgama.Size = new System.Drawing.Size(52, 17);
            this.lblAgama.TabIndex = 12;
            this.lblAgama.Text = "Agama";
            // 
            // DtpTanggalLahir
            // 
            this.DtpTanggalLahir.Location = new System.Drawing.Point(167, 164);
            this.DtpTanggalLahir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpTanggalLahir.Name = "DtpTanggalLahir";
            this.DtpTanggalLahir.Size = new System.Drawing.Size(265, 22);
            this.DtpTanggalLahir.TabIndex = 11;
            this.DtpTanggalLahir.ValueChanged += new System.EventHandler(this.DtpTanggalLahir_ValueChanged);
            // 
            // txboxTempatLahir
            // 
            this.txboxTempatLahir.Location = new System.Drawing.Point(167, 128);
            this.txboxTempatLahir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txboxTempatLahir.Name = "txboxTempatLahir";
            this.txboxTempatLahir.Size = new System.Drawing.Size(405, 22);
            this.txboxTempatLahir.TabIndex = 10;
            this.txboxTempatLahir.TextChanged += new System.EventHandler(this.txboxTempatLahir_TextChanged);
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(304, 98);
            this.rbPerempuan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(102, 21);
            this.rbPerempuan.TabIndex = 9;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            this.rbPerempuan.CheckedChanged += new System.EventHandler(this.rbPerempuan_CheckedChanged);
            // 
            // rbPria
            // 
            this.rbPria.AutoSize = true;
            this.rbPria.Location = new System.Drawing.Point(167, 98);
            this.rbPria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPria.Name = "rbPria";
            this.rbPria.Size = new System.Drawing.Size(54, 21);
            this.rbPria.TabIndex = 8;
            this.rbPria.TabStop = true;
            this.rbPria.Text = "Pria";
            this.rbPria.UseVisualStyleBackColor = true;
            this.rbPria.CheckedChanged += new System.EventHandler(this.rbPria_CheckedChanged);
            // 
            // txboxNamaLengkap
            // 
            this.txboxNamaLengkap.Location = new System.Drawing.Point(167, 63);
            this.txboxNamaLengkap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txboxNamaLengkap.Name = "txboxNamaLengkap";
            this.txboxNamaLengkap.Size = new System.Drawing.Size(405, 22);
            this.txboxNamaLengkap.TabIndex = 7;
            this.txboxNamaLengkap.TextChanged += new System.EventHandler(this.txboxNamaLengkap_TextChanged);
            // 
            // txboxNIK
            // 
            this.txboxNIK.Location = new System.Drawing.Point(167, 28);
            this.txboxNIK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txboxNIK.Name = "txboxNIK";
            this.txboxNIK.Size = new System.Drawing.Size(405, 22);
            this.txboxNIK.TabIndex = 6;
            this.txboxNIK.TextChanged += new System.EventHandler(this.txboxNIK_TextChanged);
            // 
            // lblTanggalLahir
            // 
            this.lblTanggalLahir.AutoSize = true;
            this.lblTanggalLahir.Location = new System.Drawing.Point(25, 169);
            this.lblTanggalLahir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTanggalLahir.Name = "lblTanggalLahir";
            this.lblTanggalLahir.Size = new System.Drawing.Size(96, 17);
            this.lblTanggalLahir.TabIndex = 4;
            this.lblTanggalLahir.Text = "Tanggal Lahir";
            // 
            // lblTempatLahir
            // 
            this.lblTempatLahir.AutoSize = true;
            this.lblTempatLahir.Location = new System.Drawing.Point(25, 133);
            this.lblTempatLahir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempatLahir.Name = "lblTempatLahir";
            this.lblTempatLahir.Size = new System.Drawing.Size(92, 17);
            this.lblTempatLahir.TabIndex = 3;
            this.lblTempatLahir.Text = "Tempat Lahir";
            // 
            // lblJenisKelamin
            // 
            this.lblJenisKelamin.AutoSize = true;
            this.lblJenisKelamin.Location = new System.Drawing.Point(25, 100);
            this.lblJenisKelamin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJenisKelamin.Name = "lblJenisKelamin";
            this.lblJenisKelamin.Size = new System.Drawing.Size(95, 17);
            this.lblJenisKelamin.TabIndex = 2;
            this.lblJenisKelamin.Text = "Jenis Kelamin";
            // 
            // lblNamaLengkap
            // 
            this.lblNamaLengkap.AutoSize = true;
            this.lblNamaLengkap.Location = new System.Drawing.Point(25, 68);
            this.lblNamaLengkap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamaLengkap.Name = "lblNamaLengkap";
            this.lblNamaLengkap.Size = new System.Drawing.Size(104, 17);
            this.lblNamaLengkap.TabIndex = 1;
            this.lblNamaLengkap.Text = "Nama Lengkap";
            // 
            // lblNIK
            // 
            this.lblNIK.AutoSize = true;
            this.lblNIK.Location = new System.Drawing.Point(25, 33);
            this.lblNIK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNIK.Name = "lblNIK";
            this.lblNIK.Size = new System.Drawing.Size(30, 17);
            this.lblNIK.TabIndex = 0;
            this.lblNIK.Text = "NIK";
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.BtnHapus);
            this.groupBoxAction.Controls.Add(this.btnUbah);
            this.groupBoxAction.Controls.Add(this.btnTambah);
            this.groupBoxAction.Location = new System.Drawing.Point(1268, 239);
            this.groupBoxAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAction.Size = new System.Drawing.Size(133, 160);
            this.groupBoxAction.TabIndex = 22;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Action";
            // 
            // BtnHapus
            // 
            this.BtnHapus.Location = new System.Drawing.Point(17, 108);
            this.BtnHapus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(100, 28);
            this.BtnHapus.TabIndex = 2;
            this.BtnHapus.Text = "Hapus";
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(17, 70);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(100, 28);
            this.btnUbah.TabIndex = 1;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(19, 31);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 28);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FormDesaPenarik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 450);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.groupBoxDataWarga);
            this.Controls.Add(this.dtgWarga);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDesaPenarik";
            this.Text = "Desa Penarik";
            this.Load += new System.EventHandler(this.FormDesaPenarik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wargaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgWarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wargaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet1)).EndInit();
            this.groupBoxDataWarga.ResumeLayout(false);
            this.groupBoxDataWarga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUmur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPenghasilan)).EndInit();
            this.groupBoxAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UASDataSet uASDataSet;
        private System.Windows.Forms.BindingSource wargaBindingSource;
        private UASDataSetTableAdapters.wargaTableAdapter wargaTableAdapter;
        private System.Windows.Forms.DataGridView dtgWarga;
        private UASDataSet1 uASDataSet1;
        private System.Windows.Forms.BindingSource wargaBindingSource1;
        private UASDataSet1TableAdapters.wargaTableAdapter wargaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaLengkapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempatLahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalLahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendidikanTerakhirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pekerjaanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penghasilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxDataWarga;
        private System.Windows.Forms.Label lblNIK;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbPria;
        private System.Windows.Forms.TextBox txboxNamaLengkap;
        private System.Windows.Forms.TextBox txboxNIK;
        private System.Windows.Forms.Label lblTanggalLahir;
        private System.Windows.Forms.Label lblTempatLahir;
        private System.Windows.Forms.Label lblJenisKelamin;
        private System.Windows.Forms.Label lblNamaLengkap;
        private System.Windows.Forms.DateTimePicker DtpTanggalLahir;
        private System.Windows.Forms.TextBox txboxTempatLahir;
        private System.Windows.Forms.NumericUpDown nudUmur;
        private System.Windows.Forms.Label lblUmur;
        private System.Windows.Forms.NumericUpDown nudPenghasilan;
        private System.Windows.Forms.Label lblPenghasilan;
        private System.Windows.Forms.DomainUpDown dupPendidikan;
        private System.Windows.Forms.TextBox txboxPekerjaan;
        private System.Windows.Forms.Label lblPekerjaan;
        private System.Windows.Forms.Label lblPendidikanTerakhir;
        private System.Windows.Forms.Label lblAgama;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ComboBox comboAgama;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

