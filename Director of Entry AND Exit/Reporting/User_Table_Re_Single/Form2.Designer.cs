namespace Director_of_Entry_AND_Exit.Reporting.User_Table_Re_Single
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.R_Single_Get_all_and_shawItBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new Director_of_Entry_AND_Exit.Reporting.User_Table_Re_Single.DataSet2();
            this.R_Single_Get_all_and_shawItTableAdapter = new Director_of_Entry_AND_Exit.Reporting.User_Table_Re_Single.DataSet2TableAdapters.R_Single_Get_all_and_shawItTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboID_USER = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.R_Single_Get_all_and_shawItBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.R_Single_Get_all_and_shawItBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Director_of_Entry_AND_Exit.Reporting.User_Table_Re_Single.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 74);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(728, 393);
            this.reportViewer1.TabIndex = 0;
            // 
            // R_Single_Get_all_and_shawItBindingSource
            // 
            this.R_Single_Get_all_and_shawItBindingSource.DataMember = "R_Single_Get_all_and_shawIt";
            this.R_Single_Get_all_and_shawItBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // R_Single_Get_all_and_shawItTableAdapter
            // 
            this.R_Single_Get_all_and_shawItTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المناوب";
            // 
            // comboID_USER
            // 
            this.comboID_USER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboID_USER.FormattingEnabled = true;
            this.comboID_USER.Location = new System.Drawing.Point(119, 19);
            this.comboID_USER.Name = "comboID_USER";
            this.comboID_USER.Size = new System.Drawing.Size(121, 21);
            this.comboID_USER.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboID_USER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.R_Single_Get_all_and_shawItBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource R_Single_Get_all_and_shawItBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.R_Single_Get_all_and_shawItTableAdapter R_Single_Get_all_and_shawItTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboID_USER;
        private System.Windows.Forms.Button button1;
    }
}