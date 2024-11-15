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
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            OwnerInfoGroupBox = new GroupBox();
            txtOwnerPhone = new MaskedTextBox();
            txtOwnerEmail = new TextBox();
            lblOwnerEmail = new Label();
            label1 = new Label();
            lblOwnerPhone = new Label();
            txtOwnerName = new TextBox();
            lblOwnerName = new Label();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnFind = new Button();
            ShowOwnerInfoCheckBox = new CheckBox();
            OwnerInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // lblClientType
            // 
            lblClientType.AutoSize = true;
            lblClientType.Location = new Point(12, 45);
            lblClientType.Name = "lblClientType";
            lblClientType.Size = new Size(70, 15);
            lblClientType.TabIndex = 0;
            lblClientType.Text = "Тип клієнта";
            // 
            // cmbClientType
            // 
            cmbClientType.DisplayMember = "Value";
            cmbClientType.FormattingEnabled = true;
            cmbClientType.Location = new Point(130, 45);
            cmbClientType.Name = "cmbClientType";
            cmbClientType.Size = new Size(204, 23);
            cmbClientType.TabIndex = 2;
            cmbClientType.ValueMember = "Key";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Назва:";
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 15);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 23);
            txtName.TabIndex = 1;
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
            txtEDRPOU.Size = new Size(204, 23);
            txtEDRPOU.TabIndex = 3;
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
            txtContractHours.Size = new Size(204, 23);
            txtContractHours.TabIndex = 5;
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
            cmbCompanySize.DisplayMember = "Value";
            cmbCompanySize.FormattingEnabled = true;
            cmbCompanySize.Location = new Point(130, 171);
            cmbCompanySize.Name = "cmbCompanySize";
            cmbCompanySize.Size = new Size(204, 23);
            cmbCompanySize.TabIndex = 6;
            cmbCompanySize.ValueMember = "Key";
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 105);
            dateTimePicker1.MaxDate = new DateTime(2024, 11, 9, 7, 4, 12, 51);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(204, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Value = new DateTime(2024, 11, 9, 7, 4, 12, 51);
            // 
            // OwnerInfoGroupBox
            // 
            OwnerInfoGroupBox.Controls.Add(txtOwnerPhone);
            OwnerInfoGroupBox.Controls.Add(txtOwnerEmail);
            OwnerInfoGroupBox.Controls.Add(lblOwnerEmail);
            OwnerInfoGroupBox.Controls.Add(label1);
            OwnerInfoGroupBox.Controls.Add(lblOwnerPhone);
            OwnerInfoGroupBox.Controls.Add(txtOwnerName);
            OwnerInfoGroupBox.Controls.Add(lblOwnerName);
            OwnerInfoGroupBox.Enabled = false;
            OwnerInfoGroupBox.Location = new Point(12, 224);
            OwnerInfoGroupBox.Name = "OwnerInfoGroupBox";
            OwnerInfoGroupBox.Size = new Size(335, 151);
            OwnerInfoGroupBox.TabIndex = 11;
            OwnerInfoGroupBox.TabStop = false;
            // 
            // txtOwnerPhone
            // 
            txtOwnerPhone.Location = new Point(118, 72);
            txtOwnerPhone.Mask = "+38\\0(00)-000-00-00";
            txtOwnerPhone.Name = "txtOwnerPhone";
            txtOwnerPhone.Size = new Size(200, 23);
            txtOwnerPhone.TabIndex = 19;
            // 
            // txtOwnerEmail
            // 
            txtOwnerEmail.Location = new Point(118, 106);
            txtOwnerEmail.Name = "txtOwnerEmail";
            txtOwnerEmail.Size = new Size(200, 23);
            txtOwnerEmail.TabIndex = 20;
            // 
            // lblOwnerEmail
            // 
            lblOwnerEmail.AutoSize = true;
            lblOwnerEmail.Location = new Point(6, 109);
            lblOwnerEmail.Name = "lblOwnerEmail";
            lblOwnerEmail.Size = new Size(93, 15);
            lblOwnerEmail.TabIndex = 27;
            lblOwnerEmail.Text = "Email власника:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 80);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 25;
            label1.Text = "+380(00)-000-00-00";
            // 
            // lblOwnerPhone
            // 
            lblOwnerPhone.AutoSize = true;
            lblOwnerPhone.Location = new Point(6, 65);
            lblOwnerPhone.Name = "lblOwnerPhone";
            lblOwnerPhone.Size = new Size(109, 15);
            lblOwnerPhone.TabIndex = 26;
            lblOwnerPhone.Text = "Телефон власника";
            // 
            // txtOwnerName
            // 
            txtOwnerName.Location = new Point(118, 32);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.Size = new Size(200, 23);
            txtOwnerName.TabIndex = 18;
            // 
            // lblOwnerName
            // 
            lblOwnerName.AutoSize = true;
            lblOwnerName.Location = new Point(6, 35);
            lblOwnerName.Name = "lblOwnerName";
            lblOwnerName.Size = new Size(83, 15);
            lblOwnerName.TabIndex = 24;
            lblOwnerName.Text = "ПІБ власника:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(130, 392);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 30);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(130, 392);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 29;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 392);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 30);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Відмінити";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(130, 392);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(80, 30);
            btnFind.TabIndex = 30;
            btnFind.Text = "Знайти";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Visible = false;
            btnFind.Click += btnFind_Click;
            // 
            // ShowOwnerInfoCheckBox
            // 
            ShowOwnerInfoCheckBox.AutoSize = true;
            ShowOwnerInfoCheckBox.Location = new Point(13, 201);
            ShowOwnerInfoCheckBox.Name = "ShowOwnerInfoCheckBox";
            ShowOwnerInfoCheckBox.Size = new Size(168, 19);
            ShowOwnerInfoCheckBox.TabIndex = 33;
            ShowOwnerInfoCheckBox.Text = "Інформація про власника";
            ShowOwnerInfoCheckBox.UseVisualStyleBackColor = true;
            ShowOwnerInfoCheckBox.CheckedChanged += ShowOwnerInfoCheckBox_CheckedChanged;
            // 
            // AddClientForm
            // 
            ClientSize = new Size(359, 439);
            Controls.Add(ShowOwnerInfoCheckBox);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnFind);
            Controls.Add(OwnerInfoGroupBox);
            Controls.Add(dateTimePicker1);
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
            OwnerInfoGroupBox.ResumeLayout(false);
            OwnerInfoGroupBox.PerformLayout();
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
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private GroupBox OwnerInfoGroupBox;
        private MaskedTextBox txtOwnerPhone;
        private TextBox txtOwnerEmail;
        private Label lblOwnerEmail;
        private Label label1;
        private Label lblOwnerPhone;
        private TextBox txtOwnerName;
        private Label lblOwnerName;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private Button btnFind;
        private CheckBox ShowOwnerInfoCheckBox;
    }
}
