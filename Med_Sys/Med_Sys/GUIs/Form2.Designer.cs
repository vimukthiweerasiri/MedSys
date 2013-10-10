namespace Med_Sys
{
    partial class Form2
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
            this.combopatientID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pharmacyPrescription = new System.Windows.Forms.DataGridView();
            this.issue = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyPrescription)).BeginInit();
            this.SuspendLayout();
            // 
            // combopatientID
            // 
            this.combopatientID.FormattingEnabled = true;
            this.combopatientID.Location = new System.Drawing.Point(541, 96);
            this.combopatientID.Name = "combopatientID";
            this.combopatientID.Size = new System.Drawing.Size(190, 21);
            this.combopatientID.TabIndex = 0;
            this.combopatientID.SelectedValueChanged += new System.EventHandler(this.check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(55, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Identity number";
            // 
            // pharmacyPrescription
            // 
            this.pharmacyPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pharmacyPrescription.Location = new System.Drawing.Point(3, 225);
            this.pharmacyPrescription.Name = "pharmacyPrescription";
            this.pharmacyPrescription.Size = new System.Drawing.Size(980, 337);
            this.pharmacyPrescription.TabIndex = 2;
            // 
            // issue
            // 
            this.issue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.issue.Location = new System.Drawing.Point(817, 596);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(155, 53);
            this.issue.TabIndex = 3;
            this.issue.Text = "issue";
            this.issue.UseVisualStyleBackColor = false;
            this.issue.Click += new System.EventHandler(this.issue_Click);
            // 
            // check
            // 
            this.check.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.check.Location = new System.Drawing.Point(767, 82);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(130, 46);
            this.check.TabIndex = 4;
            this.check.Text = "CHECK";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Med_Sys.Properties.Resources.fighter_plane_hd_high_quality_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.check);
            this.Controls.Add(this.issue);
            this.Controls.Add(this.pharmacyPrescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combopatientID);
            this.Name = "Form2";
            this.Text = "Pharmacist";
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyPrescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combopatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pharmacyPrescription;
        private System.Windows.Forms.Button issue;
        private System.Windows.Forms.Button check;
    }
}