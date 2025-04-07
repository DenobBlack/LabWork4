using CommunityToolkit.Mvvm.ComponentModel;

namespace LabWork4.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private ObservableObject? _currentView;

    public MainViewModel()
    {
        CurrentView = new UserListViewModel();
    }
}
