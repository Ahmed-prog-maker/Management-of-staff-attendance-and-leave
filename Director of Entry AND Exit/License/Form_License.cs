using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Director_of_Entry_AND_Exit.Properties;
using Microsoft.Win32;
using System.IO;
using System.Management;

namespace Director_of_Entry_AND_Exit.License
{
    public partial class Form_License : Form
    {

          double Result, TResult;
        DateTime TrialTime, CalTime;
        RegistryKey RK = Registry.CurrentUser.OpenSubKey("Software\\NextTech", true);
        TextBox td = new TextBox();
        
        public Form_License()
        {
            InitializeComponent();

            //Settings.Default.Reset();

            string mode = Settings.Default.Mode;
            if (mode == "SQL")
            {
                Settings.Default["Dr_DBConnectionString"] = String.Format("Data Source=" + Settings.Default.Server +
                 "; Initial Catalog=" + Settings.Default.Database +
                 "; Integrated Security = false; User ID=" + Settings.Default.ID +
                 "; Password=" + Settings.Default.Password + "");
            }
            else
            {
                 Settings.Default["Dr_DBConnectionString"] = String.Format("Data Source=" + Settings.Default.Server +
                 "; Initial Catalog=" + Settings.Default.Database +
                 "; Integrated Security = True;");
            }


            TrialTime = DateTime.Now;
            CalTime = DateTime.Now.AddDays(15);
            if (!Settings.Default.isChecked)
            {
                getUnlqueID("c");
                td.Text = getUnlqueID("c");

                Settings.Default.GI = td.Text;
                Settings.Default.Save();

                RegistryKey RK = Registry.CurrentUser.CreateSubKey("Software\\NextTech");
                RK = Registry.CurrentUser.OpenSubKey("Software\\NextTech", true);

                Settings.Default.CalDate = CalTime;
                RK.SetValue("count", Business_Layer.Cls_Encryption.Encrypt(Settings.Default.CalDate.ToString()));

                Settings.Default.Trial = TrialTime;
                Settings.Default.isChecked = true;
                timer1.Enabled = true;
                Settings.Default.Save();
            }
            else
            {
                getUnlqueID("c");
                td.Text = getUnlqueID("c");

                if (Settings.Default.Trial.Add(new TimeSpan(15, 0, 0, 0)) > DateTime.Now &&
                    DateTime.Now <= DateTime.Parse(Business_Layer.Cls_Encryption.Decrypt(RK.GetValue("count").ToString())))
                {
                    if (td.Text != Settings.Default.GI)
                    {
                        Application.Exit();
                    }
                    Settings.Default.isTrial = true;
                    timer1.Enabled = true;
                    Settings.Default.Save();
                }
                else if (DateTime.Now >= DateTime.Parse(Business_Layer.Cls_Encryption.Decrypt(RK.GetValue("count").ToString())))
                {
                    MessageBox.Show("انتهى الفترة التجريبية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    timer1.Enabled = false;
                    label3.Visible = false;
                    labelDays.Visible = false;
                    BtnTrial.Enabled = false;
                    labelText.ForeColor = Color.Red;
                    labelText.Text = "انتهى الفترة التجريبية";
                }
                else
                {
                    MessageBox.Show("انتهى الفترة التجريبية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    timer1.Enabled = false;
                    label3.Visible = false;
                    labelDays.Visible = false;
                    BtnTrial.Enabled = false;
                    labelText.ForeColor = Color.Red;
                    labelText.Text = "انتهى الفترة التجريبية";
                }
            }
        }
        private void Form_License_Load(object sender, EventArgs e)
        {
            getUnlqueID("c");
            td.Text = getUnlqueID("c");
            if (Settings.Default.isLicensed == Convert.ToBoolean(Business_Layer.Cls_Encryption.Decrypt(("101 * 117 % 114 % 116 *").ToString())))
            {
                SettingsCala();
                if (TResult == Convert.ToDouble(Business_Layer.Cls_Encryption.Decrypt(Settings.Default.KT.ToString())))
                {
                    if (td.Text != Settings.Default.GI)
                    {
                        Application.Exit();
                    }

                    timer1.Enabled = false;
                    Presentation_Layer.Form_main FM = new Presentation_Layer.Form_main();
                    this.Hide();
                    FM.ShowDialog();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        private void Cala()
        {
            if (txtSerial1.Text != string.Empty && txtSerial2.Text != string.Empty &&
                txtSerial3.Text != string.Empty && txtSerial4.Text != string.Empty)
            {
                double S1 = Convert.ToDouble(txtSerial1.Text);
                double S2 = Convert.ToDouble(txtSerial2.Text);
                double S3 = Convert.ToDouble(txtSerial3.Text);
                double S4 = Convert.ToDouble(txtSerial4.Text);
                Result = (S1 + S2) - (S3 + S4);
            }
        }
        private void SettingsCala()
        {
            if (Settings.Default.m1 != string.Empty && Settings.Default.m2 != string.Empty &&
                Settings.Default.m3 != string.Empty && Settings.Default.m4 != string.Empty)
            {
                double S1 = Convert.ToDouble(Settings.Default.m1);
                double S2 = Convert.ToDouble(Settings.Default.m2);
                double S3 = Convert.ToDouble(Settings.Default.m3);
                double S4 = Convert.ToDouble(Settings.Default.m4);
                TResult = (S1 + S2) - (S3 + S4);
            }
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtSerial1.Text == string.Empty || txtSerial2.Text == string.Empty ||
                txtSerial3.Text == string.Empty || txtSerial4.Text == string.Empty)
            {
                MessageBox.Show("عذرا اكتب السيريل اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Cala();
                if (Result == Convert.ToDouble(Business_Layer.Cls_Encryption.Decrypt(Settings.Default.KT.ToString())))
                {
                    getUnlqueID("c");
                    td.Text = getUnlqueID("c");

                    //Settings.Default.GI = td.Text;
                    //Settings.Default.Save();

                    if (td.Text != Settings.Default.GI)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        Settings.Default.m1 = txtSerial1.Text;
                        Settings.Default.m2 = txtSerial2.Text;
                        Settings.Default.m3 = txtSerial3.Text;
                        Settings.Default.m4 = txtSerial4.Text;

                        MessageBox.Show("تم تفعيل البرنامج بنجاح", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Settings.Default.isLicensed = true;
                        Settings.Default.Save();

                        timer1.Enabled = false;

                        Presentation_Layer.Form_main FM = new Presentation_Layer.Form_main();
                        this.Hide();
                        FM.ShowDialog();
                        //this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("رقم السيريل المدخل غير صحيح", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("رقم السيريل المدخل غير صحيح", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSerial1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSerial2.Focus();
            }
        }

        private void txtSerial2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSerial3.Focus();
            }
        }

        private void txtSerial3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSerial4.Focus();
            }
        }

        private void txtSerial4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.Focus();
            }
        }

        private void txtSerial1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtSerial2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtSerial3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtSerial4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(RK != null)
            {
                DateTime TotalTime = DateTime.Parse(Business_Layer.Cls_Encryption.Decrypt(RK.GetValue("count").ToString()));
                TimeSpan CountDown = TotalTime - DateTime.Now;

                if (CountDown.TotalSeconds <= 0)
                {
                    timer1.Enabled = false;
                    label3.Visible = false;
                    labelDays.Visible = false;
                    BtnTrial.Enabled = false;
                    labelText.ForeColor = Color.Red;
                    labelText.Text = "انتهى الفترة التجريبية";
                }
                else
                {
                    labelDays.Text = CountDown.Days.ToString();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getUnlqueID("c");
            td.Text = getUnlqueID("c");

            if (Settings.Default.Trial.Add(new TimeSpan (15, 0, 0, 0)) > DateTime.Now)
            {
                if (td.Text != Settings.Default.GI)
                {
                    Application.Exit();
                }
                Settings.Default.isTrial = true;
                Settings.Default.Save();
                Presentation_Layer.Form_main FM = new Presentation_Layer.Form_main();
                this.Hide();
                FM.ShowDialog();
            }
            else
            {
                timer1.Enabled = false;
                Application.Exit();
            }
        }
        private string getVolumeSerial(string drive)
        {
            ManagementObject disk = new ManagementObject(@"win32_logicaldisk.deviceid=""" + drive + @":""");
            disk.Get();

            string volumeSerial = disk["VolumeSerialNumber"].ToString();
            disk.Dispose();

            return volumeSerial;
        }

        private string getCPUID()
        {
            string cpuInfo = "";
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = managClass.GetInstances();

            foreach (ManagementObject managObj in managCollec)
            {
                if (cpuInfo == "")
                {
                    cpuInfo = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            return cpuInfo;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private string getUnlqueID(string drive)
        {
            if (drive == string.Empty)
            {
                foreach (DriveInfo compDrive in DriveInfo.GetDrives())
                {
                    if (compDrive.IsReady)
                    {
                        drive = compDrive.RootDirectory.ToString();
                        break;
                    }
                }
            }
            if (drive.EndsWith(":\\"))
            {
                drive = drive.Substring(0, drive.Length - 2);
            }
            string volumeSerial = getVolumeSerial(drive);
            string CpuID = getCPUID();

            return CpuID.Substring(13) + CpuID.Substring(1, 4) + volumeSerial + CpuID.Substring(4, 4);
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Form_Con CON = new Presentation_Layer.Form_Con();
            CON.ShowDialog();
        }
    }
}
