using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Director_of_Entry_AND_Exit.License
{
    public partial class Form_EnAndDe : Form
    {
        public Form_EnAndDe()
        {
            InitializeComponent();
        }

        private void BtnEn_Click(object sender, EventArgs e)
        {
            txtEn.Clear();
            txtEn.Text = Business_Layer.Cls_Encryption.Encrypt(txtDe.Text);
        }

        private void BtnDe_Click(object sender, EventArgs e)
        {
            txtDe.Clear();
            txtDe.Text = Business_Layer.Cls_Encryption.Decrypt(txtEn.Text);
        }

        private void BtnCansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
