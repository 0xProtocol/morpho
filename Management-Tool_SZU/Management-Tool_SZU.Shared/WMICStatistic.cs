using System;
using System.Diagnostics;

namespace Management_Tool_SZU.Shared
{
    /// <summary>
    /// Class WMICStatistic to get different statistics from clients 
    /// </summary>
    public class WMICStatistic
    {
        /// <summary>
        /// Get the name of the operating system
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the manufacturer of the baseboard
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the serialnumber of the baseboard
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the status of the baseboard
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the productname of the baseboard
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the version of the BIOS
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the manufacturer of the BIOS
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the status of the BIOS
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the admin password status
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Get the current timezone
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the DNS hostname
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the primary owner name
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the computer name
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the status of the computersystem
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the current workgroup
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the caption of all disk drives
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the information if the disk drive is media loaded
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the status of all disk drives
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the size of all disk drives
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get the last last boot up time
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic20(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " os get lastbootuptime");
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

        /// <summary>
        /// Get the caption of all logical disk
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic21(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " path Win32_LogicalDisk Get Caption");
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

        /// <summary>
        /// Get the used filesystem of logical disk
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic22(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_LogicalDisk Get FileSystem");
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

        /// <summary>
        /// Get the size of logical disk
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic23(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_LogicalDisk Get size");
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

        /// <summary>
        /// Get the discription of all network adapters
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic24(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_NetworkAdapter Get Description");
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

        /// <summary>
        /// Get the manufacturer of all network adapters
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic25(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_NetworkAdapter Get manufacturer");
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

        /// <summary>
        /// Get the mac address of all network adapters
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic26(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_NetworkAdapter Get macaddress");
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

        /// <summary>
        /// Get the name of all network adapters
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic27(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_NetworkAdapter Get name");
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

        /// <summary>
        /// Get the adaptertype of all network adapters
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic28(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_NetworkAdapter Get adaptertype");
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

        /// <summary>
        /// Get the installed state of all network adapters
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic29(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_NetworkAdapter Get installed");
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

        /// <summary>
        /// Get the architecture of the operating system
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic30(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_OperatingSystem Get OSArchitecture");
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

        /// <summary>
        /// Get the installdate of the operating system
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic31(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_OperatingSystem Get installdate");
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

        /// <summary>
        /// Get the registered users
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic32(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_OperatingSystem Get registereduser");
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

        /// <summary>
        /// Get the version of the operating system
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic33(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_OperatingSystem Get version");
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

        /// <summary>
        /// Get the status of the operating system
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic34(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_OperatingSystem Get status");
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

        /// <summary>
        /// Get the description of the timezone
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic35(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_TimeZone Get Description");
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

        /// <summary>
        /// Get the setting of the timezone
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetStatistic36(string ip, string username, string password)
        {
            string request = (@"wmic / user:""" + username + "\" /password:\"" + password + "\" /node:" + ip + " Path Win32_SystemTimeZone Get Setting");
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
