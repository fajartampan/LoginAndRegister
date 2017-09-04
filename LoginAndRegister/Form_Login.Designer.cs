namespace LoginAndRegister
{
    partial class Form_Login
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
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbseepass = new System.Windows.Forms.CheckBox();
            this.btregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(94, 91);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(132, 20);
            this.tbuser.TabIndex = 0;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(94, 117);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(132, 20);
            this.tbpass.TabIndex = 1;
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(23, 177);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 23);
            this.btlogin.TabIndex = 2;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(104, 177);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(75, 23);
            this.btcancel.TabIndex = 3;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // cbseepass
            // 
            this.cbseepass.AutoSize = true;
            this.cbseepass.Location = new System.Drawing.Point(94, 143);
            this.cbseepass.Name = "cbseepass";
            this.cbseepass.Size = new System.Drawing.Size(94, 17);
            this.cbseepass.TabIndex = 6;
            this.cbseepass.Text = "See Password";
            this.cbseepass.UseVisualStyleBackColor = true;
            this.cbseepass.CheckedChanged += new System.EventHandler(this.cbseepass_CheckedChanged);
            // 
            // btregister
            // 
            this.btregister.Location = new System.Drawing.Point(67, 241);
            this.btregister.Name = "btregister";
            this.btregister.Size = new System.Drawing.Size(75, 23);
            this.btregister.TabIndex = 7;
            this.btregister.Text = "Register";
            this.btregister.UseVisualStyleBackColor = true;
            this.btregister.Click += new System.EventHandler(this.btregister_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 327);
            this.Controls.Add(this.btregister);
            this.Controls.Add(this.cbseepass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbuser);
            this.Name = "Form_Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbseepass;
        private System.Windows.Forms.Button btregister;
    }
}

