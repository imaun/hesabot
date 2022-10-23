using System.Threading.Tasks;
using System.Collections.Generic;
using Hesabot.Storage.Core;
using Hesabot.Core.Models;

namespace Hesabot.Storage.Contracts
{

    public interface IHashtagRepository : IBaseRepository<Hashtag, long>
    {

        Task<Hashtag> FindByTitleAsync(long userId, string title);

        Task<bool> ExistAsync(long userId, string title);

        Task<IReadOnlyCollection<Hashtag>> GetUserHashtagsAsync(long userId);
    }
}
