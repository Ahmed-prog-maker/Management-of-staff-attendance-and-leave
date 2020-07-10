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
    public partial class Form_Working_time_Editcs : Form
    {
        public DataTable dt;
        public Form_Working_time_Editcs()
        {
            InitializeComponent();
            dataGrid.DataSource = dt;
        }
    }
}
