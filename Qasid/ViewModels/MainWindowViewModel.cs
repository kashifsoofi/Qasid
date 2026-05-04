using System.Collections.ObjectModel;

namespace Qasid.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";
    public ObservableCollection<CollectionViewModel> Collections { get; set; }
    
    
}