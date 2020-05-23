/*
 * Created by SharpDevelop.
 * User: Bianca
 * Date: 5/16/2020
 * Time: 9:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
	public partial class AddBorrowerForm : Form {
		
		public MainForm ParentForm { get; set; }
		
		public AddBorrowerForm() {
			InitializeComponent();

		}
		void ButtonOkClick(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(textBoxName.Text)) {
				labelNotification.Text = "Name field must be filled in.";
			}
			else {
				int id = this.ParentForm.addBorrower(textBoxName.Text, dateTimeDob.Value);
				labelNotification.Text = "Borrower #" + id + " added.";
				textBoxName.Text = "";
			}

		}
		void AddBorrowerFormLoad(object sender, EventArgs e) {
			labelNotification.Text = "";
		}
	}
}
