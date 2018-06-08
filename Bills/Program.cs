using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Sql;

namespace Bills
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

            Control.CheckForIllegalCrossThreadCalls = false;
            Bills.SplashScreen.ShowSplashScreen();
            Application.DoEvents();
            Bills.SplashScreen.SetStatus("Učitavanje grafike");
            System.Threading.Thread.Sleep(500);
            Bills.SplashScreen.SetStatus("Učitavanje osnovnih šifarnika");
            System.Threading.Thread.Sleep(300);
            Bills.SplashScreen.SetStatus("Učitavanje pregleda");
            System.Threading.Thread.Sleep(900);
            Bills.SplashScreen.SetStatus("Učitavanje stora");
            System.Threading.Thread.Sleep(100);

            Bills.SplashScreen.SetStatus("Učitavanje servera");
            Form1.tblServer = SqlDataSourceEnumerator.Instance.GetDataSources();

            Bills.SplashScreen.SetStatus("Priprema Baznih klasa");
            System.Threading.Thread.Sleep(50);
            Bills.SplashScreen.SetStatus("Priprema klasa");
            System.Threading.Thread.Sleep(240);
            Bills.SplashScreen.SetStatus("Priprema Helper klasa");
            System.Threading.Thread.Sleep(900);
            Bills.SplashScreen.SetStatus("Provjera ConnStringa");
            System.Threading.Thread.Sleep(240);
            Bills.SplashScreen.SetStatus("Pokretanje glavnog izbornika.");
            System.Threading.Thread.Sleep(90);
            Bills.SplashScreen.SetStatus("Pokretanje glavnog izbornika..");
            System.Threading.Thread.Sleep(1000);
            Bills.SplashScreen.SetStatus("Pokretanje glavnog izbornika...");
            System.Threading.Thread.Sleep(100);
            Bills.SplashScreen.SetStatus("Pokretanje glavnog izbornika..");
            System.Threading.Thread.Sleep(500);
            Bills.SplashScreen.SetStatus("Pokretanje glavnog izbornika.", false);
            System.Threading.Thread.Sleep(500);
            Bills.SplashScreen.SetStatus("Pokretanje glavnog izbornika..", false);
            System.Threading.Thread.Sleep(500);
            Bills.SplashScreen.SetStatus("Pokretanje glavnog izbornika...", false);
            System.Threading.Thread.Sleep(250);
            Bills.SplashScreen.SetStatus("Pokretanje glavnog izbornika..", false);
            System.Threading.Thread.Sleep(250);
            Bills.SplashScreen.SetStatus("Pokretanje glavnog izbornika.");
            System.Threading.Thread.Sleep(20);
            Bills.SplashScreen.SetStatus("Pokretanje glavnog izbornika..");
            System.Threading.Thread.Sleep(450);
            Bills.SplashScreen.SetStatus("Pokretanje glavnog izbornika...");
            System.Threading.Thread.Sleep(240);
            Bills.SplashScreen.SetStatus("Pokretanje glavnog izbornika....");
            System.Threading.Thread.Sleep(90);
            
            Application.Run(new Form1());
        }
    }
}
