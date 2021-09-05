using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FawadIjazAssigt
{
    //Static Class: No other Class of this type could be formed
    static class Program
    {
        //The main entry point for the application.
        [STAThread]
        //RUN Function for the Application
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPlayerMode());
        }
    }
}
