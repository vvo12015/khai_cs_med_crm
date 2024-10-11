using System;
using System.Windows.Forms;

namespace MedCRM
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (MaxCountClientBox maxCountClientBox = new MaxCountClientBox())
            {
                if (maxCountClientBox.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm(maxCountClientBox.MaxClients));
                }
                else
                {
                    MessageBox.Show("÷€ програма буде закрита.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
    }
}
