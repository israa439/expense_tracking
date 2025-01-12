namespace Expense_Tracking_App
{
    partial class sch_expense_form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtExpenseName = new TextBox();
            txtAmount = new TextBox();
            btnAddExpense = new CustomControls.RoundedButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(99, 24);
            label1.Name = "label1";
            label1.Size = new Size(355, 35);
            label1.TabIndex = 0;
            label1.Text = "Create new scheduled expense";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(47, 95);
            label2.Name = "label2";
            label2.Size = new Size(143, 28);
            label2.TabIndex = 1;
            label2.Text = "Expense Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(47, 157);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 2;
            label3.Text = "Amount:";
            // 
            // txtExpenseName
            // 
            txtExpenseName.Font = new Font("Segoe UI", 10F);
            txtExpenseName.Location = new Point(210, 95);
            txtExpenseName.Name = "txtExpenseName";
            txtExpenseName.Size = new Size(266, 30);
            txtExpenseName.TabIndex = 4;
            txtExpenseName.TextChanged += txtExpenseName_TextChanged;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 10F);
            txtAmount.Location = new Point(210, 155);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(266, 30);
            txtAmount.TabIndex = 5;
            // 
            // btnAddExpense
            // 
            btnAddExpense.BackColor = Color.CornflowerBlue;
            btnAddExpense.BorderRadius = 20;
            btnAddExpense.ForeColor = SystemColors.ButtonHighlight;
            btnAddExpense.Location = new Point(241, 224);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(76, 36);
            btnAddExpense.TabIndex = 6;
            btnAddExpense.Text = "create";
            btnAddExpense.UseVisualStyleBackColor = false;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // sch_expense_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 288);
            Controls.Add(btnAddExpense);
            Controls.Add(txtAmount);
            Controls.Add(txtExpenseName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "sch_expense_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sch_expense_form";
            Load += sch_expense_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtExpenseName;
        private TextBox txtAmount;
        private CustomControls.RoundedButton btnAddExpense;
    }
}