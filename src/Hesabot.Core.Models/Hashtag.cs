using System;
using NPoco;

namespace Hesabot.Core.Models {

    [TableName("Hashtags")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class Hashtag {

        public Hashtag() { }

        public long Id { get; set; }

        public string Title { get; set; }

        public DateTime CreateDate { get; set; }

        public long? ParentId { get; set; }

        public string Description { get; set; }

        public long UserId { get; set; }
    }
}
