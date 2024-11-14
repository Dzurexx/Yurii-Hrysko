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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MobileBank.Forms
{
    public partial class ChangeEmail : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();
        public ChangeEmail()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void chandeEmailBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Data zapisana";

            if (!Regex.IsMatch(EmailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Wpisz swój adres e-mail", caption, btn, ico);
                EmailTextBox.Select();
                return;
            }

            var email = EmailTextBox.Text;
            var changeNumQuery = $"update client set client_email = '{email}' where id_client = '{DataStorage.idClient}'";
            dataBase.openConnection();
            var command = new SqlCommand(changeNumQuery, dataBase.getConnection());

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("E-mail został zmieniony pomyślnie");
                Close();
            }
            else
            {
                MessageBox.Show("Błąd");
            }


        }

        private void ChangeEmail_MouseDown(object sender, MouseEventArgs e)
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

        private void ChangeEmail_Load(object sender, EventArgs e)
        {

        }
    }
}
