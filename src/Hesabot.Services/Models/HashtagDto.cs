using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabot.Services.Models {

    public class CreateHashtagDto {
        public long UserId { get; set; }
        public string Title { get; set; }
    }
}
