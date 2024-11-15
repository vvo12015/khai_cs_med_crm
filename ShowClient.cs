﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Linq;

namespace MedCRM
{
    public partial class ShowClient : Form
    {

        public static List<Client> Clients = new List<Client>();
        public ShowClient()
        {
            InitializeComponent();
        }

        private void ShowClient_Paint(object sender, EventArgs e)
        {
            UpdateTable();
            ClientCountLabel.Text = Client.Counter.ToString();
            numericUpDown1.Value = (decimal)Client.MinHours;
        }

        private void UpdateTable()
        {
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 0;


            List<string> names = Client.ToDisplayNames();
            tableLayoutPanel1.RowCount++;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute));
            tableLayoutPanel1.RowStyles[0].Height = 50;
            tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Absolute;
            tableLayoutPanel1.ColumnCount = names.Count;
            tableLayoutPanel1.ColumnStyles.Clear();


            for (int i = 0; i < names.Count; i++)
            {
                string name = names[i];
                Debug.WriteLine(names[i]);
                Label label = new Label();
                label.AutoEllipsis = false;
                label.Text = name;
                label.Dock = DockStyle.Fill;
                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / names.Count));
                tableLayoutPanel1.ColumnStyles[i].Width = label.Width;
                tableLayoutPanel1.ColumnStyles[i].SizeType = SizeType.Absolute;
                tableLayoutPanel1.Controls.Add(label, i, 0);
            }


            for (int row = 0; row < Clients.Count; row++)
            {
                if ((!ShowDebtorCheckBox.Checked) ||
                    (ShowDebtorCheckBox.Checked && Clients[row].Hours <= Client.MinHours))
                {
                    tableLayoutPanel1.RowCount++;
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 1].Height = 50;
                    tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 1].SizeType = SizeType.Absolute;

                    List<string> clientFields = Clients[row].ToDisplayValues();
                    for (int col = 0; col
                                      < clientFields.Count; col++)
                    {
                        Label label = new Label();
                        label.Text = clientFields[col];
                        label.Dock = DockStyle.Fill;
                        label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(label, col, tableLayoutPanel1.RowCount - 1);
                    }
                }
            }

            tableLayoutPanel1.ResumeLayout();
        }

        private void ShowDebtorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Client.MinHours = (double)numericUpDown1.Value;
            UpdateTable();
        }
    }
}
