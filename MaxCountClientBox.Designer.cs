
namespace MedCRM
{
    partial class MaxCountClientBox
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
            lblPrompt = new Label();
            txtInput = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(12, 15);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(224, 15);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Введіть максимальну кількість клієнтів:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(15, 40);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(250, 23);
            txtInput.TabIndex = 1;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(50, 80);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 30);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(150, 80);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // MaxCountClientBox
            // 
            ClientSize = new Size(280, 130);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(txtInput);
            Controls.Add(lblPrompt);
            Name = "MaxCountClientBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Введення кількості пацієнтів";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
