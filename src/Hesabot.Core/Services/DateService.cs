using System;

namespace Hesabot.Core.Services {

    public interface IDateService {

        DateTime UtcNow();

        DateTime Now();
    }

    public class DateService: IDateService {

        public DateTime UtcNow() => DateTime.UtcNow;

        public DateTime Now() => DateTime.Now;
    }
}
