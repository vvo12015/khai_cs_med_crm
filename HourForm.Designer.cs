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
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            labelBalance = new Label();
            hoursMaskedTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 169);
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
            label2.AutoSize = true;
            label2.Location = new Point(167, 15);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 3;
            label2.Text = "Баланс годин";
            // 
            // button1
            // 
            button1.Location = new Point(167, 124);
            button1.Name = "button1";
            button1.Size = new Size(118, 25);
            button1.TabIndex = 4;
            button1.Text = "Використати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(167, 155);
            button2.Name = "button2";
            button2.Size = new Size(118, 25);
            button2.TabIndex = 5;
            button2.Text = "Додати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(167, 186);
            button4.Name = "button4";
            button4.Size = new Size(118, 25);
            button4.TabIndex = 6;
            button4.Text = "Вихід";
            button4.UseVisualStyleBackColor = true;
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
            hoursMaskedTextBox.Location = new Point(167, 95);
            hoursMaskedTextBox.Mask = "0000.00";
            hoursMaskedTextBox.Name = "hoursMaskedTextBox";
            hoursMaskedTextBox.Size = new Size(118, 23);
            hoursMaskedTextBox.TabIndex = 8;
            hoursMaskedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // HourForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(hoursMaskedTextBox);
            Controls.Add(labelBalance);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "HourForm";
            Size = new Size(312, 270);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button4;
        private Label labelBalance;
        private MaskedTextBox hoursMaskedTextBox;
    }
}
