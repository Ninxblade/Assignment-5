namespace Assignment__5.Views
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.ProductInfoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.GPUTypelabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MemoeryDataLabel = new System.Windows.Forms.Label();
            this.CPUBrandDataLabel = new System.Windows.Forms.Label();
            this.CPUTypeDataLabel = new System.Windows.Forms.Label();
            this.LCDDataLabel = new System.Windows.Forms.Label();
            this.CPUNumDataLabel = new System.Windows.Forms.Label();
            this.CPUSpeedDataLabel = new System.Windows.Forms.Label();
            this.HDDDataLabel = new System.Windows.Forms.Label();
            this.GPUTypeDataLabel = new System.Windows.Forms.Label();
            this.WebCamDataLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.ComfirmLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectAnotherpProductButton = new System.Windows.Forms.Button();
            this.PlatformDataLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ManufactuerDataLabel = new System.Windows.Forms.Label();
            this.ModelDataLabel = new System.Windows.Forms.Label();
            this.OSDataLabel = new System.Windows.Forms.Label();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductIDDataLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ConditionDataLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CostDataLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductInfoLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ProductsaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProductInfoMenuStrip.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductInfoMenuStrip
            // 
            this.ProductInfoMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ProductInfoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.ProductInfoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoMenuStrip.Name = "ProductInfoMenuStrip";
            this.ProductInfoMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.ProductInfoMenuStrip.Size = new System.Drawing.Size(784, 30);
            this.ProductInfoMenuStrip.TabIndex = 0;
            this.ProductInfoMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.toolStripSeparator,
            this.SaveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(221, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.selectAnotherProductToolStripMenuItem.Text = "Select Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.SelectAnotherpProductButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(678, 504);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(92, 37);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.GPUTypelabel, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.MemoryLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CPUBrandLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.MemoeryDataLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.CPUBrandDataLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.CPUTypeDataLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.LCDDataLabel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.CPUNumDataLabel, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.CPUSpeedDataLabel, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.HDDDataLabel, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.GPUTypeDataLabel, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.WebCamDataLabel, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.WebCamLabel, 4, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 313);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(758, 174);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "LCD Size";
            // 
            // GPUTypelabel
            // 
            this.GPUTypelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GPUTypelabel.AutoSize = true;
            this.GPUTypelabel.Location = new System.Drawing.Point(507, 74);
            this.GPUTypelabel.Name = "GPUTypelabel";
            this.GPUTypelabel.Size = new System.Drawing.Size(120, 25);
            this.GPUTypelabel.TabIndex = 0;
            this.GPUTypelabel.Text = "GPU Type";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "HDD";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(3, 16);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(120, 25);
            this.MemoryLabel.TabIndex = 0;
            this.MemoryLabel.Text = "Memory";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(3, 74);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(120, 25);
            this.CPUBrandLabel.TabIndex = 0;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU Type";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(255, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "CPU Speed";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "CPU Number";
            // 
            // MemoeryDataLabel
            // 
            this.MemoeryDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoeryDataLabel.BackColor = System.Drawing.Color.White;
            this.MemoeryDataLabel.Location = new System.Drawing.Point(129, 15);
            this.MemoeryDataLabel.Name = "MemoeryDataLabel";
            this.MemoeryDataLabel.Size = new System.Drawing.Size(120, 28);
            this.MemoeryDataLabel.TabIndex = 1;
            this.MemoeryDataLabel.Text = "8GB";
            this.MemoeryDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUBrandDataLabel
            // 
            this.CPUBrandDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUBrandDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUBrandDataLabel.Location = new System.Drawing.Point(129, 73);
            this.CPUBrandDataLabel.Name = "CPUBrandDataLabel";
            this.CPUBrandDataLabel.Size = new System.Drawing.Size(120, 28);
            this.CPUBrandDataLabel.TabIndex = 2;
            this.CPUBrandDataLabel.Text = "Intel";
            this.CPUBrandDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUTypeDataLabel
            // 
            this.CPUTypeDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUTypeDataLabel.Location = new System.Drawing.Point(129, 131);
            this.CPUTypeDataLabel.Name = "CPUTypeDataLabel";
            this.CPUTypeDataLabel.Size = new System.Drawing.Size(120, 27);
            this.CPUTypeDataLabel.TabIndex = 3;
            this.CPUTypeDataLabel.Text = "Quad-Core";
            this.CPUTypeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LCDDataLabel
            // 
            this.LCDDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LCDDataLabel.BackColor = System.Drawing.Color.White;
            this.LCDDataLabel.Location = new System.Drawing.Point(381, 16);
            this.LCDDataLabel.Name = "LCDDataLabel";
            this.LCDDataLabel.Size = new System.Drawing.Size(120, 26);
            this.LCDDataLabel.TabIndex = 4;
            this.LCDDataLabel.Text = "17.3\"";
            this.LCDDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUNumDataLabel
            // 
            this.CPUNumDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUNumDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUNumDataLabel.Location = new System.Drawing.Point(381, 74);
            this.CPUNumDataLabel.Name = "CPUNumDataLabel";
            this.CPUNumDataLabel.Size = new System.Drawing.Size(120, 26);
            this.CPUNumDataLabel.TabIndex = 5;
            this.CPUNumDataLabel.Text = "I7-2630QM";
            this.CPUNumDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUSpeedDataLabel
            // 
            this.CPUSpeedDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUSpeedDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUSpeedDataLabel.Location = new System.Drawing.Point(381, 133);
            this.CPUSpeedDataLabel.Name = "CPUSpeedDataLabel";
            this.CPUSpeedDataLabel.Size = new System.Drawing.Size(120, 23);
            this.CPUSpeedDataLabel.TabIndex = 6;
            this.CPUSpeedDataLabel.Text = "2.0Ghz";
            this.CPUSpeedDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HDDDataLabel
            // 
            this.HDDDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HDDDataLabel.BackColor = System.Drawing.Color.White;
            this.HDDDataLabel.Location = new System.Drawing.Point(633, 13);
            this.HDDDataLabel.Name = "HDDDataLabel";
            this.HDDDataLabel.Size = new System.Drawing.Size(122, 32);
            this.HDDDataLabel.TabIndex = 7;
            this.HDDDataLabel.Text = "1TB";
            this.HDDDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GPUTypeDataLabel
            // 
            this.GPUTypeDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GPUTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.GPUTypeDataLabel.Location = new System.Drawing.Point(633, 71);
            this.GPUTypeDataLabel.Name = "GPUTypeDataLabel";
            this.GPUTypeDataLabel.Size = new System.Drawing.Size(122, 31);
            this.GPUTypeDataLabel.TabIndex = 8;
            this.GPUTypeDataLabel.Text = "NVIDIA GeForce GTX 560M";
            this.GPUTypeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WebCamDataLabel
            // 
            this.WebCamDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WebCamDataLabel.BackColor = System.Drawing.Color.White;
            this.WebCamDataLabel.Location = new System.Drawing.Point(633, 129);
            this.WebCamDataLabel.Name = "WebCamDataLabel";
            this.WebCamDataLabel.Size = new System.Drawing.Size(122, 32);
            this.WebCamDataLabel.TabIndex = 9;
            this.WebCamDataLabel.Text = "1.3MP";
            this.WebCamDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(507, 132);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(96, 25);
            this.WebCamLabel.TabIndex = 10;
            this.WebCamLabel.Text = "WebCam";
            // 
            // ComfirmLabel
            // 
            this.ComfirmLabel.AutoSize = true;
            this.ComfirmLabel.Location = new System.Drawing.Point(15, 504);
            this.ComfirmLabel.Name = "ComfirmLabel";
            this.ComfirmLabel.Size = new System.Drawing.Size(326, 25);
            this.ComfirmLabel.TabIndex = 1;
            this.ComfirmLabel.Text = "Click Next to Confirm Your Selection";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(540, 504);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(110, 37);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectAnotherpProductButton
            // 
            this.SelectAnotherpProductButton.BackColor = System.Drawing.Color.White;
            this.SelectAnotherpProductButton.Location = new System.Drawing.Point(296, 504);
            this.SelectAnotherpProductButton.Name = "SelectAnotherpProductButton";
            this.SelectAnotherpProductButton.Size = new System.Drawing.Size(238, 37);
            this.SelectAnotherpProductButton.TabIndex = 9;
            this.SelectAnotherpProductButton.Text = "Select another product";
            this.SelectAnotherpProductButton.UseVisualStyleBackColor = false;
            this.SelectAnotherpProductButton.Click += new System.EventHandler(this.SelectAnotherpProductButton_Click);
            // 
            // PlatformDataLabel
            // 
            this.PlatformDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatformDataLabel.AutoSize = true;
            this.PlatformDataLabel.BackColor = System.Drawing.Color.White;
            this.PlatformDataLabel.Location = new System.Drawing.Point(154, 27);
            this.PlatformDataLabel.Name = "PlatformDataLabel";
            this.PlatformDataLabel.Size = new System.Drawing.Size(145, 25);
            this.PlatformDataLabel.TabIndex = 0;
            this.PlatformDataLabel.Text = "Platform";
            this.PlatformDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OSLabel
            // 
            this.OSLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(305, 27);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(145, 25);
            this.OSLabel.TabIndex = 1;
            this.OSLabel.Text = "OS";
            // 
            // ModelLabel
            // 
            this.ModelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelLabel.Location = new System.Drawing.Point(305, 106);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(145, 25);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Model";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(3, 106);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(145, 25);
            this.ManufacturerLabel.TabIndex = 1;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(3, 27);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(145, 25);
            this.PlatformLabel.TabIndex = 0;
            this.PlatformLabel.Text = "Platform";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.PlatformLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ManufacturerLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ModelLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.OSLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ManufactuerDataLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ModelDataLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlatformDataLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.OSDataLabel, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 159);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ManufactuerDataLabel
            // 
            this.ManufactuerDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ManufactuerDataLabel.AutoSize = true;
            this.ManufactuerDataLabel.BackColor = System.Drawing.Color.White;
            this.ManufactuerDataLabel.Location = new System.Drawing.Point(154, 106);
            this.ManufactuerDataLabel.Name = "ManufactuerDataLabel";
            this.ManufactuerDataLabel.Size = new System.Drawing.Size(145, 25);
            this.ManufactuerDataLabel.TabIndex = 2;
            this.ManufactuerDataLabel.Text = "Toshiba";
            // 
            // ModelDataLabel
            // 
            this.ModelDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelDataLabel.AutoSize = true;
            this.ModelDataLabel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.ModelDataLabel, 2);
            this.ModelDataLabel.Location = new System.Drawing.Point(456, 106);
            this.ModelDataLabel.Name = "ModelDataLabel";
            this.ModelDataLabel.Size = new System.Drawing.Size(299, 25);
            this.ModelDataLabel.TabIndex = 4;
            this.ModelDataLabel.Text = "X770-01J";
            // 
            // OSDataLabel
            // 
            this.OSDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OSDataLabel.AutoSize = true;
            this.OSDataLabel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.OSDataLabel, 2);
            this.OSDataLabel.Location = new System.Drawing.Point(456, 14);
            this.OSDataLabel.Name = "OSDataLabel";
            this.OSDataLabel.Size = new System.Drawing.Size(299, 50);
            this.OSDataLabel.TabIndex = 3;
            this.OSDataLabel.Text = "Windows 7 Home Preminum 64-Bit";
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.Location = new System.Drawing.Point(8, 40);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(85, 31);
            this.ProductIDLabel.TabIndex = 10;
            this.ProductIDLabel.Text = "Product ID";
            this.ProductIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductIDDataLabel
            // 
            this.ProductIDDataLabel.BackColor = System.Drawing.Color.White;
            this.ProductIDDataLabel.Location = new System.Drawing.Point(99, 40);
            this.ProductIDDataLabel.Name = "ProductIDDataLabel";
            this.ProductIDDataLabel.Size = new System.Drawing.Size(132, 31);
            this.ProductIDDataLabel.TabIndex = 11;
            this.ProductIDDataLabel.Text = "7";
            this.ProductIDDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(237, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 31);
            this.label12.TabIndex = 12;
            this.label12.Text = "Condition";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConditionDataLabel
            // 
            this.ConditionDataLabel.BackColor = System.Drawing.Color.White;
            this.ConditionDataLabel.Location = new System.Drawing.Point(341, 40);
            this.ConditionDataLabel.Name = "ConditionDataLabel";
            this.ConditionDataLabel.Size = new System.Drawing.Size(112, 31);
            this.ConditionDataLabel.TabIndex = 13;
            this.ConditionDataLabel.Text = "New";
            this.ConditionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(461, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 31);
            this.label14.TabIndex = 14;
            this.label14.Text = "Cost";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CostDataLabel
            // 
            this.CostDataLabel.BackColor = System.Drawing.Color.White;
            this.CostDataLabel.Location = new System.Drawing.Point(559, 40);
            this.CostDataLabel.Name = "CostDataLabel";
            this.CostDataLabel.Size = new System.Drawing.Size(121, 31);
            this.CostDataLabel.TabIndex = 15;
            this.CostDataLabel.Text = "#1,499.99";
            this.CostDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tech Specs";
            // 
            // ProductInfoLabel
            // 
            this.ProductInfoLabel.AutoSize = true;
            this.ProductInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInfoLabel.Location = new System.Drawing.Point(32, 94);
            this.ProductInfoLabel.Name = "ProductInfoLabel";
            this.ProductInfoLabel.Size = new System.Drawing.Size(128, 25);
            this.ProductInfoLabel.TabIndex = 16;
            this.ProductInfoLabel.Text = "Product Info";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.ProductInfoLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CostDataLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ConditionDataLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ProductIDDataLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.SelectAnotherpProductButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.ComfirmLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ProductInfoMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ProductInfoMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.ProductInfoMenuStrip.ResumeLayout(false);
            this.ProductInfoMenuStrip.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ProductInfoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ComfirmLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GPUTypelabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectAnotherpProductButton;
        private System.Windows.Forms.Label MemoeryDataLabel;
        private System.Windows.Forms.Label CPUBrandDataLabel;
        private System.Windows.Forms.Label CPUTypeDataLabel;
        private System.Windows.Forms.Label LCDDataLabel;
        private System.Windows.Forms.Label CPUNumDataLabel;
        private System.Windows.Forms.Label CPUSpeedDataLabel;
        private System.Windows.Forms.Label HDDDataLabel;
        private System.Windows.Forms.Label GPUTypeDataLabel;
        private System.Windows.Forms.Label WebCamDataLabel;
        private System.Windows.Forms.Label PlatformDataLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ManufactuerDataLabel;
        private System.Windows.Forms.Label ModelDataLabel;
        private System.Windows.Forms.Label OSDataLabel;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ProductIDDataLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ConditionDataLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label CostDataLabel;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ProductInfoLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SaveFileDialog ProductsaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}