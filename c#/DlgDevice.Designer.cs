namespace RTCM {
	partial class DlgDevice {
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
			txtbxID = new TextBox();
			txtbxFirst = new TextBox();
			label1 = new Label();
			label2 = new Label();
			gridUsers = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)gridUsers).BeginInit();
			SuspendLayout();
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(249, 211);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 5;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			btnOK.Location = new Point(140, 211);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(75, 23);
			btnOK.TabIndex = 4;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			// 
			// txtbxID
			// 
			txtbxID.Location = new Point(239, 22);
			txtbxID.Name = "txtbxID";
			txtbxID.Size = new Size(30, 23);
			txtbxID.TabIndex = 9;
			// 
			// txtbxFirst
			// 
			txtbxFirst.Location = new Point(128, 22);
			txtbxFirst.Name = "txtbxFirst";
			txtbxFirst.Size = new Size(100, 23);
			txtbxFirst.TabIndex = 7;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(83, 25);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
			label1.TabIndex = 8;
			label1.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(62, 57);
			label2.Name = "label2";
			label2.Size = new Size(60, 15);
			label2.TabIndex = 10;
			label2.Text = "Properties";
			// 
			// gridUsers
			// 
			gridUsers.AllowUserToAddRows = false;
			gridUsers.AllowUserToDeleteRows = false;
			gridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridUsers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
			gridUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
			gridUsers.Location = new Point(128, 57);
			gridUsers.Name = "gridUsers";
			gridUsers.RowHeadersVisible = false;
			gridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridUsers.Size = new Size(223, 135);
			gridUsers.TabIndex = 11;
			// 
			// Column1
			// 
			Column1.HeaderText = "Property";
			Column1.Name = "Column1";
			// 
			// Column2
			// 
			Column2.HeaderText = "Value";
			Column2.Name = "Column2";
			// 
			// DlgDevice
			// 
			AcceptButton = btnOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(381, 258);
			Controls.Add(gridUsers);
			Controls.Add(label2);
			Controls.Add(txtbxID);
			Controls.Add(txtbxFirst);
			Controls.Add(label1);
			Controls.Add(btnCancel);
			Controls.Add(btnOK);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DlgDevice";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Device Properties";
			((System.ComponentModel.ISupportInitialize)gridUsers).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCancel;
		private Button btnOK;
		private TextBox txtbxID;
		private TextBox txtbxFirst;
		private Label label1;
		private Label label2;
		private DataGridView gridUsers;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
	}
}