namespace Director_of_Entry_AND_Exit.Presentation_Layer
{
    partial class Form_User_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_User_list));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.StatsTXT = new System.Windows.Forms.ComboBox();
            this.OOK_butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(359, 325);
            this.dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "الحاله";
            // 
            // StatsTXT
            // 
            this.StatsTXT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatsTXT.FormattingEnabled = true;
            this.StatsTXT.Items.AddRange(new object[] {
            "مكافأه",
            "خصم",
            "غياب",
            "تأخير",
            "تنبيه ",
            "أخرى"});
            this.StatsTXT.Location = new System.Drawing.Point(129, 13);
            this.StatsTXT.Name = "StatsTXT";
            this.StatsTXT.Size = new System.Drawing.Size(121, 21);
            this.StatsTXT.TabIndex = 2;
            // 
            // OOK_butt
            // 
            this.OOK_butt.Location = new System.Drawing.Point(153, 399);
            this.OOK_butt.Name = "OOK_butt";
            this.OOK_butt.Size = new System.Drawing.Size(75, 23);
            this.OOK_butt.TabIndex = 3;
            this.OOK_butt.Text = "موافق";
            this.OOK_butt.UseVisualStyleBackColor = true;
            this.OOK_butt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_User_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 434);
            this.Controls.Add(this.OOK_butt);
            this.Controls.Add(this.StatsTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_User_list";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمه المستخدمين";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OOK_butt;
        public System.Windows.Forms.ComboBox StatsTXT;
    }
}