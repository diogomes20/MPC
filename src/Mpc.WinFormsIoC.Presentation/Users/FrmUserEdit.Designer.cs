namespace Mpc.WinFormsIoC.Presentation.Users
{
    partial class FrmUserEdit
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
            this.LblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.countryDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countryDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(75, 13);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(16, 13);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "Id";
            this.LblId.Click += new System.EventHandler(this.LblId_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(97, 10);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(255, 20);
            this.TxtId.TabIndex = 1;
            this.TxtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(97, 36);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(255, 20);
            this.TxtUsername.TabIndex = 2;
            this.TxtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(97, 62);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(255, 20);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(97, 88);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(255, 20);
            this.TxtName.TabIndex = 4;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(97, 114);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(255, 20);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(36, 39);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(55, 13);
            this.LblUsername.TabIndex = 6;
            this.LblUsername.Text = "Username";
            this.LblUsername.Click += new System.EventHandler(this.LblUsername_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(38, 65);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 7;
            this.LblPassword.Text = "Password";
            this.LblPassword.Click += new System.EventHandler(this.LblPassword_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(56, 91);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 8;
            this.LblName.Text = "Name";
            this.LblName.Click += new System.EventHandler(this.LblName_Click);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(59, 117);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 9;
            this.LblEmail.Text = "Email";
            this.LblEmail.Click += new System.EventHandler(this.LblEmail_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(277, 180);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_ClickAsync);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.countryDtoBindingSource, "Id", true));
            this.comboBox1.DataSource = this.countryDtoBindingSource;
            this.comboBox1.DisplayMember = "Id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // countryDtoBindingSource
            // 
            this.countryDtoBindingSource.DataSource = typeof(Mpc.WinFormsIoC.Application.Dto.CountryDto);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "País";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(377, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUserEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmUserEdit";
            this.Load += new System.EventHandler(this.FrmUserEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource countryDtoBindingSource;
        private System.Windows.Forms.Label label1;
    }
}