using CommunityToolkit.Mvvm.ComponentModel;

namespace FreelanceFinancer.App.ViewModels;

public partial class MainWindowViewModel : ViewModelBase {
    [ObservableProperty] ViewModelBase? _currentPage;
    private readonly CostTemplateMakerPageVeiwModel _vm = new();

    public MainWindowViewModel (){
        _currentPage = _vm;
    }
}