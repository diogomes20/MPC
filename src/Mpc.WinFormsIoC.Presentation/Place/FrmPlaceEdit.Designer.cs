namespace Mpc.WinFormsIoC.Presentation.Place
{
    partial class FrmPlaceEdit
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtWebsite = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblWebsite = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(82, 63);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(206, 20);
            this.TxtName.TabIndex = 0;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(82, 89);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(206, 20);
            this.TxtAddress.TabIndex = 1;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(82, 115);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(206, 20);
            this.TxtPhone.TabIndex = 2;
            // 
            // TxtWebsite
            // 
            this.TxtWebsite.Location = new System.Drawing.Point(82, 141);
            this.TxtWebsite.Name = "TxtWebsite";
            this.TxtWebsite.Size = new System.Drawing.Size(206, 20);
            this.TxtWebsite.TabIndex = 3;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(38, 66);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "Name:";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(28, 92);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(48, 13);
            this.LblAddress.TabIndex = 5;
            this.LblAddress.Text = "Address:";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(23, 118);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(53, 13);
            this.LblPhone.TabIndex = 6;
            this.LblPhone.Text = "Phone Nº";
            // 
            // LblWebsite
            // 
            this.LblWebsite.AutoSize = true;
            this.LblWebsite.Location = new System.Drawing.Point(27, 144);
            this.LblWebsite.Name = "LblWebsite";
            this.LblWebsite.Size = new System.Drawing.Size(49, 13);
            this.LblWebsite.TabIndex = 7;
            this.LblWebsite.Text = "Website:";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.Location = new System.Drawing.Point(12, 246);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.Location = new System.Drawing.Point(93, 246);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmPlaceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 281);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblWebsite);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtWebsite);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtName);
            this.Name = "FrmPlaceEdit";
            this.Text = "FrmPlaceEdit";
            this.Load += new System.EventHandler(this.FrmPlaceEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtWebsite;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblWebsite;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}