namespace Expense_Tracking_App
{
    partial class Budget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budget));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            Budget_amount = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            Transfered_budget_amount = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label15 = new Label();
            Added_budget_amount = new TextBox();
            label13 = new Label();
            Transfer_to_savings = new CustomControls.RoundedButton();
            Add_to_budget = new CustomControls.RoundedButton();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Dubai", 23F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 66);
            label1.TabIndex = 7;
            label1.Text = "Spendly";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Georgia", 20F, FontStyle.Bold);
            label14.ForeColor = Color.MidnightBlue;
            label14.Location = new Point(67, 143);
            label14.Name = "label14";
            label14.Size = new Size(142, 39);
            label14.TabIndex = 11;
            label14.Text = "Budget";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 13F, FontStyle.Bold);
            label7.ForeColor = Color.SlateGray;
            label7.Location = new Point(12, 253);
            label7.Name = "label7";
            label7.Size = new Size(785, 27);
            label7.TabIndex = 16;
            label7.Text = "Budget helps you have an efficient overview of your spending limits.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 15F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(12, 290);
            label3.Name = "label3";
            label3.Size = new Size(411, 30);
            label3.TabIndex = 17;
            label3.Text = "Your budget for this month is : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 15F, FontStyle.Bold);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(410, 290);
            label6.Name = "label6";
            label6.Size = new Size(71, 30);
            label6.TabIndex = 31;
            label6.Text = "USD";
            // 
            // Budget_amount
            // 
            Budget_amount.AutoSize = true;
            Budget_amount.Font = new Font("Georgia", 15F, FontStyle.Bold);
            Budget_amount.ForeColor = Color.Crimson;
            Budget_amount.Location = new Point(473, 290);
            Budget_amount.Name = "Budget_amount";
            Budget_amount.Size = new Size(107, 30);
            Budget_amount.TabIndex = 32;
            Budget_amount.Text = " 123.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 13F, FontStyle.Bold);
            label5.ForeColor = Color.SlateGray;
            label5.Location = new Point(12, 382);
            label5.Name = "label5";
            label5.Size = new Size(709, 27);
            label5.TabIndex = 33;
            label5.Text = "Would you like to transfer from your Budget to your Savings?\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 15F, FontStyle.Bold);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(17, 417);
            label8.Name = "label8";
            label8.Size = new Size(125, 30);
            label8.TabIndex = 34;
            label8.Text = "Transfer";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 15F, FontStyle.Bold);
            label9.ForeColor = Color.Crimson;
            label9.Location = new Point(143, 417);
            label9.Name = "label9";
            label9.Size = new Size(71, 30);
            label9.TabIndex = 36;
            label9.Text = "USD";
            // 
            // Transfered_budget_amount
            // 
            Transfered_budget_amount.Cursor = Cursors.Hand;
            Transfered_budget_amount.Location = new Point(220, 417);
            Transfered_budget_amount.Name = "Transfered_budget_amount";
            Transfered_budget_amount.Size = new Size(142, 27);
            Transfered_budget_amount.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 15F, FontStyle.Bold);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(368, 417);
            label10.Name = "label10";
            label10.Size = new Size(310, 30);
            label10.TabIndex = 38;
            label10.Text = "from Budget to Savings";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Georgia", 13F, FontStyle.Bold);
            label11.ForeColor = Color.SlateGray;
            label11.Location = new Point(19, 510);
            label11.Name = "label11";
            label11.Size = new Size(525, 27);
            label11.TabIndex = 39;
            label11.Text = "Would you like to add money to your budget?\r\n";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Georgia", 15F, FontStyle.Bold);
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(25, 537);
            label12.Name = "label12";
            label12.Size = new Size(66, 30);
            label12.TabIndex = 40;
            label12.Text = "Add";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Georgia", 15F, FontStyle.Bold);
            label15.ForeColor = Color.MidnightBlue;
            label15.Location = new Point(322, 537);
            label15.Name = "label15";
            label15.Size = new Size(143, 30);
            label15.TabIndex = 45;
            label15.Text = "to Savings";
            // 
            // Added_budget_amount
            // 
            Added_budget_amount.Cursor = Cursors.Hand;
            Added_budget_amount.Location = new Point(174, 540);
            Added_budget_amount.Name = "Added_budget_amount";
            Added_budget_amount.Size = new Size(142, 27);
            Added_budget_amount.TabIndex = 44;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Georgia", 15F, FontStyle.Bold);
            label13.ForeColor = Color.Crimson;
            label13.Location = new Point(88, 537);
            label13.Name = "label13";
            label13.Size = new Size(71, 30);
            label13.TabIndex = 43;
            label13.Text = "USD";
            // 
            // Transfer_to_savings
            // 
            Transfer_to_savings.BackColor = Color.CornflowerBlue;
            Transfer_to_savings.BorderRadius = 20;
            Transfer_to_savings.ForeColor = Color.White;
            Transfer_to_savings.Location = new Point(684, 418);
            Transfer_to_savings.Name = "Transfer_to_savings";
            Transfer_to_savings.Size = new Size(81, 38);
            Transfer_to_savings.TabIndex = 46;
            Transfer_to_savings.Text = "Transfer";
            Transfer_to_savings.UseVisualStyleBackColor = false;
            Transfer_to_savings.Click += Transfer_to_savings_Click;
            // 
            // Add_to_budget
            // 
            Add_to_budget.BackColor = Color.CornflowerBlue;
            Add_to_budget.BorderRadius = 20;
            Add_to_budget.ForeColor = Color.White;
            Add_to_budget.Location = new Point(471, 540);
            Add_to_budget.Name = "Add_to_budget";
            Add_to_budget.Size = new Size(81, 38);
            Add_to_budget.TabIndex = 47;
            Add_to_budget.Text = "Add";
            Add_to_budget.UseVisualStyleBackColor = false;
            Add_to_budget.Click += Add_to_budget_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1063, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(1099, 15);
            label2.Name = "label2";
            label2.Size = new Size(169, 32);
            label2.TabIndex = 49;
            label2.Text = "Back to home";
            label2.Click += label2_Click;
            // 
            // Budget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 705);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(Add_to_budget);
            Controls.Add(Transfer_to_savings);
            Controls.Add(label15);
            Controls.Add(Added_budget_amount);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(Transfered_budget_amount);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(Budget_amount);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label14);
            Controls.Add(label1);
            Name = "Budget";
            Text = "Budget";
            Load += Budget_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private Label label14;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label Budget_amount;
        private Label label5;
        private Label label8;
        private Label label9;
        private TextBox Transfered_budget_amount;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label15;
        private TextBox Added_budget_amount;
        private Label label13;
        private CustomControls.RoundedButton Transfer_to_savings;
        private CustomControls.RoundedButton Add_to_budget;
        private PictureBox pictureBox3;
        private Label label2;
    }
}