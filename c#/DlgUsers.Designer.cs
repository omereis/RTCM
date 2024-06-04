namespace RTCM {
	partial class DlgUsers {
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
			btnOK = new Button();
			btnCancel = new Button();
			gridUsers = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			btnAdd = new Button();
			btnEdit = new Button();
			btnDel = new Button();
			((System.ComponentModel.ISupportInitialize)gridUsers).BeginInit();
			SuspendLayout();
			// 
			// btnOK
			// 
			btnOK.Location = new Point(134, 323);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(75, 23);
			btnOK.TabIndex = 0;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(243, 323);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 1;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// gridUsers
			// 
			gridUsers.AllowUserToAddRows = false;
			gridUsers.AllowUserToDeleteRows = false;
			gridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridUsers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4 });
			gridUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
			gridUsers.Location = new Point(12, 24);
			gridUsers.Name = "gridUsers";
			gridUsers.RowHeadersVisible = false;
			gridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridUsers.Size = new Size(437, 271);
			gridUsers.TabIndex = 2;
			// 
			// Column1
			// 
			Column1.HeaderText = "Name";
			Column1.Name = "Column1";
			// 
			// Column3
			// 
			Column3.HeaderText = "Username";
			Column3.Name = "Column3";
			// 
			// Column2
			// 
			Column2.HeaderText = "Level";
			Column2.Name = "Column2";
			// 
			// Column4
			// 
			Column4.HeaderText = "Status";
			Column4.Name = "Column4";
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(463, 53);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(75, 23);
			btnAdd.TabIndex = 3;
			btnAdd.Text = "Add...";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(463, 93);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(75, 23);
			btnEdit.TabIndex = 4;
			btnEdit.Text = "Edit...";
			btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnDel
			// 
			btnDel.Location = new Point(463, 152);
			btnDel.Name = "btnDel";
			btnDel.Size = new Size(75, 23);
			btnDel.TabIndex = 5;
			btnDel.Text = "Delete...";
			btnDel.UseVisualStyleBackColor = true;
			// 
			// DlgUsers
			// 
			AcceptButton = btnOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(551, 369);
			Controls.Add(btnDel);
			Controls.Add(btnEdit);
			Controls.Add(btnAdd);
			Controls.Add(gridUsers);
			Controls.Add(btnCancel);
			Controls.Add(btnOK);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DlgUsers";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "RCM Users";
			((System.ComponentModel.ISupportInitialize)gridUsers).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnOK;
		private Button btnCancel;
		private DataGridView gridUsers;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column4;
		private Button btnAdd;
		private Button btnEdit;
		private Button btnDel;
	}
}