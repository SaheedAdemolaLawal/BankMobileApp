using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyBankMobileApp
{
    public class Transaction
    {
        public int Id { set; get; }
        public string TransactionUniqueReference { set; get; }
        public decimal TransactionAmount { set; get; }
        public decimal TransactionFee { set; get; } = 0; //come back to this later
        public TranStatus TransactionStatus { set; get; }
        public bool IsSuccessful => TransactionStatus.Equals(TranStatus.Successful); //Check later
        public string TransactionSourceAccount {  set; get; }
        public string TransactionDestinationAccount { set; get;}
        public string TransactionParticulars { set; get; }
        public TranType TransactionType {  set; get; }
        public DateTime TransactionDate { set; get; }
    }
}
public enum TranStatus
{
    Failed,
    Successful,
    Error
}
public enum TranType
{
    Deposit,
    Withdrawal,
    Transfer,
    Balance
}
