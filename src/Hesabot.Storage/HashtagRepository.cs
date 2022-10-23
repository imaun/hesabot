using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hesabot.Core.Models;
using Hesabot.Storage.Core;
using Hesabot.Storage.Contracts;
using NPoco;

namespace Hesabot.Storage
{
    public class HashtagRepository : BaseRepository<Hashtag, long>, IHashtagRepository
    {
        public HashtagRepository(IDatabase db) : base(db) {
        }

        public Task<bool> ExistAsync(long userId, string title) {
            throw new NotImplementedException();
        }

        public Task<Hashtag> FindByTitleAsync(long userId, string title) {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<Hashtag>> GetUserHashtagsAsync(long userId) {
            throw new NotImplementedException();
        }
    }
}
