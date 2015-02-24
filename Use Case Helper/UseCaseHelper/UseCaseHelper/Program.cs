using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    static class Program
    {
        /// <summary>
        /// Dit Programa is gemaakt door Milton en Kevin uit S22T
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ScreenUseCaseDraw());
            
        }
    }
}
