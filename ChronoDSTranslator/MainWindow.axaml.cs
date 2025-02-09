using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace ChronoDSTranslator;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        SetIcon();
    }

    private void SetIcon()
    {
        var bitmap = new Bitmap(AssetLoader.Open(
            new Uri("avares://ChronoDSTranslator/Assets/icon.png"))
        );
        Icon = new WindowIcon(bitmap);
    }

    private void InputElement_OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        if (WindowState == WindowState.Normal)
        {
            BeginMoveDrag(e);
        }
    }
}