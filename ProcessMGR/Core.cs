using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ProcessMGR
{
    public class Core
    {
        /// <summary>
        /// Kill process by its name like "javaw"(no".exe"!!!)
        /// </summary>
        /// <param name="processName"></param>
        public static void KillProcess(String processName)
        {
            foreach (var item in Process.GetProcessesByName(processName))
            {
                item.Kill();
            }
        }

        #region DLLImporter
        [Flags]
        public enum ProcessAccess : uint
        {
            Terminate = 0x1,
            CreateThread = 0x2,
            SetSessionId = 0x4,
            VmOperation = 0x8,
            VmRead = 0x10,
            VmWrite = 0x20,
            DupHandle = 0x40,
            CreateProcess = 0x80,
            SetQuota = 0x100,
            SetInformation = 0x200,
            QueryInformation = 0x400,
            SetPort = 0x800,
            SuspendResume = 0x800,
            QueryLimitedInformation = 0x1000,
            Synchronize = 0x100000
        }

        [DllImport("ntdll.dll")]
        private static extern uint NtResumeProcess([In] IntPtr processHandle);

        [DllImport("ntdll.dll")]
        private static extern uint NtSuspendProcess([In] IntPtr processHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr OpenProcess(
        ProcessAccess desiredAccess,
        bool inheritHandle,
        int processId);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle([In] IntPtr handle);
        #endregion
        /// <summary>
        /// Suspend process by process id
        /// </summary>
        /// <param name="processID"></param>
        public static void SuspendProcess(String processName)
        {
            int processID = 0;
            foreach (var item in Process.GetProcessesByName(processName))
            {
                processID = item.Id;
            }
            IntPtr hProc = IntPtr.Zero;
            try
            {
                hProc = OpenProcess(ProcessAccess.SuspendResume, false, processID);
                if (hProc != IntPtr.Zero)
                    NtSuspendProcess(hProc);
            }
            finally
            {
                if (hProc != IntPtr.Zero)
                    CloseHandle(hProc);
            }
        }

        /// <summary>
        /// Resume process by process id
        /// </summary>
        /// <param name="processID"></param>
        public static void ResumeProcess(String processName)
        {
            int processID = 0;
            foreach (var item in Process.GetProcessesByName(processName))
            {
                processID = item.Id;
            }
            IntPtr hProc = IntPtr.Zero;
            try
            {
                hProc = OpenProcess(ProcessAccess.SuspendResume, false, processID);
                if (hProc != IntPtr.Zero)
                    NtResumeProcess(hProc);
            }
            finally
            {
                if (hProc != IntPtr.Zero)
                    CloseHandle(hProc);
            }
        }

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        /// <summary>
        /// Get windows exist state by its name like "xxxxx"
        /// </summary>
        /// <param name="windowName"></param>
        /// <returns></returns>
        public static bool IsWindowExist(String windowName)
        {
            IntPtr @int = FindWindow(null, windowName);
            if (@int.ToInt64() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Get process exist state by its name like "javaw"(no".exe"!!!)
        /// </summary>
        /// <param name="processName"></param>
        /// <returns></returns>
        public static bool IsProcessExist(String processName)
        {
            if (Process.GetProcessesByName(processName).Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Start process with path(Same effect like Process.Start())
        /// </summary>
        /// <param name="processPath"></param>
        public static void StartProcess(String processPath)
        {
            Process.Start(processPath);
        }

        [DllImport("user32.dll", EntryPoint = "SetWindowText")]
        public static extern int SetWindowText(IntPtr hwnd, string lpString);
        /// <summary>
        /// Set window title by its process name
        /// </summary>
        /// <param name="titleText"></param>
        /// <param name="processName">demo:"javaw"(no".exe"!!!)</param>
        public static void ChangeWindowTitle(String titleText,String processName)
        {
            if (IsProcessExist(processName))
            {
                foreach (Process item in Process.GetProcessesByName(processName))
                {
                    SetWindowText(item.MainWindowHandle, titleText);
                }
            }
        }
        /// <summary>
        /// Set window title by its process name
        /// </summary>
        /// <param name="titleText">a String array list for title texts</param>
        /// <param name="processName">demo:"javaw"(no".exe"!!!)</param>
        public static void ChangeWindowTitle(String[] titleText, String processName)
        {
            if (IsProcessExist(processName))
            {
                foreach (Process item in Process.GetProcessesByName(processName))
                {
                    foreach (var i in titleText)
                    {
                        SetWindowText(item.MainWindowHandle, i);
                    }
                }
            }
        }
    }
}
