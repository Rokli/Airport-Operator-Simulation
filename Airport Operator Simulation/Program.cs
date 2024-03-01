using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airport_Operator_Simulation.View.Class;
using Airport_Operator_Simulation;
using Airport_Operator_Simulation.Models;

namespace Airport_Operator_Simulation
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SaveLoad saveLoad = new SaveLoad();
            MainWindow view = new MainWindow(saveLoad);
            Presenter presenter = new Presenter(view, saveLoad);
            Application.Run(view);
        }
    }
}
