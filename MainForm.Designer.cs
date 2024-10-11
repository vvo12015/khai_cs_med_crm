namespace MedCRM
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            btnAddClient = new Button();
            btnDisplayClients = new Button();
            btnFindClient = new Button();
            btnRemoveClient = new Button();
            btnDemonstrateBehavior = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(44, 28);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(131, 38);
            btnAddClient.TabIndex = 0;
            btnAddClient.Text = "1 - Додати клієнта";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnDisplayClients
            // 
            btnDisplayClients.Location = new Point(44, 75);
            btnDisplayClients.Name = "btnDisplayClients";
            btnDisplayClients.Size = new Size(131, 38);
            btnDisplayClients.TabIndex = 1;
            btnDisplayClients.Text = "2 - Показати клієнтів";
            btnDisplayClients.UseVisualStyleBackColor = true;
            btnDisplayClients.Click += btnDisplayClients_Click;
            // 
            // btnFindClient
            // 
            btnFindClient.Location = new Point(44, 122);
            btnFindClient.Name = "btnFindClient";
            btnFindClient.Size = new Size(131, 38);
            btnFindClient.TabIndex = 2;
            btnFindClient.Text = "3 - Знайти клієнта";
            btnFindClient.UseVisualStyleBackColor = true;
            btnFindClient.Click += btnFindClient_Click;
            // 
            // btnRemoveClient
            // 
            btnRemoveClient.Location = new Point(44, 169);
            btnRemoveClient.Name = "btnRemoveClient";
            btnRemoveClient.Size = new Size(131, 38);
            btnRemoveClient.TabIndex = 3;
            btnRemoveClient.Text = "4 - Видалити клієнта";
            btnRemoveClient.UseVisualStyleBackColor = true;
            btnRemoveClient.Click += btnRemoveClient_Click;
            // 
            // btnDemonstrateBehavior
            // 
            btnDemonstrateBehavior.Location = new Point(44, 216);
            btnDemonstrateBehavior.Name = "btnDemonstrateBehavior";
            btnDemonstrateBehavior.Size = new Size(131, 38);
            btnDemonstrateBehavior.TabIndex = 4;
            btnDemonstrateBehavior.Text = "5 - Демонстрація клієнта";
            btnDemonstrateBehavior.UseVisualStyleBackColor = true;
            btnDemonstrateBehavior.Click += btnDemonstrateBehavior_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(44, 262);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 38);
            btnExit.TabIndex = 5;
            btnExit.Text = "0 - Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 328);
            Controls.Add(btnExit);
            Controls.Add(btnDemonstrateBehavior);
            Controls.Add(btnRemoveClient);
            Controls.Add(btnFindClient);
            Controls.Add(btnDisplayClients);
            Controls.Add(btnAddClient);
            Name = "MainForm";
            Text = "Main Menu";
            Load += this.MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnDisplayClients;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Button btnDemonstrateBehavior;
        private System.Windows.Forms.Button btnExit;
    }
}
