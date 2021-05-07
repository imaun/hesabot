using System.Collections.Generic;

namespace Hesabot.Services.Models {

    public abstract class ListDto<T> where T: class {

        public ListDto() => Items = new List<T>();

        public IEnumerable<T> Items { get; set; }
    }
}
