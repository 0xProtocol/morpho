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
        public string GetStatistic(IPAddress ip, string username, string password)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            proc.Start();
            proc.StandardInput.WriteLine("wmic / user:"+username+ " /password:" + password + " /node:"+ ip + " os get name");
            proc.StandardInput.Flush();
            proc.StandardInput.Close();
            StreamReader sr = proc.StandardOutput;
            string output = sr.ReadToEnd();
            proc.WaitForExit();
            return output;
        }
    }
}
