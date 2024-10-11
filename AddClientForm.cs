using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace MedCRM
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length < 5)
            {
                MessageBox.Show("Назва пуста або містить менше 5 символів.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClientType clientType;
            if (!Enum.TryParse(cmbClientType.SelectedItem?.ToString(), out clientType))
            {
                MessageBox.Show("Будь-ласка виберіть тип клієнта.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEDRPOU.Text))
            {
                MessageBox.Show("ЄДПРОУ/ІПН не може бути пустим.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtEDRPOU.Text.Length < 10)
            {
                MessageBox.Show("ЄДПРОУ/ІПН повинен бути не менше 10 символів", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateTimePicker1.Value < new DateTime())
            {
                MessageBox.Show("Будь ласка введіть дату реєстації.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtContractHours.Text, out double contractHours) || contractHours <= 0)
            {
                MessageBox.Show("Кількість годин повинна бути позитивним числом.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (contractHours > 100)
            {
                MessageBox.Show("Кількість годин не має перевищувати 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CompanySize companySize;
            if (!Enum.TryParse(cmbCompanySize.SelectedItem?.ToString(), out companySize))
            {
                MessageBox.Show("Введіть розмір компанії.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtOwnerName.Text))
            {
                MessageBox.Show("ПІБ власника не може бути пустим полем.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtOwnerPhone.MaskFull)
            {
                MessageBox.Show("Номер телефону повинен відповідати формату +380(11)-111-11-11.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOwnerEmail.Text) || !txtOwnerEmail.Text.Contains("@"))
            {
                MessageBox.Show("A valid email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtOwnerEmail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client CreatedClient = new Client(
                    clientType,
                    txtName.Text,
                    txtEDRPOU.Text,
                    dateTimePicker1.Value,
                    contractHours,
                    companySize,
                    txtOwnerName.Text,
                    txtOwnerPhone.Text,
                    txtOwnerEmail.Text,
                    "normal"
                );


            DialogResult = DialogResult.OK;
            
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void showBtnForSave()
        {
            this.btnSave.Visible = true;
            this.btnFind.Visible = false;
        }

        public void showBtnForFind()
        {
            this.btnSave.Visible = false;
            this.btnFind.Visible = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
