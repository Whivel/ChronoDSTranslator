using Avalonia.ReactiveUI;
using ChronoDSTranslator.ViewModel;

namespace ChronoDSTranslator.Views;

public partial class MainView : ReactiveUserControl<MainViewModel>
{
    public MainView()
    {
        InitializeComponent();
    }
}