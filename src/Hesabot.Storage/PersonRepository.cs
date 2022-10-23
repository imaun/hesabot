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
    public class PersonRepository : BaseRepository<Person, long>, IPersonRepository
    {
        public PersonRepository(IDatabase db) : base(db) {
        }

        public Task<IReadOnlyCollection<Person>> GetUserPeaopleAsync(long userId) {
            throw new NotImplementedException();
        }
    }
}
