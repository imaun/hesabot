using System;
using System.Linq;
using System.Threading.Tasks;
using Hesabot.Core.Extensions;
using Hesabot.Core.Models;
using Hesabot.Core.Services;
using Hesabot.Storage.Core;
using Hesabot.Services.Models;
using Hesabot.Services.Extensions;

namespace Hesabot.Services {

    public class AccountService {


        private readonly IDateService _dateService;
        private readonly IBaseRepository<Account, long> _repository;

        public AccountService(
            IDateService dateService,
            IBaseRepository<Account, long> repository) {
            dateService = _dateService ?? throw new ArgumentNullException(nameof(dateService));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<ServiceResult<Account>> CreateAsync(CreateAccountDto model) {
            if(model == null)
                throw new ArgumentNullException(nameof(model));

            var result = new ServiceResult<Account> {
                Result = model.ToResult()
            };

            if (model.UserId <= 0)
                throw new ArgumentOutOfRangeException(nameof(model.UserId));

            if (model.Title.IsNotNullOrEmpty())
                return result.Which(isValid: false, withMessage: "");

            result.Result.CreateDate =
                result.Result.ModifyDate = _dateService.UtcNow();
            result.Result.Active = true;

            await _repository.InsertAsync(result.Result);

            return result;
        }

        public async Task<bool> HasAny(long userId) {
            var query = await _repository.QueryAsync(_ => _.UserId == userId);
            return query.Count() > 0;
        }
    }
}
