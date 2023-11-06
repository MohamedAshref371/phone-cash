namespace Phone_Cash
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxWithdraw = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.now = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.getExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.maxDepo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.remDepo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.remWithdraw = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.withdraw = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.newFirstCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 200);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(876, 488);
            this.dataGridView.TabIndex = 0;
            // 
            // phoneNumber
            // 
            this.phoneNumber.BackColor = System.Drawing.Color.White;
            this.phoneNumber.Font = new System.Drawing.Font("Tahoma", 16F);
            this.phoneNumber.Location = new System.Drawing.Point(546, 6);
            this.phoneNumber.MaxLength = 11;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            this.phoneNumber.Size = new System.Drawing.Size(221, 33);
            this.phoneNumber.TabIndex = 1;
            this.phoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(773, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "رقم الهاتف:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(738, 57);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "أقصى السحب:";
            // 
            // maxWithdraw
            // 
            this.maxWithdraw.Font = new System.Drawing.Font("Tahoma", 16F);
            this.maxWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maxWithdraw.Location = new System.Drawing.Point(618, 56);
            this.maxWithdraw.Name = "maxWithdraw";
            this.maxWithdraw.Size = new System.Drawing.Size(123, 33);
            this.maxWithdraw.TabIndex = 5;
            this.maxWithdraw.Text = "0";
            this.maxWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amount
            // 
            this.amount.DecimalPlaces = 2;
            this.amount.Font = new System.Drawing.Font("Tahoma", 16F);
            this.amount.Location = new System.Drawing.Point(24, 27);
            this.amount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.amount.Size = new System.Drawing.Size(221, 33);
            this.amount.TabIndex = 7;
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Tahoma", 14F);
            this.add.Location = new System.Drawing.Point(145, 77);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 33);
            this.add.TabIndex = 9;
            this.add.Text = "إيداع";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(441, 56);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "الرصيد:";
            // 
            // balance
            // 
            this.balance.BackColor = System.Drawing.Color.Transparent;
            this.balance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.balance.ForeColor = System.Drawing.Color.Green;
            this.balance.Location = new System.Drawing.Point(315, 56);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(123, 33);
            this.balance.TabIndex = 12;
            this.balance.Text = "0";
            this.balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comment
            // 
            this.comment.Font = new System.Drawing.Font("Tahoma", 16F);
            this.comment.Location = new System.Drawing.Point(12, 158);
            this.comment.MaxLength = 1000;
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(313, 33);
            this.comment.TabIndex = 13;
            this.comment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // now
            // 
            this.now.AutoSize = true;
            this.now.BackColor = System.Drawing.Color.Transparent;
            this.now.Font = new System.Drawing.Font("Tahoma", 16F);
            this.now.Location = new System.Drawing.Point(312, 98);
            this.now.Name = "now";
            this.now.Size = new System.Drawing.Size(124, 27);
            this.now.TabIndex = 15;
            this.now.Text = "2023/10/19";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label5.Location = new System.Drawing.Point(252, 128);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(73, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "تعليق:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // getExcel
            // 
            this.getExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.getExcel.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.getExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getExcel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.getExcel.Location = new System.Drawing.Point(360, 8);
            this.getExcel.Name = "getExcel";
            this.getExcel.Size = new System.Drawing.Size(136, 33);
            this.getExcel.TabIndex = 20;
            this.getExcel.Text = "ملف إكسيل";
            this.getExcel.UseVisualStyleBackColor = false;
            this.getExcel.Click += new System.EventHandler(this.getExcel_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "worksheet.xlsx";
            this.saveFileDialog1.Filter = "Excel Workbook|*.xlsx";
            // 
            // maxDepo
            // 
            this.maxDepo.Font = new System.Drawing.Font("Tahoma", 16F);
            this.maxDepo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.maxDepo.Location = new System.Drawing.Point(618, 90);
            this.maxDepo.Name = "maxDepo";
            this.maxDepo.Size = new System.Drawing.Size(123, 33);
            this.maxDepo.TabIndex = 22;
            this.maxDepo.Text = "0";
            this.maxDepo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(754, 91);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(134, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "أقصى الإيداع:";
            // 
            // remDepo
            // 
            this.remDepo.Font = new System.Drawing.Font("Tahoma", 16F);
            this.remDepo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.remDepo.Location = new System.Drawing.Point(618, 169);
            this.remDepo.Name = "remDepo";
            this.remDepo.Size = new System.Drawing.Size(123, 33);
            this.remDepo.TabIndex = 26;
            this.remDepo.Text = "0";
            this.remDepo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(763, 170);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(125, 27);
            this.label9.TabIndex = 25;
            this.label9.Text = "باقي الإيداع:";
            // 
            // remWithdraw
            // 
            this.remWithdraw.Font = new System.Drawing.Font("Tahoma", 16F);
            this.remWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remWithdraw.Location = new System.Drawing.Point(618, 135);
            this.remWithdraw.Name = "remWithdraw";
            this.remWithdraw.Size = new System.Drawing.Size(123, 33);
            this.remWithdraw.TabIndex = 24;
            this.remWithdraw.Text = "0";
            this.remWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(747, 136);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(141, 27);
            this.label11.TabIndex = 23;
            this.label11.Text = "باقي السحب:";
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.withdraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdraw.Font = new System.Drawing.Font("Tahoma", 14F);
            this.withdraw.Location = new System.Drawing.Point(24, 77);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(115, 33);
            this.withdraw.TabIndex = 27;
            this.withdraw.Text = "سحب";
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.del.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Font = new System.Drawing.Font("Tahoma", 10F);
            this.del.Location = new System.Drawing.Point(453, 164);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(101, 33);
            this.del.TabIndex = 28;
            this.del.Text = "مسح البيانات";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.Del_Click);
            // 
            // newFirstCheck
            // 
            this.newFirstCheck.AutoSize = true;
            this.newFirstCheck.Font = new System.Drawing.Font("Tahoma", 12F);
            this.newFirstCheck.Location = new System.Drawing.Point(342, 171);
            this.newFirstCheck.Name = "newFirstCheck";
            this.newFirstCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.newFirstCheck.Size = new System.Drawing.Size(101, 23);
            this.newFirstCheck.TabIndex = 29;
            this.newFirstCheck.Text = "الأحدث أولاً";
            this.newFirstCheck.UseVisualStyleBackColor = true;
            this.newFirstCheck.CheckedChanged += new System.EventHandler(this.NewFirstCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.newFirstCheck);
            this.Controls.Add(this.del);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.remWithdraw);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maxDepo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.getExcel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.now);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.add);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.maxWithdraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.remDepo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فون كاش";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maxWithdraw;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Label now;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button getExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label maxDepo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button withdraw;
        public System.Windows.Forms.Label remDepo;
        public System.Windows.Forms.Label remWithdraw;
        private System.Windows.Forms.Button del;
        public System.Windows.Forms.CheckBox newFirstCheck;
    }
}

