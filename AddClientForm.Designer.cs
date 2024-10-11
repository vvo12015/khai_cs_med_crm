namespace MedCRM
{
    partial class AddClientForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblClientType = new Label();
            cmbClientType = new ComboBox();
            lblName = new Label();
            txtName = new TextBox();
            lblEDRPOU = new Label();
            txtEDRPOU = new TextBox();
            lblRegistrationDate = new Label();
            lblContractHours = new Label();
            txtContractHours = new TextBox();
            lblCompanySize = new Label();
            cmbCompanySize = new ComboBox();
            lblOwnerName = new Label();
            txtOwnerName = new TextBox();
            lblOwnerPhone = new Label();
            lblOwnerEmail = new Label();
            txtOwnerEmail = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnFind = new Button();
            label1 = new Label();
            label2 = new Label();
            txtOwnerPhone = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // lblClientType
            // 
            lblClientType.AutoSize = true;
            lblClientType.Location = new Point(12, 15);
            lblClientType.Name = "lblClientType";
            lblClientType.Size = new Size(68, 15);
            lblClientType.TabIndex = 0;
            lblClientType.Text = "Client Type:";
            // 
            // cmbClientType
            // 
            cmbClientType.FormattingEnabled = true;
            cmbClientType.Items.AddRange(new object[] { "ФОП", "Юридична особа" });
            cmbClientType.Location = new Point(130, 12);
            cmbClientType.Name = "cmbClientType";
            cmbClientType.Size = new Size(200, 23);
            cmbClientType.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 45);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Назва:";
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 3;
            // 
            // lblEDRPOU
            // 
            lblEDRPOU.AutoSize = true;
            lblEDRPOU.Location = new Point(12, 75);
            lblEDRPOU.Name = "lblEDRPOU";
            lblEDRPOU.Size = new Size(83, 15);
            lblEDRPOU.TabIndex = 4;
            lblEDRPOU.Text = "ЄДПРОУ/ІПН:";
            // 
            // txtEDRPOU
            // 
            txtEDRPOU.Location = new Point(130, 72);
            txtEDRPOU.Name = "txtEDRPOU";
            txtEDRPOU.Size = new Size(200, 23);
            txtEDRPOU.TabIndex = 5;
            // 
            // lblRegistrationDate
            // 
            lblRegistrationDate.AutoSize = true;
            lblRegistrationDate.Location = new Point(12, 105);
            lblRegistrationDate.Name = "lblRegistrationDate";
            lblRegistrationDate.Size = new Size(94, 15);
            lblRegistrationDate.TabIndex = 6;
            lblRegistrationDate.Text = "Дата реєстрації:";
            // 
            // lblContractHours
            // 
            lblContractHours.AutoSize = true;
            lblContractHours.Location = new Point(12, 135);
            lblContractHours.Name = "lblContractHours";
            lblContractHours.Size = new Size(113, 15);
            lblContractHours.TabIndex = 8;
            lblContractHours.Text = "Кількість сервісних";
            // 
            // txtContractHours
            // 
            txtContractHours.Location = new Point(130, 135);
            txtContractHours.Name = "txtContractHours";
            txtContractHours.Size = new Size(200, 23);
            txtContractHours.TabIndex = 9;
            // 
            // lblCompanySize
            // 
            lblCompanySize.AutoSize = true;
            lblCompanySize.Location = new Point(12, 174);
            lblCompanySize.Name = "lblCompanySize";
            lblCompanySize.Size = new Size(99, 15);
            lblCompanySize.TabIndex = 10;
            lblCompanySize.Text = "Розмір компанії:";
            // 
            // cmbCompanySize
            // 
            cmbCompanySize.FormattingEnabled = true;
            cmbCompanySize.Items.AddRange(new object[] { "Мала", "Середня", "Велика" });
            cmbCompanySize.Location = new Point(130, 171);
            cmbCompanySize.Name = "cmbCompanySize";
            cmbCompanySize.Size = new Size(200, 23);
            cmbCompanySize.TabIndex = 11;
            // 
            // lblOwnerName
            // 
            lblOwnerName.AutoSize = true;
            lblOwnerName.Location = new Point(12, 204);
            lblOwnerName.Name = "lblOwnerName";
            lblOwnerName.Size = new Size(83, 15);
            lblOwnerName.TabIndex = 12;
            lblOwnerName.Text = "ПІБ власника:";
            // 
            // txtOwnerName
            // 
            txtOwnerName.Location = new Point(130, 201);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.Size = new Size(200, 23);
            txtOwnerName.TabIndex = 13;
            // 
            // lblOwnerPhone
            // 
            lblOwnerPhone.AutoSize = true;
            lblOwnerPhone.Location = new Point(12, 234);
            lblOwnerPhone.Name = "lblOwnerPhone";
            lblOwnerPhone.Size = new Size(109, 15);
            lblOwnerPhone.TabIndex = 14;
            lblOwnerPhone.Text = "Телефон власника";
            // 
            // lblOwnerEmail
            // 
            lblOwnerEmail.AutoSize = true;
            lblOwnerEmail.Location = new Point(12, 278);
            lblOwnerEmail.Name = "lblOwnerEmail";
            lblOwnerEmail.Size = new Size(93, 15);
            lblOwnerEmail.TabIndex = 16;
            lblOwnerEmail.Text = "Email власника:";
            // 
            // txtOwnerEmail
            // 
            txtOwnerEmail.Location = new Point(130, 275);
            txtOwnerEmail.Name = "txtOwnerEmail";
            txtOwnerEmail.Size = new Size(200, 23);
            txtOwnerEmail.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(130, 313);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 18;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 313);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 30);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Відмінити";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(130, 313);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(80, 30);
            btnFind.TabIndex = 20;
            btnFind.Text = "Знайти";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Visible = false;
            btnFind.Click += btnFind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 249);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 14;
            label1.Text = "+380(00)-000-00-00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 150);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 8;
            label2.Text = "годин на рік:";
            // 
            // txtOwnerPhone
            // 
            txtOwnerPhone.Location = new Point(130, 241);
            txtOwnerPhone.Mask = "+38\\0(00)-000-00-00";
            txtOwnerPhone.Name = "txtOwnerPhone";
            txtOwnerPhone.Size = new Size(200, 23);
            txtOwnerPhone.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 22;
            dateTimePicker1.MaxDate = DateTime.Now;
            // 
            // AddClientForm
            // 
            ClientSize = new Size(380, 387);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtOwnerPhone);
            Controls.Add(btnFind);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtOwnerEmail);
            Controls.Add(lblOwnerEmail);
            Controls.Add(label1);
            Controls.Add(lblOwnerPhone);
            Controls.Add(txtOwnerName);
            Controls.Add(lblOwnerName);
            Controls.Add(cmbCompanySize);
            Controls.Add(lblCompanySize);
            Controls.Add(txtContractHours);
            Controls.Add(label2);
            Controls.Add(lblContractHours);
            Controls.Add(lblRegistrationDate);
            Controls.Add(txtEDRPOU);
            Controls.Add(lblEDRPOU);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(cmbClientType);
            Controls.Add(lblClientType);
            Name = "AddClientForm";
            Text = "Додати нового клієнта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblClientType;
        private System.Windows.Forms.ComboBox cmbClientType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEDRPOU;
        private System.Windows.Forms.TextBox txtEDRPOU;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Label lblContractHours;
        private System.Windows.Forms.TextBox txtContractHours;
        private System.Windows.Forms.Label lblCompanySize;
        private System.Windows.Forms.ComboBox cmbCompanySize;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label lblOwnerPhone;
        private System.Windows.Forms.Label lblOwnerEmail;
        private System.Windows.Forms.TextBox txtOwnerEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private Button btnFind;
        private Label label1;
        private Label label2;
        private MaskedTextBox txtOwnerPhone;
        private DateTimePicker dateTimePicker1;
    }
}
