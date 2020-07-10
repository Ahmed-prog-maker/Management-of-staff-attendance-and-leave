namespace Director_of_Entry_AND_Exit.Presentation_Layer
{
    partial class Form_add
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_add));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Date_Log_In = new Bunifu.Framework.UI.BunifuDatepicker();
            this.text1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Date_Log_Out = new Bunifu.Framework.UI.BunifuDatepicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboHH2 = new System.Windows.Forms.ComboBox();
            this.comboMM2 = new System.Windows.Forms.ComboBox();
            this.comboTT2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboID_USER = new System.Windows.Forms.ComboBox();
            this.comboHH1 = new System.Windows.Forms.ComboBox();
            this.comboMM1 = new System.Windows.Forms.ComboBox();
            this.comboTT1 = new System.Windows.Forms.ComboBox();
            this.text2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Date_Log_In
            // 
            this.Date_Log_In.BackColor = System.Drawing.Color.SeaGreen;
            this.Date_Log_In.BorderRadius = 0;
            this.Date_Log_In.ForeColor = System.Drawing.Color.White;
            this.Date_Log_In.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date_Log_In.FormatCustom = null;
            this.Date_Log_In.Location = new System.Drawing.Point(90, 96);
            this.Date_Log_In.Name = "Date_Log_In";
            this.Date_Log_In.Size = new System.Drawing.Size(214, 35);
            this.Date_Log_In.TabIndex = 0;
            this.Date_Log_In.Value = new System.DateTime(2018, 8, 3, 18, 24, 0, 0);
            this.Date_Log_In.onValueChanged += new System.EventHandler(this.Date_Log_In_onValueChanged);
            // 
            // text1
            // 
            this.text1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.text1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.text1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.text1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text1.HintForeColor = System.Drawing.Color.Silver;
            this.text1.HintText = "ملاحظه الدخول";
            this.text1.isPassword = false;
            this.text1.LineFocusedColor = System.Drawing.Color.Blue;
            this.text1.LineIdleColor = System.Drawing.Color.Gray;
            this.text1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.text1.LineThickness = 3;
            this.text1.Location = new System.Drawing.Point(90, 213);
            this.text1.Margin = new System.Windows.Forms.Padding(4);
            this.text1.MaxLength = 32767;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(214, 33);
            this.text1.TabIndex = 5;
            this.text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text1.OnValueChanged += new System.EventHandler(this.text1_OnValueChanged);
            // 
            // Date_Log_Out
            // 
            this.Date_Log_Out.BackColor = System.Drawing.Color.SeaGreen;
            this.Date_Log_Out.BorderRadius = 0;
            this.Date_Log_Out.ForeColor = System.Drawing.Color.White;
            this.Date_Log_Out.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date_Log_Out.FormatCustom = null;
            this.Date_Log_Out.Location = new System.Drawing.Point(90, 308);
            this.Date_Log_Out.Name = "Date_Log_Out";
            this.Date_Log_Out.Size = new System.Drawing.Size(214, 35);
            this.Date_Log_Out.TabIndex = 6;
            this.Date_Log_Out.Value = new System.DateTime(2018, 8, 3, 18, 24, 0, 0);
            this.Date_Log_Out.onValueChanged += new System.EventHandler(this.Date_Log_Out_onValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.bunifuFlatButton3);
            this.groupBox1.Controls.Add(this.bunifuFlatButton2);
            this.groupBox1.Controls.Add(this.bunifuFlatButton1);
            this.groupBox1.Controls.Add(this.comboHH2);
            this.groupBox1.Controls.Add(this.comboMM2);
            this.groupBox1.Controls.Add(this.comboTT2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboID_USER);
            this.groupBox1.Controls.Add(this.comboHH1);
            this.groupBox1.Controls.Add(this.comboMM1);
            this.groupBox1.Controls.Add(this.comboTT1);
            this.groupBox1.Controls.Add(this.text2);
            this.groupBox1.Controls.Add(this.Date_Log_In);
            this.groupBox1.Controls.Add(this.text1);
            this.groupBox1.Controls.Add(this.Date_Log_Out);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 587);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الاضافه";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "الغاء";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(90, 514);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(90, 38);
            this.bunifuFlatButton2.TabIndex = 30;
            this.bunifuFlatButton2.Text = "الغاء";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "اضافه";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(214, 514);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(90, 38);
            this.bunifuFlatButton1.TabIndex = 29;
            this.bunifuFlatButton1.Text = "اضافه";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // comboHH2
            // 
            this.comboHH2.FormattingEnabled = true;
            this.comboHH2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboHH2.Location = new System.Drawing.Point(263, 372);
            this.comboHH2.Name = "comboHH2";
            this.comboHH2.Size = new System.Drawing.Size(41, 21);
            this.comboHH2.TabIndex = 28;
            this.comboHH2.SelectedIndexChanged += new System.EventHandler(this.comboHH2_SelectedIndexChanged);
            // 
            // comboMM2
            // 
            this.comboMM2.FormattingEnabled = true;
            this.comboMM2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.comboMM2.Location = new System.Drawing.Point(180, 372);
            this.comboMM2.Name = "comboMM2";
            this.comboMM2.Size = new System.Drawing.Size(41, 21);
            this.comboMM2.TabIndex = 27;
            this.comboMM2.SelectedIndexChanged += new System.EventHandler(this.comboMM2_SelectedIndexChanged);
            // 
            // comboTT2
            // 
            this.comboTT2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTT2.FormattingEnabled = true;
            this.comboTT2.Items.AddRange(new object[] {
            "ص",
            "م"});
            this.comboTT2.Location = new System.Drawing.Point(90, 372);
            this.comboTT2.Name = "comboTT2";
            this.comboTT2.Size = new System.Drawing.Size(41, 21);
            this.comboTT2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "ساعه / دقيقه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "تاريخ الخروج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "ساعه / دقيقه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "تاريخ الدخول";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "اسم المناوب";
            // 
            // comboID_USER
            // 
            this.comboID_USER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboID_USER.FormattingEnabled = true;
            this.comboID_USER.Location = new System.Drawing.Point(90, 37);
            this.comboID_USER.Name = "comboID_USER";
            this.comboID_USER.Size = new System.Drawing.Size(214, 21);
            this.comboID_USER.TabIndex = 20;
            // 
            // comboHH1
            // 
            this.comboHH1.FormattingEnabled = true;
            this.comboHH1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboHH1.Location = new System.Drawing.Point(263, 164);
            this.comboHH1.Name = "comboHH1";
            this.comboHH1.Size = new System.Drawing.Size(41, 21);
            this.comboHH1.TabIndex = 15;
            this.comboHH1.SelectedIndexChanged += new System.EventHandler(this.comboHH1_SelectedIndexChanged);
            // 
            // comboMM1
            // 
            this.comboMM1.FormattingEnabled = true;
            this.comboMM1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.comboMM1.Location = new System.Drawing.Point(180, 164);
            this.comboMM1.Name = "comboMM1";
            this.comboMM1.Size = new System.Drawing.Size(41, 21);
            this.comboMM1.TabIndex = 14;
            this.comboMM1.SelectedIndexChanged += new System.EventHandler(this.comboMM1_SelectedIndexChanged);
            // 
            // comboTT1
            // 
            this.comboTT1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTT1.FormattingEnabled = true;
            this.comboTT1.Items.AddRange(new object[] {
            "ص",
            "م"});
            this.comboTT1.Location = new System.Drawing.Point(90, 164);
            this.comboTT1.Name = "comboTT1";
            this.comboTT1.Size = new System.Drawing.Size(41, 21);
            this.comboTT1.TabIndex = 12;
            this.comboTT1.SelectedIndexChanged += new System.EventHandler(this.comboTT1_SelectedIndexChanged);
            // 
            // text2
            // 
            this.text2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.text2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.text2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.text2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text2.HintForeColor = System.Drawing.Color.Silver;
            this.text2.HintText = "ملاحظه الخروج";
            this.text2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.text2.isPassword = false;
            this.text2.LineFocusedColor = System.Drawing.Color.Blue;
            this.text2.LineIdleColor = System.Drawing.Color.Gray;
            this.text2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.text2.LineThickness = 3;
            this.text2.Location = new System.Drawing.Point(90, 428);
            this.text2.Margin = new System.Windows.Forms.Padding(4);
            this.text2.MaxLength = 32767;
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(214, 33);
            this.text2.TabIndex = 9;
            this.text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(462, 18);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(18, 17);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 31;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "اضافه مستخدم جديد";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 46);
            this.panel1.TabIndex = 32;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = false;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "bunifuFlatButton3";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(238, 459);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton3.TabIndex = 31;
            this.bunifuFlatButton3.Text = "bunifuFlatButton3";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 532);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 32;
            // 
            // Form_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_add";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox text1;
        private Bunifu.Framework.UI.BunifuDatepicker Date_Log_Out;
        private Bunifu.Framework.UI.BunifuMaterialTextbox text2;
        private System.Windows.Forms.ComboBox comboTT1;
        private System.Windows.Forms.ComboBox comboHH1;
        private System.Windows.Forms.ComboBox comboMM1;
        public Bunifu.Framework.UI.BunifuDatepicker Date_Log_In;
        private System.Windows.Forms.ComboBox comboID_USER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboHH2;
        private System.Windows.Forms.ComboBox comboMM2;
        private System.Windows.Forms.ComboBox comboTT2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.TextBox textBox1;
    }
}