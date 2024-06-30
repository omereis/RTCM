namespace RTCM {
	partial class DlgDeviceType {
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
			gridUsers = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			label3 = new Label();
			txtbxName = new TextBox();
			txtbxRelease = new TextBox();
			picbx = new PictureBox();
			btnPicLoad = new Button();
			btnPicClear = new Button();
			dlgOpenPic = new OpenFileDialog();
			btnPropAdd = new Button();
			btnPropEdit = new Button();
			btnPropDel = new Button();
			groupBox1 = new GroupBox();
			((System.ComponentModel.ISupportInitialize)gridUsers).BeginInit();
			((System.ComponentModel.ISupportInitialize)picbx).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(397, 344);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 5;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			btnOK.Location = new Point(288, 344);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(75, 23);
			btnOK.TabIndex = 4;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 23);
			label1.Name = "label1";
			label1.Size = new Size(77, 15);
			label1.TabIndex = 6;
			label1.Text = "Device Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(43, 53);
			label2.Name = "label2";
			label2.Size = new Size(46, 15);
			label2.TabIndex = 7;
			label2.Text = "Release";
			// 
			// gridUsers
			// 
			gridUsers.AllowUserToAddRows = false;
			gridUsers.AllowUserToDeleteRows = false;
			gridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridUsers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
			gridUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
			gridUsers.Location = new Point(101, 94);
			gridUsers.Name = "gridUsers";
			gridUsers.RowHeadersVisible = false;
			gridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridUsers.Size = new Size(330, 228);
			gridUsers.TabIndex = 8;
			// 
			// Column1
			// 
			Column1.HeaderText = "Property Name";
			Column1.Name = "Column1";
			Column1.Width = 150;
			// 
			// Column2
			// 
			Column2.HeaderText = "Property Value";
			Column2.Name = "Column2";
			Column2.Width = 150;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 94);
			label3.Name = "label3";
			label3.Size = new Size(60, 15);
			label3.TabIndex = 9;
			label3.Text = "Properties";
			// 
			// txtbxName
			// 
			txtbxName.Location = new Point(95, 15);
			txtbxName.Name = "txtbxName";
			txtbxName.Size = new Size(100, 23);
			txtbxName.TabIndex = 10;
			// 
			// txtbxRelease
			// 
			txtbxRelease.Location = new Point(95, 50);
			txtbxRelease.Name = "txtbxRelease";
			txtbxRelease.Size = new Size(100, 23);
			txtbxRelease.TabIndex = 11;
			// 
			// picbx
			// 
			picbx.BorderStyle = BorderStyle.FixedSingle;
			picbx.Location = new Point(6, 54);
			picbx.Name = "picbx";
			picbx.Size = new Size(258, 222);
			picbx.SizeMode = PictureBoxSizeMode.StretchImage;
			picbx.TabIndex = 13;
			picbx.TabStop = false;
			// 
			// btnPicLoad
			// 
			btnPicLoad.Location = new Point(37, 22);
			btnPicLoad.Name = "btnPicLoad";
			btnPicLoad.Size = new Size(75, 26);
			btnPicLoad.TabIndex = 14;
			btnPicLoad.Text = "&Load...";
			btnPicLoad.UseVisualStyleBackColor = true;
			btnPicLoad.Click += btnPicLoad_Click;
			// 
			// btnPicClear
			// 
			btnPicClear.Location = new Point(146, 22);
			btnPicClear.Name = "btnPicClear";
			btnPicClear.Size = new Size(75, 26);
			btnPicClear.TabIndex = 15;
			btnPicClear.Text = "Clear";
			btnPicClear.UseVisualStyleBackColor = true;
			btnPicClear.Click += btnPicClear_Click;
			// 
			// dlgOpenPic
			// 
			dlgOpenPic.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...;";
			// 
			// btnPropAdd
			// 
			btnPropAdd.Location = new Point(20, 128);
			btnPropAdd.Name = "btnPropAdd";
			btnPropAdd.Size = new Size(75, 23);
			btnPropAdd.TabIndex = 16;
			btnPropAdd.Text = "Add...";
			btnPropAdd.UseVisualStyleBackColor = true;
			btnPropAdd.Click += btnPropAdd_Click;
			// 
			// btnPropEdit
			// 
			btnPropEdit.Location = new Point(20, 157);
			btnPropEdit.Name = "btnPropEdit";
			btnPropEdit.Size = new Size(75, 23);
			btnPropEdit.TabIndex = 17;
			btnPropEdit.Text = "Edit...";
			btnPropEdit.UseVisualStyleBackColor = true;
			// 
			// btnPropDel
			// 
			btnPropDel.Location = new Point(18, 216);
			btnPropDel.Name = "btnPropDel";
			btnPropDel.Size = new Size(75, 23);
			btnPropDel.TabIndex = 18;
			btnPropDel.Text = "Delete...";
			btnPropDel.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnPicLoad);
			groupBox1.Controls.Add(btnPicClear);
			groupBox1.Controls.Add(picbx);
			groupBox1.Location = new Point(437, 40);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(277, 282);
			groupBox1.TabIndex = 19;
			groupBox1.TabStop = false;
			groupBox1.Text = "Picture";
			// 
			// DlgDeviceType
			// 
			AcceptButton = btnOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(747, 379);
			Controls.Add(groupBox1);
			Controls.Add(btnPropDel);
			Controls.Add(btnPropEdit);
			Controls.Add(btnPropAdd);
			Controls.Add(txtbxRelease);
			Controls.Add(txtbxName);
			Controls.Add(label3);
			Controls.Add(gridUsers);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnCancel);
			Controls.Add(btnOK);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DlgDeviceType";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "DlgDeviceType";
			((System.ComponentModel.ISupportInitialize)gridUsers).EndInit();
			((System.ComponentModel.ISupportInitialize)picbx).EndInit();
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCancel;
		private Button btnOK;
		private Label label1;
		private Label label2;
		private DataGridView gridUsers;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private Label label3;
		private TextBox txtbxName;
		private TextBox txtbxRelease;
		private PictureBox picbx;
		private Button btnPicLoad;
		private Button btnPicClear;
		private OpenFileDialog dlgOpenPic;
		private Button btnPropAdd;
		private Button btnPropEdit;
		private Button btnPropDel;
		private GroupBox groupBox1;
	}
}