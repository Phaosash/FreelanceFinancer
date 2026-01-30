using CommunityToolkit.Mvvm.ComponentModel;
using FreelanceFinancer.App.Models;

namespace FreelanceFinancer.App.ViewModels.Controls;

internal partial class FieldsViewControl: ObservableObject {
    private readonly CategoryViewControl _veiwModel;

    [ObservableProperty] private FieldsDTO _fieldsDTO = new();

    public FieldsViewControl (CategoryViewControl pageVeiwModel){
        _veiwModel = pageVeiwModel;
    }

    //  TODO: Create a method to send the data from the _fieldsDTO to the _viewModel.
}