using System;
using System.Threading.Tasks;
using Hesabot.Core.Models;
using Hesabot.Core.Services;
using Hesabot.Core.Extensions;
using Hesabot.Storage.Core;
using Hesabot.Services.Models;

namespace Hesabot.Services {

    public class UserService {

        private readonly IDateService _dateService;
        private readonly IBaseRepository<User, long> _repository;

        public UserService(
            IDateService dateService,
            IBaseRepository<User, long> repository) {
            _dateService = dateService ?? throw new ArgumentNullException(nameof(dateService));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<ServiceResult<User>> CreateWithTelegramAsync(CreateTelegramUserDto model) {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            if (model.TelegramId.IsNullOrEmpty())
                throw new ArgumentNullException(nameof(model.TelegramId));

            var result = new ServiceResult<User>();

            var existed = await FindByTelegramIdAsync(model.TelegramId);

            if(existed != null) {
                result.Result = existed;
                return result;
            }

            var user = new User {
                CreateDate = _dateService.UtcNow(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                TelegramId = model.TelegramId,
                Username = model.Username
            };

            await _repository.InsertAsync(user);

            result.Result = user;
            return await Task.FromResult(result);
        }

        public async Task<User> FindByTelegramIdAsync(string telegramId) {
            if (telegramId.IsNullOrEmpty())
                throw new ArgumentNullException(nameof(telegramId));

            string query = @"SELECT * FROM [Users] WHERE [TelegramId] = @0";
            var user = await _repository.FirstOrDefaultAsync(query, telegramId);

            return await Task.FromResult(user);
        }


        public async Task<User> FindByUsernameAsync(string username) {
            if (username.IsNullOrEmpty())
                throw new ArgumentNullException(nameof(username));

            string query = @"SELECT * FROM [Users] WHERE UPPER[Username] = @0";
            var user = await _repository.FirstOrDefaultAsync(query, username.ToUpper());

            return await Task.FromResult(user);
        }


    }
}
