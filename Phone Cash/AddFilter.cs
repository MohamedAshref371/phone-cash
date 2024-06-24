using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Cash
{
    public partial class AddFilter : Form
    {
        readonly static SQLiteConnection connection = StartForm.connection;
        readonly SQLiteCommand command;
        SQLiteDataReader reader;

        public string fltrName = "";
        public string fltrStartWith = "";

        public AddFilter()
        {
            InitializeComponent();
            command = new SQLiteCommand(connection);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (filterName.Text == string.Empty || filterStartWith.Text == string.Empty)
            {
                MessageBox.Show("إملأ الحقول الفارغة");
                return;
            }
            fltrName = filterName.Text;
            fltrStartWith = filterStartWith.Text;

            connection.Open();
            command.CommandText = $"SELECT * FROM filter WHERE name='{fltrName}'";
            reader = command.ExecuteReader();
            DialogResult res = DialogResult.Yes;
            if (reader.HasRows)
            {
                reader.Close();
                command.Cancel();
                res = MessageBox.Show("هذا الإسم موجود بالفعل، هل تريد تحديثه ؟",":/", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    command.CommandText = $"UPDATE filter SET start_with = '{fltrStartWith}' WHERE name = '{fltrName}'";
                    command.ExecuteNonQuery();
                }
            }
            else if (res == DialogResult.Yes)
            {
                reader.Close();
                command.Cancel();
                command.CommandText = $"INSERT INTO filter VALUES ('{fltrName}','{fltrStartWith}')";
                command.ExecuteNonQuery();
            }
            
            command.Cancel();
            connection.Close();
            if (res != DialogResult.Cancel)
                Close();
        }
    }
}
