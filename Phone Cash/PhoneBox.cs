using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Phone_Cash
{
    class PhoneBox : Control
    {
        public Label phone, balance, remaining;
        public Button select, edit, delete;


        static Font font = new Font("Tahoma", 16F);


        static Point phonePoint = new Point(15, 16);
        static Point palancePoint = new Point(191, 16);
        static Point remainingPoint = new Point(299, 16);

        static Size phoneSize = new Size(144, 27);
        static Size balanceSize = new Size(103, 27);
        static Size remainingSize = new Size(203, 27);




        public PhoneBox(string phoneText, string palanceText, string maximumText)
        {

            phone = new Label(); balance = new Label(); remaining = new Label();
            select = new Button(); edit = new Button(); delete = new Button();

            Size = new Size(851, 58);
            TabStop = false;

            phone.BackColor = Color.Transparent;
            phone.Font = font;
            phone.Location = phonePoint;
            phone.Size = phoneSize;
            phone.Text = phoneText;
            phone.TextAlign = ContentAlignment.MiddleCenter;

            balance.BackColor = Color.Transparent;
            balance.Font = font;
            balance.Location = palancePoint;
            balance.Size = balanceSize;
            balance.Text = palanceText;
            balance.TextAlign = ContentAlignment.MiddleCenter;

            remaining.BackColor = Color.Transparent;
            remaining.Font = font;
            remaining.Location = remainingPoint;
            remaining.Size = remainingSize;
            remaining.Text = maximumText;
            remaining.TextAlign = ContentAlignment.MiddleCenter;


            select.BackColor = Color.FromArgb(210, 255, 255);
            select.FlatAppearance.BorderColor = Color.Teal;
            select.FlatStyle = FlatStyle.Flat;
            select.Font = font;
            select.Location = new Point(584, 12);
            select.Size = new Size(102, 36);
            select.Tag = this;
            select.Text = "اختيار";
            select.TabStop = false;

            edit.BackColor = Color.FromArgb(255, 255, 210);
            edit.FlatStyle = FlatStyle.Flat;
            edit.Font = font;
            edit.ForeColor = Color.Blue;
            edit.Location = new Point(700, 13);
            edit.Size = new Size(36, 36);
            edit.Tag = this;
            edit.Text = "!";
            edit.TabStop = false;

            delete.BackColor = Color.FromArgb(255, 210, 210);
            delete.FlatAppearance.BorderColor = Color.Maroon;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = font;
            delete.Location = new Point(747, 13);
            delete.Size = new Size(92, 36);
            delete.Tag = this;
            delete.Text = "حذف";
            delete.TabStop = false;

            Controls.AddRange(new Control[] { phone, balance, remaining, select, edit, delete });
        }
    }
}
