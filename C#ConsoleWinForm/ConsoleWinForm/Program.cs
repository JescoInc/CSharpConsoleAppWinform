using System;
using System.Runtime.InteropServices;
using System.Windows.Forms; // add DLL to System.Windows.Forms

namespace ConsoleWinForm
{
    internal static class NativeMethods
    {
        [DllImport("kernel32.dll")]
        internal static extern Boolean AllocConsole();
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                // run as windows app
                Application.EnableVisualStyles();
                Application.Run(new Form());
            }

            else
            {
                // run as console app
                NativeMethods.AllocConsole();
                Console.WriteLine("Hello World");
                Console.ReadLine();
            }
        }
    }
}
