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
    public partial class HourForm : UserControl
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
                    labelBalance.Text = currentClient.hours.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hours = getHours();
            if (currentClient is not null)
            {
                currentClient.UseHours(hours);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double hours = getHours();
            if (currentClient is not null)
            {
                currentClient.BuyHours(hours);
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
    }
}
