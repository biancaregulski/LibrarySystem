using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

// TODO: add search book and search borrower features
// TODO: hover over text to show full
// TODO: make return and checkout longer to show notifs

namespace LibrarySystem {

	public partial class MainForm : Form {
		public Hashtable borrowers { get; set; }
		public Hashtable books { get; set; }
		
		Borrower currentBorrower;
		int? currentBorrowerId;
		
		int borrowIdCount = 0;
		int bookIdCount = 0;
		
		AddBorrowerForm addBorrowerForm = new AddBorrowerForm ();
		AddBookForm addBookForm = new AddBookForm ();
		ViewBookForm viewBookForm = new ViewBookForm ();
		
		public MainForm() {
			InitializeComponent();
			borrowers =  new Hashtable();
			books = new Hashtable();
			borrowers.Add(++borrowIdCount, new Borrower("Lucy Smith", new DateTime(1995, 1, 18)));
			borrowers.Add(++borrowIdCount, new Borrower("Jack Jacobs", new DateTime(1997, 2, 16)));
			books.Add(++bookIdCount, new Book("1984", "George", "Orwell", 1949, true, "842.611.854.C"));
			books.Add(++bookIdCount, new Book("Brave New World", "Aldous", "Huxley", 1932, true, "842.150.656.F"));
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
						textBoxName.Text = currentBorrower.Name;						// TODO: allow to change name
						textBoxDob.Text = String.Format("{0:M/d/yyyy}", currentBorrower.Dob);
						updateListView();
						updateEnabledForms();
						labelShowNotification.Text = "Accessing account of #" + borrowerId + ".";
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
			removeLabels("show");
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
							updateEnabledForms();
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
			removeLabels("checkout");
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
							updateEnabledForms();
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
			removeLabels("return");
		}
		
		void ButtonNameEditClick(object sender, EventArgs e) {
			if (buttonEdit.Text == "Edit") {
				enableBorrowerInfo(false, false, true);
				enableShowBorrower(false);
				enableCheckout(false);
				enableReturn(false);
				enabledBottomButtons(false);
				buttonRemove.Enabled = false;
				textBoxDob.Visible = false;
				dateTimePicker.Visible = true;
				dateTimePicker.Value = currentBorrower.Dob;
				buttonEdit.Text = "Save";
			}
			else {
				currentBorrower.Name = textBoxName.Text;
				currentBorrower.Dob = dateTimePicker.Value;
				textBoxDob.Visible = true;
				textBoxDob.Text = String.Format("{0:M/d/yyyy}", currentBorrower.Dob);
				dateTimePicker.Visible = false;
				updateEnabledForms();
				buttonEdit.Text = "Edit";
			}
			removeLabels("info");
		}
		void ButtonRemoveClick(object sender, EventArgs e) {
			if (currentBorrower.CheckedOutBooks.Count > 0) {
				labelInfoNotification.Text = "Must return all books first.";
			}
			else if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete borrower #" + currentBorrowerId + "?",
			                                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) {
				enableBorrowerInfo(true, false, false);
				enableShowBorrower(true);
				enableCheckout(false);
				enableReturn(false);
				updateListView();
				borrowers.Remove(currentBorrowerId);
				labelInfoNotification.Text = "Borrower #" + currentBorrowerId + " deleted.";
				currentBorrower = null;
				currentBorrowerId = null;
				textBoxName.Text = "";
				textBoxDob.Text = "";
				removeLabels("info");
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
		
		// TODO: change to enum
		void removeLabels(string doNotRemove) {
			if (!doNotRemove.Equals("show")) {
				labelShowNotification.Text = "";
			}
			else if (!doNotRemove.Equals("info")) {
				labelInfoNotification.Text = "";
			}
			else if (!doNotRemove.Equals("checkout")) {
				labelCheckoutNotification.Text = "";
			}
			else if (!doNotRemove.Equals("return")) {
				labelReturnNotification.Text = "";
			}
		}
		
		public void updateListView() {
			booksListView.Items.Clear();
			if (currentBorrower != null) {
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
			enableBorrowerInfo(true, true, true);
		}
		
		void enableBorrowerInfo(Boolean value, Boolean removeValue, Boolean editValue) {
			textBoxName.ReadOnly = value;
			textBoxDob.ReadOnly = value;
			buttonRemove.Enabled = removeValue;
			buttonEdit.Enabled = editValue;
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

	}
}
