using System;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MedCRM
{
    public partial class MainForm : Form
    {
        public static int MaxClients { get; set; } = 0;

        public static List<Client> Clients { get; set; } = new List<Client>();

        public MainForm(int maxClients)
        {
            InitializeComponent();

            this.KeyPreview = true;

            MaxClients = maxClients;

            MessageBox.Show($"Максимальна кількість клієнтів: {MaxClients}");
        }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (GetActions().Keys.Contains(e.KeyData))
            {
                GetActions()[e.KeyData].Invoke(sender, e);
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (Clients.Count < MaxClients)
            {
                AddClientForm addClientForm = new AddClientForm();
                addClientForm.showBtnForSave();
                if (addClientForm.ShowDialog() == DialogResult.OK && addClientForm.Client is not null)
                {
                    Clients.Add(addClientForm.Client);
                    MessageBox.Show("Клієнт успішно доданий.");
                }
            }
            else
            {
                MessageBox.Show($"Досягнута максимальна кількість клієнтів: {MaxClients}");
            }
            
        }


        private void btnDisplayClients_Click(object sender, EventArgs e)
        {
            ShowClient showClient = new ShowClient();

            ShowClient.Clients = new List<Client>(MainForm.Clients);

            showClient.ShowDialog();
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.showBtnForFind();
            addClientForm.ShowDialog();
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.showBtnForDelete();
            addClientForm.ShowDialog();
        }

        private void btnDemonstrateBehavior_Click(object sender, EventArgs e)
        {
            HourForm hourForm = new HourForm();
            hourForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Dictionary<Keys, Action<object, EventArgs>> GetActions()
        {
            Dictionary<Keys, Action<object, EventArgs>> actions = new Dictionary<Keys, Action<object, EventArgs>>();

            actions.Add(Keys.D1, (o, e) => btnAddClient_Click(o, e));
            actions.Add(Keys.D2, (o, e) => btnDisplayClients_Click(o, e));
            actions.Add(Keys.D3, (o, e) => btnFindClient_Click(o, e));
            actions.Add(Keys.D4, (o, e) => btnRemoveClient_Click(o, e));
            actions.Add(Keys.D5, (o, e) => btnDemonstrateBehavior_Click(o, e));
            actions.Add(Keys.D0, (o, e) => btnExit_Click(o, e));

            return actions;
        }


    }
}
