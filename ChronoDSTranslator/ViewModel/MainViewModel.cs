using ReactiveUI;

namespace ChronoDSTranslator.ViewModel;

public class MainViewModel : ReactiveObject, IScreen
{
    public bool CanGoBack => Router.NavigationStack.Count > 1;
    public RoutingState Router { get; } = new();
}