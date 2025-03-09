using ChronoDSTranslator.ViewModels.Controls;
using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace ChronoDSTranslator.ViewModels;

public partial class MainViewModel : ReactiveObject, IScreen
{
    [Reactive]
    private AppToolbarViewModel _toolbarData = new();

    public bool CanGoBack => Router.NavigationStack.Count > 1;
    public RoutingState Router { get; } = new();
}