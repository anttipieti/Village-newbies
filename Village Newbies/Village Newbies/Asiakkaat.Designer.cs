namespace Village_Newbies
{
    partial class Asiakkaat
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
            this.dgAsiakas = new System.Windows.Forms.DataGridView();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villageNewbiesDataSet = new Village_Newbies.VillageNewbiesDataSet();
            this.asiakasTableAdapter = new Village_Newbies.VillageNewbiesDataSetTableAdapters.asiakasTableAdapter();
            this.tab_muokkaa = new System.Windows.Forms.TabPage();
            this.btnAsPoista = new System.Windows.Forms.Button();
            this.btnAsMuokkaa = new System.Windows.Forms.Button();
            this.btnAsLisaa = new System.Windows.Forms.Button();
            this.tbAsPuhNro = new System.Windows.Forms.TextBox();
            this.tbAsEmail = new System.Windows.Forms.TextBox();
            this.tbAsPostinro = new System.Windows.Forms.TextBox();
            this.tbAsLOsoite = new System.Windows.Forms.TextBox();
            this.tbAsSukunimi = new System.Windows.Forms.TextBox();
            this.tbAsEtunimi = new System.Windows.Forms.TextBox();
            this.lbAsPuhNro = new System.Windows.Forms.Label();
            this.lbAsEmail = new System.Windows.Forms.Label();
            this.lbAsPostinro = new System.Windows.Forms.Label();
            this.lbAsLOsoite = new System.Windows.Forms.Label();
            this.lbAsSukunimi = new System.Windows.Forms.Label();
            this.lbAsEtunimi = new System.Windows.Forms.Label();
            this.tabAsiakkaat = new System.Windows.Forms.TabControl();
            this.tab_as_hae = new System.Windows.Forms.TabPage();
            this.gbAsHae = new System.Windows.Forms.GroupBox();
            this.cbAsPostinro = new System.Windows.Forms.CheckBox();
            this.cbAsPuhNro = new System.Windows.Forms.CheckBox();
            this.cbAsEtunimi = new System.Windows.Forms.CheckBox();
            this.cbAsEmail = new System.Windows.Forms.CheckBox();
            this.cbAsSukunimi = new System.Windows.Forms.CheckBox();
            this.cbAsLOsoite = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbHakusana = new System.Windows.Forms.Label();
            this.lbAsID = new System.Windows.Forms.Label();
            this.tbAsID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsiakas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).BeginInit();
            this.tab_muokkaa.SuspendLayout();
            this.tabAsiakkaat.SuspendLayout();
            this.tab_as_hae.SuspendLayout();
            this.gbAsHae.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAsiakas
            // 
            this.dgAsiakas.AllowUserToAddRows = false;
            this.dgAsiakas.AllowUserToDeleteRows = false;
            this.dgAsiakas.AutoGenerateColumns = false;
            this.dgAsiakas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsiakas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.etunimiDataGridViewTextBoxColumn,
            this.sukunimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.dgAsiakas.DataSource = this.asiakasBindingSource;
            this.dgAsiakas.Location = new System.Drawing.Point(12, 381);
            this.dgAsiakas.Name = "dgAsiakas";
            this.dgAsiakas.RowHeadersWidth = 51;
            this.dgAsiakas.RowTemplate.Height = 24;
            this.dgAsiakas.Size = new System.Drawing.Size(948, 318);
            this.dgAsiakas.TabIndex = 1;
            this.dgAsiakas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgAsiakas_MouseClick);
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            this.asiakasidDataGridViewTextBoxColumn.Width = 125;
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            this.postinroDataGridViewTextBoxColumn.Width = 125;
            // 
            // etunimiDataGridViewTextBoxColumn
            // 
            this.etunimiDataGridViewTextBoxColumn.DataPropertyName = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.HeaderText = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.etunimiDataGridViewTextBoxColumn.Name = "etunimiDataGridViewTextBoxColumn";
            this.etunimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sukunimiDataGridViewTextBoxColumn
            // 
            this.sukunimiDataGridViewTextBoxColumn.DataPropertyName = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.HeaderText = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sukunimiDataGridViewTextBoxColumn.Name = "sukunimiDataGridViewTextBoxColumn";
            this.sukunimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            this.lahiosoiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // puhelinnroDataGridViewTextBoxColumn
            // 
            this.puhelinnroDataGridViewTextBoxColumn.DataPropertyName = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.HeaderText = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.puhelinnroDataGridViewTextBoxColumn.Name = "puhelinnroDataGridViewTextBoxColumn";
            this.puhelinnroDataGridViewTextBoxColumn.Width = 125;
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
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // tab_muokkaa
            // 
            this.tab_muokkaa.BackColor = System.Drawing.Color.White;
            this.tab_muokkaa.Controls.Add(this.tbAsID);
            this.tab_muokkaa.Controls.Add(this.lbAsID);
            this.tab_muokkaa.Controls.Add(this.btnAsPoista);
            this.tab_muokkaa.Controls.Add(this.btnAsMuokkaa);
            this.tab_muokkaa.Controls.Add(this.btnAsLisaa);
            this.tab_muokkaa.Controls.Add(this.tbAsPuhNro);
            this.tab_muokkaa.Controls.Add(this.tbAsEmail);
            this.tab_muokkaa.Controls.Add(this.tbAsPostinro);
            this.tab_muokkaa.Controls.Add(this.tbAsLOsoite);
            this.tab_muokkaa.Controls.Add(this.tbAsSukunimi);
            this.tab_muokkaa.Controls.Add(this.tbAsEtunimi);
            this.tab_muokkaa.Controls.Add(this.lbAsPuhNro);
            this.tab_muokkaa.Controls.Add(this.lbAsEmail);
            this.tab_muokkaa.Controls.Add(this.lbAsPostinro);
            this.tab_muokkaa.Controls.Add(this.lbAsLOsoite);
            this.tab_muokkaa.Controls.Add(this.lbAsSukunimi);
            this.tab_muokkaa.Controls.Add(this.lbAsEtunimi);
            this.tab_muokkaa.Location = new System.Drawing.Point(4, 25);
            this.tab_muokkaa.Name = "tab_muokkaa";
            this.tab_muokkaa.Padding = new System.Windows.Forms.Padding(3);
            this.tab_muokkaa.Size = new System.Drawing.Size(944, 277);
            this.tab_muokkaa.TabIndex = 0;
            this.tab_muokkaa.Text = "Muokkaa";
            // 
            // btnAsPoista
            // 
            this.btnAsPoista.BackColor = System.Drawing.SystemColors.Control;
            this.btnAsPoista.Location = new System.Drawing.Point(748, 202);
            this.btnAsPoista.Name = "btnAsPoista";
            this.btnAsPoista.Size = new System.Drawing.Size(125, 25);
            this.btnAsPoista.TabIndex = 14;
            this.btnAsPoista.Text = "Poista";
            this.btnAsPoista.UseVisualStyleBackColor = false;
            // 
            // btnAsMuokkaa
            // 
            this.btnAsMuokkaa.BackColor = System.Drawing.SystemColors.Control;
            this.btnAsMuokkaa.Location = new System.Drawing.Point(748, 167);
            this.btnAsMuokkaa.Name = "btnAsMuokkaa";
            this.btnAsMuokkaa.Size = new System.Drawing.Size(125, 25);
            this.btnAsMuokkaa.TabIndex = 13;
            this.btnAsMuokkaa.Text = "Muokkaa";
            this.btnAsMuokkaa.UseVisualStyleBackColor = false;
            this.btnAsMuokkaa.Click += new System.EventHandler(this.btnAsMuokkaa_Click);
            // 
            // btnAsLisaa
            // 
            this.btnAsLisaa.BackColor = System.Drawing.SystemColors.Control;
            this.btnAsLisaa.Location = new System.Drawing.Point(748, 132);
            this.btnAsLisaa.Name = "btnAsLisaa";
            this.btnAsLisaa.Size = new System.Drawing.Size(125, 25);
            this.btnAsLisaa.TabIndex = 12;
            this.btnAsLisaa.Text = "Lisää";
            this.btnAsLisaa.UseVisualStyleBackColor = false;
            this.btnAsLisaa.Click += new System.EventHandler(this.btnAsLisaa_Click);
            // 
            // tbAsPuhNro
            // 
            this.tbAsPuhNro.Location = new System.Drawing.Point(282, 207);
            this.tbAsPuhNro.Name = "tbAsPuhNro";
            this.tbAsPuhNro.Size = new System.Drawing.Size(321, 22);
            this.tbAsPuhNro.TabIndex = 11;
            // 
            // tbAsEmail
            // 
            this.tbAsEmail.Location = new System.Drawing.Point(282, 172);
            this.tbAsEmail.Name = "tbAsEmail";
            this.tbAsEmail.Size = new System.Drawing.Size(321, 22);
            this.tbAsEmail.TabIndex = 10;
            // 
            // tbAsPostinro
            // 
            this.tbAsPostinro.Location = new System.Drawing.Point(282, 137);
            this.tbAsPostinro.Name = "tbAsPostinro";
            this.tbAsPostinro.Size = new System.Drawing.Size(111, 22);
            this.tbAsPostinro.TabIndex = 9;
            // 
            // tbAsLOsoite
            // 
            this.tbAsLOsoite.Location = new System.Drawing.Point(282, 105);
            this.tbAsLOsoite.Name = "tbAsLOsoite";
            this.tbAsLOsoite.Size = new System.Drawing.Size(321, 22);
            this.tbAsLOsoite.TabIndex = 8;
            // 
            // tbAsSukunimi
            // 
            this.tbAsSukunimi.Location = new System.Drawing.Point(282, 70);
            this.tbAsSukunimi.Name = "tbAsSukunimi";
            this.tbAsSukunimi.Size = new System.Drawing.Size(321, 22);
            this.tbAsSukunimi.TabIndex = 7;
            // 
            // tbAsEtunimi
            // 
            this.tbAsEtunimi.Location = new System.Drawing.Point(282, 35);
            this.tbAsEtunimi.Name = "tbAsEtunimi";
            this.tbAsEtunimi.Size = new System.Drawing.Size(321, 22);
            this.tbAsEtunimi.TabIndex = 6;
            // 
            // lbAsPuhNro
            // 
            this.lbAsPuhNro.AutoSize = true;
            this.lbAsPuhNro.Location = new System.Drawing.Point(57, 210);
            this.lbAsPuhNro.Name = "lbAsPuhNro";
            this.lbAsPuhNro.Size = new System.Drawing.Size(103, 17);
            this.lbAsPuhNro.TabIndex = 5;
            this.lbAsPuhNro.Text = "Puhelinnumero";
            // 
            // lbAsEmail
            // 
            this.lbAsEmail.AutoSize = true;
            this.lbAsEmail.Location = new System.Drawing.Point(57, 175);
            this.lbAsEmail.Name = "lbAsEmail";
            this.lbAsEmail.Size = new System.Drawing.Size(116, 17);
            this.lbAsEmail.TabIndex = 4;
            this.lbAsEmail.Text = "Sähköpostiosoite";
            // 
            // lbAsPostinro
            // 
            this.lbAsPostinro.AutoSize = true;
            this.lbAsPostinro.Location = new System.Drawing.Point(57, 140);
            this.lbAsPostinro.Name = "lbAsPostinro";
            this.lbAsPostinro.Size = new System.Drawing.Size(87, 17);
            this.lbAsPostinro.TabIndex = 3;
            this.lbAsPostinro.Text = "Postinumero";
            // 
            // lbAsLOsoite
            // 
            this.lbAsLOsoite.AutoSize = true;
            this.lbAsLOsoite.Location = new System.Drawing.Point(57, 105);
            this.lbAsLOsoite.Name = "lbAsLOsoite";
            this.lbAsLOsoite.Size = new System.Drawing.Size(73, 17);
            this.lbAsLOsoite.TabIndex = 2;
            this.lbAsLOsoite.Text = "Lähiosoite";
            // 
            // lbAsSukunimi
            // 
            this.lbAsSukunimi.AutoSize = true;
            this.lbAsSukunimi.Location = new System.Drawing.Point(57, 70);
            this.lbAsSukunimi.Name = "lbAsSukunimi";
            this.lbAsSukunimi.Size = new System.Drawing.Size(65, 17);
            this.lbAsSukunimi.TabIndex = 1;
            this.lbAsSukunimi.Text = "Sukunimi";
            // 
            // lbAsEtunimi
            // 
            this.lbAsEtunimi.AutoSize = true;
            this.lbAsEtunimi.Location = new System.Drawing.Point(57, 35);
            this.lbAsEtunimi.Name = "lbAsEtunimi";
            this.lbAsEtunimi.Size = new System.Drawing.Size(54, 17);
            this.lbAsEtunimi.TabIndex = 0;
            this.lbAsEtunimi.Text = "Etunimi";
            // 
            // tabAsiakkaat
            // 
            this.tabAsiakkaat.Controls.Add(this.tab_muokkaa);
            this.tabAsiakkaat.Controls.Add(this.tab_as_hae);
            this.tabAsiakkaat.Location = new System.Drawing.Point(12, 34);
            this.tabAsiakkaat.Name = "tabAsiakkaat";
            this.tabAsiakkaat.SelectedIndex = 0;
            this.tabAsiakkaat.Size = new System.Drawing.Size(952, 306);
            this.tabAsiakkaat.TabIndex = 0;
            // 
            // tab_as_hae
            // 
            this.tab_as_hae.BackColor = System.Drawing.Color.White;
            this.tab_as_hae.Controls.Add(this.gbAsHae);
            this.tab_as_hae.Controls.Add(this.button1);
            this.tab_as_hae.Controls.Add(this.textBox5);
            this.tab_as_hae.Controls.Add(this.lbHakusana);
            this.tab_as_hae.Location = new System.Drawing.Point(4, 25);
            this.tab_as_hae.Name = "tab_as_hae";
            this.tab_as_hae.Padding = new System.Windows.Forms.Padding(3);
            this.tab_as_hae.Size = new System.Drawing.Size(944, 277);
            this.tab_as_hae.TabIndex = 1;
            this.tab_as_hae.Text = "Hae";
            // 
            // gbAsHae
            // 
            this.gbAsHae.Controls.Add(this.cbAsPostinro);
            this.gbAsHae.Controls.Add(this.cbAsPuhNro);
            this.gbAsHae.Controls.Add(this.cbAsEtunimi);
            this.gbAsHae.Controls.Add(this.cbAsEmail);
            this.gbAsHae.Controls.Add(this.cbAsSukunimi);
            this.gbAsHae.Controls.Add(this.cbAsLOsoite);
            this.gbAsHae.Location = new System.Drawing.Point(280, 97);
            this.gbAsHae.Name = "gbAsHae";
            this.gbAsHae.Size = new System.Drawing.Size(321, 127);
            this.gbAsHae.TabIndex = 37;
            this.gbAsHae.TabStop = false;
            this.gbAsHae.Text = "Hae";
            // 
            // cbAsPostinro
            // 
            this.cbAsPostinro.AutoSize = true;
            this.cbAsPostinro.Location = new System.Drawing.Point(182, 57);
            this.cbAsPostinro.Name = "cbAsPostinro";
            this.cbAsPostinro.Size = new System.Drawing.Size(109, 21);
            this.cbAsPostinro.TabIndex = 34;
            this.cbAsPostinro.Text = "Postinumero";
            this.cbAsPostinro.UseVisualStyleBackColor = true;
            // 
            // cbAsPuhNro
            // 
            this.cbAsPuhNro.AutoSize = true;
            this.cbAsPuhNro.Location = new System.Drawing.Point(182, 84);
            this.cbAsPuhNro.Name = "cbAsPuhNro";
            this.cbAsPuhNro.Size = new System.Drawing.Size(125, 21);
            this.cbAsPuhNro.TabIndex = 36;
            this.cbAsPuhNro.Text = "Puhelinnumero";
            this.cbAsPuhNro.UseVisualStyleBackColor = true;
            // 
            // cbAsEtunimi
            // 
            this.cbAsEtunimi.AutoSize = true;
            this.cbAsEtunimi.Location = new System.Drawing.Point(16, 30);
            this.cbAsEtunimi.Name = "cbAsEtunimi";
            this.cbAsEtunimi.Size = new System.Drawing.Size(76, 21);
            this.cbAsEtunimi.TabIndex = 28;
            this.cbAsEtunimi.Text = "Etunimi";
            this.cbAsEtunimi.UseVisualStyleBackColor = true;
            // 
            // cbAsEmail
            // 
            this.cbAsEmail.AutoSize = true;
            this.cbAsEmail.Location = new System.Drawing.Point(16, 84);
            this.cbAsEmail.Name = "cbAsEmail";
            this.cbAsEmail.Size = new System.Drawing.Size(100, 21);
            this.cbAsEmail.TabIndex = 35;
            this.cbAsEmail.Text = "Sähköposti";
            this.cbAsEmail.UseVisualStyleBackColor = true;
            // 
            // cbAsSukunimi
            // 
            this.cbAsSukunimi.AutoSize = true;
            this.cbAsSukunimi.Location = new System.Drawing.Point(182, 30);
            this.cbAsSukunimi.Name = "cbAsSukunimi";
            this.cbAsSukunimi.Size = new System.Drawing.Size(87, 21);
            this.cbAsSukunimi.TabIndex = 32;
            this.cbAsSukunimi.Text = "Sukunimi";
            this.cbAsSukunimi.UseVisualStyleBackColor = true;
            // 
            // cbAsLOsoite
            // 
            this.cbAsLOsoite.AutoSize = true;
            this.cbAsLOsoite.Location = new System.Drawing.Point(16, 57);
            this.cbAsLOsoite.Name = "cbAsLOsoite";
            this.cbAsLOsoite.Size = new System.Drawing.Size(95, 21);
            this.cbAsLOsoite.TabIndex = 33;
            this.cbAsLOsoite.Text = "Lähiosoite";
            this.cbAsLOsoite.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(755, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 25);
            this.button1.TabIndex = 27;
            this.button1.Text = "Poista";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(280, 59);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(321, 22);
            this.textBox5.TabIndex = 22;
            // 
            // lbHakusana
            // 
            this.lbHakusana.AutoSize = true;
            this.lbHakusana.Location = new System.Drawing.Point(78, 62);
            this.lbHakusana.Name = "lbHakusana";
            this.lbHakusana.Size = new System.Drawing.Size(72, 17);
            this.lbHakusana.TabIndex = 20;
            this.lbHakusana.Text = "Hakusana";
            // 
            // lbAsID
            // 
            this.lbAsID.AutoSize = true;
            this.lbAsID.Location = new System.Drawing.Point(745, 38);
            this.lbAsID.Name = "lbAsID";
            this.lbAsID.Size = new System.Drawing.Size(60, 17);
            this.lbAsID.TabIndex = 15;
            this.lbAsID.Text = "Tunnus:";
            // 
            // tbAsID
            // 
            this.tbAsID.Location = new System.Drawing.Point(818, 35);
            this.tbAsID.Name = "tbAsID";
            this.tbAsID.ReadOnly = true;
            this.tbAsID.Size = new System.Drawing.Size(55, 22);
            this.tbAsID.TabIndex = 16;
            // 
            // Asiakkaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 723);
            this.Controls.Add(this.dgAsiakas);
            this.Controls.Add(this.tabAsiakkaat);
            this.Name = "Asiakkaat";
            this.Text = "Asiakkaat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Asiakkaat_FormClosing);
            this.Load += new System.EventHandler(this.Asiakkaat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsiakas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).EndInit();
            this.tab_muokkaa.ResumeLayout(false);
            this.tab_muokkaa.PerformLayout();
            this.tabAsiakkaat.ResumeLayout(false);
            this.tab_as_hae.ResumeLayout(false);
            this.tab_as_hae.PerformLayout();
            this.gbAsHae.ResumeLayout(false);
            this.gbAsHae.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgAsiakas;
        private VillageNewbiesDataSet villageNewbiesDataSet;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private VillageNewbiesDataSetTableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tab_muokkaa;
        private System.Windows.Forms.Button btnAsLisaa;
        private System.Windows.Forms.TextBox tbAsPuhNro;
        private System.Windows.Forms.TextBox tbAsEmail;
        private System.Windows.Forms.TextBox tbAsPostinro;
        private System.Windows.Forms.TextBox tbAsLOsoite;
        private System.Windows.Forms.TextBox tbAsSukunimi;
        private System.Windows.Forms.TextBox tbAsEtunimi;
        private System.Windows.Forms.Label lbAsPuhNro;
        private System.Windows.Forms.Label lbAsEmail;
        private System.Windows.Forms.Label lbAsPostinro;
        private System.Windows.Forms.Label lbAsLOsoite;
        private System.Windows.Forms.Label lbAsSukunimi;
        private System.Windows.Forms.Label lbAsEtunimi;
        private System.Windows.Forms.TabControl tabAsiakkaat;
        private System.Windows.Forms.Button btnAsPoista;
        private System.Windows.Forms.Button btnAsMuokkaa;
        private System.Windows.Forms.TabPage tab_as_hae;
        private System.Windows.Forms.CheckBox cbAsEmail;
        private System.Windows.Forms.CheckBox cbAsPostinro;
        private System.Windows.Forms.CheckBox cbAsLOsoite;
        private System.Windows.Forms.CheckBox cbAsSukunimi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbAsEtunimi;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbHakusana;
        private System.Windows.Forms.CheckBox cbAsPuhNro;
        private System.Windows.Forms.GroupBox gbAsHae;
        private System.Windows.Forms.Label lbAsID;
        private System.Windows.Forms.TextBox tbAsID;
    }
}