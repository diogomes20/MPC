namespace Mpc.WinFormsIoC.Presentation.Review
{
    partial class FrmReviewEdit
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
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.Place = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtComment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.radRating1 = new Telerik.WinControls.UI.RadRating();
            this.ratingStarVisualElement1 = new Telerik.WinControls.UI.RatingStarVisualElement();
            this.ratingStarVisualElement2 = new Telerik.WinControls.UI.RatingStarVisualElement();
            this.ratingStarVisualElement3 = new Telerik.WinControls.UI.RatingStarVisualElement();
            this.ratingStarVisualElement4 = new Telerik.WinControls.UI.RatingStarVisualElement();
            this.ratingStarVisualElement5 = new Telerik.WinControls.UI.RatingStarVisualElement();
            this.object_f7b8cd35_dbcf_4c8a_a48a_77850f020d2e = new Telerik.WinControls.RootRadElement();
            ((System.ComponentModel.ISupportInitialize)(this.radRating1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(68, 52);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(29, 20);
            this.TxtId.TabIndex = 0;
            // 
            // TxtName
            // 
            this.TxtName.Enabled = false;
            this.TxtName.Location = new System.Drawing.Point(68, 78);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(160, 20);
            this.TxtName.TabIndex = 1;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Enabled = false;
            this.TxtAddress.Location = new System.Drawing.Point(68, 104);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(160, 20);
            this.TxtAddress.TabIndex = 2;
            // 
            // Place
            // 
            this.Place.AutoSize = true;
            this.Place.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Place.Location = new System.Drawing.Point(11, 9);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(82, 31);
            this.Place.TabIndex = 3;
            this.Place.Text = "Place";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address:";
            // 
            // TxtComment
            // 
            this.TxtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtComment.Location = new System.Drawing.Point(12, 231);
            this.TxtComment.Multiline = true;
            this.TxtComment.Name = "TxtComment";
            this.TxtComment.Size = new System.Drawing.Size(352, 87);
            this.TxtComment.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Comment:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Classification:";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Save.Location = new System.Drawing.Point(16, 332);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 11;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // radRating1
            // 
            this.radRating1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.radRating1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.ratingStarVisualElement1,
            this.ratingStarVisualElement2,
            this.ratingStarVisualElement3,
            this.ratingStarVisualElement4,
            this.ratingStarVisualElement5});
            this.radRating1.Location = new System.Drawing.Point(81, 157);
            this.radRating1.Maximum = 5D;
            this.radRating1.Name = "radRating1";
            // 
            // 
            // 
            this.radRating1.RootElement.Opacity = 3D;
            this.radRating1.RootElement.ShadowDepth = 3;
            this.radRating1.SelectionMode = Telerik.WinControls.UI.RatingSelectionMode.FullItem;
            this.radRating1.Size = new System.Drawing.Size(134, 34);
            this.radRating1.TabIndex = 12;
            this.radRating1.ThemeName = "ControlDefault";
            // 
            // ratingStarVisualElement1
            // 
            this.ratingStarVisualElement1.Name = "ratingStarVisualElement1";
            // 
            // ratingStarVisualElement2
            // 
            this.ratingStarVisualElement2.Name = "ratingStarVisualElement2";
            // 
            // ratingStarVisualElement3
            // 
            this.ratingStarVisualElement3.Name = "ratingStarVisualElement3";
            // 
            // ratingStarVisualElement4
            // 
            this.ratingStarVisualElement4.Name = "ratingStarVisualElement4";
            // 
            // ratingStarVisualElement5
            // 
            this.ratingStarVisualElement5.Name = "ratingStarVisualElement5";
            // 
            // object_f7b8cd35_dbcf_4c8a_a48a_77850f020d2e
            // 
            this.object_f7b8cd35_dbcf_4c8a_a48a_77850f020d2e.Name = "object_f7b8cd35_dbcf_4c8a_a48a_77850f020d2e";
            this.object_f7b8cd35_dbcf_4c8a_a48a_77850f020d2e.Opacity = 3D;
            this.object_f7b8cd35_dbcf_4c8a_a48a_77850f020d2e.ShadowDepth = 3;
            this.object_f7b8cd35_dbcf_4c8a_a48a_77850f020d2e.StretchHorizontally = true;
            this.object_f7b8cd35_dbcf_4c8a_a48a_77850f020d2e.StretchVertically = true;
            // 
            // FrmReviewEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 367);
            this.Controls.Add(this.radRating1);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtId);
            this.Name = "FrmReviewEdit";
            this.Text = "FrmReviewEdit";
            this.Load += new System.EventHandler(this.FrmReviewEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRating1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label Place;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Save;
        private Telerik.WinControls.UI.RadRating radRating1;
        private Telerik.WinControls.UI.RatingStarVisualElement ratingStarVisualElement1;
        private Telerik.WinControls.UI.RatingStarVisualElement ratingStarVisualElement2;
        private Telerik.WinControls.UI.RatingStarVisualElement ratingStarVisualElement3;
        private Telerik.WinControls.UI.RatingStarVisualElement ratingStarVisualElement4;
        private Telerik.WinControls.UI.RatingStarVisualElement ratingStarVisualElement5;
        private Telerik.WinControls.RootRadElement object_f7b8cd35_dbcf_4c8a_a48a_77850f020d2e;
    }
}