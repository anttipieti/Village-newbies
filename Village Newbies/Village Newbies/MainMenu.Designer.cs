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
            this.SuspendLayout();
            // 
            // btnMenuVaraukset
            // 
            this.btnMenuVaraukset.Location = new System.Drawing.Point(125, 96);
            this.btnMenuVaraukset.Name = "btnMenuVaraukset";
            this.btnMenuVaraukset.Size = new System.Drawing.Size(211, 93);
            this.btnMenuVaraukset.TabIndex = 0;
            this.btnMenuVaraukset.Text = "Varaukset";
            this.btnMenuVaraukset.UseVisualStyleBackColor = true;
            this.btnMenuVaraukset.Click += new System.EventHandler(this.btnMenuVaraukset_Click);
            // 
            // btnMenuAs
            // 
            this.btnMenuAs.Location = new System.Drawing.Point(452, 96);
            this.btnMenuAs.Name = "btnMenuAs";
            this.btnMenuAs.Size = new System.Drawing.Size(211, 93);
            this.btnMenuAs.TabIndex = 1;
            this.btnMenuAs.Text = "Asiakkaat";
            this.btnMenuAs.UseVisualStyleBackColor = true;
            this.btnMenuAs.Click += new System.EventHandler(this.btnMenuAs_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}