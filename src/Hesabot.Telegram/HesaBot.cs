using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types.InlineQueryResults;
using Hesabot.Telegram.Models;

namespace Hesabot.Telegram {

    public class HesaBot {

        private readonly BotSetting _setting;
        private readonly TelegramBotClient _bot;
        private User _me;
        private CancellationTokenSource _cancelTokenSrc;

        public HesaBot(BotSetting setting) {
            _setting = setting ?? throw new ArgumentNullException(nameof(setting));
            _bot = new TelegramBotClient(_setting.Token);
            _cancelTokenSrc = new CancellationTokenSource();
            
        }

        public async Task Start() {
            _me = await _bot.GetMeAsync();
            //Start the Bot
            _bot.StartReceiving(new DefaultUpdateHandler(
                    handleUpdateAsync,
                    handleErrorAsync),
                _cancelTokenSrc.Token);
        }

        private async Task handleUpdateAsync(
            ITelegramBotClient botClient, 
            Update update, 
            CancellationToken cancellationToken) {

            var handler = update.Type switch {
                UpdateType.Message => onMessageReceived(update.Message),
                UpdateType.EditedMessage => onMessageReceived(update.Message),
                UpdateType.CallbackQuery => onCallbackQueryReceived(update.CallbackQuery),
                UpdateType.InlineQuery => onInlineQueryReceived(update.InlineQuery),
                UpdateType.ChosenInlineResult => onChosenInlineResultReceived(update.ChosenInlineResult),
                // UpdateType.Unknown:
                // UpdateType.ChannelPost:
                // UpdateType.EditedChannelPost:
                // UpdateType.ShippingQuery:
                // UpdateType.PreCheckoutQuery:
                // UpdateType.Poll:
                _ => defaultUpdateHandlerAsync(update)
            };

            try {
                await handler;
            }
            catch (Exception exception) {
                await handleErrorAsync(botClient, exception, cancellationToken);
            }
        }

        private async Task onMessageReceived(Message message) {

        }

        private async Task onCallbackQueryReceived(CallbackQuery query) {

        }

        private async Task onInlineQueryReceived(InlineQuery query) {

        }

        private async Task onChosenInlineResultReceived(ChosenInlineResult result) {

        }

        private async Task defaultUpdateHandlerAsync(Update update) {

        }

        private async Task handleErrorAsync(
            ITelegramBotClient botClient, 
            Exception exception, 
            CancellationToken cancellationToken) {

        }

    }
}
