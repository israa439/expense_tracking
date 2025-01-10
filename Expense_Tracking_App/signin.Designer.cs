using Expense_Tracking_App.CustomControls;

namespace Expense_Tracking_App
{
    partial class signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin));
            signInContainer = new BorderedGroupBox();
            Signin_btn = new RoundedButton();
            navToSignup = new Label();
            password_signin_field = new TextBox();
            password_signin_label = new Label();
            text = new Label();
            username_signin_field = new TextBox();
            useername_signin_label = new Label();
            signinHeader = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            signInContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signInContainer
            // 
            signInContainer.BackColor = SystemColors.ActiveCaption;
            signInContainer.BorderRadius = 30;
            signInContainer.Controls.Add(Signin_btn);
            signInContainer.Controls.Add(navToSignup);
            signInContainer.Controls.Add(password_signin_field);
            signInContainer.Controls.Add(password_signin_label);
            signInContainer.Controls.Add(text);
            signInContainer.Controls.Add(username_signin_field);
            signInContainer.Controls.Add(useername_signin_label);
            signInContainer.Controls.Add(signinHeader);
            signInContainer.Font = new Font("Segoe UI", 15F);
            signInContainer.Location = new Point(426, 68);
            signInContainer.Name = "signInContainer";
            signInContainer.Size = new Size(478, 592);
            signInContainer.TabIndex = 0;
            signInContainer.TabStop = false;
            // 
            // Signin_btn
            // 
            Signin_btn.BackColor = SystemColors.ButtonHighlight;
            Signin_btn.BorderRadius = 20;
            Signin_btn.Cursor = Cursors.Hand;
            Signin_btn.ForeColor = SystemColors.ActiveCaptionText;
            Signin_btn.Location = new Point(169, 454);
            Signin_btn.Name = "Signin_btn";
            Signin_btn.Size = new Size(150, 51);
            Signin_btn.TabIndex = 6;
            Signin_btn.Text = "Sign in";
            Signin_btn.UseVisualStyleBackColor = false;
            Signin_btn.Click += Signin_btn_Click;
            // 
            // navToSignup
            // 
            navToSignup.AutoSize = true;
            navToSignup.BackColor = SystemColors.ActiveCaption;
            navToSignup.Cursor = Cursors.Hand;
            navToSignup.Font = new Font("Segoe UI", 13F);
            navToSignup.ForeColor = Color.Crimson;
            navToSignup.Location = new Point(308, 375);
            navToSignup.Name = "navToSignup";
            navToSignup.Size = new Size(139, 30);
            navToSignup.TabIndex = 5;
            navToSignup.Text = "register now.";
            navToSignup.Click += navToSignup_Click;
            // 
            // password_signin_field
            // 
            password_signin_field.Location = new Point(193, 262);
            password_signin_field.Name = "password_signin_field";
            password_signin_field.PasswordChar = '*';
            password_signin_field.Size = new Size(266, 41);
            password_signin_field.TabIndex = 4;
            password_signin_field.UseSystemPasswordChar = true;
            // 
            // password_signin_label
            // 
            password_signin_label.AutoSize = true;
            password_signin_label.ForeColor = SystemColors.ActiveCaptionText;
            password_signin_label.Location = new Point(25, 262);
            password_signin_label.Name = "password_signin_label";
            password_signin_label.Size = new Size(122, 35);
            password_signin_label.TabIndex = 1;
            password_signin_label.Text = "password";
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Segoe UI", 13F);
            text.ForeColor = SystemColors.ActiveCaptionText;
            text.Location = new Point(25, 375);
            text.Name = "text";
            text.Size = new Size(291, 30);
            text.TabIndex = 3;
            text.Text = "If you don't have an account,";
            //text.Click += text_Click;
            // 
            // username_signin_field
            // 
            username_signin_field.Font = new Font("Segoe UI", 15F);
            username_signin_field.Location = new Point(193, 170);
            username_signin_field.Name = "username_signin_field";
            username_signin_field.Size = new Size(266, 41);
            username_signin_field.TabIndex = 2;
   
            // 
            // useername_signin_label
            // 
            useername_signin_label.AutoSize = true;
            useername_signin_label.BackColor = SystemColors.ActiveCaption;
            useername_signin_label.ForeColor = SystemColors.ActiveCaptionText;
            useername_signin_label.Location = new Point(25, 170);
            useername_signin_label.Name = "useername_signin_label";
            useername_signin_label.Size = new Size(127, 35);
            useername_signin_label.TabIndex = 1;
            useername_signin_label.Text = "Username";
            // 
            // signinHeader
            // 
            signinHeader.AutoSize = true;
            signinHeader.BackColor = SystemColors.ActiveCaption;
            signinHeader.Font = new Font("Trebuchet MS", 20F);
            signinHeader.ForeColor = SystemColors.ActiveCaptionText;
            signinHeader.Location = new Point(169, 37);
            signinHeader.Name = "signinHeader";
            signinHeader.Size = new Size(129, 43);
            signinHeader.TabIndex = 0;
            signinHeader.Text = "Sign In ";
            //signinHeader.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Dubai", 23F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(97, 14);
            label1.Name = "label1";
            label1.Size = new Size(160, 66);
            label1.TabIndex = 3;
            label1.Text = "Spendly";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1345, 747);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(signInContainer);
            ForeColor = Color.CornflowerBlue;
            Name = "signin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            //BackColorChanged += Auth_BackColorChanged;
            signInContainer.ResumeLayout(false);
            signInContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private BorderedGroupBox signInContainer;
        private Label signinHeader;
        private Label useername_signin_label;
        private Label password_signin_label;
        private TextBox username_signin_field;
        private Label text;
        private TextBox password_signin_field;
        private Label navToSignup;
        private RoundedButton Signin_btn;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
