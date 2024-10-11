using System;
using System.Windows.Forms;

namespace MedCRM
{
    public partial class MainForm : Form
    {
        public int maxClients = 0;

        public List<Client> clients = new List<Client>();

        public MainForm(int maxClients)
        {
            InitializeComponent();

            this.maxClients = maxClients;

            MessageBox.Show($"Максимальна кількість клієнтів: {maxClients}");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }



        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();

            //addClientForm.btnFind.Visible = false;
            //addClientForm.btnSave.Visible = true;

            if (addClientForm.ShowDialog() == DialogResult.OK)
            {
                //clients.Add(addClientForm.CreatedClient);
                MessageBox.Show("Клієнт успішно доданий.");
            }
        }


        private void btnDisplayClients_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Показати список клієнтів");
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Знайти клієнта");
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Видалити клієта");
        }

        private void btnDemonstrateBehavior_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Демонтрація поведінки");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
