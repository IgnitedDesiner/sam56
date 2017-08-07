using System;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

// For more information about this template visit http://aka.ms/azurebots-csharp-luis
[Serializable]
public class BasicLuisDialog : LuisDialog<object>
{
    public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(Utils.GetAppSetting("LuisAppId"), Utils.GetAppSetting("LuisAPIKey"))))
    {
    }

    [LuisIntent("None")]
    public async Task NoneIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the none intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    // Go to https://luis.ai and create a new intent, then train/publish your luis app.
    // Finally replace "MyIntent" with the name of your newly created intent in the following handler
    [LuisIntent("Turn_Off_AC")]
    public async Task TurnOffACIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Turn Off AC intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Turn_On_AC")]
    public async Task TurnOnACIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Turn On AC intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Cool_Down")]
    public async Task CoolDownIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Cool Down intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Warm_Up")]
    public async Task WarmUpIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the Warm Up intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
}