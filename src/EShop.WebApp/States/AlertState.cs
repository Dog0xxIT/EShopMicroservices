namespace EShop.WebApp.States;

public class AlertState
{
    public List<Alert> Alerts { get; private set; }

    public event Action AlertChanged;


    public void AddMessage(Alert alert)
    {
        Alerts.Add(alert);
        AlertChanged.Invoke();
    }

    public class Alert
    {
        public string Message { get; set; }
        public AlertType Type { get; set; }
    }

    public enum AlertType
    {
        Primary,
        Secondary,
        Success,
        Info,
        Danger,
        Warning,
        Dark,
        Light
    }
}