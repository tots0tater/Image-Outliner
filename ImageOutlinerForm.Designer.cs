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
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.outlineImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.imageProperties = new System.Windows.Forms.GroupBox();
			this.outlineColorButton = new System.Windows.Forms.Button();
			this.outlineColorTextBox = new System.Windows.Forms.TextBox();
			this.outlineColorLabel = new System.Windows.Forms.Label();
			this.highColorButton = new System.Windows.Forms.Button();
			this.lowColorButton = new System.Windows.Forms.Button();
			this.highColorTextBox = new System.Windows.Forms.TextBox();
			this.highColorLabel = new System.Windows.Forms.Label();
			this.lowColorTextBox = new System.Windows.Forms.TextBox();
			this.lowColorLabel = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.imageProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(604, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem});
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
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Location = new System.Drawing.Point(0, 99);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(604, 464);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// imageProperties
			// 
			this.imageProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imageProperties.Controls.Add(this.outlineColorButton);
			this.imageProperties.Controls.Add(this.outlineColorTextBox);
			this.imageProperties.Controls.Add(this.outlineColorLabel);
			this.imageProperties.Controls.Add(this.highColorButton);
			this.imageProperties.Controls.Add(this.lowColorButton);
			this.imageProperties.Controls.Add(this.highColorTextBox);
			this.imageProperties.Controls.Add(this.highColorLabel);
			this.imageProperties.Controls.Add(this.lowColorTextBox);
			this.imageProperties.Controls.Add(this.lowColorLabel);
			this.imageProperties.Location = new System.Drawing.Point(0, 27);
			this.imageProperties.Name = "imageProperties";
			this.imageProperties.Size = new System.Drawing.Size(604, 73);
			this.imageProperties.TabIndex = 2;
			this.imageProperties.TabStop = false;
			this.imageProperties.Text = "Outline Image Properties";
			// 
			// outlineColorButton
			// 
			this.outlineColorButton.Location = new System.Drawing.Point(494, 42);
			this.outlineColorButton.Name = "outlineColorButton";
			this.outlineColorButton.Size = new System.Drawing.Size(100, 24);
			this.outlineColorButton.TabIndex = 11;
			this.outlineColorButton.Text = "Pick Outline Color";
			this.outlineColorButton.UseVisualStyleBackColor = true;
			this.outlineColorButton.Click += new System.EventHandler(this.outlineColorButton_Click);
			// 
			// outlineColorTextBox
			// 
			this.outlineColorTextBox.Location = new System.Drawing.Point(494, 19);
			this.outlineColorTextBox.Name = "outlineColorTextBox";
			this.outlineColorTextBox.ReadOnly = true;
			this.outlineColorTextBox.Size = new System.Drawing.Size(100, 20);
			this.outlineColorTextBox.TabIndex = 10;
			// 
			// outlineColorLabel
			// 
			this.outlineColorLabel.AutoSize = true;
			this.outlineColorLabel.Location = new System.Drawing.Point(418, 31);
			this.outlineColorLabel.Name = "outlineColorLabel";
			this.outlineColorLabel.Size = new System.Drawing.Size(70, 13);
			this.outlineColorLabel.TabIndex = 9;
			this.outlineColorLabel.Text = "Outline Color:";
			// 
			// highColorButton
			// 
			this.highColorButton.Location = new System.Drawing.Point(277, 42);
			this.highColorButton.Name = "highColorButton";
			this.highColorButton.Size = new System.Drawing.Size(100, 24);
			this.highColorButton.TabIndex = 8;
			this.highColorButton.Text = "Pick High Color";
			this.highColorButton.UseVisualStyleBackColor = true;
			this.highColorButton.Click += new System.EventHandler(this.highColorButton_Click);
			// 
			// lowColorButton
			// 
			this.lowColorButton.Location = new System.Drawing.Point(70, 42);
			this.lowColorButton.Name = "lowColorButton";
			this.lowColorButton.Size = new System.Drawing.Size(100, 24);
			this.lowColorButton.TabIndex = 7;
			this.lowColorButton.Text = "Pick Low Color";
			this.lowColorButton.UseVisualStyleBackColor = true;
			this.lowColorButton.Click += new System.EventHandler(this.lowColorButton_Click);
			// 
			// highColorTextBox
			// 
			this.highColorTextBox.Location = new System.Drawing.Point(277, 19);
			this.highColorTextBox.Name = "highColorTextBox";
			this.highColorTextBox.ReadOnly = true;
			this.highColorTextBox.Size = new System.Drawing.Size(100, 20);
			this.highColorTextBox.TabIndex = 5;
			// 
			// highColorLabel
			// 
			this.highColorLabel.AutoSize = true;
			this.highColorLabel.Location = new System.Drawing.Point(212, 31);
			this.highColorLabel.Name = "highColorLabel";
			this.highColorLabel.Size = new System.Drawing.Size(59, 13);
			this.highColorLabel.TabIndex = 4;
			this.highColorLabel.Text = "High Color:";
			// 
			// lowColorTextBox
			// 
			this.lowColorTextBox.Location = new System.Drawing.Point(70, 19);
			this.lowColorTextBox.Name = "lowColorTextBox";
			this.lowColorTextBox.ReadOnly = true;
			this.lowColorTextBox.Size = new System.Drawing.Size(100, 20);
			this.lowColorTextBox.TabIndex = 3;
			// 
			// lowColorLabel
			// 
			this.lowColorLabel.AutoSize = true;
			this.lowColorLabel.Location = new System.Drawing.Point(7, 31);
			this.lowColorLabel.Name = "lowColorLabel";
			this.lowColorLabel.Size = new System.Drawing.Size(57, 13);
			this.lowColorLabel.TabIndex = 2;
			this.lowColorLabel.Text = "Low Color:";
			// 
			// ImageOutlinerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 562);
			this.Controls.Add(this.imageProperties);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(620, 600);
			this.Name = "ImageOutlinerForm";
			this.Text = "Image Outliner";
			this.Load += new System.EventHandler(this.ImageOutlinerForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.imageProperties.ResumeLayout(false);
			this.imageProperties.PerformLayout();
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
		private System.Windows.Forms.GroupBox imageProperties;
		private System.Windows.Forms.TextBox highColorTextBox;
		private System.Windows.Forms.Label highColorLabel;
		private System.Windows.Forms.TextBox lowColorTextBox;
		private System.Windows.Forms.Label lowColorLabel;
		private System.Windows.Forms.Button highColorButton;
		private System.Windows.Forms.Button lowColorButton;
		private System.Windows.Forms.Button outlineColorButton;
		private System.Windows.Forms.TextBox outlineColorTextBox;
		private System.Windows.Forms.Label outlineColorLabel;
	}
}

