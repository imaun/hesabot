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

        public static Account Map(this CreateAccountDto dto)
            => new Account {
                Title = dto.Title.ApplyCorrectYeKe(),
                CardNumber = dto.CardNumber,
                InitBalance = dto.InitBalance,
                Description = dto.Description.ApplyCorrectYeKe(),
                UserId = dto.UserId,
                IsDefault = dto.IsDefault
            };

        public static Hashtag Map(this CreateHashtagDto dto)
            => new Hashtag {
                Title = dto.Title.Trim().ApplyCorrectYeKe(),
                UserId = dto.UserId
            };

        public static Transaction Map(this CreateTransactionDto dto)
            => new Transaction
            {
                AccountId = dto.AccountId,
                Amount = dto.Amount,
                Title = dto.Title,
                Hashtag = dto.Hashtag,
                MessageId = dto.MessageId,
                TransactionType = dto.TransactionType
            };
    }
}
