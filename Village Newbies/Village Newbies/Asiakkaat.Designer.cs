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
            this.tabAsiakkaat = new System.Windows.Forms.TabControl();
            this.tab_as_selaa = new System.Windows.Forms.TabPage();
            this.tab_as_lisaa = new System.Windows.Forms.TabPage();
            this.btnAsLisaa = new System.Windows.Forms.Button();
            this.TbAsPuhNro = new System.Windows.Forms.TextBox();
            this.TbAsEmail = new System.Windows.Forms.TextBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.tabAsiakkaat.SuspendLayout();
            this.tab_as_lisaa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAsiakkaat
            // 
            this.tabAsiakkaat.Controls.Add(this.tab_as_selaa);
            this.tabAsiakkaat.Controls.Add(this.tab_as_lisaa);
            this.tabAsiakkaat.Location = new System.Drawing.Point(12, 34);
            this.tabAsiakkaat.Name = "tabAsiakkaat";
            this.tabAsiakkaat.SelectedIndex = 0;
            this.tabAsiakkaat.Size = new System.Drawing.Size(952, 306);
            this.tabAsiakkaat.TabIndex = 0;
            // 
            // tab_as_selaa
            // 
            this.tab_as_selaa.BackColor = System.Drawing.Color.White;
            this.tab_as_selaa.Location = new System.Drawing.Point(4, 25);
            this.tab_as_selaa.Name = "tab_as_selaa";
            this.tab_as_selaa.Padding = new System.Windows.Forms.Padding(3);
            this.tab_as_selaa.Size = new System.Drawing.Size(944, 277);
            this.tab_as_selaa.TabIndex = 1;
            this.tab_as_selaa.Text = "Selaa";
            // 
            // tab_as_lisaa
            // 
            this.tab_as_lisaa.BackColor = System.Drawing.Color.White;
            this.tab_as_lisaa.Controls.Add(this.btnAsLisaa);
            this.tab_as_lisaa.Controls.Add(this.TbAsPuhNro);
            this.tab_as_lisaa.Controls.Add(this.TbAsEmail);
            this.tab_as_lisaa.Controls.Add(this.tbAsPostinro);
            this.tab_as_lisaa.Controls.Add(this.tbAsLOsoite);
            this.tab_as_lisaa.Controls.Add(this.tbAsSukunimi);
            this.tab_as_lisaa.Controls.Add(this.tbAsEtunimi);
            this.tab_as_lisaa.Controls.Add(this.lbAsPuhNro);
            this.tab_as_lisaa.Controls.Add(this.lbAsEmail);
            this.tab_as_lisaa.Controls.Add(this.lbAsPostinro);
            this.tab_as_lisaa.Controls.Add(this.lbAsLOsoite);
            this.tab_as_lisaa.Controls.Add(this.lbAsSukunimi);
            this.tab_as_lisaa.Controls.Add(this.lbAsEtunimi);
            this.tab_as_lisaa.Location = new System.Drawing.Point(4, 25);
            this.tab_as_lisaa.Name = "tab_as_lisaa";
            this.tab_as_lisaa.Padding = new System.Windows.Forms.Padding(3);
            this.tab_as_lisaa.Size = new System.Drawing.Size(944, 277);
            this.tab_as_lisaa.TabIndex = 0;
            this.tab_as_lisaa.Text = "Lisää";
            // 
            // btnAsLisaa
            // 
            this.btnAsLisaa.BackColor = System.Drawing.SystemColors.Control;
            this.btnAsLisaa.Location = new System.Drawing.Point(748, 206);
            this.btnAsLisaa.Name = "btnAsLisaa";
            this.btnAsLisaa.Size = new System.Drawing.Size(125, 25);
            this.btnAsLisaa.TabIndex = 12;
            this.btnAsLisaa.Text = "Lisää";
            this.btnAsLisaa.UseVisualStyleBackColor = false;
            // 
            // TbAsPuhNro
            // 
            this.TbAsPuhNro.Location = new System.Drawing.Point(282, 207);
            this.TbAsPuhNro.Name = "TbAsPuhNro";
            this.TbAsPuhNro.Size = new System.Drawing.Size(321, 22);
            this.TbAsPuhNro.TabIndex = 11;
            // 
            // TbAsEmail
            // 
            this.TbAsEmail.Location = new System.Drawing.Point(282, 172);
            this.TbAsEmail.Name = "TbAsEmail";
            this.TbAsEmail.Size = new System.Drawing.Size(321, 22);
            this.TbAsEmail.TabIndex = 10;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.etunimiDataGridViewTextBoxColumn,
            this.sukunimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.asiakasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 490);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(948, 209);
            this.dataGridView1.TabIndex = 1;
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
            // Asiakkaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 723);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabAsiakkaat);
            this.Name = "Asiakkaat";
            this.Text = "Asiakkaat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Asiakkaat_FormClosing);
            this.Load += new System.EventHandler(this.Asiakkaat_Load);
            this.tabAsiakkaat.ResumeLayout(false);
            this.tab_as_lisaa.ResumeLayout(false);
            this.tab_as_lisaa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAsiakkaat;
        private System.Windows.Forms.TabPage tab_as_lisaa;
        private System.Windows.Forms.TabPage tab_as_selaa;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label lbAsEtunimi;
        private System.Windows.Forms.Label lbAsSukunimi;
        private System.Windows.Forms.Label lbAsPostinro;
        private System.Windows.Forms.Label lbAsLOsoite;
        private System.Windows.Forms.Label lbAsEmail;
        private System.Windows.Forms.Label lbAsPuhNro;
        private System.Windows.Forms.TextBox tbAsLOsoite;
        private System.Windows.Forms.TextBox tbAsSukunimi;
        private System.Windows.Forms.TextBox tbAsEtunimi;
        private System.Windows.Forms.Button btnAsLisaa;
        private System.Windows.Forms.TextBox TbAsPuhNro;
        private System.Windows.Forms.TextBox TbAsEmail;
        private System.Windows.Forms.TextBox tbAsPostinro;
    }
}