using System;
using System.Threading.Tasks;
using Hesabot.Core.Models;
using Hesabot.Storage.Core;
using Hesabot.Services.Models;

namespace Hesabot.Services {

    public class AccountService { 

        private readonly IBaseRepository<Account, long> _repository;

        public AccountService(IBaseRepository<Account, long> repository) {
            _repository = repository ?? throw new ArgumentNullException(nameof(_repository));
        }

        public async Task<ServiceResult<Account>> CreateAsync(CreateAccountDto model) {
            if(model == null)
                throw new ArgumentNullException(nameof(model));

            if(string.IsNullOrWhiteSpace())
        }
    }
}
