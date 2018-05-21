using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMFTR
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //On set nos textes de bouton pour nos boutons de messages box
            MessageBoxManager.Yes = Resources.ResourcesString.STR_Oui;
            MessageBoxManager.No = Resources.ResourcesString.STR_Non;
            MessageBoxManager.OK = Resources.ResourcesString.STR_Ok;

            //On register le message  box manager pour pouvoir customizer nos message box
            MessageBoxManager.Register();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SuivisList());
        }
    }
}
