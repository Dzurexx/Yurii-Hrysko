using System;
using System.Data;
using MobileBank.Classes;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileBank.Forms
{
    public partial class SendToForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        Random rand = new Random();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int Wparam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();
        

        public SendToForm()
        {
            InitializeComponent();
        }

        private void SendToForm_Load(object sender, EventArgs e)
        {
            TextBoxCardDestination.Text = DataStorage.bankCard;
            TextBoxCard.Text = DataStorage.cardNumber;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            double dolar = 4.17;
            double euro = 4.51;

            var cardNumber = TextBoxCard.Text;
            var cardCVV = TextBoxCVV.Text;
            var cardDate = TextBoxCardTo.Text;
            var destinationCard = TextBoxCardDestination.Text;
            double sum = Convert.ToDouble(TextBoxSum.Text);
            var cardCurrency = "";
            var cardCurrency2 = "";
            var cardCVVCheck = "";
            var cardDateCheck = "";
            double cardBalanceCheck = 0;
            bool error = false;

            var queryCheckCard = $"select bank_card_cvv_code, CONCAT(FORMAT(bank_kard_date, '%M'), '/', FORMAT(bank_kard_date, '%y')), bank,kard_balance, bank_card_currency from bank_card where card_number = '{cardNumber}'";
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

            if(cardCVV != cardCVVCheck)
            {
                MessageBox.Show("Błąd. Wprowadzono nieprawidłowy kod CVV", "Anulowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (cardDate != cardDateCheck)
            {
                MessageBox.Show("Błąd. Błąd. Data karty wpisana nieprawidłowo", "Anulowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            var queryCheckCardNumber = $"select id_bank_card, bank_card_currency from bank_card where bank_card_number = '{destinationCard}'";
            SqlCommand commandCheckCardNumber = new SqlCommand(queryCheckCardNumber, database.getConnection());

            adapter.SelectCommand = commandCheckCardNumber;
            adapter.Fill(table);
            SqlDataReader reader1 = commandCheckCardNumber.ExecuteReader();
            while (reader1.Read())
            {
                cardCurrency2 = reader1[1].ToString();
            }
            reader1.Close();

            if(table.Rows.Count == 0) 
            {
                MessageBox.Show("Błąd. Niepoprawne dane karty odbiorcy", "Anulowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
                //Błąd. Niepoprawne dane karty odbiorcy Minimalna kwota przelewu 1.00zł
            }

            if(Convert.ToDouble(sum) < 1.00)
            {
                MessageBox.Show("Błąd. Minimalna kwota przelewu 1.00zł", "Anulowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (cardNumber == destinationCard)
            {
                MessageBox.Show("Błąd. Nie możesz przelać środków na tę kartę", "Anulowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (sum > cardBalanceCheck)
            {
                MessageBox.Show("Błąd. Niewystarczające środki do sfinalizowania transakcji", "Anulowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (error == false)
            {
                DataStorage.bankCard = TextBoxCard.Text;
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

                    var queryTransaction1 = $"";
                    var queryTransaction2 = $"";

                    if(cardCurrency == "PLN" &&  cardCurrency == "USD")
                    {
                        queryTransaction1 = $"update bank_card set bank_card_balance = bank_card_balance - '{sum}' where bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"update bank_card set bank_card_balance = bank_card_balance + '{sum /= dolar}' where bank_card_number = '{destinationCard}'";
                    }

                    else if (cardCurrency == "PLN" && cardCurrency == "EUR")
                    {
                        queryTransaction1 = $"update bank_card set bank_card_balance = bank_card_balance - '{sum}' where bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"update bank_card set bank_card_balance = bank_card_balance + '{sum /= euro}' where bank_card_number = '{destinationCard}'";
                    }

                    else if (cardCurrency == "USD" && cardCurrency == "PLN")
                    {
                        queryTransaction1 = $"update bank_card set bank_card_balance = bank_card_balance - '{sum}' where bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"update bank_card set bank_card_balance = bank_card_balance + '{sum *= dolar}' where bank_card_number = '{destinationCard}'";
                    }

                    else if (cardCurrency == "USD" && cardCurrency == "EUR")
                    {
                        queryTransaction1 = $"update bank_card set bank_card_balance = bank_card_balance - '{sum}' where bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"update bank_card set bank_card_balance = bank_card_balance + '{sum *= 0.96}' where bank_card_number = '{destinationCard}'";
                    }

                    else if (cardCurrency == "EUR" && cardCurrency == "PLN")
                    {
                        queryTransaction1 = $"update bank_card set bank_card_balance = bank_card_balance - '{sum}' where bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"update bank_card set bank_card_balance = bank_card_balance + '{sum *= euro}' where bank_card_number = '{destinationCard}'";
                    }

                    else
                    {
                        queryTransaction1 = $"update bank_card set bank_card_balance = bank_card_balance - '{sum *= 1.04}' where bank_card_number = '{cardNumber}'";
                        queryTransaction2 = $"update bank_card set bank_card_balance = bank_card_balance + '{sum}' where bank_card_number = '{destinationCard}'";
                    }

                    var queryTransaction3 = $"insert into transactions(transaction_type, transaction_destination, transaction_date, transaction_number, transaction_value, id_bank_card) values('Transfer', '{destinationCard}', '{transactionDate}', '{transactionNumber}', '{sum}', (select id_bank_card, from bank_card where bank_card_number = '{cardNumber}'))";
                    var command1 = new SqlCommand(queryTransaction1, database.getConnection());
                    var command2 = new SqlCommand(queryTransaction2, database.getConnection());
                    var command3 = new SqlCommand(queryTransaction3, database.getConnection());
                    database.openConnection();
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command3.ExecuteNonQuery();
                    database.closeConnection();

                    Close();

                }
            }
        }


        private void SendToForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
