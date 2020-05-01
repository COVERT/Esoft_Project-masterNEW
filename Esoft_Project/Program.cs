using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    static class Program
    {
        //создание статистического экземпляра класса модели ADO.EDM
        public static WFTutorialEntities1 wftDB = new WFTutorialEntities1();
        
        public static WFTutorial2Entities newDB = new WFTutorial2Entities(); 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
            Application.Run(new FormClient());
            Application.Run(new FormAgent());
        }
    }
}
