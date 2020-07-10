using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Director_of_Entry_AND_Exit.User_Control
{
    public partial class User_Settings : UserControl
    {
        
       
        Business_Layer.Cls_Entry_AND_Exit CEE = new Business_Layer.Cls_Entry_AND_Exit();
         
        public User_Settings()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " ملفات الصور | *.JPG; *.PNG; *.GIF;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Ima.Image = System.Drawing.Image.FromFile(ofd.FileName);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            Ima.Image.Save(ms, Ima.Image.RawFormat);
            byte[] byteImage = ms.ToArray();

            if (Name_Sett.Text == string.Empty || Address.Text == string.Empty || phone.Text == string.Empty || Cellphone1.Text == string.Empty
                || Cellphone2.Text == string.Empty )
            {
                MessageBox.Show("رجاء ادخل جميع البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CEE.add_Settings_table(Name_Sett.Text, Address.Text, Convert.ToInt32(phone.Text),
                Convert.ToInt32(Cellphone1.Text), Convert.ToInt32(Cellphone2.Text), byteImage);
           

            MessageBox.Show("تمت اضافه المنتج بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Name_Sett_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Address.Focus();
            }
        }

        private void Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                phone.Focus();
            }
        }

        private void phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cellphone1.Focus();
            }
        }

        private void Cellphone1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cellphone2.Focus();
            }
        }

        private void Cellphone2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ima.Focus();
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Cellphone1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Cellphone2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Cellphone2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Form_BackUP frm1 = new Presentation_Layer.Form_BackUP();
            frm1.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Form_Recovery frm2 = new Presentation_Layer.Form_Recovery();
            frm2.ShowDialog();
        }
    }
}
