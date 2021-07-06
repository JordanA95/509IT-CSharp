
namespace HarrisCSharp
{
    partial class PersonalEditor
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
            this.personaldgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.personalfnametxb = new System.Windows.Forms.TextBox();
            this.personallnametxb = new System.Windows.Forms.TextBox();
            this.personalphonetxb = new System.Windows.Forms.TextBox();
            this.personalemailtxb = new System.Windows.Forms.TextBox();
            this.personaladdrline1txb = new System.Windows.Forms.TextBox();
            this.personaladdrline2txb = new System.Windows.Forms.TextBox();
            this.personalcitytxb = new System.Windows.Forms.TextBox();
            this.personalpostcodetxb = new System.Windows.Forms.TextBox();
            this.deleteselectedpersonalbtn = new System.Windows.Forms.Button();
            this.updateselectedpersonalbtn = new System.Windows.Forms.Button();
            this.savenewpersonalbtn = new System.Windows.Forms.Button();
            this.refreshpersonalbtn = new System.Windows.Forms.Button();
            this.addnewpersonalbtn = new System.Windows.Forms.Button();
            this.saveselectedpersonaldbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personaldgv)).BeginInit();
            this.SuspendLayout();
            // 
            // personaldgv
            // 
            this.personaldgv.AllowUserToResizeColumns = false;
            this.personaldgv.AllowUserToResizeRows = false;
            this.personaldgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personaldgv.Location = new System.Drawing.Point(12, 203);
            this.personaldgv.Name = "personaldgv";
            this.personaldgv.ReadOnly = true;
            this.personaldgv.RowTemplate.Height = 25;
            this.personaldgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personaldgv.Size = new System.Drawing.Size(776, 235);
            this.personaldgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Harris and Sons Consulting LTD.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(349, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Personal Contacts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Personal Telephone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Postcode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "City:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Address Line 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Address Line 1:";
            // 
            // personalfnametxb
            // 
            this.personalfnametxb.Enabled = false;
            this.personalfnametxb.Location = new System.Drawing.Point(120, 70);
            this.personalfnametxb.Name = "personalfnametxb";
            this.personalfnametxb.Size = new System.Drawing.Size(192, 23);
            this.personalfnametxb.TabIndex = 14;
            // 
            // personallnametxb
            // 
            this.personallnametxb.Enabled = false;
            this.personallnametxb.Location = new System.Drawing.Point(120, 103);
            this.personallnametxb.Name = "personallnametxb";
            this.personallnametxb.Size = new System.Drawing.Size(192, 23);
            this.personallnametxb.TabIndex = 15;
            // 
            // personalphonetxb
            // 
            this.personalphonetxb.Enabled = false;
            this.personalphonetxb.Location = new System.Drawing.Point(120, 132);
            this.personalphonetxb.Name = "personalphonetxb";
            this.personalphonetxb.Size = new System.Drawing.Size(192, 23);
            this.personalphonetxb.TabIndex = 16;
            // 
            // personalemailtxb
            // 
            this.personalemailtxb.Enabled = false;
            this.personalemailtxb.Location = new System.Drawing.Point(120, 160);
            this.personalemailtxb.Name = "personalemailtxb";
            this.personalemailtxb.Size = new System.Drawing.Size(192, 23);
            this.personalemailtxb.TabIndex = 17;
            // 
            // personaladdrline1txb
            // 
            this.personaladdrline1txb.Enabled = false;
            this.personaladdrline1txb.Location = new System.Drawing.Point(410, 67);
            this.personaladdrline1txb.Name = "personaladdrline1txb";
            this.personaladdrline1txb.Size = new System.Drawing.Size(182, 23);
            this.personaladdrline1txb.TabIndex = 18;
            // 
            // personaladdrline2txb
            // 
            this.personaladdrline2txb.Enabled = false;
            this.personaladdrline2txb.Location = new System.Drawing.Point(410, 100);
            this.personaladdrline2txb.Name = "personaladdrline2txb";
            this.personaladdrline2txb.Size = new System.Drawing.Size(182, 23);
            this.personaladdrline2txb.TabIndex = 19;
            // 
            // personalcitytxb
            // 
            this.personalcitytxb.Enabled = false;
            this.personalcitytxb.Location = new System.Drawing.Point(410, 132);
            this.personalcitytxb.Name = "personalcitytxb";
            this.personalcitytxb.Size = new System.Drawing.Size(182, 23);
            this.personalcitytxb.TabIndex = 20;
            // 
            // personalpostcodetxb
            // 
            this.personalpostcodetxb.Enabled = false;
            this.personalpostcodetxb.Location = new System.Drawing.Point(410, 160);
            this.personalpostcodetxb.Name = "personalpostcodetxb";
            this.personalpostcodetxb.Size = new System.Drawing.Size(182, 23);
            this.personalpostcodetxb.TabIndex = 21;
            // 
            // deleteselectedpersonalbtn
            // 
            this.deleteselectedpersonalbtn.Location = new System.Drawing.Point(603, 91);
            this.deleteselectedpersonalbtn.Name = "deleteselectedpersonalbtn";
            this.deleteselectedpersonalbtn.Size = new System.Drawing.Size(104, 23);
            this.deleteselectedpersonalbtn.TabIndex = 43;
            this.deleteselectedpersonalbtn.Text = "Delete Selected";
            this.deleteselectedpersonalbtn.UseVisualStyleBackColor = true;
            this.deleteselectedpersonalbtn.Click += new System.EventHandler(this.deletepersonalbtn_Click);
            // 
            // updateselectedpersonalbtn
            // 
            this.updateselectedpersonalbtn.Location = new System.Drawing.Point(603, 35);
            this.updateselectedpersonalbtn.Name = "updateselectedpersonalbtn";
            this.updateselectedpersonalbtn.Size = new System.Drawing.Size(104, 23);
            this.updateselectedpersonalbtn.TabIndex = 42;
            this.updateselectedpersonalbtn.Text = "Update Selected";
            this.updateselectedpersonalbtn.UseVisualStyleBackColor = true;
            this.updateselectedpersonalbtn.Click += new System.EventHandler(this.updatepersonalbtn_Click);
            // 
            // savenewpersonalbtn
            // 
            this.savenewpersonalbtn.Enabled = false;
            this.savenewpersonalbtn.Location = new System.Drawing.Point(713, 64);
            this.savenewpersonalbtn.Name = "savenewpersonalbtn";
            this.savenewpersonalbtn.Size = new System.Drawing.Size(75, 23);
            this.savenewpersonalbtn.TabIndex = 41;
            this.savenewpersonalbtn.Text = "Save New";
            this.savenewpersonalbtn.UseVisualStyleBackColor = true;
            this.savenewpersonalbtn.Click += new System.EventHandler(this.addpersonalbtn_Click);
            // 
            // refreshpersonalbtn
            // 
            this.refreshpersonalbtn.Location = new System.Drawing.Point(713, 93);
            this.refreshpersonalbtn.Name = "refreshpersonalbtn";
            this.refreshpersonalbtn.Size = new System.Drawing.Size(75, 23);
            this.refreshpersonalbtn.TabIndex = 44;
            this.refreshpersonalbtn.Text = "Refresh";
            this.refreshpersonalbtn.UseVisualStyleBackColor = true;
            this.refreshpersonalbtn.Click += new System.EventHandler(this.RefreshPersonalbtn_Click);
            // 
            // addnewpersonalbtn
            // 
            this.addnewpersonalbtn.Location = new System.Drawing.Point(713, 35);
            this.addnewpersonalbtn.Name = "addnewpersonalbtn";
            this.addnewpersonalbtn.Size = new System.Drawing.Size(75, 23);
            this.addnewpersonalbtn.TabIndex = 45;
            this.addnewpersonalbtn.Text = "Add New";
            this.addnewpersonalbtn.UseVisualStyleBackColor = true;
            this.addnewpersonalbtn.Click += new System.EventHandler(this.addnewpersonalbtn_Click);
            // 
            // saveselectedpersonaldbtn
            // 
            this.saveselectedpersonaldbtn.Enabled = false;
            this.saveselectedpersonaldbtn.Location = new System.Drawing.Point(603, 62);
            this.saveselectedpersonaldbtn.Name = "saveselectedpersonaldbtn";
            this.saveselectedpersonaldbtn.Size = new System.Drawing.Size(104, 23);
            this.saveselectedpersonaldbtn.TabIndex = 47;
            this.saveselectedpersonaldbtn.Text = "Save Selected";
            this.saveselectedpersonaldbtn.UseVisualStyleBackColor = true;
            this.saveselectedpersonaldbtn.Click += new System.EventHandler(this.saveselectedpersonaldbtn_Click);
            // 
            // PersonalEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveselectedpersonaldbtn);
            this.Controls.Add(this.addnewpersonalbtn);
            this.Controls.Add(this.refreshpersonalbtn);
            this.Controls.Add(this.deleteselectedpersonalbtn);
            this.Controls.Add(this.updateselectedpersonalbtn);
            this.Controls.Add(this.savenewpersonalbtn);
            this.Controls.Add(this.personalpostcodetxb);
            this.Controls.Add(this.personalcitytxb);
            this.Controls.Add(this.personaladdrline2txb);
            this.Controls.Add(this.personaladdrline1txb);
            this.Controls.Add(this.personalemailtxb);
            this.Controls.Add(this.personalphonetxb);
            this.Controls.Add(this.personallnametxb);
            this.Controls.Add(this.personalfnametxb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personaldgv);
            this.Name = "PersonalEditor";
            this.Text = "PersonalContacts";
            this.Load += new System.EventHandler(this.PersonalEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personaldgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView personaldgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox personalfnametxb;
        private System.Windows.Forms.TextBox personallnametxb;
        private System.Windows.Forms.TextBox personalphonetxb;
        private System.Windows.Forms.TextBox personalemailtxb;
        private System.Windows.Forms.TextBox personaladdrline1txb;
        private System.Windows.Forms.TextBox personaladdrline2txb;
        private System.Windows.Forms.TextBox personalcitytxb;
        private System.Windows.Forms.TextBox personalpostcodetxb;
        private System.Windows.Forms.Button deleteselectedpersonalbtn;
        private System.Windows.Forms.Button updateselectedpersonalbtn;
        private System.Windows.Forms.Button savenewpersonalbtn;
        private System.Windows.Forms.Button refreshpersonalbtn;
        private System.Windows.Forms.Button addnewpersonalbtn;
        private System.Windows.Forms.Button saveselectedpersonaldbtn;
    }
}