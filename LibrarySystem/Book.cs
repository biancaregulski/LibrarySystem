using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem {
	public class Book {
		private int bookNum;
		private String title;
		private String author;
		private int year;
		private String location;
		Boolean avaliable;
		DateTime? checkoutDate;
		DateTime? returnDate;
		
		public Book(String title, String author, int year, String location) {
			//bookNum = newBookNum();		// TODO: make function elsewhere
			this.title = title;
			this.author = author;
			this.year = year;
			this.location = location;
			this.avaliable = true;
		}
		
		// fails if book is already checkout out or borrower is now allowed to check out
		public Boolean checkoutBook(Borrower borrower, int weeks) {
			if (checkoutDate == null) {	
				if (borrower.getIsAllowed()) {
					this.checkoutDate = DateTime.Now;
					this.returnDate = checkoutDate.Value.AddDays(weeks * 7);
					borrower.addToCheckedOutBooks(this);
					return true;
				}
			}
			return false;
		}
		
		public Boolean returnBook(Borrower borrower) {
			if (checkoutDate == null) {
				Boolean isOnTime = false;
				if (DateTime.Now < this.returnDate) {
					isOnTime = true;
				}
				borrower.removeFromCheckedOutBooks(this, isOnTime);
				this.checkoutDate = null;
				this.returnDate = null;
				return true;			// success
			}
			return false;				// fail, book wasn't even checked out
		}
		
		public void setTitle(String title) { this.title = title; }
		public void setAuthor(String author) { this.author = author; }
		public void setYear(int year) { this.year = year; }
		public void setLocation(String location) { this.location = location; }
		
		public String getTitle() { return title; }
		public String getAuthor() { return author; }
		public int getYear() { return year; }
		public String getLocation() { return location; }
	}
}
