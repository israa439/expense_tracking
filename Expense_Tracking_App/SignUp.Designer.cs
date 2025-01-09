using Expense_Tracking_App.CustomControls;
using static System.Net.Mime.MediaTypeNames;

namespace Expense_Tracking_App
{
    partial class SignUp
    {
  
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            signUpContainer = new BorderedGroupBox();
            Signup_btn = new RoundedButton();
            navToSignin = new Label();
            text = new Label();
            FullName_signup_field = new TextBox();
            Fullname_signup_label = new Label();
            Email_signup_field = new TextBox();
            email_signup_label = new Label();
            password_signup_field = new TextBox();
            password_signup_label = new Label();
            useername_signup_field = new TextBox();
            useername_signup_label = new Label();
            signupHeader = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            signUpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signUpContainer
            // 
            signUpContainer.BackColor = SystemColors.ActiveCaption;
            signUpContainer.BorderRadius = 20;
            signUpContainer.Controls.Add(Signup_btn);
            signUpContainer.Controls.Add(navToSignin);
            signUpContainer.Controls.Add(text);
            signUpContainer.Controls.Add(FullName_signup_field);
            signUpContainer.Controls.Add(Fullname_signup_label);
            signUpContainer.Controls.Add(Email_signup_field);
            signUpContainer.Controls.Add(email_signup_label);
            signUpContainer.Controls.Add(password_signup_field);
            signUpContainer.Controls.Add(password_signup_label);
            signUpContainer.Controls.Add(useername_signup_field);
            signUpContainer.Controls.Add(useername_signup_label);
            signUpContainer.Controls.Add(signupHeader);
            signUpContainer.Location = new Point(426, 68);
            signUpContainer.Name = "signUpContainer";
            signUpContainer.Size = new Size(478, 592);
            signUpContainer.TabIndex = 0;
            signUpContainer.TabStop = false;
            // 
            // Signup_btn
            // 
            Signup_btn.BackColor = SystemColors.ButtonHighlight;
            Signup_btn.BorderRadius = 20;
            Signup_btn.Cursor = Cursors.Hand;
            Signup_btn.ForeColor = SystemColors.ActiveCaptionText;
            Signup_btn.Location = new Point(169, 518);
            Signup_btn.Name = "Signup_btn";
            Signup_btn.Size = new Size(150, 51);
            Signup_btn.TabIndex = 11;
            Signup_btn.Text = "Sign up";
            Signup_btn.UseVisualStyleBackColor = false;
            Signup_btn.Click += Signup_btn_Click;
            // 
            // navToSignin
            // 
            navToSignin.AutoSize = true;
            navToSignin.BackColor = SystemColors.ActiveCaption;
            navToSignin.Cursor = Cursors.Hand;
            navToSignin.Font = new System.Drawing.Font("Segoe UI", 13F);
            navToSignin.ForeColor = Color.Crimson;
            navToSignin.Location = new Point(354, 472);
            navToSignin.Name = "navToSignin";
            navToSignin.Size = new Size(77, 30);
            navToSignin.TabIndex = 10;
            navToSignin.Text = "Log in.";
            navToSignin.Click += navToSignin_Click;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new System.Drawing.Font("Segoe UI", 13F);
            text.ForeColor = SystemColors.ActiveCaptionText;
            text.Location = new Point(48, 472);
            text.Name = "text";
            text.Size = new Size(312, 30);
            text.TabIndex = 9;
            text.Text = "If you already have an account,";
            // 
            // FullName_signup_field
            // 
            FullName_signup_field.Font = new System.Drawing.Font("Segoe UI", 15F);
            FullName_signup_field.Location = new Point(191, 389);
            FullName_signup_field.Name = "FullName_signup_field";
            FullName_signup_field.Size = new Size(266, 41);
            FullName_signup_field.TabIndex = 8;
            // 
            // Fullname_signup_label
            // 
            Fullname_signup_label.AutoSize = true;
            Fullname_signup_label.Font = new System.Drawing.Font("Segoe UI", 15F);
            Fullname_signup_label.Location = new Point(21, 395);
            Fullname_signup_label.Name = "Fullname_signup_label";
            Fullname_signup_label.Size = new Size(127, 35);
            Fullname_signup_label.TabIndex = 7;
            Fullname_signup_label.Text = "Full Name";
            // 
            // Email_signup_field
            // 
            Email_signup_field.Font = new System.Drawing.Font("Segoe UI", 15F);
            Email_signup_field.Location = new Point(191, 311);
            Email_signup_field.Name = "Email_signup_field";
            Email_signup_field.Size = new Size(266, 41);
            Email_signup_field.TabIndex = 6;
            // 
            // email_signup_label
            // 
            email_signup_label.AutoSize = true;
            email_signup_label.Font = new System.Drawing.Font("Segoe UI", 15F);
            email_signup_label.Location = new Point(21, 317);
            email_signup_label.Name = "email_signup_label";
            email_signup_label.Size = new Size(75, 35);
            email_signup_label.TabIndex = 5;
            email_signup_label.Text = "Email";
            // 
            // password_signup_field
            // 
            password_signup_field.Font = new System.Drawing.Font("Segoe UI", 15F);
            password_signup_field.Location = new Point(191, 234);
            password_signup_field.Name = "password_signup_field";
            password_signup_field.PasswordChar = '*';
            password_signup_field.Size = new Size(266, 41);
            password_signup_field.TabIndex = 4;
            password_signup_field.TextChanged += password_signup_field_TextChanged;
            // 
            // password_signup_label
            // 
            password_signup_label.AutoSize = true;
            password_signup_label.Font = new System.Drawing.Font("Segoe UI", 15F);
            password_signup_label.Location = new Point(21, 240);
            password_signup_label.Name = "password_signup_label";
            password_signup_label.Size = new Size(120, 35);
            password_signup_label.TabIndex = 3;
            password_signup_label.Text = "Password";
            // 
            // useername_signup_field
            // 
            useername_signup_field.Font = new System.Drawing.Font("Segoe UI", 15F);
            useername_signup_field.Location = new Point(191, 162);
            useername_signup_field.Name = "useername_signup_field";
            useername_signup_field.Size = new Size(266, 41);
            useername_signup_field.TabIndex = 2;
            // 
            // useername_signup_label
            // 
            useername_signup_label.AutoSize = true;
            useername_signup_label.Font = new System.Drawing.Font("Segoe UI", 15F);
            useername_signup_label.Location = new Point(21, 162);
            useername_signup_label.Name = "useername_signup_label";
            useername_signup_label.Size = new Size(127, 35);
            useername_signup_label.TabIndex = 1;
            useername_signup_label.Text = "Username";
            // 
            // signupHeader
            // 
            signupHeader.AutoSize = true;
            signupHeader.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            signupHeader.Location = new Point(169, 37);
            signupHeader.Name = "signupHeader";
            signupHeader.Size = new Size(132, 43);
            signupHeader.TabIndex = 0;
            signupHeader.Text = "Sign Up";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new System.Drawing.Font("Dubai", 23F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(97, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 66);
            label1.TabIndex = 3;
            label1.Text = "Spendly";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 709);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(signUpContainer);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpcs";
            Click += SignUp_Click;
            signUpContainer.ResumeLayout(false);
            signUpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private BorderedGroupBox signUpContainer;
        private Label signupHeader;
        private Label useername_signup_label;
        private TextBox useername_signup_field;
        private Label password_signup_label;
        private TextBox password_signup_field;
        private Label email_signup_label;
        private TextBox Email_signup_field;
        private TextBox FullName_signup_field;
        private Label Fullname_signup_label;
        private Label text;
        private Label navToSignin;
        private RoundedButton Signup_btn;
        private Label label1;
        private PictureBox pictureBox1;
    }
}