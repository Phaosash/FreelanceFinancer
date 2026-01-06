using FreelanceFinancer.Windows.ViewModels;
using System.Windows.Controls;

namespace FreelanceFinancer.Windows.Views;

public partial class DashboardPageView : UserControl {
    private readonly DashboardPageViewModel viewModel;

    public DashboardPageView (){
        InitializeComponent();
        viewModel = new DashboardPageViewModel();

        DataContext = viewModel;
    }
}