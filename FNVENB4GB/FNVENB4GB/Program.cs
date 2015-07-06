using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace FNVENB4GB
{
    class Program
    {
        static void Main(string[] args)
        {
            String enbExecutable = "ENBInjector.exe";
            String fourgbExecutable = "fnv4gb.exe";

            String enbProcess = "ENBInjector";
            String falloutProcess = "FalloutNV";


            Console.WriteLine("Opening " + enbExecutable);
            Process.Start(enbExecutable);

            Console.WriteLine("Opening " + fourgbExecutable);
            Process.Start(fourgbExecutable);

            Console.WriteLine("Waiting For 20 Seconds..");
            Thread.Sleep(20000);

            Process[] fallout;
            fallout = Process.GetProcessesByName(falloutProcess);
            Process[] enb = Process.GetProcessesByName(enbProcess);

            while (fallout.Length > 0)
            {
                fallout = Process.GetProcessesByName(falloutProcess);
                //Console.WriteLine(falloutProcess + " Still Open");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Closing " + fourgbExecutable);
            enb[0].Close();
            Application.Exit();
        }
    }
}