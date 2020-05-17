using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

// TODO: add search book and search borrower features
// TODO: hover over text to show full

namespace LibrarySystem {

	public partial class MainForm : Form {
		Hashtable borrowers =  new Hashtable();
		Hashtable books = new Hashtable();
		
		Borrower currentBorrower;
		int currentBorrowerId;
		
		int borrowIdCount = 0;
		int bookIdCount = 0;
		
		AddBorrowerForm addBorrowerForm = new AddBorrowerForm ();
		AddBookForm addBookForm = new AddBookForm ();
		
		
		public MainForm() {
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e) {

		}
		
		public int addBorrower(string name, DateTime dt) {
			borrowers.Add(++borrowIdCount, new Borrower(name, dt));
			return borrowIdCount;
		}
		
		public int addBook(string title, string authorFirstName, string authorLastName, int year, Boolean genre, string location) {
			books.Add(++bookIdCount, new Book(title, authorFirstName, authorLastName, year, genre, location));
			return bookIdCount;
		}
		
		void ButtonShowBorrowerClick(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(textBoxBorrowerId.Text)) {
				labelShowNotification.Text = "Borrower ID must be filled in.";
			}
			else {
				int borrowerId;
				if (Int32.TryParse(textBoxBorrowerId.Text, out borrowerId)) {
					if (borrowerId == currentBorrowerId) {
						labelShowNotification.Text = "ID #" + borrowerId + " already accessed.";
					}
					else if(borrowers.ContainsKey(borrowerId)) { 					// check if id matches anyone
						currentBorrowerId = borrowerId;
						currentBorrower = (Borrower)borrowers[currentBorrowerId];
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
						labelShowNotification.Text = "Accessing account of borrower #" + borrowerId + ".";
						textBoxBorrowerId.Text = "";
					}
					else {
						labelShowNotification.Text = "ID #" + borrowerId + " not found.";
					}
				}
				else {
					labelShowNotification.Text = "Invalid input.";
				}
			}
			labelCheckoutNotification.Text = "";
			labelReturnNotification.Text = "";
		}
		
		
		void ButtonCheckoutClick(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(textBoxCheckoutId.Text) || string.IsNullOrWhiteSpace(textBoxWeeks.Text)) {
				labelCheckoutNotification.Text = "All fields must be filled in.";
			}
			else {
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
						if (currentBook.checkoutBook(currentBorrower, numWeeks)) {
							updateListView();
							labelCheckoutNotification.Text = "Checked out book #" + bookId + " for " + numWeeks + " week(s).";
							textBoxCheckoutId.Text = "";
							textBoxWeeks.Text = "";
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
			labelShowNotification.Text = "";
			labelReturnNotification.Text = "";
		}
		
		void ButtonReturnClick(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(textBoxReturnId.Text)) {
				labelReturnNotification.Text = "Book ID must be filled in.";
			}
			else {
				int bookId;
				if (Int32.TryParse(textBoxReturnId.Text, out bookId)) {
					if (!books.ContainsKey(bookId)) {
						labelReturnNotification.Text = "Invalid book ID.";
					}
					else {					// check if id matches any book
						Book currentBook = (Book)(books[bookId]);
						if (currentBook.returnBook(currentBorrower)) {
							updateListView();
							labelReturnNotification.Text = "Returned book #" + bookId + ".";
							textBoxReturnId.Text = "";
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
			labelShowNotification.Text = "";
			labelCheckoutNotification.Text = "";
		}
		
		void ButtonAddBorrowerClick(object sender, EventArgs e) {
			addBorrowerForm.parentForm = this;
			addBorrowerForm.ShowDialog();
		}
		
		void ButtonDeleteBorrowerClick(object sender, EventArgs e) {
			
		}
		
		void ButtonAddBookClick(object sender, EventArgs e) {
			addBookForm.parentForm = this;
			addBookForm.ShowDialog();
		}
		
		void ButtonDeleteBookClick(object sender, EventArgs e) {
			
		}
		
		void updateListView() {
			booksListView.Items.Clear();
			foreach (Book b in (currentBorrower.CheckedOutBooks)) {
				string[] arr = new string[5];
				arr[0] = b.Title;
				arr[1] = b.AuthorFirstName + " " + b.AuthorLastName;
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
			if (currentBorrower.CheckedOutBooks.Count == 0) {
				// cannot return when there are no books checked out
				enableReturn(false);
			}
			else {
				enableReturn(true);
			}
			if (currentBorrower.CheckedOutBooks.Count >= 5) {
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
			
			if (!value) {
				textBoxCheckoutId.Text = "";
				textBoxWeeks.Text = "";
			}
		}
		
		void enableReturn(Boolean value) {
			textBoxReturnId.Enabled = value;
			buttonReturn.Enabled = value;
			
			if (!value) {
				textBoxReturnId.Text = "";
			}
		}
	}
}
