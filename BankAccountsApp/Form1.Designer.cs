namespace BankAccountsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccountBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 35);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 237);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            label2.Click += label2_Click;
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(97, 32);
            OwnerTxt.Margin = new Padding(2, 3, 2, 3);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(159, 36);
            OwnerTxt.TabIndex = 2;
            OwnerTxt.TextChanged += textBox1_TextChanged;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(108, 235);
            AmountNum.Margin = new Padding(2, 3, 2, 3);
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(147, 36);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountGrid
            // 
            BankAccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountGrid.Location = new Point(302, 52);
            BankAccountGrid.Margin = new Padding(2, 3, 2, 3);
            BankAccountGrid.Name = "BankAccountGrid";
            BankAccountGrid.Size = new Size(616, 181);
            BankAccountGrid.TabIndex = 4;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(308, 237);
            DepositBtn.Margin = new Padding(2, 3, 2, 3);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(306, 41);
            DepositBtn.TabIndex = 5;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(628, 237);
            WithdrawBtn.Margin = new Padding(2, 3, 2, 3);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(280, 41);
            WithdrawBtn.TabIndex = 6;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(97, 82);
            CreateAccountBtn.Margin = new Padding(2, 3, 2, 3);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(158, 41);
            CreateAccountBtn.TabIndex = 7;
            CreateAccountBtn.Text = "Create account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 304);
            Controls.Add(CreateAccountBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 6, 3, 6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Button CreateAccountBtn;
    }
}
