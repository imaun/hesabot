using System;
using NPoco;

namespace Hesabot.Core.Models {

    [TableName("Users")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class User {

        public User() { }

        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? WebRegisterDate { get; set; }

        public string TelegramId { get; set; }

        public string TelegramUserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Ignore]
        public string Fullname {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

    }
}
