using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Drawing;
using System.Xml.Linq;


namespace MedCRM
{
    public partial class AddClientForm : Form
    {
        public Client? Client { get; set; }

        public AddClientForm()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            cmbClientType.Items.Clear();

            foreach (var item in Enum.GetValues(typeof(ClientType))
                    .Cast<ClientType>()
                    .Skip(1)
                    .Select(clientType => new KeyValuePair<ClientType, string>(
                            clientType,
                            (Enum.GetName(typeof(ClientType), clientType) ?? ClientType.UNKNOWN.ToString()).Replace("_", " ")
                        )
                    )
            )
            {
                cmbClientType.Items.Add(item);
            }

            cmbClientType.DisplayMember = "Value";
            cmbClientType.ValueMember = "Key";

            cmbCompanySize.Items.Clear();

            foreach (var item in Enum.GetValues(typeof(CompanySize))
                    .Cast<CompanySize>()
                    .Skip(1)
                    .Select(companySize => new KeyValuePair<CompanySize, string>(
                            companySize,
                            (Enum.GetName(typeof(CompanySize), companySize) ?? CompanySize.UNKNOWN.ToString()).Replace("_", " ")
                        )
                    )
            )
            {
                cmbCompanySize.Items.Add(item);
            }

            cmbCompanySize.DisplayMember = "Value";
            cmbCompanySize.ValueMember = "Key";

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            Client? createdClient = null;

            if (checkFields(out createdClient))
            {
                if (createdClient is not null)
                {
                    Debug.WriteLine(createdClient);

                    this.Client = createdClient;

                    DialogResult = DialogResult.OK;

                    this.Close();
                }
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void showBtnForSave()
        {
            this.btnSave.Visible = true;
            this.btnFind.Visible = false;
            this.btnDelete.Visible = false;
        }

        public void showBtnForFind()
        {
            this.btnSave.Visible = false;
            this.btnFind.Visible = true;
            this.btnDelete.Visible = false;
        }

        public void showBtnForDelete()
        {
            this.btnSave.Visible = false;
            this.btnFind.Visible = false;
            this.btnDelete.Visible = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            List<Client> resultList = FindedClientFromForm();
                ShowClient showClient = new ShowClient();
            ShowClient.Clients = resultList;

            showClient.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CompanySize? companySize = null;
            ClientType? clientType = null;

            if (cmbCompanySize.SelectedItem != null)
            {
                companySize = ((KeyValuePair<CompanySize, string>)cmbCompanySize.SelectedItem).Key;
            }

            if (cmbClientType.SelectedItem != null)
            {
                clientType = ((KeyValuePair<ClientType, string>)cmbClientType.SelectedItem).Key;
            }

            double.TryParse(txtContractHours.Text, out double contractHours);

            MainForm.Clients.RemoveAll(FindedClientFromForm().Contains);

            ShowClient showClient = new ShowClient();

            ShowClient.Clients = new List<Client>(MainForm.Clients);

            showClient.ShowDialog();
        }

        public bool checkFields(out Client? client)
        {
            client = null;
            try
            {
                ClientType? clientType = null;
                CompanySize? companySize = null;

                if (cmbClientType.SelectedItem == null)
                {
                    MessageBox.Show("Будь-ласка виберіть тип клієнта.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    clientType = ((KeyValuePair<ClientType, string>)cmbClientType.SelectedItem).Key;
                }

                if (!double.TryParse(txtContractHours.Text, out double contractHours))
                {
                    MessageBox.Show("Кількість годин повинна бути дійсним числом(формату 0,00).", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (dateTimePicker1.Value < new DateTime())
                {
                    MessageBox.Show("Будь ласка введіть дату реєстації.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (cmbCompanySize.SelectedItem == null)
                {
                    MessageBox.Show("Будь-ласка виберіть розмір компанії.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    companySize = ((KeyValuePair<CompanySize, string>)cmbCompanySize.SelectedItem).Key;
                }

                client = new Client(
                    clientType.GetValueOrDefault(ClientType.UNKNOWN),
                    txtName.Text,
                    txtEDRPOU.Text,
                    dateTimePicker1.Value,
                    contractHours,
                    companySize.GetValueOrDefault(CompanySize.UNKNOWN),
                    txtOwnerName.Text,
                    txtOwnerPhone.Text,
                    txtOwnerEmail.Text,
                    "normal");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public List<Client> FindedClientFromForm()
        {
            CompanySize? companySize = null;
            ClientType? clientType = null;

            if (cmbCompanySize.SelectedItem != null)
            {
                companySize = ((KeyValuePair<CompanySize, string>)cmbCompanySize.SelectedItem).Key;
            }

            if (cmbClientType.SelectedItem != null)
            {
                clientType = ((KeyValuePair<ClientType, string>)cmbClientType.SelectedItem).Key;
            }

            double.TryParse(txtContractHours.Text, out double contractHours);

            List<Client> preparedList;
            List<Client> resultList = new List<Client>(MainForm.Clients);

            if (clientType != null)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.Type == clientType)
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (txtName.Text.Length > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.Name.Equals(txtName.Text))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (txtEDRPOU.Text.Length > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.EDRPOU.Equals(txtEDRPOU.Text))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (contractHours > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.ContractHours.Equals(contractHours))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (companySize != null)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.Size == companySize)
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (txtOwnerName.Text.Length > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.OwnerName.Equals(txtOwnerName.Text))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (txtOwnerPhone.Text.Length == 18)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.OwnerPhone.Equals(txtOwnerPhone.Text))
                    {
                        resultList.Add(fClient);
                    }
                }
            }


            if (txtOwnerEmail.Text.Length > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.OwnerEmail.Equals(txtOwnerEmail.Text))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            return resultList;
        }
    }
}
