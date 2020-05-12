namespace Village_Newbies
{
    partial class MainMenu
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
            this.btnMenuVaraukset = new System.Windows.Forms.Button();
            this.btnMenuAs = new System.Windows.Forms.Button();
            this.btnMenuAlueet = new System.Windows.Forms.Button();
            this.btnMenuPalvelut = new System.Windows.Forms.Button();
            this.btnMenuLaskut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuVaraukset
            // 
            this.btnMenuVaraukset.Location = new System.Drawing.Point(125, 96);
            this.btnMenuVaraukset.Name = "btnMenuVaraukset";
            this.btnMenuVaraukset.Size = new System.Drawing.Size(179, 68);
            this.btnMenuVaraukset.TabIndex = 0;
            this.btnMenuVaraukset.Text = "Varaukset";
            this.btnMenuVaraukset.UseVisualStyleBackColor = true;
            this.btnMenuVaraukset.Click += new System.EventHandler(this.btnMenuVaraukset_Click);
            // 
            // btnMenuAs
            // 
            this.btnMenuAs.Location = new System.Drawing.Point(452, 96);
            this.btnMenuAs.Name = "btnMenuAs";
            this.btnMenuAs.Size = new System.Drawing.Size(179, 68);
            this.btnMenuAs.TabIndex = 1;
            this.btnMenuAs.Text = "Asiakkaat";
            this.btnMenuAs.UseVisualStyleBackColor = true;
            this.btnMenuAs.Click += new System.EventHandler(this.btnMenuAs_Click);
            // 
            // btnMenuAlueet
            // 
            this.btnMenuAlueet.Location = new System.Drawing.Point(125, 181);
            this.btnMenuAlueet.Name = "btnMenuAlueet";
            this.btnMenuAlueet.Size = new System.Drawing.Size(179, 68);
            this.btnMenuAlueet.TabIndex = 2;
            this.btnMenuAlueet.Text = "Toiminta-alueet";
            this.btnMenuAlueet.UseVisualStyleBackColor = true;
            this.btnMenuAlueet.Click += new System.EventHandler(this.btnMenuAlueet_Click);
            // 
            // btnMenuPalvelut
            // 
            this.btnMenuPalvelut.Location = new System.Drawing.Point(452, 181);
            this.btnMenuPalvelut.Name = "btnMenuPalvelut";
            this.btnMenuPalvelut.Size = new System.Drawing.Size(179, 68);
            this.btnMenuPalvelut.TabIndex = 3;
            this.btnMenuPalvelut.Text = "Palvelut";
            this.btnMenuPalvelut.UseVisualStyleBackColor = true;
            this.btnMenuPalvelut.Click += new System.EventHandler(this.btnMenuPalvelut_Click);
            // 
            // btnMenuLaskut
            // 
            this.btnMenuLaskut.Location = new System.Drawing.Point(125, 266);
            this.btnMenuLaskut.Name = "btnMenuLaskut";
            this.btnMenuLaskut.Size = new System.Drawing.Size(179, 67);
            this.btnMenuLaskut.TabIndex = 4;
            this.btnMenuLaskut.Text = "Laskut";
            this.btnMenuLaskut.UseVisualStyleBackColor = true;
            this.btnMenuLaskut.Click += new System.EventHandler(this.btnMenuLaskut_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuLaskut);
            this.Controls.Add(this.btnMenuPalvelut);
            this.Controls.Add(this.btnMenuAlueet);
            this.Controls.Add(this.btnMenuAs);
            this.Controls.Add(this.btnMenuVaraukset);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuVaraukset;
        private System.Windows.Forms.Button btnMenuAs;
        private System.Windows.Forms.Button btnMenuAlueet;
        private System.Windows.Forms.Button btnMenuPalvelut;
        private System.Windows.Forms.Button btnMenuLaskut;
    }
}