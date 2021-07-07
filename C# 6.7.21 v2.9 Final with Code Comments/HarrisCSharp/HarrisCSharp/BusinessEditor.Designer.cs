﻿
namespace HarrisCSharp
{
    partial class BusinessEditor
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
            this.businessdgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.businesspostcodetxb = new System.Windows.Forms.TextBox();
            this.businesscitytxb = new System.Windows.Forms.TextBox();
            this.businessaddrline2txb = new System.Windows.Forms.TextBox();
            this.businessaddrline1txb = new System.Windows.Forms.TextBox();
            this.businessemailtxb = new System.Windows.Forms.TextBox();
            this.businessphonetxb = new System.Windows.Forms.TextBox();
            this.businesslnametxb = new System.Windows.Forms.TextBox();
            this.businessfnametxb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.savenewbusinessbtn = new System.Windows.Forms.Button();
            this.updateselectedbusinessbtn = new System.Windows.Forms.Button();
            this.deleteselectedbusinessbtn = new System.Windows.Forms.Button();
            this.refreshbusinessbtn = new System.Windows.Forms.Button();
            this.addnewbusinessbtn = new System.Windows.Forms.Button();
            this.saveselectedbusinessbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.statuslbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.businessdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // businessdgv
            // 
            this.businessdgv.AllowUserToResizeColumns = false;
            this.businessdgv.AllowUserToResizeRows = false;
            this.businessdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessdgv.Location = new System.Drawing.Point(12, 203);
            this.businessdgv.Name = "businessdgv";
            this.businessdgv.ReadOnly = true;
            this.businessdgv.RowTemplate.Height = 25;
            this.businessdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.businessdgv.Size = new System.Drawing.Size(776, 235);
            this.businessdgv.TabIndex = 1;
            this.businessdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.businessdgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Harris and Sons Consulting LTD.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(342, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Business Contacts";
            // 
            // businesspostcodetxb
            // 
            this.businesspostcodetxb.Enabled = false;
            this.businesspostcodetxb.Location = new System.Drawing.Point(407, 161);
            this.businesspostcodetxb.Name = "businesspostcodetxb";
            this.businesspostcodetxb.Size = new System.Drawing.Size(180, 23);
            this.businesspostcodetxb.TabIndex = 37;
            // 
            // businesscitytxb
            // 
            this.businesscitytxb.Enabled = false;
            this.businesscitytxb.Location = new System.Drawing.Point(407, 133);
            this.businesscitytxb.Name = "businesscitytxb";
            this.businesscitytxb.Size = new System.Drawing.Size(180, 23);
            this.businesscitytxb.TabIndex = 36;
            // 
            // businessaddrline2txb
            // 
            this.businessaddrline2txb.Enabled = false;
            this.businessaddrline2txb.Location = new System.Drawing.Point(407, 101);
            this.businessaddrline2txb.Name = "businessaddrline2txb";
            this.businessaddrline2txb.Size = new System.Drawing.Size(180, 23);
            this.businessaddrline2txb.TabIndex = 35;
            // 
            // businessaddrline1txb
            // 
            this.businessaddrline1txb.Enabled = false;
            this.businessaddrline1txb.Location = new System.Drawing.Point(407, 68);
            this.businessaddrline1txb.Name = "businessaddrline1txb";
            this.businessaddrline1txb.Size = new System.Drawing.Size(180, 23);
            this.businessaddrline1txb.TabIndex = 34;
            // 
            // businessemailtxb
            // 
            this.businessemailtxb.Enabled = false;
            this.businessemailtxb.Location = new System.Drawing.Point(117, 161);
            this.businessemailtxb.Name = "businessemailtxb";
            this.businessemailtxb.Size = new System.Drawing.Size(192, 23);
            this.businessemailtxb.TabIndex = 33;
            // 
            // businessphonetxb
            // 
            this.businessphonetxb.Enabled = false;
            this.businessphonetxb.Location = new System.Drawing.Point(117, 133);
            this.businessphonetxb.Name = "businessphonetxb";
            this.businessphonetxb.Size = new System.Drawing.Size(192, 23);
            this.businessphonetxb.TabIndex = 32;
            // 
            // businesslnametxb
            // 
            this.businesslnametxb.Enabled = false;
            this.businesslnametxb.Location = new System.Drawing.Point(117, 104);
            this.businesslnametxb.Name = "businesslnametxb";
            this.businesslnametxb.Size = new System.Drawing.Size(192, 23);
            this.businesslnametxb.TabIndex = 31;
            // 
            // businessfnametxb
            // 
            this.businessfnametxb.Enabled = false;
            this.businessfnametxb.Location = new System.Drawing.Point(117, 71);
            this.businessfnametxb.Name = "businessfnametxb";
            this.businessfnametxb.Size = new System.Drawing.Size(192, 23);
            this.businessfnametxb.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Postcode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "City:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Address Line 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Address Line 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Business Telephone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "First Name:";
            // 
            // savenewbusinessbtn
            // 
            this.savenewbusinessbtn.Enabled = false;
            this.savenewbusinessbtn.Location = new System.Drawing.Point(713, 61);
            this.savenewbusinessbtn.Name = "savenewbusinessbtn";
            this.savenewbusinessbtn.Size = new System.Drawing.Size(75, 23);
            this.savenewbusinessbtn.TabIndex = 38;
            this.savenewbusinessbtn.Text = "Save New";
            this.savenewbusinessbtn.UseVisualStyleBackColor = true;
            this.savenewbusinessbtn.Click += new System.EventHandler(this.addbusinessbtn_Click);
            // 
            // updateselectedbusinessbtn
            // 
            this.updateselectedbusinessbtn.Location = new System.Drawing.Point(603, 32);
            this.updateselectedbusinessbtn.Name = "updateselectedbusinessbtn";
            this.updateselectedbusinessbtn.Size = new System.Drawing.Size(104, 23);
            this.updateselectedbusinessbtn.TabIndex = 39;
            this.updateselectedbusinessbtn.Text = "Update Selected";
            this.updateselectedbusinessbtn.UseVisualStyleBackColor = true;
            this.updateselectedbusinessbtn.Click += new System.EventHandler(this.updatebusinessbtn_Click);
            // 
            // deleteselectedbusinessbtn
            // 
            this.deleteselectedbusinessbtn.Location = new System.Drawing.Point(603, 90);
            this.deleteselectedbusinessbtn.Name = "deleteselectedbusinessbtn";
            this.deleteselectedbusinessbtn.Size = new System.Drawing.Size(104, 23);
            this.deleteselectedbusinessbtn.TabIndex = 40;
            this.deleteselectedbusinessbtn.Text = "Delete Selected";
            this.deleteselectedbusinessbtn.UseVisualStyleBackColor = true;
            this.deleteselectedbusinessbtn.Click += new System.EventHandler(this.deletebusinessbtn_Click);
            // 
            // refreshbusinessbtn
            // 
            this.refreshbusinessbtn.Location = new System.Drawing.Point(713, 90);
            this.refreshbusinessbtn.Name = "refreshbusinessbtn";
            this.refreshbusinessbtn.Size = new System.Drawing.Size(75, 23);
            this.refreshbusinessbtn.TabIndex = 41;
            this.refreshbusinessbtn.Text = "Refresh";
            this.refreshbusinessbtn.UseVisualStyleBackColor = true;
            this.refreshbusinessbtn.Click += new System.EventHandler(this.RefreshBusinessbtn_Click);
            // 
            // addnewbusinessbtn
            // 
            this.addnewbusinessbtn.Location = new System.Drawing.Point(713, 32);
            this.addnewbusinessbtn.Name = "addnewbusinessbtn";
            this.addnewbusinessbtn.Size = new System.Drawing.Size(75, 23);
            this.addnewbusinessbtn.TabIndex = 42;
            this.addnewbusinessbtn.Text = "Add New";
            this.addnewbusinessbtn.UseVisualStyleBackColor = true;
            this.addnewbusinessbtn.Click += new System.EventHandler(this.addnewbusinessbtn_Click);
            // 
            // saveselectedbusinessbtn
            // 
            this.saveselectedbusinessbtn.Enabled = false;
            this.saveselectedbusinessbtn.Location = new System.Drawing.Point(603, 61);
            this.saveselectedbusinessbtn.Name = "saveselectedbusinessbtn";
            this.saveselectedbusinessbtn.Size = new System.Drawing.Size(104, 23);
            this.saveselectedbusinessbtn.TabIndex = 48;
            this.saveselectedbusinessbtn.Text = "Save Selected";
            this.saveselectedbusinessbtn.UseVisualStyleBackColor = true;
            this.saveselectedbusinessbtn.Click += new System.EventHandler(this.saveselectedbusinessbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Enabled = false;
            this.cancelbtn.Location = new System.Drawing.Point(673, 119);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 49;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Location = new System.Drawing.Point(603, 9);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(12, 15);
            this.statuslbl.TabIndex = 50;
            this.statuslbl.Text = "-";
            // 
            // BusinessEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.saveselectedbusinessbtn);
            this.Controls.Add(this.addnewbusinessbtn);
            this.Controls.Add(this.refreshbusinessbtn);
            this.Controls.Add(this.deleteselectedbusinessbtn);
            this.Controls.Add(this.updateselectedbusinessbtn);
            this.Controls.Add(this.savenewbusinessbtn);
            this.Controls.Add(this.businesspostcodetxb);
            this.Controls.Add(this.businesscitytxb);
            this.Controls.Add(this.businessaddrline2txb);
            this.Controls.Add(this.businessaddrline1txb);
            this.Controls.Add(this.businessemailtxb);
            this.Controls.Add(this.businessphonetxb);
            this.Controls.Add(this.businesslnametxb);
            this.Controls.Add(this.businessfnametxb);
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
            this.Controls.Add(this.businessdgv);
            this.Name = "BusinessEditor";
            this.Text = "BusinessContacts";
            this.Load += new System.EventHandler(this.BusinessEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.businessdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView businessdgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox businesspostcodetxb;
        private System.Windows.Forms.TextBox businesscitytxb;
        private System.Windows.Forms.TextBox businessaddrline2txb;
        private System.Windows.Forms.TextBox businessaddrline1txb;
        private System.Windows.Forms.TextBox businessemailtxb;
        private System.Windows.Forms.TextBox businessphonetxb;
        private System.Windows.Forms.TextBox businesslnametxb;
        private System.Windows.Forms.TextBox businessfnametxb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button savenewbusinessbtn;
        private System.Windows.Forms.Button updateselectedbusinessbtn;
        private System.Windows.Forms.Button deleteselectedbusinessbtn;
        private System.Windows.Forms.Button refreshbusinessbtn;
        private System.Windows.Forms.Button addnewbusinessbtn;
        private System.Windows.Forms.Button saveselectedbusinessbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label statuslbl;
    }
}