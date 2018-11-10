namespace BusTicketManagement
{
    partial class UserControlSignUpForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSignUpForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ButtonSignIn = new System.Windows.Forms.Button();
            this.CheckBoxAgreement = new System.Windows.Forms.Label();
            this.CheckBoxAgree = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ButtonSignUp = new System.Windows.Forms.Button();
            this.TextBoxEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxPassword2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxYourName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "And Get Amazing Discount!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create An Account Today";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 670);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 139);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TextBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxPassword.HintText = "password";
            this.TextBoxPassword.isPassword = true;
            this.TextBoxPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxPassword.LineThickness = 3;
            this.TextBoxPassword.Location = new System.Drawing.Point(33, 292);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(303, 37);
            this.TextBoxPassword.TabIndex = 12;
            this.TextBoxPassword.Text = "Password";
            this.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxPassword.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // ButtonSignIn
            // 
            this.ButtonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignIn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignIn.ForeColor = System.Drawing.Color.White;
            this.ButtonSignIn.Location = new System.Drawing.Point(27, 582);
            this.ButtonSignIn.Name = "ButtonSignIn";
            this.ButtonSignIn.Size = new System.Drawing.Size(306, 37);
            this.ButtonSignIn.TabIndex = 11;
            this.ButtonSignIn.Text = "Sign In";
            this.ButtonSignIn.UseVisualStyleBackColor = false;
            this.ButtonSignIn.Click += new System.EventHandler(this.button2_Click);
            // 
            // CheckBoxAgreement
            // 
            this.CheckBoxAgreement.AutoSize = true;
            this.CheckBoxAgreement.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxAgreement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CheckBoxAgreement.Location = new System.Drawing.Point(53, 498);
            this.CheckBoxAgreement.Name = "CheckBoxAgreement";
            this.CheckBoxAgreement.Size = new System.Drawing.Size(280, 17);
            this.CheckBoxAgreement.TabIndex = 10;
            this.CheckBoxAgreement.Text = "I agree with the terms and condition";
            // 
            // CheckBoxAgree
            // 
            this.CheckBoxAgree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CheckBoxAgree.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckBoxAgree.Checked = true;
            this.CheckBoxAgree.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CheckBoxAgree.ForeColor = System.Drawing.Color.White;
            this.CheckBoxAgree.Location = new System.Drawing.Point(30, 498);
            this.CheckBoxAgree.Name = "CheckBoxAgree";
            this.CheckBoxAgree.Size = new System.Drawing.Size(20, 20);
            this.CheckBoxAgree.TabIndex = 9;
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignUp.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignUp.ForeColor = System.Drawing.Color.White;
            this.ButtonSignUp.Location = new System.Drawing.Point(27, 539);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(306, 37);
            this.ButtonSignUp.TabIndex = 3;
            this.ButtonSignUp.Text = "Sign Up";
            this.ButtonSignUp.UseVisualStyleBackColor = false;
            this.ButtonSignUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TextBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxEmail.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxEmail.HintText = "Email ";
            this.TextBoxEmail.isPassword = false;
            this.TextBoxEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxEmail.LineThickness = 3;
            this.TextBoxEmail.Location = new System.Drawing.Point(30, 445);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(303, 37);
            this.TextBoxEmail.TabIndex = 8;
            this.TextBoxEmail.Text = "someone@example.com";
            this.TextBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(26, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // TextBoxPassword2
            // 
            this.TextBoxPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TextBoxPassword2.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxPassword2.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxPassword2.HintText = "password";
            this.TextBoxPassword2.isPassword = true;
            this.TextBoxPassword2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxPassword2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxPassword2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxPassword2.LineThickness = 3;
            this.TextBoxPassword2.Location = new System.Drawing.Point(33, 377);
            this.TextBoxPassword2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPassword2.Name = "TextBoxPassword2";
            this.TextBoxPassword2.Size = new System.Drawing.Size(303, 37);
            this.TextBoxPassword2.TabIndex = 6;
            this.TextBoxPassword2.Text = "Password";
            this.TextBoxPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(26, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Re-Enter Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(29, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TextBoxUserName.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxUserName.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxUserName.HintText = "User Name";
            this.TextBoxUserName.isPassword = false;
            this.TextBoxUserName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxUserName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxUserName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxUserName.LineThickness = 3;
            this.TextBoxUserName.Location = new System.Drawing.Point(30, 215);
            this.TextBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(303, 37);
            this.TextBoxUserName.TabIndex = 2;
            this.TextBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(29, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(25, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sign Up";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.TextBoxYourName);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.TextBoxPassword);
            this.panel2.Controls.Add(this.ButtonSignIn);
            this.panel2.Controls.Add(this.CheckBoxAgreement);
            this.panel2.Controls.Add(this.CheckBoxAgree);
            this.panel2.Controls.Add(this.ButtonSignUp);
            this.panel2.Controls.Add(this.TextBoxEmail);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TextBoxPassword2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TextBoxUserName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(343, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 669);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TextBoxYourName
            // 
            this.TextBoxYourName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TextBoxYourName.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxYourName.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxYourName.HintText = "Full Name";
            this.TextBoxYourName.isPassword = false;
            this.TextBoxYourName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxYourName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxYourName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxYourName.LineThickness = 3;
            this.TextBoxYourName.Location = new System.Drawing.Point(33, 147);
            this.TextBoxYourName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxYourName.Name = "TextBoxYourName";
            this.TextBoxYourName.Size = new System.Drawing.Size(303, 37);
            this.TextBoxYourName.TabIndex = 14;
            this.TextBoxYourName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label9.Location = new System.Drawing.Point(32, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Your Name";
            // 
            // UserControlSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlSignUpForm";
            this.Size = new System.Drawing.Size(732, 670);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxPassword;
        private System.Windows.Forms.Button ButtonSignIn;
        private System.Windows.Forms.Label CheckBoxAgreement;
        private Bunifu.Framework.UI.BunifuCheckbox CheckBoxAgree;
        private System.Windows.Forms.Button ButtonSignUp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxEmail;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxPassword2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxYourName;
        private System.Windows.Forms.Label label9;
    }
}
