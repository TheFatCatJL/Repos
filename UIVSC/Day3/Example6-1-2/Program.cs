using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Example6_1_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //sets another thread to run Forms2 concurrently.
            Thread myThread = new Thread(AnotherForm);
            myThread.TrySetApartmentState(ApartmentState.STA);
            myThread.Start();

            Application.Run(new Form1());

        }
        static void AnotherForm()
        {
            Application.Run(new Form2());
        }
    }
}
