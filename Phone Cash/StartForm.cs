using ClosedXML.Excel;
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
    public partial class StartForm : Form
    {
        FormSize fs;
        public static readonly SQLiteConnection connection = new SQLiteConnection("Data Source=phone cash.db; Version=3;");
        readonly SQLiteCommand command;
        SQLiteDataReader reader;

        SQLiteDataAdapter adapter;
        DataTable table;

        PhoneBox pb;
        PhoneBox pbLast = null;

        //public static readonly string save = Microsoft.VisualBasic.FileIO.SpecialDirectories.AllUsersApplicationData.Replace(Application.ProductVersion, "");

        public StartForm()
        {
            InitializeComponent();
            command = new SQLiteCommand(connection);
            adapter = new SQLiteDataAdapter("SELECT * FROM phones", connection);
            table = new DataTable { TableName = "phones" };
            //width = ClientSize.Width; height = ClientSize.Height;
        }

        void AddPhoneBoxToPanel(string s1, string s2, string s3)
        {
            pb = new PhoneBox(s1, s2, s3);
            pb.Location = new Point(3, pbLast!=null? pbLast.Location.Y + 58 : 5);
            pb.select.Click += Select_Click;
            pb.edit.Click += Edit_Click;
            pb.delete.Click += Delete_Click;
            panel1.Controls.Add(pb);
            pbLast = pb;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection.Open();
            command.CommandText = "SELECT * FROM phones";
            reader = command.ExecuteReader();

            while (reader.Read()) AddPhoneBoxToPanel(reader.GetString(0), reader.GetDouble(1).ToString(), reader.GetDouble(2).ToString() + " - " + reader.GetDouble(3).ToString());

            reader.Close();
            command.Cancel();
            connection.Close();
        }

        private void PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '' /*علامة الرجوع*/ && e.KeyChar != '' /*Ctrl X*/ && e.KeyChar != '' /*Ctrl C*/ && e.KeyChar != '' /*Ctrl V*/)
            {
                e.KeyChar = '\0';
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (equalMax.Checked)
            {
                remWithdraw.Value = maxWithdraw.Value;
                remDepo.Value = maxDepo.Value;
            }
            if (phoneNumber.Text != "")
                try
                {
                    connection.Open();
                    command.CommandText = $"SELECT * FROM phones WHERE phone='{phoneNumber.Text}'";
                    reader = command.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        command.Cancel();
                        command.CommandText = $"INSERT INTO phones (phone,balance,withdrawal_remaining,deposit_remaining,maximum_withdrawal,maximum_deposit,comment) VALUES ('{phoneNumber.Text}',{balance.Value},{remWithdraw.Value},{remDepo.Value},{maxWithdraw.Value},{maxDepo.Value},'{comment.Text}')";
                        command.ExecuteNonQuery();
                        AddPhoneBoxToPanel(phoneNumber.Text, balance.Value.ToString(), remWithdraw.Value.ToString() + " - " + remDepo.Value.ToString());
                    }
                    else
                    {
                        reader.Close();
                        if (MessageBox.Show("هل أنت متأكد من أنك تريد تحديث البيانات", "o_O", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            command.Cancel();
                            command.CommandText = $"UPDATE phones SET balance={balance.Value},withdrawal_remaining={(equalMax.Checked? maxWithdraw.Value : remWithdraw.Value)},deposit_remaining={(equalMax.Checked ? maxDepo.Value : remDepo.Value)},maximum_withdrawal={maxWithdraw.Value},maximum_deposit={maxDepo.Value},comment='{comment.Text}' WHERE phone='{phoneNumber.Text}'";
                            command.ExecuteNonQuery();
                            Search_Click(sender, e);
                            if (pb != null)
                            {
                                pb.balance.Text = balance.Value.ToString();
                                pb.remaining.Text = $"{remWithdraw.Value} - {remDepo.Value}";
                            }
                        }
                    }
                    command.Cancel();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            else
                MessageBox.Show("أكتب رقم الهاتف");
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                pb = (PhoneBox)((Button)sender).Tag;
                command.CommandText = $"SELECT * FROM phones WHERE phone='{pb.phone.Text}'";
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    equalMax.Checked = false;
                    phoneNumber.Text = reader.GetString(0);
                    balance.Value = reader.GetDecimal(1);
                    remWithdraw.Value = reader.GetDecimal(2);
                    remDepo.Value = reader.GetDecimal(3);
                    maxWithdraw.Value = reader.GetDecimal(4);
                    maxDepo.Value = reader.GetDecimal(5);
                    comment.Text = reader.GetString(6);
                }
                reader.Close();
                command.Cancel();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                pb = (PhoneBox)((Button)sender).Tag;
                command.CommandText = $"SELECT * FROM payments WHERE phone='{pb.phone.Text}'";
                reader = command.ExecuteReader();
                if (!reader.HasRows || MessageBox.Show("يوجد عمليات على هذا الرقم\nهل أنت متأكد بأنك تريد حذفه؟",":'(", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    pb.Enabled = false;
                    pb.Size = new Size(pb.Size.Width, 30);
                    pb.phone.Location = new Point(pb.phone.Location.X, 0);
                    pb.remaining.Visible = false; pb.balance.Visible = false;
                    pb.delete.Visible = false; pb.edit.Visible = false; pb.select.Visible = false;
                    //panel1.Controls.Remove(pb);

                    reader.Close();
                    command.Cancel();
                    command.CommandText = $"DELETE FROM payments WHERE phone='{pb.phone.Text}'; DELETE FROM phones WHERE phone='{pb.phone.Text}'";
                    command.ExecuteNonQuery();

                    pb.phone.Text = "تم الحذف";
                }
                reader.Close();
                command.Cancel();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string s0 = null, s1 = null, s2 = null, s3 = null, s4 = null, s5 = null;
                pb = (PhoneBox)((Button)sender).Tag;
                command.CommandText = $"SELECT * FROM phones WHERE phone='{pb.phone.Text}'";
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    s0 = reader.GetString(0);
                    s1 = reader.GetDouble(1).ToString();
                    s2 = reader.GetDouble(2).ToString();
                    s3 = reader.GetDouble(3).ToString();
                    s4 = reader.GetDouble(4).ToString();
                    s5 = reader.GetDouble(5).ToString();
                }
                reader.Close();
                command.Cancel();
                connection.Close();
                Form1 f = new Form1(s0, s1, s2, s3, s4, s5, System.IO.File.Exists("newFirst") && System.IO.File.ReadAllText("newFirst") == "1");
                f.ShowDialog();
                pb.balance.Text = f.balance.Text;
                pb.remaining.Text = $"{f.remWithdraw.Text} - {f.remDepo.Text}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectAll(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command.CommandText = $"SELECT balance FROM phones";
                reader = command.ExecuteReader();
                double count = 0;
                while (reader.Read()) count += reader.GetDouble(0);
                reader.Close();
                command.Cancel();
                connection.Close();
                Form1 f = new Form1(balanc: count.ToString(), newFirst: System.IO.File.Exists("newFirst") && System.IO.File.ReadAllText("newFirst") == "1");
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (phoneNumber.Text != "")
                for (int i = 0; i < panel1.Controls.Count; i++)
                {
                    pb = (PhoneBox)panel1.Controls[i];
                    if (pb.phone.Text.Contains(phoneNumber.Text))
                    {
                        pb.Select();
                        break;
                    }
                    pb = null;
                }
            else
                MessageBox.Show("أكتب رقم الهاتف");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            phoneNumber.Text = "";
            balance.Value = 0;
            maxWithdraw.Value = 0;
            maxDepo.Value = 0;
            remWithdraw.Value = 0;
            remDepo.Value = 0;
        }

        private void GetExcel_Click(object sender, EventArgs e)
        {
            try
            {
                XLWorkbook wb = new XLWorkbook();
                table.Clear();
                adapter.Fill(table);
                wb.Worksheets.Add(table);
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) wb.SaveAs(saveFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EqualMax_CheckedChanged(object sender, EventArgs e)
        {
            if (equalMax.Checked)
            {
                remWithdraw.Enabled = false;
                remDepo.Enabled = false;
            }
            else
            {
                remWithdraw.Enabled = true;
                remDepo.Enabled = true;
            }
        }

        //int width=0, height=0;
        //private void StartForm_SizeChanged(object sender, EventArgs e)
        //{
        //    fs = new FormSize(width,height, ClientSize.Width, ClientSize.Height);
        //    fs.SetControls(Controls);
        //    fs.SetControls(panel1.Controls);
        //    for (int i=0; i< panel1.Controls.Count; i++)
        //        fs.SetControls(((PhoneBox)panel1.Controls[i]).Controls);

        //    width = ClientSize.Width; height = ClientSize.Height;
        //}
    }
}
