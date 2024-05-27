namespace RTCM {
	partial class main {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
			menuMain = new MenuStrip();
			popupFile = new ToolStripMenuItem();
			miLogin = new ToolStripMenuItem();
			miLogout = new ToolStripMenuItem();
			miFileSep1 = new ToolStripSeparator();
			miExit = new ToolStripMenuItem();
			instrumentsToolStripMenuItem = new ToolStripMenuItem();
			instrumentsToolStripMenuItem1 = new ToolStripMenuItem();
			usersToolStripMenuItem = new ToolStripMenuItem();
			helpToolStripMenuItem = new ToolStripMenuItem();
			aboutToolStripMenuItem = new ToolStripMenuItem();
			button1 = new Button();
			statusStrip1 = new StatusStrip();
			sblblDatabase = new ToolStripStatusLabel();
			menuMain.SuspendLayout();
			statusStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuMain
			// 
			menuMain.Items.AddRange(new ToolStripItem[] { popupFile, instrumentsToolStripMenuItem, helpToolStripMenuItem });
			menuMain.Location = new Point(0, 0);
			menuMain.Name = "menuMain";
			menuMain.Size = new Size(800, 24);
			menuMain.TabIndex = 1;
			menuMain.Text = "menuStrip1";
			// 
			// popupFile
			// 
			popupFile.DropDownItems.AddRange(new ToolStripItem[] { miLogin, miLogout, miFileSep1, miExit });
			popupFile.Name = "popupFile";
			popupFile.Size = new Size(37, 20);
			popupFile.Text = "&File";
			// 
			// miLogin
			// 
			miLogin.Name = "miLogin";
			miLogin.Size = new Size(113, 22);
			miLogin.Text = "Login...";
			// 
			// miLogout
			// 
			miLogout.Name = "miLogout";
			miLogout.Size = new Size(113, 22);
			miLogout.Text = "Logout";
			// 
			// miFileSep1
			// 
			miFileSep1.Name = "miFileSep1";
			miFileSep1.Size = new Size(110, 6);
			// 
			// miExit
			// 
			miExit.Name = "miExit";
			miExit.Size = new Size(113, 22);
			miExit.Text = "Exit";
			miExit.Click += miExit_Click;
			// 
			// instrumentsToolStripMenuItem
			// 
			instrumentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { instrumentsToolStripMenuItem1, usersToolStripMenuItem });
			instrumentsToolStripMenuItem.Name = "instrumentsToolStripMenuItem";
			instrumentsToolStripMenuItem.Size = new Size(62, 20);
			instrumentsToolStripMenuItem.Text = "Manage";
			// 
			// instrumentsToolStripMenuItem1
			// 
			instrumentsToolStripMenuItem1.Name = "instrumentsToolStripMenuItem1";
			instrumentsToolStripMenuItem1.Size = new Size(180, 22);
			instrumentsToolStripMenuItem1.Text = "Instruments...";
			// 
			// usersToolStripMenuItem
			// 
			usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			usersToolStripMenuItem.Size = new Size(180, 22);
			usersToolStripMenuItem.Text = "Users...";
			usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(44, 20);
			helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			aboutToolStripMenuItem.Size = new Size(116, 22);
			aboutToolStripMenuItem.Text = "About...";
			// 
			// button1
			// 
			button1.Location = new Point(234, 109);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 2;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { sblblDatabase });
			statusStrip1.Location = new Point(0, 428);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(800, 22);
			statusStrip1.TabIndex = 3;
			statusStrip1.Text = "statusStrip1";
			// 
			// sblblDatabase
			// 
			sblblDatabase.Name = "sblblDatabase";
			sblblDatabase.Size = new Size(55, 17);
			sblblDatabase.Text = "Database";
			// 
			// main
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(statusStrip1);
			Controls.Add(button1);
			Controls.Add(menuMain);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuMain;
			Name = "main";
			Text = "Rotem Test Case Management System";
			FormClosed += main_FormClosed;
			Load += main_Load;
			menuMain.ResumeLayout(false);
			menuMain.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private MenuStrip menuMain;
		private ToolStripMenuItem popupFile;
		private ToolStripMenuItem miLogin;
		private ToolStripMenuItem miLogout;
		private ToolStripSeparator miFileSep1;
		private ToolStripMenuItem miExit;
		private ToolStripMenuItem instrumentsToolStripMenuItem;
		private ToolStripMenuItem instrumentsToolStripMenuItem1;
		private ToolStripMenuItem usersToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private Button button1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel sblblDatabase;
	}
}
