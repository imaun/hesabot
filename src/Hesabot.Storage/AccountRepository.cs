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
        const string _table = "[Account]";

        public AccountRepository(IDatabase db) : base(db) {
        }

        public async Task<bool> ExistAsync(Guid userId, string title) {
            string query = @"SELECT COUNT(Id) FROM [Accounts] WHERE [UserId] = @0 AND UPPER([Title]) = @1";
            return await AnyAsync(query, userId, title.ToUpper());
        }

        public async Task<Account> GetByTitleAsync(Guid userId, string title) {
            var query = @"SELECT * FROM [Accounts] WHERE [UserId] = @0 AND UPPER([Title]) = @1";
            return await FirstOrDefaultAsync(query, userId, title.ToUpper());
        }

        public async Task<IReadOnlyCollection<Account>> GetUserAccountsAsync(long userId) 
            => (await QueryAsync(_ => _.UserId == userId)).ToList();

        public async Task<bool> HasAnyAsync(Guid userId) {
            throw new NotImplementedException();
        }
    }
}
