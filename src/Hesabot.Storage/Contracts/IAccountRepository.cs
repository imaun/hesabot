using System.Collections.Generic;
using System.Threading.Tasks;
using Hesabot.Core.Models;
using Hesabot.Storage.Core;

namespace Hesabot.Storage.Contracts
{
    public interface IAccountRepository : IBaseRepository<Account, long>
    {

        Task<IReadOnlyCollection<Account>> GetUserAccountsAsync(long userId);

    }
}
