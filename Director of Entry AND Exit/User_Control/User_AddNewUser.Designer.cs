namespace Director_of_Entry_AND_Exit.User_Control
{
    partial class User_AddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_AddNewUser));
            this.ID_New_User = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PWD_New_User = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PPWD_New_User = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.OkButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Full_Name_USER = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.Salary_USER = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.Hours_of_work_USER = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_Sections = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.combo_Working_time = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID_New_User
            // 
            this.ID_New_User.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ID_New_User.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ID_New_User.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ID_New_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID_New_User.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_New_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ID_New_User.HintForeColor = System.Drawing.Color.DimGray;
            this.ID_New_User.HintText = "اسم المستخدم";
            this.ID_New_User.isPassword = false;
            this.ID_New_User.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.ID_New_User.LineIdleColor = System.Drawing.Color.Gray;
            this.ID_New_User.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.ID_New_User.LineThickness = 3;
            this.ID_New_User.Location = new System.Drawing.Point(502, 134);
            this.ID_New_User.Margin = new System.Windows.Forms.Padding(4);
            this.ID_New_User.MaxLength = 32767;
            this.ID_New_User.Name = "ID_New_User";
            this.ID_New_User.Size = new System.Drawing.Size(219, 33);
            this.ID_New_User.TabIndex = 0;
            this.ID_New_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ID_New_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_New_User_KeyDown);
            this.ID_New_User.Validated += new System.EventHandler(this.ID_New_User_Validated);
            // 
            // PWD_New_User
            // 
            this.PWD_New_User.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PWD_New_User.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PWD_New_User.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PWD_New_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PWD_New_User.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWD_New_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PWD_New_User.HintForeColor = System.Drawing.Color.DimGray;
            this.PWD_New_User.HintText = "رقم السري";
            this.PWD_New_User.isPassword = true;
            this.PWD_New_User.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.PWD_New_User.LineIdleColor = System.Drawing.Color.Gray;
            this.PWD_New_User.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.PWD_New_User.LineThickness = 3;
            this.PWD_New_User.Location = new System.Drawing.Point(45, 134);
            this.PWD_New_User.Margin = new System.Windows.Forms.Padding(4);
            this.PWD_New_User.MaxLength = 32767;
            this.PWD_New_User.Name = "PWD_New_User";
            this.PWD_New_User.Size = new System.Drawing.Size(219, 33);
            this.PWD_New_User.TabIndex = 5;
            this.PWD_New_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PWD_New_User.OnValueChanged += new System.EventHandler(this.PWD_New_User_OnValueChanged);
            this.PWD_New_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PWD_New_User_KeyDown);
            // 
            // PPWD_New_User
            // 
            this.PPWD_New_User.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PPWD_New_User.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PPWD_New_User.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PPWD_New_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PPWD_New_User.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPWD_New_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PPWD_New_User.HintForeColor = System.Drawing.Color.DimGray;
            this.PPWD_New_User.HintText = "رقم السري";
            this.PPWD_New_User.isPassword = true;
            this.PPWD_New_User.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.PPWD_New_User.LineIdleColor = System.Drawing.Color.Gray;
            this.PPWD_New_User.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.PPWD_New_User.LineThickness = 3;
            this.PPWD_New_User.Location = new System.Drawing.Point(45, 197);
            this.PPWD_New_User.Margin = new System.Windows.Forms.Padding(4);
            this.PPWD_New_User.MaxLength = 32767;
            this.PPWD_New_User.Name = "PPWD_New_User";
            this.PPWD_New_User.Size = new System.Drawing.Size(219, 33);
            this.PPWD_New_User.TabIndex = 6;
            this.PPWD_New_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PPWD_New_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PPWD_New_User_KeyDown);
            this.PPWD_New_User.Validated += new System.EventHandler(this.PPWD_New_User_Validated);
            // 
            // OkButton
            // 
            this.OkButton.Active = false;
            this.OkButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.OkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OkButton.BorderRadius = 0;
            this.OkButton.ButtonText = "إنشاء مستخدم جديد";
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.DisabledColor = System.Drawing.Color.Gray;
            this.OkButton.Iconcolor = System.Drawing.Color.Transparent;
            this.OkButton.Iconimage = null;
            this.OkButton.Iconimage_right = null;
            this.OkButton.Iconimage_right_Selected = null;
            this.OkButton.Iconimage_Selected = null;
            this.OkButton.IconMarginLeft = 0;
            this.OkButton.IconMarginRight = 0;
            this.OkButton.IconRightVisible = true;
            this.OkButton.IconRightZoom = 0D;
            this.OkButton.IconVisible = true;
            this.OkButton.IconZoom = 90D;
            this.OkButton.IsTab = false;
            this.OkButton.Location = new System.Drawing.Point(340, 473);
            this.OkButton.Name = "OkButton";
            this.OkButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.OkButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.OkButton.OnHoverTextColor = System.Drawing.Color.White;
            this.OkButton.selected = false;
            this.OkButton.Size = new System.Drawing.Size(223, 40);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "إنشاء مستخدم جديد";
            this.OkButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OkButton.Textcolor = System.Drawing.Color.White;
            this.OkButton.TextFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "";
            this.bunifuTileButton1.Location = new System.Drawing.Point(376, 22);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(116, 108);
            this.bunifuTileButton1.TabIndex = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "مدير",
            "عادي"});
            this.comboBox1.Location = new System.Drawing.Point(502, 332);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(744, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 234;
            this.label2.Text = "نوع المستخدم :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 121;
            this.label3.Text = "كلمه المرور :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 232;
            this.label4.Text = "تاكيد كلمه المرور :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(735, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 111;
            this.label5.Text = "اسم المستخدم :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(756, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 123;
            this.label6.Text = "اسم المناوب :";
            // 
            // Full_Name_USER
            // 
            this.Full_Name_USER.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Full_Name_USER.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Full_Name_USER.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Full_Name_USER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Full_Name_USER.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Full_Name_USER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Full_Name_USER.HintForeColor = System.Drawing.Color.DimGray;
            this.Full_Name_USER.HintText = "اسم المناوب";
            this.Full_Name_USER.isPassword = false;
            this.Full_Name_USER.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.Full_Name_USER.LineIdleColor = System.Drawing.Color.Gray;
            this.Full_Name_USER.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.Full_Name_USER.LineThickness = 3;
            this.Full_Name_USER.Location = new System.Drawing.Point(502, 199);
            this.Full_Name_USER.Margin = new System.Windows.Forms.Padding(4);
            this.Full_Name_USER.MaxLength = 32767;
            this.Full_Name_USER.Name = "Full_Name_USER";
            this.Full_Name_USER.Size = new System.Drawing.Size(215, 33);
            this.Full_Name_USER.TabIndex = 1;
            this.Full_Name_USER.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Full_Name_USER.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Full_Name_USER_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(751, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 232;
            this.label7.Text = "راتب الشهري :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Salary_USER
            // 
            this.Salary_USER.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Salary_USER.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Salary_USER.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Salary_USER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Salary_USER.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_USER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Salary_USER.HintForeColor = System.Drawing.Color.DimGray;
            this.Salary_USER.HintText = "راتب الشهري";
            this.Salary_USER.isPassword = false;
            this.Salary_USER.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.Salary_USER.LineIdleColor = System.Drawing.Color.Gray;
            this.Salary_USER.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.Salary_USER.LineThickness = 3;
            this.Salary_USER.Location = new System.Drawing.Point(502, 262);
            this.Salary_USER.Margin = new System.Windows.Forms.Padding(4);
            this.Salary_USER.MaxLength = 8;
            this.Salary_USER.Name = "Salary_USER";
            this.Salary_USER.Size = new System.Drawing.Size(219, 33);
            this.Salary_USER.TabIndex = 2;
            this.Salary_USER.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Salary_USER.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            this.Salary_USER.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Salary_USER_KeyDown);
            this.Salary_USER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Salary_USER_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(312, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 134;
            this.label8.Text = "رقم الجوال :";
            // 
            // Hours_of_work_USER
            // 
            this.Hours_of_work_USER.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Hours_of_work_USER.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Hours_of_work_USER.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Hours_of_work_USER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Hours_of_work_USER.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours_of_work_USER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Hours_of_work_USER.HintForeColor = System.Drawing.Color.DimGray;
            this.Hours_of_work_USER.HintText = "رقم الجوال";
            this.Hours_of_work_USER.isPassword = false;
            this.Hours_of_work_USER.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.Hours_of_work_USER.LineIdleColor = System.Drawing.Color.Gray;
            this.Hours_of_work_USER.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.Hours_of_work_USER.LineThickness = 3;
            this.Hours_of_work_USER.Location = new System.Drawing.Point(45, 262);
            this.Hours_of_work_USER.Margin = new System.Windows.Forms.Padding(4);
            this.Hours_of_work_USER.MaxLength = 9;
            this.Hours_of_work_USER.Name = "Hours_of_work_USER";
            this.Hours_of_work_USER.Size = new System.Drawing.Size(219, 33);
            this.Hours_of_work_USER.TabIndex = 7;
            this.Hours_of_work_USER.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Hours_of_work_USER.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hours_of_work_USER_KeyDown);
            this.Hours_of_work_USER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hours_of_work_USER_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(579, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "* يستخدم في تسجيل الدخول";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(427, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(295, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "* يستخدم في التقارير والجداول ويستحسن كتابه الاسم الثلاثي";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.combo_Sections);
            this.groupBox1.Controls.Add(this.bunifuTileButton1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.combo_Working_time);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ID_New_User);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.PWD_New_User);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PPWD_New_User);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Hours_of_work_USER);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Salary_USER);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Full_Name_USER);
            this.groupBox1.Location = new System.Drawing.Point(15, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 435);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مستخدم جديد";
            // 
            // combo_Sections
            // 
            this.combo_Sections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Sections.FormattingEnabled = true;
            this.combo_Sections.Location = new System.Drawing.Point(502, 391);
            this.combo_Sections.Name = "combo_Sections";
            this.combo_Sections.Size = new System.Drawing.Size(219, 21);
            this.combo_Sections.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(802, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 18);
            this.label11.TabIndex = 234;
            this.label11.Text = "قسم :";
            // 
            // combo_Working_time
            // 
            this.combo_Working_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Working_time.FormattingEnabled = true;
            this.combo_Working_time.ItemHeight = 13;
            this.combo_Working_time.Location = new System.Drawing.Point(45, 335);
            this.combo_Working_time.Name = "combo_Working_time";
            this.combo_Working_time.Size = new System.Drawing.Size(219, 21);
            this.combo_Working_time.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "فترة الدوام :";
            // 
            // User_AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OkButton);
            this.Name = "User_AddNewUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(900, 527);
            this.Load += new System.EventHandler(this.User_AddNewUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox ID_New_User;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PWD_New_User;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PPWD_New_User;
        private Bunifu.Framework.UI.BunifuFlatButton OkButton;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Full_Name_USER;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Salary_USER;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Hours_of_work_USER;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combo_Sections;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combo_Working_time;
        private System.Windows.Forms.Label label1;
    }
}
