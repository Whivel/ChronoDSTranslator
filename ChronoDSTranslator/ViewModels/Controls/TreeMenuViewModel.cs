using ChronoDSTranslator.ViewModels.Models;
using ReactiveUI;

namespace ChronoDSTranslator.ViewModels.Controls;

public class TreeMenuViewModel : ReactiveObject
{
    public TreeNode RootNode { get; } = new();
}