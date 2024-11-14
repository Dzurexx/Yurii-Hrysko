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
    public partial class ChangePhoneNumber : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        Random rand = new Random();
        DataTable operators = new DataTable();
        Validation validation = new Validation();


        public ChangePhoneNumber()
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

        private void changePhoneBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Data zapisana";

            if (!Regex.IsMatch(NumberTextBox.Text, "^[+][4][8][0-9]{7-14}$"))
            {
                MessageBox.Show("Proszę podać numer telefonu", caption, btn, ico);
                NumberTextBox.Select();
                return;
            }

            var phonenumber = NumberTextBox.Text;
            var changeNumQuery = $"update client set client_phone_number = '{phonenumber}' where id_client = '{DataStorage.idClient}'";
            var command = new SqlCommand(changeNumQuery, database.getConnection());
            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Numer telefonu został zmieniony pomyślnie!");
                Close();
            }
            else
            {
                MessageBox.Show("Błąd");
            }


        }

        private void ChangePhoneNumber_MouseDown(object sender, MouseEventArgs e)
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
