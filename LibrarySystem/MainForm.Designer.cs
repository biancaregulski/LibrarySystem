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
		private System.Windows.Forms.Label labelDobValue;
		private System.Windows.Forms.Label labelRestrictionValue;
		private System.Windows.Forms.Label labelRestriction;
		private System.Windows.Forms.Label labelDob;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelReturnId;
		private System.Windows.Forms.Button buttonCheckout;
		private System.Windows.Forms.TextBox textBoxWeeks;
		private System.Windows.Forms.Label labelNameValue;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelShowNotification = new System.Windows.Forms.Label();
			this.buttonShowBorrower = new System.Windows.Forms.Button();
			this.textBoxBorrowerId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.labelNameValue = new System.Windows.Forms.Label();
			this.labelRestrictionValue = new System.Windows.Forms.Label();
			this.labelRestriction = new System.Windows.Forms.Label();
			this.labelDobValue = new System.Windows.Forms.Label();
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
			this.groupBox1.Size = new System.Drawing.Size(356, 87);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Show Borrower:";
			// 
			// labelShowNotification
			// 
			this.labelShowNotification.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelShowNotification.Location = new System.Drawing.Point(6, 54);
			this.labelShowNotification.Name = "labelShowNotification";
			this.labelShowNotification.Size = new System.Drawing.Size(249, 23);
			this.labelShowNotification.TabIndex = 3;
			// 
			// buttonShowBorrower
			// 
			this.buttonShowBorrower.Location = new System.Drawing.Point(261, 51);
			this.buttonShowBorrower.Name = "buttonShowBorrower";
			this.buttonShowBorrower.Size = new System.Drawing.Size(75, 23);
			this.buttonShowBorrower.TabIndex = 2;
			this.buttonShowBorrower.Text = "OK";
			this.buttonShowBorrower.UseVisualStyleBackColor = true;
			this.buttonShowBorrower.Click += new System.EventHandler(this.ButtonShowBorrowerClick);
			// 
			// textBoxBorrowerId
			// 
			this.textBoxBorrowerId.Location = new System.Drawing.Point(159, 23);
			this.textBoxBorrowerId.Name = "textBoxBorrowerId";
			this.textBoxBorrowerId.Size = new System.Drawing.Size(178, 22);
			this.textBoxBorrowerId.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Borrower ID:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.labelNameValue);
			this.groupBox2.Controls.Add(this.labelRestrictionValue);
			this.groupBox2.Controls.Add(this.labelRestriction);
			this.groupBox2.Controls.Add(this.labelDobValue);
			this.groupBox2.Controls.Add(this.labelDob);
			this.groupBox2.Controls.Add(this.labelName);
			this.groupBox2.Location = new System.Drawing.Point(12, 105);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(356, 106);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Borrower Information:";
			// 
			// labelNameValue
			// 
			this.labelNameValue.Location = new System.Drawing.Point(159, 25);
			this.labelNameValue.Name = "labelNameValue";
			this.labelNameValue.Size = new System.Drawing.Size(178, 23);
			this.labelNameValue.TabIndex = 6;
			// 
			// labelRestrictionValue
			// 
			this.labelRestrictionValue.Location = new System.Drawing.Point(159, 72);
			this.labelRestrictionValue.Name = "labelRestrictionValue";
			this.labelRestrictionValue.Size = new System.Drawing.Size(178, 23);
			this.labelRestrictionValue.TabIndex = 5;
			// 
			// labelRestriction
			// 
			this.labelRestriction.Location = new System.Drawing.Point(7, 72);
			this.labelRestriction.Name = "labelRestriction";
			this.labelRestriction.Size = new System.Drawing.Size(100, 21);
			this.labelRestriction.TabIndex = 4;
			this.labelRestriction.Text = "Restriction:";
			// 
			// labelDobValue
			// 
			this.labelDobValue.Location = new System.Drawing.Point(158, 49);
			this.labelDobValue.Name = "labelDobValue";
			this.labelDobValue.Size = new System.Drawing.Size(178, 23);
			this.labelDobValue.TabIndex = 3;
			// 
			// labelDob
			// 
			this.labelDob.Location = new System.Drawing.Point(7, 49);
			this.labelDob.Name = "labelDob";
			this.labelDob.Size = new System.Drawing.Size(100, 23);
			this.labelDob.TabIndex = 1;
			this.labelDob.Text = "DOB:";
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(7, 26);
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
			this.booksListView.Location = new System.Drawing.Point(12, 221);
			this.booksListView.Name = "booksListView";
			this.booksListView.Size = new System.Drawing.Size(714, 128);
			this.booksListView.TabIndex = 2;
			this.booksListView.UseCompatibleStateImageBehavior = false;
			this.booksListView.View = System.Windows.Forms.View.Details;
			// 
			// titleColumnHeader
			// 
			this.titleColumnHeader.Text = "Title";
			this.titleColumnHeader.Width = 210;
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
			this.groupBox3.Location = new System.Drawing.Point(374, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(352, 113);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Checkout:";
			// 
			// labelCheckoutNotification
			// 
			this.labelCheckoutNotification.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelCheckoutNotification.Location = new System.Drawing.Point(7, 82);
			this.labelCheckoutNotification.Name = "labelCheckoutNotification";
			this.labelCheckoutNotification.Size = new System.Drawing.Size(258, 23);
			this.labelCheckoutNotification.TabIndex = 5;
			// 
			// labelWeeks
			// 
			this.labelWeeks.Location = new System.Drawing.Point(8, 54);
			this.labelWeeks.Name = "labelWeeks";
			this.labelWeeks.Size = new System.Drawing.Size(147, 23);
			this.labelWeeks.TabIndex = 4;
			this.labelWeeks.Text = "No. weeks:";
			// 
			// textBoxWeeks
			// 
			this.textBoxWeeks.Enabled = false;
			this.textBoxWeeks.Location = new System.Drawing.Point(160, 51);
			this.textBoxWeeks.Name = "textBoxWeeks";
			this.textBoxWeeks.Size = new System.Drawing.Size(186, 22);
			this.textBoxWeeks.TabIndex = 3;
			// 
			// buttonCheckout
			// 
			this.buttonCheckout.Enabled = false;
			this.buttonCheckout.Location = new System.Drawing.Point(271, 79);
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
			this.textBoxCheckoutId.Location = new System.Drawing.Point(160, 23);
			this.textBoxCheckoutId.Name = "textBoxCheckoutId";
			this.textBoxCheckoutId.Size = new System.Drawing.Size(186, 22);
			this.textBoxCheckoutId.TabIndex = 1;
			// 
			// labelCheckoutId
			// 
			this.labelCheckoutId.Location = new System.Drawing.Point(7, 26);
			this.labelCheckoutId.Name = "labelCheckoutId";
			this.labelCheckoutId.Size = new System.Drawing.Size(148, 23);
			this.labelCheckoutId.TabIndex = 0;
			this.labelCheckoutId.Text = "Book ID:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.labelReturnNotification);
			this.groupBox4.Controls.Add(this.buttonReturn);
			this.groupBox4.Controls.Add(this.textBoxReturnId);
			this.groupBox4.Controls.Add(this.labelReturnId);
			this.groupBox4.Location = new System.Drawing.Point(374, 131);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(352, 80);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Return:";
			// 
			// labelReturnNotification
			// 
			this.labelReturnNotification.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelReturnNotification.Location = new System.Drawing.Point(6, 51);
			this.labelReturnNotification.Name = "labelReturnNotification";
			this.labelReturnNotification.Size = new System.Drawing.Size(259, 23);
			this.labelReturnNotification.TabIndex = 3;
			// 
			// buttonReturn
			// 
			this.buttonReturn.Enabled = false;
			this.buttonReturn.Location = new System.Drawing.Point(271, 51);
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
			this.textBoxReturnId.Location = new System.Drawing.Point(161, 22);
			this.textBoxReturnId.Name = "textBoxReturnId";
			this.textBoxReturnId.Size = new System.Drawing.Size(185, 22);
			this.textBoxReturnId.TabIndex = 1;
			// 
			// labelReturnId
			// 
			this.labelReturnId.Location = new System.Drawing.Point(8, 25);
			this.labelReturnId.Name = "labelReturnId";
			this.labelReturnId.Size = new System.Drawing.Size(147, 23);
			this.labelReturnId.TabIndex = 0;
			this.labelReturnId.Text = "Book ID:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(738, 359);
			this.Controls.Add(this.booksListView);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Borrower";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}