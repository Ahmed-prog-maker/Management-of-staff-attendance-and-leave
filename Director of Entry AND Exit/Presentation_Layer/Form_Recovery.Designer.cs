namespace Director_of_Entry_AND_Exit.Presentation_Layer
{
    partial class Form_Recovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Recovery));
            this.label1 = new System.Windows.Forms.Label();
            this.btbCansel = new System.Windows.Forms.Button();
            this.btnReco = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "قم بتحديد مسار النسخه الاحتياطيه";
            // 
            // btbCansel
            // 
            this.btbCansel.Location = new System.Drawing.Point(279, 113);
            this.btbCansel.Name = "btbCansel";
            this.btbCansel.Size = new System.Drawing.Size(75, 32);
            this.btbCansel.TabIndex = 8;
            this.btbCansel.Text = "إلغاء";
            this.btbCansel.UseVisualStyleBackColor = true;
            this.btbCansel.Click += new System.EventHandler(this.btbCansel_Click);
            // 
            // btnReco
            // 
            this.btnReco.Enabled = false;
            this.btnReco.Location = new System.Drawing.Point(95, 113);
            this.btnReco.Name = "btnReco";
            this.btnReco.Size = new System.Drawing.Size(111, 32);
            this.btnReco.TabIndex = 7;
            this.btnReco.Text = "استرجاع النسخة ";
            this.btnReco.UseVisualStyleBackColor = true;
            this.btnReco.Click += new System.EventHandler(this.btnReco_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(377, 58);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(47, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(39, 59);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(340, 20);
            this.txtFileName.TabIndex = 5;
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // Form_Recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbCansel);
            this.Controls.Add(this.btnReco);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Recovery";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إسترجاع نسخة الاحتياطيه";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbCansel;
        private System.Windows.Forms.Button btnReco;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}