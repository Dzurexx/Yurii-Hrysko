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
    public partial class ChangePassword : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        public ChangePassword()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Data zapisana";

            if (!Regex.IsMatch(PasswordTextBox.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                MessageBox.Show("Proszę wpisać hasło", caption, btn, ico);
                PasswordTextBox.Select();
                return;
            }

            var pass = PasswordTextBox.Text;
            var changeNumQuery = $"update client set client_password = '{pass}' where id_client = (select id_client from client where id_client '{DataStorage.idClient}')";
            dataBase.openConnection();
            var command = new SqlCommand(changeNumQuery, dataBase.getConnection());

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Hasło zostało zmienione pomyślnie");
                Close();
            }
            else
            {
                MessageBox.Show("Błąd");
            }
            dataBase.closeConnection();

        }

        private void ChangePassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
