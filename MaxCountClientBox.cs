using System;
using System.Windows.Forms;

namespace MedCRM
{
    public partial class MaxCountClientBox : Form
    {
        public int MaxClients { get; private set; }

        public MaxCountClientBox()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int maxClients) && maxClients > 0)
            {
                MaxClients = maxClients;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Введіть правильне позитивне число.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
