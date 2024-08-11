using Microsoft.AspNetCore.Components;

namespace EShop.WebApp.States
{
    public class AuthState
    {
        private NavigationManager _navigationManager;

        public AuthState(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public event Action OnChanged;

        private void NotifyStateChanged() => OnChanged?.Invoke();
    }
}
