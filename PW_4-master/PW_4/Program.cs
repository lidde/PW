using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PW_4
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
            Application.Run(new Form1());
        }

        public static void calculate()
        {
            int value = 1, n;
            Form1 currentForm = (Form1)Form1.ActiveForm;
            n = currentForm.get_n();

            if (n == 0 || n == 1)
                currentForm.SetText(n + "! = " + value.ToString());
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    value *= i;
                    currentForm.SetText("Aktualna wartosć dla i = " + i + " wynosi: " + value.ToString());
                    Thread.Sleep(500);
                }
                currentForm.SetText(n + "! = " + value.ToString());
            }
        }

    }
}
