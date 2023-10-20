namespace Phone_Cash
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.maxWithdraw = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.getExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.maxDepo = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.remDepo = new System.Windows.Forms.NumericUpDown();
            this.remWithdraw = new System.Windows.Forms.NumericUpDown();
            this.equalMax = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.maxWithdraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remDepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remWithdraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.search.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Tahoma", 15F);
            this.search.Location = new System.Drawing.Point(491, 8);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(102, 33);
            this.search.TabIndex = 11;
            this.search.Text = "بحث";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(771, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "رقم الهاتف:";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Tahoma", 16F);
            this.phoneNumber.Location = new System.Drawing.Point(599, 8);
            this.phoneNumber.MaxLength = 11;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(166, 33);
            this.phoneNumber.TabIndex = 9;
            this.phoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumber_KeyPress);
            // 
            // maxWithdraw
            // 
            this.maxWithdraw.DecimalPlaces = 2;
            this.maxWithdraw.Font = new System.Drawing.Font("Tahoma", 16F);
            this.maxWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maxWithdraw.Location = new System.Drawing.Point(580, 56);
            this.maxWithdraw.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.maxWithdraw.Name = "maxWithdraw";
            this.maxWithdraw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maxWithdraw.Size = new System.Drawing.Size(151, 33);
            this.maxWithdraw.TabIndex = 13;
            this.maxWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.Location = new System.Drawing.Point(743, 58);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "أقصى السحب:";
            // 
            // comment
            // 
            this.comment.Font = new System.Drawing.Font("Tahoma", 16F);
            this.comment.Location = new System.Drawing.Point(12, 95);
            this.comment.MaxLength = 10000;
            this.comment.Multiline = true;
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(313, 79);
            this.comment.TabIndex = 15;
            this.comment.Text = "تعليق";
            this.comment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Tahoma", 16F);
            this.add.Location = new System.Drawing.Point(393, 131);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(128, 37);
            this.add.TabIndex = 14;
            this.add.Text = "حفظ";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 479);
            this.panel1.TabIndex = 17;
            // 
            // selectAll
            // 
            this.selectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.selectAll.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.selectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAll.Font = new System.Drawing.Font("Tahoma", 14F);
            this.selectAll.Location = new System.Drawing.Point(187, 175);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(122, 33);
            this.selectAll.TabIndex = 19;
            this.selectAll.Text = "اختيار الكل";
            this.selectAll.UseVisualStyleBackColor = false;
            this.selectAll.Click += new System.EventHandler(this.SelectAll);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label6.Location = new System.Drawing.Point(424, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "الباقي";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label5.Location = new System.Drawing.Point(597, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 27);
            this.label5.TabIndex = 18;
            this.label5.Text = "الرصيد";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label4.Location = new System.Drawing.Point(718, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "رقم الهاتف";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Tahoma", 14F);
            this.clear.Location = new System.Drawing.Point(749, 138);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(139, 33);
            this.clear.TabIndex = 18;
            this.clear.Text = "مسح الخانات";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // getExcel
            // 
            this.getExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.getExcel.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.getExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getExcel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.getExcel.Location = new System.Drawing.Point(338, 17);
            this.getExcel.Name = "getExcel";
            this.getExcel.Size = new System.Drawing.Size(128, 33);
            this.getExcel.TabIndex = 19;
            this.getExcel.Text = "ملف إكسيل";
            this.getExcel.UseVisualStyleBackColor = false;
            this.getExcel.Click += new System.EventHandler(this.GetExcel_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "worksheet.xlsx";
            this.saveFileDialog1.Filter = "Excel Workbook|*.xlsx";
            // 
            // maxDepo
            // 
            this.maxDepo.DecimalPlaces = 2;
            this.maxDepo.Font = new System.Drawing.Font("Tahoma", 16F);
            this.maxDepo.ForeColor = System.Drawing.Color.Green;
            this.maxDepo.Location = new System.Drawing.Point(580, 94);
            this.maxDepo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.maxDepo.Name = "maxDepo";
            this.maxDepo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maxDepo.Size = new System.Drawing.Size(151, 33);
            this.maxDepo.TabIndex = 21;
            this.maxDepo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label7.Location = new System.Drawing.Point(750, 96);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(134, 27);
            this.label7.TabIndex = 20;
            this.label7.Text = "أقصى الإيداع:";
            // 
            // remDepo
            // 
            this.remDepo.DecimalPlaces = 2;
            this.remDepo.Enabled = false;
            this.remDepo.Font = new System.Drawing.Font("Tahoma", 16F);
            this.remDepo.ForeColor = System.Drawing.Color.Green;
            this.remDepo.Location = new System.Drawing.Point(20, 50);
            this.remDepo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.remDepo.Name = "remDepo";
            this.remDepo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.remDepo.Size = new System.Drawing.Size(151, 33);
            this.remDepo.TabIndex = 25;
            this.remDepo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // remWithdraw
            // 
            this.remWithdraw.DecimalPlaces = 2;
            this.remWithdraw.Enabled = false;
            this.remWithdraw.Font = new System.Drawing.Font("Tahoma", 16F);
            this.remWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remWithdraw.Location = new System.Drawing.Point(20, 11);
            this.remWithdraw.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.remWithdraw.Name = "remWithdraw";
            this.remWithdraw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.remWithdraw.Size = new System.Drawing.Size(151, 33);
            this.remWithdraw.TabIndex = 23;
            this.remWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // equalMax
            // 
            this.equalMax.AutoSize = true;
            this.equalMax.Checked = true;
            this.equalMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.equalMax.Font = new System.Drawing.Font("Tahoma", 12F);
            this.equalMax.Location = new System.Drawing.Point(177, 24);
            this.equalMax.Name = "equalMax";
            this.equalMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.equalMax.Size = new System.Drawing.Size(123, 42);
            this.equalMax.TabIndex = 26;
            this.equalMax.Text = "الباقي يساوي\r\nالحد الأقصى";
            this.equalMax.UseVisualStyleBackColor = true;
            this.equalMax.CheckedChanged += new System.EventHandler(this.EqualMax_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(472, 72);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "الرصيد:";
            // 
            // balance
            // 
            this.balance.DecimalPlaces = 2;
            this.balance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.balance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.balance.Location = new System.Drawing.Point(347, 70);
            this.balance.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.balance.Name = "balance";
            this.balance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.balance.Size = new System.Drawing.Size(123, 33);
            this.balance.TabIndex = 28;
            this.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.equalMax);
            this.Controls.Add(this.remDepo);
            this.Controls.Add(this.remWithdraw);
            this.Controls.Add(this.maxDepo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.getExcel);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.add);
            this.Controls.Add(this.maxWithdraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فون كاش: الفتح";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxWithdraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remDepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remWithdraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.NumericUpDown maxWithdraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button selectAll;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button getExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown maxDepo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown remDepo;
        private System.Windows.Forms.NumericUpDown remWithdraw;
        private System.Windows.Forms.CheckBox equalMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown balance;
    }
}