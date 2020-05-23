namespace LibrarySystem
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxBorrowerId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonShowBorrower;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView booksListView;
		private System.Windows.Forms.ColumnHeader titleColumnHeader;
		private System.Windows.Forms.ColumnHeader authorColumnHeader;
		private System.Windows.Forms.ColumnHeader checkoutDateColumnHeader;
		private System.Windows.Forms.ColumnHeader returnDateColumnHeader;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBoxCheckoutId;
		private System.Windows.Forms.Label labelCheckoutId;
		private System.Windows.Forms.GroupBox groupBox4;
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
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxDob;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label labelInfoNotification;
		private System.Windows.Forms.Button buttonAddBook;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelShowNotification = new System.Windows.Forms.Label();
			this.buttonShowBorrower = new System.Windows.Forms.Button();
			this.textBoxBorrowerId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.labelInfoNotification = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.textBoxDob = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.labelCheckoutNotification = new System.Windows.Forms.Label();
			this.labelWeeks = new System.Windows.Forms.Label();
			this.textBoxWeeks = new System.Windows.Forms.TextBox();
			this.buttonCheckout = new System.Windows.Forms.Button();
			this.textBoxCheckoutId = new System.Windows.Forms.TextBox();
			this.labelCheckoutId = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.labelReturnNotification = new System.Windows.Forms.Label();
			this.buttonReturn = new System.Windows.Forms.Button();
			this.textBoxReturnId = new System.Windows.Forms.TextBox();
			this.labelReturnId = new System.Windows.Forms.Label();
			this.buttonAddBorrower = new System.Windows.Forms.Button();
			this.buttonViewBook = new System.Windows.Forms.Button();
			this.buttonAddBook = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelShowNotification);
			this.groupBox1.Controls.Add(this.buttonShowBorrower);
			this.groupBox1.Controls.Add(this.textBoxBorrowerId);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(371, 87);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Show Borrower:";
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.labelInfoNotification);
			this.groupBox2.Controls.Add(this.dateTimePicker);
			this.groupBox2.Controls.Add(this.textBoxDob);
			this.groupBox2.Controls.Add(this.textBoxName);
			this.groupBox2.Controls.Add(this.buttonRemove);
			this.groupBox2.Controls.Add(this.buttonEdit);
			this.groupBox2.Controls.Add(this.labelDob);
			this.groupBox2.Controls.Add(this.labelName);
			this.groupBox2.Location = new System.Drawing.Point(12, 105);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(371, 118);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Borrower Information:";
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
			this.dateTimePicker.Location = new System.Drawing.Point(209, 52);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(156, 22);
			this.dateTimePicker.TabIndex = 9;
			this.dateTimePicker.Visible = false;
			// 
			// textBoxDob
			// 
			this.textBoxDob.Location = new System.Drawing.Point(209, 52);
			this.textBoxDob.Name = "textBoxDob";
			this.textBoxDob.ReadOnly = true;
			this.textBoxDob.Size = new System.Drawing.Size(156, 22);
			this.textBoxDob.TabIndex = 11;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(209, 23);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ReadOnly = true;
			this.textBoxName.Size = new System.Drawing.Size(154, 22);
			this.textBoxName.TabIndex = 10;
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
			this.booksListView.Location = new System.Drawing.Point(12, 229);
			this.booksListView.Name = "booksListView";
			this.booksListView.Size = new System.Drawing.Size(668, 128);
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
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.labelCheckoutNotification);
			this.groupBox3.Controls.Add(this.labelWeeks);
			this.groupBox3.Controls.Add(this.textBoxWeeks);
			this.groupBox3.Controls.Add(this.buttonCheckout);
			this.groupBox3.Controls.Add(this.textBoxCheckoutId);
			this.groupBox3.Controls.Add(this.labelCheckoutId);
			this.groupBox3.ForeColor = System.Drawing.Color.Black;
			this.groupBox3.Location = new System.Drawing.Point(389, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(291, 120);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Checkout:";
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
			this.labelWeeks.Location = new System.Drawing.Point(6, 55);
			this.labelWeeks.Name = "labelWeeks";
			this.labelWeeks.Size = new System.Drawing.Size(128, 23);
			this.labelWeeks.TabIndex = 4;
			this.labelWeeks.Text = "No. weeks:";
			// 
			// textBoxWeeks
			// 
			this.textBoxWeeks.Enabled = false;
			this.textBoxWeeks.Location = new System.Drawing.Point(142, 52);
			this.textBoxWeeks.Name = "textBoxWeeks";
			this.textBoxWeeks.Size = new System.Drawing.Size(139, 22);
			this.textBoxWeeks.TabIndex = 3;
			// 
			// buttonCheckout
			// 
			this.buttonCheckout.Enabled = false;
			this.buttonCheckout.Location = new System.Drawing.Point(206, 82);
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
			this.textBoxCheckoutId.Location = new System.Drawing.Point(142, 23);
			this.textBoxCheckoutId.Name = "textBoxCheckoutId";
			this.textBoxCheckoutId.Size = new System.Drawing.Size(139, 22);
			this.textBoxCheckoutId.TabIndex = 1;
			// 
			// labelCheckoutId
			// 
			this.labelCheckoutId.Location = new System.Drawing.Point(7, 26);
			this.labelCheckoutId.Name = "labelCheckoutId";
			this.labelCheckoutId.Size = new System.Drawing.Size(129, 23);
			this.labelCheckoutId.TabIndex = 0;
			this.labelCheckoutId.Text = "Book ID:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.labelReturnNotification);
			this.groupBox4.Controls.Add(this.buttonReturn);
			this.groupBox4.Controls.Add(this.textBoxReturnId);
			this.groupBox4.Controls.Add(this.labelReturnId);
			this.groupBox4.Location = new System.Drawing.Point(389, 131);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(291, 92);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Return:";
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
			this.buttonReturn.Location = new System.Drawing.Point(206, 54);
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
			this.textBoxReturnId.Location = new System.Drawing.Point(140, 23);
			this.textBoxReturnId.Name = "textBoxReturnId";
			this.textBoxReturnId.Size = new System.Drawing.Size(139, 22);
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
			this.buttonAddBorrower.Location = new System.Drawing.Point(12, 363);
			this.buttonAddBorrower.Name = "buttonAddBorrower";
			this.buttonAddBorrower.Size = new System.Drawing.Size(103, 23);
			this.buttonAddBorrower.TabIndex = 5;
			this.buttonAddBorrower.Text = "Add Borrower";
			this.buttonAddBorrower.UseVisualStyleBackColor = true;
			this.buttonAddBorrower.Click += new System.EventHandler(this.ButtonAddBorrowerClick);
			// 
			// buttonViewBook
			// 
			this.buttonViewBook.Location = new System.Drawing.Point(569, 363);
			this.buttonViewBook.Name = "buttonViewBook";
			this.buttonViewBook.Size = new System.Drawing.Size(111, 23);
			this.buttonViewBook.TabIndex = 8;
			this.buttonViewBook.Text = "View/Edit Book";
			this.buttonViewBook.UseVisualStyleBackColor = true;
			this.buttonViewBook.Click += new System.EventHandler(this.ButtonViewBookClick);
			// 
			// buttonAddBook
			// 
			this.buttonAddBook.Location = new System.Drawing.Point(329, 363);
			this.buttonAddBook.Name = "buttonAddBook";
			this.buttonAddBook.Size = new System.Drawing.Size(82, 23);
			this.buttonAddBook.TabIndex = 9;
			this.buttonAddBook.Text = "Add Book";
			this.buttonAddBook.UseVisualStyleBackColor = true;
			this.buttonAddBook.Click += new System.EventHandler(this.ButtonAddBookClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 396);
			this.Controls.Add(this.buttonAddBook);
			this.Controls.Add(this.buttonViewBook);
			this.Controls.Add(this.buttonAddBorrower);
			this.Controls.Add(this.booksListView);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Borrower Information";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

	}
}