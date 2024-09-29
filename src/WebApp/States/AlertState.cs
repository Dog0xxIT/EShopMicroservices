using WebApp.Models.Common;

namespace EShop.WebApp.States
{
    public class AlertState
    {
        public Queue<AlertItem> QueueAlerts { get; private set; }

        public event Action AlertChanged;

        public AlertState()
        {
            QueueAlerts = new();
        }

        public void AddMessage(AlertItem alert)
        {
            QueueAlerts.Enqueue(alert);
            AlertChanged?.Invoke();

            var timer = new System.Timers.Timer
            {
                Interval = 5000,
                AutoReset = true,
                Enabled = true,
            };

            timer.Elapsed += (sender, args) =>
            {
                if (QueueAlerts.Any())
                {
                    QueueAlerts.Dequeue();
                    AlertChanged?.Invoke();
                }
                else
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };
        }
    }
}
