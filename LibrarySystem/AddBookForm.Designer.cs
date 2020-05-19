namespace LibrarySystem
{
	partial class AddBookForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelAuthor;
		private System.Windows.Forms.Label labelYear;
		private System.Windows.Forms.TextBox textBoxFirstName;
		private System.Windows.Forms.TextBox textBoxYear;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.Label labelNotification;
		private System.Windows.Forms.Label genreLabel;
		private System.Windows.Forms.ComboBox comboBoxGenre;
		private System.Windows.Forms.TextBox textBoxLastName;
		private void InitializeComponent()
		{
			this.buttonOk = new System.Windows.Forms.Button();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelAuthor = new System.Windows.Forms.Label();
			this.labelYear = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.textBoxYear = new System.Windows.Forms.TextBox();
			this.labelNotification = new System.Windows.Forms.Label();
			this.genreLabel = new System.Windows.Forms.Label();
			this.comboBoxGenre = new System.Windows.Forms.ComboBox();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(281, 135);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 10;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// labelTitle
			// 
			this.labelTitle.Location = new System.Drawing.Point(12, 45);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(118, 23);
			this.labelTitle.TabIndex = 2;
			this.labelTitle.Text = "Title:";
			// 
			// labelAuthor
			// 
			this.labelAuthor.Location = new System.Drawing.Point(12, 17);
			this.labelAuthor.Name = "labelAuthor";
			this.labelAuthor.Size = new System.Drawing.Size(100, 23);
			this.labelAuthor.TabIndex = 1;
			this.labelAuthor.Text = "Author:";
			// 
			// labelYear
			// 
			this.labelYear.Location = new System.Drawing.Point(12, 74);
			this.labelYear.Name = "labelYear";
			this.labelYear.Size = new System.Drawing.Size(100, 23);
			this.labelYear.TabIndex = 3;
			this.labelYear.Text = "Year:";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(136, 42);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(220, 22);
			this.textBoxTitle.TabIndex = 7;
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(135, 14);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(107, 22);
			this.textBoxFirstName.TabIndex = 5;
			// 
			// textBoxYear
			// 
			this.textBoxYear.Location = new System.Drawing.Point(135, 71);
			this.textBoxYear.Name = "textBoxYear";
			this.textBoxYear.Size = new System.Drawing.Size(221, 22);
			this.textBoxYear.TabIndex = 8;
			// 
			// labelNotification
			// 
			this.labelNotification.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelNotification.Location = new System.Drawing.Point(12, 138);
			this.labelNotification.Name = "labelNotification";
			this.labelNotification.Size = new System.Drawing.Size(263, 23);
			this.labelNotification.TabIndex = 7;
			// 
			// genreLabel
			// 
			this.genreLabel.Location = new System.Drawing.Point(12, 102);
			this.genreLabel.Name = "genreLabel";
			this.genreLabel.Size = new System.Drawing.Size(100, 23);
			this.genreLabel.TabIndex = 4;
			this.genreLabel.Text = "Genre:";
			// 
			// comboBoxGenre
			// 
			this.comboBoxGenre.FormattingEnabled = true;
			this.comboBoxGenre.Items.AddRange(new object[] {
			"Fiction",
			"Non-fiction"});
			this.comboBoxGenre.Location = new System.Drawing.Point(135, 99);
			this.comboBoxGenre.Name = "comboBoxGenre";
			this.comboBoxGenre.Size = new System.Drawing.Size(221, 24);
			this.comboBoxGenre.TabIndex = 9;
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(249, 14);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(107, 22);
			this.textBoxLastName.TabIndex = 6;
			// 
			// AddBookForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 170);
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
			this.Controls.Add(this.buttonOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "AddBookForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Book";
			this.Load += new System.EventHandler(this.AddBookFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
