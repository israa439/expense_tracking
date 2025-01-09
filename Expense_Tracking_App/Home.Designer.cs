using Expense_Tracking_App.CustomControls;

namespace Expense_Tracking_App
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new BorderedGroupBox();
            addBudgetIcon = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            borderedGroupBox1 = new BorderedGroupBox();
            addBSavingsIcon = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            borderedGroupBox2 = new BorderedGroupBox();
            addSchExpIcon = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            borderedGroupBox3 = new BorderedGroupBox();
            AddOccExpIcon = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addBudgetIcon).BeginInit();
            borderedGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addBSavingsIcon).BeginInit();
            borderedGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addSchExpIcon).BeginInit();
            borderedGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddOccExpIcon).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Dubai", 23F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(94, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 66);
            label1.TabIndex = 1;
            label1.Text = "Spendly";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.RoyalBlue;
            groupBox1.BorderRadius = 20;
            groupBox1.Controls.Add(addBudgetIcon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 77);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // addBudgetIcon
            // 
            addBudgetIcon.Cursor = Cursors.Hand;
            addBudgetIcon.Image = (Image)resources.GetObject("addBudgetIcon.Image");
            addBudgetIcon.Location = new Point(185, 43);
            addBudgetIcon.Name = "addBudgetIcon";
            addBudgetIcon.Size = new Size(42, 30);
            addBudgetIcon.SizeMode = PictureBoxSizeMode.Zoom;
            addBudgetIcon.TabIndex = 5;
            addBudgetIcon.TabStop = false;
            addBudgetIcon.Click += addBudgetIcon_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(82, 43);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 4;
            label4.Text = "123";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(17, 43);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 3;
            label3.Text = "USD  $";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(17, 9);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 0;
            label2.Text = "Budget";
            // 
            // borderedGroupBox1
            // 
            borderedGroupBox1.BackColor = Color.RoyalBlue;
            borderedGroupBox1.BorderRadius = 20;
            borderedGroupBox1.Controls.Add(addBSavingsIcon);
            borderedGroupBox1.Controls.Add(label5);
            borderedGroupBox1.Controls.Add(label6);
            borderedGroupBox1.Controls.Add(label7);
            borderedGroupBox1.Location = new Point(302, 126);
            borderedGroupBox1.Name = "borderedGroupBox1";
            borderedGroupBox1.Size = new Size(233, 77);
            borderedGroupBox1.TabIndex = 3;
            borderedGroupBox1.TabStop = false;
            // 
            // addBSavingsIcon
            // 
            addBSavingsIcon.Cursor = Cursors.Hand;
            addBSavingsIcon.Image = (Image)resources.GetObject("addBSavingsIcon.Image");
            addBSavingsIcon.Location = new Point(185, 41);
            addBSavingsIcon.Name = "addBSavingsIcon";
            addBSavingsIcon.Size = new Size(42, 30);
            addBSavingsIcon.SizeMode = PictureBoxSizeMode.Zoom;
            addBSavingsIcon.TabIndex = 6;
            addBSavingsIcon.TabStop = false;
            addBSavingsIcon.Click += addBSavingsIcon_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(82, 43);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 4;
            label5.Text = "123";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(17, 43);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 3;
            label6.Text = "USD  $";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(17, 9);
            label7.Name = "label7";
            label7.Size = new Size(86, 30);
            label7.TabIndex = 0;
            label7.Text = "Savings";
            // 
            // borderedGroupBox2
            // 
            borderedGroupBox2.BackColor = Color.RoyalBlue;
            borderedGroupBox2.BorderRadius = 20;
            borderedGroupBox2.Controls.Add(addSchExpIcon);
            borderedGroupBox2.Controls.Add(label8);
            borderedGroupBox2.Controls.Add(label9);
            borderedGroupBox2.Controls.Add(label10);
            borderedGroupBox2.Location = new Point(608, 126);
            borderedGroupBox2.Name = "borderedGroupBox2";
            borderedGroupBox2.Size = new Size(233, 77);
            borderedGroupBox2.TabIndex = 4;
            borderedGroupBox2.TabStop = false;
            // 
            // addSchExpIcon
            // 
            addSchExpIcon.Cursor = Cursors.Hand;
            addSchExpIcon.Image = (Image)resources.GetObject("addSchExpIcon.Image");
            addSchExpIcon.Location = new Point(183, 41);
            addSchExpIcon.Name = "addSchExpIcon";
            addSchExpIcon.Size = new Size(42, 30);
            addSchExpIcon.SizeMode = PictureBoxSizeMode.Zoom;
            addSchExpIcon.TabIndex = 5;
            addSchExpIcon.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(82, 43);
            label8.Name = "label8";
            label8.Size = new Size(42, 25);
            label8.TabIndex = 4;
            label8.Text = "123";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(17, 43);
            label9.Name = "label9";
            label9.Size = new Size(68, 25);
            label9.TabIndex = 3;
            label9.Text = "USD  $";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(17, 9);
            label10.Name = "label10";
            label10.Size = new Size(208, 30);
            label10.TabIndex = 0;
            label10.Text = "Scheduled Expenses";
            label10.Click += label10_Click;
            // 
            // borderedGroupBox3
            // 
            borderedGroupBox3.BackColor = Color.RoyalBlue;
            borderedGroupBox3.BorderRadius = 20;
            borderedGroupBox3.Controls.Add(AddOccExpIcon);
            borderedGroupBox3.Controls.Add(label11);
            borderedGroupBox3.Controls.Add(label12);
            borderedGroupBox3.Controls.Add(label13);
            borderedGroupBox3.Location = new Point(927, 124);
            borderedGroupBox3.Name = "borderedGroupBox3";
            borderedGroupBox3.Size = new Size(233, 77);
            borderedGroupBox3.TabIndex = 5;
            borderedGroupBox3.TabStop = false;
            // 
            // AddOccExpIcon
            // 
            AddOccExpIcon.Cursor = Cursors.Hand;
            AddOccExpIcon.Image = (Image)resources.GetObject("AddOccExpIcon.Image");
            AddOccExpIcon.Location = new Point(183, 41);
            AddOccExpIcon.Name = "AddOccExpIcon";
            AddOccExpIcon.Size = new Size(42, 30);
            AddOccExpIcon.SizeMode = PictureBoxSizeMode.Zoom;
            AddOccExpIcon.TabIndex = 5;
            AddOccExpIcon.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(82, 43);
            label11.Name = "label11";
            label11.Size = new Size(42, 25);
            label11.TabIndex = 4;
            label11.Text = "123";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(17, 43);
            label12.Name = "label12";
            label12.Size = new Size(68, 25);
            label12.TabIndex = 3;
            label12.Text = "USD  $";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13F);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(17, 9);
            label13.Name = "label13";
            label13.Size = new Size(210, 30);
            label13.TabIndex = 0;
            label13.Text = "Occasional Expenses";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Georgia", 18F, FontStyle.Bold);
            label14.ForeColor = Color.MidnightBlue;
            label14.Location = new Point(12, 260);
            label14.Name = "label14";
            label14.Size = new Size(298, 35);
            label14.TabIndex = 6;
            label14.Text = "Expenses Analysis";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 705);
            Controls.Add(label14);
            Controls.Add(borderedGroupBox3);
            Controls.Add(borderedGroupBox2);
            Controls.Add(borderedGroupBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addBudgetIcon).EndInit();
            borderedGroupBox1.ResumeLayout(false);
            borderedGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addBSavingsIcon).EndInit();
            borderedGroupBox2.ResumeLayout(false);
            borderedGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addSchExpIcon).EndInit();
            borderedGroupBox3.ResumeLayout(false);
            borderedGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddOccExpIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private Label label1;
        private BorderedGroupBox groupBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private BorderedGroupBox borderedGroupBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox addBudgetIcon;
        private PictureBox addBSavingsIcon;
        private BorderedGroupBox borderedGroupBox2;
        private Label label10;
        private PictureBox addSchExpIcon;
        private Label label8;
        private Label label9;
        private BorderedGroupBox borderedGroupBox3;
        private PictureBox AddOccExpIcon;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}