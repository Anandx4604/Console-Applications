using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTHRechargeApplication
{
    public class UserRegistration
    {
        //fields
        private static int s_userID = 1000;
        //properties
        public string UserID { get; }
        public string UserName { get; set; }
        public long MobileNumber { get; set; }
        public string EmailID { get; set; }
        public double WalletBalance { get; set; }

        public UserRegistration(string userName, long mobileNumber,string emailID, double walletBalance)
        {
            s_userID++;
            UserID = "UID" + s_userID;
            UserName = userName;
            MobileNumber = mobileNumber;
            EmailID = emailID;
            WalletBalance = walletBalance;

        }
        public void WalletRecharge(double amount)
        {
            WalletBalance += amount;
        }

        // public bool IsDeductBalance(double amount)
        // {
        //     if (WalletBalance < amount)
        //     {
        //         return false;
        //     }
        //     else
        //     {
        //         WalletBalance -= amount;
        //         return true;
        //     }

        // }
    }
}