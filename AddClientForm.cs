using System.Text.RegularExpressions;
using System.Diagnostics;


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

            Client? CreatedClient = null;

            if (checkFields(out CreatedClient))
            {
                if (CreatedClient is not null)
                {
                    Debug.WriteLine(CreatedClient);

                    this.Client = CreatedClient;

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

            Client client = new Client(
                    clientType.GetValueOrDefault(ClientType.UNKNOWN),
                    txtName.Text,
                    txtEDRPOU.Text,
                    dateTimePicker1.Value,
                    contractHours,
                    companySize.GetValueOrDefault(CompanySize.UNKNOWN),
                    txtOwnerName.Text,
                    txtOwnerPhone.Text,
                    txtOwnerEmail.Text,
                    "normal"
                );

            List<Client> resultList = Helper.FindedClientFromForm(client);

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

            Client client = new Client(
                    clientType.GetValueOrDefault(ClientType.UNKNOWN),
                    txtName.Text,
                    txtEDRPOU.Text,
                    dateTimePicker1.Value,
                    contractHours,
                    companySize.GetValueOrDefault(CompanySize.UNKNOWN),
                    txtOwnerName.Text,
                    txtOwnerPhone.Text,
                    txtOwnerEmail.Text,
                    "normal"
                );

            MainForm.Clients.RemoveAll(Helper.FindedClientFromForm(client).Contains);

            ShowClient showClient = new ShowClient();

            ShowClient.Clients = new List<Client>(MainForm.Clients);

            showClient.ShowDialog();
        }

        public bool checkFields(out Client? client)
        {
            client = null;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Назва пуста", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtName.Text.Length < 5)
            {
                MessageBox.Show("Назва містить менше 5 символів.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Char.IsLetter(txtName.Text[0]))
            {
                MessageBox.Show("Назва повинна починатися з букви.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            ClientType? clientType = null;

            if (cmbClientType.SelectedItem == null)
            {
                MessageBox.Show("Будь-ласка виберіть тип клієнта.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                clientType = ((KeyValuePair<ClientType, string>)cmbClientType.SelectedItem).Key;
            }

            if (string.IsNullOrWhiteSpace(txtEDRPOU.Text))
            {
                MessageBox.Show("ЄДПРОУ/ІПН не може бути пустим.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtEDRPOU.Text.Length < 10)
            {
                MessageBox.Show("ЄДПРОУ/ІПН повинен бути не менше 10 символів", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dateTimePicker1.Value < new DateTime())
            {
                MessageBox.Show("Будь ласка введіть дату реєстації.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(txtContractHours.Text, out double contractHours))
            {
                MessageBox.Show("Кількість годин повинна бути дійсним числом(формату 0,00).", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (contractHours == 0)
            {
                MessageBox.Show("Кількість годин не може дорівнювати 0.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (contractHours < 0)
            {
                MessageBox.Show("Кількість годин повинна бути позитивним числом.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (contractHours > 100)
            {
                MessageBox.Show("Кількість годин не має перевищувати 100.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            CompanySize? companySize = null;

            if (cmbCompanySize.SelectedItem == null)
            {
                MessageBox.Show("Будь-ласка виберіть розмір компанії.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                companySize = ((KeyValuePair<CompanySize, string>)cmbCompanySize.SelectedItem).Key;
            }

            if (string.IsNullOrWhiteSpace(txtOwnerName.Text))
            {
                MessageBox.Show("ПІБ власника не може бути пустим полем.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtOwnerName.Text.Length < 5)
            {
                MessageBox.Show("ПІБ містить менше 5 символів.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Char.IsLetter(txtOwnerName.Text[0]))
            {
                MessageBox.Show("ПІБ власника повинна починатися з букви.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (!txtOwnerPhone.MaskFull)
            {
                MessageBox.Show("Номер телефону повинен відповідати формату +380(11)-111-11-11.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOwnerEmail.Text))
            {
                MessageBox.Show("Введіть email.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtOwnerEmail.Text, emailPattern))
            {
                MessageBox.Show("Недопустимий тип email.", "Перевірка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            client = new Client(
                    clientType.GetValueOrDefault(ClientType.ФОП),
                    txtName.Text,
                    txtEDRPOU.Text,
                    dateTimePicker1.Value,
                    contractHours,
                    companySize.GetValueOrDefault(CompanySize.Мала),
                    txtOwnerName.Text,
                    txtOwnerPhone.Text,
                    txtOwnerEmail.Text,
                    "normal"
                );

            return true;
        }
    }
}
