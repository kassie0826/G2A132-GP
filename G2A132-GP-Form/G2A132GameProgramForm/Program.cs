using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2A132GameProgramForm
{
    static class Program
    {
        
        public static ApplicationContext _mainFormContext;
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _mainFormContext = new ApplicationContext();
            _mainFormContext.MainForm = new Main_Page();
            Application.Run(_mainFormContext);
        }
    }
}
