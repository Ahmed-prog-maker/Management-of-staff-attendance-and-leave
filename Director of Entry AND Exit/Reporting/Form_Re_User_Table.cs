using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Director_of_Entry_AND_Exit.Reporting
{
    public partial class Form_Re_User_Table : Form
    {
        public Form_Re_User_Table()
        {
            InitializeComponent();
        }

        private void Form_Re_User_Table_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
