using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem {	
	public class Borrower {
		
		private string name;
		public string Name {
			get { return name; }
			set { name = value; }
		}
		
		private DateTime dob;
		public DateTime Dob {
			get { return dob; }
			set { dob = value; }
		}
		
		// TODO: come up with calculation for those not allowed
		private Boolean restriction;
		public Boolean Restriction {
			get { return restriction; }
			set { restriction = value; }
		}
		
		private List<Book> checkedOutBooks = new List<Book>();
		public List<Book> CheckedOutBooks {
			get { return checkedOutBooks; }
			set { checkedOutBooks = value; }
		}
			
		private int numReturnedLate;
		
		public Borrower(string name, DateTime dob) {
			this.name = name;
			this.dob = dob;
			this.restriction = false;
		}
		
		public Boolean addToCheckedOutBooks(Book book) {
			if (checkedOutBooks.Count < 5) {
				checkedOutBooks.Add(book);
				return true;
			}
			return false;			// too many books checked out (max 5) 
		}
		
		public Boolean removeFromCheckedOutBooks(Book book, Boolean isOnTime) {
			if (checkedOutBooks.Remove(book)) {
				if (!isOnTime) {
					numReturnedLate++;
				}
				return true;
			}
			return false;
		}
	}
}
