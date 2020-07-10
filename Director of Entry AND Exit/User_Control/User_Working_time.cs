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
    public partial class User_Working_time : UserControl
    {
        Business_Layer.Cls_Entry_AND_Exit EaE = new Business_Layer.Cls_Entry_AND_Exit();
        public User_Working_time()
        {
            InitializeComponent();

            this.DG_Work.DataSource = EaE.get_Working_time_Table();
            this.DG_Sections.DataSource = EaE.get_Sections_Table();

        }

        void cula()
        {
            if(From_M.Text != string.Empty && To_M.Text != string.Empty && From_H.Text != string.Empty && To_H.Text != string.Empty)
            {
                Double TOTALH = Math.Abs(Convert.ToDouble(From_H.Text) - Convert.ToDouble(To_H.Text));
                Double TOTALM = (Math.Abs(Convert.ToDouble(From_M.Text) - Convert.ToDouble(To_M.Text)))/60;

                total_hours.Text = Convert.ToString(TOTALH + TOTALM) ;
            }
        }

        void ClearBoxse()
        {
            Name_Working_time.Text = "";
            From_H.Text = "";
            From_M.Text = "";
            To_H.Text = "";
            To_M.Text = "";
            total_hours.Text = "";
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(From_M.Text != string.Empty && To_M.Text != string.Empty && From_H.Text != string.Empty &&
                To_H.Text != string.Empty && Name_Working_time.Text != string.Empty)
            {

                string From_total = From_H.Text + ":" + From_M.Text;
                string To_total = To_H.Text + ":" + To_M.Text;


                int mm = Convert.ToInt32(To_M.Text) - Convert.ToInt32(From_M.Text);
                int hh = Convert.ToInt32(To_H.Text) - Convert.ToInt32(From_H.Text);
                string totalDT = hh.ToString() + ":" + mm.ToString();

                DateTime From_total1 = Convert.ToDateTime(From_total);
                DateTime To_total1 = Convert.ToDateTime(To_total);


                DateTime totalDT1 = Convert.ToDateTime(totalDT);

                TextBox t1 = new TextBox();
                t1.Text = From_total1.ToString("hh:mm");

                TextBox t2 = new TextBox();
                t2.Text = To_total1.ToString("hh:mm");

                TextBox t3 = new TextBox();
                t3.Text = totalDT1.ToString("hh:mm:ss");

               // DateTime dt3 = Convert.ToDateTime(t3.Text);

                String Holidays = "";
                //if (checkBox1.Checked == true)
                //    Holidays += "Sunday ";

                //if (checkBox2.Checked == true)
                //    Holidays += "Monday ";

                //if (checkBox3.Checked == true)
                //    Holidays += "Tuesday ";

                //if (checkBox4.Checked == true)
                //    Holidays += "Wednesday ";

                //if (checkBox5.Checked == true)
                //    Holidays += "Thursday ";

                //if (checkBox6.Checked == true)
                //    Holidays += "Friday ";

                //if (checkBox7.Checked == true)
                //    Holidays += "Saturday ";

                
                EaE.Add_Working_time(Name_Working_time.Text, t1.Text, t2.Text, total_hours.Text, Convert.ToDateTime(t3.Text), Holidays);
                MessageBox.Show("تم الاضافه", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DG_Work.DataSource = EaE.get_Working_time_Table();
                ClearBoxse();
            }
            else
            {
                MessageBox.Show("الرجاء ادخل جميع البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void From_M_KeyUp(object sender, KeyEventArgs e)
        {
            cula();
        }

        private void From_H_KeyUp(object sender, KeyEventArgs e)
        {
            cula();
        }

        private void To_M_KeyUp(object sender, KeyEventArgs e)
        {
            cula();
        }

        private void To_H_KeyUp(object sender, KeyEventArgs e)
        {
            cula();
        }

        private void From_M_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void From_H_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void From_H_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void To_M_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void To_M_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void To_H_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //if(comboID_USER.Text != string.Empty && combo_Name_Working_time.Text != string.Empty)
            //{
            //    EaE.Add_distribution(comboID_USER.Text, combo_Name_Working_time.Text);
            //    MessageBox.Show("تم الاضافه", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("الرجاء ادخل جميع البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
        }

        private void Name_Working_time_Validated(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = EaE.verify_Name_Working_time(Name_Working_time.Text);

            if (Dt.Rows.Count > 0)
            {
                MessageBox.Show("اسم فترة الدوام موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Name_Working_time.Focus();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Form_Working_time_Editcs w = new Presentation_Layer.Form_Working_time_Editcs();
            w.dt = EaE.GET_Working_time_Table_ID(Convert.ToInt32(this.DG_Work.CurrentRow.Cells[0].Value.ToString()));
            w.ShowDialog();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            if(Name_Sections_tx.Text != string.Empty)
            {
                EaE.ADD_Sections_Table(Name_Sections_tx.Text);
                MessageBox.Show("تم الاضافه", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.DG_Sections.DataSource = EaE.get_Sections_Table();
        }
    }
}
