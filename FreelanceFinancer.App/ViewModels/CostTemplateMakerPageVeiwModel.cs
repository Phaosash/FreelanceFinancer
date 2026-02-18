using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreelanceFinancer.App.Views.Controls;
using System.Collections.ObjectModel;

namespace FreelanceFinancer.App.ViewModels;

internal partial class CostTemplateMakerPageVeiwModel: ViewModelBase {
    [ObservableProperty] private ObservableCollection<CategoryView> _categories = [];

    [RelayCommand] private void AddNewCategory (){
        Categories.Add(new CategoryView());
    }
}