namespace RTCM {
	partial class dlgDevices {
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
			gridUsers = new DataGridView();
			btnDel = new Button();
			btnEdit = new Button();
			btnAdd = new Button();
			Column1 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)gridUsers).BeginInit();
			SuspendLayout();
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(244, 302);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			btnOK.Location = new Point(135, 302);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(75, 23);
			btnOK.TabIndex = 2;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// gridUsers
			// 
			gridUsers.AllowUserToAddRows = false;
			gridUsers.AllowUserToDeleteRows = false;
			gridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridUsers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4 });
			gridUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
			gridUsers.Location = new Point(12, 12);
			gridUsers.Name = "gridUsers";
			gridUsers.RowHeadersVisible = false;
			gridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridUsers.Size = new Size(437, 271);
			gridUsers.TabIndex = 4;
			// 
			// btnDel
			// 
			btnDel.Location = new Point(471, 120);
			btnDel.Name = "btnDel";
			btnDel.Size = new Size(75, 23);
			btnDel.TabIndex = 8;
			btnDel.Text = "Delete...";
			btnDel.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(471, 61);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(75, 23);
			btnEdit.TabIndex = 7;
			btnEdit.Text = "Edit...";
			btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(471, 21);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(75, 23);
			btnAdd.TabIndex = 6;
			btnAdd.Text = "Add...";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// Column1
			// 
			Column1.HeaderText = "Name";
			Column1.Name = "Column1";
			// 
			// Column3
			// 
			Column3.HeaderText = "Release";
			Column3.Name = "Column3";
			// 
			// Column2
			// 
			Column2.HeaderText = "Properties";
			Column2.Name = "Column2";
			// 
			// Column4
			// 
			Column4.HeaderText = "Status";
			Column4.Name = "Column4";
			// 
			// dlgDevices
			// 
			AcceptButton = btnOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(568, 332);
			Controls.Add(btnDel);
			Controls.Add(btnEdit);
			Controls.Add(btnAdd);
			Controls.Add(gridUsers);
			Controls.Add(btnCancel);
			Controls.Add(btnOK);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "dlgDevices";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Devices";
			((System.ComponentModel.ISupportInitialize)gridUsers).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnCancel;
		private Button btnOK;
		private DataGridView gridUsers;
		private Button btnDel;
		private Button btnEdit;
		private Button btnAdd;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column4;
	}
}