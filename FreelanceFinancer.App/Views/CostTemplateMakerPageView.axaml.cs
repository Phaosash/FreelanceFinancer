using Avalonia.Controls;
using FreelanceFinancer.App.ViewModels;
using System.Diagnostics;

namespace FreelanceFinancer.App.Views;

public partial class CostTemplateMakerPageView : UserControl {
    private readonly CostTemplateMakerPageVeiwModel _model = new();

    public CostTemplateMakerPageView (){
        InitializeComponent();
        DataContext = _model;
    }
}