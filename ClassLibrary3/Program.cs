﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
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

            //Initialie the DB Connections
            TrackerLib.GlobalConfig.InitializeConnections(true, true);

            Application.Run(new CreatePrize());
            //Application.Run(new TournamentDashboardForm());
        }
    }
}