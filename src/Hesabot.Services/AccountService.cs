using System;
using System.Linq;
using System.Threading.Tasks;
using Hesabot.Resources;
using Hesabot.Core.Models;
using Hesabot.Storage.Core;
using Hesabot.Core.Services;
using Hesabot.Core.Extensions;
using Hesabot.Services.Models;
using Hesabot.Services.Extensions;

namespace Hesabot.Services {

    public class AccountService {


        private readonly IDateService _dateService;
        private readonly IBaseRepository<Account, long> _repository;

        public AccountService(
            IDateService dateService,
            IBaseRepository<Account, long> repository) {
            _dateService = dateService ?? throw new ArgumentNullException(nameof(dateService));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Account> CreateDefaultAccountAsync(long userId) {
            var account = new Account {
                Active = true,
                CreateDate = _dateService.UtcNow(),
                ModifyDate = _dateService.UtcNow(),
                UserId = userId
            };

            await _repository.InsertAsync(account);

            return await Task.FromResult(account);
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
                return result.Which(
                    isValid: false, 
                    withMessage: ErrorText.Account_Title_Required);

            if (await ExistAsync(model.UserId, model.Title))
                return result.Which(
                    isValid: false,
                    withMessage: "");

            result.Result.CreateDate =
                result.Result.ModifyDate = _dateService.UtcNow();
            result.Result.Active = true;

            await _repository.InsertAsync(result.Result);

            return result;
        }

        public async Task<AccountListDto> GetUserAccountsAsync(long userId) {
            var query = await _repository.QueryAsync(_ => _.UserId == userId);
            return new AccountListDto {
                Items = query.Select(_=> new AccountListItemDto {
                    Balance = _.InitBalance,
                    CardNumber = _.CardNumber,
                    Id = _.Id,
                    Title = _.Title
                })
            };
        }

        public async Task<Account> GetAccountByTitleAsync(long userId, string title) {
            var query = @"SELECT * FROM [Accounts] WHERE [UserId] = @0 AND UPPER([Title]) = @1"; ;
            return await _repository.FirstOrDefaultAsync(query, userId, title.ToUpper());
        }

        public async Task<bool> ExistAsync(long userId, string title) {
            string query = @"SELECT COUNT(Id) FROM [Accounts] WHERE [UserId] = @0 AND UPPER([Title]) = @1";
            return await _repository.AnyAsync(query, userId, title);
        }

        public async Task<bool> HasAnyAsync(long userId) {
            string query = @"SELECT COUNT(Id) FROM [Accounts] WHERE [UserId] = @0";
            return await _repository.AnyAsync(query, userId);
        }
    }
}
