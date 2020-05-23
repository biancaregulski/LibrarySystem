/*
 * Created by SharpDevelop.
 * User: Bianca
 * Date: 5/16/2020
 * Time: 9:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LibrarySystem
{
	partial class AddBorrowerForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Label labelNotification;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.Label labelDob;
		private System.Windows.Forms.DateTimePicker dateTimeDob;
		private System.Windows.Forms.TextBox textBoxFirstName;

		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.labelDob = new System.Windows.Forms.Label();
			this.dateTimeDob = new System.Windows.Forms.DateTimePicker();
			this.buttonOk = new System.Windows.Forms.Button();
			this.labelNotification = new System.Windows.Forms.Label();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(13, 13);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(100, 23);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name:";
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(223, 10);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(84, 22);
			this.textBoxLastName.TabIndex = 1;
			// 
			// labelDob
			// 
			this.labelDob.Location = new System.Drawing.Point(13, 40);
			this.labelDob.Name = "labelDob";
			this.labelDob.Size = new System.Drawing.Size(100, 23);
			this.labelDob.TabIndex = 2;
			this.labelDob.Text = "Date of Birth:";
			// 
			// dateTimeDob
			// 
			this.dateTimeDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeDob.Location = new System.Drawing.Point(133, 40);
			this.dateTimeDob.Name = "dateTimeDob";
			this.dateTimeDob.Size = new System.Drawing.Size(174, 22);
			this.dateTimeDob.TabIndex = 3;
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(235, 77);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 4;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// labelNotification
			// 
			this.labelNotification.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelNotification.Location = new System.Drawing.Point(13, 80);
			this.labelNotification.Name = "labelNotification";
			this.labelNotification.Size = new System.Drawing.Size(216, 23);
			this.labelNotification.TabIndex = 7;
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(133, 10);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(84, 22);
			this.textBoxFirstName.TabIndex = 8;
			// 
			// AddBorrowerForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 115);
			this.Controls.Add(this.textBoxFirstName);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.dateTimeDob);
			this.Controls.Add(this.labelDob);
			this.Controls.Add(this.textBoxLastName);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelNotification);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "AddBorrowerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Borrower";
			this.Load += new System.EventHandler(this.AddBorrowerFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
