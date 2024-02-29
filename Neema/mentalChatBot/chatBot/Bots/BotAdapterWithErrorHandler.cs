namespace chatBot.Bots
{

    using Microsoft.Bot.Builder;
    using Microsoft.Bot.Builder.Integration.AspNet.Core;
    using Microsoft.Bot.Connector.Authentication;

    public class BotAdapterWithErrorHandler : BotFrameworkHttpAdapter
    {
        public BotAdapterWithErrorHandler(IConfiguration configuration) : base(configuration)
        {
            OnTurnError = async (turnContext, exception) =>
            {
                // Log any leaked exception from the application.
                Console.WriteLine($"Exception caught : {exception.Message}");

                // Send a catch-all apology to the user.
                await turnContext.SendActivityAsync("Sorry, it looks like something went wrong.");
            };
        }
    }
}