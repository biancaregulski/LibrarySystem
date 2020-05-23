using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem {

	public partial class AddBookForm : Form {
		
		public MainForm ParentForm { get; set; }
		
		public AddBookForm() {
			InitializeComponent();

		}
		void ButtonOkClick(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(textBoxTitle.Text) || string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
			    string.IsNullOrWhiteSpace(textBoxLastName.Text) ||string.IsNullOrWhiteSpace(textBoxYear.Text)) {
				labelNotification.Text = "All fields must be filled in.";
			}
			else {
				string title, authorFirstName, authorLastName, location;
				Boolean fiction;
				int year;
				if (Int32.TryParse(textBoxYear.Text, out year)) {
					
					title = textBoxTitle.Text;
					authorFirstName = textBoxFirstName.Text;
					authorLastName = textBoxLastName.Text;
					fiction = comboBoxGenre.SelectedIndex.Equals(0) ? true : false;
					location = this.ParentForm.calculateBookLocation(title, authorLastName, year, fiction);
					
					int id = this.ParentForm.addBook(title, authorFirstName, authorLastName, year, fiction, location);
					
					labelNotification.Text = "Book #" + id + " added at " + location + ".";
					textBoxTitle.Text = "";
					textBoxFirstName.Text = "";
					textBoxLastName.Text = "";
					textBoxYear.Text = "";
				}
				else {
					labelNotification.Text = "Invalid year.";
				}
			}

		}
		void AddBookFormLoad(object sender, EventArgs e) {
			labelNotification.Text = "";
			comboBoxGenre.SelectedIndex = 0;
		}
	}
}
