using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem {
	public class Book {
		
		private string title;
		public string Title {
			get { return title; }
			set { title = value; }
		}
		
		private string authorFirstName;
		public string AuthorFirstName {
			get { return authorFirstName; }
			set { authorFirstName = value; }
		}
		
		private string authorLastName;
		public string AuthorLastName {
			get { return authorLastName; }
			set { authorLastName = value; }
		}
		
		private int year;
		public int Year {
			get { return year; }
			set { year = value; }
		}
		
		private string location;
		public string Location {
			get { return location; }
			set { location = value; }
		}
		
		private Boolean avaliable = true;
		public Boolean Avaliable {
			get { return avaliable; }
			set { avaliable = value; }
		}
		
		private Boolean fiction;
		public Boolean Fiction {
			get {return fiction; }
			set {fiction = value; }
		}
		
		private DateTime? checkoutDate;
		public DateTime? CheckoutDate {
			get { return checkoutDate; }
			set { checkoutDate = value; }
		}
		
		private DateTime? returnDate;
		public DateTime? ReturnDate {
			get { return returnDate; }
			set { returnDate = value; }
		}
		
		public Book(String title, String authorFirstName, string authorLastName, int year, Boolean fiction, string location) {
			this.title = title;
			this.authorFirstName = authorFirstName;
			this.authorLastName = authorLastName;
			this.year = year;
			this.fiction = fiction;
			this.avaliable = true;
			this.location = location;
		}
		
		// fails if book is already checkout out or borrower is now allowed to check out
		public Boolean checkoutBook(Borrower borrower, int weeks) {
			if (checkoutDate == null) {
				if (!borrower.Restriction) {
					this.checkoutDate = DateTime.Now;
					this.returnDate = checkoutDate.Value.AddDays(weeks * 7);
					if (borrower.addToCheckedOutBooks(this)) {
						this.avaliable = false;
						return true;
					}
				}
			}
			return false;
		}
		
		public Boolean returnBook(Borrower borrower) {
			if (checkoutDate != null) {
				Boolean isOnTime = false;
				if (DateTime.Now < this.returnDate) {
					isOnTime = true;
				}
				if (borrower.removeFromCheckedOutBooks(this, isOnTime)) {
					this.checkoutDate = null;
					this.returnDate = null;
					return true;			// success
				}
			}
			return false;				// fail, book wasn't even checked out
		}
	}
}
