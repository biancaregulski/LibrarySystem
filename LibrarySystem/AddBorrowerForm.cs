using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem {
	public partial class AddBorrowerForm : Form {
		
		public MainForm ParentForm { get; set; }
		
		public AddBorrowerForm() {
			InitializeComponent();

		}
		void ButtonOkClick(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) || string.IsNullOrWhiteSpace(textBoxLastName.Text)) {
				labelNotification.Text = "Name field must be filled in.";
			}
			else {
				int id = this.ParentForm.addBorrower(textBoxFirstName.Text, textBoxLastName.Text, dateTimeDob.Value);
				labelNotification.Text = "Borrower #" + id + " added.";
				textBoxFirstName.Text = "";
				textBoxLastName.Text = "";
			}

		}
		void AddBorrowerFormLoad(object sender, EventArgs e) {
			labelNotification.Text = "";
		}
	}
}
