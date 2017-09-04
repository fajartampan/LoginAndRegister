namespace LoginAndRegister
{
    partial class Form_Registerr
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
            this.btfullname = new System.Windows.Forms.TextBox();
            this.btuser = new System.Windows.Forms.TextBox();
            this.btpass = new System.Windows.Forms.TextBox();
            this.btrepass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btregister = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btfullname
            // 
            this.btfullname.Location = new System.Drawing.Point(135, 12);
            this.btfullname.Name = "btfullname";
            this.btfullname.Size = new System.Drawing.Size(100, 20);
            this.btfullname.TabIndex = 0;
            // 
            // btuser
            // 
            this.btuser.Location = new System.Drawing.Point(135, 38);
            this.btuser.Name = "btuser";
            this.btuser.Size = new System.Drawing.Size(100, 20);
            this.btuser.TabIndex = 1;
            // 
            // btpass
            // 
            this.btpass.Location = new System.Drawing.Point(135, 64);
            this.btpass.Name = "btpass";
            this.btpass.Size = new System.Drawing.Size(100, 20);
            this.btpass.TabIndex = 2;
            // 
            // btrepass
            // 
            this.btrepass.Location = new System.Drawing.Point(135, 90);
            this.btrepass.Name = "btrepass";
            this.btrepass.Size = new System.Drawing.Size(100, 20);
            this.btrepass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repeat Pass";
            // 
            // btregister
            // 
            this.btregister.Location = new System.Drawing.Point(62, 148);
            this.btregister.Name = "btregister";
            this.btregister.Size = new System.Drawing.Size(75, 23);
            this.btregister.TabIndex = 8;
            this.btregister.Text = "Register";
            this.btregister.UseVisualStyleBackColor = true;
            this.btregister.Click += new System.EventHandler(this.btregister_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(143, 148);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(75, 23);
            this.btcancel.TabIndex = 9;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(135, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Lihat Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form_Registerr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 324);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btregister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btrepass);
            this.Controls.Add(this.btpass);
            this.Controls.Add(this.btuser);
            this.Controls.Add(this.btfullname);
            this.Name = "Form_Registerr";
            this.Text = "Form_Registerr";
            this.Load += new System.EventHandler(this.Form_Registerr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox btfullname;
        private System.Windows.Forms.TextBox btuser;
        private System.Windows.Forms.TextBox btpass;
        private System.Windows.Forms.TextBox btrepass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btregister;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}