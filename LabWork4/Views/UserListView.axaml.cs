using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LabWork4.ViewModels;

namespace LabWork4.Views;

public partial class UserListView : UserControl
{
    public UserListView()
    {
        DataContext = new UserListViewModel();
        InitializeComponent();
    }
}