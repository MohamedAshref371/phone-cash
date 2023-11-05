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


        static readonly Font font = new Font("Tahoma", 16F);

        static readonly Point phonePoint = new Point(692, 16); //new Point(15, 16);
        static readonly Point palancePoint = new Point(557, 16); //new Point(191, 16);
        static readonly Point remainingPoint = new Point(349, 16); //new Point(299, 16);
        static readonly Point selectPoint = new Point(189, 13); //new Point(584, 12);
        static readonly Point editPoint = new Point(97, 13); //new Point(700, 13);
        static readonly Point deletePoint = new Point(5, 13); //new Point(747, 13);

        static readonly Size phoneSize = new Size(144, 27);
        static readonly Size balanceSize = new Size(103, 27);
        static readonly Size remainingSize = new Size(203, 27);
        static readonly Size selectSize = new Size(90, 36);
        static readonly Size editSize = new Size(90, 36);
        static readonly Size deleteSize = new Size(90, 36);


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
            select.Location = selectPoint;
            select.Size = selectSize;
            select.Tag = this;
            select.Text = "اختيار";
            select.TabStop = false;

            edit.BackColor = Color.FromArgb(255, 255, 210);
            edit.FlatStyle = FlatStyle.Flat;
            edit.Font = font;
            edit.ForeColor = Color.Blue;
            edit.Location = editPoint;
            edit.Size = editSize;
            edit.Tag = this;
            edit.Text = "تعديل";
            edit.TabStop = false;

            delete.BackColor = Color.FromArgb(255, 210, 210);
            delete.FlatAppearance.BorderColor = Color.Maroon;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = font;
            delete.Location = deletePoint;
            delete.Size = deleteSize;
            delete.Tag = this;
            delete.Text = "حذف";
            delete.TabStop = false;

            Controls.AddRange(new Control[] { phone, balance, remaining, select, edit, delete });
        }
    }
}
