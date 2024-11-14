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
    public partial class RegestrationForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public RegestrationForm()
        {
            InitializeComponent();
        }
        private void RegestrationForm_Load(object sender, EventArgs e)
        {
            LastNameTextBox.Select();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Data zapisana";
            if (!Regex.IsMatch(LastNameTextBox.Text, "[A-Za-z]+$"))
            {
                MessageBox.Show("Prosze wpisać nazwisko ponownie", caption, btn, ico);
                LastNameTextBox.Select();
                return;
            }

            if (!Regex.IsMatch(FirstNameTextBox.Text, "[A-Za-z]+$"))
            {
                MessageBox.Show("Prosze wpisać imię ponownie", caption, btn, ico);
                FirstNameTextBox.Select();
                return;
            }

            if (!Regex.IsMatch(MiddleNameTextBox.Text, "[A-Za-z]"))
            {
                MessageBox.Show("Prosze wpisać imię ojca", caption, btn, ico);
                MiddleNameTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(GenderComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Prosze wybrać płeć", caption, btn, ico);
                GenderComboBox.Select();
                return;
            }

            if (!Regex.IsMatch(PasswordTextBox.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                MessageBox.Show("Prosze wpisać hasło", caption, btn, ico);
                PasswordTextBox.Select();
                return;
            }

            if (!Regex.IsMatch(ConfirmPasswordTextBox.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                MessageBox.Show("Prosze wpisać hasło", caption, btn, ico);
                ConfirmPasswordTextBox.Select();
                return;
            }

            if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Hasła nie są jednakowe", caption, btn, ico);
                ConfirmPasswordTextBox.SelectAll();
                return;
            }


            if (!Regex.IsMatch(EmailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Prosze wpisać mail", caption, btn, ico);
                EmailTextBox.Select();
                return;
            }

            if (!Regex.IsMatch(NumberPhoneTextBox.Text, "^[+][4][8][0-9]{7,14}$"))
            {
                MessageBox.Show("Prosze wpisać numer telefonu", caption, btn, ico);
                NumberPhoneTextBox.Select();
                return;
            }

            string yourSQL = "SELECT client_phone_number FROM client WHERE client_phone_number = '" + NumberPhoneTextBox.Text + "'";

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(yourSQL, database.getConnection());

            adapter.SelectCommand = command;
           

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Ten nume telefonu jest już zarejestrowany!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NumberPhoneTextBox.SelectAll();
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Chcesz zapisać dane?", "Zapisywania danych", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                String mySQL = String.Empty;

                mySQL += "INSERT INTO client (client_last_name, client_first_name, client_middle_name, client_gender, client_password, client_email, client_phone_number) ";
                mySQL += "VALUES ('" + LastNameTextBox.Text + "','" + FirstNameTextBox.Text + "','" + MiddleNameTextBox.Text + "')";
                mySQL += "'" + GenderComboBox.SelectedItem.ToString() + "','" + PasswordTextBox.Text + "','" + NumberPhoneTextBox + "')";

                database.openConnection();
                SqlCommand commandAddNewUser = new SqlCommand(mySQL, database.getConnection());
                commandAddNewUser.ExecuteNonQuery();

                MessageBox.Show("Konto jest stworzone", "Dane są zapisane", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearControls(); //clearControls
                database.closeConnection();
                Close();
            }
        }

        private void ClearControls()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                textBox.Text = String.Empty;
            }

            foreach (ComboBox comboBox in Controls.OfType<ComboBox>())
            {
                comboBox.SelectedItem = null;
            }
        }

        private void ClearButton_Click_Click(object sender, EventArgs e)
        {
            LastNameTextBox.Select();
            ClearControls();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                ConfirmPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}