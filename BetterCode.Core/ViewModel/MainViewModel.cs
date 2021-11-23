using BetterCode.Core.Data;
using BetterCode.Core.Model;
using System.Collections.ObjectModel;

namespace BetterCode.Core.ViewModel;

public class MainViewModel : ViewModelBase
{
    private readonly ISessionDataProvider _sessionDataProvider;
    private Session? _selectedSession;

    public MainViewModel(ISessionDataProvider sessionDataProvider)
    {
        _sessionDataProvider = sessionDataProvider;
    }

    public async Task LoadAsync()
    {
        Sessions.Clear();
        var sessions = await _sessionDataProvider.GetSessionsAsync();
        foreach (var session in sessions)
        {
            Sessions.Add(session);
        }
    }

    public ObservableCollection<Session> Sessions { get; } = new();

    public Session? SelectedSession
    {
        get => _selectedSession;
        set
        {
            if (_selectedSession != value)
            {
                _selectedSession = value;
                OnPropertyChanged();
            }
        }
    }

}
