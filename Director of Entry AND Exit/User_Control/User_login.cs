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
    public partial class User_login : UserControl
    {
        Business_Layer.Cls_login log = new Business_Layer.Cls_login();


        public static User_login frm;
        public string txt_ID = "gyyyyyy";
        public User_login()
        {
            InitializeComponent();
          
        }
        

        private void User_login_Load(object sender, EventArgs e)
        {

        }
        public string txxt(string st)
        {
            st = txtID.Text;
            return st;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            DataTable Dt = log.login(txtID.Text, txtPWD.Text);



            if (Dt.Rows.Count > 0)
            {
                Presentation_Layer.Form_main.getMainForm.TimeButton.Enabled = true;
            Presentation_Layer.Form_main.getMainForm.TableButton.Enabled = true;
            Presentation_Layer.Form_main.getMainForm.NewUserButton.Enabled = true;
            Presentation_Layer.Form_main.getMainForm.SettingsButton.Enabled = true;
            txt_ID = txtID.Text;

                MessageBox.Show("تم التسجيل بنجاح", "عمليه التسجيل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("لم يتم التسجيل", "عمليه التسجيل", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
