using System;

namespace Hesabot.Core.Exceptions {

    public class HesabotException: Exception {

        public HesabotException(): base() { }

        public HesabotException(string message): base(message) { }
    }
}
