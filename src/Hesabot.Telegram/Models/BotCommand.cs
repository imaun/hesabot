using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace Hesabot.Telegram.Models { 

    public class BotCommand {

        public BotCommand() { }

        public BotCommand(Message message) {
            Text = message.Text;
            ChatId = message.Chat.Id;
            Username = message.From.Username;
            FirstName = message.From.FirstName;
            LastName = message.From.LastName;
            TelegramId = message.From.Id;
            MessageId = message.MessageId;
        }

        public long Id { get; set; }

        public DateTime SendTime { get; set; }

        public string Text { get; set; }

        public string Command {
            get {
                try {
                    var idx = Text.IndexOf("/");
                    if (idx == -1)
                        return Text;
                    var first_space = Text.IndexOf(" ");
                    var hasSpace = first_space > -1;
                    if (hasSpace)
                        return Text.Substring(idx, first_space + 1);
                    return Text.Substring(idx, Text.Length);
                }
                catch {
                    return string.Empty;
                }
            }
        }

        public long ChatId { get; set; }

        public string OutputText { get; set; }

        public List<string> Params { get; set; }

        public string Parameters {
            get {
                try {
                    if (Command == string.Empty)
                        return string.Empty;

                    if (Command.StartsWith("/", StringComparison.CurrentCultureIgnoreCase)) {
                        if (Text.Trim() == Command.Trim())
                            return string.Empty;

                        return Text.Substring(Command.Length,
                            Text.Length - Command.Length).Trim();
                    }
                    var first_space = Text.IndexOf(" ");
                    return Text.Substring(first_space,
                            Text.Length - first_space).Trim();
                }
                catch {
                    return string.Empty;
                }
            }
        }

        public bool HasError { get; set; }

        public string ErrorMessage { get; set; }

        public string Username { get; set; }

        public long UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long TelegramId { get; set; }

        public int MessageId { get; set; }

        public InlineKeyboardMarkup InlineButtons { get; set; }

        public ReplyKeyboardMarkup KeyboardButtons { get; set; }

    }

}
