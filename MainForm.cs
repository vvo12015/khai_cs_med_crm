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

            MessageBox.Show($"����������� ������� �볺���: {maxClients}");
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
                MessageBox.Show("�볺�� ������ �������.");
            }
        }


        private void btnDisplayClients_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� ������ �볺���");
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ �볺���");
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� �볺��");
        }

        private void btnDemonstrateBehavior_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����������� ��������");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
