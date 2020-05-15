using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem {

	public class Borrower {
		private int borrowerNum;
		private String name;
		private DateTime dob;
		private HashSet<Book> checkedOutBooks = new HashSet<Book>();
		private Boolean isAllowed;
		private int numReturnedLate;
		
		public Borrower(String name_, DateTime dob_) {
			//this.borrowerNum = newBorrowerNum(); 			// TODO: make funciton elsewhere
			name = name_;
			dob = dob_;
			isAllowed = true;
		}
		
		// TODO: come up with calculation for those not allowed		
		public Boolean getIsAllowed(){
			return this.isAllowed;
		}
		
		public void addToCheckedOutBooks(Book book) {
			checkedOutBooks.Add(book);
		}
		
		public void removeFromCheckedOutBooks(Book book, Boolean isOnTime) {
			checkedOutBooks.Remove(book);
			if (!isOnTime) {
				numReturnedLate++;
			}
		}
	}
}
