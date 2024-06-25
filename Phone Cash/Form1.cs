using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using ClosedXML.Excel;

namespace Phone_Cash
{
    public partial class Form1 : Form
    {
        FormSize fs;
        readonly static SQLiteConnection connection = StartForm.connection;
        readonly SQLiteCommand command;
        //SQLiteDataReader reader;
        SQLiteDataAdapter adapter;
        DataTable table;

        public Form1(string phone = null, string balanc = null, string remW = null, string remD = null, string maxW = null, string maxD = null, bool newFirst = false, string type = null)
        {
            InitializeComponent();
            allow = false;
            newFirstCheck.Checked = newFirst; allow = true;
            phoneNumber.Text = phone;
            balance.Text = balanc;
            remWithdraw.Text = remW;
            remDepo.Text = remD;
            maxWithdraw.Text = maxW;
            maxDepo.Text = maxD;
            command = new SQLiteCommand(connection);
            if (phone != null && phone != "")
                adapter = new SQLiteDataAdapter($"SELECT * FROM payments WHERE phone='{phoneNumber.Text}'" + (newFirstCheck.Checked ? " ORDER BY id DESC" : ""), connection);
            else
            {
                adapter = new SQLiteDataAdapter("SELECT * FROM payments" +(type != null && type.Trim() != "" ? $"SELECT * FROM payments where payments.phone = (select phones.phone from phones where type='{type}')" : "")+ (newFirstCheck.Checked ? " ORDER BY id DESC" : ""), connection);
                add.Enabled = false;
                withdraw.Enabled = false;
                amount.Enabled = false;
                comment.Enabled = false;
                phoneNumber.Enabled = false;
            }
            //width = ClientSize.Width; height = ClientSize.Height;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (phoneNumber.Text != "")
                {
                    connection.Open();

                    if (amount.Value <= Convert.ToDecimal(remDepo.Text))
                    {
                        balance.Text = (Convert.ToDecimal(balance.Text) + amount.Value).ToString();
                        remDepo.Text = (Convert.ToDecimal(remDepo.Text) - amount.Value).ToString();
                        command.CommandText = $"INSERT INTO payments (phone,date,balance,withdrawal_amount,deposit_amount,withdrawal_remaining,deposit_remaining,comment) VALUES ('{phoneNumber.Text}','{DateTime.Now}',{balance.Text},0,{amount.Value},{remWithdraw.Text},{remDepo.Text},'{comment.Text}')";
                        command.ExecuteNonQuery();
                        command.Cancel();
                        command.CommandText = $"Update phones SET balance={balance.Text},deposit_remaining={remDepo.Text} WHERE phone='{phoneNumber.Text}'";
                        command.ExecuteNonQuery();
                        command.Cancel();
                    }
                    else
                    {
                        MessageBox.Show("قيمة الإيداع أكبر من باقي الإيداع");
                    }
                }
                table = new DataTable();
                table.TableName = "عمليات الدفع";
                adapter.Fill(table);
                ChangeColumnName();
                dataGridView.DataSource = table;
                connection.Close();
                amount.Value = 0;
            }
            catch (Exception ex)
            {
                command.Cancel();
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            try
            {
                if (phoneNumber.Text != "")
                {
                    connection.Open();

                    if (amount.Value <= Convert.ToDecimal(balance.Text) && amount.Value <= Convert.ToDecimal(remWithdraw.Text))
                    {
                        balance.Text = (Convert.ToDecimal(balance.Text) - amount.Value).ToString();
                        remWithdraw.Text = (Convert.ToDecimal(remWithdraw.Text) - amount.Value).ToString();
                        command.CommandText = $"INSERT INTO payments (phone,date,balance,withdrawal_amount,deposit_amount,withdrawal_remaining,deposit_remaining,comment) VALUES ('{phoneNumber.Text}','{DateTime.Now}',{balance.Text},{amount.Value},0,{remWithdraw.Text},{remDepo.Text},'{comment.Text}')";
                        command.ExecuteNonQuery();
                        command.Cancel();
                        command.CommandText = $"Update phones SET balance={balance.Text},withdrawal_remaining={remWithdraw.Text} WHERE phone='{phoneNumber.Text}'";
                        command.ExecuteNonQuery();
                        command.Cancel();
                    }
                    else
                    {
                        MessageBox.Show("قيمة السحب أكبر من باقي السحب أو الرصيد");
                    }
                }

                table = new DataTable();
                table.TableName = "عمليات الدفع";
                adapter.Fill(table);
                ChangeColumnName();
                dataGridView.DataSource = table;
                connection.Close();
                amount.Value = 0;
            }
            catch (Exception ex)
            {
                command.Cancel();
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            now.Text = DateTime.Now.ToString();
            connection.Open();

            table = new DataTable();
            table.TableName = "عمليات الدفع";
            adapter.Fill(table);

            ChangeColumnName();

            dataGridView.DataSource = table;

            connection.Close();
        }

        void ChangeColumnName()
        {
            table.Columns[1].ColumnName = "رقم الهاتف";
            table.Columns[2].ColumnName = "التاريخ";
            table.Columns[3].ColumnName = "الرصيد";
            table.Columns[4].ColumnName = "قيمة السحب";
            table.Columns[5].ColumnName = "قيمة الإيداع";
            table.Columns[6].ColumnName = "باقي السحب";
            table.Columns[7].ColumnName = "باقي الإيداع";
            table.Columns[8].ColumnName = "تعليق";
        }

        private void timer1_Tick(object sender, EventArgs e) { now.Text = DateTime.Now.ToString(); }

        private void getExcel_Click(object sender, EventArgs e)
        {
            try
            {
                XLWorkbook wb = new XLWorkbook();
                table = new DataTable();
                table.TableName = "عمليات الدفع";
                adapter.Fill(table);
                ChangeColumnName();
                wb.Worksheets.Add(table);
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) wb.SaveAs(saveFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command.Cancel();
                command.CommandText = $"DELETE FROM payments WHERE phone='{phoneNumber.Text}'";
                if ((phoneNumber.Text == null || phoneNumber.Text == "") && MessageBox.Show("هل أنت متأكد من مسح كل البيانات؟", ">_<", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    command.CommandText = $"DELETE FROM payments; VACUUM;";
                }
                command.ExecuteNonQuery();
                command.Cancel();
                table = new DataTable();
                table.TableName = "عمليات الدفع";
                adapter.Fill(table);
                ChangeColumnName();
                dataGridView.DataSource = table;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool allow = false;
        private void NewFirstCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!allow) return;
            if (newFirstCheck.Checked) System.IO.File.WriteAllText("newFirst","1");
            else System.IO.File.WriteAllText("newFirst", "0");

            if (phoneNumber.Text != null && phoneNumber.Text != "")
                adapter = new SQLiteDataAdapter($"SELECT * FROM payments WHERE phone='{phoneNumber.Text}'" + (newFirstCheck.Checked? " ORDER BY id DESC":""), connection);
            else
            {
                adapter = new SQLiteDataAdapter("SELECT * FROM payments" + (newFirstCheck.Checked? " ORDER BY id DESC" : ""), connection);
            }

            Form1_Load(sender, e);
        }

        //int width = 0, height = 0;
        //private void Form1_SizeChanged(object sender, EventArgs e)
        //{
        //    fs = new FormSize(width, height, ClientSize.Width, ClientSize.Height);
        //    fs.SetControls(Controls);

        //    width = ClientSize.Width; height = ClientSize.Height;
        //    dataGridView.Size = new Size(ClientSize.Width - dataGridView.Location.X - 12, ClientSize.Height - dataGridView.Location.Y - 12);

        //}
    }
}
