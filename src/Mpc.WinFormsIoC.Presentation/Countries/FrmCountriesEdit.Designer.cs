namespace Mpc.WinFormsIoC.Presentation.Countries
{
    partial class FrmCountriesEdit
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
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.Btn_save = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblAlias = new System.Windows.Forms.Label();
            this.TxtAlias = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(32, 41);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 10;
            this.LblName.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(73, 38);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(255, 20);
            this.TxtName.TabIndex = 9;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(51, 15);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(16, 13);
            this.LblId.TabIndex = 7;
            this.LblId.Text = "Id";
            // 
            // Btn_save
            // 
            this.Btn_save.Location = new System.Drawing.Point(253, 97);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(75, 23);
            this.Btn_save.TabIndex = 11;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = true;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(73, 15);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(255, 20);
            this.TxtId.TabIndex = 12;
            // 
            // LblAlias
            // 
            this.LblAlias.AutoSize = true;
            this.LblAlias.Location = new System.Drawing.Point(32, 67);
            this.LblAlias.Name = "LblAlias";
            this.LblAlias.Size = new System.Drawing.Size(29, 13);
            this.LblAlias.TabIndex = 14;
            this.LblAlias.Text = "Alias";
            // 
            // TxtAlias
            // 
            this.TxtAlias.Location = new System.Drawing.Point(73, 64);
            this.TxtAlias.Name = "TxtAlias";
            this.TxtAlias.Size = new System.Drawing.Size(255, 20);
            this.TxtAlias.TabIndex = 13;
            // 
            // FrmCountriesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(353, 132);
            this.Controls.Add(this.LblAlias);
            this.Controls.Add(this.TxtAlias);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblId);
            this.Name = "FrmCountriesEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCountriesEdit";
            this.Load += new System.EventHandler(this.FrmCountriesEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblAlias;
        private System.Windows.Forms.TextBox TxtAlias;
    }
}