using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Director_of_Entry_AND_Exit.Presentation_Layer
{
    public partial class Form2 : Form
    {
        Business_Layer.Cls_Entry_AND_Exit CEE = new Business_Layer.Cls_Entry_AND_Exit();
        Form_User_list frm = new Form_User_list();
        

            void ClearBoxse()
        {
             ID_user.Clear();
             Full_name_user.Clear();
             date.Clear();
             Salary.Clear();
             Bonus.Clear();
             Discaunt.Clear();
             text.Clear();

        }

        DataTable Dt = new DataTable();
        void CreateDataTable()
        {
            Dt.Columns.Add("اسم المستخدم");
            Dt.Columns.Add("اسم الكامل");
            Dt.Columns.Add("تاريخ");
            Dt.Columns.Add("الراتب الاساسي");
            Dt.Columns.Add("مكافأه");
            Dt.Columns.Add("خصم");
            Dt.Columns.Add("ملاحظات");
            Dt.Columns.Add("جمالي الراتب بعد مكافأه / خصم");
            DGV.DataSource = Dt;
        }


        //void reSize_DGV()
        //{
        //    this.bunifuCustomDataGrid1.RowHeadersWidth = 89;
        //    this.bunifuCustomDataGrid1.Columns[0].Width = 113;
        //    this.bunifuCustomDataGrid1.Columns[1].Width = 160;
        //    this.bunifuCustomDataGrid1.Columns[2].Width = 91;
        //    this.bunifuCustomDataGrid1.Columns[3].Width = 91;
        //    this.bunifuCustomDataGrid1.Columns[4].Width = 91;
        //    this.bunifuCustomDataGrid1.Columns[5].Width = 102;
        //}
        public Form2()
        {
            InitializeComponent();
            //CreateDataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frm.ShowDialog();

            this.DGV.DataSource = CEE.get_Salary_Table(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            
            
            ID_user.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Full_name_user.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Salary.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            date.Text = Convert.ToString(DateTime.Now.Date);

            Bonus_total.Text = Convert.ToString((CEE.Sum_Bonus_Salary(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0]);
            Discaunt_totel.Text = Convert.ToString((CEE.Sum_Discaunt_Salary(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0]);
            TOTAL_ALL.Text = Convert.ToString((Convert.ToInt32(Salary.Text) + Convert.ToInt32(Bonus_total.Text)) - Convert.ToInt32(Discaunt_totel.Text));

            //date.Text = DateTime.Now.ToString("d/M/yyyy");
            //DateTime S = Convert.ToDateTime(date.Text);

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void Discaunt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void Bonus_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                text.Focus();
            }
        }

        private void Discaunt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text.Focus();
            }
        }

        //private void Bonus_KeyUp(object sender, KeyEventArgs e)
        //{
        //    CalculatBonus();
        //}

        //private void Discaunt_KeyUp(object sender, KeyEventArgs e)
        //{
        //    CalculatDiscaunt();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //DataRow Dr = Dt.NewRow();
            //Dr[0] = ID_user.Text;
            //Dr[1] = Full_name_user.Text;
            //Dr[2] = date.Text;
            //Dr[3] = Salary.Text;
            //Dr[4] = Bonus.Text;
            //Dr[5] = Discaunt.Text;
            //Dr[6] = text.Text;
            //Dr[7] = TOOTAL.Text;


            //Dt.Rows.Add(Dr);
            //DGV.DataSource = Dt;
            //DateTime S = Convert.ToDateTime(date.Text);
           // CEE.add_Bonus_and_Discaunt_salary(ID_user.Text, Full_name_user.Text, Convert.ToDateTime(date.Text), Convert.ToInt32(Salary.Text),
                                            //  Convert.ToInt32(Bonus.Text), Convert.ToInt32(Discaunt.Text), text.Text);

            Bonus_total.Text = Convert.ToString((CEE.Sum_Bonus_Salary(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0]);
            Discaunt_totel.Text = Convert.ToString((CEE.Sum_Discaunt_Salary(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0]);
            TOTAL_ALL.Text = Convert.ToString((Convert.ToInt32(Salary.Text) + Convert.ToInt32(Bonus_total.Text)) - Convert.ToInt32(Discaunt_totel.Text));

            this.DGV.DataSource = CEE.get_Salary_Table(ID_user.Text);
            ClearBoxse();
            
        }

        private void Full_name_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
