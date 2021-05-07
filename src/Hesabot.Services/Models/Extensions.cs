using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hesabot.Core.Extensions;
using Hesabot.Core.Models;
using Hesabot.Services.Models;

namespace Hesabot.Services.Extensions {

    public static class Extensions {

        public static Account ToResult(this CreateAccountDto dto)
            => new Account {
                Title = dto.Title,
                CardNumber = dto.CardNumber,
                InitBalance = dto.InitBalance,
                Description = dto.Description,
                UserId = dto.UserId,
                IsDefault = dto.IsDefault
            };
    }
}
