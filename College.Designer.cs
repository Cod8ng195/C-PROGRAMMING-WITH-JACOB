
namespace college_application_form
{
    partial class College
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.cmdAdd_All = new System.Windows.Forms.Button();
            this.cmdRemove_All = new System.Windows.Forms.Button();
            this.cmdFinalize = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 186);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(549, 44);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(189, 186);
            this.listBox2.TabIndex = 1;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Location = new System.Drawing.Point(316, 44);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(149, 31);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemove.Location = new System.Drawing.Point(316, 83);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(149, 31);
            this.cmdRemove.TabIndex = 3;
            this.cmdRemove.Text = "Remove";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmdAdd_All
            // 
            this.cmdAdd_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd_All.Location = new System.Drawing.Point(316, 122);
            this.cmdAdd_All.Name = "cmdAdd_All";
            this.cmdAdd_All.Size = new System.Drawing.Size(149, 31);
            this.cmdAdd_All.TabIndex = 4;
            this.cmdAdd_All.Text = "Add All";
            this.cmdAdd_All.UseVisualStyleBackColor = true;
            this.cmdAdd_All.Click += new System.EventHandler(this.cmdAdd_All_Click);
            // 
            // cmdRemove_All
            // 
            this.cmdRemove_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemove_All.Location = new System.Drawing.Point(316, 161);
            this.cmdRemove_All.Name = "cmdRemove_All";
            this.cmdRemove_All.Size = new System.Drawing.Size(149, 31);
            this.cmdRemove_All.TabIndex = 5;
            this.cmdRemove_All.Text = "Remove All";
            this.cmdRemove_All.UseVisualStyleBackColor = true;
            this.cmdRemove_All.Click += new System.EventHandler(this.cmdRemove_All_Click);
            // 
            // cmdFinalize
            // 
            this.cmdFinalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFinalize.Location = new System.Drawing.Point(316, 198);
            this.cmdFinalize.Name = "cmdFinalize";
            this.cmdFinalize.Size = new System.Drawing.Size(149, 31);
            this.cmdFinalize.TabIndex = 6;
            this.cmdFinalize.Text = "Finalize";
            this.cmdFinalize.UseVisualStyleBackColor = true;
            this.cmdFinalize.Click += new System.EventHandler(this.cmdFinalize_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Available Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(546, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selected Courses";
            // 
            // College
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::college_application_form.Properties.Resources.fbi_wallpapers_logo_hd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdFinalize);
            this.Controls.Add(this.cmdRemove_All);
            this.Controls.Add(this.cmdAdd_All);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "College";
            this.Text = "College";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.Button cmdAdd_All;
        private System.Windows.Forms.Button cmdRemove_All;
        private System.Windows.Forms.Button cmdFinalize;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

