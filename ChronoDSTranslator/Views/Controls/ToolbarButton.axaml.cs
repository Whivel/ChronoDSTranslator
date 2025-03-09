using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace ChronoDSTranslator.Views.Controls;

public partial class ToolbarButton : UserControl
{
    public static readonly StyledProperty<IImage> IconProperty =
        AvaloniaProperty.Register<ToolbarButton, IImage>(nameof(Icon));

    public static readonly StyledProperty<bool> IsSelectedProperty =
        AvaloniaProperty.Register<ToolbarButton, bool>(nameof(IsSelected));

    public static readonly StyledProperty<ICommand?> CommandProperty =
        AvaloniaProperty.Register<Button, ICommand?>(nameof(Command), enableDataValidation: true);

    public static readonly StyledProperty<object?> CommandParameterProperty =
        AvaloniaProperty.Register<Button, object?>(nameof(CommandParameter));

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

    public ICommand? Command
    {
        get => GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    public object? CommandParameter
    {
        get => GetValue(CommandParameterProperty);
        set => SetValue(CommandParameterProperty, value);
    }
}