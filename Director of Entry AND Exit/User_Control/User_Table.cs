using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Director_of_Entry_AND_Exit.User_Control
{
    public partial class User_Table : UserControl
    {
        
        Business_Layer.Cls_Entry_AND_Exit EaE = new Business_Layer.Cls_Entry_AND_Exit();
        public User_Table()
        {
            InitializeComponent();
            this.dataGridView1.DataSource =   EaE.Get_all_and_shawIt();
            this.dataGridView1.Columns[0].Visible = false;

            //DataGridViewCheckBoxColumn e1 = new DataGridViewCheckBoxColumn();
            //e1.HeaderText = "قبول العذر حضور";
            //dataGridView1.Columns.Add(e1);

            //DataGridViewCheckBoxColumn e2 = new DataGridViewCheckBoxColumn();
            //e2.HeaderText = "قبول العذر انصراف";
            //dataGridView1.Columns.Add(e2);

            comboID_USER.DataSource = EaE.get_ID_USER11();
            comboID_USER.DisplayMember = "Full_Name_USER";
            comboID_USER.ValueMember = "Full_Name_USER";

            this.Date1.Value = DateTime.Now;
            this.Date2.Value = DateTime.Now;

            ButtonAdd.Visible = false;
            //this.dataGridView1.Columns[3].Visible = false;
            //this.dataGridView1.Columns[6].Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = EaE.Search(txtSearch.Text);
            this.dataGridView1.DataSource = Dt;
        }
        
        private void ButtonDelet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف المحدد", "عمليه حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                EaE.Delete(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم حذف بنجاح", "عمليه حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = EaE.Get_all_and_shawIt();
            }
            else
                MessageBox.Show("تم الغاء عمليه الحذف", "عمليه حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Form_add frm = new Presentation_Layer.Form_add();
            frm.ShowDialog();
            this.dataGridView1.DataSource = EaE.Get_all_and_shawIt();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //Reporting.User_Table_Re.Form1 frm1 = new Reporting.User_Table_Re.Form1();
            //frm1.ShowDialog();

            Reporting.R_User_Table.Form_R_S_tabel r = new Reporting.R_User_Table.Form_R_S_tabel();
            r.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void User_Table_Load(object sender, EventArgs e)
        {

        }

        private void UPdate_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = EaE.Get_all_and_shawIt(); 
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Form_excuse fe = new Presentation_Layer.Form_excuse();
            fe.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //DataTable Dt = new DataTable();
            //Dt = EaE.Search(txtSearch.Text);
            this.dataGridView1.DataSource = EaE.Search(txtSearch.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DateTime dt1 = Date1.Value.Date;
            DateTime dt2 = Date2.Value.Date;

            DataTable Dt = new DataTable();
            Dt = EaE.Search_Table(comboID_USER.Text, dt1, dt2);
            this.dataGridView1.DataSource = Dt;
        }
    }
}
