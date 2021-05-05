using System;
using NPoco;

namespace Hesabot.Core.Models {

    public enum TransactionType {
        Expense = 0,
        Income,
        Transfer
    }

    [TableName("Transactions")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class Transaction {

        public Transaction() { }

        public long Id { get; set; }

        public string Title { get; set; }

        public DateTime CreateDate { get; set; }

        public long Amount { get; set; }

        public string Hashtag { get; set; }

        public long HashtagId { get; set; }

        public long? PersonId { get; set; }

        public long UserId { get; set; }

        public string Description { get; set; }

        public TransactionType TransactionType { get; set; }

        public long MessageId { get; set; }

        public long? AccountId { get; set; }
    }
}
