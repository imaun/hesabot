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

    public class UserRepository : BaseRepository<User, Guid>, IUserRepository
    {
        public UserRepository(IDatabase db) : base(db) {
        }

        public Task<User> FindByTelegramUserNameAsync(string telegramUserName) {
            throw new NotImplementedException();
        }
    }
}
