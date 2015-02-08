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
			this.imageProperties = new System.Windows.Forms.GroupBox();
			this.editingMethodTabs = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.imageControlGroup.SuspendLayout();
			this.imageProperties.SuspendLayout();
			this.editingMethodTabs.SuspendLayout();
			this.tabPage1.SuspendLayout();
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
			this.menuStrip1.Size = new System.Drawing.Size(659, 24);
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
			this.pictureBox1.Size = new System.Drawing.Size(652, 421);
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
			this.imageLocationTextbox.Size = new System.Drawing.Size(442, 20);
			this.imageLocationTextbox.TabIndex = 3;
			this.imageLocationTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.imageLocationTextbox_KeyDown);
			// 
			// loadImageButton
			// 
			this.loadImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.loadImageButton.Location = new System.Drawing.Point(545, 11);
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
			this.outlineButton.Location = new System.Drawing.Point(582, 11);
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
			this.imageControlGroup.Size = new System.Drawing.Size(659, 37);
			this.imageControlGroup.TabIndex = 8;
			this.imageControlGroup.TabStop = false;
			// 
			// lightColorLabel
			// 
			this.lightColorLabel.AutoSize = true;
			this.lightColorLabel.Location = new System.Drawing.Point(10, 22);
			this.lightColorLabel.Name = "lightColorLabel";
			this.lightColorLabel.Size = new System.Drawing.Size(60, 13);
			this.lightColorLabel.TabIndex = 2;
			this.lightColorLabel.Text = "Light Color:";
			// 
			// lightColorTextBox
			// 
			this.lightColorTextBox.Location = new System.Drawing.Point(70, 19);
			this.lightColorTextBox.Name = "lightColorTextBox";
			this.lightColorTextBox.ReadOnly = true;
			this.lightColorTextBox.Size = new System.Drawing.Size(136, 20);
			this.lightColorTextBox.TabIndex = 3;
			// 
			// darkColorLabel
			// 
			this.darkColorLabel.AutoSize = true;
			this.darkColorLabel.Location = new System.Drawing.Point(219, 22);
			this.darkColorLabel.Name = "darkColorLabel";
			this.darkColorLabel.Size = new System.Drawing.Size(60, 13);
			this.darkColorLabel.TabIndex = 4;
			this.darkColorLabel.Text = "Dark Color:";
			// 
			// darkColorTextBox
			// 
			this.darkColorTextBox.Location = new System.Drawing.Point(284, 19);
			this.darkColorTextBox.Name = "darkColorTextBox";
			this.darkColorTextBox.ReadOnly = true;
			this.darkColorTextBox.Size = new System.Drawing.Size(135, 20);
			this.darkColorTextBox.TabIndex = 5;
			// 
			// lightColorButton
			// 
			this.lightColorButton.Location = new System.Drawing.Point(89, 42);
			this.lightColorButton.Name = "lightColorButton";
			this.lightColorButton.Size = new System.Drawing.Size(100, 24);
			this.lightColorButton.TabIndex = 7;
			this.lightColorButton.Text = "Pick Light Color";
			this.lightColorButton.UseVisualStyleBackColor = true;
			this.lightColorButton.Click += new System.EventHandler(this.lightColorButton_Click);
			// 
			// darkColorButton
			// 
			this.darkColorButton.Location = new System.Drawing.Point(304, 42);
			this.darkColorButton.Name = "darkColorButton";
			this.darkColorButton.Size = new System.Drawing.Size(100, 24);
			this.darkColorButton.TabIndex = 8;
			this.darkColorButton.Text = "Pick Dark Color";
			this.darkColorButton.UseVisualStyleBackColor = true;
			this.darkColorButton.Click += new System.EventHandler(this.darkColorButton_Click);
			// 
			// outlineColorLabel
			// 
			this.outlineColorLabel.AutoSize = true;
			this.outlineColorLabel.Location = new System.Drawing.Point(429, 22);
			this.outlineColorLabel.Name = "outlineColorLabel";
			this.outlineColorLabel.Size = new System.Drawing.Size(70, 13);
			this.outlineColorLabel.TabIndex = 9;
			this.outlineColorLabel.Text = "Outline Color:";
			// 
			// outlineColorTextBox
			// 
			this.outlineColorTextBox.Location = new System.Drawing.Point(505, 19);
			this.outlineColorTextBox.Name = "outlineColorTextBox";
			this.outlineColorTextBox.ReadOnly = true;
			this.outlineColorTextBox.Size = new System.Drawing.Size(135, 20);
			this.outlineColorTextBox.TabIndex = 10;
			// 
			// outlineColorButton
			// 
			this.outlineColorButton.Location = new System.Drawing.Point(524, 42);
			this.outlineColorButton.Name = "outlineColorButton";
			this.outlineColorButton.Size = new System.Drawing.Size(100, 24);
			this.outlineColorButton.TabIndex = 11;
			this.outlineColorButton.Text = "Pick Outline Color";
			this.outlineColorButton.UseVisualStyleBackColor = true;
			this.outlineColorButton.Click += new System.EventHandler(this.outlineColorButton_Click);
			// 
			// imageProperties
			// 
			this.imageProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imageProperties.Controls.Add(this.outlineColorButton);
			this.imageProperties.Controls.Add(this.outlineColorTextBox);
			this.imageProperties.Controls.Add(this.outlineColorLabel);
			this.imageProperties.Controls.Add(this.darkColorButton);
			this.imageProperties.Controls.Add(this.lightColorButton);
			this.imageProperties.Controls.Add(this.darkColorTextBox);
			this.imageProperties.Controls.Add(this.darkColorLabel);
			this.imageProperties.Controls.Add(this.lightColorTextBox);
			this.imageProperties.Controls.Add(this.lightColorLabel);
			this.imageProperties.Location = new System.Drawing.Point(3, 3);
			this.imageProperties.Name = "imageProperties";
			this.imageProperties.Size = new System.Drawing.Size(645, 73);
			this.imageProperties.TabIndex = 2;
			this.imageProperties.TabStop = false;
			this.imageProperties.Text = "Outline Image Properties";
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
			this.editingMethodTabs.Size = new System.Drawing.Size(659, 518);
			this.editingMethodTabs.TabIndex = 9;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.imageProperties);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(651, 492);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(651, 492);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// ImageOutlinerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(659, 577);
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
			this.imageProperties.ResumeLayout(false);
			this.imageProperties.PerformLayout();
			this.editingMethodTabs.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
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
		private System.Windows.Forms.GroupBox imageProperties;
		private System.Windows.Forms.TabControl editingMethodTabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
	}
}

