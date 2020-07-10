using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Director_of_Entry_AND_Exit.Reporting.User_Salary
{
    public partial class Form_S : Form
    {
        Business_Layer.Cls_Entry_AND_Exit EaE = new Business_Layer.Cls_Entry_AND_Exit();
        DataSet_STableAdapters.R_get_Salary_TableTableAdapter Adapter = new DataSet_STableAdapters.R_get_Salary_TableTableAdapter();
        DataSet_S.R_get_Salary_TableDataTable Table = new DataSet_S.R_get_Salary_TableDataTable();
        public Form_S()
        {
            InitializeComponent();
            this.Date1.Value = DateTime.Now;
            this.Date2.Value = DateTime.Now;

            comboID_USER.DataSource = EaE.get_ID_USER11();
            comboID_USER.DisplayMember = "Full_Name_USER";
            comboID_USER.ValueMember = "Full_Name_USER";
        }

        private void Form_S_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_S.R_get_Salary_Table' table. You can move, or remove it, as needed.
            //this.R_get_Salary_TableTableAdapter.Fill(this.DataSet_S.R_get_Salary_Table);
                 
            //this.reportViewer1.RefreshReport();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Adapter.FillBy(Table, comboID_USER.Text);

            //ReportDataSource RDS = new ReportDataSource("DataSet1", (DataTable)Table);
            //this.reportViewer1.LocalReport.DataSources.Clear();

            //this.reportViewer1.LocalReport.DataSources.Add(RDS);

            //this.reportViewer1.LocalReport.Refresh();

            //this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d1 = Date1.Value.Date.ToString("yyyy-MM-dd");
            string d2 = Date2.Value.Date.ToString("yyyy-MM-dd");
           
            ReportParameter date1 = new ReportParameter("date1", d1);
            ReportParameter date2 = new ReportParameter("date2", d2);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {date1, date2});

            //Adapter.FillBy(Table, comboID_USER.Text);
            Adapter.FillBy1(Table, comboID_USER.Text, Convert.ToString(d1), Convert.ToString(d2));

            //ReportDataSource RDS = new ReportDataSource("DataSet1", (DataTable)Table);
            ReportDataSource RDS1 = new ReportDataSource("DataSet1", (DataTable)Table);

            this.reportViewer1.LocalReport.DataSources.Clear();

            //this.reportViewer1.LocalReport.DataSources.Add(RDS);
            this.reportViewer1.LocalReport.DataSources.Add(RDS1);

            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
