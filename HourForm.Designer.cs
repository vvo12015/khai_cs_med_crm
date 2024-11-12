namespace MedCRM
{
    partial class HourForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            useButton = new Button();
            addButton = new Button();
            exitButton = new Button();
            labelBalance = new Label();
            hoursMaskedTextBox = new MaskedTextBox();
            refreshContractButton = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(132, 184);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Клієнти";
            // 
            // label2
            // 
            label2.Location = new Point(167, 15);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 3;
            label2.Text = "Баланс годин";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            useButton.Location = new Point(167, 139);
            useButton.Name = "button1";
            useButton.Size = new Size(118, 25);
            useButton.TabIndex = 4;
            useButton.Text = "Використати";
            useButton.UseVisualStyleBackColor = true;
            useButton.Click += button1_Click;
            // 
            // button2
            // 
            addButton.Location = new Point(166, 170);
            addButton.Name = "button2";
            addButton.Size = new Size(118, 25);
            addButton.TabIndex = 5;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button2_Click;
            // 
            // button4
            // 
            exitButton.Location = new Point(166, 201);
            exitButton.Name = "button4";
            exitButton.Size = new Size(118, 25);
            exitButton.TabIndex = 6;
            exitButton.Text = "Вихід";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += button4_Click;
            // 
            // labelBalance
            // 
            labelBalance.Font = new Font("Segoe UI", 16F);
            labelBalance.Location = new Point(167, 42);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(116, 41);
            labelBalance.TabIndex = 7;
            labelBalance.Text = "100";
            labelBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hoursMaskedTextBox
            // 
            hoursMaskedTextBox.Location = new Point(167, 79);
            hoursMaskedTextBox.Mask = "0000.00";
            hoursMaskedTextBox.Name = "hoursMaskedTextBox";
            hoursMaskedTextBox.Size = new Size(118, 23);
            hoursMaskedTextBox.TabIndex = 8;
            hoursMaskedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            refreshContractButton.Location = new Point(167, 108);
            refreshContractButton.Name = "button3";
            refreshContractButton.Size = new Size(118, 25);
            refreshContractButton.TabIndex = 4;
            refreshContractButton.Text = "Оновити контракт";
            refreshContractButton.UseVisualStyleBackColor = true;
            refreshContractButton.Click += refreshContractButton_Click;
            // 
            // HourForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 257);
            Controls.Add(hoursMaskedTextBox);
            Controls.Add(labelBalance);
            Controls.Add(exitButton);
            Controls.Add(addButton);
            Controls.Add(refreshContractButton);
            Controls.Add(useButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "HourForm";
            Shown += HourForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Button useButton;
        private Button addButton;
        private Button exitButton;
        private Label labelBalance;
        private MaskedTextBox hoursMaskedTextBox;
        private Button refreshContractButton;
    }
}
