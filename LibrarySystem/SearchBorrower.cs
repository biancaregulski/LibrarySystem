using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;

namespace LibrarySystem {
	public partial class SearchBorrower : Form {
		
		public MainForm ParentForm { get; set; }
		
		public SearchBorrower() {
			InitializeComponent();
		}
		
		void ButtonShowAllClick(object sender, EventArgs e) {
			showAllBorrowers();
		}
		
		void ButtonSearchClick(object sender, EventArgs e) {
			listViewBorrowers.Items.Clear();
			if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) &&
			    string.IsNullOrWhiteSpace(textBoxLastName.Text)) {
				showAllBorrowers();
			}
			else {
				// for each borrower, if searched name is part of borrower's name, show result in the table
				foreach (DictionaryEntry borrower in ParentForm.borrowers) {
					// make both strings lowercase to make search case-insensitive
					if ((!string.IsNullOrWhiteSpace(textBoxFirstName.Text) && string.IsNullOrWhiteSpace(textBoxLastName.Text)
					     && (borrower.Value as Borrower).FirstName.ToLower().Contains(textBoxFirstName.Text.ToLower()))
					    || (string.IsNullOrWhiteSpace(textBoxFirstName.Text) && !string.IsNullOrWhiteSpace(textBoxLastName.Text)
					        && (borrower.Value as Borrower).LastName.ToLower().Contains(textBoxLastName.Text.ToLower()))
					    || ((borrower.Value as Borrower).FirstName.ToLower().Contains(textBoxFirstName.Text.ToLower())
					        && (borrower.Value as Borrower).LastName.ToLower().Contains(textBoxLastName.Text.ToLower()))) {
						addToListView(borrower);
					}
				}
			}
		}
		
		void addToListView(DictionaryEntry borrower) {
			string[] arr = new string[3];
			arr[0] = borrower.Key.ToString();
			arr[1] = (borrower.Value as Borrower).FirstName + " " + (borrower.Value as Borrower).LastName;
			arr[2] = String.Format("{0:M/d/yyyy}", (borrower.Value as Borrower).Dob);
			ListViewItem item = new ListViewItem(arr);
			listViewBorrowers.Items.Add(item);
			
			// resize last column due to vertical search bar
			listViewBorrowers.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
			listViewBorrowers.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		
		void showAllBorrowers() {
			listViewBorrowers.Items.Clear();
			if (ParentForm.borrowers != null) {
				foreach (DictionaryEntry borrower in ParentForm.borrowers) {
					addToListView(borrower);
				}
			}
		}
		
		// login selected borrower in main form
		void LoginToolStripMenuItemClick(object sender, EventArgs e) {
			if (listViewBorrowers.SelectedItems.Count == 1) {
				// get borrower that matches id number from first column of selected item
				int borrowerId =  Int32.Parse(listViewBorrowers.SelectedItems[0].SubItems[0].Text);
				ParentForm.loginBorrower(borrowerId);
				this.Close();							// close form to return to main form
			}
		}
	}
}
