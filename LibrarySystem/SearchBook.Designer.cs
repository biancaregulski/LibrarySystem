/*
 * Created by SharpDevelop.
 * User: Bianca
 * Date: 5/24/2020
 * Time: 3:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LibrarySystem
{
	partial class SearchBook
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.ComboBox comboBoxGenre;
		private System.Windows.Forms.Label genreLabel;
		private System.Windows.Forms.MaskedTextBox textBoxYear;
		private System.Windows.Forms.TextBox textBoxFirstName;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.Label labelYear;
		private System.Windows.Forms.Label labelAuthor;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Button buttonShowAll;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripBorrowers;
		private System.Windows.Forms.ColumnHeader IdcolumnHeader;
		private System.Windows.Forms.ColumnHeader titleColumnHeader;
		private System.Windows.Forms.ColumnHeader authorColumnHeader;
		private System.Windows.Forms.ColumnHeader yearColumnHeader;
		private System.Windows.Forms.ColumnHeader avaliableColumnHeader;
		private System.Windows.Forms.ListView listViewBooks;
		private System.Windows.Forms.ColumnHeader genreColumnHeader;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.Label labelNotification;
		
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
			this.components = new System.ComponentModel.Container();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.comboBoxGenre = new System.Windows.Forms.ComboBox();
			this.genreLabel = new System.Windows.Forms.Label();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.labelYear = new System.Windows.Forms.Label();
			this.labelAuthor = new System.Windows.Forms.Label();
			this.labelTitle = new System.Windows.Forms.Label();
			this.buttonShowAll = new System.Windows.Forms.Button();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.contextMenuStripBorrowers = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listViewBooks = new System.Windows.Forms.ListView();
			this.IdcolumnHeader = new System.Windows.Forms.ColumnHeader();
			this.titleColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.authorColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.yearColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.genreColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.avaliableColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.textBoxYear = new System.Windows.Forms.MaskedTextBox();
			this.labelNotification = new System.Windows.Forms.Label();
			this.contextMenuStripBorrowers.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(232, 11);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(107, 22);
			this.textBoxLastName.TabIndex = 15;
			// 
			// comboBoxGenre
			// 
			this.comboBoxGenre.FormattingEnabled = true;
			this.comboBoxGenre.Items.AddRange(new object[] {
			"",
			"Fiction",
			"Non-Fiction"});
			this.comboBoxGenre.Location = new System.Drawing.Point(474, 39);
			this.comboBoxGenre.Name = "comboBoxGenre";
			this.comboBoxGenre.Size = new System.Drawing.Size(156, 24);
			this.comboBoxGenre.TabIndex = 18;
			// 
			// genreLabel
			// 
			this.genreLabel.Location = new System.Drawing.Point(345, 42);
			this.genreLabel.Name = "genreLabel";
			this.genreLabel.Size = new System.Drawing.Size(100, 23);
			this.genreLabel.TabIndex = 13;
			this.genreLabel.Text = "Genre:";
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(118, 11);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(107, 22);
			this.textBoxFirstName.TabIndex = 14;
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(119, 39);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(220, 22);
			this.textBoxTitle.TabIndex = 16;
			// 
			// labelYear
			// 
			this.labelYear.Location = new System.Drawing.Point(345, 14);
			this.labelYear.Name = "labelYear";
			this.labelYear.Size = new System.Drawing.Size(100, 23);
			this.labelYear.TabIndex = 12;
			this.labelYear.Text = "Year:";
			// 
			// labelAuthor
			// 
			this.labelAuthor.Location = new System.Drawing.Point(12, 14);
			this.labelAuthor.Name = "labelAuthor";
			this.labelAuthor.Size = new System.Drawing.Size(100, 23);
			this.labelAuthor.TabIndex = 10;
			this.labelAuthor.Text = "Author:";
			// 
			// labelTitle
			// 
			this.labelTitle.Location = new System.Drawing.Point(12, 42);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(118, 23);
			this.labelTitle.TabIndex = 11;
			this.labelTitle.Text = "Title:";
			// 
			// buttonShowAll
			// 
			this.buttonShowAll.Location = new System.Drawing.Point(474, 69);
			this.buttonShowAll.Name = "buttonShowAll";
			this.buttonShowAll.Size = new System.Drawing.Size(75, 23);
			this.buttonShowAll.TabIndex = 21;
			this.buttonShowAll.Text = "Show All";
			this.buttonShowAll.UseVisualStyleBackColor = true;
			this.buttonShowAll.Click += new System.EventHandler(this.ButtonShowAllClick);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(555, 69);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 20;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
			// 
			// contextMenuStripBorrowers
			// 
			this.contextMenuStripBorrowers.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStripBorrowers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.removeToolStripMenuItem});
			this.contextMenuStripBorrowers.Name = "contextMenuStripBorrowers";
			this.contextMenuStripBorrowers.Size = new System.Drawing.Size(176, 56);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItemClick);
			// 
			// listViewBooks
			// 
			this.listViewBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.IdcolumnHeader,
			this.titleColumnHeader,
			this.authorColumnHeader,
			this.yearColumnHeader,
			this.genreColumnHeader,
			this.avaliableColumnHeader});
			this.listViewBooks.ContextMenuStrip = this.contextMenuStripBorrowers;
			this.listViewBooks.FullRowSelect = true;
			this.listViewBooks.GridLines = true;
			this.listViewBooks.HideSelection = false;
			this.listViewBooks.Location = new System.Drawing.Point(12, 98);
			this.listViewBooks.MultiSelect = false;
			this.listViewBooks.Name = "listViewBooks";
			this.listViewBooks.Size = new System.Drawing.Size(618, 128);
			this.listViewBooks.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewBooks.TabIndex = 23;
			this.listViewBooks.UseCompatibleStateImageBehavior = false;
			this.listViewBooks.View = System.Windows.Forms.View.Details;
			// 
			// IdcolumnHeader
			// 
			this.IdcolumnHeader.Text = "ID";
			this.IdcolumnHeader.Width = 55;
			// 
			// titleColumnHeader
			// 
			this.titleColumnHeader.Text = "Title";
			this.titleColumnHeader.Width = 172;
			// 
			// authorColumnHeader
			// 
			this.authorColumnHeader.Text = "Author";
			this.authorColumnHeader.Width = 146;
			// 
			// yearColumnHeader
			// 
			this.yearColumnHeader.Text = "Year";
			this.yearColumnHeader.Width = 62;
			// 
			// genreColumnHeader
			// 
			this.genreColumnHeader.Text = "Genre";
			this.genreColumnHeader.Width = 85;
			// 
			// avaliableColumnHeader
			// 
			this.avaliableColumnHeader.Text = "Avaliable?";
			this.avaliableColumnHeader.Width = 94;
			// 
			// textBoxYear
			// 
			this.textBoxYear.Location = new System.Drawing.Point(474, 11);
			this.textBoxYear.Name = "textBoxYear";
			this.textBoxYear.Size = new System.Drawing.Size(156, 22);
			this.textBoxYear.TabIndex = 24;
			// 
			// labelNotification
			// 
			this.labelNotification.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelNotification.Location = new System.Drawing.Point(12, 69);
			this.labelNotification.Name = "labelNotification";
			this.labelNotification.Size = new System.Drawing.Size(456, 23);
			this.labelNotification.TabIndex = 25;
			// 
			// SearchBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 238);
			this.Controls.Add(this.labelNotification);
			this.Controls.Add(this.textBoxYear);
			this.Controls.Add(this.listViewBooks);
			this.Controls.Add(this.buttonShowAll);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxLastName);
			this.Controls.Add(this.comboBoxGenre);
			this.Controls.Add(this.genreLabel);
			this.Controls.Add(this.textBoxFirstName);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.labelYear);
			this.Controls.Add(this.labelAuthor);
			this.Controls.Add(this.labelTitle);
			this.MaximizeBox = false;
			this.Name = "SearchBook";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SearchBook";
			this.contextMenuStripBorrowers.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
