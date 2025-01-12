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
            Budget_amount = new Label();
            label3 = new Label();
            label2 = new Label();
            borderedGroupBox1 = new BorderedGroupBox();
            addBSavingsIcon = new PictureBox();
            Savings_amount = new Label();
            label6 = new Label();
            label7 = new Label();
            borderedGroupBox2 = new BorderedGroupBox();
            addSchExpIcon = new PictureBox();
            sch_expenses_amout = new Label();
            label9 = new Label();
            label10 = new Label();
            borderedGroupBox3 = new BorderedGroupBox();
            AddOccExpIcon = new PictureBox();
            occ_expenses_amount = new Label();
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
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 76);
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
            label1.Location = new Point(82, 8);
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
            groupBox1.Controls.Add(Budget_amount);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 76);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // addBudgetIcon
            // 
            addBudgetIcon.Cursor = Cursors.Hand;
            addBudgetIcon.Image = (Image)resources.GetObject("addBudgetIcon.Image");
            addBudgetIcon.Location = new Point(211, 43);
            addBudgetIcon.Name = "addBudgetIcon";
            addBudgetIcon.Size = new Size(37, 27);
            addBudgetIcon.SizeMode = PictureBoxSizeMode.Zoom;
            addBudgetIcon.TabIndex = 5;
            addBudgetIcon.TabStop = false;
            addBudgetIcon.Click += addBudgetIcon_Click;
            // 
            // Budget_amount
            // 
            Budget_amount.AutoSize = true;
            Budget_amount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Budget_amount.ForeColor = Color.AntiqueWhite;
            Budget_amount.Location = new Point(59, 41);
            Budget_amount.Name = "Budget_amount";
            Budget_amount.Size = new Size(45, 25);
            Budget_amount.TabIndex = 4;
            Budget_amount.Text = "123";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(15, 41);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 3;
            label3.Text = "USD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(15, 8);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 0;
            label2.Text = "Budget";
            // 
            // borderedGroupBox1
            // 
            borderedGroupBox1.BackColor = Color.RoyalBlue;
            borderedGroupBox1.BorderRadius = 20;
            borderedGroupBox1.Controls.Add(addBSavingsIcon);
            borderedGroupBox1.Controls.Add(Savings_amount);
            borderedGroupBox1.Controls.Add(label6);
            borderedGroupBox1.Controls.Add(label7);
            borderedGroupBox1.Location = new Point(328, 112);
            borderedGroupBox1.Name = "borderedGroupBox1";
            borderedGroupBox1.Size = new Size(254, 76);
            borderedGroupBox1.TabIndex = 3;
            borderedGroupBox1.TabStop = false;
            // 
            // addBSavingsIcon
            // 
            addBSavingsIcon.Cursor = Cursors.Hand;
            addBSavingsIcon.Image = (Image)resources.GetObject("addBSavingsIcon.Image");
            addBSavingsIcon.Location = new Point(211, 43);
            addBSavingsIcon.Name = "addBSavingsIcon";
            addBSavingsIcon.Size = new Size(37, 27);
            addBSavingsIcon.SizeMode = PictureBoxSizeMode.Zoom;
            addBSavingsIcon.TabIndex = 6;
            addBSavingsIcon.TabStop = false;
            addBSavingsIcon.Click += addBSavingsIcon_Click;
            // 
            // Savings_amount
            // 
            Savings_amount.AutoSize = true;
            Savings_amount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Savings_amount.ForeColor = Color.AntiqueWhite;
            Savings_amount.Location = new Point(59, 41);
            Savings_amount.Name = "Savings_amount";
            Savings_amount.Size = new Size(45, 25);
            Savings_amount.TabIndex = 4;
            Savings_amount.Text = "123";
            Savings_amount.Click += Savings_amount_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(15, 41);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 3;
            label6.Text = "USD ";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(15, 8);
            label7.Name = "label7";
            label7.Size = new Size(92, 30);
            label7.TabIndex = 0;
            label7.Text = "Savings";
            // 
            // borderedGroupBox2
            // 
            borderedGroupBox2.BackColor = Color.RoyalBlue;
            borderedGroupBox2.BorderRadius = 20;
            borderedGroupBox2.Controls.Add(addSchExpIcon);
            borderedGroupBox2.Controls.Add(sch_expenses_amout);
            borderedGroupBox2.Controls.Add(label9);
            borderedGroupBox2.Controls.Add(label10);
            borderedGroupBox2.Location = new Point(638, 112);
            borderedGroupBox2.Name = "borderedGroupBox2";
            borderedGroupBox2.Size = new Size(254, 76);
            borderedGroupBox2.TabIndex = 4;
            borderedGroupBox2.TabStop = false;
            // 
            // addSchExpIcon
            // 
            addSchExpIcon.Cursor = Cursors.Hand;
            addSchExpIcon.Image = (Image)resources.GetObject("addSchExpIcon.Image");
            addSchExpIcon.Location = new Point(211, 43);
            addSchExpIcon.Name = "addSchExpIcon";
            addSchExpIcon.Size = new Size(37, 27);
            addSchExpIcon.SizeMode = PictureBoxSizeMode.Zoom;
            addSchExpIcon.TabIndex = 5;
            addSchExpIcon.TabStop = false;
            addSchExpIcon.Click += addSchExpIcon_Click;
            // 
            // sch_expenses_amout
            // 
            sch_expenses_amout.AutoSize = true;
            sch_expenses_amout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            sch_expenses_amout.ForeColor = Color.AntiqueWhite;
            sch_expenses_amout.Location = new Point(59, 41);
            sch_expenses_amout.Name = "sch_expenses_amout";
            sch_expenses_amout.Size = new Size(45, 25);
            sch_expenses_amout.TabIndex = 4;
            sch_expenses_amout.Text = "123";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(15, 41);
            label9.Name = "label9";
            label9.Size = new Size(56, 25);
            label9.TabIndex = 3;
            label9.Text = "USD ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(10, 7);
            label10.Name = "label10";
            label10.Size = new Size(221, 30);
            label10.TabIndex = 0;
            label10.Text = "Scheduled Expenses";
            label10.Click += label10_Click;
            // 
            // borderedGroupBox3
            // 
            borderedGroupBox3.BackColor = Color.RoyalBlue;
            borderedGroupBox3.BorderRadius = 20;
            borderedGroupBox3.Controls.Add(AddOccExpIcon);
            borderedGroupBox3.Controls.Add(occ_expenses_amount);
            borderedGroupBox3.Controls.Add(label12);
            borderedGroupBox3.Controls.Add(label13);
            borderedGroupBox3.Location = new Point(971, 112);
            borderedGroupBox3.Name = "borderedGroupBox3";
            borderedGroupBox3.Size = new Size(254, 76);
            borderedGroupBox3.TabIndex = 5;
            borderedGroupBox3.TabStop = false;
            // 
            // AddOccExpIcon
            // 
            AddOccExpIcon.Cursor = Cursors.Hand;
            AddOccExpIcon.Image = (Image)resources.GetObject("AddOccExpIcon.Image");
            AddOccExpIcon.Location = new Point(211, 43);
            AddOccExpIcon.Name = "AddOccExpIcon";
            AddOccExpIcon.Size = new Size(37, 27);
            AddOccExpIcon.SizeMode = PictureBoxSizeMode.Zoom;
            AddOccExpIcon.TabIndex = 5;
            AddOccExpIcon.TabStop = false;
            // 
            // occ_expenses_amount
            // 
            occ_expenses_amount.AutoSize = true;
            occ_expenses_amount.BackColor = Color.RoyalBlue;
            occ_expenses_amount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            occ_expenses_amount.ForeColor = Color.AntiqueWhite;
            occ_expenses_amount.Location = new Point(59, 41);
            occ_expenses_amount.Name = "occ_expenses_amount";
            occ_expenses_amount.Size = new Size(45, 25);
            occ_expenses_amount.TabIndex = 4;
            occ_expenses_amount.Text = "123";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(15, 41);
            label12.Name = "label12";
            label12.Size = new Size(51, 25);
            label12.TabIndex = 3;
            label12.Text = "USD";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(7, 7);
            label13.Name = "label13";
            label13.Size = new Size(225, 30);
            label13.TabIndex = 0;
            label13.Text = "Occasional Expenses";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Georgia", 18F, FontStyle.Bold);
            label14.ForeColor = Color.MidnightBlue;
            label14.Location = new Point(10, 234);
            label14.Name = "label14";
            label14.Size = new Size(298, 35);
            label14.TabIndex = 6;
            label14.Text = "Expenses Analysis";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 747);
            Controls.Add(label14);
            Controls.Add(borderedGroupBox3);
            Controls.Add(borderedGroupBox2);
            Controls.Add(borderedGroupBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Parchment", 9F);
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
        private Label Budget_amount;
        private Label label3;
        private BorderedGroupBox borderedGroupBox1;
        private Label Savings_amount;
        private Label label6;
        private Label label7;
        private PictureBox addBudgetIcon;
        private PictureBox addBSavingsIcon;
        private BorderedGroupBox borderedGroupBox2;
        private Label label10;
        private PictureBox addSchExpIcon;
        private Label sch_expenses_amout;
        private Label label9;
        private BorderedGroupBox borderedGroupBox3;
        private PictureBox AddOccExpIcon;
        private Label occ_expenses_amount;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}