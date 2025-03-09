using Avalonia.ReactiveUI;
using ChronoDSTranslator.ViewModels.Controls;

namespace ChronoDSTranslator.Views.Controls;

public partial class AppToolbar : ReactiveUserControl<AppToolbarViewModel>
{
    public AppToolbar()
    {
        InitializeComponent();
    }
}