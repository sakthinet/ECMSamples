using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Vanara.PInvoke.User32;
using Vanara.PInvoke;
using System.Diagnostics;

namespace WinFormsApp1net8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form javaForm = new Form();
                javaForm.MdiParent = this;
                javaForm.Text = "Java Application";
                javaForm.Show();

                Process javaProcess = new Process();
                javaProcess.StartInfo.FileName = "java";
                javaProcess.StartInfo.Arguments = "-jar C:\\Users\\Nethra\\Downloads\\Jswingapp3.jar"; // Replace with your JAR file path
                javaProcess.StartInfo.UseShellExecute = false;
                javaProcess.StartInfo.RedirectStandardOutput = true;
                javaProcess.StartInfo.RedirectStandardError = true;
                javaProcess.OutputDataReceived += (s, ev) => Console.WriteLine(ev.Data);
                javaProcess.ErrorDataReceived += (s, ev) => Console.WriteLine(ev.Data);
                javaProcess.Start();

                // Wait for the Java application to load
                javaProcess.WaitForInputIdle();

                // Get the main window handle of the Java application
                IntPtr javaAppHandle = javaProcess.MainWindowHandle;

                // Reparent the Java application's window to the MDI child form
                User32.SetParent(javaAppHandle, javaForm.Handle);

                // Resize the Java application's window to fit the MDI child form
                User32.SetWindowPos(javaAppHandle, HWND.NULL, 0, 0, javaForm.ClientSize.Width, javaForm.ClientSize.Height, SetWindowPosFlags.SWP_NOZORDER | SetWindowPosFlags.SWP_NOACTIVATE);
                //Process javaProcess = new Process();
                //javaProcess.StartInfo.FileName = "java";
                //javaProcess.StartInfo.Arguments = "-jar C:\\Users\\Nethra\\Downloads\\Jswingapp3.jar"; // Replace with your JAR file path
                //javaProcess.StartInfo.UseShellExecute = false;
                //javaProcess.StartInfo.RedirectStandardOutput = true;
                //javaProcess.StartInfo.RedirectStandardError = true;
                //javaProcess.OutputDataReceived += (s, ev) => Console.WriteLine(ev.Data);
                //javaProcess.ErrorDataReceived += (s, ev) => Console.WriteLine(ev.Data);
                //javaProcess.Start();
                //javaProcess.BeginOutputReadLine();
                //javaProcess.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
