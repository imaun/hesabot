using Hesabot.Telegram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabot.Telegram {

    public class BotController
    {


        public BotController() {

        }


        public async Task<BotCommand> ProccessAsync(BotCommand command) {
            if (command == null)
                throw new ArgumentNullException(nameof(command));

            var result = command;

            if(command.Text == null) {

                return result;
            }


        }


    }
}
