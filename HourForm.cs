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

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectIndex = listBox1.SelectedIndex;
            if (selectIndex != -1)
            {
                if (MainForm.Clients.Count > selectIndex)
                {
                    currentClient = MainForm.Clients[selectIndex];
                    ShowHourBalance();
                }
            }
        }

        private void UseButton_Click(object sender, EventArgs e)
        {
            double hours = GetHours();
            if (currentClient is not null && hours > 0)
            {
                currentClient.UseHours(hours);
                ShowHourBalance();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            double hours = GetHours();
            if (currentClient is not null && hours > 0)
            {
                currentClient.AddHours(hours);
                ShowHourBalance();
            }
        }

        private void ShowHourBalance()
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

        private void RefreshContractButton_Click(object sender, EventArgs e)
        {
            double hours = GetHours();

            if (currentClient is not null)
            {
                if (hours >= 0)
                {
                    currentClient.RefreshContract(hours);
                }
                else
                {
                    currentClient.RefreshContract();
                }
                ShowHourBalance();
            }
        }

        private double GetHours()
        {
            double hours;

            if (double.TryParse(hoursMaskedTextBox.Text, out hours) ||
                    hours < 0)
            {
                return hours;
            }
            else
            {
                MessageBox.Show($"Не коректно введена кількість");
                return -1;
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
                ShowHourBalance();
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
