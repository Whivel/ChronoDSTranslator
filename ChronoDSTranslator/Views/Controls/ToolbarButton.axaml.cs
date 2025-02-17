using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace ChronoDSTranslator.Views.Controls;

public partial class ToolbarButton : UserControl
{
    private static readonly StyledProperty<IImage> IconProperty =
        AvaloniaProperty.Register<ToolbarButton, IImage>(nameof(Icon));

    private static readonly StyledProperty<bool> IsSelectedProperty =
        AvaloniaProperty.Register<ToolbarButton, bool>(nameof(IsSelected));


    public ToolbarButton()
    {
        InitializeComponent();
    }

    public IImage Icon
    {
        get => GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public bool IsSelected
    {
        get => GetValue(IsSelectedProperty);
        set => SetValue(IsSelectedProperty, value);
    }
}