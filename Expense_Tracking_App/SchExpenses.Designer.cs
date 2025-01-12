namespace Expense_Tracking_App
{
    partial class SchExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchExpenses));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label14 = new Label();
            panelScheduledExpenses = new Panel();
            add_sch_exp_icon = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)add_sch_exp_icon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Dubai", 23F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(91, 8);
            label1.Name = "label1";
            label1.Size = new Size(160, 66);
            label1.TabIndex = 7;
            label1.Text = "Spendly";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(1154, 9);
            label2.Name = "label2";
            label2.Size = new Size(169, 32);
            label2.TabIndex = 53;
            label2.Text = "Back to home";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1118, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 52;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Georgia", 20F, FontStyle.Bold);
            label14.ForeColor = Color.MidnightBlue;
            label14.Location = new Point(81, 146);
            label14.Name = "label14";
            label14.Size = new Size(370, 39);
            label14.TabIndex = 54;
            label14.Text = "Scheduled Expenses";
            // 
            // panelScheduledExpenses
            // 
            panelScheduledExpenses.AutoScroll = true;
            panelScheduledExpenses.Location = new Point(2, 281);
            panelScheduledExpenses.Name = "panelScheduledExpenses";
            panelScheduledExpenses.Size = new Size(1331, 425);
            panelScheduledExpenses.TabIndex = 56;
            // 
            // add_sch_exp_icon
            // 
            add_sch_exp_icon.Cursor = Cursors.Hand;
            add_sch_exp_icon.Image = (Image)resources.GetObject("add_sch_exp_icon.Image");
            add_sch_exp_icon.Location = new Point(982, 197);
            add_sch_exp_icon.Name = "add_sch_exp_icon";
            add_sch_exp_icon.Size = new Size(45, 34);
            add_sch_exp_icon.SizeMode = PictureBoxSizeMode.Zoom;
            add_sch_exp_icon.TabIndex = 57;
            add_sch_exp_icon.TabStop = false;
            add_sch_exp_icon.Click += add_sch_exp_icon_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Dubai", 13F, FontStyle.Bold);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(1020, 197);
            label3.Name = "label3";
            label3.Size = new Size(240, 37);
            label3.TabIndex = 58;
            label3.Text = "Add scheduled expense";
            label3.Click += label3_Click;
            // 
            // SchExpenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 747);
            Controls.Add(label3);
            Controls.Add(add_sch_exp_icon);
            Controls.Add(panelScheduledExpenses);
            Controls.Add(pictureBox2);
            Controls.Add(label14);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "SchExpenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FixedExpenses";
            Load += SchExpenses_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)add_sch_exp_icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label14;
        private Panel panelScheduledExpenses;
        private PictureBox add_sch_exp_icon;
        private Label label3;
    }
}