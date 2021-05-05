using System;
using NPoco;

namespace Hesabot.Core.Models {

    [TableName("Accounts")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class Account {

        public Account() { }

        public long Id { get; set; }

        public string Title { get; set; }

        public bool Active { get; set; }

        public string AccountNumber { get; set; }

        public string CardNumber { get; set; }

        public string BankName { get; set; }

        public long InitBalance { get; set; }

        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifyDate { get; set; }

        public long UserId { get; set; }

        public bool IsDefault { get; set; }

    }
}
