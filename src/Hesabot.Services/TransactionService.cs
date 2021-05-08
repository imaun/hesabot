using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hesabot.Resources;
using Hesabot.Core.Models;
using Hesabot.Core.Services;
using Hesabot.Core.Exceptions;
using Hesabot.Core.Extensions;
using Hesabot.Storage.Core;
using Hesabot.Services.Models;
using Hesabot.Services.Extensions;

namespace Hesabot.Services {

    public class TransactionService {

        private readonly IDateService _dateService;
        private readonly IBaseRepository<Transaction, long> _repository;

        public TransactionService(
            IDateService dateService,
            IBaseRepository<Transaction, long> repository) {
            _dateService = dateService ?? throw new ArgumentNullException(nameof(dateService));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }


        public async Task<bool> HasAnyAsync(long userId) {
            string query = @"SELECT COUNT(Id) FROM [Transactions] WHERE [UserId] = @0";
            return await _repository.AnyAsync(query, userId);
        }

        public async Task<Transaction> FindByMessageIdAsync(long userId, string messageId) {
            string query = @"SELECT * FROM [Transactions] WHERE UserId = @0 AND MessageId = @1";
            return await _repository.FirstOrDefaultAsync(query, userId, messageId);
        }

    }
}
