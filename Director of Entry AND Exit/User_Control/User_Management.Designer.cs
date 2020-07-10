namespace Director_of_Entry_AND_Exit.User_Control
{
    partial class User_Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonDelet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.UPdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Active = false;
            this.ButtonAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAdd.BorderRadius = 0;
            this.ButtonAdd.ButtonText = "اضافه مستخدم جديد";
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonAdd.Iconimage = null;
            this.ButtonAdd.Iconimage_right = null;
            this.ButtonAdd.Iconimage_right_Selected = null;
            this.ButtonAdd.Iconimage_Selected = null;
            this.ButtonAdd.IconMarginLeft = 0;
            this.ButtonAdd.IconMarginRight = 0;
            this.ButtonAdd.IconRightVisible = true;
            this.ButtonAdd.IconRightZoom = 0D;
            this.ButtonAdd.IconVisible = true;
            this.ButtonAdd.IconZoom = 90D;
            this.ButtonAdd.IsTab = false;
            this.ButtonAdd.Location = new System.Drawing.Point(589, 459);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ButtonAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonAdd.selected = false;
            this.ButtonAdd.Size = new System.Drawing.Size(128, 38);
            this.ButtonAdd.TabIndex = 11;
            this.ButtonAdd.Text = "اضافه مستخدم جديد";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonAdd.Textcolor = System.Drawing.Color.White;
            this.ButtonAdd.TextFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelet
            // 
            this.ButtonDelet.Active = false;
            this.ButtonDelet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonDelet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonDelet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonDelet.BorderRadius = 0;
            this.ButtonDelet.ButtonText = "حذف المحدد";
            this.ButtonDelet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelet.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonDelet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelet.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonDelet.Iconimage = null;
            this.ButtonDelet.Iconimage_right = null;
            this.ButtonDelet.Iconimage_right_Selected = null;
            this.ButtonDelet.Iconimage_Selected = null;
            this.ButtonDelet.IconMarginLeft = 0;
            this.ButtonDelet.IconMarginRight = 0;
            this.ButtonDelet.IconRightVisible = true;
            this.ButtonDelet.IconRightZoom = 0D;
            this.ButtonDelet.IconVisible = true;
            this.ButtonDelet.IconZoom = 90D;
            this.ButtonDelet.IsTab = false;
            this.ButtonDelet.Location = new System.Drawing.Point(321, 459);
            this.ButtonDelet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonDelet.Name = "ButtonDelet";
            this.ButtonDelet.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonDelet.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ButtonDelet.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonDelet.selected = false;
            this.ButtonDelet.Size = new System.Drawing.Size(128, 38);
            this.ButtonDelet.TabIndex = 10;
            this.ButtonDelet.Text = "حذف المحدد";
            this.ButtonDelet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDelet.Textcolor = System.Drawing.Color.White;
            this.ButtonDelet.TextFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelet.Click += new System.EventHandler(this.ButtonDelet_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(223, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(449, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(701, 44);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(27, 13);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "بحث";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "تعديل المحدد";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(455, 459);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(128, 38);
            this.bunifuFlatButton1.TabIndex = 12;
            this.bunifuFlatButton1.Text = "تعديل المحدد";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // UPdate
            // 
            this.UPdate.Active = false;
            this.UPdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.UPdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.UPdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UPdate.BorderRadius = 0;
            this.UPdate.ButtonText = "تحديث";
            this.UPdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UPdate.DisabledColor = System.Drawing.Color.Gray;
            this.UPdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPdate.Iconcolor = System.Drawing.Color.Transparent;
            this.UPdate.Iconimage = null;
            this.UPdate.Iconimage_right = null;
            this.UPdate.Iconimage_right_Selected = null;
            this.UPdate.Iconimage_Selected = null;
            this.UPdate.IconMarginLeft = 0;
            this.UPdate.IconMarginRight = 0;
            this.UPdate.IconRightVisible = true;
            this.UPdate.IconRightZoom = 0D;
            this.UPdate.IconVisible = true;
            this.UPdate.IconZoom = 90D;
            this.UPdate.IsTab = false;
            this.UPdate.Location = new System.Drawing.Point(187, 459);
            this.UPdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UPdate.Name = "UPdate";
            this.UPdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.UPdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.UPdate.OnHoverTextColor = System.Drawing.Color.White;
            this.UPdate.selected = false;
            this.UPdate.Size = new System.Drawing.Size(128, 38);
            this.UPdate.TabIndex = 114;
            this.UPdate.Text = "تحديث";
            this.UPdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UPdate.Textcolor = System.Drawing.Color.White;
            this.UPdate.TextFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPdate.Click += new System.EventHandler(this.UPdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(37, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(827, 359);
            this.dataGridView1.TabIndex = 115;
            // 
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UPdate);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonDelet);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "User_Management";
            this.Size = new System.Drawing.Size(900, 527);
            this.Load += new System.EventHandler(this.User_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton ButtonAdd;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonDelet;
        private System.Windows.Forms.TextBox txtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton UPdate;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
    }
}
