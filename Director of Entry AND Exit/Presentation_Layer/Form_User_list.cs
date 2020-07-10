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
    public partial class Form_User_list : Form
    {
        Business_Layer.Cls_Entry_AND_Exit CEE = new Business_Layer.Cls_Entry_AND_Exit();
        public Form_User_list()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = CEE.Get_and_shawIt_USER_list();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
