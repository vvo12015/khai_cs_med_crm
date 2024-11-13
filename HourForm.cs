using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCRM
{
    public partial class HourForm : Form
    {
        private static Client? currentClient;
        public HourForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectIndex = listBox1.SelectedIndex;
            if (selectIndex != -1)
            {
                if (MainForm.Clients.Count > selectIndex)
                {
                    currentClient = MainForm.Clients[selectIndex];
                    showHourBalance();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hours = getHours();
            if (currentClient is not null)
            {
                currentClient.UseHours(hours);
                showHourBalance();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double hours = getHours();
            if (currentClient is not null)
            {
                currentClient.AddHours(hours);
                showHourBalance();
            }
        }

        private void showHourBalance()
        {
            if (currentClient is not null)
            {
                labelBalance.Text = currentClient.Hours.ToString();
                if (currentClient.Hours < 0)
                {
                    labelBalance.ForeColor = Color.Red;
                }
                else
                {
                    labelBalance.ForeColor = Color.Black;
                }
            }
        }

        private void refreshContractButton_Click(object sender, EventArgs e)
        {
            if (currentClient is not null)
            {
                currentClient.AddHours(currentClient.ContractHours.GetValueOrDefault(0));
                showHourBalance();
            }
        }

        private double getHours()
        {
            double hours;

            if (double.TryParse(hoursMaskedTextBox.Text, out hours))
            {
                return hours;
            }
            else
            {
                MessageBox.Show($"Не коректно введена кількість");
                return 0;
            }
        }

        private void HourForm_Shown(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (Client client in MainForm.Clients)
            {
                listBox1.Items.Add(client.NameForList);
            }

            if (MainForm.Clients.Count > 0)
            {
                currentClient = MainForm.Clients[0];
                showHourBalance();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
