namespace WindowsFormsTestECM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.customButton2 = new CustomControls.CustomButton.CustomButton();
            this.btnRefreshButton = new CustomControls.CustomButton.CustomButton();
            this.btnOpenApplication = new CustomControls.CustomButton.CustomButton();
            this.btnBackButton = new CustomControls.CustomButton.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddressbar = new System.Windows.Forms.TextBox();
            this.cmbAccelerator = new System.Windows.Forms.ComboBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEcmproduct = new System.Windows.Forms.Label();
            this.cmbProductList = new System.Windows.Forms.ComboBox();
            this.cmdProductService = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customButton1 = new CustomControls.CustomButton.CustomButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customButton2);
            this.panel3.Controls.Add(this.btnRefreshButton);
            this.panel3.Controls.Add(this.btnOpenApplication);
            this.panel3.Controls.Add(this.btnBackButton);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtAddressbar);
            this.panel3.Controls.Add(this.cmbAccelerator);
            this.panel3.Controls.Add(this.webView21);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblEcmproduct);
            this.panel3.Controls.Add(this.cmbProductList);
            this.panel3.Controls.Add(this.cmdProductService);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(1581, 687);
            this.panel3.TabIndex = 0;
            // 
            // customButton2
            // 
            this.customButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.customButton2.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 25;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(1265, 0);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(130, 52);
            this.customButton2.TabIndex = 14;
            this.customButton2.Text = "Open URL";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // btnRefreshButton
            // 
            this.btnRefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRefreshButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRefreshButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefreshButton.BorderRadius = 20;
            this.btnRefreshButton.BorderSize = 0;
            this.btnRefreshButton.FlatAppearance.BorderSize = 0;
            this.btnRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefreshButton.ForeColor = System.Drawing.Color.White;
            this.btnRefreshButton.Location = new System.Drawing.Point(1287, 68);
            this.btnRefreshButton.Name = "btnRefreshButton";
            this.btnRefreshButton.Size = new System.Drawing.Size(125, 37);
            this.btnRefreshButton.TabIndex = 7;
            this.btnRefreshButton.Text = "Refresh";
            this.btnRefreshButton.TextColor = System.Drawing.Color.White;
            this.btnRefreshButton.UseVisualStyleBackColor = false;
            this.btnRefreshButton.Click += new System.EventHandler(this.btnRefreshButton_Click);
            // 
            // btnOpenApplication
            // 
            this.btnOpenApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenApplication.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOpenApplication.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnOpenApplication.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpenApplication.BorderRadius = 25;
            this.btnOpenApplication.BorderSize = 0;
            this.btnOpenApplication.FlatAppearance.BorderSize = 0;
            this.btnOpenApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenApplication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOpenApplication.ForeColor = System.Drawing.Color.White;
            this.btnOpenApplication.Location = new System.Drawing.Point(1398, 0);
            this.btnOpenApplication.Name = "btnOpenApplication";
            this.btnOpenApplication.Size = new System.Drawing.Size(160, 52);
            this.btnOpenApplication.TabIndex = 12;
            this.btnOpenApplication.Text = "Open Accelerator";
            this.btnOpenApplication.TextColor = System.Drawing.Color.White;
            this.btnOpenApplication.UseVisualStyleBackColor = false;
            this.btnOpenApplication.Click += new System.EventHandler(this.btnOpenApplication_Click_1);
            // 
            // btnBackButton
            // 
            this.btnBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBackButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBackButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBackButton.BorderRadius = 20;
            this.btnBackButton.BorderSize = 0;
            this.btnBackButton.FlatAppearance.BorderSize = 0;
            this.btnBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackButton.ForeColor = System.Drawing.Color.White;
            this.btnBackButton.Location = new System.Drawing.Point(1418, 68);
            this.btnBackButton.Name = "btnBackButton";
            this.btnBackButton.Size = new System.Drawing.Size(123, 37);
            this.btnBackButton.TabIndex = 6;
            this.btnBackButton.Text = "Back";
            this.btnBackButton.TextColor = System.Drawing.Color.White;
            this.btnBackButton.UseVisualStyleBackColor = false;
            this.btnBackButton.Click += new System.EventHandler(this.btnBackButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(801, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "ECM Product Accelerator";
            // 
            // txtAddressbar
            // 
            this.txtAddressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressbar.Location = new System.Drawing.Point(5, 68);
            this.txtAddressbar.Multiline = true;
            this.txtAddressbar.Name = "txtAddressbar";
            this.txtAddressbar.Size = new System.Drawing.Size(1276, 30);
            this.txtAddressbar.TabIndex = 5;
            this.txtAddressbar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddressbar_KeyPress);
            // 
            // cmbAccelerator
            // 
            this.cmbAccelerator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAccelerator.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbAccelerator.FormattingEnabled = true;
            this.cmbAccelerator.Location = new System.Drawing.Point(1006, 16);
            this.cmbAccelerator.MaximumSize = new System.Drawing.Size(233, 0);
            this.cmbAccelerator.MinimumSize = new System.Drawing.Size(230, 0);
            this.cmbAccelerator.Name = "cmbAccelerator";
            this.cmbAccelerator.Size = new System.Drawing.Size(230, 33);
            this.cmbAccelerator.TabIndex = 10;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(5, 108);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1573, 576);
            this.webView21.TabIndex = 4;
            this.webView21.ZoomFactor = 1D;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(382, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "ECM Product Service";
            // 
            // lblEcmproduct
            // 
            this.lblEcmproduct.AutoSize = true;
            this.lblEcmproduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEcmproduct.Location = new System.Drawing.Point(5, 16);
            this.lblEcmproduct.Name = "lblEcmproduct";
            this.lblEcmproduct.Size = new System.Drawing.Size(138, 21);
            this.lblEcmproduct.TabIndex = 8;
            this.lblEcmproduct.Text = "ECM Product List";
            // 
            // cmbProductList
            // 
            this.cmbProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductList.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbProductList.FormattingEnabled = true;
            this.cmbProductList.Location = new System.Drawing.Point(149, 12);
            this.cmbProductList.MaximumSize = new System.Drawing.Size(233, 0);
            this.cmbProductList.MinimumSize = new System.Drawing.Size(230, 0);
            this.cmbProductList.Name = "cmbProductList";
            this.cmbProductList.Size = new System.Drawing.Size(230, 33);
            this.cmbProductList.TabIndex = 6;
            this.cmbProductList.SelectedIndexChanged += new System.EventHandler(this.cmbProductList_SelectedIndexChanged);
            // 
            // cmdProductService
            // 
            this.cmdProductService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdProductService.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmdProductService.FormattingEnabled = true;
            this.cmdProductService.Location = new System.Drawing.Point(556, 16);
            this.cmdProductService.MaximumSize = new System.Drawing.Size(233, 0);
            this.cmdProductService.MinimumSize = new System.Drawing.Size(230, 0);
            this.cmdProductService.Name = "cmdProductService";
            this.cmdProductService.Size = new System.Drawing.Size(230, 33);
            this.cmdProductService.TabIndex = 7;
            this.cmdProductService.SelectedIndexChanged += new System.EventHandler(this.cmdProductService_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(7, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1581, 687);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1295, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // customButton1
            // 
            this.customButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.customButton1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 0;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(118, 13);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(1184, 92);
            this.customButton1.TabIndex = 17;
            this.customButton1.Text = "ECM ACCELERATOR LANDING PAGE";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1592, 810);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "ECM TCS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private CustomControls.CustomButton.CustomButton btnRefreshButton;
        private CustomControls.CustomButton.CustomButton btnBackButton;
        private System.Windows.Forms.TextBox txtAddressbar;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbProductList;
        private System.Windows.Forms.ComboBox cmdProductService;
        private System.Windows.Forms.Label lblEcmproduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAccelerator;
        private System.Windows.Forms.Label label1;
        private CustomControls.CustomButton.CustomButton btnOpenApplication;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.CustomButton.CustomButton customButton1;
        private CustomControls.CustomButton.CustomButton customButton2;
    }
}