using HukukBuroOtomasyonu.Adliye;
using HukukBuroOtomasyonu.Muvekkiller;
using HukukBuroOtomasyonu.PersonelIslemleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HukukBuroOtomasyonu
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
            Application.Run(new FormGirisEkrani());
        }
    }
}
