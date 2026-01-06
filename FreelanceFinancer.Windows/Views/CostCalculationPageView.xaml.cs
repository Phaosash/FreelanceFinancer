using FreelanceFinancer.Windows.ViewModels;
using System.Windows.Controls;


namespace FreelanceFinancer.Windows.Views;

public partial class CostCalculationPageView : UserControl {
    private readonly CostCalculationsPageViewModel viewModel;

    public CostCalculationPageView (){
        InitializeComponent();
        viewModel = new CostCalculationsPageViewModel();

        DataContext = viewModel;
    }
}