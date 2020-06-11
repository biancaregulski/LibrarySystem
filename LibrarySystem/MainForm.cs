using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem {

	public partial class MainForm : Form {
		public Hashtable borrowers { get; set; }
		public Hashtable books { get; set; }
		
		Borrower currentBorrower;
		int? currentBorrowerId;
		
		int borrowIdCount = 0;
		int bookIdCount = 0;

		ServerConnectForm serverConnectForm = new ServerConnectForm();
		AddBorrowerForm addBorrowerForm = new AddBorrowerForm();
		AddBookForm addBookForm = new AddBookForm();
		ViewBookForm viewBookForm = new ViewBookForm();
		SearchBorrower searchBorrower = new SearchBorrower();
		SearchBook searchBook = new SearchBook();
		
		public MainForm() {
			InitializeComponent();
			borrowers =  new Hashtable();
			books = new Hashtable();
			borrowers.Add(++borrowIdCount, new Borrower(borrowIdCount, "Lucy", "Smith", new DateTime(1995, 1, 18)));
			borrowers.Add(++borrowIdCount, new Borrower(borrowIdCount, "Jack", "Jacobs", new DateTime(1997, 2, 16)));
			books.Add(++bookIdCount, new Book(bookIdCount, "1984", "George", "Orwell", 1949, true, "842.611.854.C"));
			books.Add(++bookIdCount, new Book(bookIdCount, "Brave New World", "Aldous", "Huxley", 1932, true, "842.150.656.F"));
		}
		
		void MainFormLoad(object sender, EventArgs e) {
			
		}
		
		public int addBorrower(string firstName, string lastName, DateTime dt) {
			borrowers.Add(++borrowIdCount, new Borrower(borrowIdCount, firstName, lastName, dt));
			return borrowIdCount;
		}
		
		public int addBook(string title, string authorFirstName, string authorLastName, int year, Boolean genre, string location) {
			books.Add(++bookIdCount, new Book(bookIdCount, title, authorFirstName, authorLastName, year, genre, location));
			return bookIdCount;
		}
		
		public string calculateBookLocation(string title, string authorLastName, int year, Boolean fiction) {
			string location = (fiction == true) ? "F." : "N.";		// start with number to represent genre
			for (int i = 0; i < 3; i++) {
				// give number for nth number of alphabet for first 3 letters of name
				location +=  (i < authorLastName.Length && Char.IsLetter(authorLastName[i])) ?
					((int)Char.ToLower(authorLastName[i]) - 96).ToString() : "0";
				location += ".";
			}
			location += Char.ToUpper(title[0]) + ".";
			location+= year.ToString();
			return location;
		}
		
		void ButtonShowBorrowerClick(object sender, EventArgs e) {
			removeLabels();
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
						loginBorrower(borrowerId);
					}
					else {
						labelShowNotification.Text = "ID #" + borrowerId + " not found.";
					}
				}
				else {
					labelShowNotification.Text = "Invalid input.";
				}
			}
		}
		
		void ButtonCheckoutClick(object sender, EventArgs e) {
			removeLabels();
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
						if (currentBook.CheckoutDate == null || currentBorrower.CheckedOutBooks.Contains(currentBook)) {
							if (currentBook.CheckoutDate == null) {
								currentBook.checkoutOrRenewBook(currentBorrower, numWeeks);
								labelCheckoutNotification.Text = "Checked out book.";
								if (currentBorrower.CheckedOutBooks.Count >= 5) {
									labelCheckoutNotification.Text += " Book limit reached.";
								}
							}
							else {
								currentBorrower.CheckedOutBooks.Remove(currentBook);
								currentBook.checkoutOrRenewBook(currentBorrower, numWeeks);
								labelCheckoutNotification.Text = "Renewed book.";
							}
							updateListView();
							updateEnabledForms();
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
		}
		
		void ButtonReturnClick(object sender, EventArgs e) {
			removeLabels();
			if (string.IsNullOrWhiteSpace(textBoxReturnId.Text)) {
				labelReturnNotification.Text = "Book ID must be filled in.";
			}
			else {
				int bookId;
				if (Int32.TryParse(textBoxReturnId.Text, out bookId)) {
					if (!books.ContainsKey(bookId)) {
						labelReturnNotification.Text = "Invalid book ID.";
					}
					else {
						returnSelectedBook(bookId);
					}
				}
				else {
					labelReturnNotification.Text = "Invalid input.";
				}
			}
		}
		
		void ButtonNameEditClick(object sender, EventArgs e) {
			removeLabels();
			if (buttonEdit.Text == "Edit") {
				// make user unable to press any buttons unrelated to editing
				enableBorrowerInfo(true, true);
				enableShowBorrower(false);
				enableCheckout(false);
				enableReturn(false);
				enabledBottomButtons(false);
				buttonRemove.Text = "Cancel";
				dateTimePicker.Visible = true;
				dateTimePicker.Value = currentBorrower.Dob;
				buttonEdit.Text = "Save";
				buttonReturn.Text = "Cancel";
			}
			else {				// save changes
				currentBorrower.FirstName = textBoxFirstName.Text;
				currentBorrower.LastName = textBoxLastName.Text;
				currentBorrower.Dob = dateTimePicker.Value;
				textBoxDob.Text = String.Format("{0:M/d/yyyy}", currentBorrower.Dob);
				dateTimePicker.Visible = false;
				updateEnabledForms();
				labelInfoNotification.Text = "Borrower #" + currentBorrowerId + " updated.";
				buttonEdit.Text = "Edit";
				buttonRemove.Text = "Remove";
			}
		}
		void ButtonRemoveClick(object sender, EventArgs e) {
			removeLabels();
			if (buttonRemove.Text == "Remove") {
				if (currentBorrower.CheckedOutBooks.Count > 0) {
					labelInfoNotification.Text = "Must return all books first.";
				}
				else if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete borrower #" + currentBorrowerId + "?",
				                                             "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) {
					enableBorrowerInfo(true, false);
					enableShowBorrower(true);
					enableCheckout(false);
					enableReturn(false);
					updateListView();
					borrowers.Remove(currentBorrowerId);
					labelInfoNotification.Text = "Borrower #" + currentBorrowerId + " deleted.";
					currentBorrower = null;
					currentBorrowerId = null;
					textBoxFirstName.Text = "";
					textBoxLastName.Text = "";
					textBoxDob.Text = "";
				}
				else {
					// book was not removed
					labelInfoNotification.Text = "Borrower was not deleted.";
				}
			}
			else {				// cancel changes
				// don't save changes and revert boxes back to object's values
				updateEnabledForms();
				enableBorrowerInfo(false, true);
				textBoxFirstName.Text = currentBorrower.FirstName;
				textBoxLastName.Text = currentBorrower.LastName;
				textBoxDob.Text = String.Format("{0:M/d/yyyy}", currentBorrower.Dob);
				dateTimePicker.Visible = false;
				buttonEdit.Text = "Edit";
				buttonRemove.Text = "Remove";
			}
		}
		
		void ButtonAddBorrowerClick(object sender, EventArgs e) {
			addBorrowerForm.ParentForm = this;
			addBorrowerForm.ShowDialog();
		}
		
		void ButtonDeleteBorrowerClick(object sender, EventArgs e) {
			
		}
		
		void ButtonAddBookClick(object sender, EventArgs e) {
			addBookForm.ParentForm = this;
			addBookForm.ShowDialog();
		}
		
		void ButtonViewBookClick(object sender, EventArgs e) {
			viewBookForm.ParentForm = this;
			viewBookForm.ShowDialog();
		}
		void ButtonSearchBorrowerClick(object sender, EventArgs e) {
			searchBorrower.ParentForm = this;
			searchBorrower.ShowDialog();
		}
		
		void ButtonSearchBookClick(object sender, EventArgs e) {
			searchBook.ParentForm = this;
			searchBook.ShowDialog();
		}
		
		Boolean returnSelectedBook(int bookId) {
			removeLabels();
			// check if id matches any book
			Book currentBook = books[bookId] as Book;
			if (currentBook.returnBook(currentBorrower)) {
				updateListView();
				updateEnabledForms();
				labelReturnNotification.Text = "Returned book #" + bookId + ".";
				textBoxReturnId.Text = "";
				return true;
			}
			else {
				labelReturnNotification.Text = "Book not checked out by this borrower.";
				return false;
			}
		}
		
		public void loginBorrower(int borrowerId) {
			currentBorrowerId = borrowerId;
			currentBorrower = borrowers[currentBorrowerId] as Borrower;
			// fill in labels with borrower information
			textBoxFirstName.Text = currentBorrower.FirstName;
			textBoxLastName.Text = currentBorrower.LastName;
			textBoxDob.Text = String.Format("{0:M/d/yyyy}", currentBorrower.Dob);
			updateListView();
			updateEnabledForms();
			labelShowNotification.Text = "Accessing account of #" + borrowerId + ".";
			textBoxBorrowerId.Text = "";
		}
		
		void removeLabels() {
			labelShowNotification.Text = "";
			labelInfoNotification.Text = "";
			labelCheckoutNotification.Text = "";
			labelReturnNotification.Text = "";
		}
		
		public void updateListView() {
			booksListView.Items.Clear();
			if (currentBorrower != null) {
				foreach (Book b in (currentBorrower.CheckedOutBooks)) {
					string[] arr = new string[6];
					arr[0] = b.Id.ToString();;
					arr[1] = b.Title;
					arr[2] = b.AuthorFirstName + " " + b.AuthorLastName;
					arr[3] = b.Year.ToString();
					arr[4] = String.Format("{0:M/d/yyyy}", b.CheckoutDate);
					arr[5] = String.Format("{0:M/d/yyyy}", b.ReturnDate);
					ListViewItem item = new ListViewItem(arr);
					
					if (DateTime.Now > b.ReturnDate) {
						// if now is later than return date, change text color
						item.SubItems[4].ForeColor = Color.Crimson;
						item.UseItemStyleForSubItems = false;
					}
					booksListView.Items.Add(item);
				}
			}
		}
		
		void updateEnabledForms() {
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
			enableShowBorrower(true);
			enableBorrowerInfo(false, true);
		}
		
		void enableBorrowerInfo(Boolean value, Boolean buttonValue) {
			textBoxFirstName.ReadOnly = !value;
			textBoxLastName.ReadOnly = !value;
			textBoxDob.ReadOnly = !value;
			buttonRemove.Enabled = buttonValue;
			buttonEdit.Enabled = buttonValue;
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
		
		void enableShowBorrower(Boolean value) {
			textBoxBorrowerId.Enabled = value;
			buttonShowBorrower.Enabled = value;
		}
		
		void enabledBottomButtons(Boolean value) {
			
		}
		void AddBookClick(object sender, EventArgs e) {

		}
		private void connectToolStripMenuItem1_Click(object sender, EventArgs e) {
			serverConnectForm.ParentForm = this;
			serverConnectForm.ShowDialog();
		}
		void ReturnToolStripMenuItemClick(object sender, EventArgs e) {
			if (booksListView.SelectedItems.Count == 1) {
				// get book that matches id number from first column of selected item
				int bookId = Int32.Parse(booksListView.SelectedItems[0].SubItems[0].Text);
				returnSelectedBook(bookId);
			}
		}

	}
}
