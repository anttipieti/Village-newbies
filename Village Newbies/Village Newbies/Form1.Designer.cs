namespace Ohjelmistotuotanto_1
{
    partial class Form1
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
            this.TCtrl = new System.Windows.Forms.TabControl();
            this.LisääSivuTPage = new System.Windows.Forms.TabPage();
            this.MuokkaaSivuTPage = new System.Windows.Forms.TabPage();
            this.PoistaSivuTPage = new System.Windows.Forms.TabPage();
            this.HaeSivuTPage = new System.Windows.Forms.TabPage();
            this.LblLaskuID = new System.Windows.Forms.Label();
            this.LblVarausID = new System.Windows.Forms.Label();
            this.LblSumma = new System.Windows.Forms.Label();
            this.LblALV = new System.Windows.Forms.Label();
            this.TBoxLaskuID = new System.Windows.Forms.TextBox();
            this.TBoxVarausID = new System.Windows.Forms.TextBox();
            this.TBoxSumma = new System.Windows.Forms.TextBox();
            this.TBoxALV = new System.Windows.Forms.TextBox();
            this.BtnLisää = new System.Windows.Forms.Button();
            this.TCtrl.SuspendLayout();
            this.LisääSivuTPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCtrl
            // 
            this.TCtrl.Controls.Add(this.LisääSivuTPage);
            this.TCtrl.Controls.Add(this.MuokkaaSivuTPage);
            this.TCtrl.Controls.Add(this.PoistaSivuTPage);
            this.TCtrl.Controls.Add(this.HaeSivuTPage);
            this.TCtrl.Location = new System.Drawing.Point(12, 12);
            this.TCtrl.Name = "TCtrl";
            this.TCtrl.SelectedIndex = 0;
            this.TCtrl.Size = new System.Drawing.Size(718, 506);
            this.TCtrl.TabIndex = 1;
            // 
            // LisääSivuTPage
            // 
            this.LisääSivuTPage.Controls.Add(this.BtnLisää);
            this.LisääSivuTPage.Controls.Add(this.TBoxALV);
            this.LisääSivuTPage.Controls.Add(this.TBoxSumma);
            this.LisääSivuTPage.Controls.Add(this.TBoxVarausID);
            this.LisääSivuTPage.Controls.Add(this.TBoxLaskuID);
            this.LisääSivuTPage.Controls.Add(this.LblALV);
            this.LisääSivuTPage.Controls.Add(this.LblSumma);
            this.LisääSivuTPage.Controls.Add(this.LblVarausID);
            this.LisääSivuTPage.Controls.Add(this.LblLaskuID);
            this.LisääSivuTPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LisääSivuTPage.Location = new System.Drawing.Point(4, 22);
            this.LisääSivuTPage.Name = "LisääSivuTPage";
            this.LisääSivuTPage.Padding = new System.Windows.Forms.Padding(3);
            this.LisääSivuTPage.Size = new System.Drawing.Size(710, 480);
            this.LisääSivuTPage.TabIndex = 0;
            this.LisääSivuTPage.Text = "Lisää";
            this.LisääSivuTPage.UseVisualStyleBackColor = true;
            this.LisääSivuTPage.Click += new System.EventHandler(this.TPage1_Click);
            // 
            // MuokkaaSivuTPage
            // 
            this.MuokkaaSivuTPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuokkaaSivuTPage.Location = new System.Drawing.Point(4, 22);
            this.MuokkaaSivuTPage.Name = "MuokkaaSivuTPage";
            this.MuokkaaSivuTPage.Padding = new System.Windows.Forms.Padding(3);
            this.MuokkaaSivuTPage.Size = new System.Drawing.Size(710, 480);
            this.MuokkaaSivuTPage.TabIndex = 1;
            this.MuokkaaSivuTPage.Text = "Muokkaa";
            this.MuokkaaSivuTPage.UseVisualStyleBackColor = true;
            // 
            // PoistaSivuTPage
            // 
            this.PoistaSivuTPage.Location = new System.Drawing.Point(4, 22);
            this.PoistaSivuTPage.Name = "PoistaSivuTPage";
            this.PoistaSivuTPage.Padding = new System.Windows.Forms.Padding(3);
            this.PoistaSivuTPage.Size = new System.Drawing.Size(710, 480);
            this.PoistaSivuTPage.TabIndex = 2;
            this.PoistaSivuTPage.Text = "Poista";
            this.PoistaSivuTPage.UseVisualStyleBackColor = true;
            // 
            // HaeSivuTPage
            // 
            this.HaeSivuTPage.Location = new System.Drawing.Point(4, 22);
            this.HaeSivuTPage.Name = "HaeSivuTPage";
            this.HaeSivuTPage.Padding = new System.Windows.Forms.Padding(3);
            this.HaeSivuTPage.Size = new System.Drawing.Size(710, 480);
            this.HaeSivuTPage.TabIndex = 3;
            this.HaeSivuTPage.Text = "Hae";
            this.HaeSivuTPage.UseVisualStyleBackColor = true;
            // 
            // LblLaskuID
            // 
            this.LblLaskuID.AutoSize = true;
            this.LblLaskuID.Location = new System.Drawing.Point(26, 23);
            this.LblLaskuID.Name = "LblLaskuID";
            this.LblLaskuID.Size = new System.Drawing.Size(69, 20);
            this.LblLaskuID.TabIndex = 0;
            this.LblLaskuID.Text = "LaskuID";
            // 
            // LblVarausID
            // 
            this.LblVarausID.AutoSize = true;
            this.LblVarausID.Location = new System.Drawing.Point(26, 72);
            this.LblVarausID.Name = "LblVarausID";
            this.LblVarausID.Size = new System.Drawing.Size(77, 20);
            this.LblVarausID.TabIndex = 1;
            this.LblVarausID.Text = "VarausID";
            // 
            // LblSumma
            // 
            this.LblSumma.AutoSize = true;
            this.LblSumma.Location = new System.Drawing.Point(26, 119);
            this.LblSumma.Name = "LblSumma";
            this.LblSumma.Size = new System.Drawing.Size(64, 20);
            this.LblSumma.TabIndex = 2;
            this.LblSumma.Text = "Summa";
            // 
            // LblALV
            // 
            this.LblALV.AutoSize = true;
            this.LblALV.Location = new System.Drawing.Point(26, 169);
            this.LblALV.Name = "LblALV";
            this.LblALV.Size = new System.Drawing.Size(40, 20);
            this.LblALV.TabIndex = 3;
            this.LblALV.Text = "ALV";
            // 
            // TBoxLaskuID
            // 
            this.TBoxLaskuID.Location = new System.Drawing.Point(200, 20);
            this.TBoxLaskuID.Name = "TBoxLaskuID";
            this.TBoxLaskuID.Size = new System.Drawing.Size(261, 26);
            this.TBoxLaskuID.TabIndex = 4;
            // 
            // TBoxVarausID
            // 
            this.TBoxVarausID.Location = new System.Drawing.Point(200, 69);
            this.TBoxVarausID.Name = "TBoxVarausID";
            this.TBoxVarausID.Size = new System.Drawing.Size(261, 26);
            this.TBoxVarausID.TabIndex = 5;
            // 
            // TBoxSumma
            // 
            this.TBoxSumma.Location = new System.Drawing.Point(200, 116);
            this.TBoxSumma.Name = "TBoxSumma";
            this.TBoxSumma.Size = new System.Drawing.Size(261, 26);
            this.TBoxSumma.TabIndex = 6;
            // 
            // TBoxALV
            // 
            this.TBoxALV.Location = new System.Drawing.Point(200, 166);
            this.TBoxALV.Name = "TBoxALV";
            this.TBoxALV.Size = new System.Drawing.Size(261, 26);
            this.TBoxALV.TabIndex = 7;
            // 
            // BtnLisää
            // 
            this.BtnLisää.Location = new System.Drawing.Point(359, 215);
            this.BtnLisää.Name = "BtnLisää";
            this.BtnLisää.Size = new System.Drawing.Size(102, 34);
            this.BtnLisää.TabIndex = 8;
            this.BtnLisää.Text = "Lisää";
            this.BtnLisää.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 530);
            this.Controls.Add(this.TCtrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TCtrl.ResumeLayout(false);
            this.LisääSivuTPage.ResumeLayout(false);
            this.LisääSivuTPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCtrl;
        private System.Windows.Forms.TabPage LisääSivuTPage;
        private System.Windows.Forms.TabPage MuokkaaSivuTPage;
        private System.Windows.Forms.TabPage PoistaSivuTPage;
        private System.Windows.Forms.TabPage HaeSivuTPage;
        private System.Windows.Forms.Button BtnLisää;
        private System.Windows.Forms.TextBox TBoxALV;
        private System.Windows.Forms.TextBox TBoxSumma;
        private System.Windows.Forms.TextBox TBoxVarausID;
        private System.Windows.Forms.TextBox TBoxLaskuID;
        private System.Windows.Forms.Label LblALV;
        private System.Windows.Forms.Label LblSumma;
        private System.Windows.Forms.Label LblVarausID;
        private System.Windows.Forms.Label LblLaskuID;
    }
}

