
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
            this.deletepersonalbtn = new System.Windows.Forms.Button();
            this.updatepersonalbtn = new System.Windows.Forms.Button();
            this.addpersonalbtn = new System.Windows.Forms.Button();
            this.RefreshPersonalbtn = new System.Windows.Forms.Button();
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
            this.label3.Location = new System.Drawing.Point(58, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Personal Telephone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Postcode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "City:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Address Line 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(329, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Address Line 1:";
            // 
            // personalfnametxb
            // 
            this.personalfnametxb.Location = new System.Drawing.Point(131, 80);
            this.personalfnametxb.Name = "personalfnametxb";
            this.personalfnametxb.Size = new System.Drawing.Size(192, 23);
            this.personalfnametxb.TabIndex = 14;
            // 
            // personallnametxb
            // 
            this.personallnametxb.Location = new System.Drawing.Point(131, 113);
            this.personallnametxb.Name = "personallnametxb";
            this.personallnametxb.Size = new System.Drawing.Size(192, 23);
            this.personallnametxb.TabIndex = 15;
            // 
            // personalphonetxb
            // 
            this.personalphonetxb.Location = new System.Drawing.Point(131, 142);
            this.personalphonetxb.Name = "personalphonetxb";
            this.personalphonetxb.Size = new System.Drawing.Size(192, 23);
            this.personalphonetxb.TabIndex = 16;
            // 
            // personalemailtxb
            // 
            this.personalemailtxb.Location = new System.Drawing.Point(131, 170);
            this.personalemailtxb.Name = "personalemailtxb";
            this.personalemailtxb.Size = new System.Drawing.Size(192, 23);
            this.personalemailtxb.TabIndex = 17;
            // 
            // personaladdrline1txb
            // 
            this.personaladdrline1txb.Location = new System.Drawing.Point(421, 77);
            this.personaladdrline1txb.Name = "personaladdrline1txb";
            this.personaladdrline1txb.Size = new System.Drawing.Size(192, 23);
            this.personaladdrline1txb.TabIndex = 18;
            // 
            // personaladdrline2txb
            // 
            this.personaladdrline2txb.Location = new System.Drawing.Point(421, 110);
            this.personaladdrline2txb.Name = "personaladdrline2txb";
            this.personaladdrline2txb.Size = new System.Drawing.Size(192, 23);
            this.personaladdrline2txb.TabIndex = 19;
            // 
            // personalcitytxb
            // 
            this.personalcitytxb.Location = new System.Drawing.Point(421, 142);
            this.personalcitytxb.Name = "personalcitytxb";
            this.personalcitytxb.Size = new System.Drawing.Size(192, 23);
            this.personalcitytxb.TabIndex = 20;
            // 
            // personalpostcodetxb
            // 
            this.personalpostcodetxb.Location = new System.Drawing.Point(421, 170);
            this.personalpostcodetxb.Name = "personalpostcodetxb";
            this.personalpostcodetxb.Size = new System.Drawing.Size(192, 23);
            this.personalpostcodetxb.TabIndex = 21;
            // 
            // deletepersonalbtn
            // 
            this.deletepersonalbtn.Location = new System.Drawing.Point(638, 142);
            this.deletepersonalbtn.Name = "deletepersonalbtn";
            this.deletepersonalbtn.Size = new System.Drawing.Size(150, 23);
            this.deletepersonalbtn.TabIndex = 43;
            this.deletepersonalbtn.Text = "Delete Selected Contact";
            this.deletepersonalbtn.UseVisualStyleBackColor = true;
            this.deletepersonalbtn.Click += new System.EventHandler(this.deletepersonalbtn_Click);
            // 
            // updatepersonalbtn
            // 
            this.updatepersonalbtn.Location = new System.Drawing.Point(638, 110);
            this.updatepersonalbtn.Name = "updatepersonalbtn";
            this.updatepersonalbtn.Size = new System.Drawing.Size(150, 23);
            this.updatepersonalbtn.TabIndex = 42;
            this.updatepersonalbtn.Text = "Update Selected Contact";
            this.updatepersonalbtn.UseVisualStyleBackColor = true;
            this.updatepersonalbtn.Click += new System.EventHandler(this.updatepersonalbtn_Click);
            // 
            // addpersonalbtn
            // 
            this.addpersonalbtn.Location = new System.Drawing.Point(638, 77);
            this.addpersonalbtn.Name = "addpersonalbtn";
            this.addpersonalbtn.Size = new System.Drawing.Size(150, 23);
            this.addpersonalbtn.TabIndex = 41;
            this.addpersonalbtn.Text = "Add New Contact";
            this.addpersonalbtn.UseVisualStyleBackColor = true;
            this.addpersonalbtn.Click += new System.EventHandler(this.addpersonalbtn_Click);
            // 
            // RefreshPersonalbtn
            // 
            this.RefreshPersonalbtn.Location = new System.Drawing.Point(713, 174);
            this.RefreshPersonalbtn.Name = "RefreshPersonalbtn";
            this.RefreshPersonalbtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshPersonalbtn.TabIndex = 44;
            this.RefreshPersonalbtn.Text = "Refresh";
            this.RefreshPersonalbtn.UseVisualStyleBackColor = true;
            this.RefreshPersonalbtn.Click += new System.EventHandler(this.RefreshPersonalbtn_Click);
            // 
            // PersonalEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RefreshPersonalbtn);
            this.Controls.Add(this.deletepersonalbtn);
            this.Controls.Add(this.updatepersonalbtn);
            this.Controls.Add(this.addpersonalbtn);
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
        private System.Windows.Forms.Button deletepersonalbtn;
        private System.Windows.Forms.Button updatepersonalbtn;
        private System.Windows.Forms.Button addpersonalbtn;
        private System.Windows.Forms.Button RefreshPersonalbtn;
    }
}