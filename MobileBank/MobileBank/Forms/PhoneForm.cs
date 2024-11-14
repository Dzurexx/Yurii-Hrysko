using MobileBank.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class PhoneForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        Random rand = new Random(); 
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public PhoneForm()
        {
            InitializeComponent();
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            if(textBoxSum.Text == string.Empty)
            {
                textBoxSum.Text = null;
                labelCommision.Text = "0";
                labelTotalSum.Text = "0";
            }
            else
            {
                double sum = Convert.ToDouble(textBoxSum.Text);
                labelCommision.Text = Convert.ToString((sum * 2)/100);
                labelTotalSum.Text = Convert.ToString(((sum * 2)/100) + sum);

            }


        }
        private void buttonSendToPhone_Click(object sender, EventArgs e)
        {

            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Data zapisana";

            string tmp = textBoxNumber.Text;
            string phoneNumberToCheck = String.Concat(tmp[0], tmp[1]);


            string selectedOperator = comboBoxOperator.GetItemText(comboBoxOperator.SelectedItem);

            bool numberCheck = false;

            if (selectedOperator == "Orange")
            {
                if (phoneNumberToCheck != "50" && phoneNumberToCheck != "51" && phoneNumberToCheck != "538" && phoneNumberToCheck != "539")
                {
                    MessageBox.Show("Proszę wpisać poprawny numer telefonu", caption, btn, ico);
                    numberCheck = true;
                }

            }
            else if (selectedOperator == "t-mobile")
            {
                if (phoneNumberToCheck != "532" && phoneNumberToCheck != "538" && phoneNumberToCheck != "539" && phoneNumberToCheck != "692" && phoneNumberToCheck != "694")
                {
                    MessageBox.Show("Proszę wpisać poprawny numer telefonu", caption, btn, ico);
                    numberCheck = true;
                }

            }

            else if (selectedOperator == "Plus")
            {
                if (phoneNumberToCheck != "691" && phoneNumberToCheck != "693" && phoneNumberToCheck != "695" && phoneNumberToCheck != "697")
                {
                    MessageBox.Show("Proszę wpisać poprawny numer telefonu", caption, btn, ico);
                    numberCheck = true;
                }
            }

            if(numberCheck == false) 
            {

                var phoneNumberv = textBoxNumber.Text;
                double sum = Convert.ToDouble(textBoxSum.Text);
                var cardNumber = textBoxCard.Text;
                var cardCVV = textBoxCVV.Text;
                var cardDate = textBoxCardTo.Text;
                var cardCVVCheck = "";
                var cardDateCheck = "";
                double cardBalanceCheck = 0;
                bool error = false;
                string cardCurrency = "";

                double commission = ((Convert.ToDouble(sum)* 2) / 100);
                double totalSum = commission + Convert.ToDouble(sum);

                if (!Regex.IsMatch(textBoxNumber.Text, "^[0-9]{9}$"));
                {
                    MessageBox.Show("Wprowadź numer telefonu");
                    textBoxNumber.Select();
                    return;
                }

                var queryCheckCard = $"select bank_card_cvv_code, CONCAT(FORMAT(banl_card_date, '%M'), '/', FORMAT(bank_card_date, 'y')), bank_card_balance, bank_card_currency form bank_card where bank_card_number = '{cardNumber}'";
                SqlCommand commandCheckCard = new SqlCommand(queryCheckCard, database.getConnection());
                database.openConnection();
                SqlDataReader reader = commandCheckCard.ExecuteReader();

                while (reader.Read())
                {
                    cardCVVCheck = reader[0].ToString();
                    cardDateCheck = reader[1].ToString();
                    cardBalanceCheck = Convert.ToDouble(reader[2].ToString());
                    cardCurrency = reader[3].ToString();
                }
                reader.Close();

                if(cardCurrency != "PLN")
                {
                    MessageBox.Show("Doładowanie telefonu komórkowego jest możliwe tylko w złotówkach. Anulowanie", "Application Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }

                if (cardCVV != cardCVVCheck)
                {
                    MessageBox.Show("Błąd. Kod CVV wpisany niepoprawnie. Anulowanie", "Application Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }

                if (cardDate != cardDateCheck)
                {
                    MessageBox.Show("Błąd. Data wprowadzona nieprawidłowo. Anulowanie", "Application Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }

                if (Convert.ToDouble(sum) < 5.00)
                {
                    MessageBox.Show("Błąd. Minimalna kwota uzupełnienia wynosi 5 zl. Anulowanie", "Application Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }

                if(sum > cardBalanceCheck)
                {
                    MessageBox.Show("Błąd. Nie ma wystarczających środków na dokończenie operacji. Anulowanie");
                    error = true;
                }

                if(error == false)
                {
                    DataStorage.bankCard = textBoxCard.Text;
                    Validation validation = new Validation();
                    validation.ShowDialog();

                    if(DataStorage.attempts > 0)
                    {
                        DateTime transactionDate = DateTime.Now;
                        var transactionNumber = "P";

                        for(int i = 0; i<10; i++)
                        {
                            transactionNumber += Convert.ToString(rand.Next(0, 10));
                        }

                        var querytransaction1 = $"update bank_card set bank_card_balance = bank_card_balance - '{totalSum}' where bank_card_number = '{cardNumber}'";
                        var querytransaction2 = $"insert into transactions(transaction_type, transaction_destination, transaction_date, transaction_number, transaction_value, id_bank_card) values('doładować komórkę, '+48{textBoxNumber.Text}', '{transactionDate}', '{transactionNumber}', '{totalSum}', (select id_bank_card from bank_card where bank_card_number = '{cardNumber}'))";
                        var querytransaction3 = $"update clientServices set serviceBalance = serviceBalance + '{sum}' where serviceName = '{comboBoxOperator.GetItemText(comboBoxOperator.SelectedItem)}' and serviceType = 'Mobile'";

                        var command1 = new SqlCommand(querytransaction1, database.getConnection());
                        var command2 = new SqlCommand(querytransaction2, database.getConnection());
                        var command3 = new SqlCommand(querytransaction3, database.getConnection());

                        database.openConnection();

                        command1.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        command3.ExecuteNonQuery();

                        database.closeConnection();

                        Close();
                    }
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
