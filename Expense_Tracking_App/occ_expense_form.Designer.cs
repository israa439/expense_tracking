namespace Expense_Tracking_App
{
    partial class occ_expense_form
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
            btnAddExpense = new CustomControls.RoundedButton();
            txtAmount = new TextBox();
            txtExpenseName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAddExpense
            // 
            btnAddExpense.BackColor = Color.CornflowerBlue;
            btnAddExpense.BorderRadius = 20;
            btnAddExpense.ForeColor = SystemColors.ButtonHighlight;
            btnAddExpense.Location = new Point(244, 227);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(76, 36);
            btnAddExpense.TabIndex = 12;
            btnAddExpense.Text = "create";
            btnAddExpense.UseVisualStyleBackColor = false;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 10F);
            txtAmount.Location = new Point(213, 158);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(266, 30);
            txtAmount.TabIndex = 11;
            // 
            // txtExpenseName
            // 
            txtExpenseName.Font = new Font("Segoe UI", 10F);
            txtExpenseName.Location = new Point(213, 98);
            txtExpenseName.Name = "txtExpenseName";
            txtExpenseName.Size = new Size(266, 30);
            txtExpenseName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(50, 160);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 9;
            label3.Text = "Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(50, 98);
            label2.Name = "label2";
            label2.Size = new Size(143, 28);
            label2.TabIndex = 8;
            label2.Text = "Expense Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(102, 27);
            label1.Name = "label1";
            label1.Size = new Size(359, 35);
            label1.TabIndex = 7;
            label1.Text = "Create new occasional expense";
            // 
            // occ_expense_form
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
            Name = "occ_expense_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "occ_expense_form";
            Load += occ_expense_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RoundedButton btnAddExpense;
        private TextBox txtAmount;
        private TextBox txtExpenseName;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}