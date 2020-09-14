using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotLD.Models.Commands
{
    public class StartCommand : Command
    {
        public override string Name => @"/start";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO: Command logic -_----- parsing and other HERE

            await client.SendTextMessageAsync(chatId, "Hello! I'm Schedule bot!\n\n\n*P.S* Not working yet", replyToMessageId: messageId);
        }
    }
}
