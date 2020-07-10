using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Director_of_Entry_AND_Exit.Reporting.User_Table_Re_Single
{
    public partial class Form2 : Form
    {
        Business_Layer.Cls_Entry_AND_Exit EaE = new Business_Layer.Cls_Entry_AND_Exit();
        User_Control.User_Table us = new User_Control.User_Table();
        public Form2()
        {
            InitializeComponent();
            comboID_USER.DataSource = EaE.get_ID_USER();
            comboID_USER.DisplayMember = "Full_Name_USER";
            comboID_USER.ValueMember = "Full_Name_USER";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // string id = us.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            // TODO: This line of code loads data into the 'DataSet2.R_Single_Get_all_and_shawIt' table. You can move, or remove it, as needed.
            //this.R_Single_Get_all_and_shawItTableAdapter.Fill(this.DataSet2.R_Single_Get_all_and_shawIt);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
