using System;
using NPoco;

namespace Hesabot.Core.Models {

    [TableName("Peapole")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class Person {

        public Person() { }

        public long Id { get; set; }

        public string Title { get; set; }

        public string TelegramUsername { get; set; }

        public string Email { get; set; }

        public DateTime CreateDate { get; set; }

        public string Phone { get; set; }

        public string Description { get; set; }

        public long UserId { get; set; }
    }
}
