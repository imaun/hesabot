using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hesabot.Storage.Core;
using Hesabot.Core.Models;

namespace Hesabot.Storage.Contracts
{
    public interface IUserRepository
    {

        Task<User> FindByTelegramUserNameAsync(string telegramUserName);
    }
}
