﻿namespace Image_Outliner
{
	partial class ImageOutlinerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outlineImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageLocationTextbox = new System.Windows.Forms.TextBox();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.imageLocationLabel = new System.Windows.Forms.Label();
            this.outlineButton = new System.Windows.Forms.Button();
            this.imageControlGroup = new System.Windows.Forms.GroupBox();
            this.lightColorLabel = new System.Windows.Forms.Label();
            this.lightColorTextBox = new System.Windows.Forms.TextBox();
            this.darkColorLabel = new System.Windows.Forms.Label();
            this.darkColorTextBox = new System.Windows.Forms.TextBox();
            this.lightColorButton = new System.Windows.Forms.Button();
            this.darkColorButton = new System.Windows.Forms.Button();
            this.outlineColorLabel = new System.Windows.Forms.Label();
            this.outlineColorTextBox = new System.Windows.Forms.TextBox();
            this.outlineColorButton = new System.Windows.Forms.Button();
            this.imageProperties1 = new System.Windows.Forms.GroupBox();
            this.editingMethodTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBarOutlineLabel = new System.Windows.Forms.Label();
            this.baseColorButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.baseColorLabel = new System.Windows.Forms.Label();
            this.trackBarDarkLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.trackBarLightLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.outlineTrackBarColorButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.imageControlGroup.SuspendLayout();
            this.imageProperties1.SuspendLayout();
            this.editingMethodTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image...";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image...";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outlineImageToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // outlineImageToolStripMenuItem
            // 
            this.outlineImageToolStripMenuItem.Name = "outlineImageToolStripMenuItem";
            this.outlineImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.outlineImageToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.outlineImageToolStripMenuItem.Text = "Outline Image...";
            this.outlineImageToolStripMenuItem.Click += new System.EventHandler(this.outlineImageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(3, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(823, 421);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imageLocationTextbox
            // 
            this.imageLocationTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageLocationTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.imageLocationTextbox.Location = new System.Drawing.Point(97, 11);
            this.imageLocationTextbox.Name = "imageLocationTextbox";
            this.imageLocationTextbox.Size = new System.Drawing.Size(613, 20);
            this.imageLocationTextbox.TabIndex = 3;
            this.imageLocationTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.imageLocationTextbox_KeyDown);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadImageButton.Location = new System.Drawing.Point(716, 11);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(31, 21);
            this.loadImageButton.TabIndex = 5;
            this.loadImageButton.Text = ". . .";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // imageLocationLabel
            // 
            this.imageLocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imageLocationLabel.AutoSize = true;
            this.imageLocationLabel.Location = new System.Drawing.Point(8, 13);
            this.imageLocationLabel.Name = "imageLocationLabel";
            this.imageLocationLabel.Size = new System.Drawing.Size(83, 13);
            this.imageLocationLabel.TabIndex = 6;
            this.imageLocationLabel.Text = "Image Location:";
            // 
            // outlineButton
            // 
            this.outlineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outlineButton.BackColor = System.Drawing.Color.Green;
            this.outlineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outlineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outlineButton.ForeColor = System.Drawing.Color.White;
            this.outlineButton.Location = new System.Drawing.Point(753, 11);
            this.outlineButton.Name = "outlineButton";
            this.outlineButton.Size = new System.Drawing.Size(70, 20);
            this.outlineButton.TabIndex = 7;
            this.outlineButton.Text = "Outline!";
            this.outlineButton.UseVisualStyleBackColor = false;
            this.outlineButton.Click += new System.EventHandler(this.outlineButton_Click);
            // 
            // imageControlGroup
            // 
            this.imageControlGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageControlGroup.Controls.Add(this.imageLocationTextbox);
            this.imageControlGroup.Controls.Add(this.loadImageButton);
            this.imageControlGroup.Controls.Add(this.outlineButton);
            this.imageControlGroup.Controls.Add(this.imageLocationLabel);
            this.imageControlGroup.Location = new System.Drawing.Point(0, 540);
            this.imageControlGroup.Name = "imageControlGroup";
            this.imageControlGroup.Size = new System.Drawing.Size(830, 37);
            this.imageControlGroup.TabIndex = 8;
            this.imageControlGroup.TabStop = false;
            // 
            // lightColorLabel
            // 
            this.lightColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lightColorLabel.AutoSize = true;
            this.lightColorLabel.Location = new System.Drawing.Point(96, 22);
            this.lightColorLabel.Name = "lightColorLabel";
            this.lightColorLabel.Size = new System.Drawing.Size(60, 13);
            this.lightColorLabel.TabIndex = 2;
            this.lightColorLabel.Text = "Light Color:";
            // 
            // lightColorTextBox
            // 
            this.lightColorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lightColorTextBox.Location = new System.Drawing.Point(156, 19);
            this.lightColorTextBox.Name = "lightColorTextBox";
            this.lightColorTextBox.ReadOnly = true;
            this.lightColorTextBox.Size = new System.Drawing.Size(136, 20);
            this.lightColorTextBox.TabIndex = 3;
            // 
            // darkColorLabel
            // 
            this.darkColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.darkColorLabel.AutoSize = true;
            this.darkColorLabel.Location = new System.Drawing.Point(305, 22);
            this.darkColorLabel.Name = "darkColorLabel";
            this.darkColorLabel.Size = new System.Drawing.Size(60, 13);
            this.darkColorLabel.TabIndex = 4;
            this.darkColorLabel.Text = "Dark Color:";
            // 
            // darkColorTextBox
            // 
            this.darkColorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.darkColorTextBox.Location = new System.Drawing.Point(370, 19);
            this.darkColorTextBox.Name = "darkColorTextBox";
            this.darkColorTextBox.ReadOnly = true;
            this.darkColorTextBox.Size = new System.Drawing.Size(135, 20);
            this.darkColorTextBox.TabIndex = 5;
            // 
            // lightColorButton
            // 
            this.lightColorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lightColorButton.Location = new System.Drawing.Point(175, 42);
            this.lightColorButton.Name = "lightColorButton";
            this.lightColorButton.Size = new System.Drawing.Size(100, 24);
            this.lightColorButton.TabIndex = 7;
            this.lightColorButton.Text = "Pick Light Color";
            this.lightColorButton.UseVisualStyleBackColor = true;
            this.lightColorButton.Click += new System.EventHandler(this.lightColorButton_Click);
            // 
            // darkColorButton
            // 
            this.darkColorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.darkColorButton.Location = new System.Drawing.Point(390, 42);
            this.darkColorButton.Name = "darkColorButton";
            this.darkColorButton.Size = new System.Drawing.Size(100, 24);
            this.darkColorButton.TabIndex = 8;
            this.darkColorButton.Text = "Pick Dark Color";
            this.darkColorButton.UseVisualStyleBackColor = true;
            this.darkColorButton.Click += new System.EventHandler(this.darkColorButton_Click);
            // 
            // outlineColorLabel
            // 
            this.outlineColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outlineColorLabel.AutoSize = true;
            this.outlineColorLabel.Location = new System.Drawing.Point(515, 22);
            this.outlineColorLabel.Name = "outlineColorLabel";
            this.outlineColorLabel.Size = new System.Drawing.Size(70, 13);
            this.outlineColorLabel.TabIndex = 9;
            this.outlineColorLabel.Text = "Outline Color:";
            // 
            // outlineColorTextBox
            // 
            this.outlineColorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outlineColorTextBox.Location = new System.Drawing.Point(591, 19);
            this.outlineColorTextBox.Name = "outlineColorTextBox";
            this.outlineColorTextBox.ReadOnly = true;
            this.outlineColorTextBox.Size = new System.Drawing.Size(135, 20);
            this.outlineColorTextBox.TabIndex = 10;
            // 
            // outlineColorButton
            // 
            this.outlineColorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outlineColorButton.Location = new System.Drawing.Point(610, 42);
            this.outlineColorButton.Name = "outlineColorButton";
            this.outlineColorButton.Size = new System.Drawing.Size(100, 24);
            this.outlineColorButton.TabIndex = 11;
            this.outlineColorButton.Text = "Pick Outline Color";
            this.outlineColorButton.UseVisualStyleBackColor = true;
            this.outlineColorButton.Click += new System.EventHandler(this.outlineColorButton_Click);
            // 
            // imageProperties1
            // 
            this.imageProperties1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageProperties1.Controls.Add(this.outlineColorButton);
            this.imageProperties1.Controls.Add(this.outlineColorTextBox);
            this.imageProperties1.Controls.Add(this.outlineColorLabel);
            this.imageProperties1.Controls.Add(this.darkColorButton);
            this.imageProperties1.Controls.Add(this.lightColorButton);
            this.imageProperties1.Controls.Add(this.darkColorTextBox);
            this.imageProperties1.Controls.Add(this.darkColorLabel);
            this.imageProperties1.Controls.Add(this.lightColorTextBox);
            this.imageProperties1.Controls.Add(this.lightColorLabel);
            this.imageProperties1.Location = new System.Drawing.Point(3, 3);
            this.imageProperties1.Name = "imageProperties1";
            this.imageProperties1.Size = new System.Drawing.Size(816, 73);
            this.imageProperties1.TabIndex = 2;
            this.imageProperties1.TabStop = false;
            this.imageProperties1.Text = "Outline Image Properties";
            // 
            // editingMethodTabs
            // 
            this.editingMethodTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editingMethodTabs.Controls.Add(this.tabPage1);
            this.editingMethodTabs.Controls.Add(this.tabPage2);
            this.editingMethodTabs.Location = new System.Drawing.Point(0, 27);
            this.editingMethodTabs.Name = "editingMethodTabs";
            this.editingMethodTabs.SelectedIndex = 0;
            this.editingMethodTabs.Size = new System.Drawing.Size(830, 518);
            this.editingMethodTabs.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.imageProperties1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.outlineTrackBarColorButton);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.trackBarLightLabel);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.trackBar3);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.trackBarOutlineLabel);
            this.groupBox1.Controls.Add(this.baseColorButton);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.baseColorLabel);
            this.groupBox1.Controls.Add(this.trackBarDarkLabel);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outline Image Properties";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(491, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(44, 20);
            this.textBox1.TabIndex = 10;
            // 
            // trackBarOutlineLabel
            // 
            this.trackBarOutlineLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBarOutlineLabel.AutoSize = true;
            this.trackBarOutlineLabel.Location = new System.Drawing.Point(717, 21);
            this.trackBarOutlineLabel.Name = "trackBarOutlineLabel";
            this.trackBarOutlineLabel.Size = new System.Drawing.Size(70, 13);
            this.trackBarOutlineLabel.TabIndex = 9;
            this.trackBarOutlineLabel.Text = "Outline Color:";
            // 
            // baseColorButton
            // 
            this.baseColorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baseColorButton.Location = new System.Drawing.Point(264, 68);
            this.baseColorButton.Name = "baseColorButton";
            this.baseColorButton.Size = new System.Drawing.Size(105, 24);
            this.baseColorButton.TabIndex = 8;
            this.baseColorButton.Text = "Pick Base Color";
            this.baseColorButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(260, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 5;
            // 
            // baseColorLabel
            // 
            this.baseColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baseColorLabel.AutoSize = true;
            this.baseColorLabel.Location = new System.Drawing.Point(285, 21);
            this.baseColorLabel.Name = "baseColorLabel";
            this.baseColorLabel.Size = new System.Drawing.Size(61, 13);
            this.baseColorLabel.TabIndex = 4;
            this.baseColorLabel.Text = "Base Color:";
            // 
            // trackBarDarkLabel
            // 
            this.trackBarDarkLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBarDarkLabel.AutoSize = true;
            this.trackBarDarkLabel.Location = new System.Drawing.Point(24, 21);
            this.trackBarDarkLabel.Name = "trackBarDarkLabel";
            this.trackBarDarkLabel.Size = new System.Drawing.Size(60, 13);
            this.trackBarDarkLabel.TabIndex = 2;
            this.trackBarDarkLabel.Text = "Dark Color:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(3, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(823, 387);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBar1.BackColor = System.Drawing.SystemColors.Window;
            this.trackBar1.Enabled = false;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(128, 38);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(126, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar3
            // 
            this.trackBar3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBar3.BackColor = System.Drawing.SystemColors.Window;
            this.trackBar3.Enabled = false;
            this.trackBar3.LargeChange = 10;
            this.trackBar3.Location = new System.Drawing.Point(382, 38);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(126, 45);
            this.trackBar3.SmallChange = 5;
            this.trackBar3.TabIndex = 5;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.Location = new System.Drawing.Point(6, 42);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(116, 20);
            this.textBox4.TabIndex = 14;
            // 
            // trackBarLightLabel
            // 
            this.trackBarLightLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBarLightLabel.AutoSize = true;
            this.trackBarLightLabel.Location = new System.Drawing.Point(544, 21);
            this.trackBarLightLabel.Name = "trackBarLightLabel";
            this.trackBarLightLabel.Size = new System.Drawing.Size(60, 13);
            this.trackBarLightLabel.TabIndex = 15;
            this.trackBarLightLabel.Text = "Light Color:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Location = new System.Drawing.Point(514, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox5.Location = new System.Drawing.Point(694, 42);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(116, 20);
            this.textBox5.TabIndex = 17;
            // 
            // outlineTrackBarColorButton
            // 
            this.outlineTrackBarColorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outlineTrackBarColorButton.Location = new System.Drawing.Point(699, 68);
            this.outlineTrackBarColorButton.Name = "outlineTrackBarColorButton";
            this.outlineTrackBarColorButton.Size = new System.Drawing.Size(105, 24);
            this.outlineTrackBarColorButton.TabIndex = 18;
            this.outlineTrackBarColorButton.Text = "Pick Outline Color";
            this.outlineTrackBarColorButton.UseVisualStyleBackColor = true;
            // 
            // ImageOutlinerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 577);
            this.Controls.Add(this.editingMethodTabs);
            this.Controls.Add(this.imageControlGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(675, 615);
            this.Name = "ImageOutlinerForm";
            this.Text = "Image Outliner";
            this.Load += new System.EventHandler(this.ImageOutlinerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.imageControlGroup.ResumeLayout(false);
            this.imageControlGroup.PerformLayout();
            this.imageProperties1.ResumeLayout(false);
            this.imageProperties1.PerformLayout();
            this.editingMethodTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem outlineImageToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox imageLocationTextbox;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Label imageLocationLabel;
        private System.Windows.Forms.Button outlineButton;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.GroupBox imageControlGroup;
		private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
		private System.Windows.Forms.Label lightColorLabel;
		private System.Windows.Forms.TextBox lightColorTextBox;
		private System.Windows.Forms.Label darkColorLabel;
		private System.Windows.Forms.TextBox darkColorTextBox;
		private System.Windows.Forms.Button lightColorButton;
		private System.Windows.Forms.Button darkColorButton;
		private System.Windows.Forms.Label outlineColorLabel;
		private System.Windows.Forms.TextBox outlineColorTextBox;
		private System.Windows.Forms.Button outlineColorButton;
		private System.Windows.Forms.GroupBox imageProperties1;
		private System.Windows.Forms.TabControl editingMethodTabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label trackBarOutlineLabel;
        private System.Windows.Forms.Button baseColorButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label baseColorLabel;
        private System.Windows.Forms.Label trackBarDarkLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label trackBarLightLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button outlineTrackBarColorButton;
	}
}

