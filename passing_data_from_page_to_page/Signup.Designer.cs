
namespace passing_data_from_page_to_page
{
    partial class Signup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Trans = new System.Windows.Forms.Label();
            this.lblSMS_not = new System.Windows.Forms.Label();
            this.chkTrans = new System.Windows.Forms.CheckBox();
            this.chkReports = new System.Windows.Forms.CheckBox();
            this.chkSMS = new System.Windows.Forms.CheckBox();
            this.cmdSignup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Adress:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(160, 55);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(499, 20);
            this.txtFName.TabIndex = 3;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(160, 99);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(499, 20);
            this.txtLName.TabIndex = 4;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(160, 153);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(499, 20);
            this.txtEmailAddress.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Trans);
            this.groupBox1.Controls.Add(this.lblSMS_not);
            this.groupBox1.Controls.Add(this.chkTrans);
            this.groupBox1.Controls.Add(this.chkReports);
            this.groupBox1.Controls.Add(this.chkSMS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 144);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // lbl_Trans
            // 
            this.lbl_Trans.AutoSize = true;
            this.lbl_Trans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Trans.Location = new System.Drawing.Point(346, 101);
            this.lbl_Trans.Name = "lbl_Trans";
            this.lbl_Trans.Size = new System.Drawing.Size(48, 16);
            this.lbl_Trans.TabIndex = 4;
            this.lbl_Trans.Text = "..........";
            // 
            // lblSMS_not
            // 
            this.lblSMS_not.AutoSize = true;
            this.lblSMS_not.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSMS_not.Location = new System.Drawing.Point(355, 30);
            this.lblSMS_not.Name = "lblSMS_not";
            this.lblSMS_not.Size = new System.Drawing.Size(52, 16);
            this.lblSMS_not.TabIndex = 3;
            this.lblSMS_not.Text = "...........";
            this.lblSMS_not.Click += new System.EventHandler(this.lblSMS_not_Click);
            // 
            // chkTrans
            // 
            this.chkTrans.AutoSize = true;
            this.chkTrans.Location = new System.Drawing.Point(164, 101);
            this.chkTrans.Name = "chkTrans";
            this.chkTrans.Size = new System.Drawing.Size(168, 20);
            this.chkTrans.TabIndex = 2;
            this.chkTrans.Text = "Transaction Reports";
            this.chkTrans.UseVisualStyleBackColor = true;
            this.chkTrans.CheckedChanged += new System.EventHandler(this.chkTrans_CheckedChanged);
            // 
            // chkReports
            // 
            this.chkReports.AutoSize = true;
            this.chkReports.Location = new System.Drawing.Point(164, 66);
            this.chkReports.Name = "chkReports";
            this.chkReports.Size = new System.Drawing.Size(82, 20);
            this.chkReports.TabIndex = 1;
            this.chkReports.Text = "Reports";
            this.chkReports.UseVisualStyleBackColor = true;
            this.chkReports.CheckedChanged += new System.EventHandler(this.chkReports_CheckedChanged);
            // 
            // chkSMS
            // 
            this.chkSMS.AutoSize = true;
            this.chkSMS.Location = new System.Drawing.Point(164, 30);
            this.chkSMS.Name = "chkSMS";
            this.chkSMS.Size = new System.Drawing.Size(149, 20);
            this.chkSMS.TabIndex = 0;
            this.chkSMS.Text = "SMS Notifications";
            this.chkSMS.UseVisualStyleBackColor = true;
            this.chkSMS.CheckedChanged += new System.EventHandler(this.chkSMS_CheckedChanged);
            // 
            // cmdSignup
            // 
            this.cmdSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSignup.Location = new System.Drawing.Point(576, 405);
            this.cmdSignup.Name = "cmdSignup";
            this.cmdSignup.Size = new System.Drawing.Size(95, 33);
            this.cmdSignup.TabIndex = 7;
            this.cmdSignup.Text = "SIGN";
            this.cmdSignup.UseVisualStyleBackColor = true;
            this.cmdSignup.Click += new System.EventHandler(this.cmdSignup_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdSignup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Signup";
            this.Text = "signup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkTrans;
        private System.Windows.Forms.CheckBox chkReports;
        private System.Windows.Forms.CheckBox chkSMS;
        private System.Windows.Forms.Button cmdSignup;
        private System.Windows.Forms.Label lbl_Trans;
        private System.Windows.Forms.Label lblSMS_not;
    }
}

