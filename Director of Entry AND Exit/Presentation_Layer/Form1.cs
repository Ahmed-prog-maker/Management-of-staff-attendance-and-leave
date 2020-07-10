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
    public partial class Form1 : Form
    {
        
        Business_Layer.Cls_login log = new Business_Layer.Cls_login();
        public string txt_ID ="";
        public Form1()
        {
            InitializeComponent();
        }

        
        private void txtID_OnValueChanged(object sender, EventArgs e)
        {

        }
       

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.login(txtID.Text, txtPWD.Text);
            
            txt_ID = txtID.Text;
            textBox1.Text = txt_ID;
            if (Dt.Rows.Count > 0)
            {
                
                MessageBox.Show("تم التسجيل بنجاح", "عمليه التسجيل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("لم يتم التسجيل", "عمليه التسجيل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            Form_main frm = new Form_main();
            frm.ShowDialog();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = txt_ID;
        }
    }
}
