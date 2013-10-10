namespace Med_Sys.GUIs
{
    partial class StoreKeeper
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
            this.medname = new System.Windows.Forms.ComboBox();
            this.form = new System.Windows.Forms.ComboBox();
            this.dose = new System.Windows.Forms.ComboBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.datagridGRN = new System.Windows.Forms.DataGridView();
            this.stckidcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedIdcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mednamecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtycol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expdatecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonselect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridGRN)).BeginInit();
            this.SuspendLayout();
            // 
            // medname
            // 
            this.medname.FormattingEnabled = true;
            this.medname.Location = new System.Drawing.Point(23, 68);
            this.medname.Name = "medname";
            this.medname.Size = new System.Drawing.Size(121, 21);
            this.medname.TabIndex = 0;
            // 
            // form
            // 
            this.form.FormattingEnabled = true;
            this.form.Location = new System.Drawing.Point(169, 68);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(121, 21);
            this.form.TabIndex = 0;
            // 
            // dose
            // 
            this.dose.FormattingEnabled = true;
            this.dose.Location = new System.Drawing.Point(313, 68);
            this.dose.Name = "dose";
            this.dose.Size = new System.Drawing.Size(121, 21);
            this.dose.TabIndex = 0;
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(467, 68);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(110, 20);
            this.qty.TabIndex = 1;
            // 
            // datepicker
            // 
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker.Location = new System.Drawing.Point(606, 68);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(150, 20);
            this.datepicker.TabIndex = 2;
            // 
            // datagridGRN
            // 
            this.datagridGRN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridGRN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stckidcol,
            this.MedIdcol,
            this.mednamecol,
            this.formcol,
            this.dosecol,
            this.qtycol,
            this.Expdatecol});
            this.datagridGRN.Location = new System.Drawing.Point(23, 173);
            this.datagridGRN.Name = "datagridGRN";
            this.datagridGRN.Size = new System.Drawing.Size(750, 150);
            this.datagridGRN.TabIndex = 3;
            // 
            // stckidcol
            // 
            this.stckidcol.HeaderText = "Stock ID";
            this.stckidcol.Name = "stckidcol";
            this.stckidcol.ReadOnly = true;
            // 
            // MedIdcol
            // 
            this.MedIdcol.HeaderText = "Medicine ID";
            this.MedIdcol.Name = "MedIdcol";
            this.MedIdcol.ReadOnly = true;
            // 
            // mednamecol
            // 
            this.mednamecol.HeaderText = "Medicine Name";
            this.mednamecol.Name = "mednamecol";
            this.mednamecol.ReadOnly = true;
            // 
            // formcol
            // 
            this.formcol.HeaderText = "Form";
            this.formcol.Name = "formcol";
            this.formcol.ReadOnly = true;
            // 
            // dosecol
            // 
            this.dosecol.HeaderText = "Dose";
            this.dosecol.Name = "dosecol";
            this.dosecol.ReadOnly = true;
            // 
            // qtycol
            // 
            this.qtycol.HeaderText = "Quantity";
            this.qtycol.Name = "qtycol";
            this.qtycol.ReadOnly = true;
            // 
            // Expdatecol
            // 
            this.Expdatecol.HeaderText = "Expiry Date";
            this.Expdatecol.Name = "Expdatecol";
            this.Expdatecol.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Medicine Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dose";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Expiry Date";
            // 
            // buttonselect
            // 
            this.buttonselect.Location = new System.Drawing.Point(680, 127);
            this.buttonselect.Name = "buttonselect";
            this.buttonselect.Size = new System.Drawing.Size(75, 23);
            this.buttonselect.TabIndex = 5;
            this.buttonselect.Text = "Select";
            this.buttonselect.UseVisualStyleBackColor = true;
            this.buttonselect.Click += new System.EventHandler(this.buttonselect_Click);
            // 
            // StoreKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 562);
            this.Controls.Add(this.buttonselect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridGRN);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.dose);
            this.Controls.Add(this.form);
            this.Controls.Add(this.medname);
            this.Name = "StoreKeeper";
            this.Text = "StoreKeeper";
            ((System.ComponentModel.ISupportInitialize)(this.datagridGRN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox medname;
        private System.Windows.Forms.ComboBox form;
        private System.Windows.Forms.ComboBox dose;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.DataGridView datagridGRN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn stckidcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedIdcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn mednamecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn formcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtycol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expdatecol;
        private System.Windows.Forms.Button buttonselect;
    }
}