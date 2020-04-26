using System;
using System.Diagnostics;

namespace Management_Tool_SZU.Shared
{
    public class WMICStatistic
    {
        public string GetStatistic(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " os get name");
            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + request);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            string result = string.Empty;
            using (Process process = new Process())
            {
                process.StartInfo = procStartInfo;
                process.Start();
                process.WaitForExit();
                result = process.StandardOutput.ReadToEnd();
            }
            return result;
        }
    }
}
