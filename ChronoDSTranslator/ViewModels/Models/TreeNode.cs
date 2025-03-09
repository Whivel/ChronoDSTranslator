using Avalonia.Media;
using DynamicData;
using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace ChronoDSTranslator.ViewModels.Models;

public partial class TreeNode : ReactiveObject
{
    [Reactive]
    private string _ariaLabel = string.Empty;

    [Reactive]
    private SourceList<TreeNode> _children = new();

    [Reactive]
    private IImage? _icon;

    [Reactive]
    private string _label = string.Empty;

    //public SourceList<TreeNode> Children { get; } = new();
}