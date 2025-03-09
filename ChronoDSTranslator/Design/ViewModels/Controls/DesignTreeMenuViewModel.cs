using Avalonia.Media.Imaging;
using ChronoDSTranslator.ViewModels.Controls;
using ChronoDSTranslator.ViewModels.Models;
using DynamicData;
using SkiaSharp;
using Svg.Skia;

namespace ChronoDSTranslator.Design.ViewModels.Controls;

public class DesignTreeMenuViewModel : TreeMenuViewModel
{
    public DesignTreeMenuViewModel()
    {
        var svg = SKSvg.CreateFromSvg("""
                                      <?xml version="1.0" encoding="utf-8"?><!-- Uploaded to: SVG Repo, www.svgrepo.com, Generator: SVG Repo Mixer Tools -->
                                      <svg width="800px" height="800px" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
                                      <path fill-rule="evenodd" clip-rule="evenodd" d="M3.75 5.25L3 6V18L3.75 18.75H20.25L21 18V6L20.25 5.25H3.75ZM4.5 7.6955V17.25H19.5V7.69525L11.9999 14.5136L4.5 7.6955ZM18.3099 6.75H5.68986L11.9999 12.4864L18.3099 6.75Z" fill="#080341"/>
                                      </svg>
                                      """);
        var img = SKImage.FromBitmap(svg.Picture!.ToBitmap(SKColors.Transparent, 1, 1, SKColorType.Rgba8888, SKAlphaType.Premul, SKColorSpace.CreateSrgb()));
        var encoded = img.Encode();
        // get a stream over the encoded data
        var stream = encoded.AsStream();
        var iimg = new Bitmap(stream);
        var l1_1 = new TreeNode
        {
            Label = "L1_1",
            AriaLabel = "L1_1"
        };
        var l1_2 = new TreeNode
        {
            Label = "L1_2",
            AriaLabel = "L1_2"
        };
        var l2_1 = new TreeNode
        {
            Label = "L2_1",
            AriaLabel = "L2_1",
            Icon = iimg
        };
        var l3_1 = new TreeNode
        {
            Label = "L3_1",
            AriaLabel = "L3_1"
        };
        l1_1.Children.Add(l2_1);
        l2_1.Children.Add(l3_1);

        RootNode.Children.Add(l1_1);
        RootNode.Children.Add(l1_2);
    }
}