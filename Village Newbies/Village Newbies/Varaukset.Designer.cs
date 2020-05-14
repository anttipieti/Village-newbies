namespace Village_Newbies
{
    partial class Varaukset
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
            this.tabVarausNakyma = new System.Windows.Forms.TabControl();
            this.tabPageVaraus = new System.Windows.Forms.TabPage();
            this.chbvarausvahvista = new System.Windows.Forms.CheckBox();
            this.tbPalvelulkm = new System.Windows.Forms.TextBox();
            this.lblValitutPalvelut = new System.Windows.Forms.Label();
            this.btnTabVarausPalvelut = new System.Windows.Forms.Button();
            this.txtmokkiid = new System.Windows.Forms.TextBox();
            this.btnmokki = new System.Windows.Forms.Button();
            this.btnVarausPoista = new System.Windows.Forms.Button();
            this.btnasiakas = new System.Windows.Forms.Button();
            this.btnVarausMuuta = new System.Windows.Forms.Button();
            this.txtvarausid = new System.Windows.Forms.TextBox();
            this.btnVarausUusi = new System.Windows.Forms.Button();
            this.lblmokkiid = new System.Windows.Forms.Label();
            this.lblvarausid = new System.Windows.Forms.Label();
            this.txtasiakasid = new System.Windows.Forms.TextBox();
            this.lblasiakasID = new System.Windows.Forms.Label();
            this.dtploppu = new System.Windows.Forms.DateTimePicker();
            this.dtpvarattu = new System.Windows.Forms.DateTimePicker();
            this.dtpalku = new System.Windows.Forms.DateTimePicker();
            this.lblvarattu = new System.Windows.Forms.Label();
            this.dtpvahvistus = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageAsiakas = new System.Windows.Forms.TabPage();
            this.dgvVarausAsiakkaat = new System.Windows.Forms.DataGridView();
            this.asiakasidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villageNewbiesDataSet = new Village_Newbies.VillageNewbiesDataSet();
            this.btnLisaaVarausAsiakas = new System.Windows.Forms.Button();
            this.tbAsiakasIdVarausValinta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageMokki = new System.Windows.Forms.TabPage();
            this.cmbVarausToimialue = new System.Windows.Forms.ComboBox();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.dtgVarausMokit = new System.Windows.Forms.DataGridView();
            this.tbVarausMokki = new System.Windows.Forms.TextBox();
            this.btnVarausMokkiLisays = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPagePalvelut = new System.Windows.Forms.TabPage();
            this.lblvarauspalvelu = new System.Windows.Forms.Label();
            this.btnPoistaVarausPalvelu = new System.Windows.Forms.Button();
            this.dtgVarauksenPalvelut = new System.Windows.Forms.DataGridView();
            this.btnLisaaVarausPalvelu = new System.Windows.Forms.Button();
            this.tbVarausPalveluLkm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVarausPalveluValinta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageHaku = new System.Windows.Forms.TabPage();
            this.btnvVarausNaytaKaikki = new System.Windows.Forms.Button();
            this.btnHaku = new System.Windows.Forms.Button();
            this.chbvarausvahvistetut = new System.Windows.Forms.CheckBox();
            this.cmbVarausHakuEhto = new System.Windows.Forms.ComboBox();
            this.lblhakuteksti = new System.Windows.Forms.Label();
            this.dtphakualku = new System.Windows.Forms.DateTimePicker();
            this.dtphakupaattyy = new System.Windows.Forms.DateTimePicker();
            this.lblhakualkaen = new System.Windows.Forms.Label();
            this.lblhakupaattyen = new System.Windows.Forms.Label();
            this.dtgVarausTaulu = new System.Windows.Forms.DataGridView();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkimokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahvistuspvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattualkupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattuloppupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausTableAdapter = new Village_Newbies.VillageNewbiesDataSetTableAdapters.varausTableAdapter();
            this.asiakasTableAdapter = new Village_Newbies.VillageNewbiesDataSetTableAdapters.asiakasTableAdapter();
            this.toimintaalueTableAdapter = new Village_Newbies.VillageNewbiesDataSetTableAdapters.toimintaalueTableAdapter();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palveluTableAdapter = new Village_Newbies.VillageNewbiesDataSetTableAdapters.palveluTableAdapter();
            this.gbAsHae = new System.Windows.Forms.GroupBox();
            this.cbAsPostinro = new System.Windows.Forms.CheckBox();
            this.cbAsPuhNro = new System.Windows.Forms.CheckBox();
            this.cbAsEtunimi = new System.Windows.Forms.CheckBox();
            this.cbAsEmail = new System.Windows.Forms.CheckBox();
            this.cbAsSukunimi = new System.Windows.Forms.CheckBox();
            this.cbAsLOsoite = new System.Windows.Forms.CheckBox();
            this.tbAsHaku = new System.Windows.Forms.TextBox();
            this.lbHakusana = new System.Windows.Forms.Label();
            this.btnAsNollaa = new System.Windows.Forms.Button();
            this.btnAsHae = new System.Windows.Forms.Button();
            this.tabVarausNakyma.SuspendLayout();
            this.tabPageVaraus.SuspendLayout();
            this.tabPageAsiakas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarausAsiakkaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).BeginInit();
            this.tabPageMokki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVarausMokit)).BeginInit();
            this.tabPagePalvelut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVarauksenPalvelut)).BeginInit();
            this.tabPageHaku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVarausTaulu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            this.gbAsHae.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabVarausNakyma
            // 
            this.tabVarausNakyma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabVarausNakyma.Controls.Add(this.tabPageVaraus);
            this.tabVarausNakyma.Controls.Add(this.tabPageAsiakas);
            this.tabVarausNakyma.Controls.Add(this.tabPageMokki);
            this.tabVarausNakyma.Controls.Add(this.tabPagePalvelut);
            this.tabVarausNakyma.Controls.Add(this.tabPageHaku);
            this.tabVarausNakyma.Location = new System.Drawing.Point(47, 39);
            this.tabVarausNakyma.Name = "tabVarausNakyma";
            this.tabVarausNakyma.SelectedIndex = 0;
            this.tabVarausNakyma.Size = new System.Drawing.Size(925, 358);
            this.tabVarausNakyma.TabIndex = 0;
            // 
            // tabPageVaraus
            // 
            this.tabPageVaraus.Controls.Add(this.chbvarausvahvista);
            this.tabPageVaraus.Controls.Add(this.tbPalvelulkm);
            this.tabPageVaraus.Controls.Add(this.lblValitutPalvelut);
            this.tabPageVaraus.Controls.Add(this.btnTabVarausPalvelut);
            this.tabPageVaraus.Controls.Add(this.txtmokkiid);
            this.tabPageVaraus.Controls.Add(this.btnmokki);
            this.tabPageVaraus.Controls.Add(this.btnVarausPoista);
            this.tabPageVaraus.Controls.Add(this.btnasiakas);
            this.tabPageVaraus.Controls.Add(this.btnVarausMuuta);
            this.tabPageVaraus.Controls.Add(this.txtvarausid);
            this.tabPageVaraus.Controls.Add(this.btnVarausUusi);
            this.tabPageVaraus.Controls.Add(this.lblmokkiid);
            this.tabPageVaraus.Controls.Add(this.lblvarausid);
            this.tabPageVaraus.Controls.Add(this.txtasiakasid);
            this.tabPageVaraus.Controls.Add(this.lblasiakasID);
            this.tabPageVaraus.Controls.Add(this.dtploppu);
            this.tabPageVaraus.Controls.Add(this.dtpvarattu);
            this.tabPageVaraus.Controls.Add(this.dtpalku);
            this.tabPageVaraus.Controls.Add(this.lblvarattu);
            this.tabPageVaraus.Controls.Add(this.dtpvahvistus);
            this.tabPageVaraus.Controls.Add(this.label1);
            this.tabPageVaraus.Controls.Add(this.label2);
            this.tabPageVaraus.Controls.Add(this.label3);
            this.tabPageVaraus.Location = new System.Drawing.Point(4, 25);
            this.tabPageVaraus.Name = "tabPageVaraus";
            this.tabPageVaraus.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVaraus.Size = new System.Drawing.Size(917, 329);
            this.tabPageVaraus.TabIndex = 0;
            this.tabPageVaraus.Text = "Varaus";
            this.tabPageVaraus.UseVisualStyleBackColor = true;
            // 
            // chbvarausvahvista
            // 
            this.chbvarausvahvista.AutoSize = true;
            this.chbvarausvahvista.Location = new System.Drawing.Point(417, 132);
            this.chbvarausvahvista.Name = "chbvarausvahvista";
            this.chbvarausvahvista.Size = new System.Drawing.Size(114, 21);
            this.chbvarausvahvista.TabIndex = 43;
            this.chbvarausvahvista.Text = "Ei vahvistettu";
            this.chbvarausvahvista.UseVisualStyleBackColor = true;
            this.chbvarausvahvista.CheckStateChanged += new System.EventHandler(this.chbvarausvahvista_CheckStateChanged);
            // 
            // tbPalvelulkm
            // 
            this.tbPalvelulkm.Location = new System.Drawing.Point(115, 249);
            this.tbPalvelulkm.Name = "tbPalvelulkm";
            this.tbPalvelulkm.ReadOnly = true;
            this.tbPalvelulkm.Size = new System.Drawing.Size(117, 22);
            this.tbPalvelulkm.TabIndex = 42;
            // 
            // lblValitutPalvelut
            // 
            this.lblValitutPalvelut.AutoSize = true;
            this.lblValitutPalvelut.Location = new System.Drawing.Point(45, 252);
            this.lblValitutPalvelut.Name = "lblValitutPalvelut";
            this.lblValitutPalvelut.Size = new System.Drawing.Size(62, 17);
            this.lblValitutPalvelut.TabIndex = 41;
            this.lblValitutPalvelut.Text = "Palvelut:";
            // 
            // btnTabVarausPalvelut
            // 
            this.btnTabVarausPalvelut.Location = new System.Drawing.Point(115, 284);
            this.btnTabVarausPalvelut.Name = "btnTabVarausPalvelut";
            this.btnTabVarausPalvelut.Size = new System.Drawing.Size(117, 30);
            this.btnTabVarausPalvelut.TabIndex = 40;
            this.btnTabVarausPalvelut.Text = "Valitse Palvelut";
            this.btnTabVarausPalvelut.UseVisualStyleBackColor = true;
            this.btnTabVarausPalvelut.Click += new System.EventHandler(this.btnTabVarausPalvelut_Click);
            // 
            // txtmokkiid
            // 
            this.txtmokkiid.Location = new System.Drawing.Point(115, 173);
            this.txtmokkiid.Name = "txtmokkiid";
            this.txtmokkiid.Size = new System.Drawing.Size(117, 22);
            this.txtmokkiid.TabIndex = 27;
            // 
            // btnmokki
            // 
            this.btnmokki.Location = new System.Drawing.Point(115, 208);
            this.btnmokki.Name = "btnmokki";
            this.btnmokki.Size = new System.Drawing.Size(117, 28);
            this.btnmokki.TabIndex = 28;
            this.btnmokki.Text = "Valitse Mökki";
            this.btnmokki.UseVisualStyleBackColor = true;
            this.btnmokki.Click += new System.EventHandler(this.btnmokki_Click);
            // 
            // btnVarausPoista
            // 
            this.btnVarausPoista.Location = new System.Drawing.Point(726, 166);
            this.btnVarausPoista.Name = "btnVarausPoista";
            this.btnVarausPoista.Size = new System.Drawing.Size(153, 43);
            this.btnVarausPoista.TabIndex = 31;
            this.btnVarausPoista.Text = "Poista varaus";
            this.btnVarausPoista.UseVisualStyleBackColor = true;
            this.btnVarausPoista.Click += new System.EventHandler(this.btnVarausPoista_Click);
            // 
            // btnasiakas
            // 
            this.btnasiakas.Location = new System.Drawing.Point(115, 132);
            this.btnasiakas.Name = "btnasiakas";
            this.btnasiakas.Size = new System.Drawing.Size(117, 28);
            this.btnasiakas.TabIndex = 25;
            this.btnasiakas.Text = "Valitse Asiakas";
            this.btnasiakas.UseVisualStyleBackColor = true;
            this.btnasiakas.Click += new System.EventHandler(this.btnasiakas_Click);
            // 
            // btnVarausMuuta
            // 
            this.btnVarausMuuta.Location = new System.Drawing.Point(726, 105);
            this.btnVarausMuuta.Name = "btnVarausMuuta";
            this.btnVarausMuuta.Size = new System.Drawing.Size(153, 50);
            this.btnVarausMuuta.TabIndex = 30;
            this.btnVarausMuuta.Text = "Muutos varaukseen";
            this.btnVarausMuuta.UseVisualStyleBackColor = true;
            this.btnVarausMuuta.Click += new System.EventHandler(this.btnMuuta_Click);
            // 
            // txtvarausid
            // 
            this.txtvarausid.Location = new System.Drawing.Point(115, 32);
            this.txtvarausid.Name = "txtvarausid";
            this.txtvarausid.ReadOnly = true;
            this.txtvarausid.Size = new System.Drawing.Size(117, 22);
            this.txtvarausid.TabIndex = 22;
            // 
            // btnVarausUusi
            // 
            this.btnVarausUusi.Location = new System.Drawing.Point(726, 52);
            this.btnVarausUusi.Name = "btnVarausUusi";
            this.btnVarausUusi.Size = new System.Drawing.Size(153, 42);
            this.btnVarausUusi.TabIndex = 29;
            this.btnVarausUusi.Text = "Uusi varaus";
            this.btnVarausUusi.UseVisualStyleBackColor = true;
            this.btnVarausUusi.Click += new System.EventHandler(this.btnUusi_Click);
            // 
            // lblmokkiid
            // 
            this.lblmokkiid.AutoSize = true;
            this.lblmokkiid.Location = new System.Drawing.Point(45, 176);
            this.lblmokkiid.Name = "lblmokkiid";
            this.lblmokkiid.Size = new System.Drawing.Size(57, 17);
            this.lblmokkiid.TabIndex = 26;
            this.lblmokkiid.Text = "mokkiID";
            // 
            // lblvarausid
            // 
            this.lblvarausid.AutoSize = true;
            this.lblvarausid.Location = new System.Drawing.Point(45, 32);
            this.lblvarausid.Name = "lblvarausid";
            this.lblvarausid.Size = new System.Drawing.Size(64, 17);
            this.lblvarausid.TabIndex = 21;
            this.lblvarausid.Text = "varausID";
            // 
            // txtasiakasid
            // 
            this.txtasiakasid.Location = new System.Drawing.Point(115, 97);
            this.txtasiakasid.Name = "txtasiakasid";
            this.txtasiakasid.Size = new System.Drawing.Size(117, 22);
            this.txtasiakasid.TabIndex = 24;
            // 
            // lblasiakasID
            // 
            this.lblasiakasID.AutoSize = true;
            this.lblasiakasID.Location = new System.Drawing.Point(40, 100);
            this.lblasiakasID.Name = "lblasiakasID";
            this.lblasiakasID.Size = new System.Drawing.Size(69, 17);
            this.lblasiakasID.TabIndex = 23;
            this.lblasiakasID.Text = "asiakasID";
            // 
            // dtploppu
            // 
            this.dtploppu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtploppu.Location = new System.Drawing.Point(418, 252);
            this.dtploppu.Name = "dtploppu";
            this.dtploppu.Size = new System.Drawing.Size(244, 22);
            this.dtploppu.TabIndex = 39;
            // 
            // dtpvarattu
            // 
            this.dtpvarattu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpvarattu.Location = new System.Drawing.Point(418, 32);
            this.dtpvarattu.Name = "dtpvarattu";
            this.dtpvarattu.Size = new System.Drawing.Size(243, 22);
            this.dtpvarattu.TabIndex = 36;
            // 
            // dtpalku
            // 
            this.dtpalku.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpalku.Location = new System.Drawing.Point(418, 178);
            this.dtpalku.Name = "dtpalku";
            this.dtpalku.Size = new System.Drawing.Size(244, 22);
            this.dtpalku.TabIndex = 38;
            // 
            // lblvarattu
            // 
            this.lblvarattu.AutoSize = true;
            this.lblvarattu.Location = new System.Drawing.Point(296, 32);
            this.lblvarattu.Name = "lblvarattu";
            this.lblvarattu.Size = new System.Drawing.Size(54, 17);
            this.lblvarattu.TabIndex = 32;
            this.lblvarattu.Text = "Varattu";
            // 
            // dtpvahvistus
            // 
            this.dtpvahvistus.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpvahvistus.Location = new System.Drawing.Point(417, 95);
            this.dtpvahvistus.Name = "dtpvahvistus";
            this.dtpvahvistus.Size = new System.Drawing.Size(244, 22);
            this.dtpvahvistus.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Vahvistus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Varaus alkaa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Varaus päättyy";
            // 
            // tabPageAsiakas
            // 
            this.tabPageAsiakas.Controls.Add(this.btnAsNollaa);
            this.tabPageAsiakas.Controls.Add(this.btnAsHae);
            this.tabPageAsiakas.Controls.Add(this.gbAsHae);
            this.tabPageAsiakas.Controls.Add(this.tbAsHaku);
            this.tabPageAsiakas.Controls.Add(this.lbHakusana);
            this.tabPageAsiakas.Controls.Add(this.dgvVarausAsiakkaat);
            this.tabPageAsiakas.Controls.Add(this.btnLisaaVarausAsiakas);
            this.tabPageAsiakas.Controls.Add(this.tbAsiakasIdVarausValinta);
            this.tabPageAsiakas.Controls.Add(this.label6);
            this.tabPageAsiakas.Location = new System.Drawing.Point(4, 25);
            this.tabPageAsiakas.Name = "tabPageAsiakas";
            this.tabPageAsiakas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAsiakas.Size = new System.Drawing.Size(917, 390);
            this.tabPageAsiakas.TabIndex = 1;
            this.tabPageAsiakas.Text = "Asiakas";
            this.tabPageAsiakas.UseVisualStyleBackColor = true;
            // 
            // dgvVarausAsiakkaat
            // 
            this.dgvVarausAsiakkaat.AllowUserToAddRows = false;
            this.dgvVarausAsiakkaat.AllowUserToDeleteRows = false;
            this.dgvVarausAsiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVarausAsiakkaat.AutoGenerateColumns = false;
            this.dgvVarausAsiakkaat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVarausAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarausAsiakkaat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasidDataGridViewTextBoxColumn1,
            this.postinroDataGridViewTextBoxColumn,
            this.etunimiDataGridViewTextBoxColumn,
            this.sukunimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.dgvVarausAsiakkaat.DataSource = this.asiakasBindingSource;
            this.dgvVarausAsiakkaat.Location = new System.Drawing.Point(28, 158);
            this.dgvVarausAsiakkaat.Name = "dgvVarausAsiakkaat";
            this.dgvVarausAsiakkaat.ReadOnly = true;
            this.dgvVarausAsiakkaat.RowHeadersVisible = false;
            this.dgvVarausAsiakkaat.RowHeadersWidth = 51;
            this.dgvVarausAsiakkaat.RowTemplate.Height = 24;
            this.dgvVarausAsiakkaat.Size = new System.Drawing.Size(851, 206);
            this.dgvVarausAsiakkaat.TabIndex = 29;
            // 
            // asiakasidDataGridViewTextBoxColumn1
            // 
            this.asiakasidDataGridViewTextBoxColumn1.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn1.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.asiakasidDataGridViewTextBoxColumn1.Name = "asiakasidDataGridViewTextBoxColumn1";
            this.asiakasidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            this.postinroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etunimiDataGridViewTextBoxColumn
            // 
            this.etunimiDataGridViewTextBoxColumn.DataPropertyName = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.HeaderText = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.etunimiDataGridViewTextBoxColumn.Name = "etunimiDataGridViewTextBoxColumn";
            this.etunimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sukunimiDataGridViewTextBoxColumn
            // 
            this.sukunimiDataGridViewTextBoxColumn.DataPropertyName = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.HeaderText = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sukunimiDataGridViewTextBoxColumn.Name = "sukunimiDataGridViewTextBoxColumn";
            this.sukunimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            this.lahiosoiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // puhelinnroDataGridViewTextBoxColumn
            // 
            this.puhelinnroDataGridViewTextBoxColumn.DataPropertyName = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.HeaderText = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.puhelinnroDataGridViewTextBoxColumn.Name = "puhelinnroDataGridViewTextBoxColumn";
            this.puhelinnroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.villageNewbiesDataSet;
            // 
            // villageNewbiesDataSet
            // 
            this.villageNewbiesDataSet.DataSetName = "VillageNewbiesDataSet";
            this.villageNewbiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLisaaVarausAsiakas
            // 
            this.btnLisaaVarausAsiakas.Location = new System.Drawing.Point(28, 66);
            this.btnLisaaVarausAsiakas.Name = "btnLisaaVarausAsiakas";
            this.btnLisaaVarausAsiakas.Size = new System.Drawing.Size(230, 28);
            this.btnLisaaVarausAsiakas.TabIndex = 28;
            this.btnLisaaVarausAsiakas.Text = "Lisää Asiakas varaukseen";
            this.btnLisaaVarausAsiakas.UseVisualStyleBackColor = true;
            this.btnLisaaVarausAsiakas.Click += new System.EventHandler(this.btnVarausAsiakasLisays_Click);
            // 
            // tbAsiakasIdVarausValinta
            // 
            this.tbAsiakasIdVarausValinta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asiakasBindingSource, "asiakas_id", true));
            this.tbAsiakasIdVarausValinta.Location = new System.Drawing.Point(107, 26);
            this.tbAsiakasIdVarausValinta.Name = "tbAsiakasIdVarausValinta";
            this.tbAsiakasIdVarausValinta.Size = new System.Drawing.Size(151, 22);
            this.tbAsiakasIdVarausValinta.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "asiakasID";
            // 
            // tabPageMokki
            // 
            this.tabPageMokki.Controls.Add(this.cmbVarausToimialue);
            this.tabPageMokki.Controls.Add(this.label8);
            this.tabPageMokki.Controls.Add(this.dtgVarausMokit);
            this.tabPageMokki.Controls.Add(this.tbVarausMokki);
            this.tabPageMokki.Controls.Add(this.btnVarausMokkiLisays);
            this.tabPageMokki.Controls.Add(this.label7);
            this.tabPageMokki.Location = new System.Drawing.Point(4, 25);
            this.tabPageMokki.Name = "tabPageMokki";
            this.tabPageMokki.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMokki.Size = new System.Drawing.Size(917, 390);
            this.tabPageMokki.TabIndex = 2;
            this.tabPageMokki.Text = "Mökki";
            this.tabPageMokki.UseVisualStyleBackColor = true;
            // 
            // cmbVarausToimialue
            // 
            this.cmbVarausToimialue.DataSource = this.toimintaalueBindingSource;
            this.cmbVarausToimialue.DisplayMember = "nimi";
            this.cmbVarausToimialue.FormattingEnabled = true;
            this.cmbVarausToimialue.Location = new System.Drawing.Point(35, 31);
            this.cmbVarausToimialue.Name = "cmbVarausToimialue";
            this.cmbVarausToimialue.Size = new System.Drawing.Size(182, 24);
            this.cmbVarausToimialue.TabIndex = 34;
            this.cmbVarausToimialue.ValueMember = "toimintaalue_id";
            this.cmbVarausToimialue.SelectionChangeCommitted += new System.EventHandler(this.cmbVarausToimialue_SelectionChangeCommitted);
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.villageNewbiesDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Valitse toimialue";
            // 
            // dtgVarausMokit
            // 
            this.dtgVarausMokit.AllowUserToAddRows = false;
            this.dtgVarausMokit.AllowUserToDeleteRows = false;
            this.dtgVarausMokit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVarausMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVarausMokit.Location = new System.Drawing.Point(35, 115);
            this.dtgVarausMokit.Name = "dtgVarausMokit";
            this.dtgVarausMokit.ReadOnly = true;
            this.dtgVarausMokit.RowHeadersVisible = false;
            this.dtgVarausMokit.RowHeadersWidth = 51;
            this.dtgVarausMokit.RowTemplate.Height = 24;
            this.dtgVarausMokit.Size = new System.Drawing.Size(848, 244);
            this.dtgVarausMokit.TabIndex = 32;
            this.dtgVarausMokit.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVarausMokit_CellEnter);
            // 
            // tbVarausMokki
            // 
            this.tbVarausMokki.Location = new System.Drawing.Point(35, 78);
            this.tbVarausMokki.Name = "tbVarausMokki";
            this.tbVarausMokki.Size = new System.Drawing.Size(185, 22);
            this.tbVarausMokki.TabIndex = 30;
            // 
            // btnVarausMokkiLisays
            // 
            this.btnVarausMokkiLisays.Location = new System.Drawing.Point(440, 59);
            this.btnVarausMokkiLisays.Name = "btnVarausMokkiLisays";
            this.btnVarausMokkiLisays.Size = new System.Drawing.Size(235, 28);
            this.btnVarausMokkiLisays.TabIndex = 31;
            this.btnVarausMokkiLisays.Text = "Lisää Mökki varaukseen";
            this.btnVarausMokkiLisays.UseVisualStyleBackColor = true;
            this.btnVarausMokkiLisays.Click += new System.EventHandler(this.btnLisaaVarauksenMokki_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "mokkiID";
            // 
            // tabPagePalvelut
            // 
            this.tabPagePalvelut.Controls.Add(this.lblvarauspalvelu);
            this.tabPagePalvelut.Controls.Add(this.btnPoistaVarausPalvelu);
            this.tabPagePalvelut.Controls.Add(this.dtgVarauksenPalvelut);
            this.tabPagePalvelut.Controls.Add(this.btnLisaaVarausPalvelu);
            this.tabPagePalvelut.Controls.Add(this.tbVarausPalveluLkm);
            this.tabPagePalvelut.Controls.Add(this.label5);
            this.tabPagePalvelut.Controls.Add(this.cmbVarausPalveluValinta);
            this.tabPagePalvelut.Controls.Add(this.label4);
            this.tabPagePalvelut.Location = new System.Drawing.Point(4, 25);
            this.tabPagePalvelut.Name = "tabPagePalvelut";
            this.tabPagePalvelut.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePalvelut.Size = new System.Drawing.Size(917, 390);
            this.tabPagePalvelut.TabIndex = 3;
            this.tabPagePalvelut.Text = "Palvelut";
            this.tabPagePalvelut.UseVisualStyleBackColor = true;
            // 
            // lblvarauspalvelu
            // 
            this.lblvarauspalvelu.AutoSize = true;
            this.lblvarauspalvelu.Location = new System.Drawing.Point(37, 16);
            this.lblvarauspalvelu.Name = "lblvarauspalvelu";
            this.lblvarauspalvelu.Size = new System.Drawing.Size(203, 17);
            this.lblvarauspalvelu.TabIndex = 13;
            this.lblvarauspalvelu.Text = "Valitse ensin toimialue ja mökki";
            // 
            // btnPoistaVarausPalvelu
            // 
            this.btnPoistaVarausPalvelu.Location = new System.Drawing.Point(439, 89);
            this.btnPoistaVarausPalvelu.Name = "btnPoistaVarausPalvelu";
            this.btnPoistaVarausPalvelu.Size = new System.Drawing.Size(240, 28);
            this.btnPoistaVarausPalvelu.TabIndex = 12;
            this.btnPoistaVarausPalvelu.Text = "Poista varauksen palvelu";
            this.btnPoistaVarausPalvelu.UseVisualStyleBackColor = true;
            this.btnPoistaVarausPalvelu.Click += new System.EventHandler(this.btnPoistaVarausPalvelu_Click);
            // 
            // dtgVarauksenPalvelut
            // 
            this.dtgVarauksenPalvelut.AllowUserToAddRows = false;
            this.dtgVarauksenPalvelut.AllowUserToDeleteRows = false;
            this.dtgVarauksenPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVarauksenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVarauksenPalvelut.Location = new System.Drawing.Point(37, 135);
            this.dtgVarauksenPalvelut.Name = "dtgVarauksenPalvelut";
            this.dtgVarauksenPalvelut.ReadOnly = true;
            this.dtgVarauksenPalvelut.RowHeadersVisible = false;
            this.dtgVarauksenPalvelut.RowHeadersWidth = 51;
            this.dtgVarauksenPalvelut.RowTemplate.Height = 24;
            this.dtgVarauksenPalvelut.Size = new System.Drawing.Size(642, 221);
            this.dtgVarauksenPalvelut.TabIndex = 11;
            // 
            // btnLisaaVarausPalvelu
            // 
            this.btnLisaaVarausPalvelu.Location = new System.Drawing.Point(439, 55);
            this.btnLisaaVarausPalvelu.Name = "btnLisaaVarausPalvelu";
            this.btnLisaaVarausPalvelu.Size = new System.Drawing.Size(240, 28);
            this.btnLisaaVarausPalvelu.TabIndex = 10;
            this.btnLisaaVarausPalvelu.Text = "Lisää varauksen palvelu";
            this.btnLisaaVarausPalvelu.UseVisualStyleBackColor = true;
            this.btnLisaaVarausPalvelu.Click += new System.EventHandler(this.btnLisaaVarausPalvelu_Click);
            // 
            // tbVarausPalveluLkm
            // 
            this.tbVarausPalveluLkm.Location = new System.Drawing.Point(153, 93);
            this.tbVarausPalveluLkm.Name = "tbVarausPalveluLkm";
            this.tbVarausPalveluLkm.Size = new System.Drawing.Size(200, 22);
            this.tbVarausPalveluLkm.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lukumäärä";
            // 
            // cmbVarausPalveluValinta
            // 
            this.cmbVarausPalveluValinta.DisplayMember = "palvelu_id";
            this.cmbVarausPalveluValinta.FormattingEnabled = true;
            this.cmbVarausPalveluValinta.Location = new System.Drawing.Point(153, 58);
            this.cmbVarausPalveluValinta.Name = "cmbVarausPalveluValinta";
            this.cmbVarausPalveluValinta.Size = new System.Drawing.Size(200, 24);
            this.cmbVarausPalveluValinta.TabIndex = 7;
            this.cmbVarausPalveluValinta.ValueMember = "palvelu_id";
            this.cmbVarausPalveluValinta.SelectionChangeCommitted += new System.EventHandler(this.cmbVarausPalveluValinta_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valitse palvelu";
            // 
            // tabPageHaku
            // 
            this.tabPageHaku.Controls.Add(this.btnvVarausNaytaKaikki);
            this.tabPageHaku.Controls.Add(this.btnHaku);
            this.tabPageHaku.Controls.Add(this.chbvarausvahvistetut);
            this.tabPageHaku.Controls.Add(this.cmbVarausHakuEhto);
            this.tabPageHaku.Controls.Add(this.lblhakuteksti);
            this.tabPageHaku.Controls.Add(this.dtphakualku);
            this.tabPageHaku.Controls.Add(this.dtphakupaattyy);
            this.tabPageHaku.Controls.Add(this.lblhakualkaen);
            this.tabPageHaku.Controls.Add(this.lblhakupaattyen);
            this.tabPageHaku.Location = new System.Drawing.Point(4, 25);
            this.tabPageHaku.Name = "tabPageHaku";
            this.tabPageHaku.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHaku.Size = new System.Drawing.Size(917, 329);
            this.tabPageHaku.TabIndex = 4;
            this.tabPageHaku.Text = "Haku";
            this.tabPageHaku.UseVisualStyleBackColor = true;
            // 
            // btnvVarausNaytaKaikki
            // 
            this.btnvVarausNaytaKaikki.Location = new System.Drawing.Point(348, 219);
            this.btnvVarausNaytaKaikki.Name = "btnvVarausNaytaKaikki";
            this.btnvVarausNaytaKaikki.Size = new System.Drawing.Size(225, 34);
            this.btnvVarausNaytaKaikki.TabIndex = 15;
            this.btnvVarausNaytaKaikki.Text = "Näytä kaikki varaukset";
            this.btnvVarausNaytaKaikki.UseVisualStyleBackColor = true;
            this.btnvVarausNaytaKaikki.Click += new System.EventHandler(this.btnvVarausNaytaKaikki_Click);
            // 
            // btnHaku
            // 
            this.btnHaku.Location = new System.Drawing.Point(53, 219);
            this.btnHaku.Name = "btnHaku";
            this.btnHaku.Size = new System.Drawing.Size(223, 34);
            this.btnHaku.TabIndex = 14;
            this.btnHaku.Text = "Hae";
            this.btnHaku.UseVisualStyleBackColor = true;
            this.btnHaku.Click += new System.EventHandler(this.btnHaku_Click);
            // 
            // chbvarausvahvistetut
            // 
            this.chbvarausvahvistetut.AutoSize = true;
            this.chbvarausvahvistetut.Location = new System.Drawing.Point(353, 67);
            this.chbvarausvahvistetut.Name = "chbvarausvahvistetut";
            this.chbvarausvahvistetut.Size = new System.Drawing.Size(196, 21);
            this.chbvarausvahvistetut.TabIndex = 13;
            this.chbvarausvahvistetut.Text = "Vain vahvistetut varaukset";
            this.chbvarausvahvistetut.UseVisualStyleBackColor = true;
            // 
            // cmbVarausHakuEhto
            // 
            this.cmbVarausHakuEhto.FormattingEnabled = true;
            this.cmbVarausHakuEhto.Items.AddRange(new object[] {
            "Voimassaolevat varaukset",
            "Varauspäivä"});
            this.cmbVarausHakuEhto.Location = new System.Drawing.Point(53, 67);
            this.cmbVarausHakuEhto.Name = "cmbVarausHakuEhto";
            this.cmbVarausHakuEhto.Size = new System.Drawing.Size(228, 24);
            this.cmbVarausHakuEhto.TabIndex = 12;
            // 
            // lblhakuteksti
            // 
            this.lblhakuteksti.AutoSize = true;
            this.lblhakuteksti.Location = new System.Drawing.Point(50, 37);
            this.lblhakuteksti.Name = "lblhakuteksti";
            this.lblhakuteksti.Size = new System.Drawing.Size(34, 17);
            this.lblhakuteksti.TabIndex = 7;
            this.lblhakuteksti.Text = "Hae";
            // 
            // dtphakualku
            // 
            this.dtphakualku.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtphakualku.Location = new System.Drawing.Point(53, 147);
            this.dtphakualku.Name = "dtphakualku";
            this.dtphakualku.Size = new System.Drawing.Size(228, 22);
            this.dtphakualku.TabIndex = 10;
            // 
            // dtphakupaattyy
            // 
            this.dtphakupaattyy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtphakupaattyy.Location = new System.Drawing.Point(353, 147);
            this.dtphakupaattyy.Name = "dtphakupaattyy";
            this.dtphakupaattyy.Size = new System.Drawing.Size(225, 22);
            this.dtphakupaattyy.TabIndex = 11;
            // 
            // lblhakualkaen
            // 
            this.lblhakualkaen.AutoSize = true;
            this.lblhakualkaen.Location = new System.Drawing.Point(50, 123);
            this.lblhakualkaen.Name = "lblhakualkaen";
            this.lblhakualkaen.Size = new System.Drawing.Size(51, 17);
            this.lblhakualkaen.TabIndex = 8;
            this.lblhakualkaen.Text = "Alkaen";
            // 
            // lblhakupaattyen
            // 
            this.lblhakupaattyen.AutoSize = true;
            this.lblhakupaattyen.Location = new System.Drawing.Point(350, 123);
            this.lblhakupaattyen.Name = "lblhakupaattyen";
            this.lblhakupaattyen.Size = new System.Drawing.Size(64, 17);
            this.lblhakupaattyen.TabIndex = 9;
            this.lblhakupaattyen.Text = "Päättyen";
            // 
            // dtgVarausTaulu
            // 
            this.dtgVarausTaulu.AllowUserToAddRows = false;
            this.dtgVarausTaulu.AllowUserToDeleteRows = false;
            this.dtgVarausTaulu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVarausTaulu.AutoGenerateColumns = false;
            this.dtgVarausTaulu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVarausTaulu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVarausTaulu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausidDataGridViewTextBoxColumn,
            this.asiakasidDataGridViewTextBoxColumn,
            this.mokkimokkiidDataGridViewTextBoxColumn,
            this.varattupvmDataGridViewTextBoxColumn,
            this.vahvistuspvmDataGridViewTextBoxColumn,
            this.varattualkupvmDataGridViewTextBoxColumn,
            this.varattuloppupvmDataGridViewTextBoxColumn});
            this.dtgVarausTaulu.DataSource = this.varausBindingSource;
            this.dtgVarausTaulu.Location = new System.Drawing.Point(47, 403);
            this.dtgVarausTaulu.Name = "dtgVarausTaulu";
            this.dtgVarausTaulu.ReadOnly = true;
            this.dtgVarausTaulu.RowHeadersVisible = false;
            this.dtgVarausTaulu.RowHeadersWidth = 51;
            this.dtgVarausTaulu.RowTemplate.Height = 24;
            this.dtgVarausTaulu.Size = new System.Drawing.Size(925, 259);
            this.dtgVarausTaulu.TabIndex = 1;
            this.dtgVarausTaulu.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVarausTaulu_CellEnter);
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            this.varausidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            this.asiakasidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mokkimokkiidDataGridViewTextBoxColumn
            // 
            this.mokkimokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.HeaderText = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mokkimokkiidDataGridViewTextBoxColumn.Name = "mokkimokkiidDataGridViewTextBoxColumn";
            this.mokkimokkiidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varattupvmDataGridViewTextBoxColumn
            // 
            this.varattupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.HeaderText = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varattupvmDataGridViewTextBoxColumn.Name = "varattupvmDataGridViewTextBoxColumn";
            this.varattupvmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vahvistuspvmDataGridViewTextBoxColumn
            // 
            this.vahvistuspvmDataGridViewTextBoxColumn.DataPropertyName = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.HeaderText = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vahvistuspvmDataGridViewTextBoxColumn.Name = "vahvistuspvmDataGridViewTextBoxColumn";
            this.vahvistuspvmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varattualkupvmDataGridViewTextBoxColumn
            // 
            this.varattualkupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.HeaderText = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varattualkupvmDataGridViewTextBoxColumn.Name = "varattualkupvmDataGridViewTextBoxColumn";
            this.varattualkupvmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varattuloppupvmDataGridViewTextBoxColumn
            // 
            this.varattuloppupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.HeaderText = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varattuloppupvmDataGridViewTextBoxColumn.Name = "varattuloppupvmDataGridViewTextBoxColumn";
            this.varattuloppupvmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.villageNewbiesDataSet;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "palvelu";
            this.palveluBindingSource.DataSource = this.villageNewbiesDataSet;
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // gbAsHae
            // 
            this.gbAsHae.Controls.Add(this.cbAsPostinro);
            this.gbAsHae.Controls.Add(this.cbAsPuhNro);
            this.gbAsHae.Controls.Add(this.cbAsEtunimi);
            this.gbAsHae.Controls.Add(this.cbAsEmail);
            this.gbAsHae.Controls.Add(this.cbAsSukunimi);
            this.gbAsHae.Controls.Add(this.cbAsLOsoite);
            this.gbAsHae.Location = new System.Drawing.Point(329, 66);
            this.gbAsHae.Name = "gbAsHae";
            this.gbAsHae.Size = new System.Drawing.Size(550, 86);
            this.gbAsHae.TabIndex = 40;
            this.gbAsHae.TabStop = false;
            this.gbAsHae.Text = "Hae";
            // 
            // cbAsPostinro
            // 
            this.cbAsPostinro.AutoSize = true;
            this.cbAsPostinro.Location = new System.Drawing.Point(155, 52);
            this.cbAsPostinro.Name = "cbAsPostinro";
            this.cbAsPostinro.Size = new System.Drawing.Size(109, 21);
            this.cbAsPostinro.TabIndex = 34;
            this.cbAsPostinro.Text = "Postinumero";
            this.cbAsPostinro.UseVisualStyleBackColor = true;
            // 
            // cbAsPuhNro
            // 
            this.cbAsPuhNro.AutoSize = true;
            this.cbAsPuhNro.Location = new System.Drawing.Point(296, 25);
            this.cbAsPuhNro.Name = "cbAsPuhNro";
            this.cbAsPuhNro.Size = new System.Drawing.Size(125, 21);
            this.cbAsPuhNro.TabIndex = 36;
            this.cbAsPuhNro.Text = "Puhelinnumero";
            this.cbAsPuhNro.UseVisualStyleBackColor = true;
            // 
            // cbAsEtunimi
            // 
            this.cbAsEtunimi.AutoSize = true;
            this.cbAsEtunimi.Location = new System.Drawing.Point(15, 25);
            this.cbAsEtunimi.Name = "cbAsEtunimi";
            this.cbAsEtunimi.Size = new System.Drawing.Size(76, 21);
            this.cbAsEtunimi.TabIndex = 28;
            this.cbAsEtunimi.Text = "Etunimi";
            this.cbAsEtunimi.UseVisualStyleBackColor = true;
            // 
            // cbAsEmail
            // 
            this.cbAsEmail.AutoSize = true;
            this.cbAsEmail.Location = new System.Drawing.Point(296, 52);
            this.cbAsEmail.Name = "cbAsEmail";
            this.cbAsEmail.Size = new System.Drawing.Size(100, 21);
            this.cbAsEmail.TabIndex = 35;
            this.cbAsEmail.Text = "Sähköposti";
            this.cbAsEmail.UseVisualStyleBackColor = true;
            // 
            // cbAsSukunimi
            // 
            this.cbAsSukunimi.AutoSize = true;
            this.cbAsSukunimi.Location = new System.Drawing.Point(155, 25);
            this.cbAsSukunimi.Name = "cbAsSukunimi";
            this.cbAsSukunimi.Size = new System.Drawing.Size(87, 21);
            this.cbAsSukunimi.TabIndex = 32;
            this.cbAsSukunimi.Text = "Sukunimi";
            this.cbAsSukunimi.UseVisualStyleBackColor = true;
            // 
            // cbAsLOsoite
            // 
            this.cbAsLOsoite.AutoSize = true;
            this.cbAsLOsoite.Location = new System.Drawing.Point(15, 52);
            this.cbAsLOsoite.Name = "cbAsLOsoite";
            this.cbAsLOsoite.Size = new System.Drawing.Size(95, 21);
            this.cbAsLOsoite.TabIndex = 33;
            this.cbAsLOsoite.Text = "Lähiosoite";
            this.cbAsLOsoite.UseVisualStyleBackColor = true;
            // 
            // tbAsHaku
            // 
            this.tbAsHaku.Location = new System.Drawing.Point(424, 21);
            this.tbAsHaku.Name = "tbAsHaku";
            this.tbAsHaku.Size = new System.Drawing.Size(185, 22);
            this.tbAsHaku.TabIndex = 39;
            // 
            // lbHakusana
            // 
            this.lbHakusana.AutoSize = true;
            this.lbHakusana.Location = new System.Drawing.Point(326, 24);
            this.lbHakusana.Name = "lbHakusana";
            this.lbHakusana.Size = new System.Drawing.Size(72, 17);
            this.lbHakusana.TabIndex = 38;
            this.lbHakusana.Text = "Hakusana";
            // 
            // btnAsNollaa
            // 
            this.btnAsNollaa.BackColor = System.Drawing.SystemColors.Control;
            this.btnAsNollaa.Location = new System.Drawing.Point(754, 18);
            this.btnAsNollaa.Name = "btnAsNollaa";
            this.btnAsNollaa.Size = new System.Drawing.Size(105, 25);
            this.btnAsNollaa.TabIndex = 42;
            this.btnAsNollaa.Text = "Nollaa";
            this.btnAsNollaa.UseVisualStyleBackColor = false;
            this.btnAsNollaa.Click += new System.EventHandler(this.btnAsNollaa_Click);
            // 
            // btnAsHae
            // 
            this.btnAsHae.BackColor = System.Drawing.SystemColors.Control;
            this.btnAsHae.Location = new System.Drawing.Point(640, 18);
            this.btnAsHae.Name = "btnAsHae";
            this.btnAsHae.Size = new System.Drawing.Size(100, 25);
            this.btnAsHae.TabIndex = 41;
            this.btnAsHae.Text = "Hae";
            this.btnAsHae.UseVisualStyleBackColor = false;
            this.btnAsHae.Click += new System.EventHandler(this.btnAsHae_Click);
            // 
            // Varaukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 674);
            this.Controls.Add(this.dtgVarausTaulu);
            this.Controls.Add(this.tabVarausNakyma);
            this.Name = "Varaukset";
            this.Text = "Varaukset";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Varaukset_FormClosing);
            this.Load += new System.EventHandler(this.Varaukset_Load);
            this.tabVarausNakyma.ResumeLayout(false);
            this.tabPageVaraus.ResumeLayout(false);
            this.tabPageVaraus.PerformLayout();
            this.tabPageAsiakas.ResumeLayout(false);
            this.tabPageAsiakas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarausAsiakkaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).EndInit();
            this.tabPageMokki.ResumeLayout(false);
            this.tabPageMokki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVarausMokit)).EndInit();
            this.tabPagePalvelut.ResumeLayout(false);
            this.tabPagePalvelut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVarauksenPalvelut)).EndInit();
            this.tabPageHaku.ResumeLayout(false);
            this.tabPageHaku.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVarausTaulu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            this.gbAsHae.ResumeLayout(false);
            this.gbAsHae.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabVarausNakyma;
        private System.Windows.Forms.TabPage tabPageVaraus;
        private System.Windows.Forms.TextBox txtmokkiid;
        private System.Windows.Forms.Button btnmokki;
        private System.Windows.Forms.Button btnVarausPoista;
        private System.Windows.Forms.Button btnasiakas;
        private System.Windows.Forms.Button btnVarausMuuta;
        private System.Windows.Forms.TextBox txtvarausid;
        private System.Windows.Forms.Button btnVarausUusi;
        private System.Windows.Forms.Label lblmokkiid;
        private System.Windows.Forms.Label lblvarausid;
        private System.Windows.Forms.TextBox txtasiakasid;
        private System.Windows.Forms.Label lblasiakasID;
        private System.Windows.Forms.DateTimePicker dtploppu;
        private System.Windows.Forms.DateTimePicker dtpvarattu;
        private System.Windows.Forms.DateTimePicker dtpalku;
        private System.Windows.Forms.Label lblvarattu;
        private System.Windows.Forms.DateTimePicker dtpvahvistus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageAsiakas;
        private System.Windows.Forms.DataGridView dgvVarausAsiakkaat;
        private System.Windows.Forms.Button btnLisaaVarausAsiakas;
        private System.Windows.Forms.TextBox tbAsiakasIdVarausValinta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageMokki;
        private System.Windows.Forms.ComboBox cmbVarausToimialue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgVarausMokit;
        private System.Windows.Forms.TextBox tbVarausMokki;
        private System.Windows.Forms.Button btnVarausMokkiLisays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPagePalvelut;
        private System.Windows.Forms.DataGridView dtgVarauksenPalvelut;
        private System.Windows.Forms.Button btnLisaaVarausPalvelu;
        private System.Windows.Forms.TextBox tbVarausPalveluLkm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVarausPalveluValinta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageHaku;
        private System.Windows.Forms.CheckBox chbvarausvahvistetut;
        private System.Windows.Forms.ComboBox cmbVarausHakuEhto;
        private System.Windows.Forms.Label lblhakuteksti;
        private System.Windows.Forms.DateTimePicker dtphakualku;
        private System.Windows.Forms.DateTimePicker dtphakupaattyy;
        private System.Windows.Forms.Label lblhakualkaen;
        private System.Windows.Forms.Label lblhakupaattyen;
        private System.Windows.Forms.DataGridView dtgVarausTaulu;
        private VillageNewbiesDataSet villageNewbiesDataSet;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private VillageNewbiesDataSetTableAdapters.varausTableAdapter varausTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkimokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahvistuspvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattualkupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattuloppupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private VillageNewbiesDataSetTableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private VillageNewbiesDataSetTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private VillageNewbiesDataSetTableAdapters.palveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.Button btnPoistaVarausPalvelu;
        private System.Windows.Forms.Label lblvarauspalvelu;
        private System.Windows.Forms.Button btnTabVarausPalvelut;
        private System.Windows.Forms.TextBox tbPalvelulkm;
        private System.Windows.Forms.Label lblValitutPalvelut;
        private System.Windows.Forms.Button btnHaku;
        private System.Windows.Forms.Button btnvVarausNaytaKaikki;
        private System.Windows.Forms.CheckBox chbvarausvahvista;
        private System.Windows.Forms.GroupBox gbAsHae;
        private System.Windows.Forms.CheckBox cbAsPostinro;
        private System.Windows.Forms.CheckBox cbAsPuhNro;
        private System.Windows.Forms.CheckBox cbAsEtunimi;
        private System.Windows.Forms.CheckBox cbAsEmail;
        private System.Windows.Forms.CheckBox cbAsSukunimi;
        private System.Windows.Forms.CheckBox cbAsLOsoite;
        private System.Windows.Forms.TextBox tbAsHaku;
        private System.Windows.Forms.Label lbHakusana;
        private System.Windows.Forms.Button btnAsNollaa;
        private System.Windows.Forms.Button btnAsHae;
    }
}

