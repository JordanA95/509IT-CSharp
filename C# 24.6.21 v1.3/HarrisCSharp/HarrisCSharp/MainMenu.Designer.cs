
namespace HarrisCSharp
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.personalbtn = new System.Windows.Forms.Button();
            this.businessbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // personalbtn
            // 
            this.personalbtn.Location = new System.Drawing.Point(47, 203);
            this.personalbtn.Name = "personalbtn";
            this.personalbtn.Size = new System.Drawing.Size(292, 153);
            this.personalbtn.TabIndex = 0;
            this.personalbtn.Text = "Manage Personal Contacts";
            this.personalbtn.UseVisualStyleBackColor = true;
            this.personalbtn.Click += new System.EventHandler(this.personalbtn_Click);
            // 
            // businessbtn
            // 
            this.businessbtn.Location = new System.Drawing.Point(445, 203);
            this.businessbtn.Name = "businessbtn";
            this.businessbtn.Size = new System.Drawing.Size(292, 153);
            this.businessbtn.TabIndex = 1;
            this.businessbtn.Text = "Manage Business Contacts";
            this.businessbtn.UseVisualStyleBackColor = true;
            this.businessbtn.Click += new System.EventHandler(this.businessbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Harris and Sons Consulting LTD.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(262, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contact Management";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.businessbtn);
            this.Controls.Add(this.personalbtn);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button personalbtn;
        private System.Windows.Forms.Button businessbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

