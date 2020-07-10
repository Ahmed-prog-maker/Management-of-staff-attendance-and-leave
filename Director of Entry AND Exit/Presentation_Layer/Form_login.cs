using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Director_of_Entry_AND_Exit
{
    public partial class Form_login : Form
    {
        public static Form_login frm;
        Business_Layer.Cls_login log = new Business_Layer.Cls_login();

        
        public Form_login()
        {
            InitializeComponent();
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.login(txtID.Text, txtPWD.Text);

            if (Dt.Rows.Count > 0)
            {
                MessageBox.Show("تم التسجيل بنجاح","عمليه التسجيل",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("لم يتم التسجيل", "عمليه التسجيل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            Presentation_Layer.Form_main frm = new Presentation_Layer.Form_main();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtID_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }
    }
}
