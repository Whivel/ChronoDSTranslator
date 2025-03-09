using Avalonia;
using Avalonia.Controls;

namespace ChronoDSTranslator.Views.Controls;

public class SettingItem : ContentControl
{
    public static readonly StyledProperty<string> TitleProperty = AvaloniaProperty.Register<SettingItem, string>(nameof(Title));

    public static readonly StyledProperty<string> DescriptionProperty = AvaloniaProperty.Register<SettingItem, string>(nameof(Description));

    public static readonly StyledProperty<string> IconProperty = AvaloniaProperty.Register<SettingItem, string>(nameof(Icon));

    public static readonly StyledProperty<bool> IsSelectedProperty = AvaloniaProperty.Register<SettingItem, bool>(nameof(IsSelected));

    public string Title
    {
        get => GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public string Description
    {
        get => GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }

    public string Icon
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