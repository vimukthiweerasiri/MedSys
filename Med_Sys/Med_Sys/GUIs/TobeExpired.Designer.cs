namespace Med_Sys.GUIs
{
    partial class TobeExpired
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
            this.dataGridtobeexpired = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtobeexpired)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridtobeexpired
            // 
            this.dataGridtobeexpired.AllowUserToAddRows = false;
            this.dataGridtobeexpired.AllowUserToDeleteRows = false;
            this.dataGridtobeexpired.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridtobeexpired.Location = new System.Drawing.Point(66, 54);
            this.dataGridtobeexpired.Name = "dataGridtobeexpired";
            this.dataGridtobeexpired.ReadOnly = true;
            this.dataGridtobeexpired.Size = new System.Drawing.Size(635, 377);
            this.dataGridtobeexpired.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To Be Expired Within A Month";
            // 
            // TobeExpired
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridtobeexpired);
            this.Name = "TobeExpired";
            this.Text = "TobeExpired";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtobeexpired)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridtobeexpired;
        private System.Windows.Forms.Label label1;
    }
}