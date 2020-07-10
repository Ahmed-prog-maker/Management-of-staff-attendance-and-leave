namespace Director_of_Entry_AND_Exit.Reporting.R_User_Table
{
    partial class Form_R_S_tabel
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_R_S_tabel));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboID_USER = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Date2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Date1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.R_S_Get_all_and_shawItBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Director_of_Entry_AND_Exit.Reporting.R_User_Table.DataSet1();
            this.R_S_Get_all_and_shawItTableAdapter = new Director_of_Entry_AND_Exit.Reporting.R_User_Table.DataSet1TableAdapters.R_S_Get_all_and_shawItTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.R_S_Get_all_and_shawItBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.R_S_Get_all_and_shawItBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Director_of_Entry_AND_Exit.Reporting.R_User_Table.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 108);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 315);
            this.reportViewer1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(522, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 16);
            this.label11.TabIndex = 126;
            this.label11.Text = "الى";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(409, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 125;
            this.label8.Text = "من";
            // 
            // comboID_USER
            // 
            this.comboID_USER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboID_USER.FormattingEnabled = true;
            this.comboID_USER.Location = new System.Drawing.Point(149, 36);
            this.comboID_USER.Name = "comboID_USER";
            this.comboID_USER.Size = new System.Drawing.Size(121, 21);
            this.comboID_USER.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "اسم المناوب";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 38);
            this.button2.TabIndex = 122;
            this.button2.Text = "بحث";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Date2
            // 
            this.Date2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Date2.BorderRadius = 0;
            this.Date2.ForeColor = System.Drawing.Color.White;
            this.Date2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date2.FormatCustom = null;
            this.Date2.Location = new System.Drawing.Point(556, 27);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(76, 38);
            this.Date2.TabIndex = 121;
            this.Date2.Value = new System.DateTime(2018, 7, 21, 2, 58, 26, 102);
            // 
            // Date1
            // 
            this.Date1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Date1.BorderRadius = 0;
            this.Date1.ForeColor = System.Drawing.Color.White;
            this.Date1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date1.FormatCustom = null;
            this.Date1.Location = new System.Drawing.Point(440, 27);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(76, 38);
            this.Date1.TabIndex = 120;
            this.Date1.Value = new System.DateTime(2018, 7, 21, 2, 58, 26, 102);
            // 
            // R_S_Get_all_and_shawItBindingSource
            // 
            this.R_S_Get_all_and_shawItBindingSource.DataMember = "R_S_Get_all_and_shawIt";
            this.R_S_Get_all_and_shawItBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // R_S_Get_all_and_shawItTableAdapter
            // 
            this.R_S_Get_all_and_shawItTableAdapter.ClearBeforeFill = true;
            // 
            // Form_R_S_tabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 435);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboID_USER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Date2);
            this.Controls.Add(this.Date1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_R_S_tabel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_R_S_tabel";
            this.Load += new System.EventHandler(this.Form_R_S_tabel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.R_S_Get_all_and_shawItBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource R_S_Get_all_and_shawItBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.R_S_Get_all_and_shawItTableAdapter R_S_Get_all_and_shawItTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboID_USER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuDatepicker Date2;
        private Bunifu.Framework.UI.BunifuDatepicker Date1;
    }
}