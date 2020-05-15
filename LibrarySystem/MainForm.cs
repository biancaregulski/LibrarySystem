using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem {

	public partial class MainForm : Form {
		private HashSet<Borrower> borrowers;
		private HashSet<Book> books;
		
		public MainForm() {
			InitializeComponent();
			
			// always show 5 rows in listview
			var arr = new string[4];
			ListViewItem item;
			arr[0] = "1984";
			arr[1] = "George Orwell";
			var dt = new DateTime(2008, 3, 9, 16, 5, 7, 123);
			arr[2] = String.Format("{0:dd/MM/yyyy HH:mm}", dt);
			var dt2 = new DateTime(2008, 4, 9, 16, 5, 7, 123);
			arr[3] = String.Format("{0:dd/MM/yyyy HH:mm}", dt2);
			item = new ListViewItem(arr);
			booksListView.Items.Add(item);
			
			// TODO: before logging in validly, grey out checkout / return text boxes / button
			// if restricted, grey out checkout text boxes / button
			// if there are no books checked out, grey out return text box / button
		}
		void MainFormLoad(object sender, EventArgs e) {
	
		}
	}
}
