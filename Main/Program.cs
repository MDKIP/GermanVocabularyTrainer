using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using GUI_WindowsForms;

namespace Main
{
    class Program
    {
        static IAppForm mainWindow;
        [STAThread]
        static void Main(string[] args)
        {
            // Załaduj GUI WinForms
            FormTraining mainForm = new FormTraining();
            Application.Run(mainForm);
            mainWindow = mainForm;
        }
    }
}
