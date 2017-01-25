namespace paint
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel_main = new System.Windows.Forms.Panel();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.colorToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(576, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// insertToolStripMenuItem
			// 
			this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem1,
            this.rectangleToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.triangleToolStripMenuItem});
			this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
			this.insertToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.insertToolStripMenuItem.Text = "&Insert";
			// 
			// lineToolStripMenuItem1
			// 
			this.lineToolStripMenuItem1.Name = "lineToolStripMenuItem1";
			this.lineToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.lineToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
			this.lineToolStripMenuItem1.Text = "Line";
			this.lineToolStripMenuItem1.Click += new System.EventHandler(this.lineToolStripMenuItem1_Click);
			// 
			// rectangleToolStripMenuItem
			// 
			this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
			this.rectangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.rectangleToolStripMenuItem.Text = "Rectangle";
			this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
			// 
			// circleToolStripMenuItem
			// 
			this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
			this.circleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.circleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.circleToolStripMenuItem.Text = "circle";
			this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click_1);
			// 
			// triangleToolStripMenuItem
			// 
			this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
			this.triangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.triangleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.triangleToolStripMenuItem.Text = "Triangle";
			this.triangleToolStripMenuItem.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
			// 
			// colorToolStripMenuItem
			// 
			this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
			this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.colorToolStripMenuItem.Text = "Color";
			this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
			// 
			// panel_main
			// 
			this.panel_main.BackColor = System.Drawing.Color.White;
			this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_main.Location = new System.Drawing.Point(0, 24);
			this.panel_main.Name = "panel_main";
			this.panel_main.Size = new System.Drawing.Size(576, 309);
			this.panel_main.TabIndex = 1;
			this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
			this.panel_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_main_MouseDown);
			this.panel_main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_main_MouseMove);
			this.panel_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_main_MouseUp_1);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "14",
            "20",
            "30",
            "60"});
			this.comboBox1.Location = new System.Drawing.Point(135, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(82, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.Tag = "";
			this.comboBox1.Text = "Size";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 333);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.panel_main);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Panel panel_main;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}

