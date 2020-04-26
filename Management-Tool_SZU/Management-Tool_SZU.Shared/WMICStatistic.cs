using System;
using System.Diagnostics;

namespace Management_Tool_SZU.Shared
{
    public class WMICStatistic
    {
        // OS Name
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

        // 
        public string GetStatistic2(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " path Win32_BaseBoard get manufacturer");
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

        public string GetStatistic3(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " path Win32_BaseBoard get serialnumber");
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

        public string GetStatistic4(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " path Win32_BaseBoard get status");
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

        public string GetStatistic5(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " path Win32_BaseBoard get product");
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

        public string GetStatistic6(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_BIOS Get Version");
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

        public string GetStatistic7(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " path CIM_BIOSElement get manufacturer");
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

        public string GetStatistic8(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " path CIM_BIOSElement get status");
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

        public string GetStatistic9(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_ComputerSystem Get AdminPasswordStatus");
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
        public string GetStatistic10(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_ComputerSystem Get currenttimezone");
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
        public string GetStatistic11(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_ComputerSystem Get dnshostname");
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
        public string GetStatistic12(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_ComputerSystem Get primaryownername");
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
        public string GetStatistic13(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_ComputerSystem Get name");
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
        public string GetStatistic14(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_ComputerSystem Get status");
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
        public string GetStatistic15(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_ComputerSystem Get workgroup");
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
        public string GetStatistic16(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_DiskDrive get caption");
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
        public string GetStatistic17(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_DiskDrive get medialoaded");
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
        public string GetStatistic18(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_DiskDrive get status");
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
        public string GetStatistic19(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_DiskDrive get size");
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
