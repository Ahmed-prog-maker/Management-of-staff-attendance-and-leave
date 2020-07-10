using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Director_of_Entry_AND_Exit.Properties;

namespace Director_of_Entry_AND_Exit.User_Control
{
    
    public partial class User_Message : UserControl
    {
        Business_Layer.Cls_Entry_AND_Exit EaE = new Business_Layer.Cls_Entry_AND_Exit();
        DateTime Date_Message = DateTime.Now.Date;
        
        public User_Message()
        {
            InitializeComponent();
            To_Massage.DataSource = EaE.get_ID_USER();
            To_Massage.DisplayMember = "Full_Name_USER";
            To_Massage.ValueMember = "Full_Name_USER";

            Date_Labl.Text = DateTime.Now.ToString("d/M/yyyy");
            
            Full_Name_USER.Text = Settings.Default.FullName;
            //Full_Name_USER.Text = Presentation_Layer.Form_main.NameID;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (To_Massage.Text == string.Empty || Text_Message.Text == string.Empty)
            {
                MessageBox.Show("الرجاء ادخل جميع البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int flat = 0;
            EaE.add_Messege_Table(Full_Name_USER.Text, Date_Message, To_Massage.Text, Text_Message.Text, flat);
            MessageBox.Show("تم الإرسال", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Text_Message.Clear();

        }
    }
}
