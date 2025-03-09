using System;
using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace ChronoDSTranslator.ViewModels.Controls;

public partial class AppToolbarViewModel : ReactiveObject
{
    public enum ToolbarItemId
    {
        Files,
        Settings
    }

    [Reactive]
    private ToolbarItemId _selectedItemId = ToolbarItemId.Settings;

    public AppToolbarViewModel()
    {
        IsFilesSelected = this.WhenAnyValue(x => x.SelectedItemId).Select(id => { return id == ToolbarItemId.Files; });
    }


    public IObservable<bool> IsFilesSelected { get; init; }

    [ReactiveCommand]
    private void SelectFiles()
    {
        SelectedItemId = ToolbarItemId.Files;
    }
}