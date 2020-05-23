/*
 * Created by SharpDevelop.
 * User: Bianca
 * Date: 5/19/2020
 * Time: 9:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LibrarySystem
{
	partial class ViewBookForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.ComboBox comboBoxGenre;
		private System.Windows.Forms.Label genreLabel;
		private System.Windows.Forms.Label labelNotification;
		private System.Windows.Forms.TextBox textBoxYear;
		private System.Windows.Forms.TextBox textBoxFirstName;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.Label labelYear;
		private System.Windows.Forms.Label labelAuthor;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.TextBox textBoxBookId;
		private System.Windows.Forms.Label labelCheckoutId;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonOk;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.comboBoxGenre = new System.Windows.Forms.ComboBox();
			this.genreLabel = new System.Windows.Forms.Label();
			this.labelNotification = new System.Windows.Forms.Label();
			this.textBoxYear = new System.Windows.Forms.TextBox();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.labelYear = new System.Windows.Forms.Label();
			this.labelAuthor = new System.Windows.Forms.Label();
			this.labelTitle = new System.Windows.Forms.Label();
			this.textBoxBookId = new System.Windows.Forms.TextBox();
			this.labelCheckoutId = new System.Windows.Forms.Label();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(250, 39);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.ReadOnly = true;
			this.textBoxLastName.Size = new System.Drawing.Size(107, 22);
			this.textBoxLastName.TabIndex = 16;
			// 
			// comboBoxGenre
			// 
			this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGenre.Enabled = false;
			this.comboBoxGenre.FormattingEnabled = true;
			this.comboBoxGenre.Items.AddRange(new object[] {
			"Fiction",
			"Non-fiction"});
			this.comboBoxGenre.Location = new System.Drawing.Point(136, 124);
			this.comboBoxGenre.Name = "comboBoxGenre";
			this.comboBoxGenre.Size = new System.Drawing.Size(221, 24);
			this.comboBoxGenre.TabIndex = 10;
			// 
			// genreLabel
			// 
			this.genreLabel.Location = new System.Drawing.Point(13, 127);
			this.genreLabel.Name = "genreLabel";
			this.genreLabel.Size = new System.Drawing.Size(100, 23);
			this.genreLabel.TabIndex = 9;
			this.genreLabel.Text = "Genre:";
			// 
			// labelNotification
			// 
			this.labelNotification.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelNotification.Location = new System.Drawing.Point(13, 162);
			this.labelNotification.Name = "labelNotification";
			this.labelNotification.Size = new System.Drawing.Size(184, 23);
			this.labelNotification.TabIndex = 17;
			// 
			// textBoxYear
			// 
			this.textBoxYear.Location = new System.Drawing.Point(136, 96);
			this.textBoxYear.Name = "textBoxYear";
			this.textBoxYear.ReadOnly = true;
			this.textBoxYear.Size = new System.Drawing.Size(221, 22);
			this.textBoxYear.TabIndex = 8;
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(137, 38);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.ReadOnly = true;
			this.textBoxFirstName.Size = new System.Drawing.Size(107, 22);
			this.textBoxFirstName.TabIndex = 4;
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(137, 67);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.ReadOnly = true;
			this.textBoxTitle.Size = new System.Drawing.Size(220, 22);
			this.textBoxTitle.TabIndex = 6;
			// 
			// labelYear
			// 
			this.labelYear.Location = new System.Drawing.Point(13, 99);
			this.labelYear.Name = "labelYear";
			this.labelYear.Size = new System.Drawing.Size(100, 23);
			this.labelYear.TabIndex = 7;
			this.labelYear.Text = "Year:";
			// 
			// labelAuthor
			// 
			this.labelAuthor.Location = new System.Drawing.Point(13, 42);
			this.labelAuthor.Name = "labelAuthor";
			this.labelAuthor.Size = new System.Drawing.Size(100, 23);
			this.labelAuthor.TabIndex = 3;
			this.labelAuthor.Text = "Author:";
			// 
			// labelTitle
			// 
			this.labelTitle.Location = new System.Drawing.Point(13, 70);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(118, 23);
			this.labelTitle.TabIndex = 5;
			this.labelTitle.Text = "Title:";
			// 
			// textBoxBookId
			// 
			this.textBoxBookId.Location = new System.Drawing.Point(137, 10);
			this.textBoxBookId.Name = "textBoxBookId";
			this.textBoxBookId.Size = new System.Drawing.Size(138, 22);
			this.textBoxBookId.TabIndex = 2;
			// 
			// labelCheckoutId
			// 
			this.labelCheckoutId.Location = new System.Drawing.Point(13, 13);
			this.labelCheckoutId.Name = "labelCheckoutId";
			this.labelCheckoutId.Size = new System.Drawing.Size(129, 23);
			this.labelCheckoutId.TabIndex = 1;
			this.labelCheckoutId.Text = "Book ID:";
			// 
			// buttonRemove
			// 
			this.buttonRemove.Enabled = false;
			this.buttonRemove.Location = new System.Drawing.Point(203, 159);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(75, 23);
			this.buttonRemove.TabIndex = 11;
			this.buttonRemove.Text = "Remove";
			this.buttonRemove.UseVisualStyleBackColor = true;
			this.buttonRemove.Click += new System.EventHandler(this.ButtonRemoveClick);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Enabled = false;
			this.buttonEdit.Location = new System.Drawing.Point(284, 159);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(75, 23);
			this.buttonEdit.TabIndex = 12;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.ButtonEditClick);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(281, 9);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 18;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// ViewBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 194);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonRemove);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.textBoxBookId);
			this.Controls.Add(this.labelCheckoutId);
			this.Controls.Add(this.textBoxLastName);
			this.Controls.Add(this.comboBoxGenre);
			this.Controls.Add(this.genreLabel);
			this.Controls.Add(this.labelNotification);
			this.Controls.Add(this.textBoxYear);
			this.Controls.Add(this.textBoxFirstName);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.labelYear);
			this.Controls.Add(this.labelAuthor);
			this.Controls.Add(this.labelTitle);
			this.MaximizeBox = false;
			this.Name = "ViewBookForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ViewBookForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
