using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication
{
    public enum BookStatus { Default, Borrowed, Returned }
    public class BorrowDetails
    {
        private static int s_borrowID = 2000;
        public string BorrowID { get; }
        public string BookID { get;}
        public string UserID { get; }
        public DateTime BorrowedDate { get; set; }
        public int BorrowBookCount { get; set; }
        public BookStatus BookStatus { get; set; }
        public double PaidFineAmount { get; set; }

        public BorrowDetails(string bookID, string userID, DateTime borrowedDate, int borrowBookCount, BookStatus bookStatus, double paidFineAmount)
        {
            s_borrowID++;
            BorrowID = "LB" + s_borrowID;
            BookID = bookID;
            UserID = userID;
            BorrowedDate = borrowedDate;
            BorrowBookCount = borrowBookCount;
            BookStatus = bookStatus;
            PaidFineAmount = paidFineAmount;

        }

    }
}