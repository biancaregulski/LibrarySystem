using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem {
	public class Book {
		public string Title { get; set;	}
		public string AuthorFirstName { get; set; }
		public string AuthorLastName { get; set; }
		public int Year { get; set;	}
		public int Id { get; set; }
		public string Location { get; set; }
		public Boolean Avaliable { get; set; }
		public Boolean Fiction { get; set; }
		public DateTime? CheckoutDate { get; set; }
		public DateTime? ReturnDate { get; set; }
		
		public Book(int id, String title, String authorFirstName, string authorLastName, int year, Boolean fiction, string location) {
			Id = id;
			Title = title;
			AuthorFirstName = authorFirstName;
			AuthorLastName = authorLastName;
			Year = year;
			Fiction = fiction;
			Avaliable = true;
			Location = location;
		}
		
		// fails if book is chcked out by other borrower or this borrower is now allowed to check out
		public Boolean checkoutOrRenewBook(Borrower borrower, int weeks) {
			if (!borrower.Restriction) {
				this.CheckoutDate = DateTime.Now;
				this.ReturnDate = CheckoutDate.Value.AddDays(weeks * 7);
				if (borrower.addToCheckedOutBooks(this)) {
					this.Avaliable = false;
					return true;
				}
			}
			return false;
		}
		
		public Boolean returnBook(Borrower borrower) {
			if (CheckoutDate != null) {
				Boolean isOnTime = false;
				if (DateTime.Now < this.ReturnDate) {
					isOnTime = true;
				}
				if (borrower.removeFromCheckedOutBooks(this, isOnTime)) {
					this.CheckoutDate = null;
					this.ReturnDate = null;
					this.Avaliable = true;
					return true;			// success
				}
			}
			return false;				// fail, book wasn't even checked out
		}
	}
}
