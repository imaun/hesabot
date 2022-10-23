using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hesabot.Core.Models;
using Hesabot.Storage.Core;

namespace Hesabot.Storage.Contracts
{
    public interface IPersonRepository : IBaseRepository<Person, long>
    {

        Task<IReadOnlyCollection<Person>> GetUserPeaopleAsync(long userId);
    }
}
