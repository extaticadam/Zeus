using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();  
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialise the database connections

            PortfolioLibrary.GlobalConfig.InitialiseConnections(true);


            //Application.Run(new PortfolioEntry());
            Application.Run(new SearchForm());
            //Application.Run(new PanelTest());
        }
    }
}