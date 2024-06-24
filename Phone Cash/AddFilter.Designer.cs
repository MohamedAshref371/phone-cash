namespace Phone_Cash
{
    partial class AddFilter
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.filterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filterStartWith = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Tahoma", 18F);
            this.nameLabel.Location = new System.Drawing.Point(368, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameLabel.Size = new System.Drawing.Size(126, 29);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "إسم الفلتر:";
            // 
            // filterName
            // 
            this.filterName.Font = new System.Drawing.Font("Tahoma", 18F);
            this.filterName.Location = new System.Drawing.Point(70, 28);
            this.filterName.MaxLength = 15;
            this.filterName.Name = "filterName";
            this.filterName.Size = new System.Drawing.Size(274, 36);
            this.filterName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.Location = new System.Drawing.Point(368, 131);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "يبدأ الرقم بـ :";
            // 
            // filterStartWith
            // 
            this.filterStartWith.Font = new System.Drawing.Font("Tahoma", 18F);
            this.filterStartWith.Location = new System.Drawing.Point(70, 124);
            this.filterStartWith.MaxLength = 7;
            this.filterStartWith.Name = "filterStartWith";
            this.filterStartWith.Size = new System.Drawing.Size(274, 36);
            this.filterStartWith.TabIndex = 3;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Tahoma", 16F);
            this.add.Location = new System.Drawing.Point(12, 208);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(141, 42);
            this.add.TabIndex = 4;
            this.add.Text = "إضافة";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.cancel.Location = new System.Drawing.Point(435, 208);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(141, 42);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "إلغاء";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 262);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.filterStartWith);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterName);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFilter";
            this.Text = "AddFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox filterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterStartWith;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancel;
    }
}