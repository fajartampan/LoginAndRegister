namespace LoginAndRegister
{
    partial class Registerrrr
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
            this.tbfullname = new System.Windows.Forms.TextBox();
            this.tbrepass = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.btregis = new System.Windows.Forms.Button();
            this.btcancell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbfullname
            // 
            this.tbfullname.Location = new System.Drawing.Point(139, 36);
            this.tbfullname.Name = "tbfullname";
            this.tbfullname.Size = new System.Drawing.Size(100, 20);
            this.tbfullname.TabIndex = 0;
            // 
            // tbrepass
            // 
            this.tbrepass.Location = new System.Drawing.Point(139, 114);
            this.tbrepass.Name = "tbrepass";
            this.tbrepass.Size = new System.Drawing.Size(100, 20);
            this.tbrepass.TabIndex = 1;
            this.tbrepass.TextChanged += new System.EventHandler(this.tbrepass_TextChanged);
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(139, 88);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(100, 20);
            this.tbpass.TabIndex = 2;
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(139, 62);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(100, 20);
            this.tbuser.TabIndex = 3;
            // 
            // btregis
            // 
            this.btregis.Location = new System.Drawing.Point(77, 170);
            this.btregis.Name = "btregis";
            this.btregis.Size = new System.Drawing.Size(75, 23);
            this.btregis.TabIndex = 4;
            this.btregis.Text = "Register";
            this.btregis.UseVisualStyleBackColor = true;
            this.btregis.Click += new System.EventHandler(this.btregis_Click);
            // 
            // btcancell
            // 
            this.btcancell.Location = new System.Drawing.Point(183, 169);
            this.btcancell.Name = "btcancell";
            this.btcancell.Size = new System.Drawing.Size(75, 23);
            this.btcancell.TabIndex = 5;
            this.btcancell.Text = "Cancel";
            this.btcancell.UseVisualStyleBackColor = true;
            this.btcancell.Click += new System.EventHandler(this.btcancell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Repeat Pass";
            // 
            // Registerrrr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btcancell);
            this.Controls.Add(this.btregis);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbrepass);
            this.Controls.Add(this.tbfullname);
            this.Name = "Registerrrr";
            this.Text = "Registerrrr";
            this.Load += new System.EventHandler(this.Registerrrr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbfullname;
        private System.Windows.Forms.TextBox tbrepass;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.Button btregis;
        private System.Windows.Forms.Button btcancell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}