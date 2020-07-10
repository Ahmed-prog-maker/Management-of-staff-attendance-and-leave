namespace Director_of_Entry_AND_Exit.User_Control
{
    partial class User_Taimer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Taimer));
            this.label1 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.okButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPWD = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Log_In_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Log_Out_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Log_In_Save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.LABLog_Out = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.LABLog_In = new Bunifu.UI.WinForms.BunifuLabel();
            this.Log_Out_Save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "0 : 0 : 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(289, 139);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(251, 20);
            this.text1.TabIndex = 10;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(289, 272);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(251, 20);
            this.text2.TabIndex = 11;
            // 
            // okButton
            // 
            this.okButton.Active = false;
            this.okButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.okButton.BackColor = System.Drawing.Color.SeaGreen;
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.okButton.BorderRadius = 0;
            this.okButton.ButtonText = "تسجيل دخول";
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.DisabledColor = System.Drawing.Color.Gainsboro;
            this.okButton.Iconcolor = System.Drawing.Color.Transparent;
            this.okButton.Iconimage = null;
            this.okButton.Iconimage_right = null;
            this.okButton.Iconimage_right_Selected = null;
            this.okButton.Iconimage_Selected = null;
            this.okButton.IconMarginLeft = 0;
            this.okButton.IconMarginRight = 0;
            this.okButton.IconRightVisible = true;
            this.okButton.IconRightZoom = 0D;
            this.okButton.IconVisible = true;
            this.okButton.IconZoom = 90D;
            this.okButton.IsTab = false;
            this.okButton.Location = new System.Drawing.Point(27, 41);
            this.okButton.Name = "okButton";
            this.okButton.Normalcolor = System.Drawing.Color.SeaGreen;
            this.okButton.OnHovercolor = System.Drawing.Color.Green;
            this.okButton.OnHoverTextColor = System.Drawing.Color.White;
            this.okButton.selected = false;
            this.okButton.Size = new System.Drawing.Size(104, 48);
            this.okButton.TabIndex = 17;
            this.okButton.Text = "تسجيل دخول";
            this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okButton.Textcolor = System.Drawing.Color.White;
            this.okButton.TextFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // txtPWD
            // 
            this.txtPWD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPWD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPWD.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPWD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPWD.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPWD.ForeColor = System.Drawing.Color.DimGray;
            this.txtPWD.HintForeColor = System.Drawing.Color.DimGray;
            this.txtPWD.HintText = "رقم السري";
            this.txtPWD.isPassword = true;
            this.txtPWD.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtPWD.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtPWD.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtPWD.LineThickness = 3;
            this.txtPWD.Location = new System.Drawing.Point(338, 50);
            this.txtPWD.Margin = new System.Windows.Forms.Padding(4);
            this.txtPWD.MaxLength = 32767;
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(223, 33);
            this.txtPWD.TabIndex = 68;
            this.txtPWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPWD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPWD_KeyDown);
            // 
            // txtID
            // 
            this.txtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtID.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.DimGray;
            this.txtID.HintForeColor = System.Drawing.Color.DimGray;
            this.txtID.HintText = "اسم المستخدم ";
            this.txtID.isPassword = false;
            this.txtID.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtID.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtID.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtID.LineThickness = 3;
            this.txtID.Location = new System.Drawing.Point(589, 50);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(223, 33);
            this.txtID.TabIndex = 30;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtPWD);
            this.groupBox1.Controls.Add(this.okButton);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(29, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(843, 137);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تسجيل الدخول";
            // 
            // ExitButton
            // 
            this.ExitButton.Active = false;
            this.ExitButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ExitButton.BackColor = System.Drawing.Color.SeaGreen;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.BorderRadius = 0;
            this.ExitButton.ButtonText = "تسجيل خروج";
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DisabledColor = System.Drawing.Color.Gainsboro;
            this.ExitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ExitButton.Iconimage = null;
            this.ExitButton.Iconimage_right = null;
            this.ExitButton.Iconimage_right_Selected = null;
            this.ExitButton.Iconimage_Selected = null;
            this.ExitButton.IconMarginLeft = 0;
            this.ExitButton.IconMarginRight = 0;
            this.ExitButton.IconRightVisible = true;
            this.ExitButton.IconRightZoom = 0D;
            this.ExitButton.IconVisible = true;
            this.ExitButton.IconZoom = 90D;
            this.ExitButton.IsTab = false;
            this.ExitButton.Location = new System.Drawing.Point(176, 41);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Normalcolor = System.Drawing.Color.SeaGreen;
            this.ExitButton.OnHovercolor = System.Drawing.Color.Green;
            this.ExitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ExitButton.selected = false;
            this.ExitButton.Size = new System.Drawing.Size(104, 48);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "تسجيل خروج";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.Textcolor = System.Drawing.Color.White;
            this.ExitButton.TextFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Log_In_Button);
            this.groupBox2.Controls.Add(this.Log_Out_Button);
            this.groupBox2.Controls.Add(this.Log_In_Save);
            this.groupBox2.Controls.Add(this.bunifuLabel2);
            this.groupBox2.Controls.Add(this.LABLog_Out);
            this.groupBox2.Controls.Add(this.bunifuLabel1);
            this.groupBox2.Controls.Add(this.LABLog_In);
            this.groupBox2.Controls.Add(this.Log_Out_Save);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.text2);
            this.groupBox2.Controls.Add(this.text1);
            this.groupBox2.Location = new System.Drawing.Point(29, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(843, 329);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المؤقت";
            // 
            // Log_In_Button
            // 
            this.Log_In_Button.Active = false;
            this.Log_In_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log_In_Button.BackColor = System.Drawing.Color.SeaGreen;
            this.Log_In_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Log_In_Button.BorderRadius = 0;
            this.Log_In_Button.ButtonText = "دخول";
            this.Log_In_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log_In_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Log_In_Button.Enabled = false;
            this.Log_In_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Log_In_Button.Iconimage = null;
            this.Log_In_Button.Iconimage_right = null;
            this.Log_In_Button.Iconimage_right_Selected = null;
            this.Log_In_Button.Iconimage_Selected = null;
            this.Log_In_Button.IconMarginLeft = 0;
            this.Log_In_Button.IconMarginRight = 0;
            this.Log_In_Button.IconRightVisible = true;
            this.Log_In_Button.IconRightZoom = 0D;
            this.Log_In_Button.IconVisible = true;
            this.Log_In_Button.IconZoom = 90D;
            this.Log_In_Button.IsTab = false;
            this.Log_In_Button.Location = new System.Drawing.Point(640, 111);
            this.Log_In_Button.Name = "Log_In_Button";
            this.Log_In_Button.Normalcolor = System.Drawing.Color.SeaGreen;
            this.Log_In_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Log_In_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Log_In_Button.selected = false;
            this.Log_In_Button.Size = new System.Drawing.Size(104, 48);
            this.Log_In_Button.TabIndex = 28;
            this.Log_In_Button.Text = "دخول";
            this.Log_In_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Log_In_Button.Textcolor = System.Drawing.Color.White;
            this.Log_In_Button.TextFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_In_Button.Click += new System.EventHandler(this.bunifuFlatButton1_Click_2);
            // 
            // Log_Out_Button
            // 
            this.Log_Out_Button.Active = false;
            this.Log_Out_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log_Out_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log_Out_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Log_Out_Button.BorderRadius = 0;
            this.Log_Out_Button.ButtonText = "خروج";
            this.Log_Out_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log_Out_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Log_Out_Button.Enabled = false;
            this.Log_Out_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Log_Out_Button.Iconimage = null;
            this.Log_Out_Button.Iconimage_right = null;
            this.Log_Out_Button.Iconimage_right_Selected = null;
            this.Log_Out_Button.Iconimage_Selected = null;
            this.Log_Out_Button.IconMarginLeft = 0;
            this.Log_Out_Button.IconMarginRight = 0;
            this.Log_Out_Button.IconRightVisible = true;
            this.Log_Out_Button.IconRightZoom = 0D;
            this.Log_Out_Button.IconVisible = true;
            this.Log_Out_Button.IconZoom = 90D;
            this.Log_Out_Button.IsTab = false;
            this.Log_Out_Button.Location = new System.Drawing.Point(640, 244);
            this.Log_Out_Button.Name = "Log_Out_Button";
            this.Log_Out_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log_Out_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Log_Out_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Log_Out_Button.selected = false;
            this.Log_Out_Button.Size = new System.Drawing.Size(104, 48);
            this.Log_Out_Button.TabIndex = 27;
            this.Log_Out_Button.Text = "خروج";
            this.Log_Out_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Log_Out_Button.Textcolor = System.Drawing.Color.White;
            this.Log_Out_Button.TextFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Out_Button.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // Log_In_Save
            // 
            this.Log_In_Save.Active = false;
            this.Log_In_Save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log_In_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log_In_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Log_In_Save.BorderRadius = 0;
            this.Log_In_Save.ButtonText = "حفظ";
            this.Log_In_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log_In_Save.DisabledColor = System.Drawing.Color.Gray;
            this.Log_In_Save.Enabled = false;
            this.Log_In_Save.Iconcolor = System.Drawing.Color.Transparent;
            this.Log_In_Save.Iconimage = null;
            this.Log_In_Save.Iconimage_right = null;
            this.Log_In_Save.Iconimage_right_Selected = null;
            this.Log_In_Save.Iconimage_Selected = null;
            this.Log_In_Save.IconMarginLeft = 0;
            this.Log_In_Save.IconMarginRight = 0;
            this.Log_In_Save.IconRightVisible = true;
            this.Log_In_Save.IconRightZoom = 0D;
            this.Log_In_Save.IconVisible = true;
            this.Log_In_Save.IconZoom = 90D;
            this.Log_In_Save.IsTab = false;
            this.Log_In_Save.Location = new System.Drawing.Point(94, 111);
            this.Log_In_Save.Name = "Log_In_Save";
            this.Log_In_Save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log_In_Save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Log_In_Save.OnHoverTextColor = System.Drawing.Color.White;
            this.Log_In_Save.selected = false;
            this.Log_In_Save.Size = new System.Drawing.Size(104, 48);
            this.Log_In_Save.TabIndex = 26;
            this.Log_In_Save.Text = "حفظ";
            this.Log_In_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Log_In_Save.Textcolor = System.Drawing.Color.White;
            this.Log_In_Save.TextFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_In_Save.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(372, 244);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuLabel2.Size = new System.Drawing.Size(91, 18);
            this.bunifuLabel2.TabIndex = 25;
            this.bunifuLabel2.Text = "ملاحظه الخروج :";
            this.bunifuLabel2.TextAlign = Bunifu.UI.WinForms.BunifuLabel.TextAlignments.Left;
            // 
            // LABLog_Out
            // 
            this.LABLog_Out.CursorType = null;
            this.LABLog_Out.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABLog_Out.Location = new System.Drawing.Point(645, 298);
            this.LABLog_Out.Name = "LABLog_Out";
            this.LABLog_Out.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LABLog_Out.Size = new System.Drawing.Size(89, 21);
            this.LABLog_Out.TabIndex = 23;
            this.LABLog_Out.Text = "00 : 00 : 00";
            this.LABLog_Out.TextAlign = Bunifu.UI.WinForms.BunifuLabel.TextAlignments.Center;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(372, 111);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuLabel1.Size = new System.Drawing.Size(94, 18);
            this.bunifuLabel1.TabIndex = 24;
            this.bunifuLabel1.Text = "ملاحظه الدخول :";
            this.bunifuLabel1.TextAlign = Bunifu.UI.WinForms.BunifuLabel.TextAlignments.Left;
            // 
            // LABLog_In
            // 
            this.LABLog_In.CursorType = null;
            this.LABLog_In.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABLog_In.Location = new System.Drawing.Point(645, 165);
            this.LABLog_In.Name = "LABLog_In";
            this.LABLog_In.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LABLog_In.Size = new System.Drawing.Size(89, 21);
            this.LABLog_In.TabIndex = 22;
            this.LABLog_In.Text = "00 : 00 : 00";
            this.LABLog_In.TextAlign = Bunifu.UI.WinForms.BunifuLabel.TextAlignments.Center;
            // 
            // Log_Out_Save
            // 
            this.Log_Out_Save.Active = false;
            this.Log_Out_Save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log_Out_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log_Out_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Log_Out_Save.BorderRadius = 0;
            this.Log_Out_Save.ButtonText = "حفظ";
            this.Log_Out_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log_Out_Save.DisabledColor = System.Drawing.Color.Gray;
            this.Log_Out_Save.Enabled = false;
            this.Log_Out_Save.Iconcolor = System.Drawing.Color.Transparent;
            this.Log_Out_Save.Iconimage = null;
            this.Log_Out_Save.Iconimage_right = null;
            this.Log_Out_Save.Iconimage_right_Selected = null;
            this.Log_Out_Save.Iconimage_Selected = null;
            this.Log_Out_Save.IconMarginLeft = 0;
            this.Log_Out_Save.IconMarginRight = 0;
            this.Log_Out_Save.IconRightVisible = true;
            this.Log_Out_Save.IconRightZoom = 0D;
            this.Log_Out_Save.IconVisible = true;
            this.Log_Out_Save.IconZoom = 90D;
            this.Log_Out_Save.IsTab = false;
            this.Log_Out_Save.Location = new System.Drawing.Point(94, 244);
            this.Log_Out_Save.Name = "Log_Out_Save";
            this.Log_Out_Save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log_Out_Save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Log_Out_Save.OnHoverTextColor = System.Drawing.Color.White;
            this.Log_Out_Save.selected = false;
            this.Log_Out_Save.Size = new System.Drawing.Size(104, 48);
            this.Log_Out_Save.TabIndex = 19;
            this.Log_Out_Save.Text = "حفظ";
            this.Log_Out_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Log_Out_Save.Textcolor = System.Drawing.Color.White;
            this.Log_Out_Save.TextFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Out_Save.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // User_Taimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "User_Taimer";
            this.Size = new System.Drawing.Size(900, 527);
            this.Load += new System.EventHandler(this.User_Taimer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuFlatButton okButton;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPWD;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        public Bunifu.Framework.UI.BunifuFlatButton Log_Out_Save;
        private Bunifu.UI.WinForms.BunifuLabel LABLog_In;
        private Bunifu.UI.WinForms.BunifuLabel LABLog_Out;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        public System.Windows.Forms.TextBox text1;
        public System.Windows.Forms.TextBox text2;
        public Bunifu.Framework.UI.BunifuFlatButton ExitButton;
        public Bunifu.Framework.UI.BunifuFlatButton Log_In_Save;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public Bunifu.Framework.UI.BunifuFlatButton Log_In_Button;
        public Bunifu.Framework.UI.BunifuFlatButton Log_Out_Button;
    }
}
