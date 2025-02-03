using CarAuctions.Client.Services.SignalR;
using CarAuctions.Shared.Models;
using MudBlazor;

namespace CarAuctions.Client.Services;

public class ChatHandler(ChatHub chatHub, ISnackbar snackbar)
{
    private readonly ISnackbar snackbar = snackbar;
    private readonly ChatHub chatHub = chatHub;

    public List<ChatMessage> Messages { get; private set; } = [];
    public event Action OnChange;

    public bool ConnectionStatus => chatHub?.IsConnected ?? false;
    public void NotifyStateHasChanged() => OnChange?.Invoke();

    public async Task SubscribeChat()
    {
		try
		{
			await DisposeAsync();

            chatHub.Reconnecting += OnReconnecting;
            chatHub.Reconnected += OnReconnected;
            chatHub.ChatHandler += OnMessageGet;

            await chatHub.Subscribe();

			snackbar.Add("Udało połączyć się z chatem", Severity.Success);
		}
		catch (Exception ex)
		{
			snackbar.Add($"Nie udało się połączyć z chatem", Severity.Error);
            Console.WriteLine(ex);
        }
    }
    private void OnReconnected()
    {
        NotifyStateHasChanged();
        snackbar.Add("Ponownie połączono z czatem", Severity.Success);
    }
    private void OnReconnecting()
    {
        snackbar.Add("Trwa próba połączenia z czatem", Severity.Info);
    }
    public async Task DisposeAsync()
    {
        chatHub.ChatHandler -= OnMessageGet;

        await chatHub.DisposeAsync();
    }

    private void OnMessageGet(ChatMessage chatMessage)
    {
        Messages.Add(chatMessage);
        snackbar.Add($"Przyszła wiadomość od {chatMessage.User}", Severity.Info);
        NotifyStateHasChanged();
    }
}
