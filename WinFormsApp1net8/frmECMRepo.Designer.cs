namespace WinFormsApp1net8
{
    partial class frmECMRepo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmECMRepo));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            btnOpenApplication = new CustomControls.CustomButton.CustomButton();
            label1 = new Label();
            cmbAccelerator = new ComboBox();
            label2 = new Label();
            lblEcmproduct = new Label();
            cmdProductService = new ComboBox();
            cmbProductList = new ComboBox();
            customButton1 = new CustomControls.CustomButton.CustomButton();
            panel2 = new Panel();
            customButton2 = new CustomControls.CustomButton.CustomButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 101);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1501, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(286, 101);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOpenApplication);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbAccelerator);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblEcmproduct);
            panel1.Controls.Add(cmdProductService);
            panel1.Controls.Add(cmbProductList);
            panel1.Location = new Point(1, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(1786, 86);
            panel1.TabIndex = 0;
            // Update panel2 properties
            panel2.Controls.Add(customButton2);
            panel2.Location = new Point(2, 210);
            panel2.Name = "panel2";
            panel2.Size = new Size(1776, 569);
            panel2.TabIndex = 10;
            // 
            // btnOpenApplication
            // 
            btnOpenApplication.BackColor = Color.DodgerBlue;
            btnOpenApplication.BackgroundColor = Color.DodgerBlue;
            btnOpenApplication.BorderColor = Color.PaleVioletRed;
            btnOpenApplication.BorderRadius = 25;
            btnOpenApplication.BorderSize = 0;
            btnOpenApplication.FlatAppearance.BorderSize = 0;
            btnOpenApplication.FlatStyle = FlatStyle.Flat;
            btnOpenApplication.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnOpenApplication.ForeColor = Color.White;
            btnOpenApplication.Location = new Point(1511, 3);
            btnOpenApplication.Name = "btnOpenApplication";
            btnOpenApplication.Size = new Size(266, 80);
            btnOpenApplication.TabIndex = 12;
            btnOpenApplication.Text = "Open Accelerator";
            btnOpenApplication.TextColor = Color.White;
            btnOpenApplication.UseVisualStyleBackColor = false;
            btnOpenApplication.Click += btnOpenApplication_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(948, 26);
            label1.Name = "label1";
            label1.Size = new Size(235, 25);
            label1.TabIndex = 11;
            label1.Text = "ECM Product Accelerator";
            // 
            // cmbAccelerator
            // 
            cmbAccelerator.Font = new Font("Segoe UI", 14F);
            cmbAccelerator.FormattingEnabled = true;
            cmbAccelerator.Location = new Point(1189, 23);
            cmbAccelerator.Name = "cmbAccelerator";
            cmbAccelerator.Size = new Size(247, 33);
            cmbAccelerator.TabIndex = 10;
          //  cmbAccelerator.SelectedIndexChanged += cmbAccelerator_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(467, 23);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 9;
            label2.Text = "ECM Product Service";
            // 
            // lblEcmproduct
            // 
            lblEcmproduct.AutoSize = true;
            lblEcmproduct.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblEcmproduct.Location = new Point(11, 23);
            lblEcmproduct.Name = "lblEcmproduct";
            lblEcmproduct.Size = new Size(164, 25);
            lblEcmproduct.TabIndex = 8;
            lblEcmproduct.Text = "ECM Product List";
            // 
            // cmdProductService
            // 
            cmdProductService.Font = new Font("Segoe UI", 14F);
            cmdProductService.FormattingEnabled = true;
            cmdProductService.Location = new Point(660, 23);
            cmdProductService.Name = "cmdProductService";
            cmdProductService.Size = new Size(282, 33);
            cmdProductService.TabIndex = 7;
           // cmdProductService.SelectedIndexChanged += cmdProductService_SelectedIndexChanged;
            // 
            // cmbProductList
            // 
            cmbProductList.Font = new Font("Segoe UI", 14F);
            cmbProductList.FormattingEnabled = true;
            cmbProductList.Location = new Point(181, 20);
            cmbProductList.Name = "cmbProductList";
            cmbProductList.Size = new Size(280, 33);
            cmbProductList.TabIndex = 6;
           // cmbProductList.SelectedIndexChanged += cmbProductList_SelectedIndexChanged;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.DodgerBlue;
            customButton1.BackgroundColor = Color.DodgerBlue;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 0;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(110, 1);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(1396, 101);
            customButton1.TabIndex = 9;
            customButton1.Text = "ECM LANDING PAGE";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(customButton2);
            panel2.Location = new Point(2, 210);
            panel2.Name = "panel2";
            panel2.Size = new Size(1776, 569);
            panel2.TabIndex = 10;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.DodgerBlue;
            customButton2.BackgroundColor = Color.DodgerBlue;
            customButton2.BorderColor = Color.PaleVioletRed;
            customButton2.BorderRadius = 25;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(1507, 3);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(266, 80);
            customButton2.TabIndex = 13;
            customButton2.Text = "Open Accelerator";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // frmECMRepo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1790, 791);
            Controls.Add(panel2);
            Controls.Add(customButton1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "frmECMRepo";
            Text = "frmECMRepo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private ComboBox cmbAccelerator;
        private Label label2;
        private Label lblEcmproduct;
        private ComboBox cmdProductService;
        private ComboBox cmbProductList;
        private CustomControls.CustomButton.CustomButton customButton1;
        private CustomControls.CustomButton.CustomButton btnOpenApplication;
        private Panel panel2;
        private CustomControls.CustomButton.CustomButton customButton2;
    }
}