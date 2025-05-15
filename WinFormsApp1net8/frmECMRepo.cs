using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1net8
{
    public partial class frmECMRepo : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowLong(IntPtr hWnd, int nIndex);

        private IntPtr javaWindowHandle = IntPtr.Zero;

        public frmECMRepo()
        {
            InitializeComponent();

            // Handle panel resize event
            this.panel2.Resize += Panel2_Resize;
        }

        private void Panel2_Resize(object? sender, EventArgs e)
        {
            if (javaWindowHandle != IntPtr.Zero)
            {
                MoveWindow(javaWindowHandle, 0, 0, this.panel2.Width, this.panel2.Height, true);
            }
        }

        private void btnOpenApplication_Click(object? sender, EventArgs e)
        {
            getJavainsideWindow();
        }

        private void customButton2_Click(object? sender, EventArgs e)
        {
            getJavainsideWindow();
        }

        public void getJavainsideWindow()
        {
            string filepathtoJar = "E:\\Programming\\javajar\\Calculator.jar";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "java",
                Arguments = $"-jar \"{filepathtoJar}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = false // Set to false to create a window
            };

            Process javaProcess = new Process
            {
                StartInfo = startInfo
            };

            javaProcess.Start();

            // Wait for the process to start and get the main window handle
            IntPtr javaWindowHandle = IntPtr.Zero;
            for (int i = 0; i < 50; i++) // Try for 5 seconds
            {
                javaProcess.Refresh();
                javaWindowHandle = javaProcess.MainWindowHandle;
                if (javaWindowHandle != IntPtr.Zero)
                {
                    break;
                }
                Thread.Sleep(100);
            }

            if (javaWindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("Failed to capture the Java application window.");
                return;
            }

            // Embed the Java application window inside the panel
            SetParent(javaWindowHandle, this.panel2.Handle);

            // Remove window borders and title bar
            const int GWL_STYLE = -16;
            const uint WS_CHILD = 0x40000000;
            const uint WS_VISIBLE = 0x10000000;
            const uint WS_CAPTION = 0x00C00000;
            uint style = GetWindowLong(javaWindowHandle, GWL_STYLE);
            SetWindowLong(javaWindowHandle, GWL_STYLE, (style | WS_CHILD | WS_VISIBLE) & ~WS_CAPTION);

            // Resize and move the window to fit the panel
            MoveWindow(javaWindowHandle, 0, 0, this.panel2.Width, this.panel2.Height, true);

            // Store the handle for future resizing
            this.javaWindowHandle = javaWindowHandle;
        }
    }
}
