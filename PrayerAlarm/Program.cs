using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrayerAlarm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //int nKey = 0;
            //string sString = "give number: ";
            //Console.WriteLine(sString);
            //scanf();

            //DateTime dSubuh = new DateTime(2017, 08, 25, 05, 50, 00);

            //while (nKey == 0)
            //{
            //    if (DateTime.Now == dSubuh)
            //    {
            //        Application.EnableVisualStyles();
            //        Application.SetCompatibleTextRenderingDefault(false);
            //        Application.Run(new Form1());
            //        nKey = 1;
            //    }
            //}

            //Form1 oForm1 = new Form1();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(oForm1);

            bool bIsFirstTimeRun = true;

            if (bIsFirstTimeRun)
            {
                //oForm1.Form1_goMinimize();
                bIsFirstTimeRun = false;
            }


        }
    }
}
