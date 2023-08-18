namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Name = new TextBox();
            label1 = new Label();
            GPU20Series = new RadioButton();
            GPU30Series = new RadioButton();
            GPU40Series = new RadioButton();
            label3 = new Label();
            NumRamSticks = new TextBox();
            RAM8GB = new RadioButton();
            RAM16GB = new RadioButton();
            RAM32GB = new RadioButton();
            StorageSSD = new ListBox();
            label5 = new Label();
            PickCPU = new CheckedListBox();
            label6 = new Label();
            label7 = new Label();
            NumOfFans = new TextBox();
            RamSize = new GroupBox();
            groupBox2 = new GroupBox();
            Calculate = new Button();
            Reset = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ResultMessage = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox2 = new PictureBox();
            tabPage2 = new TabPage();
            pictureBox3 = new PictureBox();
            tabPage3 = new TabPage();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            tabPage4 = new TabPage();
            pictureBox5 = new PictureBox();
            groupBox3 = new GroupBox();
            LCYes = new RadioButton();
            LCNo = new RadioButton();
            tabPage5 = new TabPage();
            StorageSize = new GroupBox();
            StorageSize8GB = new RadioButton();
            StorageSize16G = new RadioButton();
            StorageSize32GB = new RadioButton();
            pictureBox6 = new PictureBox();
            tabPage6 = new TabPage();
            groupBox4 = new GroupBox();
            RandomYes = new RadioButton();
            RandomNo = new RadioButton();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox8 = new PictureBox();
            comboBoxCaseSize = new ComboBox();
            label10 = new Label();
            label2 = new Label();
            label4 = new Label();
            label8 = new Label();
            PCBudget = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox9 = new PictureBox();
            groupBox1 = new GroupBox();
            PurposeGaming = new RadioButton();
            PurposeWork = new RadioButton();
            PurposeHome = new RadioButton();
            Email = new TextBox();
            label14 = new Label();
            IsWithinBudget = new Label();
            WithinBudget = new Label();
            RamSize.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox3.SuspendLayout();
            tabPage5.SuspendLayout();
            StorageSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            tabPage6.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Name
            // 
            Name.Location = new Point(178, 117);
            Name.Name = "Name";
            Name.Size = new Size(200, 39);
            Name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 119);
            label1.Name = "label1";
            label1.Size = new Size(94, 33);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // GPU20Series
            // 
            GPU20Series.AutoSize = true;
            GPU20Series.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            GPU20Series.Location = new Point(18, 47);
            GPU20Series.Name = "GPU20Series";
            GPU20Series.Size = new Size(155, 37);
            GPU20Series.TabIndex = 3;
            GPU20Series.TabStop = true;
            GPU20Series.Text = "20 Series";
            GPU20Series.UseVisualStyleBackColor = true;
            GPU20Series.CheckedChanged += GPU20Series_CheckedChanged;
            // 
            // GPU30Series
            // 
            GPU30Series.AutoSize = true;
            GPU30Series.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            GPU30Series.Location = new Point(18, 92);
            GPU30Series.Name = "GPU30Series";
            GPU30Series.Size = new Size(155, 37);
            GPU30Series.TabIndex = 4;
            GPU30Series.TabStop = true;
            GPU30Series.Text = "30 Series";
            GPU30Series.UseVisualStyleBackColor = true;
            GPU30Series.CheckedChanged += GPU30Series_CheckedChanged;
            // 
            // GPU40Series
            // 
            GPU40Series.AutoSize = true;
            GPU40Series.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            GPU40Series.Location = new Point(18, 135);
            GPU40Series.Name = "GPU40Series";
            GPU40Series.Size = new Size(155, 37);
            GPU40Series.TabIndex = 5;
            GPU40Series.TabStop = true;
            GPU40Series.Text = "40 Series";
            GPU40Series.UseVisualStyleBackColor = true;
            GPU40Series.CheckedChanged += GPU40Series_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 15);
            label3.Name = "label3";
            label3.Size = new Size(354, 33);
            label3.TabIndex = 6;
            label3.Text = "Number of Ram Sticks Pairs:";
            // 
            // NumRamSticks
            // 
            NumRamSticks.Location = new Point(360, 15);
            NumRamSticks.Name = "NumRamSticks";
            NumRamSticks.Size = new Size(98, 39);
            NumRamSticks.TabIndex = 7;
            // 
            // RAM8GB
            // 
            RAM8GB.AutoSize = true;
            RAM8GB.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            RAM8GB.Location = new Point(18, 42);
            RAM8GB.Name = "RAM8GB";
            RAM8GB.Size = new Size(103, 37);
            RAM8GB.TabIndex = 8;
            RAM8GB.TabStop = true;
            RAM8GB.Text = "8 GB";
            RAM8GB.UseVisualStyleBackColor = true;
            RAM8GB.CheckedChanged += RAM8GB_CheckedChanged;
            // 
            // RAM16GB
            // 
            RAM16GB.AutoSize = true;
            RAM16GB.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            RAM16GB.Location = new Point(18, 84);
            RAM16GB.Name = "RAM16GB";
            RAM16GB.Size = new Size(118, 37);
            RAM16GB.TabIndex = 9;
            RAM16GB.TabStop = true;
            RAM16GB.Text = "16 GB";
            RAM16GB.UseVisualStyleBackColor = true;
            RAM16GB.CheckedChanged += RAM16GB_CheckedChanged;
            // 
            // RAM32GB
            // 
            RAM32GB.AutoSize = true;
            RAM32GB.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            RAM32GB.Location = new Point(18, 126);
            RAM32GB.Name = "RAM32GB";
            RAM32GB.Size = new Size(118, 37);
            RAM32GB.TabIndex = 10;
            RAM32GB.TabStop = true;
            RAM32GB.Text = "32 GB";
            RAM32GB.UseVisualStyleBackColor = true;
            RAM32GB.CheckedChanged += RAM32GB_CheckedChanged;
            // 
            // StorageSSD
            // 
            StorageSSD.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            StorageSSD.FormattingEnabled = true;
            StorageSSD.ItemHeight = 33;
            StorageSSD.Items.AddRange(new object[] { "SSD", "HDD" });
            StorageSSD.Location = new Point(43, 48);
            StorageSSD.Name = "StorageSSD";
            StorageSSD.Size = new Size(79, 70);
            StorageSSD.TabIndex = 12;
            StorageSSD.SelectedIndexChanged += StorageSSD_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 13);
            label5.Name = "label5";
            label5.Size = new Size(107, 33);
            label5.TabIndex = 13;
            label5.Text = "Storage";
            // 
            // PickCPU
            // 
            PickCPU.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            PickCPU.FormattingEnabled = true;
            PickCPU.Items.AddRange(new object[] { "AMD Ryzen", "Intel Core" });
            PickCPU.Location = new Point(20, 61);
            PickCPU.Name = "PickCPU";
            PickCPU.Size = new Size(195, 78);
            PickCPU.TabIndex = 14;
            PickCPU.SelectedIndexChanged += PickCPU_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 15);
            label6.Name = "label6";
            label6.Size = new Size(64, 33);
            label6.TabIndex = 15;
            label6.Text = "CPU";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 15);
            label7.Name = "label7";
            label7.Size = new Size(215, 33);
            label7.TabIndex = 16;
            label7.Text = "Number of Fans:";
            // 
            // NumOfFans
            // 
            NumOfFans.Location = new Point(224, 13);
            NumOfFans.Name = "NumOfFans";
            NumOfFans.Size = new Size(133, 39);
            NumOfFans.TabIndex = 17;
            // 
            // RamSize
            // 
            RamSize.Controls.Add(RAM8GB);
            RamSize.Controls.Add(RAM16GB);
            RamSize.Controls.Add(RAM32GB);
            RamSize.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RamSize.Location = new Point(19, 78);
            RamSize.Name = "RamSize";
            RamSize.Size = new Size(154, 185);
            RamSize.TabIndex = 18;
            RamSize.TabStop = false;
            RamSize.Text = "Ram Size";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(GPU20Series);
            groupBox2.Controls.Add(GPU30Series);
            groupBox2.Controls.Add(GPU40Series);
            groupBox2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(183, 175);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Graphics Card";
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Calculate.Location = new Point(42, 915);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(150, 46);
            Calculate.TabIndex = 20;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // Reset
            // 
            Reset.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Reset.Location = new Point(315, 915);
            Reset.Name = "Reset";
            Reset.Size = new Size(150, 46);
            Reset.TabIndex = 21;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(819, 915);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(211, 33);
            linkLabel1.TabIndex = 22;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Price References";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(649, 308);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 571);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // ResultMessage
            // 
            ResultMessage.AutoSize = true;
            ResultMessage.Font = new Font("Tahoma", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            ResultMessage.ForeColor = Color.Black;
            ResultMessage.Location = new Point(42, 980);
            ResultMessage.Name = "ResultMessage";
            ResultMessage.Size = new Size(209, 45);
            ResultMessage.TabIndex = 24;
            ResultMessage.Text = "Result Price";
            ResultMessage.Visible = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(42, 308);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(586, 571);
            tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(570, 517);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "GPU";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(265, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 365);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(NumRamSticks);
            tabPage2.Controls.Add(RamSize);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(570, 517);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "RAM";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(247, 102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(260, 358);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(pictureBox4);
            tabPage3.Controls.Add(PickCPU);
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(570, 517);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "CPU";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(81, 15);
            label9.Name = "label9";
            label9.Size = new Size(145, 33);
            label9.TabIndex = 17;
            label9.Text = "(Choose 1)";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(39, 163);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(350, 272);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(pictureBox5);
            tabPage4.Controls.Add(groupBox3);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(NumOfFans);
            tabPage4.Location = new Point(8, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(570, 517);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Cooling";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(293, 106);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(213, 328);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(LCYes);
            groupBox3.Controls.Add(LCNo);
            groupBox3.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(16, 77);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(215, 169);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Liquid Cooling?";
            // 
            // LCYes
            // 
            LCYes.AutoSize = true;
            LCYes.Location = new Point(12, 48);
            LCYes.Name = "LCYes";
            LCYes.Size = new Size(88, 37);
            LCYes.TabIndex = 18;
            LCYes.TabStop = true;
            LCYes.Text = "Yes";
            LCYes.UseVisualStyleBackColor = true;
            LCYes.CheckedChanged += LCYes_CheckedChanged;
            // 
            // LCNo
            // 
            LCNo.AutoSize = true;
            LCNo.Location = new Point(12, 103);
            LCNo.Name = "LCNo";
            LCNo.Size = new Size(79, 37);
            LCNo.TabIndex = 26;
            LCNo.TabStop = true;
            LCNo.Text = "No";
            LCNo.UseVisualStyleBackColor = true;
            LCNo.CheckedChanged += LCNo_CheckedChanged;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(StorageSize);
            tabPage5.Controls.Add(pictureBox6);
            tabPage5.Controls.Add(label5);
            tabPage5.Controls.Add(StorageSSD);
            tabPage5.Location = new Point(8, 46);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(570, 517);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Storage";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // StorageSize
            // 
            StorageSize.Controls.Add(StorageSize8GB);
            StorageSize.Controls.Add(StorageSize16G);
            StorageSize.Controls.Add(StorageSize32GB);
            StorageSize.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            StorageSize.Location = new Point(27, 155);
            StorageSize.Name = "StorageSize";
            StorageSize.Size = new Size(177, 185);
            StorageSize.TabIndex = 19;
            StorageSize.TabStop = false;
            StorageSize.Text = "Storage Size";
            // 
            // StorageSize8GB
            // 
            StorageSize8GB.AutoSize = true;
            StorageSize8GB.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            StorageSize8GB.Location = new Point(19, 41);
            StorageSize8GB.Name = "StorageSize8GB";
            StorageSize8GB.Size = new Size(133, 37);
            StorageSize8GB.TabIndex = 8;
            StorageSize8GB.TabStop = true;
            StorageSize8GB.Text = "250 GB";
            StorageSize8GB.UseVisualStyleBackColor = true;
            StorageSize8GB.CheckedChanged += StorageSize8GB_CheckedChanged;
            // 
            // StorageSize16G
            // 
            StorageSize16G.AutoSize = true;
            StorageSize16G.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            StorageSize16G.Location = new Point(18, 84);
            StorageSize16G.Name = "StorageSize16G";
            StorageSize16G.Size = new Size(133, 37);
            StorageSize16G.TabIndex = 9;
            StorageSize16G.TabStop = true;
            StorageSize16G.Text = "500 GB";
            StorageSize16G.UseVisualStyleBackColor = true;
            StorageSize16G.CheckedChanged += StorageSize16G_CheckedChanged;
            // 
            // StorageSize32GB
            // 
            StorageSize32GB.AutoSize = true;
            StorageSize32GB.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            StorageSize32GB.Location = new Point(18, 126);
            StorageSize32GB.Name = "StorageSize32GB";
            StorageSize32GB.Size = new Size(101, 37);
            StorageSize32GB.TabIndex = 10;
            StorageSize32GB.TabStop = true;
            StorageSize32GB.Text = "1 TB";
            StorageSize32GB.UseVisualStyleBackColor = true;
            StorageSize32GB.CheckedChanged += StorageSize32GB_CheckedChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(279, 91);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(229, 360);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(groupBox4);
            tabPage6.Controls.Add(label13);
            tabPage6.Controls.Add(label12);
            tabPage6.Controls.Add(label11);
            tabPage6.Controls.Add(pictureBox11);
            tabPage6.Controls.Add(pictureBox10);
            tabPage6.Controls.Add(pictureBox8);
            tabPage6.Controls.Add(comboBoxCaseSize);
            tabPage6.Controls.Add(label10);
            tabPage6.Controls.Add(label2);
            tabPage6.Location = new Point(8, 46);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(570, 517);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Case";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(RandomYes);
            groupBox4.Controls.Add(RandomNo);
            groupBox4.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(27, 119);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(397, 144);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "Want to know Size in inches?";
            // 
            // RandomYes
            // 
            RandomYes.AutoSize = true;
            RandomYes.Location = new Point(12, 48);
            RandomYes.Name = "RandomYes";
            RandomYes.Size = new Size(88, 37);
            RandomYes.TabIndex = 18;
            RandomYes.TabStop = true;
            RandomYes.Text = "Yes";
            RandomYes.UseVisualStyleBackColor = true;
            RandomYes.CheckedChanged += RandomYes_CheckedChanged;
            // 
            // RandomNo
            // 
            RandomNo.AutoSize = true;
            RandomNo.Location = new Point(12, 103);
            RandomNo.Name = "RandomNo";
            RandomNo.Size = new Size(79, 37);
            RandomNo.TabIndex = 26;
            RandomNo.TabStop = true;
            RandomNo.Text = "No";
            RandomNo.UseVisualStyleBackColor = true;
            RandomNo.CheckedChanged += RandomNo_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(367, 284);
            label13.Name = "label13";
            label13.Size = new Size(79, 33);
            label13.TabIndex = 22;
            label13.Text = "Micro";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(218, 284);
            label12.Name = "label12";
            label12.Size = new Size(57, 33);
            label12.TabIndex = 21;
            label12.Text = "Mid";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(55, 284);
            label11.Name = "label11";
            label11.Size = new Size(56, 33);
            label11.TabIndex = 20;
            label11.Text = "Full";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(338, 320);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(132, 178);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 19;
            pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(183, 320);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(132, 178);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 18;
            pictureBox10.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(22, 320);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(132, 178);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 17;
            pictureBox8.TabStop = false;
            // 
            // comboBoxCaseSize
            // 
            comboBoxCaseSize.FormattingEnabled = true;
            comboBoxCaseSize.Items.AddRange(new object[] { "Full", "Mid", "Micro" });
            comboBoxCaseSize.Location = new Point(24, 64);
            comboBoxCaseSize.Name = "comboBoxCaseSize";
            comboBoxCaseSize.Size = new Size(239, 40);
            comboBoxCaseSize.TabIndex = 16;
            comboBoxCaseSize.Text = "---Please Select---";
            comboBoxCaseSize.SelectedIndexChanged += comboBoxCaseSize_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(111, 219);
            label10.Name = "label10";
            label10.Size = new Size(0, 33);
            label10.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 19);
            label2.Name = "label2";
            label2.Size = new Size(71, 33);
            label2.TabIndex = 14;
            label2.Text = "Case";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 25.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(178, 9);
            label4.Name = "label4";
            label4.Size = new Size(745, 83);
            label4.TabIndex = 26;
            label4.Text = "Welcome To PCBuilder!";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(72, 183);
            label8.Name = "label8";
            label8.Size = new Size(109, 33);
            label8.TabIndex = 27;
            label8.Text = "Budget:";
            // 
            // PCBudget
            // 
            PCBudget.Location = new Point(178, 183);
            PCBudget.Name = "PCBudget";
            PCBudget.Size = new Size(200, 39);
            PCBudget.TabIndex = 28;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(111, 21);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(70, 61);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 29;
            pictureBox7.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(906, 21);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(70, 61);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 31;
            pictureBox9.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PurposeGaming);
            groupBox1.Controls.Add(PurposeWork);
            groupBox1.Controls.Add(PurposeHome);
            groupBox1.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(631, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(177, 185);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Purpose";
            // 
            // PurposeGaming
            // 
            PurposeGaming.AutoSize = true;
            PurposeGaming.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            PurposeGaming.Location = new Point(19, 41);
            PurposeGaming.Name = "PurposeGaming";
            PurposeGaming.Size = new Size(137, 37);
            PurposeGaming.TabIndex = 8;
            PurposeGaming.TabStop = true;
            PurposeGaming.Text = "Gaming";
            PurposeGaming.UseVisualStyleBackColor = true;
            PurposeGaming.CheckedChanged += PurposeGaming_CheckedChanged;
            // 
            // PurposeWork
            // 
            PurposeWork.AutoSize = true;
            PurposeWork.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            PurposeWork.Location = new Point(18, 84);
            PurposeWork.Name = "PurposeWork";
            PurposeWork.Size = new Size(108, 37);
            PurposeWork.TabIndex = 9;
            PurposeWork.TabStop = true;
            PurposeWork.Text = "Work";
            PurposeWork.UseVisualStyleBackColor = true;
            PurposeWork.CheckedChanged += PurposeWork_CheckedChanged;
            // 
            // PurposeHome
            // 
            PurposeHome.AutoSize = true;
            PurposeHome.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            PurposeHome.Location = new Point(18, 126);
            PurposeHome.Name = "PurposeHome";
            PurposeHome.Size = new Size(116, 37);
            PurposeHome.TabIndex = 10;
            PurposeHome.TabStop = true;
            PurposeHome.Text = "Home";
            PurposeHome.UseVisualStyleBackColor = true;
            PurposeHome.CheckedChanged += PurposeHome_CheckedChanged;
            // 
            // Email
            // 
            Email.Location = new Point(178, 245);
            Email.Name = "Email";
            Email.Size = new Size(200, 39);
            Email.TabIndex = 35;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(82, 247);
            label14.Name = "label14";
            label14.Size = new Size(89, 33);
            label14.TabIndex = 34;
            label14.Text = "Email:";
            // 
            // IsWithinBudget
            // 
            IsWithinBudget.AutoSize = true;
            IsWithinBudget.Location = new Point(398, 184);
            IsWithinBudget.Name = "IsWithinBudget";
            IsWithinBudget.Size = new Size(0, 32);
            IsWithinBudget.TabIndex = 36;
            // 
            // WithinBudget
            // 
            WithinBudget.AutoSize = true;
            WithinBudget.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            WithinBudget.Location = new Point(384, 185);
            WithinBudget.Name = "WithinBudget";
            WithinBudget.Size = new Size(0, 33);
            WithinBudget.TabIndex = 37;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1253, 1287);
            Controls.Add(WithinBudget);
            Controls.Add(IsWithinBudget);
            Controls.Add(Email);
            Controls.Add(label14);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox7);
            Controls.Add(PCBudget);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(tabControl1);
            Controls.Add(ResultMessage);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(Reset);
            Controls.Add(Calculate);
            Controls.Add(label1);
            Controls.Add(Name);
