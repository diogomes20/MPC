namespace Mpc.WinFormsIoC.Presentation.Countries
{
    partial class FrmCountryList
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
            this.dgvCountries = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Btn_new = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCountries
            // 
            this.dgvCountries.AllowUserToAddRows = false;
            this.dgvCountries.AllowUserToDeleteRows = false;
            this.dgvCountries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCountries.AutoGenerateColumns = false;
            this.dgvCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Alias});
            this.dgvCountries.DataSource = this.countryDtoBindingSource;
            this.dgvCountries.Location = new System.Drawing.Point(11, 11);
            this.dgvCountries.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCountries.Name = "dgvCountries";
            this.dgvCountries.ReadOnly = true;
            this.dgvCountries.RowTemplate.Height = 28;
            this.dgvCountries.Size = new System.Drawing.Size(783, 466);
            this.dgvCountries.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Alias
            // 
            this.Alias.DataPropertyName = "Alias";
            this.Alias.HeaderText = "Alias";
            this.Alias.Name = "Alias";
            this.Alias.ReadOnly = true;
            // 
            // countryDtoBindingSource
            // 
            this.countryDtoBindingSource.DataSource = typeof(Mpc.WinFormsIoC.Application.Dto.CountryDto);
            this.countryDtoBindingSource.CurrentChanged += new System.EventHandler(this.countryDtoBindingSource_CurrentChanged);
            // 
            // Btn_new
            // 
            this.Btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_new.Location = new System.Drawing.Point(12, 482);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.Size = new System.Drawing.Size(75, 23);
            this.Btn_new.TabIndex = 1;
            this.Btn_new.Text = "New";
            this.Btn_new.UseVisualStyleBackColor = true;
            this.Btn_new.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Edit.Location = new System.Drawing.Point(93, 482);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Edit.TabIndex = 2;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Delete.Location = new System.Drawing.Point(174, 482);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 3;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // FrmCountryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 511);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_new);
            this.Controls.Add(this.dgvCountries);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCountryList";
            this.Text = "FrmCountries";
            this.Load += new System.EventHandler(this.FrmCountryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCountries;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource countryDtoBindingSource;
        private System.Windows.Forms.Button Btn_new;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
        private System.Windows.Forms.Button Btn_Delete;
    }
}