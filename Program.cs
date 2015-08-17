using System;
using System.Windows.Forms;

namespace ExportSQL
{
    static partial class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                string[] args = Environment.GetCommandLineArgs();
                if (args[1].Equals(CommandLine.Argument.USAGE))
                {
                    CommandLine.ShowUsage(args[0]);
                    Environment.Exit(0);
                }

                CommandLine.Parse(args);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new WizardForm());
            }
        }
    }
}