//            Name = "Form1";
            Text = "PCBuilder";
            RamSize.ResumeLayout(false);
            RamSize.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            StorageSize.ResumeLayout(false);
            StorageSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Name;
        private Label label1;
        private RadioButton GPU20Series;
        private RadioButton GPU30Series;
        private RadioButton GPU40Series;
        private Label label3;
        private TextBox NumRamSticks;
        private RadioButton RAM8GB;
        private RadioButton RAM16GB;
        private RadioButton RAM32GB;
        private ListBox StorageSSD;
        private Label label5;
        private CheckedListBox PickCPU;
        private Label label6;
        private Label label7;
        private TextBox NumOfFans;
        private GroupBox RamSize;
        private GroupBox groupBox2;
        private Button Calculate;
        private Button Reset;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label ResultMessage;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox groupBox3;
        private RadioButton LCYes;
        private RadioButton LCNo;
        private TabPage tabPage5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private GroupBox StorageSize;
        private RadioButton StorageSize8GB;
        private RadioButton StorageSize16G;
        private RadioButton StorageSize32GB;
        private Label label4;
        private Label label8;
        private TextBox PCBudget;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private Label label9;
        private TabPage tabPage6;
        private Label label13;
        private Label label12;
        private Label label11;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox8;
        private ComboBox comboBoxCaseSize;
        private Label label10;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton PurposeGaming;
        private RadioButton PurposeWork;
        private RadioButton PurposeHome;
        private TextBox Email;
        private Label label14;
        private GroupBox groupBox4;
        private RadioButton RandomYes;
        private RadioButton RandomNo;
        private Label IsWithinBudget;
        private Label WithinBudget;
    }
}