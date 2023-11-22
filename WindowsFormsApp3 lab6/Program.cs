using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3_lab6
{
    internal static class Program
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
        static void BubbleSort(int[] tab)
        {
            for(int i=0;i<tab.Length; i++)
            {
                for(int j=0;j<tab.Length-1;j++)
                {
                    if (tab[j] > tab[j+1])
                    {
                        int tmp = tab[j];
                        tab[j] = tab[j+1];
                        tab[j+1] = tmp;
                    }
                }
            }
        }
    }
}
