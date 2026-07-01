using System;

namespace TimeKeepApp.Services
{
    public class AppState
    {
        private string _currentPage = "Department";
        public string CurrentPage
        {
            get => _currentPage;
            set
            {
                if (_currentPage != value)
                {
                    _currentPage = value;
                    NotifyStateChanged();
                }
            }
        }

        public event Action? OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}