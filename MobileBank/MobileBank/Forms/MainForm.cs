using MobileBank.Classes;
using MobileBank.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileBank
{
    public partial class MainForm : Form
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label_cardNumber.BringToFront();
            label_cardNumber.Text = "";
            label3.BringToFront();
            label_cardTo.BringToFront();
            label6.BringToFront();
            label_cardCvv.BringToFront();
            pictureBoxMasterCard.Visible = false;
            pictureBoxVisa.Visible = false;



            var queryMyCards = $"select id_bank_card, bank_card_number from bank_card where id_client = '{DataStorage.idClient}'";
            SqlDataAdapter commandMyCards = new SqlDataAdapter(queryMyCards, database.getConnection());
            database.openConnection();
            DataTable cards = new DataTable();
            commandMyCards.Fill(cards);
            cardsComboBox.DataSource = cards;
            cardsComboBox.ValueMember = "id_bank_card";
            cardsComboBox.DisplayMember = "bank_card_number";
            database.closeConnection();

            selectBankCard();

        }

        private void selectBankCard()
        {
            label_cardNumber.Text = "";
            string paymentSystem = "";
            string querySelectCard = $"select bank_card_number, bank_card_cvv_code, CONCAT(FORMAT(bank_card_date, '%m'), '/', FORMAT(bank_card_date, '%y')), bank_card_paymentSystem, bank_card_balance, bank_card_currency from bank_card where bank_card_number = '{cardsComboBox.GetItemText(cardsComboBox.SelectedItem)}'";
            SqlCommand command = new SqlCommand(querySelectCard, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var cardNumber = reader[0].ToString();

                int tmp = 0;
                int tmp1 = 4;
                    for (int m = 0; m < 4; m++)
                {
                    for (int n = 0; n < tmp1; n++)
                    {
                        label_cardNumber.Text += cardNumber[n].ToString();
                    }
                    label_cardNumber.Text += " ";
                    tmp += 4;
                    tmp1 += 4;
                }

                label_cardCvv.Text = reader[1].ToString();
                label_cardTo.Text = reader[2].ToString();
                paymentSystem = reader[3].ToString();
                balanceLabel.Text = Math.Round(Convert.ToDouble(reader[4]), 2).ToString();
                currencyLabel.Text = reader[5].ToString();
                DataStorage.cardCVV = label_cardCvv.Text;
                label_cardCvv.Text = "***";

            }
            reader.Close();


            if (paymentSystem == "Visa")
            {
                pictureBoxVisa.Visible = true;
                pictureBoxMasterCard.Visible = false;
            }
            else
            {
                pictureBoxMasterCard.Visible = true;
                pictureBoxVisa.Visible = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddBankCard addBankCard = new AddBankCard();
            addBankCard.ShowDialog();
        }

       

        private void pictureBox4_click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void buttonComunal_Click(object sender, EventArgs e)
        {
            CommunalPayments communalPayments = new CommunalPayments();
            DataStorage.cardNumber = cardsComboBox.GetItemText(cardsComboBox.SelectedItem);
            communalPayments.Show();
        }

        private void buttonInternet_Click(object sender, EventArgs e)
        {
            InternetAndTvPayment internetAndTvPayment = new InternetAndTvPayment();
            DataStorage.cardNumber = cardsComboBox.GetItemText(cardsComboBox.SelectedItem);
            internetAndTvPayment.Show();
        }

        private void buttonArmy_Click(object sender, EventArgs e)
        {
            ArmyHelp armyHelp = new ArmyHelp();
            DataStorage.cardNumber = cardsComboBox.GetItemText(cardsComboBox.SelectedItem);
            armyHelp.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPhone_Click(object sender, EventArgs e)
        {
            PhoneForm phoneForm = new PhoneForm();
            DataStorage.cardNumber = cardsComboBox.GetItemText(cardsComboBox.SelectedItem);
            DataStorage.phoneNumber = textBox1.Text;
            textBox1.Text = "";
            phoneForm.Show();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            SendToForm sendToForm = new SendToForm();
            DataStorage.bankCard = CardTextBox.Text;
            DataStorage.cardNumber = cardsComboBox.GetItemText(cardsComboBox.SelectedItem);
            cardsComboBox.Text = "";
            sendToForm.Show();
        }

        private void label_cardCvv_Click(object sender, EventArgs e)
        {
            if (label_cardCvv.Text == "***")
            {
                label_cardCvv.Text = DataStorage.cardCVV;
            }
            else
                label_cardCvv.Text = "***";
        }

        private void buttonCredit_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.Show();
        }

    }
}
