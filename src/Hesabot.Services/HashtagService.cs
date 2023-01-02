using System;
using Hesabot.Core.Models;
using Hesabot.Core.Services;
using Hesabot.Core.Extensions;
using Hesabot.Storage.Core;
using Hesabot.Services.Models;
using Hesabot.Services.Extensions;
using System.Threading.Tasks;
using Hesabot.Resources;

namespace Hesabot.Services {

    public class HashtagService {

        private readonly IDateService _dateService;
        private readonly IBaseRepository<Hashtag, long> _repository;

        public HashtagService(
            IDateService dateService,
            IBaseRepository<Hashtag, long> repository) {

            _dateService = dateService ?? throw new ArgumentNullException(nameof(dateService));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<ServiceResult<Hashtag>> CreateAsync(CreateHashtagDto model) {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            var result = new ServiceResult<Hashtag> {
                Result = new Hashtag {
                    Title = model.Title,
                    UserId = model.UserId
                }
            };

            if (model.Title.IsNotNullOrEmpty())
                return result.Which(
                    isValid: false, 
                    withMessage: ErrorText.Hashtag_Title_Required);

            var existed = await GetAsync(model.UserId, model.Title);
            if (existed != null)
                return new ServiceResult<Hashtag> { Result = existed };

            var hashtag = model.Map();
            hashtag.CreateDate = _dateService.UtcNow();

            await _repository.InsertAsync(hashtag);

            return new ServiceResult<Hashtag> { Result = hashtag };
        }

        public async Task<Hashtag> GetAsync(long userId, string title) {
            string query = @"SELECT * FROM [Hashtags] WHERE [UserId] = @0 AND UPPER([Title]) = @1";
            return await _repository.FirstOrDefaultAsync(query, userId, title.ToUpper());
        }

        public async Task<bool> ExistAsync(long userId, string title) {
            string query = @"SELECT COUNT([Id]) FROM [Hashtags] WHERE [UserId] = @0 AND UPPER([Title]) = @1";
            return await _repository.AnyAsync(query, userId, title.ToUpper());
        }

    }
}
