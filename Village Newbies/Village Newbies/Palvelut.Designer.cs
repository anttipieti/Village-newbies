namespace Village_Newbies
{
    partial class Palvelut
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPalveluID = new System.Windows.Forms.TextBox();
            this.tbAlv = new System.Windows.Forms.TextBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbTyyppi = new System.Windows.Forms.TextBox();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.tbToimintaalueID = new System.Windows.Forms.TextBox();
            this.dataPalvelut = new System.Windows.Forms.DataGridView();
            this.villageNewbiesDataSet = new Village_Newbies.VillageNewbiesDataSet();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palveluTableAdapter = new Village_Newbies.VillageNewbiesDataSetTableAdapters.palveluTableAdapter();
            this.palveluidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyyppiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnTyhjenna = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PalveluID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hinta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kuvaus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tyyppi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nimi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Toiminta-alueID";
            // 
            // tbPalveluID
            // 
            this.tbPalveluID.Location = new System.Drawing.Point(119, 13);
            this.tbPalveluID.Name = "tbPalveluID";
            this.tbPalveluID.Size = new System.Drawing.Size(100, 20);
            this.tbPalveluID.TabIndex = 7;
            // 
            // tbAlv
            // 
            this.tbAlv.Location = new System.Drawing.Point(119, 194);
            this.tbAlv.Name = "tbAlv";
            this.tbAlv.Size = new System.Drawing.Size(100, 20);
            this.tbAlv.TabIndex = 8;
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(119, 168);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(100, 20);
            this.tbHinta.TabIndex = 9;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(119, 122);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(254, 40);
            this.tbKuvaus.TabIndex = 10;
            // 
            // tbTyyppi
            // 
            this.tbTyyppi.Location = new System.Drawing.Point(119, 94);
            this.tbTyyppi.Name = "tbTyyppi";
            this.tbTyyppi.Size = new System.Drawing.Size(100, 20);
            this.tbTyyppi.TabIndex = 11;
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(119, 66);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(100, 20);
            this.tbNimi.TabIndex = 12;
            // 
            // tbToimintaalueID
            // 
            this.tbToimintaalueID.Location = new System.Drawing.Point(119, 39);
            this.tbToimintaalueID.Name = "tbToimintaalueID";
            this.tbToimintaalueID.Size = new System.Drawing.Size(100, 20);
            this.tbToimintaalueID.TabIndex = 13;
            // 
            // dataPalvelut
            // 
            this.dataPalvelut.AutoGenerateColumns = false;
            this.dataPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palveluidDataGridViewTextBoxColumn,
            this.toimintaalueidDataGridViewTextBoxColumn,
            this.nimiDataGridViewTextBoxColumn,
            this.tyyppiDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn,
            this.alvDataGridViewTextBoxColumn});
            this.dataPalvelut.DataSource = this.palveluBindingSource;
            this.dataPalvelut.Location = new System.Drawing.Point(12, 220);
            this.dataPalvelut.Name = "dataPalvelut";
            this.dataPalvelut.Size = new System.Drawing.Size(576, 206);
            this.dataPalvelut.TabIndex = 14;
            this.dataPalvelut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgPalvelu_MouseClick);
            // 
            // villageNewbiesDataSet
            // 
            this.villageNewbiesDataSet.DataSetName = "VillageNewbiesDataSet";
            this.villageNewbiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // palveluidDataGridViewTextBoxColumn
            // 
            this.palveluidDataGridViewTextBoxColumn.DataPropertyName = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.HeaderText = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.Name = "palveluidDataGridViewTextBoxColumn";
            // 
            // toimintaalueidDataGridViewTextBoxColumn
            // 
            this.toimintaalueidDataGridViewTextBoxColumn.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.HeaderText = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.Name = "toimintaalueidDataGridViewTextBoxColumn";
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            // 
            // tyyppiDataGridViewTextBoxColumn
            // 
            this.tyyppiDataGridViewTextBoxColumn.DataPropertyName = "tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.HeaderText = "tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.Name = "tyyppiDataGridViewTextBoxColumn";
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            // 
            // hintaDataGridViewTextBoxColumn
            // 
            this.hintaDataGridViewTextBoxColumn.DataPropertyName = "hinta";
            this.hintaDataGridViewTextBoxColumn.HeaderText = "hinta";
            this.hintaDataGridViewTextBoxColumn.Name = "hintaDataGridViewTextBoxColumn";
            // 
            // alvDataGridViewTextBoxColumn
            // 
            this.alvDataGridViewTextBoxColumn.DataPropertyName = "alv";
            this.alvDataGridViewTextBoxColumn.HeaderText = "alv";
            this.alvDataGridViewTextBoxColumn.Name = "alvDataGridViewTextBoxColumn";
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(460, 13);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(75, 23);
            this.btnLisaa.TabIndex = 16;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(460, 149);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(75, 23);
            this.btnTyhjenna.TabIndex = 17;
            this.btnTyhjenna.Text = "Tyhjennä";
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(460, 103);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 18;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(460, 56);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(75, 23);
            this.btnMuokkaa.TabIndex = 19;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // Palvelut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 440);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnTyhjenna);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.dataPalvelut);
            this.Controls.Add(this.tbToimintaalueID);
            this.Controls.Add(this.tbNimi);
            this.Controls.Add(this.tbTyyppi);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.tbAlv);
            this.Controls.Add(this.tbPalveluID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Palvelut";
            this.Text = "Palvelut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Palvelut_FormClosing);
            this.Load += new System.EventHandler(this.Palvelut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPalveluID;
        private System.Windows.Forms.TextBox tbAlv;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.TextBox tbTyyppi;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.TextBox tbToimintaalueID;
        private System.Windows.Forms.DataGridView dataPalvelut;
        private VillageNewbiesDataSet villageNewbiesDataSet;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private VillageNewbiesDataSetTableAdapters.palveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn palveluidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyyppiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnTyhjenna;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnMuokkaa;
    }
}