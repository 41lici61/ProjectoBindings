using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace repasoFinal.ViewModels;

public partial class MainViewModel : ViewModelBase
{

    [ObservableProperty] private bool isOpen = false;

    [RelayCommand]
    public void open()
    {
        IsOpen = true;
    }
    
    [RelayCommand]
    public void close()
    {
        IsOpen = false;
    }

}