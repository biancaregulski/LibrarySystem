using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem {	
	public class Borrower {
		
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime Dob { get; set; }
		public Boolean Restriction { get; set; }
		public List<Book> CheckedOutBooks { get; set; }
			
		private int numReturnedLate;
		
		public Borrower(string firstName, string lastName, DateTime dob) {
			FirstName = firstName;
			LastName = lastName;
			Dob = dob;
			Restriction = false;
			CheckedOutBooks  = new List<Book>();
		}
		
		public Boolean addToCheckedOutBooks(Book book) {
			if (CheckedOutBooks.Count < 5) {
				CheckedOutBooks.Add(book);
				return true;
			}
			return false;			// too many books checked out (max 5) 
		}
		
		public Boolean removeFromCheckedOutBooks(Book book, Boolean isOnTime) {
			if (CheckedOutBooks.Remove(book)) {
				if (!isOnTime) {
					numReturnedLate++;
				}
				return true;
			}
			return false;
		}
	}
}
