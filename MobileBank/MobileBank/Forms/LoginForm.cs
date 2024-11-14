using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using MobileBank.Classes;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileBank.Forms;

namespace MobileBank
{
    public partial class LoginForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public LoginForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWhd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PhoneNumberTextBox.Select();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegestrationForm regestrationForm = new RegestrationForm();
            regestrationForm.ShowDialog();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PasswordTextBox.Text) && !string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                var querySelectClien = $"SELECT * FROM client WHERE client_phone_number = '{PhoneNumberTextBox.Text}' AND client_password = '{PasswordTextBox.Text}'";
                var queryGetId = $"select id_client from client where client_phone_number = '{PhoneNumberTextBox}'";
                var commandGetId = new SqlCommand(queryGetId, database.getConnection());

                database.openConnection();
                SqlDataReader reader = commandGetId.ExecuteReader();
                while (reader.Read())
                {
                    DataStorage.idClient = reader[0].ToString();
                }
                reader.Close();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand(querySelectClien, database.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    PhoneNumberTextBox.Clear();
                    PasswordTextBox.Clear();
                    ShowPasswordCheckBox.Checked = false;

                    Hide();

                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    mainForm = null;

                    Show();
                    PhoneNumberTextBox.Select();
                }
                else
                {
                    MessageBox.Show("Imię lub hasło nie prawidłowe. Sprobuj jeszcze raz", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    PhoneNumberTextBox.Focus();
                    PhoneNumberTextBox.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Prosze wpisać imię użytkownika i hasłó", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PhoneNumberTextBox.Select();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
