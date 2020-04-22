using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Tool_SZU.Client.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Temperatur - CPU
            //Festplatteninformationen
            //Computername
            //Bios-Informationen
            //IP-Adresse
            //Auslastung

            Process proc = new Process();
            proc.StartInfo.FileName = "wmic.exe";
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
           // proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            proc.Start();
            proc.StandardInput.WriteLine("cpu get loadpercentage");
            proc.StandardInput.Flush();
            proc.StandardInput.Close();
            StreamReader sr = proc.StandardOutput;
            string output = sr.ReadToEnd();
            proc.WaitForExit();
            Console.WriteLine(output);
            Console.ReadLine();

            Process proc2 = new Process();
            proc2.StartInfo.FileName = "wmic.exe";
            proc2.StartInfo.RedirectStandardInput = true;
            proc2.StartInfo.RedirectStandardOutput = true;
            // proc.StartInfo.CreateNoWindow = true;
            proc2.StartInfo.UseShellExecute = false;
            proc2.Start();
            proc2.StandardInput.WriteLine("diskdrive get Name, Model, SerialNumber");
            proc2.StandardInput.Flush();
            proc2.StandardInput.Close();
            StreamReader sr2 = proc2.StandardOutput;
            string output2 = sr2.ReadToEnd();
            proc2.WaitForExit();
            Console.WriteLine(output2);
            Console.ReadLine();

            Process proc3 = new Process();
            proc3.StartInfo.FileName = "wmic.exe";
            proc3.StartInfo.RedirectStandardInput = true;
            proc3.StartInfo.RedirectStandardOutput = true;
            // proc.StartInfo.CreateNoWindow = true;
            proc3.StartInfo.UseShellExecute = false;
            proc3.Start();
            proc3.StandardInput.WriteLine("computersystem get Name");
            proc3.StandardInput.Flush();
            proc3.StandardInput.Close();
            StreamReader sr3 = proc3.StandardOutput;
            string output3 = sr3.ReadToEnd();
            proc3.WaitForExit();
            Console.WriteLine(output3);
            Console.ReadLine();


        }
    }
}
