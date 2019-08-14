using COMP123_S2019_FinalTestB.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123_S2019_FinalTestB.Objects;
/*
 * Student Name: Harbin Ramo
 * Student ID  : 301046044
 * Description : This is the driver class for the application
 */

namespace COMP123_S2019_FinalTestB
{
    static class Program
    {
        // Temporary
        public static CharacterGeneratorForm characterForm;
        public static Character character;
        public static List<string> inventory;

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            characterForm = new CharacterGeneratorForm();
            character = new Character();
            inventory = new List<string>();

            Application.Run(characterForm);
        }
    }
}
