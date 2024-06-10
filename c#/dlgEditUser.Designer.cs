﻿namespace RTCM {
	partial class dlgEditUser {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			btnCancel = new Button();
			btnOK = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			txtbxFirst = new TextBox();
			txtbxLast = new TextBox();
			txtbxUsername = new TextBox();
			txtbxPassword = new TextBox();
			comboLevels = new ComboBox();
			cboxActive = new CheckBox();
			txtbxID = new TextBox();
			SuspendLayout();
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(219, 252);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			btnOK.Location = new Point(110, 252);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(75, 23);
			btnOK.TabIndex = 2;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(118, 31);
			label1.Name = "label1";
			label1.Size = new Size(29, 15);
			label1.TabIndex = 4;
			label1.Text = "First";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(116, 58);
			label2.Name = "label2";
			label2.Size = new Size(28, 15);
			label2.TabIndex = 5;
			label2.Text = "Last";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(87, 97);
			label3.Name = "label3";
			label3.Size = new Size(60, 15);
			label3.TabIndex = 6;
			label3.Text = "Username";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(87, 137);
			label4.Name = "label4";
			label4.Size = new Size(57, 15);
			label4.TabIndex = 7;
			label4.Text = "Password";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(110, 169);
			label5.Name = "label5";
			label5.Size = new Size(34, 15);
			label5.TabIndex = 8;
			label5.Text = "Level";
			// 
			// txtbxFirst
			// 
			txtbxFirst.Location = new Point(164, 23);
			txtbxFirst.Name = "txtbxFirst";
			txtbxFirst.Size = new Size(100, 23);
			txtbxFirst.TabIndex = 9;
			// 
			// txtbxLast
			// 
			txtbxLast.Location = new Point(164, 58);
			txtbxLast.Name = "txtbxLast";
			txtbxLast.Size = new Size(100, 23);
			txtbxLast.TabIndex = 10;
			// 
			// txtbxUsername
			// 
			txtbxUsername.Location = new Point(164, 94);
			txtbxUsername.Name = "txtbxUsername";
			txtbxUsername.Size = new Size(100, 23);
			txtbxUsername.TabIndex = 11;
			// 
			// txtbxPassword
			// 
			txtbxPassword.Location = new Point(164, 129);
			txtbxPassword.Name = "txtbxPassword";
			txtbxPassword.Size = new Size(100, 23);
			txtbxPassword.TabIndex = 12;
			// 
			// comboLevels
			// 
			comboLevels.DropDownStyle = ComboBoxStyle.DropDownList;
			comboLevels.FormattingEnabled = true;
			comboLevels.Location = new Point(164, 166);
			comboLevels.Name = "comboLevels";
			comboLevels.Size = new Size(100, 23);
			comboLevels.Sorted = true;
			comboLevels.TabIndex = 13;
			// 
			// cboxActive
			// 
			cboxActive.AutoSize = true;
			cboxActive.Location = new Point(175, 204);
			cboxActive.Name = "cboxActive";
			cboxActive.Size = new Size(59, 19);
			cboxActive.TabIndex = 15;
			cboxActive.Text = "Active";
			cboxActive.UseVisualStyleBackColor = true;
			// 
			// txtbxID
			// 
			txtbxID.Location = new Point(275, 23);
			txtbxID.Name = "txtbxID";
			txtbxID.Size = new Size(30, 23);
			txtbxID.TabIndex = 16;
			// 
			// dlgEditUser
			// 
			AcceptButton = btnOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(387, 292);
			Controls.Add(txtbxID);
			Controls.Add(cboxActive);
			Controls.Add(comboLevels);
			Controls.Add(txtbxPassword);
			Controls.Add(txtbxUsername);
			Controls.Add(txtbxLast);
			Controls.Add(txtbxFirst);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnCancel);
			Controls.Add(btnOK);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "dlgEditUser";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Editing user details";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCancel;
		private Button btnOK;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox txtbxFirst;
		private TextBox txtbxLast;
		private TextBox txtbxUsername;
		private TextBox txtbxPassword;
		private ComboBox comboLevels;
		private CheckBox cboxActive;
		private TextBox txtbxID;
	}
}