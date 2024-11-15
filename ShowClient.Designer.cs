namespace MedCRM
{
    partial class ShowClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowClient));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            ClientCountLabel = new Label();
            ShowDebtorCheckBox = new CheckBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // ClientCountLabel
            // 
            resources.ApplyResources(ClientCountLabel, "ClientCountLabel");
            ClientCountLabel.Name = "ClientCountLabel";
            // 
            // ShowDebtorCheckBox
            // 
            resources.ApplyResources(ShowDebtorCheckBox, "ShowDebtorCheckBox");
            ShowDebtorCheckBox.Name = "ShowDebtorCheckBox";
            ShowDebtorCheckBox.UseVisualStyleBackColor = true;
            ShowDebtorCheckBox.CheckedChanged += ShowDebtorCheckBox_CheckedChanged;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(numericUpDown1, "numericUpDown1");
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Value = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // ShowClient
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(ShowDebtorCheckBox);
            Controls.Add(ClientCountLabel);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ShowClient";
            Shown += ShowClient_Paint;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label ClientCountLabel;
        private CheckBox ShowDebtorCheckBox;
        private Label label3;
        private NumericUpDown numericUpDown1;
    }
}