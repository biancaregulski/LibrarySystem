using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem {

	public partial class AddBookForm : Form {
		
		public MainForm parentForm { get; set; }
		
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
					
					location = (fiction == true) ? "F." : "N.";		// start with number to represent genre
					for (int i = 0; i < 3; i++) {
						// give number for nth number of alphabet for first 3 letters of name
						location +=  (i < authorLastName.Length && Char.IsLetter(authorLastName[i])) ? 
									 ((int)Char.ToLower(authorLastName[i]) - 96).ToString() : "0";
						location += ".";
					}
					location += Char.ToUpper(title[0]) + ".";
					location+= year.ToString();
					
					int id = this.parentForm.addBook(title, authorFirstName, authorLastName, year, fiction, location);
					
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
