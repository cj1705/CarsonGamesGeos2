﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarsonGamesGeos2;

namespace CarsonGamesGeos2
{
    internal class Program
    {
        [STAThread]
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]

        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        public string versionstring = " ";
       

        [STAThread]
        static void Main(string[] args)
        {
            Application.ThreadException += new ThreadExceptionEventHandler(CritialExeption);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CriticalExeption2);
            Program pgm = new Program();
            classes.addons.addonloader addonloader = new classes.addons.addonloader();

            Thread addons = new Thread(addonloader.LoadAddons);
            addons.Start();


#if DEBUG

            dev.debug debug = new dev.debug();
            debug.StartDebug();




#else
            pgm.versionstring = "N/A";

            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);

            CarsonGamesGeos2.Main.GUI_Items.Message_Box.MessageBox msgbox = new Main.GUI_Items.Message_Box.MessageBox("Unable to handle request.");
            msgbox.ShowDialog();
#endif



        }



        public static void CritialExeption(object sender, ThreadExceptionEventArgs t)
        {
            classes.error.error_handler error_Handler = new classes.error.error_handler();
            error_Handler.ShowError(t.Exception);
        }
        private static void CriticalExeption2(object sender, UnhandledExceptionEventArgs e)
        {
            classes.error.error_handler error_Handler = new classes.error.error_handler();
            error_Handler.ShowError(e.ExceptionObject as Exception);
        }
    }
       
}
