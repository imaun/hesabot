using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hesabot.Core.Models;
using Hesabot.Storage.Core;

namespace Hesabot.Storage.Contracts
{
    public interface IAccountRepository : IBaseRepository<Account, long>
    {

        Task<bool> HasAnyAsync(Guid userId);

        Task<Account> GetByTitleAsync(Guid userId, string title);

        Task<bool> ExistAsync(Guid userId, string title);

        Task<IReadOnlyCollection<Account>> GetUserAccountsAsync(long userId);

    }
}
