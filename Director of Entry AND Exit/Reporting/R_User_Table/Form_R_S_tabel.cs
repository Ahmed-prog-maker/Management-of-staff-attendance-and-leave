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

namespace Director_of_Entry_AND_Exit.Reporting.R_User_Table
{
    public partial class Form_R_S_tabel : Form
    {
        Business_Layer.Cls_Entry_AND_Exit EaE = new Business_Layer.Cls_Entry_AND_Exit();
        public Form_R_S_tabel()
        {
            InitializeComponent();

            comboID_USER.DataSource = EaE.get_ID_USER11();
            comboID_USER.DisplayMember = "Full_Name_USER";
            comboID_USER.ValueMember = "Full_Name_USER";
        }

        private void Form_R_S_tabel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.R_S_Get_all_and_shawIt' table. You can move, or remove it, as needed.
            this.R_S_Get_all_and_shawItTableAdapter.Fill(this.DataSet1.R_S_Get_all_and_shawIt);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.R_S_Get_all_and_shawItTableAdapter Adapter = new DataSet1TableAdapters.R_S_Get_all_and_shawItTableAdapter();
            DataSet1.R_S_Get_all_and_shawItDataTable Table = new DataSet1.R_S_Get_all_and_shawItDataTable();

            //string d1 = Date1.Value.Date.ToString("yyyy-MM-dd");
            //string d2 = Date2.Value.Date.ToString("yyyy-MM-dd");

            //ReportParameter date1 = new ReportParameter("date1", d1);
            //ReportParameter date2 = new ReportParameter("date2", d2);
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { date1, date2 });

            DateTime dt1 = Date1.Value.Date;
            DateTime dt2 = Date2.Value.Date;

            Adapter.FillBy(Table, comboID_USER.Text, dt1, dt2);

            ReportDataSource RDS = new ReportDataSource("DataSet1", (DataTable)Table);
            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(RDS);

            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
        }
    }
}
