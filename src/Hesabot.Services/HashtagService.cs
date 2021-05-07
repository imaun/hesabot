﻿using System;
using Hesabot.Core.Models;
using Hesabot.Core.Services;
using Hesabot.Core.Extensions;
using Hesabot.Storage.Core;
using Hesabot.Services.Models;
using Hesabot.Services.Extensions;
using System.Threading.Tasks;

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
                return result.Which(isValid: false, withMessage: "");


        }
    }
}