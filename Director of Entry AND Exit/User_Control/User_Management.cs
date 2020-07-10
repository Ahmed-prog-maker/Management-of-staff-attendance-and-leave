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
    public partial class User_Management : UserControl
    {
        Business_Layer.Cls_Entry_AND_Exit EaE = new Business_Layer.Cls_Entry_AND_Exit();
        public User_Management()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = EaE.Get_all_and_shawIt_USER();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Form_AddNewUser FRM = new Presentation_Layer.Form_AddNewUser();
            FRM.ShowDialog();
            this.dataGridView1.DataSource = EaE.Get_all_and_shawIt_USER();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = EaE.Search_USER(txtSearch.Text);
            this.dataGridView1.DataSource = Dt;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Form_AddNewUser FRM = new Presentation_Layer.Form_AddNewUser();
            FRM.ID_New_User.Enabled = false;
            FRM.ID_New_User.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FRM.PWD_New_User.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FRM.PPWD_New_User.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FRM.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FRM.Salary_USER.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            FRM.Hours_of_work_USER.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            FRM.Full_Name_USER.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            FRM.state = "update";
            FRM.SAVE_BUT.Text = "تعديل";
            FRM.label1.Text = "تعديل مستخدم ";
            FRM.Text = "تعديل مستخدم ";
            FRM.ShowDialog();
            this.dataGridView1.DataSource = EaE.Get_all_and_shawIt_USER();
        }

        private void ButtonDelet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف مستخدم المحدد", "عمليه حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                EaE.Delete_USER(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                MessageBox.Show("تم حذف المستخدم بنجاح", "عمليه حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = EaE.Get_all_and_shawIt_USER();
            }
            else
                MessageBox.Show("تم الغاء عمليه الحذف", "عمليه حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void User_Management_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UPdate_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = EaE.Get_all_and_shawIt_USER();
        }
    }
}
