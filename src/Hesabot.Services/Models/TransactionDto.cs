namespace Hesabot.Services.Models
{

    public class CreateTransactionDto
    {
        public string Title { get; set; }
        public long Amount { get; set; }
        public string Hashtag { get; set; }
        public string PersonName { get; set; }
        public long MessageId { get; set; }
        public long? AccountId { get; set; }
    }
}
