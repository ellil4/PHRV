using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PsychHRV
{
    static class Program
    {
        public enum DEVMODE
        {
            DEVICE, UI
        }
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            DEVMODE mode = new DEVMODE();
            mode = DEVMODE.UI;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (mode == DEVMODE.UI)
            {
                Application.Run(new FlashPanel());
            }
            else if(mode == DEVMODE.DEVICE)
            {
                Application.Run(new Form1());
            }

        }
    }
}
