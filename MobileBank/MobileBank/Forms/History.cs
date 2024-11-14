using MobileBank.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class History : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            var querySelectTransaction = $"select transaction_type, transaction_destination, transaction_day, transaction_number, transaction_value from transaction inner join bank_card on transaction.id bank_card = bank_card.id_bank_card inner join client on client.id_client = bank_card.id_client where client.id_client = '{DataStorage.idClient}'";
            SqlCommand command = new SqlCommand(querySelectTransaction, database.getConnection());
            SqlDataReader reader = command.ExecuteReader(); 
            while (reader.Read())
            {
                ListViewItem lvitem = new ListViewItem(reader[0].ToString());
                lvitem.SubItems.Add(reader[1].ToString());
                lvitem.SubItems.Add(reader[2].ToString());
                lvitem.SubItems.Add(reader[3].ToString());
                lvitem.SubItems.Add(reader[4].ToString());
                listView1.Items.Add(lvitem);
            }
            reader.Close();

            listView1.Sort();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
