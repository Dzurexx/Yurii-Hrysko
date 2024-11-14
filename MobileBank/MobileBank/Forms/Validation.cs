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
    public partial class Validation : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        public Validation()
        {
            InitializeComponent();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            int attempts = 3;
            int cardPin = Convert.ToInt32(numericUpDownPin.Value);
            int pin = 0;

            var queryCheckPin = $"select bank_card_pin from bank_card_number = '{DataStorage.bankCard}'";
            SqlCommand command = new SqlCommand(queryCheckPin, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                pin += Convert.ToInt32(reader[0]);
            }
            reader.Close();

            if (cardPin == pin)
            {
                MessageBox.Show("Operacja potwierdzona", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                DataStorage.attempts = attempts;
            }
            else
            {
                MessageBox.Show("Błąd.Zły kod PIN", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(attempts > 0)
                {
                    attempts--;
                }
                else
                {
                    DataStorage.attempts = attempts;
                    MessageBox.Show("Skończyły Ci się próby", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
