using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;


namespace LibrarySystem {

	public partial class MainForm : Form {
		// TODO: change books and borrowers to hashsets
		Hashtable borrowers =  new Hashtable();
		Hashtable books = new Hashtable();
		
		int currentBorrowerId;
		
		int borrowIdCount = 0;
		int bookIdCount = 0;
		
		public MainForm() {
			InitializeComponent();
		}
		void MainFormLoad(object sender, EventArgs e) {
			borrowers.Add(++borrowIdCount, new Borrower("Lucy Smith", new DateTime(1995, 1, 18)));
			borrowers.Add(++borrowIdCount, new Borrower("Jack Jacobs", new DateTime(1997, 2, 16)));
			books.Add(++bookIdCount, new Book("1984", "George Orwell", 1949, "842.611.854.C"));
			books.Add(++bookIdCount, new Book("Brave New World", "Aldous Huxley", 1932, "842.150.656.F"));
		}
		void ButtonShowBorrowerClick(object sender, EventArgs e) {
			if (textBoxBorrowerId.Text != "") {
				int borrowerId;
				if (Int32.TryParse(textBoxBorrowerId.Text, out borrowerId)) {
					if(borrowers.ContainsKey(borrowerId)) { 					// check if id matches anyone
						currentBorrowerId = borrowerId;
						Borrower currentBorrower = (Borrower)borrowers[currentBorrowerId];
						labelShowNotification.Text = "";
						// fill in labels with borrower information
						labelNameValue.Text = currentBorrower.Name;						// TODO: allow to change name
						labelDobValue.Text = String.Format("{0:dd/MM/yyyy}", currentBorrower.Dob);
						if (!currentBorrower.Restriction) {
							labelRestrictionValue.Text = "None";
						}
						else {
							labelRestrictionValue.Text = "Too many late returns";
						}
						updateListView();
					}
					else if (borrowerId != currentBorrowerId) {
						labelShowNotification.Text = "ID " + borrowerId + " not found.";
					}
				}
				else {
					labelShowNotification.Text = "Invalid input.";
				}
			}
		}
		
		
		void ButtonCheckoutClick(object sender, EventArgs e) {
			if (!textBoxCheckoutId.Text.Equals("") && !textBoxWeeks.Text.Equals("")) {
				int bookId;
				int numWeeks;
				if (Int32.TryParse(textBoxCheckoutId.Text, out bookId) && Int32.TryParse(textBoxWeeks.Text, out numWeeks)) {
					if (!books.ContainsKey(bookId)) {
						labelCheckoutNotification.Text = "Invalid book ID.";
					}
					
					else if (numWeeks <= 0) {
						labelCheckoutNotification.Text = "No. of weeks must be greater than 0.";
					}
					
					else {					// check if id matches any book
						Book currentBook = (Book)(books[bookId]);
						if (currentBook.checkoutBook((Borrower)borrowers[currentBorrowerId], numWeeks)) {
							labelCheckoutNotification.Text = "Checked out book #" + bookId + " for " + numWeeks + " week(s).";
							updateListView();
						}
						else {
							labelCheckoutNotification.Text = "Book not avaliable.";
						}
					}
				}
				else {
					labelCheckoutNotification.Text = "Invalid input.";
				}
			}
		}
		
		void ButtonReturnClick(object sender, EventArgs e) {
			if (textBoxReturnId.Text != "") {
				int bookId;
				if (Int32.TryParse(textBoxReturnId.Text, out bookId)) {
					if (!books.ContainsKey(bookId)) {
						labelReturnNotification.Text = "Invalid book ID.";
					}
					else {					// check if id matches any book
						Book currentBook = (Book)(books[bookId]);
						if (currentBook.returnBook((Borrower)borrowers[currentBorrowerId])) {
							labelReturnNotification.Text = "Returned book #" + bookId + ".";
							updateListView();
						}
						else {
							labelReturnNotification.Text = "Book not checked out by this borrower.";
						}
					}
				}
				else {
					labelReturnNotification.Text = "Invalid input.";
				}
			}
		}
		
		void updateListView() {
			booksListView.Items.Clear();
			foreach (Book b in ((Borrower)borrowers[currentBorrowerId]).CheckedOutBooks) {
				string[] arr = new string[5];
				arr[0] = b.Title;
				arr[1] = b.Author;
				arr[2] = b.Year.ToString();
				arr[3] = String.Format("{0:MM/dd/yyyy HH:mm}", b.CheckoutDate);
				arr[4] = String.Format("{0:MM/dd/yyyy HH:mm}", b.ReturnDate);
				ListViewItem item = new ListViewItem(arr);
				
				if (DateTime.Now > b.ReturnDate) {
					// if now is later than return date, change text color
					item.SubItems[4].ForeColor = Color.Crimson;
					item.UseItemStyleForSubItems = false;
				}
				booksListView.Items.Add(item);
			}
			
			// gray out textboxes and buttons if action not possible
			if (((Borrower)borrowers[currentBorrowerId]).CheckedOutBooks.Count == 0) {
				// cannot return when there are no books checked out
				enableReturn(false);
			}
			else {
				enableReturn(true);
			}
			if (((Borrower)borrowers[currentBorrowerId]).CheckedOutBooks.Count >= 5) {
				// max 5 books
				enableCheckout(false);
			}
			else {
				enableCheckout(true);
			}
		}
		
		void enableCheckout(Boolean value) {
			textBoxCheckoutId.Enabled = value;
			textBoxWeeks.Enabled = value;
			buttonCheckout.Enabled = value;
		}
		
		void enableReturn(Boolean value) {
			textBoxReturnId.Enabled = value;
			buttonReturn.Enabled = value;
		}
	}
}
