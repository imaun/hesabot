using Hesabot.Core.Models;

namespace Hesabot.Services.Models {

    public class CreateAccountDto {
        public string Title { get; set; }

        public string CardNumber { get; set; }

        public long InitBalance { get; set; }

        public string Description { get; set; }

        public long UserId { get; set; }

        public bool IsDefault { get; set; }
    }

    public class AccountListDto : ListDto<AccountListItemDto> { }

    public class AccountListItemDto {

        public long Id { get; set; }
        public string Title { get; set; }
        public long Balance { get; set; }
        public string CardNumber { get; set; }
    }

}
