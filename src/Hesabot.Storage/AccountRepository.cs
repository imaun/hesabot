using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hesabot.Storage.Core;
using Hesabot.Core.Models;
using Hesabot.Storage.Contracts;
using NPoco;

namespace Hesabot.Storage
{
    public class AccountRepository : BaseRepository<Account, long>, IAccountRepository
    {
        public AccountRepository(IDatabase db) : base(db) {
        }

        public Task<IReadOnlyCollection<Account>> GetUserAccountsAsync(long userId) {
            throw new NotImplementedException();
        }
    }
}
