using System;
using System.Windows.Forms;
using WordBank.Repository;

namespace WordBank.Presentation
{
    static class _Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Console(new XmlWordBank()));
        }
    }
}
