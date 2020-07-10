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
    public partial class User_Salary : UserControl
    {
        Business_Layer.Cls_Entry_AND_Exit CEE = new Business_Layer.Cls_Entry_AND_Exit();
        Presentation_Layer.Form_User_list frm = new Presentation_Layer.Form_User_list();
        public string state = "add";

        void ClearBoxse()
        {
            //ID_user.Clear();
            Full_name_user.Clear();
            date.Clear();
            Salary.Clear();
            Bonus.Clear();
            Discaunt.Clear();
            text.Clear();
        }

        void reSize_DGV()
        {
            
            this.DGV.Columns[0].Visible = false;
            this.DGV.Columns[1].Width = 50;
            this.DGV.Columns[2].Width = 50;
            this.DGV.Columns[3].Width = 50;
            this.DGV.Columns[4].Width = 50;
            this.DGV.Columns[5].Width = 300;
            //this.DGV.Columns[3].Width = 75;
            //this.DGV.Columns[4].Width = 60;
            //this.DGV.Columns[5].Width = 51;
            //this.DGV.Columns[6].Width = 51;
            //this.DGV.Columns[7].Width = 175;
        }

        void CalculatB_D_S()
        {
            if (Bonus.Text == string.Empty)
                Bonus.Text = "0";

            if (Discaunt.Text == string.Empty)
                Discaunt.Text = "0";

            if (Salary.Text == string.Empty)
                Salary.Text = "0";

            if (Bonus_total.Text == string.Empty)
                Bonus_total.Text = "0";

            if (Discaunt_totel.Text == string.Empty)
                Discaunt_totel.Text = "0";

        }
        void CalculatBonus()
        {
            if (Bonus.Text == string.Empty)
                Bonus.Text = "0";
        }
        void CalculatDiscaunt()
        {
            if (Discaunt.Text == string.Empty)
                Discaunt.Text = "0";
        }
        
        void Enabled()
        {
            if (frm.StatsTXT.Text == "مكافأه" )
            {
                Bonus.Enabled = true;
                Discaunt.Enabled = false;
            }

             if  (frm.StatsTXT.Text == "خصم")
            {
                Bonus.Enabled = false;
                Discaunt.Enabled = true;
            }

             if (frm.StatsTXT.Text == "تنبيه")
            {
                Bonus.Enabled = false;
                Discaunt.Enabled = false;
            }

             if (frm.StatsTXT.Text == "غياب")
            {
                Bonus.Enabled = false;
                Discaunt.Enabled = true;
            }

             if (frm.StatsTXT.Text == "تأخير")
            {
                Bonus.Enabled = false;
                Discaunt.Enabled = true;
            }

            if (frm.StatsTXT.Text == "آخرى")
            {
                Bonus.Enabled = true;
                Discaunt.Enabled = true;
            }
        }

        void Enabled1()
        {
            if (ID_user.Text == "مكافأه" )
            {
                Bonus.Enabled = true;
                Discaunt.Enabled = false;
            }

            if (ID_user.Text == "خصم")
            {
                Bonus.Enabled = false;
                Discaunt.Enabled = true;
            }

            if (ID_user.Text == "غياب")
            {
                Bonus.Enabled = false;
                Discaunt.Enabled = true;
            }

            if (ID_user.Text == "تنبيه")
            {
                Bonus.Enabled = false;
                Discaunt.Enabled = false;
            }

            if (frm.StatsTXT.Text == "تأخير")
            {
                Bonus.Enabled = false;
                Discaunt.Enabled = true;
            }
        }
        public User_Salary()
        {
            InitializeComponent();
            id_sa.Visible = false;
            this.Date1.Value = DateTime.Now;
            this.Date2.Value = DateTime.Now;
            
            Bonus.Text = "0";
            Discaunt.Text = "0";
            Salary.Text = "0";
        }

        private void User_Salary_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Form_User_list frm = new Presentation_Layer.Form_User_list();
            frm.ShowDialog();
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            state = "add";
            ClearBoxse();
            frm.ShowDialog();
            Enabled();

            this.DGV.DataSource = CEE.get_Salary_Table(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            reSize_DGV();

            string minutes = Convert.ToString((CEE.Sum_Date_EntryAndDate(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0]);
            if (minutes == string.Empty)
            {
                lateTXT.Text = "00:00";
            }
            else
            {
                TimeSpan span = TimeSpan.FromMinutes(Convert.ToInt32(minutes));
                lateTXT.Text = span.ToString(@"hh\:mm");
                reSize_DGV();
            }

            string salaryOfm = Convert.ToString((CEE.get_SalaryOfM(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0]);
            if (salaryOfm == string.Empty)
            {
                lateSalary.Text = " ";
            }
            else
            {
                double salaryOfmm = Convert.ToDouble(salaryOfm);
                DateTime lateTime = Convert.ToDateTime(lateTXT.Text);
                string s = DateTime.Now.ToString("0:1");
                DateTime aa = Convert.ToDateTime(s);

                double tot = 0;

                while (DateTime.Compare(aa, lateTime) <= 0)
                {
                    tot = tot + salaryOfmm;
                    aa = aa.AddMinutes(1);
                }
                int tt = (int)tot;
                lateSalary.Text = tt.ToString();
            }

            ID_user.Text = frm.StatsTXT.Text;
            Full_name_user.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Salary.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            date.Text = Convert.ToString(DateTime.Now.Date);

            if (Salary.Text == string.Empty)
                Salary.Text = "0";
            

            Bonus_total.Text = Convert.ToString((CEE.Sum_Bonus_Salary(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0]);
            Discaunt_totel.Text = Convert.ToString((CEE.Sum_Discaunt_Salary(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0]);
            CalculatB_D_S();
            TOTAL_ALL.Text = Convert.ToString((Convert.ToInt32(Salary.Text) + Convert.ToInt32(Bonus_total.Text)) - Convert.ToInt32(Discaunt_totel.Text));

            //date.Text = DateTime.Now.ToString("d/M/yyyy");
            //DateTime S = Convert.ToDateTime(date.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculatB_D_S();
            
            if(ID_user.Text == string.Empty || Full_name_user.Text == string.Empty || date.Text == string.Empty ||
                  text.Text == string.Empty)
            {
                MessageBox.Show("الرجاء ادخل جميع البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (state == "add")
            {
                CEE.add_Bonus_and_Discaunt_salary(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString(), Full_name_user.Text, Convert.ToDateTime(date.Text), Convert.ToInt32(Salary.Text),
                                              Convert.ToInt32(Bonus.Text), Convert.ToInt32(Discaunt.Text), text.Text, ID_user.Text);
                MessageBox.Show("تم الحفظ بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (state == "update")
            {
                CEE.EDIT_Salary_Table(Convert.ToInt32(id_sa.Text), Convert.ToInt32(Bonus.Text), Convert.ToInt32(Discaunt.Text), text.Text);
                MessageBox.Show("تم التعديل بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

            Bonus_total.Text = Convert.ToString((CEE.Sum_Bonus_Salary(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0]);
            Discaunt_totel.Text = Convert.ToString((CEE.Sum_Discaunt_Salary(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0]);
            CalculatB_D_S();
            TOTAL_ALL.Text = Convert.ToString((Convert.ToInt32(Salary.Text) + Convert.ToInt32(Bonus_total.Text)) - Convert.ToInt32(Discaunt_totel.Text));

            this.DGV.DataSource = CEE.get_Salary_Table(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ClearBoxse();
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
            if (e.KeyCode == Keys.Enter)
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

        private void Bonus_KeyUp(object sender, KeyEventArgs e)
        {
            CalculatBonus();
        }

        private void Discaunt_KeyUp(object sender, KeyEventArgs e)
        {
            CalculatDiscaunt();
        }

        //private void DGV_DoubleClick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        state = "update";
        //        ID_user.Text = this.DGV.CurrentRow.Cells[1].Value.ToString();
        //        Full_name_user.Text = this.DGV.CurrentRow.Cells[2].Value.ToString();
        //        date.Text = this.DGV.CurrentRow.Cells[3].Value.ToString();
        //        Salary.Text = this.DGV.CurrentRow.Cells[4].Value.ToString();
        //        Bonus.Text = this.DGV.CurrentRow.Cells[5].Value.ToString();
        //        Discaunt.Text = this.DGV.CurrentRow.Cells[6].Value.ToString();
        //        text.Text = this.DGV.CurrentRow.Cells[7].Value.ToString();
        //        DGV.Rows.RemoveAt(DGV.CurrentRow.Index);
        //    }
        //    catch
        //    {
        //        return;
        //    }
            
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            if ( Full_name_user.Text == string.Empty || date.Text == string.Empty )   
            {
                MessageBox.Show("الرجاء ادخل اسم المناوب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("هل تريد فعلا حذف المحدد", "عمليه حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
               
               CEE.delete_Salary(Convert.ToInt32(this.DGV.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تم حذف بنجاح", "عمليه حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DGV.DataSource = CEE.get_Salary_Table(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                reSize_DGV();

                Bonus_total.Text = Convert.ToString((CEE.Sum_Bonus_Salary(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0]);
                Discaunt_totel.Text = Convert.ToString((CEE.Sum_Discaunt_Salary(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0]);
                CalculatB_D_S();
                TOTAL_ALL.Text = Convert.ToString((Convert.ToInt32(Salary.Text) + Convert.ToInt32(Bonus_total.Text)) - Convert.ToInt32(Discaunt_totel.Text));

            }
            else
                MessageBox.Show("تم الغاء عمليه الحذف", "عمليه حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Edit_B_Click(object sender, EventArgs e)
        {
            try
            {
                state = "update";
                id_sa.Text = this.DGV.CurrentRow.Cells[0].Value.ToString();
                Full_name_user.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                date.Text = this.DGV.CurrentRow.Cells[1].Value.ToString();
                Salary.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                ID_user.Text = this.DGV.CurrentRow.Cells[2].Value.ToString();
                Bonus.Text = this.DGV.CurrentRow.Cells[3].Value.ToString();
                Discaunt.Text = this.DGV.CurrentRow.Cells[4].Value.ToString();
                text.Text = this.DGV.CurrentRow.Cells[5].Value.ToString();
                Enabled1();
                DGV.Rows.RemoveAt(DGV.CurrentRow.Index);
            }
            catch
            {
                return;
            }
            Enabled1();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if ( Full_name_user.Text == string.Empty )
            {
                MessageBox.Show("الرجاء اختر اسم المناوب اولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime dt1 = Date1.Value.Date;
            DateTime dt2 = Date2.Value.Date;

            string d1 = Date1.Value.Date.ToString("yyyy-MM-dd");
            string d2 = Date2.Value.Date.ToString("yyyy-MM-dd");

            string minutes = Convert.ToString((CEE.Sum_Date_EntryAndDate_between_date(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString(), d1, d2)).Rows[0][0]);
            if (minutes == string.Empty)
            {
                lateTXT.Text = "00:00";
            }
            else
            {
                TimeSpan span = TimeSpan.FromMinutes(Convert.ToInt32(minutes));
                lateTXT.Text = span.ToString(@"hh\:mm");
                reSize_DGV();
            }

            string salaryOfm = Convert.ToString((CEE.get_SalaryOfM(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0]);
            if (salaryOfm == string.Empty)
            {
                lateSalary.Text = " ";
            }
            else
            {
                double salaryOfmm = Convert.ToDouble(salaryOfm);
                DateTime lateTime = Convert.ToDateTime(lateTXT.Text);
                string s = DateTime.Now.ToString("0:1");
                DateTime aa = Convert.ToDateTime(s);

                double tot = 0;

                while (DateTime.Compare(aa, lateTime) <= 0)
                {
                    tot = tot + salaryOfmm;
                    aa = aa.AddMinutes(1);
                }
                int tt = (int)tot;
                lateSalary.Text = tt.ToString();
            }

            DataTable Dt = new DataTable();
            Dt = CEE.Search_Salary(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString(), dt1, dt2);
            this.DGV.DataSource = Dt;
            reSize_DGV();

            
            Bonus_total.Text = Convert.ToString((CEE.Sum_Bonus_Salary_Between_two_dates(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString(), dt1, dt2)).Rows[0][0]);
            Discaunt_totel.Text = Convert.ToString((CEE.Sum_Discaunt_Salary_Between_two_dates(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString(), dt1, dt2)).Rows[0][0]);
            CalculatB_D_S();
            TOTAL_ALL.Text = Convert.ToString((Convert.ToInt32(Salary.Text) + Convert.ToInt32(Bonus_total.Text)) - Convert.ToInt32(Discaunt_totel.Text));
        }

        private void Stxt_TextChanged(object sender, EventArgs e)
        {
            if ( Full_name_user.Text == string.Empty)
            {
                MessageBox.Show("الرجاء اختر اسم المستخدم اولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Stxt.Clear();
                return;
            }

            DataTable Dt = new DataTable();
            Dt = CEE.Search_Salary_Text(frm.dataGridView1.CurrentRow.Cells[0].Value.ToString(), Stxt.Text);
            this.DGV.DataSource = Dt;
            reSize_DGV();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Bonus_total_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reporting.User_Salary.Form_S s = new Reporting.User_Salary.Form_S();
            s.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Bonus.Enabled = false;
            Discaunt.Enabled = true;

            Discaunt.Text = lateSalary.Text;
            ID_user.Text = "تاخير";
            text.Focus();
        }

        private void Bonus_total_OnValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
