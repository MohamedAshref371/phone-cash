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
        readonly static SQLiteConnection connection = StartForm.connection;
        readonly SQLiteCommand command;
        //SQLiteDataReader reader;
        SQLiteDataAdapter adapter;
        DataTable table;

        public Form1(string phone = null, string balanc = null, string remW = null, string remD = null, string maxW = null, string maxD = null)
        {
            InitializeComponent();
            phoneNumber.Text = phone;
            balance.Text = balanc;
            remWithdraw.Text = remW;
            remDepo.Text = remD;
            maxWithdraw.Text = maxW;
            maxDepo.Text = maxD;
            command = new SQLiteCommand(connection);
            if (phone != null && phone != "")
                adapter = new SQLiteDataAdapter($"SELECT * FROM payments WHERE phone='{phone}'", connection);
            else
            {
                adapter = new SQLiteDataAdapter("SELECT * FROM payments", connection);
                add.Enabled = false;
                withdraw.Enabled = false;
                amount.Enabled = false;
                comment.Enabled = false;
                phoneNumber.Enabled = false;
            }
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
                        MessageBox.Show("DepositAmount Is Greater Than DepositRemaining.");
                    }
                }
                table = new DataTable();
                table.TableName = "عمليات الدفع";
                adapter.Fill(table);
                ChangeColumnName();
                dataGridView.DataSource = table;
                connection.Close();
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
                        MessageBox.Show("WithdrawalAmount Is Greater Than WithdrawalRemaining Or Balance.");
                    }
                }

                table = new DataTable();
                table.TableName = "عمليات الدفع";
                adapter.Fill(table);
                ChangeColumnName();
                dataGridView.DataSource = table;
                connection.Close();
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
    }
}
