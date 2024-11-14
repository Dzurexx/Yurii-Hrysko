using MobileBank.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class AddBankCard : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        DataBaseConnection database = new DataBaseConnection();
        Random rand = new Random();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();
        public AddBankCard()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBankCard_Load(object sender, EventArgs e)
        {
            cardTypeСomboBox.SelectedIndex = 0;
            currencyComboBox.SelectedIndex = 0;
            paymentSystemComboBox.SelectedIndex = 0;
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            var cardType = cardTypeСomboBox.GetItemText(cardTypeСomboBox.SelectedItem);
            var currency = currencyComboBox.GetItemText(currencyComboBox.SelectedItem);
            var paymentSystem = paymentSystemComboBox.GetItemText(paymentSystemComboBox.SelectedItem);
            var cardNumber = "";
            var cardPin = numericUpDownPin.Value;
            var cvvCode = "";
            bool isCardFree = false;
            DateTime dateTime = DateTime.Now;
            var cardDate = dateTime.AddYears(4);

            for(int i = 0; i < 3; i++)
            {
                cvvCode += Convert.ToString(rand.Next(0, 10));
            }

            do
            {
                if (paymentSystem == "Visa")
                {
                    cardNumber += "4";
                    for (int i = 0; i < 15; i++)
                    {
                        cardNumber += Convert.ToString(rand.Next(0, 10));
                    }
                }

                else
                {
                    cardNumber += "5";
                    for (int i = 0; i < 15; i++)
                    {
                        cardNumber += Convert.ToString(rand.Next(0, 10));
                    }

                }

                var queryCheckCardNumber = $"select * from bank_card where bank_card_number = '{cardNumber}'";

                SqlCommand commanad = new SqlCommand(queryCheckCardNumber, database.getConnection());

                adapter.SelectCommand = commanad;
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    isCardFree = true;
                }
            } while (isCardFree == false);

            var queryAddNewCard = $"insert into bank_card(bank_card_type, bank_card_number, bank_card_cvv_code, bank_card_currency, bank_card_paymentSystem, bank_card_date, id_client, bank_card_pin) values = ('{cardType}', '{cardNumber}', '{cvvCode}', '{currency}', '{DataStorage.idClient}', '{cardPin}')";
            SqlCommand commandAddNewCard = new SqlCommand(queryAddNewCard, database.getConnection());
            database.openConnection();
            commandAddNewCard.ExecuteNonQuery();
            database.closeConnection();

            MessageBox.Show("Karta utworzona pomyślnie! Dane zapisane", "Application Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

        }

        private void AddBankCard_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
