using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MyBankMobileApp
{
    public class Account
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal CurrentAccountBalance { get; set; }
        public AccountType AccountType { get; set; }
        public string AccountNumberGenerated { get; set; } // Account number generated here

        //We'll store the hash and salt pin here for account transaction here
        public byte[] PinHash { get; set; }
        public byte[] pinSalt { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        Random random = new Random(); //come back to this later please - not clear yet
        public Account()
        {
           
            AccountName = $"{FirstName} {LastName}";
        }

    }
    public enum AccountType
    {
        Savings,
        Current,
        Corporate
        
    }


}
