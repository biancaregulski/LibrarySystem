
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem {
	public partial class ViewBookForm : Form {
		public MainForm ParentForm { get; set; }
		
		int? currentBookId;
		Book currentBook;
		
		public ViewBookForm() : base() {		// TODO: base?
			InitializeComponent();

		}
		
		void ButtonOkClick(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(textBoxBookId.Text)) {
				labelNotification.Text = "Book ID must be filled in.";
			}
			else {
				int bookId;
				if (Int32.TryParse(textBoxBookId.Text, out bookId)) {
					if (bookId == currentBookId) {
						labelNotification.Text = "Book #" + currentBookId + " already shown.";
					}
					else if (!ParentForm.books.ContainsKey(bookId)) {	// check if id matches any book
						labelNotification.Text = "Invalid book ID.";
					}
					else {
						currentBookId = bookId;
						currentBook = (Book)(ParentForm.books[currentBookId]);
						labelNotification.Text = "";
						loadBookInfo(currentBook);
					}
				}
				else {
					labelNotification.Text = "Invalid input.";
				}
			}
		}
		
		void ButtonRemoveClick(object sender, EventArgs e) {
			if (buttonRemove.Text == "Remove") {
				// do not let user delete book that is currently checked out
				if (!currentBook.Avaliable) {
					labelNotification.Text = "Book must be returned first.";
				}
				else if(DialogResult.Yes == MessageBox.Show("Are you sure you want to delete book #" +
				                                            currentBookId + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) {
					ParentForm.books.Remove(currentBookId);
					this.Controls.Clear();
					this.InitializeComponent();			// restart form
					labelNotification.Text = "Book #" + currentBookId + " removed.";
					currentBook = null;
					currentBookId = null;
				}
				else {
					// book was not removed
					labelNotification.Text = "Book was not removed.";
				}
			}
			else {
				// don't save changes and revert boxes back to object's values
				textBoxFirstName.Text = currentBook.AuthorFirstName;
				textBoxLastName.Text = currentBook.AuthorLastName;
				textBoxTitle.Text = currentBook.Title;
				textBoxYear.Text = currentBook.Year.ToString();
				comboBoxGenre.SelectedIndex = currentBook.Fiction ? 0 : 1;
				enableBookInfo(false);
				buttonEdit.Text = "Edit";
				buttonRemove.Text = "Remove";
				labelNotification.Text = "";
			}
		}
		
		void ButtonEditClick(object sender, EventArgs e) {
			if (buttonEdit.Text == "Edit") {
				buttonEdit.Text = "Save";
				buttonRemove.Text = "Cancel";
				labelNotification.Text = "";
				enableBookInfo(true);
			}
			else {
				// save changes if appropriate
				if (string.IsNullOrWhiteSpace(textBoxTitle.Text) || string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
				    string.IsNullOrWhiteSpace(textBoxLastName.Text) ||string.IsNullOrWhiteSpace(textBoxYear.Text)) {
					labelNotification.Text = "All fields must be filled in.";
				}
				else {
					string title, authorFirstName, authorLastName, location;
					Boolean fiction;
					int year;
					if (Int32.TryParse(textBoxYear.Text, out year)) {
						currentBook.Title = textBoxTitle.Text;
						currentBook.AuthorFirstName = textBoxFirstName.Text;
						currentBook.AuthorLastName = textBoxLastName.Text;
						currentBook.Title = textBoxTitle.Text;
						currentBook.Year = year;
						currentBook.Fiction = comboBoxGenre.SelectedIndex.Equals(0) ? true : false;
						currentBook.Location = this.ParentForm.calculateBookLocation(currentBook.Title,
						                                                             currentBook.AuthorLastName, currentBook.Year, currentBook.Fiction);
						this.ParentForm.updateListView();				// in case book changed was in list view
						buttonEdit.Text = "Edit";
						buttonRemove.Text = "Remove";
						labelNotification.Text = "Book updated.";
						enableBookInfo(false);
					}
					else {
						labelNotification.Text = "Invalid year.";
					}
				}
			}
		}
		
		void enableBookInfo(Boolean value) {
			textBoxBookId.ReadOnly = value;
			textBoxFirstName.ReadOnly = !value;
			textBoxLastName.ReadOnly = !value;
			textBoxTitle.ReadOnly = !value;
			textBoxYear.ReadOnly = !value;
			comboBoxGenre.Enabled = value;
			buttonOk.Enabled = !value;
		}
		void loadBookInfo(Book book) {
			textBoxFirstName.Text = book.AuthorFirstName;
			textBoxLastName.Text = book.AuthorLastName;
			textBoxTitle.Text = book.Title;
			textBoxYear.Text = book.Year.ToString();
			comboBoxGenre.SelectedIndex = book.Fiction == true ? 0 : 1;
			buttonEdit.Enabled = true;
			buttonRemove.Enabled = true;
		}
	}
}
