namespace RTCM {
	partial class DlgDeviceProp {
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
			label1 = new Label();
			label2 = new Label();
			txtbxName = new TextBox();
			txtbxValue = new TextBox();
			btnCancel = new Button();
			btnOK = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(47, 17);
			label1.Name = "label1";
			label1.Size = new Size(87, 15);
			label1.TabIndex = 0;
			label1.Text = "Property Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(47, 51);
			label2.Name = "label2";
			label2.Size = new Size(83, 15);
			label2.TabIndex = 1;
			label2.Text = "Property Value";
			// 
			// txtbxName
			// 
			txtbxName.Location = new Point(151, 9);
			txtbxName.Name = "txtbxName";
			txtbxName.Size = new Size(190, 23);
			txtbxName.TabIndex = 2;
			// 
			// txtbxValue
			// 
			txtbxValue.Location = new Point(151, 48);
			txtbxValue.Name = "txtbxValue";
			txtbxValue.Size = new Size(190, 23);
			txtbxValue.TabIndex = 3;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(204, 108);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 7;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			btnOK.Location = new Point(95, 108);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(75, 23);
			btnOK.TabIndex = 6;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			// 
			// DlgDeviceProp
			// 
			AcceptButton = btnOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(394, 143);
			Controls.Add(btnCancel);
			Controls.Add(btnOK);
			Controls.Add(txtbxValue);
			Controls.Add(txtbxName);
			Controls.Add(label2);
			Controls.Add(label1);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DlgDeviceProp";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Device Property";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtbxName;
		private TextBox txtbxValue;
		private Button btnCancel;
		private Button btnOK;
	}
}