using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Director_of_Entry_AND_Exit.User_Control
{
    public partial class Form_Edit : Form
    {
        public Form_Edit()
        {
            InitializeComponent();
            User_Taimer ut = new User_Taimer();
            ut.BringToFront();
        }
    }
}
