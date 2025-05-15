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
using System.Runtime.InteropServices;
using static Vanara.PInvoke.Kernel32.PSS_HANDLE_ENTRY;

namespace WinFormsApp1net8
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowLong(IntPtr hWnd, int nIndex);
        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private const int GWL_STYLE = -16;
        private const uint WS_CHILD = 0x40000000;
        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MAXIMIZE = 0xF030;

        public MDIParent1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Maximize the window by default

            //// Initialize ComboBoxes
            //cmbProductList = new ComboBox();
            //cmdProductService = new ComboBox();
            //cmbAccelerator = new ComboBox();

            // Set properties for cmbProductList
            cmbProductList.Items.AddRange(new string[] { "Hyland", "OpenText" });
            cmbProductList.Text = "Select Product";
            cmbProductList.SelectedIndexChanged += cmbProductList_SelectedIndexChanged;

            // Set properties for cmdProductService
            cmdProductService.Text = "Select Service";
            cmdProductService.SelectedIndexChanged += cmdProductService_SelectedIndexChanged;

            // Set properties for cmbAccelerator
            cmbAccelerator.Text = "Select Accelerator";

            //// Create a TableLayoutPanel to organize the controls
            //TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            //{
            //    Dock = DockStyle.Top,
            //    ColumnCount = 2,
            //    RowCount = 3,
            //    AutoSize = true
            //};

            //// Add labels and ComboBoxes to the TableLayoutPanel
            //tableLayoutPanel.Controls.Add(new Label { Text = "Product:", Anchor = AnchorStyles.Right, AutoSize = true }, 0, 0);
            //tableLayoutPanel.Controls.Add(cmbProductList, 1, 0);
            //tableLayoutPanel.Controls.Add(new Label { Text = "Service:", Anchor = AnchorStyles.Right, AutoSize = true }, 0, 1);
            //tableLayoutPanel.Controls.Add(cmdProductService, 1, 1);
            //tableLayoutPanel.Controls.Add(new Label { Text = "Accelerator:", Anchor = AnchorStyles.Right, AutoSize = true }, 0, 2);
            //tableLayoutPanel.Controls.Add(cmbAccelerator, 1, 2);

            // Add the TableLayoutPanel to the form
            //  this.Controls.Add(tableLayoutPanel);


        }

        private void cmbProductList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            cmdProductService.Items.Clear();

            if (cmbProductList.SelectedItem?.ToString() == "Hyland")
            {
                cmdProductService.Items.AddRange(new string[] { "OnBase", "Alfresco", "Nuxeo" });
            }
            else if (cmbProductList.SelectedItem?.ToString() == "OpenText")
            {
                cmdProductService.Items.AddRange(new string[] { "OpenText Content Suite", "OpenText Extended ECM", "OpenText Documentum" });
            }

            cmdProductService.Text = "Select Service"; // Reset default text
            cmbAccelerator.Items.Clear(); // Clear the accelerator combo box
            cmbAccelerator.Text = "Select Accelerator"; // Reset default text
        }

        private void cmdProductService_SelectedIndexChanged(object? sender, EventArgs e)
        {
            cmbAccelerator.Items.Clear();

            string? selectedService = cmdProductService.SelectedItem?.ToString();

            if (selectedService == "Alfresco")
            {
                cmbAccelerator.Items.Add("Alfresco Migrator Application");
            }
            else if (selectedService == "OnBase")
            {
                cmbAccelerator.Items.Add("OnBase Eforms");
            }
            else if (selectedService == "OpenText Documentum")
            {
                cmbAccelerator.Items.Add("DocxFer Application");
            }

            cmbAccelerator.Text = "Select Accelerator"; // Reset default text
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void javaAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getJavaApplication();
        }

        public void getJavaApplication()
        {
            try
            {
                // Path to the JAR file
                string filepathtoJar = "E:\\Programming\\javajar\\Calculator.jar";

                // Start the Java application
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "java",
                    Arguments = $"-jar \"{filepathtoJar}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                System.Diagnostics.Process javaProcess = new System.Diagnostics.Process
                {
                    StartInfo = startInfo
                };

                javaProcess.Start();

                // Wait for the process to be ready
                javaProcess.WaitForInputIdle();

                // Wait until the main window handle is available
                while (javaProcess.MainWindowHandle == IntPtr.Zero)
                {
                    System.Threading.Thread.Sleep(100);
                    javaProcess.Refresh();
                }

                // Set the parent of the Java application window to the current form
                SetParent(javaProcess.MainWindowHandle, this.Handle);

                // Set the style to WS_CHILD so that the window behaves like a child window
                uint style = GetWindowLong(javaProcess.MainWindowHandle, GWL_STYLE);
                SetWindowLong(javaProcess.MainWindowHandle, GWL_STYLE, style | WS_CHILD);

                // Maximize the window within the form
                SendMessage(javaProcess.MainWindowHandle, WM_SYSCOMMAND, (IntPtr)SC_MAXIMIZE, IntPtr.Zero);
            }
            catch (Exception ex)
            {
                // Handle the exception here
                // MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void documentumDocxFerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getJavaApplication();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void cmbAccelerator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenApplication_Click(object sender, EventArgs e)
        {
            var javaInstance = new java.util.Date();
            // Invoke a Java method from .NET
            javaInstance.setDate(12);

            // Get a result from a Java method
            var result = javaInstance.getDate();

            //label4.Text= result.ToString();
            getJavaApplication();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
