namespace Director_of_Entry_AND_Exit.Reporting.User_Salary
{
    partial class Form_S
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_S));
            this.R_get_Salary_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_S = new Director_of_Entry_AND_Exit.Reporting.User_Salary.DataSet_S();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboID_USER = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Date2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Date1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.R_get_Salary_TableTableAdapter = new Director_of_Entry_AND_Exit.Reporting.User_Salary.DataSet_STableAdapters.R_get_Salary_TableTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.R_get_Salary_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_S)).BeginInit();
            this.SuspendLayout();
            // 
            // R_get_Salary_TableBindingSource
            // 
            this.R_get_Salary_TableBindingSource.DataMember = "R_get_Salary_Table";
            this.R_get_Salary_TableBindingSource.DataSource = this.DataSet_S;
            // 
            // DataSet_S
            // 
            this.DataSet_S.DataSetName = "DataSet_S";
            this.DataSet_S.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.R_get_Salary_TableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Director_of_Entry_AND_Exit.Reporting.User_Salary.Report_S.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(763, 343);
            this.reportViewer1.TabIndex = 0;
            // 
            // comboID_USER
            // 
            this.comboID_USER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboID_USER.FormattingEnabled = true;
            this.comboID_USER.Location = new System.Drawing.Point(153, 42);
            this.comboID_USER.Name = "comboID_USER";
            this.comboID_USER.Size = new System.Drawing.Size(121, 21);
            this.comboID_USER.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم المناوب";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(667, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 30);
            this.button2.TabIndex = 108;
            this.button2.Text = "بحث";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Date2
            // 
            this.Date2.BackColor = System.Drawing.Color.SeaGreen;
            this.Date2.BorderRadius = 0;
            this.Date2.ForeColor = System.Drawing.Color.White;
            this.Date2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date2.FormatCustom = null;
            this.Date2.Location = new System.Drawing.Point(563, 42);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(76, 30);
            this.Date2.TabIndex = 107;
            this.Date2.Value = new System.DateTime(2018, 7, 21, 2, 58, 26, 102);
            // 
            // Date1
            // 
            this.Date1.BackColor = System.Drawing.Color.SeaGreen;
            this.Date1.BorderRadius = 0;
            this.Date1.ForeColor = System.Drawing.Color.White;
            this.Date1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date1.FormatCustom = null;
            this.Date1.Location = new System.Drawing.Point(447, 42);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(76, 30);
            this.Date1.TabIndex = 106;
            this.Date1.Value = new System.DateTime(2018, 7, 21, 2, 58, 26, 102);
            // 
            // R_get_Salary_TableTableAdapter
            // 
            this.R_get_Salary_TableTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(529, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 16);
            this.label11.TabIndex = 111;
            this.label11.Text = "الى";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(416, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 110;
            this.label8.Text = "من";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(149, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "ملاحظه : ادخل جميع البيانات";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form_S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Date2);
            this.Controls.Add(this.Date1);
            this.Controls.Add(this.comboID_USER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_S";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير رواتب";
            this.Load += new System.EventHandler(this.Form_S_Load);
            ((System.ComponentModel.ISupportInitialize)(this.R_get_Salary_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_S)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource R_get_Salary_TableBindingSource;
        private DataSet_S DataSet_S;
        private System.Windows.Forms.ComboBox comboID_USER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuDatepicker Date2;
        private Bunifu.Framework.UI.BunifuDatepicker Date1;
        private DataSet_STableAdapters.R_get_Salary_TableTableAdapter R_get_Salary_TableTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
    }
}