using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabot.Services.Models {

    public class CreatePersonDto {
        public string Title { get; set; }
        public string TelegramUsername { get; set; }
        public string Phone { get; set; }
        public long UserId { get; set; }
    }

}
