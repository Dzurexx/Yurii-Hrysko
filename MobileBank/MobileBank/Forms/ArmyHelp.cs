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
    public partial class ArmyHelp : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        Random rand = new Random();
        DataTable operators = new DataTable();
        Validation validation = new Validation();

        public ArmyHelp()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        private void ArmyHelp_Load(object sender, EventArgs e)
        {
            textBoxCard.Text = DataStorage.cardNumber;

            var queryChooseOperator = $"select id_services, serviceName from clientServices where serviceType = 'charity'";
            SqlDataAdapter commandChooseOperator = new SqlDataAdapter(queryChooseOperator, database.getConnection());
            database.openConnection();
            commandChooseOperator.Fill(operators);
            comboBoxArmyHelp.DataSource = operators;
            comboBoxArmyHelp.ValueMember = "id_service";
            comboBoxArmyHelp.DataSource = "serviceName";
            database.closeConnection();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;

            string caption = "Data zapisana";
            var PersonalAccount = textBoxPersonalAccount.Text;
            double sum = Convert.ToDouble(textBoxSum.Text);
            var cardNumber = textBoxCard.Text;
            var cardCVV = textBoxCVV.Text;
            var cardDate = textBoxCardTo.Text;
            var cardCVVCheck = "";
            var cardDateCheck = "";
            double cardBalanceCheck = 0;
            bool error = false;
            string cardCurrency = "";

            if (!Regex.IsMatch(textBoxPersonalAccount.Text, "^[0-9]{10}$")) ;
            {
                MessageBox.Show("Wpisz poprawnie swój numer konta", caption, btn, ico);
                textBoxPersonalAccount.Select();
                return;
            }

            var queryCheckCard = $"select bank_card_cvv_code, CONCAT(FORMAT(bank_card_date, '%M'), '/' FORMAT(bank_card_date, '%y')), bank_card_balance, bank_kard_currency from bank_card where bank_kard_number = '{cardNumber}'";
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

            if (cardCurrency != "PLN")
            {
                MessageBox.Show("Pomoc wojskowa jest dostępna tylko w złotówkach", "Application Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (sum > cardBalanceCheck)
            {
                MessageBox.Show("Błąd. Nie ma wystarczających środków na dokończenie operacji. Anulowanie");
                error = true;
            }

            if (error == false)
            {
                DataStorage.bankCard = textBoxCard.Text;
                validation.ShowDialog();

                if (DataStorage.attempts > 0)
                {
                    DateTime transactionDate = DateTime.Now;
                    var transactionNumber = "P";

                    for (int i = 0; i < 10; i++)
                    {
                        transactionNumber += Convert.ToString(rand.Next(0, 10));
                    }

                    var queryTransaction1 = $"update bank_card, set bank_card_balance = bank_card_balance - '{sum}' where bank_kard_number = '{cardNumber}'";

                    var queryTransaction2 = $"insert into transactions(transaction_type, transaction_destination, transaction_date, transaction_number, transaction_value, id_bank_card) values('Opłata za usługi komunalne', '{comboBoxArmyHelp.GetItemText(comboBoxArmyHelp.SelectedItem)}'), '{transactionDate}', '{transactionNumber}', '{sum}', (select id_bank_card, from bank_card where bank_card_number = '{cardNumber}'))";

                    var queryTransaction3 = $"update clientServices set serviceBalance = serviceBalance + '{sum}' where servisName = '{comboBoxArmyHelp.GetItemText(comboBoxArmyHelp.SelectedItem)}' and serviceType = 'communal'";

                    var queryTransaction4 = $"insert into clientPersonalAccount(personal_account, id_service, id_client) values('{textBoxPersonalAccount.Text}', (select id_service, from clientServices where serviceName = '{comboBoxArmyHelp.GetItemText(comboBoxArmyHelp.SelectedItem)}'), '{DataStorage.idClient}')";


                    var command1 = new SqlCommand(queryTransaction1, database.getConnection());
                    var command2 = new SqlCommand(queryTransaction2, database.getConnection());
                    var command3 = new SqlCommand(queryTransaction3, database.getConnection());
                    var command4 = new SqlCommand(queryTransaction4, database.getConnection());

                    database.openConnection();

                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command3.ExecuteNonQuery();
                    command4.ExecuteNonQuery();

                    Close();
                }
            }
        }

        private void ArmyHelp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
