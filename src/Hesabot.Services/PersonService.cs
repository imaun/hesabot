using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hesabot.Resources;
using Hesabot.Storage.Core;
using Hesabot.Core.Models;
using Hesabot.Core.Services;
using Hesabot.Core.Exceptions;
using Hesabot.Core.Extensions;
using Hesabot.Services.Models;

namespace Hesabot.Services {

    public class PersonService {

        private readonly IDateService _dateService;
        private readonly IBaseRepository<Person, long> _repository;

        public PersonService(
            IDateService dateService,
            IBaseRepository<Person, long> repository) {
            _dateService = dateService ?? throw new ArgumentNullException(nameof(dateService));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<ServiceResult<Person>> CreateAsync(CreatePersonDto model) {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            if (model.UserId <= 0)
                throw new InvalidUserIdException();

            var result = new ServiceResult<Person>();

            if (model.Title.IsNotNullOrEmpty())
                return result.Which(
                    isValid: false, 
                    withMessage: ErrorText.Person_Title_Required);

            var existed = await FindByTitleAsync(model.UserId, model.Title);
            if(existed != null) {
                result.Result = existed;
                return await Task.FromResult(result);
            }

            var person = new Person {
                CreateDate = _dateService.UtcNow(),
                Phone = model.Phone,
                TelegramUsername = model.TelegramUsername,
                Title = model.Title.ApplyCorrectYeKe()
            };

            await _repository.InsertAsync(person);
            result.Result = person;

            return await Task.FromResult(result);
        }

        public async Task<Person> FindByTitleAsync(long userId, string title) {
            string query = @"SELECT * FROM [People] WHERE [UserId] = @0 AND UPPER([Title]) = @1";
            return await _repository.FirstOrDefaultAsync(query, userId, title.ApplyCorrectYeKe().ToUpper());
        }


    }
}
