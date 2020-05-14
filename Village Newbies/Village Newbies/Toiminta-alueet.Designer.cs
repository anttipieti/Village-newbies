namespace Village_Newbies
{
    partial class Toiminta_alueet
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
            this.tabToimintaAlue = new System.Windows.Forms.TabControl();
            this.tabToimiAluePage1 = new System.Windows.Forms.TabPage();
            this.lblLisaaToiminta = new System.Windows.Forms.Label();
            this.btnToimAluePoista = new System.Windows.Forms.Button();
            this.tbToimiAlue = new System.Windows.Forms.TextBox();
            this.btnToimAluLisaa = new System.Windows.Forms.Button();
            this.lbltoimiid = new System.Windows.Forms.Label();
            this.lbltoimNimi = new System.Windows.Forms.Label();
            this.tbToimAlueNimi = new System.Windows.Forms.TextBox();
            this.tabToimiAluePage2 = new System.Windows.Forms.TabPage();
            this.tbPostinro = new System.Windows.Forms.TextBox();
            this.lblpostinro = new System.Windows.Forms.Label();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.tbHloMaara = new System.Windows.Forms.TextBox();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbMokkiNimi = new System.Windows.Forms.TextBox();
            this.lblHinta = new System.Windows.Forms.Label();
            this.lblvarustelu = new System.Windows.Forms.Label();
            this.lblhlomaara = new System.Windows.Forms.Label();
            this.lblmokkkuvaus = new System.Windows.Forms.Label();
            this.lblmokkosoite = new System.Windows.Forms.Label();
            this.lblMokkiNimi = new System.Windows.Forms.Label();
            this.cmbMokkiToimialue = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMokkiID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvToimiAlue = new System.Windows.Forms.DataGridView();
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.tabToimiAluePage3 = new System.Windows.Forms.TabPage();
            this.villageNewbiesDataSet = new Village_Newbies.VillageNewbiesDataSet();
            this.toimintaalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toimintaalueTableAdapter = new Village_Newbies.VillageNewbiesDataSetTableAdapters.toimintaalueTableAdapter();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUusiMokki = new System.Windows.Forms.Button();
            this.btnMuutaMokkia = new System.Windows.Forms.Button();
            this.btnPoistaMokki = new System.Windows.Forms.Button();
            this.tabToimintaAlue.SuspendLayout();
            this.tabToimiAluePage1.SuspendLayout();
            this.tabToimiAluePage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimiAlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabToimintaAlue
            // 
            this.tabToimintaAlue.Controls.Add(this.tabToimiAluePage1);
            this.tabToimintaAlue.Controls.Add(this.tabToimiAluePage2);
            this.tabToimintaAlue.Controls.Add(this.tabToimiAluePage3);
            this.tabToimintaAlue.Location = new System.Drawing.Point(25, 12);
            this.tabToimintaAlue.Name = "tabToimintaAlue";
            this.tabToimintaAlue.SelectedIndex = 0;
            this.tabToimintaAlue.Size = new System.Drawing.Size(1022, 330);
            this.tabToimintaAlue.TabIndex = 9;
            // 
            // tabToimiAluePage1
            // 
            this.tabToimiAluePage1.Controls.Add(this.dgvToimiAlue);
            this.tabToimiAluePage1.Controls.Add(this.lblLisaaToiminta);
            this.tabToimiAluePage1.Controls.Add(this.btnToimAluePoista);
            this.tabToimiAluePage1.Controls.Add(this.tbToimiAlue);
            this.tabToimiAluePage1.Controls.Add(this.btnToimAluLisaa);
            this.tabToimiAluePage1.Controls.Add(this.lbltoimiid);
            this.tabToimiAluePage1.Controls.Add(this.lbltoimNimi);
            this.tabToimiAluePage1.Controls.Add(this.tbToimAlueNimi);
            this.tabToimiAluePage1.Location = new System.Drawing.Point(4, 25);
            this.tabToimiAluePage1.Name = "tabToimiAluePage1";
            this.tabToimiAluePage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabToimiAluePage1.Size = new System.Drawing.Size(1014, 301);
            this.tabToimiAluePage1.TabIndex = 0;
            this.tabToimiAluePage1.Text = "Toiminta-alueet";
            this.tabToimiAluePage1.UseVisualStyleBackColor = true;
            // 
            // lblLisaaToiminta
            // 
            this.lblLisaaToiminta.AutoSize = true;
            this.lblLisaaToiminta.Location = new System.Drawing.Point(35, 35);
            this.lblLisaaToiminta.Name = "lblLisaaToiminta";
            this.lblLisaaToiminta.Size = new System.Drawing.Size(127, 17);
            this.lblLisaaToiminta.TabIndex = 1;
            this.lblLisaaToiminta.Text = "Lisää toiminta-alue";
            // 
            // btnToimAluePoista
            // 
            this.btnToimAluePoista.Location = new System.Drawing.Point(841, 27);
            this.btnToimAluePoista.Name = "btnToimAluePoista";
            this.btnToimAluePoista.Size = new System.Drawing.Size(155, 33);
            this.btnToimAluePoista.TabIndex = 7;
            this.btnToimAluePoista.Text = "Poista Toiminta-alue";
            this.btnToimAluePoista.UseVisualStyleBackColor = true;
            this.btnToimAluePoista.Click += new System.EventHandler(this.btnToimAluePoista_Click);
            // 
            // tbToimiAlue
            // 
            this.tbToimiAlue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toimintaalueBindingSource, "toimintaalue_id", true));
            this.tbToimiAlue.Location = new System.Drawing.Point(254, 35);
            this.tbToimiAlue.Name = "tbToimiAlue";
            this.tbToimiAlue.ReadOnly = true;
            this.tbToimiAlue.Size = new System.Drawing.Size(123, 22);
            this.tbToimiAlue.TabIndex = 2;
            // 
            // btnToimAluLisaa
            // 
            this.btnToimAluLisaa.Location = new System.Drawing.Point(670, 27);
            this.btnToimAluLisaa.Name = "btnToimAluLisaa";
            this.btnToimAluLisaa.Size = new System.Drawing.Size(155, 33);
            this.btnToimAluLisaa.TabIndex = 6;
            this.btnToimAluLisaa.Text = "Uusi Toiminta-alue";
            this.btnToimAluLisaa.UseVisualStyleBackColor = true;
            this.btnToimAluLisaa.Click += new System.EventHandler(this.btnToimAluLisaa_Click);
            // 
            // lbltoimiid
            // 
            this.lbltoimiid.AutoSize = true;
            this.lbltoimiid.Location = new System.Drawing.Point(204, 35);
            this.lbltoimiid.Name = "lbltoimiid";
            this.lbltoimiid.Size = new System.Drawing.Size(21, 17);
            this.lbltoimiid.TabIndex = 3;
            this.lbltoimiid.Text = "ID";
            // 
            // lbltoimNimi
            // 
            this.lbltoimNimi.AutoSize = true;
            this.lbltoimNimi.Location = new System.Drawing.Point(413, 35);
            this.lbltoimNimi.Name = "lbltoimNimi";
            this.lbltoimNimi.Size = new System.Drawing.Size(35, 17);
            this.lbltoimNimi.TabIndex = 5;
            this.lbltoimNimi.Text = "Nimi";
            // 
            // tbToimAlueNimi
            // 
            this.tbToimAlueNimi.Location = new System.Drawing.Point(463, 35);
            this.tbToimAlueNimi.Name = "tbToimAlueNimi";
            this.tbToimAlueNimi.Size = new System.Drawing.Size(166, 22);
            this.tbToimAlueNimi.TabIndex = 4;
            // 
            // tabToimiAluePage2
            // 
            this.tabToimiAluePage2.Controls.Add(this.btnPoistaMokki);
            this.tabToimiAluePage2.Controls.Add(this.btnMuutaMokkia);
            this.tabToimiAluePage2.Controls.Add(this.btnUusiMokki);
            this.tabToimiAluePage2.Controls.Add(this.tbPostinro);
            this.tabToimiAluePage2.Controls.Add(this.lblpostinro);
            this.tabToimiAluePage2.Controls.Add(this.tbHinta);
            this.tabToimiAluePage2.Controls.Add(this.tbVarustelu);
            this.tabToimiAluePage2.Controls.Add(this.tbHloMaara);
            this.tabToimiAluePage2.Controls.Add(this.tbKuvaus);
            this.tabToimiAluePage2.Controls.Add(this.tbKatuosoite);
            this.tabToimiAluePage2.Controls.Add(this.tbMokkiNimi);
            this.tabToimiAluePage2.Controls.Add(this.lblHinta);
            this.tabToimiAluePage2.Controls.Add(this.lblvarustelu);
            this.tabToimiAluePage2.Controls.Add(this.lblhlomaara);
            this.tabToimiAluePage2.Controls.Add(this.lblmokkkuvaus);
            this.tabToimiAluePage2.Controls.Add(this.lblmokkosoite);
            this.tabToimiAluePage2.Controls.Add(this.lblMokkiNimi);
            this.tabToimiAluePage2.Controls.Add(this.cmbMokkiToimialue);
            this.tabToimiAluePage2.Controls.Add(this.label8);
            this.tabToimiAluePage2.Controls.Add(this.tbMokkiID);
            this.tabToimiAluePage2.Controls.Add(this.label7);
            this.tabToimiAluePage2.Location = new System.Drawing.Point(4, 25);
            this.tabToimiAluePage2.Name = "tabToimiAluePage2";
            this.tabToimiAluePage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabToimiAluePage2.Size = new System.Drawing.Size(1014, 301);
            this.tabToimiAluePage2.TabIndex = 1;
            this.tabToimiAluePage2.Text = "Mökit";
            this.tabToimiAluePage2.UseVisualStyleBackColor = true;
            // 
            // tbPostinro
            // 
            this.tbPostinro.Location = new System.Drawing.Point(217, 206);
            this.tbPostinro.Name = "tbPostinro";
            this.tbPostinro.Size = new System.Drawing.Size(251, 22);
            this.tbPostinro.TabIndex = 52;
            // 
            // lblpostinro
            // 
            this.lblpostinro.AutoSize = true;
            this.lblpostinro.Location = new System.Drawing.Point(59, 206);
            this.lblpostinro.Name = "lblpostinro";
            this.lblpostinro.Size = new System.Drawing.Size(87, 17);
            this.lblpostinro.TabIndex = 51;
            this.lblpostinro.Text = "Postinumero";
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(660, 201);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(275, 22);
            this.tbHinta.TabIndex = 50;
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(660, 161);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(275, 22);
            this.tbVarustelu.TabIndex = 49;
            // 
            // tbHloMaara
            // 
            this.tbHloMaara.Location = new System.Drawing.Point(660, 117);
            this.tbHloMaara.Name = "tbHloMaara";
            this.tbHloMaara.Size = new System.Drawing.Size(119, 22);
            this.tbHloMaara.TabIndex = 48;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(660, 25);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(287, 64);
            this.tbKuvaus.TabIndex = 47;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(217, 166);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(251, 22);
            this.tbKatuosoite.TabIndex = 46;
            // 
            // tbMokkiNimi
            // 
            this.tbMokkiNimi.Location = new System.Drawing.Point(217, 122);
            this.tbMokkiNimi.Name = "tbMokkiNimi";
            this.tbMokkiNimi.Size = new System.Drawing.Size(251, 22);
            this.tbMokkiNimi.TabIndex = 45;
            // 
            // lblHinta
            // 
            this.lblHinta.AutoSize = true;
            this.lblHinta.Location = new System.Drawing.Point(537, 209);
            this.lblHinta.Name = "lblHinta";
            this.lblHinta.Size = new System.Drawing.Size(41, 17);
            this.lblHinta.TabIndex = 44;
            this.lblHinta.Text = "Hinta";
            // 
            // lblvarustelu
            // 
            this.lblvarustelu.AutoSize = true;
            this.lblvarustelu.Location = new System.Drawing.Point(537, 167);
            this.lblvarustelu.Name = "lblvarustelu";
            this.lblvarustelu.Size = new System.Drawing.Size(68, 17);
            this.lblvarustelu.TabIndex = 43;
            this.lblvarustelu.Text = "Varustelu";
            // 
            // lblhlomaara
            // 
            this.lblhlomaara.AutoSize = true;
            this.lblhlomaara.Location = new System.Drawing.Point(537, 120);
            this.lblhlomaara.Name = "lblhlomaara";
            this.lblhlomaara.Size = new System.Drawing.Size(95, 17);
            this.lblhlomaara.TabIndex = 42;
            this.lblhlomaara.Text = "Henkilömäärä";
            // 
            // lblmokkkuvaus
            // 
            this.lblmokkkuvaus.AutoSize = true;
            this.lblmokkkuvaus.Location = new System.Drawing.Point(537, 28);
            this.lblmokkkuvaus.Name = "lblmokkkuvaus";
            this.lblmokkkuvaus.Size = new System.Drawing.Size(55, 17);
            this.lblmokkkuvaus.TabIndex = 41;
            this.lblmokkkuvaus.Text = "Kuvaus";
            // 
            // lblmokkosoite
            // 
            this.lblmokkosoite.AutoSize = true;
            this.lblmokkosoite.Location = new System.Drawing.Point(59, 166);
            this.lblmokkosoite.Name = "lblmokkosoite";
            this.lblmokkosoite.Size = new System.Drawing.Size(75, 17);
            this.lblmokkosoite.TabIndex = 40;
            this.lblmokkosoite.Text = "Katuosoite";
            // 
            // lblMokkiNimi
            // 
            this.lblMokkiNimi.AutoSize = true;
            this.lblMokkiNimi.Location = new System.Drawing.Point(59, 119);
            this.lblMokkiNimi.Name = "lblMokkiNimi";
            this.lblMokkiNimi.Size = new System.Drawing.Size(74, 17);
            this.lblMokkiNimi.TabIndex = 39;
            this.lblMokkiNimi.Text = "Mökin nimi";
            // 
            // cmbMokkiToimialue
            // 
            this.cmbMokkiToimialue.DataSource = this.toimintaalueBindingSource;
            this.cmbMokkiToimialue.DisplayMember = "nimi";
            this.cmbMokkiToimialue.FormattingEnabled = true;
            this.cmbMokkiToimialue.Location = new System.Drawing.Point(220, 25);
            this.cmbMokkiToimialue.Name = "cmbMokkiToimialue";
            this.cmbMokkiToimialue.Size = new System.Drawing.Size(182, 24);
            this.cmbMokkiToimialue.TabIndex = 38;
            this.cmbMokkiToimialue.ValueMember = "toimintaalue_id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Valitse toimialue";
            // 
            // tbMokkiID
            // 
            this.tbMokkiID.Location = new System.Drawing.Point(217, 72);
            this.tbMokkiID.Name = "tbMokkiID";
            this.tbMokkiID.Size = new System.Drawing.Size(185, 22);
            this.tbMokkiID.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "mokkiID";
            // 
            // dgvToimiAlue
            // 
            this.dgvToimiAlue.AllowUserToAddRows = false;
            this.dgvToimiAlue.AllowUserToDeleteRows = false;
            this.dgvToimiAlue.AutoGenerateColumns = false;
            this.dgvToimiAlue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToimiAlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToimiAlue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toimintaalueidDataGridViewTextBoxColumn,
            this.nimiDataGridViewTextBoxColumn});
            this.dgvToimiAlue.DataSource = this.toimintaalueBindingSource;
            this.dgvToimiAlue.Location = new System.Drawing.Point(38, 90);
            this.dgvToimiAlue.Name = "dgvToimiAlue";
            this.dgvToimiAlue.ReadOnly = true;
            this.dgvToimiAlue.RowHeadersVisible = false;
            this.dgvToimiAlue.RowHeadersWidth = 51;
            this.dgvToimiAlue.RowTemplate.Height = 24;
            this.dgvToimiAlue.Size = new System.Drawing.Size(591, 171);
            this.dgvToimiAlue.TabIndex = 8;
            this.dgvToimiAlue.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToimiAlue_CellEnter);
            // 
            // dgvMokit
            // 
            this.dgvMokit.AllowUserToAddRows = false;
            this.dgvMokit.AllowUserToDeleteRows = false;
            this.dgvMokit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Location = new System.Drawing.Point(29, 362);
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.ReadOnly = true;
            this.dgvMokit.RowHeadersVisible = false;
            this.dgvMokit.RowHeadersWidth = 51;
            this.dgvMokit.RowTemplate.Height = 24;
            this.dgvMokit.Size = new System.Drawing.Size(1014, 242);
            this.dgvMokit.TabIndex = 53;
            // 
            // tabToimiAluePage3
            // 
            this.tabToimiAluePage3.Location = new System.Drawing.Point(4, 25);
            this.tabToimiAluePage3.Name = "tabToimiAluePage3";
            this.tabToimiAluePage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabToimiAluePage3.Size = new System.Drawing.Size(1014, 301);
            this.tabToimiAluePage3.TabIndex = 2;
            this.tabToimiAluePage3.Text = "Haku";
            this.tabToimiAluePage3.UseVisualStyleBackColor = true;
            // 
            // villageNewbiesDataSet
            // 
            this.villageNewbiesDataSet.DataSetName = "VillageNewbiesDataSet";
            this.villageNewbiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toimintaalueBindingSource
            // 
            this.toimintaalueBindingSource.DataMember = "toimintaalue";
            this.toimintaalueBindingSource.DataSource = this.villageNewbiesDataSet;
            // 
            // toimintaalueTableAdapter
            // 
            this.toimintaalueTableAdapter.ClearBeforeFill = true;
            // 
            // toimintaalueidDataGridViewTextBoxColumn
            // 
            this.toimintaalueidDataGridViewTextBoxColumn.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.HeaderText = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toimintaalueidDataGridViewTextBoxColumn.Name = "toimintaalueidDataGridViewTextBoxColumn";
            this.toimintaalueidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "nimi";
            this.nimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            this.nimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnUusiMokki
            // 
            this.btnUusiMokki.Location = new System.Drawing.Point(62, 256);
            this.btnUusiMokki.Name = "btnUusiMokki";
            this.btnUusiMokki.Size = new System.Drawing.Size(244, 31);
            this.btnUusiMokki.TabIndex = 53;
            this.btnUusiMokki.Text = "Lisää Mökki";
            this.btnUusiMokki.UseVisualStyleBackColor = true;
            this.btnUusiMokki.Click += new System.EventHandler(this.btnUusiMokki_Click);
            // 
            // btnMuutaMokkia
            // 
            this.btnMuutaMokkia.Location = new System.Drawing.Point(361, 256);
            this.btnMuutaMokkia.Name = "btnMuutaMokkia";
            this.btnMuutaMokkia.Size = new System.Drawing.Size(244, 31);
            this.btnMuutaMokkia.TabIndex = 54;
            this.btnMuutaMokkia.Text = "Muuta Mökin tietoja";
            this.btnMuutaMokkia.UseVisualStyleBackColor = true;
            this.btnMuutaMokkia.Click += new System.EventHandler(this.btnMuutaMokkia_Click);
            // 
            // btnPoistaMokki
            // 
            this.btnPoistaMokki.Location = new System.Drawing.Point(645, 256);
            this.btnPoistaMokki.Name = "btnPoistaMokki";
            this.btnPoistaMokki.Size = new System.Drawing.Size(244, 31);
            this.btnPoistaMokki.TabIndex = 55;
            this.btnPoistaMokki.Text = "Poista Mökki";
            this.btnPoistaMokki.UseVisualStyleBackColor = true;
            // 
            // Toiminta_alueet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 635);
            this.Controls.Add(this.dgvMokit);
            this.Controls.Add(this.tabToimintaAlue);
            this.Name = "Toiminta_alueet";
            this.Text = "Toiminta-alueet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Toiminta_alueet_FormClosing);
            this.Load += new System.EventHandler(this.Toiminta_alueet_Load);
            this.tabToimintaAlue.ResumeLayout(false);
            this.tabToimiAluePage1.ResumeLayout(false);
            this.tabToimiAluePage1.PerformLayout();
            this.tabToimiAluePage2.ResumeLayout(false);
            this.tabToimiAluePage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimiAlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toimintaalueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabToimintaAlue;
        private System.Windows.Forms.TabPage tabToimiAluePage1;
        private System.Windows.Forms.Label lblLisaaToiminta;
        private System.Windows.Forms.Button btnToimAluePoista;
        private System.Windows.Forms.TextBox tbToimiAlue;
        private System.Windows.Forms.Button btnToimAluLisaa;
        private System.Windows.Forms.Label lbltoimiid;
        private System.Windows.Forms.Label lbltoimNimi;
        private System.Windows.Forms.TextBox tbToimAlueNimi;
        private System.Windows.Forms.TabPage tabToimiAluePage2;
        private System.Windows.Forms.TextBox tbPostinro;
        private System.Windows.Forms.Label lblpostinro;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbVarustelu;
        private System.Windows.Forms.TextBox tbHloMaara;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbMokkiNimi;
        private System.Windows.Forms.Label lblHinta;
        private System.Windows.Forms.Label lblvarustelu;
        private System.Windows.Forms.Label lblhlomaara;
        private System.Windows.Forms.Label lblmokkkuvaus;
        private System.Windows.Forms.Label lblmokkosoite;
        private System.Windows.Forms.Label lblMokkiNimi;
        private System.Windows.Forms.ComboBox cmbMokkiToimialue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMokkiID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvToimiAlue;
        private System.Windows.Forms.TabPage tabToimiAluePage3;
        private System.Windows.Forms.DataGridView dgvMokit;
        private VillageNewbiesDataSet villageNewbiesDataSet;
        private System.Windows.Forms.BindingSource toimintaalueBindingSource;
        private VillageNewbiesDataSetTableAdapters.toimintaalueTableAdapter toimintaalueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPoistaMokki;
        private System.Windows.Forms.Button btnMuutaMokkia;
        private System.Windows.Forms.Button btnUusiMokki;
    }
}