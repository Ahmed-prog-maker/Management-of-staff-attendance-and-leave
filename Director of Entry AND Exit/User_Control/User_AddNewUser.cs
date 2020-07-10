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
    public partial class User_AddNewUser : UserControl
    {
        Business_Layer.Cls_login cl = new Business_Layer.Cls_login();
        Business_Layer.Cls_Entry_AND_Exit CEE = new Business_Layer.Cls_Entry_AND_Exit();
        public User_AddNewUser()
        {
            InitializeComponent();

            //User_AddNewUser s = new User_AddNewUser();
            //s.combo_Working_time.Refresh();

            //combo_Working_time.Refresh();
            //combo_Sections.Refresh();

            combo_Sections.DataSource = CEE.gget_Sections_Table();
            combo_Sections.DisplayMember = "Name_Sections";
            combo_Sections.ValueMember = "ID_Sections";

            combo_Working_time.DataSource = CEE.gget_Working_time_Table();
            combo_Working_time.DisplayMember = "Name_Working_time";
            combo_Working_time.ValueMember = "ID_Working_time";

            ID_New_User.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void User_AddNewUser_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (ID_New_User.Text == string.Empty || PWD_New_User.Text == string.Empty || PPWD_New_User.Text == string.Empty || comboBox1.Text == string.Empty
                || Salary_USER.Text == string.Empty || Hours_of_work_USER.Text == string.Empty || Full_Name_USER.Text == string.Empty )
            {
                MessageBox.Show("رجاء ادخل جميع البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PWD_New_User.Text != PPWD_New_User.Text)
            {
                MessageBox.Show("الرقم السري غير متطابقة !", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable Dt = new DataTable();
            Dt = CEE.verify_User_Id(ID_New_User.Text);

            if (Dt.Rows.Count > 0)
            {
                MessageBox.Show("اسم المستخدم موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ID_New_User.Focus();
                return;
            }
            cl.ADD_NEW_USER(ID_New_User.Text, PWD_New_User.Text, comboBox1.Text, int.Parse(Salary_USER.Text),
                float.Parse(Hours_of_work_USER.Text), Full_Name_USER.Text, Convert.ToInt32(combo_Working_time.SelectedValue), Convert.ToInt32(combo_Sections.SelectedValue));
            MessageBox.Show("تم اضافه مستخدم جديد بنجاح", "اضافه مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ID_New_User.Text = "";
            PWD_New_User.Text = "";
            PPWD_New_User.Text = "";
            Salary_USER.Text = "";
            Hours_of_work_USER.Text = "";
            Full_Name_USER.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PPWD_New_User_Validated(object sender, EventArgs e)
        {
            if(PWD_New_User.Text!= PPWD_New_User.Text)
            {
                MessageBox.Show("الرقم السري غير متطابقة !", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void PWD_New_User_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Salary_USER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Hours_of_work_USER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void ID_New_User_Validated(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = CEE.verify_User_Id(ID_New_User.Text);

            if (Dt.Rows.Count > 0)
            {
                MessageBox.Show("اسم المستخدم موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ID_New_User.Focus();
            }
        }

        private void ID_New_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PWD_New_User.Focus();
            }
        }

        private void PWD_New_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PPWD_New_User.Focus();
            }
        }

        private void PPWD_New_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Full_Name_USER.Focus();
            }
        }

        private void Full_Name_USER_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Salary_USER.Focus();
            }
        }

        private void Salary_USER_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Hours_of_work_USER.Focus();
            }
        }

        private void Hours_of_work_USER_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OkButton.Focus();
            }
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 10 )
            {
                e.Handled = true;
            }
        }
    }
}
