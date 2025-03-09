using Avalonia.ReactiveUI;
using ChronoDSTranslator.ViewModels;

namespace ChronoDSTranslator.Views;

public partial class MainView : ReactiveUserControl<MainViewModel>
{
    public MainView()
    {
        DataContext = new MainViewModel();
        InitializeComponent();
    }
}