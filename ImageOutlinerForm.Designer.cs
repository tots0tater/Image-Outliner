namespace Image_Outliner
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outlineImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageLocationTextbox = new System.Windows.Forms.TextBox();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.imageLocationLabel = new System.Windows.Forms.Label();
            this.outlineButton = new System.Windows.Forms.Button();
            this.imageControlGroup = new System.Windows.Forms.GroupBox();
            this.transparentCheckBox = new System.Windows.Forms.CheckBox();
            this.darkColorLabel = new System.Windows.Forms.Label();
            this.darkColorTextBox = new System.Windows.Forms.TextBox();
            this.darkColorButton = new System.Windows.Forms.Button();
            this.outlineColorLabel = new System.Windows.Forms.Label();
            this.outlineColorTextBox = new System.Windows.Forms.TextBox();
            this.outlineColorButton = new System.Windows.Forms.Button();
            this.imageProperties1 = new System.Windows.Forms.GroupBox();
            this.lightDropper = new System.Windows.Forms.Button();
            this.darkDropper = new System.Windows.Forms.Button();
            this.backgroundButton = new System.Windows.Forms.Button();
            this.backgroundTextBox = new System.Windows.Forms.TextBox();
            this.backgroundColorLabel = new System.Windows.Forms.Label();
            this.lightColorButton = new System.Windows.Forms.Button();
            this.lightColorTextBox = new System.Windows.Forms.TextBox();
            this.lightColorLabel = new System.Windows.Forms.Label();
            this.editingMethodTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baseDropper = new System.Windows.Forms.Button();
            this.backgroundButton2 = new System.Windows.Forms.Button();
            this.backgroundTextBox2 = new System.Windows.Forms.TextBox();
            this.backgroundLabel2 = new System.Windows.Forms.Label();
            this.outlineColorButton2 = new System.Windows.Forms.Button();
            this.outlineColorTextBox2 = new System.Windows.Forms.TextBox();
            this.lightColorTextBox2 = new System.Windows.Forms.TextBox();
            this.trackBarLightLabel = new System.Windows.Forms.Label();
            this.darkColorTextBox2 = new System.Windows.Forms.TextBox();
            this.rightTrackBar = new System.Windows.Forms.TrackBar();
            this.leftTrackBar = new System.Windows.Forms.TrackBar();
            this.trackBarOutlineLabel = new System.Windows.Forms.Label();
            this.baseColorButton = new System.Windows.Forms.Button();
            this.baseColorTextBox = new System.Windows.Forms.TextBox();
            this.baseColorLabel = new System.Windows.Forms.Label();
            this.trackBarDarkLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transparentToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.imageControlGroup.SuspendLayout();
            this.imageProperties1.SuspendLayout();
            this.editingMethodTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
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
            this.saveImageToolStripMenuItem.Enabled = false;
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
            // imageLocationTextbox
            // 
            this.imageLocationTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageLocationTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.imageLocationTextbox.Location = new System.Drawing.Point(97, 11);
            this.imageLocationTextbox.Name = "imageLocationTextbox";
            this.imageLocationTextbox.Size = new System.Drawing.Size(706, 20);
            this.imageLocationTextbox.TabIndex = 3;
            this.imageLocationTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.imageLocationTextbox_KeyDown);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadImageButton.Location = new System.Drawing.Point(809, 11);
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
            this.outlineButton.Location = new System.Drawing.Point(932, 11);
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
            this.imageControlGroup.Controls.Add(this.transparentCheckBox);
            this.imageControlGroup.Controls.Add(this.imageLocationTextbox);
            this.imageControlGroup.Controls.Add(this.loadImageButton);
            this.imageControlGroup.Controls.Add(this.outlineButton);
            this.imageControlGroup.Controls.Add(this.imageLocationLabel);
            this.imageControlGroup.Location = new System.Drawing.Point(0, 675);
            this.imageControlGroup.Name = "imageControlGroup";
            this.imageControlGroup.Size = new System.Drawing.Size(1009, 37);
            this.imageControlGroup.TabIndex = 8;
            this.imageControlGroup.TabStop = false;
            // 
            // transparentCheckBox
            // 
            this.transparentCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.transparentCheckBox.AutoSize = true;
            this.transparentCheckBox.Location = new System.Drawing.Point(846, 13);
            this.transparentCheckBox.Name = "transparentCheckBox";
            this.transparentCheckBox.Size = new System.Drawing.Size(83, 17);
            this.transparentCheckBox.TabIndex = 19;
            this.transparentCheckBox.Text = "Transparent";
            this.transparentToolTip.SetToolTip(this.transparentCheckBox, "Check this box if you want your image to be transparent.\r\n        WARNING: Only ." +
        "png files support this mode.");
            this.transparentCheckBox.UseVisualStyleBackColor = true;
            // 
            // darkColorLabel
            // 
            this.darkColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.darkColorLabel.AutoSize = true;
            this.darkColorLabel.Location = new System.Drawing.Point(302, 34);
            this.darkColorLabel.Name = "darkColorLabel";
            this.darkColorLabel.Size = new System.Drawing.Size(60, 13);
            this.darkColorLabel.TabIndex = 4;
            this.darkColorLabel.Text = "Dark Color:";
            // 
            // darkColorTextBox
            // 
            this.darkColorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.darkColorTextBox.Location = new System.Drawing.Point(367, 31);
            this.darkColorTextBox.Name = "darkColorTextBox";
            this.darkColorTextBox.ReadOnly = true;
            this.darkColorTextBox.Size = new System.Drawing.Size(115, 20);
            this.darkColorTextBox.TabIndex = 5;
            // 
            // darkColorButton
            // 
            this.darkColorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.darkColorButton.Location = new System.Drawing.Point(367, 53);
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
            this.outlineColorLabel.Location = new System.Drawing.Point(730, 34);
            this.outlineColorLabel.Name = "outlineColorLabel";
            this.outlineColorLabel.Size = new System.Drawing.Size(70, 13);
            this.outlineColorLabel.TabIndex = 9;
            this.outlineColorLabel.Text = "Outline Color:";
            // 
            // outlineColorTextBox
            // 
            this.outlineColorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outlineColorTextBox.Location = new System.Drawing.Point(806, 31);
            this.outlineColorTextBox.Name = "outlineColorTextBox";
            this.outlineColorTextBox.ReadOnly = true;
            this.outlineColorTextBox.Size = new System.Drawing.Size(115, 20);
            this.outlineColorTextBox.TabIndex = 10;
            // 
            // outlineColorButton
            // 
            this.outlineColorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outlineColorButton.Location = new System.Drawing.Point(813, 53);
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
            this.imageProperties1.Controls.Add(this.lightDropper);
            this.imageProperties1.Controls.Add(this.darkDropper);
            this.imageProperties1.Controls.Add(this.backgroundButton);
            this.imageProperties1.Controls.Add(this.backgroundTextBox);
            this.imageProperties1.Controls.Add(this.backgroundColorLabel);
            this.imageProperties1.Controls.Add(this.lightColorButton);
            this.imageProperties1.Controls.Add(this.lightColorTextBox);
            this.imageProperties1.Controls.Add(this.lightColorLabel);
            this.imageProperties1.Controls.Add(this.outlineColorButton);
            this.imageProperties1.Controls.Add(this.outlineColorTextBox);
            this.imageProperties1.Controls.Add(this.outlineColorLabel);
            this.imageProperties1.Controls.Add(this.darkColorButton);
            this.imageProperties1.Controls.Add(this.darkColorTextBox);
            this.imageProperties1.Controls.Add(this.darkColorLabel);
            this.imageProperties1.Location = new System.Drawing.Point(3, 3);
            this.imageProperties1.Name = "imageProperties1";
            this.imageProperties1.Size = new System.Drawing.Size(995, 100);
            this.imageProperties1.TabIndex = 2;
            this.imageProperties1.TabStop = false;
            this.imageProperties1.Text = "Outline Image Properties";
            // 
            // lightDropper
            // 
            this.lightDropper.Location = new System.Drawing.Point(675, 53);
            this.lightDropper.Name = "lightDropper";
            this.lightDropper.Size = new System.Drawing.Size(18, 24);
            this.lightDropper.TabIndex = 24;
            this.lightDropper.Text = "t";
            this.lightDropper.UseVisualStyleBackColor = true;
            this.lightDropper.Click += new System.EventHandler(this.lightDropper_Click);
            // 
            // darkDropper
            // 
            this.darkDropper.Location = new System.Drawing.Point(463, 53);
            this.darkDropper.Name = "darkDropper";
            this.darkDropper.Size = new System.Drawing.Size(18, 24);
            this.darkDropper.TabIndex = 23;
            this.darkDropper.Text = "t";
            this.darkDropper.UseVisualStyleBackColor = true;
            this.darkDropper.Click += new System.EventHandler(this.darkDropper_Click);
            // 
            // backgroundButton
            // 
            this.backgroundButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backgroundButton.Location = new System.Drawing.Point(155, 53);
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(100, 24);
            this.backgroundButton.TabIndex = 17;
            this.backgroundButton.Text = "Pick BG Color";
            this.backgroundButton.UseVisualStyleBackColor = true;
            this.backgroundButton.Click += new System.EventHandler(this.backgroundButton_Click);
            // 
            // backgroundTextBox
            // 
            this.backgroundTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backgroundTextBox.Location = new System.Drawing.Point(149, 31);
            this.backgroundTextBox.Name = "backgroundTextBox";
            this.backgroundTextBox.ReadOnly = true;
            this.backgroundTextBox.Size = new System.Drawing.Size(115, 20);
            this.backgroundTextBox.TabIndex = 16;
            // 
            // backgroundColorLabel
            // 
            this.backgroundColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backgroundColorLabel.AutoSize = true;
            this.backgroundColorLabel.Location = new System.Drawing.Point(48, 34);
            this.backgroundColorLabel.Name = "backgroundColorLabel";
            this.backgroundColorLabel.Size = new System.Drawing.Size(95, 13);
            this.backgroundColorLabel.TabIndex = 15;
            this.backgroundColorLabel.Text = "Background Color:";
            // 
            // lightColorButton
            // 
            this.lightColorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lightColorButton.Location = new System.Drawing.Point(580, 53);
            this.lightColorButton.Name = "lightColorButton";
            this.lightColorButton.Size = new System.Drawing.Size(100, 24);
            this.lightColorButton.TabIndex = 14;
            this.lightColorButton.Text = "Pick Light Color";
            this.lightColorButton.UseVisualStyleBackColor = true;
            this.lightColorButton.Click += new System.EventHandler(this.lightColorButton_Click);
            // 
            // lightColorTextBox
            // 
            this.lightColorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lightColorTextBox.Location = new System.Drawing.Point(579, 31);
            this.lightColorTextBox.Name = "lightColorTextBox";
            this.lightColorTextBox.ReadOnly = true;
            this.lightColorTextBox.Size = new System.Drawing.Size(115, 20);
            this.lightColorTextBox.TabIndex = 13;
            // 
            // lightColorLabel
            // 
            this.lightColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lightColorLabel.AutoSize = true;
            this.lightColorLabel.Location = new System.Drawing.Point(519, 34);
            this.lightColorLabel.Name = "lightColorLabel";
            this.lightColorLabel.Size = new System.Drawing.Size(60, 13);
            this.lightColorLabel.TabIndex = 12;
            this.lightColorLabel.Text = "Light Color:";
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
            this.editingMethodTabs.Size = new System.Drawing.Size(1009, 137);
            this.editingMethodTabs.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.imageProperties1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1001, 111);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1001, 111);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.baseDropper);
            this.groupBox1.Controls.Add(this.backgroundButton2);
            this.groupBox1.Controls.Add(this.backgroundTextBox2);
            this.groupBox1.Controls.Add(this.backgroundLabel2);
            this.groupBox1.Controls.Add(this.outlineColorButton2);
            this.groupBox1.Controls.Add(this.outlineColorTextBox2);
            this.groupBox1.Controls.Add(this.lightColorTextBox2);
            this.groupBox1.Controls.Add(this.trackBarLightLabel);
            this.groupBox1.Controls.Add(this.darkColorTextBox2);
            this.groupBox1.Controls.Add(this.rightTrackBar);
            this.groupBox1.Controls.Add(this.leftTrackBar);
            this.groupBox1.Controls.Add(this.trackBarOutlineLabel);
            this.groupBox1.Controls.Add(this.baseColorButton);
            this.groupBox1.Controls.Add(this.baseColorTextBox);
            this.groupBox1.Controls.Add(this.baseColorLabel);
            this.groupBox1.Controls.Add(this.trackBarDarkLabel);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outline Image Properties";
            // 
            // baseDropper
            // 
            this.baseDropper.Location = new System.Drawing.Point(537, 62);
            this.baseDropper.Name = "baseDropper";
            this.baseDropper.Size = new System.Drawing.Size(18, 24);
            this.baseDropper.TabIndex = 23;
            this.baseDropper.Text = "t";
            this.baseDropper.UseVisualStyleBackColor = true;
            this.baseDropper.Click += new System.EventHandler(this.baseDropper_Click);
            // 
            // backgroundButton2
            // 
            this.backgroundButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backgroundButton2.Location = new System.Drawing.Point(5, 62);
            this.backgroundButton2.Name = "backgroundButton2";
            this.backgroundButton2.Size = new System.Drawing.Size(105, 24);
            this.backgroundButton2.TabIndex = 21;
            this.backgroundButton2.Text = "Pick BG Color";
            this.backgroundButton2.UseVisualStyleBackColor = true;
            this.backgroundButton2.Click += new System.EventHandler(this.backgroundButton2_Click);
            // 
            // backgroundTextBox2
            // 
            this.backgroundTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backgroundTextBox2.Location = new System.Drawing.Point(6, 36);
            this.backgroundTextBox2.Name = "backgroundTextBox2";
            this.backgroundTextBox2.ReadOnly = true;
            this.backgroundTextBox2.Size = new System.Drawing.Size(115, 20);
            this.backgroundTextBox2.TabIndex = 20;
            // 
            // backgroundLabel2
            // 
            this.backgroundLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backgroundLabel2.AutoSize = true;
            this.backgroundLabel2.Location = new System.Drawing.Point(16, 20);
            this.backgroundLabel2.Name = "backgroundLabel2";
            this.backgroundLabel2.Size = new System.Drawing.Size(95, 13);
            this.backgroundLabel2.TabIndex = 19;
            this.backgroundLabel2.Text = "Background Color:";
            // 
            // outlineColorButton2
            // 
            this.outlineColorButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outlineColorButton2.Location = new System.Drawing.Point(873, 62);
            this.outlineColorButton2.Name = "outlineColorButton2";
            this.outlineColorButton2.Size = new System.Drawing.Size(105, 24);
            this.outlineColorButton2.TabIndex = 18;
            this.outlineColorButton2.Text = "Pick Outline Color";
            this.outlineColorButton2.UseVisualStyleBackColor = true;
            this.outlineColorButton2.Click += new System.EventHandler(this.outlineColorButton2_Click);
            // 
            // outlineColorTextBox2
            // 
            this.outlineColorTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outlineColorTextBox2.Location = new System.Drawing.Point(873, 36);
            this.outlineColorTextBox2.Name = "outlineColorTextBox2";
            this.outlineColorTextBox2.ReadOnly = true;
            this.outlineColorTextBox2.Size = new System.Drawing.Size(115, 20);
            this.outlineColorTextBox2.TabIndex = 17;
            // 
            // lightColorTextBox2
            // 
            this.lightColorTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lightColorTextBox2.Location = new System.Drawing.Point(693, 36);
            this.lightColorTextBox2.Name = "lightColorTextBox2";
            this.lightColorTextBox2.ReadOnly = true;
            this.lightColorTextBox2.Size = new System.Drawing.Size(115, 20);
            this.lightColorTextBox2.TabIndex = 16;
            // 
            // trackBarLightLabel
            // 
            this.trackBarLightLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBarLightLabel.AutoSize = true;
            this.trackBarLightLabel.Location = new System.Drawing.Point(722, 22);
            this.trackBarLightLabel.Name = "trackBarLightLabel";
            this.trackBarLightLabel.Size = new System.Drawing.Size(60, 13);
            this.trackBarLightLabel.TabIndex = 15;
            this.trackBarLightLabel.Text = "Light Color:";
            // 
            // darkColorTextBox2
            // 
            this.darkColorTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.darkColorTextBox2.Location = new System.Drawing.Point(185, 36);
            this.darkColorTextBox2.Name = "darkColorTextBox2";
            this.darkColorTextBox2.ReadOnly = true;
            this.darkColorTextBox2.Size = new System.Drawing.Size(115, 20);
            this.darkColorTextBox2.TabIndex = 14;
            // 
            // rightTrackBar
            // 
            this.rightTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rightTrackBar.BackColor = System.Drawing.SystemColors.Window;
            this.rightTrackBar.Enabled = false;
            this.rightTrackBar.LargeChange = 10;
            this.rightTrackBar.Location = new System.Drawing.Point(561, 32);
            this.rightTrackBar.Maximum = 200;
            this.rightTrackBar.Name = "rightTrackBar";
            this.rightTrackBar.Size = new System.Drawing.Size(126, 45);
            this.rightTrackBar.SmallChange = 5;
            this.rightTrackBar.TabIndex = 5;
            this.rightTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rightTrackBar.Scroll += new System.EventHandler(this.rightTrackBar_Scroll_1);
            // 
            // leftTrackBar
            // 
            this.leftTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leftTrackBar.BackColor = System.Drawing.SystemColors.Window;
            this.leftTrackBar.Enabled = false;
            this.leftTrackBar.LargeChange = 10;
            this.leftTrackBar.Location = new System.Drawing.Point(307, 32);
            this.leftTrackBar.Maximum = 200;
            this.leftTrackBar.Name = "leftTrackBar";
            this.leftTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.leftTrackBar.Size = new System.Drawing.Size(126, 45);
            this.leftTrackBar.SmallChange = 5;
            this.leftTrackBar.TabIndex = 5;
            this.leftTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.leftTrackBar.Scroll += new System.EventHandler(this.leftTrackBar_Scroll_1);
            // 
            // trackBarOutlineLabel
            // 
            this.trackBarOutlineLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBarOutlineLabel.AutoSize = true;
            this.trackBarOutlineLabel.Location = new System.Drawing.Point(897, 22);
            this.trackBarOutlineLabel.Name = "trackBarOutlineLabel";
            this.trackBarOutlineLabel.Size = new System.Drawing.Size(70, 13);
            this.trackBarOutlineLabel.TabIndex = 9;
            this.trackBarOutlineLabel.Text = "Outline Color:";
            // 
            // baseColorButton
            // 
            this.baseColorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baseColorButton.Location = new System.Drawing.Point(439, 62);
            this.baseColorButton.Name = "baseColorButton";
            this.baseColorButton.Size = new System.Drawing.Size(105, 24);
            this.baseColorButton.TabIndex = 8;
            this.baseColorButton.Text = "Pick Base Color";
            this.baseColorButton.UseVisualStyleBackColor = true;
            this.baseColorButton.Click += new System.EventHandler(this.baseColorButton_Click);
            // 
            // baseColorTextBox
            // 
            this.baseColorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baseColorTextBox.Location = new System.Drawing.Point(439, 36);
            this.baseColorTextBox.Name = "baseColorTextBox";
            this.baseColorTextBox.ReadOnly = true;
            this.baseColorTextBox.Size = new System.Drawing.Size(115, 20);
            this.baseColorTextBox.TabIndex = 5;
            // 
            // baseColorLabel
            // 
            this.baseColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baseColorLabel.AutoSize = true;
            this.baseColorLabel.Location = new System.Drawing.Point(466, 22);
            this.baseColorLabel.Name = "baseColorLabel";
            this.baseColorLabel.Size = new System.Drawing.Size(61, 13);
            this.baseColorLabel.TabIndex = 4;
            this.baseColorLabel.Text = "Base Color:";
            // 
            // trackBarDarkLabel
            // 
            this.trackBarDarkLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBarDarkLabel.AutoSize = true;
            this.trackBarDarkLabel.Location = new System.Drawing.Point(214, 22);
            this.trackBarDarkLabel.Name = "trackBarDarkLabel";
            this.trackBarDarkLabel.Size = new System.Drawing.Size(60, 13);
            this.trackBarDarkLabel.TabIndex = 2;
            this.trackBarDarkLabel.Text = "Dark Color:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(4, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1002, 522);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // ImageOutlinerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 712);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editingMethodTabs);
            this.Controls.Add(this.imageControlGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1025, 720);
            this.Name = "ImageOutlinerForm";
            this.Text = "Image Outliner";
            this.Load += new System.EventHandler(this.ImageOutlinerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.imageControlGroup.ResumeLayout(false);
            this.imageControlGroup.PerformLayout();
            this.imageProperties1.ResumeLayout(false);
            this.imageProperties1.PerformLayout();
            this.editingMethodTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outlineImageToolStripMenuItem;
        private System.Windows.Forms.TextBox imageLocationTextbox;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Label imageLocationLabel;
        private System.Windows.Forms.Button outlineButton;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.GroupBox imageControlGroup;
		private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
		private System.Windows.Forms.Label darkColorLabel;
		private System.Windows.Forms.TextBox darkColorTextBox;
		private System.Windows.Forms.Button darkColorButton;
		private System.Windows.Forms.Label outlineColorLabel;
		private System.Windows.Forms.TextBox outlineColorTextBox;
		private System.Windows.Forms.Button outlineColorButton;
		private System.Windows.Forms.GroupBox imageProperties1;
		private System.Windows.Forms.TabControl editingMethodTabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label trackBarOutlineLabel;
        private System.Windows.Forms.Button baseColorButton;
        private System.Windows.Forms.TextBox baseColorTextBox;
        private System.Windows.Forms.Label baseColorLabel;
        private System.Windows.Forms.Label trackBarDarkLabel;
        private System.Windows.Forms.TrackBar leftTrackBar;
        private System.Windows.Forms.TextBox darkColorTextBox2;
        private System.Windows.Forms.TrackBar rightTrackBar;
        private System.Windows.Forms.TextBox lightColorTextBox2;
        private System.Windows.Forms.Label trackBarLightLabel;
        private System.Windows.Forms.TextBox outlineColorTextBox2;
        private System.Windows.Forms.Button outlineColorButton2;
		private System.Windows.Forms.Button lightColorButton;
		private System.Windows.Forms.TextBox lightColorTextBox;
		private System.Windows.Forms.Label lightColorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox transparentCheckBox;
		private System.Windows.Forms.ToolTip transparentToolTip;
		private System.Windows.Forms.Button backgroundButton;
		private System.Windows.Forms.TextBox backgroundTextBox;
		private System.Windows.Forms.Label backgroundColorLabel;
		private System.Windows.Forms.Button backgroundButton2;
		private System.Windows.Forms.TextBox backgroundTextBox2;
        private System.Windows.Forms.Label backgroundLabel2;
        private System.Windows.Forms.Button lightDropper;
        private System.Windows.Forms.Button darkDropper;
        private System.Windows.Forms.Button baseDropper;
	}
}

