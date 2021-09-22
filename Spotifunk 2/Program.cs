using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Spotifunk_2
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

            // after you enter your spotify link, form1 will be closed.
            // and when you close the mainScreen from the close button,
            // there will be a "System.ObjectDisposedException: 'Cannot access a disposed object"
            // error since It will try to open up form1 back again. To avoid that
            // a try catch is implemented. If it cant open up form1 under any circumstance,
            // it'll exit the program.
            try
            {
                Application.Run(new Form1());
            }
            catch
            {
                System.Windows.Forms.Application.Exit();
            }
            
        }
    }
}
