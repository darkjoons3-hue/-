using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        MessageBox.Show("УСПЕШНО", "Готово",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
