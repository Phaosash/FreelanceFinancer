using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreelanceFinancer.App.Models;
using System.Collections.Generic;

namespace FreelanceFinancer.App.ViewModels.Controls;

internal partial class CategoryViewControl (CostTemplateMakerPageVeiwModel pageVeiwModel): ObservableObject {
    private readonly CostTemplateMakerPageVeiwModel _templateMakerPageVeiwModel = pageVeiwModel;
    private readonly List<FieldsDTO> _categoryFields = [];  // Debating keeping it a list or if observable collection would be better.

    [ObservableProperty] private string _categoryName = string.Empty;
    [ObservableProperty] private FieldsDTO _categoryTotal = new();

    public void AddFieldDataToList (FieldsDTO field){
        _categoryFields.Add(field);
    }
}