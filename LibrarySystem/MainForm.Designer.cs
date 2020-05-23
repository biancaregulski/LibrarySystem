﻿namespace LibrarySystem
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBoxShow;
		private System.Windows.Forms.TextBox textBoxBorrowerId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonShowBorrower;
		private System.Windows.Forms.GroupBox groupBoxInfo;
		private System.Windows.Forms.ListView booksListView;
		private System.Windows.Forms.ColumnHeader titleColumnHeader;
		private System.Windows.Forms.ColumnHeader authorColumnHeader;
		private System.Windows.Forms.ColumnHeader checkoutDateColumnHeader;
		private System.Windows.Forms.ColumnHeader returnDateColumnHeader;
		private System.Windows.Forms.GroupBox groupBoxCheckout;
		private System.Windows.Forms.TextBox textBoxCheckoutId;
		private System.Windows.Forms.Label labelCheckoutId;
		private System.Windows.Forms.GroupBox groupBoxReturn;
		private System.Windows.Forms.Label labelWeeks;
		private System.Windows.Forms.TextBox textBoxReturnId;
		private System.Windows.Forms.Button buttonReturn;
		private System.Windows.Forms.Label labelShowNotification;
		private System.Windows.Forms.Label labelCheckoutNotification;
		private System.Windows.Forms.Label labelReturnNotification;
		private System.Windows.Forms.ColumnHeader yearColumnHeader;
		private System.Windows.Forms.Label labelDob;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelReturnId;
		private System.Windows.Forms.Button buttonCheckout;
		private System.Windows.Forms.TextBox textBoxWeeks;
		private System.Windows.Forms.Button buttonAddBorrower;
		private System.Windows.Forms.Button buttonViewBook;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.TextBox textBoxDob;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label labelInfoNotification;
		private System.Windows.Forms.Button buttonAddBook;
		private System.Windows.Forms.Button buttonSearchBorrower;
		private System.Windows.Forms.Button buttonSearchBook;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.TextBox textBoxFirstName;
		private System.Windows.Forms.GroupBox groupBoxTable;
		
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
		private void InitializeComponent()
		{
			this.groupBoxShow = new System.Windows.Forms.GroupBox();
			this.labelShowNotification = new System.Windows.Forms.Label();
			this.buttonShowBorrower = new System.Windows.Forms.Button();
			this.textBoxBorrowerId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonSearchBorrower = new System.Windows.Forms.Button();
			this.groupBoxInfo = new System.Windows.Forms.GroupBox();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.labelInfoNotification = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.textBoxDob = new System.Windows.Forms.TextBox();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.labelDob = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.booksListView = new System.Windows.Forms.ListView();
			this.titleColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.authorColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.yearColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.checkoutDateColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.returnDateColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.groupBoxCheckout = new System.Windows.Forms.GroupBox();
			this.labelCheckoutNotification = new System.Windows.Forms.Label();
			this.labelWeeks = new System.Windows.Forms.Label();
			this.textBoxWeeks = new System.Windows.Forms.TextBox();
			this.buttonCheckout = new System.Windows.Forms.Button();
			this.textBoxCheckoutId = new System.Windows.Forms.TextBox();
			this.labelCheckoutId = new System.Windows.Forms.Label();
			this.buttonSearchBook = new System.Windows.Forms.Button();
			this.groupBoxReturn = new System.Windows.Forms.GroupBox();
			this.labelReturnNotification = new System.Windows.Forms.Label();
			this.buttonReturn = new System.Windows.Forms.Button();
			this.textBoxReturnId = new System.Windows.Forms.TextBox();
			this.labelReturnId = new System.Windows.Forms.Label();
			this.buttonAddBorrower = new System.Windows.Forms.Button();
			this.buttonViewBook = new System.Windows.Forms.Button();
			this.buttonAddBook = new System.Windows.Forms.Button();
			this.groupBoxTable = new System.Windows.Forms.GroupBox();
			this.groupBoxShow.SuspendLayout();
			this.groupBoxInfo.SuspendLayout();
			this.groupBoxCheckout.SuspendLayout();
			this.groupBoxReturn.SuspendLayout();
			this.groupBoxTable.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxShow
			// 
			this.groupBoxShow.Controls.Add(this.labelShowNotification);
			this.groupBoxShow.Controls.Add(this.buttonShowBorrower);
			this.groupBoxShow.Controls.Add(this.textBoxBorrowerId);
			this.groupBoxShow.Controls.Add(this.label1);
			this.groupBoxShow.Location = new System.Drawing.Point(12, 12);
			this.groupBoxShow.Name = "groupBoxShow";
			this.groupBoxShow.Size = new System.Drawing.Size(371, 87);
			this.groupBoxShow.TabIndex = 0;
			this.groupBoxShow.TabStop = false;
			this.groupBoxShow.Text = "Show Borrower:";
			// 
			// labelShowNotification
			// 
			this.labelShowNotification.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelShowNotification.Location = new System.Drawing.Point(7, 54);
			this.labelShowNotification.Name = "labelShowNotification";
			this.labelShowNotification.Size = new System.Drawing.Size(275, 23);
			this.labelShowNotification.TabIndex = 3;
			// 
			// buttonShowBorrower
			// 
			this.buttonShowBorrower.Location = new System.Drawing.Point(288, 52);
			this.buttonShowBorrower.Name = "buttonShowBorrower";
			this.buttonShowBorrower.Size = new System.Drawing.Size(75, 23);
			this.buttonShowBorrower.TabIndex = 2;
			this.buttonShowBorrower.Text = "OK";
			this.buttonShowBorrower.UseVisualStyleBackColor = true;
			this.buttonShowBorrower.Click += new System.EventHandler(this.ButtonShowBorrowerClick);
			// 
			// textBoxBorrowerId
			// 
			this.textBoxBorrowerId.Location = new System.Drawing.Point(177, 23);
			this.textBoxBorrowerId.Name = "textBoxBorrowerId";
			this.textBoxBorrowerId.Size = new System.Drawing.Size(186, 22);
			this.textBoxBorrowerId.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Borrower ID:";
			// 
			// buttonSearchBorrower
			// 
			this.buttonSearchBorrower.Location = new System.Drawing.Point(168, 391);
			this.buttonSearchBorrower.Name = "buttonSearchBorrower";
			this.buttonSearchBorrower.Size = new System.Drawing.Size(126, 23);
			this.buttonSearchBorrower.TabIndex = 4;
			this.buttonSearchBorrower.Text = "Search Borrower";
			this.buttonSearchBorrower.UseVisualStyleBackColor = true;
			this.buttonSearchBorrower.Click += new System.EventHandler(this.ButtonSearchBorrowerClick);
			// 
			// groupBoxInfo
			// 
			this.groupBoxInfo.Controls.Add(this.textBoxFirstName);
			this.groupBoxInfo.Controls.Add(this.labelInfoNotification);
			this.groupBoxInfo.Controls.Add(this.textBoxLastName);
			this.groupBoxInfo.Controls.Add(this.buttonRemove);
			this.groupBoxInfo.Controls.Add(this.buttonEdit);
			this.groupBoxInfo.Controls.Add(this.labelDob);
			this.groupBoxInfo.Controls.Add(this.labelName);
			this.groupBoxInfo.Controls.Add(this.dateTimePicker);
			this.groupBoxInfo.Controls.Add(this.textBoxDob);
			this.groupBoxInfo.Location = new System.Drawing.Point(12, 105);
			this.groupBoxInfo.Name = "groupBoxInfo";
			this.groupBoxInfo.Size = new System.Drawing.Size(371, 118);
			this.groupBoxInfo.TabIndex = 1;
			this.groupBoxInfo.TabStop = false;
			this.groupBoxInfo.Text = "Borrower Information:";
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(177, 24);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.ReadOnly = true;
			this.textBoxFirstName.Size = new System.Drawing.Size(94, 22);
			this.textBoxFirstName.TabIndex = 13;
			// 
			// labelInfoNotification
			// 
			this.labelInfoNotification.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelInfoNotification.Location = new System.Drawing.Point(7, 80);
			this.labelInfoNotification.Name = "labelInfoNotification";
			this.labelInfoNotification.Size = new System.Drawing.Size(194, 23);
			this.labelInfoNotification.TabIndex = 12;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker.Location = new System.Drawing.Point(177, 52);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(188, 22);
			this.dateTimePicker.TabIndex = 9;
			this.dateTimePicker.Visible = false;
			// 
			// textBoxDob
			// 
			this.textBoxDob.Location = new System.Drawing.Point(177, 52);
			this.textBoxDob.Name = "textBoxDob";
			this.textBoxDob.ReadOnly = true;
			this.textBoxDob.Size = new System.Drawing.Size(188, 22);
			this.textBoxDob.TabIndex = 11;
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(277, 23);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.ReadOnly = true;
			this.textBoxLastName.Size = new System.Drawing.Size(86, 22);
			this.textBoxLastName.TabIndex = 10;
			// 
			// buttonRemove
			// 
			this.buttonRemove.Enabled = false;
			this.buttonRemove.Location = new System.Drawing.Point(209, 80);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(75, 23);
			this.buttonRemove.TabIndex = 9;
			this.buttonRemove.Text = "Remove";
			this.buttonRemove.UseVisualStyleBackColor = true;
			this.buttonRemove.Click += new System.EventHandler(this.ButtonRemoveClick);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Enabled = false;
			this.buttonEdit.Location = new System.Drawing.Point(290, 80);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(75, 23);
			this.buttonEdit.TabIndex = 7;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.ButtonNameEditClick);
			// 
			// labelDob
			// 
			this.labelDob.Location = new System.Drawing.Point(7, 52);
			this.labelDob.Name = "labelDob";
			this.labelDob.Size = new System.Drawing.Size(100, 23);
			this.labelDob.TabIndex = 1;
			this.labelDob.Text = "DOB:";
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(6, 26);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(100, 23);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name:";
			// 
			// booksListView
			// 
			this.booksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.titleColumnHeader,
			this.authorColumnHeader,
			this.yearColumnHeader,
			this.checkoutDateColumnHeader,
			this.returnDateColumnHeader});
			this.booksListView.FullRowSelect = true;
			this.booksListView.GridLines = true;
			this.booksListView.HideSelection = false;
			this.booksListView.Location = new System.Drawing.Point(16, 21);
			this.booksListView.Name = "booksListView";
			this.booksListView.Size = new System.Drawing.Size(688, 122);
			this.booksListView.TabIndex = 2;
			this.booksListView.UseCompatibleStateImageBehavior = false;
			this.booksListView.View = System.Windows.Forms.View.Details;
			// 
			// titleColumnHeader
			// 
			this.titleColumnHeader.Text = "Title";
			this.titleColumnHeader.Width = 164;
			// 
			// authorColumnHeader
			// 
			this.authorColumnHeader.Text = "Author";
			this.authorColumnHeader.Width = 160;
			// 
			// yearColumnHeader
			// 
			this.yearColumnHeader.Text = "Year";
			this.yearColumnHeader.Width = 73;
			// 
			// checkoutDateColumnHeader
			// 
			this.checkoutDateColumnHeader.Text = "Checkout Date";
			this.checkoutDateColumnHeader.Width = 140;
			// 
			// returnDateColumnHeader
			// 
			this.returnDateColumnHeader.Text = "Return Date";
			this.returnDateColumnHeader.Width = 127;
			// 
			// groupBoxCheckout
			// 
			this.groupBoxCheckout.Controls.Add(this.labelCheckoutNotification);
			this.groupBoxCheckout.Controls.Add(this.labelWeeks);
			this.groupBoxCheckout.Controls.Add(this.textBoxWeeks);
			this.groupBoxCheckout.Controls.Add(this.buttonCheckout);
			this.groupBoxCheckout.Controls.Add(this.textBoxCheckoutId);
			this.groupBoxCheckout.Controls.Add(this.labelCheckoutId);
			this.groupBoxCheckout.ForeColor = System.Drawing.Color.Black;
			this.groupBoxCheckout.Location = new System.Drawing.Point(389, 12);
			this.groupBoxCheckout.Name = "groupBoxCheckout";
			this.groupBoxCheckout.Size = new System.Drawing.Size(343, 120);
			this.groupBoxCheckout.TabIndex = 2;
			this.groupBoxCheckout.TabStop = false;
			this.groupBoxCheckout.Text = "Checkout:";
			// 
			// labelCheckoutNotification
			// 
			this.labelCheckoutNotification.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelCheckoutNotification.Location = new System.Drawing.Point(6, 82);
			this.labelCheckoutNotification.Name = "labelCheckoutNotification";
			this.labelCheckoutNotification.Size = new System.Drawing.Size(199, 23);
			this.labelCheckoutNotification.TabIndex = 5;
			// 
			// labelWeeks
			// 
			this.labelWeeks.Location = new System.Drawing.Point(6, 52);
			this.labelWeeks.Name = "labelWeeks";
			this.labelWeeks.Size = new System.Drawing.Size(128, 23);
			this.labelWeeks.TabIndex = 4;
			this.labelWeeks.Text = "No. weeks:";
			// 
			// textBoxWeeks
			// 
			this.textBoxWeeks.Enabled = false;
			this.textBoxWeeks.Location = new System.Drawing.Point(151, 48);
			this.textBoxWeeks.Name = "textBoxWeeks";
			this.textBoxWeeks.Size = new System.Drawing.Size(186, 22);
			this.textBoxWeeks.TabIndex = 3;
			// 
			// buttonCheckout
			// 
			this.buttonCheckout.Enabled = false;
			this.buttonCheckout.Location = new System.Drawing.Point(262, 82);
			this.buttonCheckout.Name = "buttonCheckout";
			this.buttonCheckout.Size = new System.Drawing.Size(75, 23);
			this.buttonCheckout.TabIndex = 2;
			this.buttonCheckout.Text = "OK";
			this.buttonCheckout.UseVisualStyleBackColor = true;
			this.buttonCheckout.Click += new System.EventHandler(this.ButtonCheckoutClick);
			// 
			// textBoxCheckoutId
			// 
			this.textBoxCheckoutId.Enabled = false;
			this.textBoxCheckoutId.Location = new System.Drawing.Point(151, 20);
			this.textBoxCheckoutId.Name = "textBoxCheckoutId";
			this.textBoxCheckoutId.Size = new System.Drawing.Size(186, 22);
			this.textBoxCheckoutId.TabIndex = 1;
			// 
			// labelCheckoutId
			// 
			this.labelCheckoutId.Location = new System.Drawing.Point(6, 23);
			this.labelCheckoutId.Name = "labelCheckoutId";
			this.labelCheckoutId.Size = new System.Drawing.Size(129, 23);
			this.labelCheckoutId.TabIndex = 0;
			this.labelCheckoutId.Text = "Book ID:";
			// 
			// buttonSearchBook
			// 
			this.buttonSearchBook.Location = new System.Drawing.Point(478, 391);
			this.buttonSearchBook.Name = "buttonSearchBook";
			this.buttonSearchBook.Size = new System.Drawing.Size(105, 23);
			this.buttonSearchBook.TabIndex = 6;
			this.buttonSearchBook.Text = "Search Book";
			this.buttonSearchBook.UseVisualStyleBackColor = true;
			// 
			// groupBoxReturn
			// 
			this.groupBoxReturn.Controls.Add(this.labelReturnNotification);
			this.groupBoxReturn.Controls.Add(this.buttonReturn);
			this.groupBoxReturn.Controls.Add(this.textBoxReturnId);
			this.groupBoxReturn.Controls.Add(this.labelReturnId);
			this.groupBoxReturn.Location = new System.Drawing.Point(389, 131);
			this.groupBoxReturn.Name = "groupBoxReturn";
			this.groupBoxReturn.Size = new System.Drawing.Size(343, 92);
			this.groupBoxReturn.TabIndex = 3;
			this.groupBoxReturn.TabStop = false;
			this.groupBoxReturn.Text = "Return:";
			// 
			// labelReturnNotification
			// 
			this.labelReturnNotification.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelReturnNotification.Location = new System.Drawing.Point(6, 54);
			this.labelReturnNotification.Name = "labelReturnNotification";
			this.labelReturnNotification.Size = new System.Drawing.Size(188, 23);
			this.labelReturnNotification.TabIndex = 3;
			// 
			// buttonReturn
			// 
			this.buttonReturn.Enabled = false;
			this.buttonReturn.Location = new System.Drawing.Point(262, 54);
			this.buttonReturn.Name = "buttonReturn";
			this.buttonReturn.Size = new System.Drawing.Size(75, 23);
			this.buttonReturn.TabIndex = 2;
			this.buttonReturn.Text = "OK";
			this.buttonReturn.UseVisualStyleBackColor = true;
			this.buttonReturn.Click += new System.EventHandler(this.ButtonReturnClick);
			// 
			// textBoxReturnId
			// 
			this.textBoxReturnId.Enabled = false;
			this.textBoxReturnId.Location = new System.Drawing.Point(151, 23);
			this.textBoxReturnId.Name = "textBoxReturnId";
			this.textBoxReturnId.Size = new System.Drawing.Size(186, 22);
			this.textBoxReturnId.TabIndex = 1;
			// 
			// labelReturnId
			// 
			this.labelReturnId.Location = new System.Drawing.Point(6, 26);
			this.labelReturnId.Name = "labelReturnId";
			this.labelReturnId.Size = new System.Drawing.Size(128, 23);
			this.labelReturnId.TabIndex = 0;
			this.labelReturnId.Text = "Book ID:";
			// 
			// buttonAddBorrower
			// 
			this.buttonAddBorrower.Location = new System.Drawing.Point(12, 391);
			this.buttonAddBorrower.Name = "buttonAddBorrower";
			this.buttonAddBorrower.Size = new System.Drawing.Size(103, 23);
			this.buttonAddBorrower.TabIndex = 5;
			this.buttonAddBorrower.Text = "Add Borrower";
			this.buttonAddBorrower.UseVisualStyleBackColor = true;
			this.buttonAddBorrower.Click += new System.EventHandler(this.ButtonAddBorrowerClick);
			// 
			// buttonViewBook
			// 
			this.buttonViewBook.Location = new System.Drawing.Point(621, 391);
			this.buttonViewBook.Name = "buttonViewBook";
			this.buttonViewBook.Size = new System.Drawing.Size(111, 23);
			this.buttonViewBook.TabIndex = 8;
			this.buttonViewBook.Text = "View/Edit Book";
			this.buttonViewBook.UseVisualStyleBackColor = true;
			this.buttonViewBook.Click += new System.EventHandler(this.ButtonViewBookClick);
			// 
			// buttonAddBook
			// 
			this.buttonAddBook.Location = new System.Drawing.Point(329, 391);
			this.buttonAddBook.Name = "buttonAddBook";
			this.buttonAddBook.Size = new System.Drawing.Size(82, 23);
			this.buttonAddBook.TabIndex = 9;
			this.buttonAddBook.Text = "Add Book";
			this.buttonAddBook.UseVisualStyleBackColor = true;
			this.buttonAddBook.Click += new System.EventHandler(this.ButtonAddBookClick);
			// 
			// groupBoxTable
			// 
			this.groupBoxTable.Controls.Add(this.booksListView);
			this.groupBoxTable.Location = new System.Drawing.Point(13, 230);
			this.groupBoxTable.Name = "groupBoxTable";
			this.groupBoxTable.Size = new System.Drawing.Size(719, 155);
			this.groupBoxTable.TabIndex = 10;
			this.groupBoxTable.TabStop = false;
			this.groupBoxTable.Text = "Checked out books:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 425);
			this.Controls.Add(this.groupBoxTable);
			this.Controls.Add(this.buttonSearchBook);
			this.Controls.Add(this.buttonSearchBorrower);
			this.Controls.Add(this.buttonAddBook);
			this.Controls.Add(this.buttonViewBook);
			this.Controls.Add(this.buttonAddBorrower);
			this.Controls.Add(this.groupBoxReturn);
			this.Controls.Add(this.groupBoxCheckout);
			this.Controls.Add(this.groupBoxInfo);
			this.Controls.Add(this.groupBoxShow);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Borrower Information";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBoxShow.ResumeLayout(false);
			this.groupBoxShow.PerformLayout();
			this.groupBoxInfo.ResumeLayout(false);
			this.groupBoxInfo.PerformLayout();
			this.groupBoxCheckout.ResumeLayout(false);
			this.groupBoxCheckout.PerformLayout();
			this.groupBoxReturn.ResumeLayout(false);
			this.groupBoxReturn.PerformLayout();
			this.groupBoxTable.ResumeLayout(false);
			this.ResumeLayout(false);

		}

	}
}