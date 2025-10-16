---
title: Change ToolTip ShowDuration
page_title: Show the ToolTips Indefinitely
description: This article explains how to create a custom UILayer to customize the way that tooltips are shown such as extending their ShowDuration.
type: how-to
slug: kb-syntaxeditor-how-to-create-custom-tooltip-layer
position: 0
ticketid: 1553912
tags: change, tooltip, showduration, indefinitely, custom, uilayer, tagger, uilayersbuilder
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2022.1.117</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadSyntaxEditor for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to create a custom `UILayer` to customize the way that tooltips are shown such as extending their `ShowDuration`.

## Solution

**1.** Implement a custom tooltip tagger as explained in the [Custom Tagger]({%slug radsyntaxeditor-features-custom-tagger%}) article.

**2.** Implement a custom UILayer that derives from `TextToolTipUILayer`. In the `GetLinePartUIElement` method, you can get the `Rectangle` created by default and set the `ToolTipService.ShowDuration` attached property.

__Creating a custom TextToolTipUILayer__
```C#
    public class CustomTextToolTipUILayer : TextToolTipUILayer
    {
        protected override FrameworkElement GetLinePartUIElement(ToolTipTag tag, Span span, UIUpdateContext updateContext)
        {
            var rectangle = (Rectangle)base.GetLinePartUIElement(tag, span, updateContext);
            ToolTipService.SetShowDuration(rectangle, int.MaxValue);
            return rectangle;
        }
    }
```

**3.** To apply the custom UILayer, create a custom `UILayersBuilder` and override its `BuildUILayers` method. In the method, you can replace the default TextToolTipUILayer with the custom one using the `Remove` and `AddAfter` methods of the `UILayerStack`.

__Creating a custom UILayersBuilder__
```C#
    public class CustomUILayersBuilder : UILayersBuilder
    {
        public override void BuildUILayers(UILayerStack uiLayers)
        {
            base.BuildUILayers(uiLayers);
            uiLayers.Remove(PredefinedUILayers.TextToolTip);
            uiLayers.AddAfter(PredefinedUILayers.Text, new CustomTextToolTipUILayer());
        }
    }
```

**4.** Apply the custom UILayersBuilder using the syntax editor's property with the same name.

__Creating a custom UILayersBuilder__
```C#
    this.syntaxEditor.UILayersBuilder = new CustomUILayersBuilder();
```

## See Also

* [Layers]({%slug radsyntaxeditor-features-layers%})
* [Taggers]({%slug radsyntaxeditor-features-taggers%})
* [Custom Tagger]({%slug radsyntaxeditor-features-custom-tagger%})