using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airport_Operator_Simulation.View.Class;
using Airport_Operator_Simulation;

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
            MainWindow view = new MainWindow();
            Presenter presenter = new Presenter(view);
            Application.Run(view);
        }
    }
}
