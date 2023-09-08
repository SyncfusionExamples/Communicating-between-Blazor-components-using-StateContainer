
public class SessionGlobals
{
    public String? MainMessage { get; set; } = "Initial Value.";

    public event Action OnChange;

    public void SetMessage(string message)
    {
        MainMessage = message;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}

