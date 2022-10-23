using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hesabot.Core.Models;
using Hesabot.Storage.Core;
using Hesabot.Storage.Contracts;

namespace Hesabot.Storage
{

    public class TransactionRepository : BaseRepository<Transaction, long>, ITransactionRepository
    {

        public TransactionRepository(NPoco.IDatabase db) : base(db) {
        }
    }
}
