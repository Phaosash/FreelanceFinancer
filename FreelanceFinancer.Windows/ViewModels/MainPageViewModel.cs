using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace FreelanceFinancer.Windows.ViewModels;

public partial class MainPageViewModel: ObservableObject {
    private bool _isSidebarCollapsed = false;
    private const float MaxSidebarWidth = 250.0f;
    private const float MinSidebarWidth = 40.0f;

    [ObservableProperty] private GridLength _sidebarWidth;

    public MainPageViewModel (){
        if (_isSidebarCollapsed){
            SidebarWidth = new GridLength(MinSidebarWidth);
        } else {
            SidebarWidth = new GridLength(MaxSidebarWidth);
        }
    }

    [RelayCommand] private void ToggleSidebar (){
        if (_isSidebarCollapsed){
            SidebarWidth = new GridLength(MaxSidebarWidth);
            _isSidebarCollapsed = false;
        } else {
            SidebarWidth = new GridLength(MinSidebarWidth);
            _isSidebarCollapsed = true;
        }
    }
}