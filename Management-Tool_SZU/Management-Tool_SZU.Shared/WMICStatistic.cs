using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Management_Tool_SZU.Shared
{
   public  class WMICStatistic
    {
        public string GetStatistic(IPAddress ip)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "wmic.exe";
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            proc.Start();
            proc.StandardInput.WriteLine("/node:" + ip + " cpu get loadpercentage");
            proc.StandardInput.Flush();
            proc.StandardInput.Close();
            StreamReader sr = proc.StandardOutput;
            string output = sr.ReadToEnd();
            proc.WaitForExit();
            return output;
        }
    }
}
