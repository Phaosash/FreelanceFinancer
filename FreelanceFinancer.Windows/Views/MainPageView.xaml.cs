using FreelanceFinancer.Windows.ViewModels;
using System.Windows.Controls;

namespace FreelanceFinancer.Windows.Views;

public partial class MainPageView : UserControl {
    private readonly MainPageViewModel viewModel;

    public MainPageView (){
        InitializeComponent();
        viewModel = new MainPageViewModel();
        DataContext = viewModel;
    }
}