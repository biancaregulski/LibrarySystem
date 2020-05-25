using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace LibrarySystem {
	
	public partial class SearchBook : Form {
		
		public MainForm ParentForm { get; set; }
		
		public SearchBook() {
			InitializeComponent();
		}
		
		void ButtonShowAllClick(object sender, EventArgs e) {
			labelNotification.Text = "";
			showAllBooks();
		}
		
		void ButtonSearchClick(object sender, EventArgs e) {
			labelNotification.Text = "";
			listViewBooks.Items.Clear();
			if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) &&
			    string.IsNullOrWhiteSpace(textBoxLastName.Text) &&
			    string.IsNullOrWhiteSpace(textBoxTitle.Text) &&
			    string.IsNullOrWhiteSpace(textBoxYear.Text) &&
			    comboBoxGenre.Text == "") {
				showAllBooks();
			}
			else {
				// for each book, if searched attribute is part of book's name, show result in the table
				foreach (DictionaryEntry book in ParentForm.books) {
					// make both strings lowercase to make search case-insensitive
					if ((string.IsNullOrWhiteSpace(textBoxFirstName.Text)
					     || (book.Value as Book).AuthorFirstName.ToLower().Contains(textBoxFirstName.Text.ToLower()))
					    &&  (string.IsNullOrWhiteSpace(textBoxLastName.Text)
					         ||  (book.Value as Book).AuthorLastName.ToLower().Contains(textBoxLastName.Text.ToLower()))
					    && (string.IsNullOrWhiteSpace(textBoxTitle.Text)
					        ||  (book.Value as Book).Title.ToLower().Contains(textBoxTitle.Text.ToLower()))
					    && (string.IsNullOrWhiteSpace(textBoxYear.Text)
					        ||  (book.Value as Book).Year.ToString().Equals(textBoxYear.Text))
					    && (comboBoxGenre.Text == ""
					        || comboBoxGenre.Text == ((book.Value as Book).Fiction ? "Fiction" : "Non-Fiction"))) {
						addToListView(book);
					}
				}
			}
		}
		
		void addToListView(DictionaryEntry book) {
			const int numColumns = 6;
			string[] arr = new string[numColumns];
			arr[0] = book.Key.ToString();
			arr[1] = (book.Value as Book).Title;
			arr[2] = (book.Value as Book).AuthorFirstName + " " + (book.Value as Book).AuthorLastName;
			arr[3] = (book.Value as Book).Year.ToString();
			arr[4] = (book.Value as Book).Fiction ? "Fiction" : "Non-Fiction";
			arr[5] = (book.Value as Book).Avaliable == true ? "Yes" : "No";
			ListViewItem item = new ListViewItem(arr);
			listViewBooks.Items.Add(item);
			
			// resize last column due to vertical search bar
			listViewBooks.AutoResizeColumn(numColumns - 1, ColumnHeaderAutoResizeStyle.ColumnContent);
			listViewBooks.AutoResizeColumn(numColumns - 1, ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		
		void showAllBooks() {
			listViewBooks.Items.Clear();
			if (ParentForm.books != null) {
				foreach (DictionaryEntry book in ParentForm.books) {
					addToListView(book);
				}
			}
		}
		void RemoveToolStripMenuItemClick(object sender, EventArgs e) {
			if (listViewBooks.SelectedItems.Count == 1) {
				int bookId =  Int32.Parse(listViewBooks.SelectedItems[0].SubItems[0].Text);
				if (!(ParentForm.books[bookId] as Book).Avaliable) {
					labelNotification.Text = "Cannot return unavaliable book (must be returned first).";
				}
				else if ((ParentForm.books[bookId] as Book).Avaliable && DialogResult.Yes ==
				         MessageBox.Show("Are you sure you want to delete book #" + bookId + "?",
				                         "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) {
					ParentForm.books.Remove(bookId);
					listViewBooks.Items.Remove(listViewBooks.SelectedItems[0]);
					labelNotification.Text = "Book #" + bookId + " deleted.";
				}
				else {
					labelNotification.Text = "Book was not deleted.";
				}
			}
		}
	}
}
