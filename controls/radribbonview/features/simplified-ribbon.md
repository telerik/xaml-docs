---
title: Simplified Ribbon
page_title: Simplified Ribbon
description: The article describes how the layout of the RadRibbonView can be changed to a simplified version.
slug: radribbonview-simplified-ribbon
tags: simplified, ribbon
published: True
position: 9
---

# Simplified Ribbon

Since the __R2 2019__ version, you have the option of changing the default ribbon layout to a simplified one. The simplified ribbon is more compact and takes up less vertical space on the screen. 

## RibbonLayout

In order to change the default ribbon layout, there are two options. Switch the layout through the UI or programmatically. 

TODO: Add info about the ShowRibbonLayoutButtonContent property

* __Switch the layout through the UI__: By default the button that switches between the default and the simplified layout is not visible. You can set the __ShowRibbonLayoutButton__ property to __True__ in order to show it. You can also set the __RibbonLayoutButtonContent__ in order to change the Content of the switch button.

#### __[XAML] Example 1: Showing the layout switch button__
{{region xaml-radribbonview-simplified-ribbon-0}}
{{endregion}}

TODO: Add gif of changing the layout

* __Switch the layout programmatically__: In order to change the layout in code, you can set the __RibbonLayout__ property to __Simplified__.

#### __[C#] Example 2: Switching the layout in code__
{{region cs-radribbonview-simplified-ribbon-1}}
    this.ribbonView.RibbonLayout = RibbonLayout.Simplified;
{{endregion}}

#### __[VB.NET] Example 2: Switching the layout in code__
{{region vb-radribbonview-simplified-ribbon-2}}
	Me.ribbonView.RibbonLayout = RibbonLayout.Simplified
{{endregion}}

>tip The [RadRibbonView Button Controls]({%slug radribbonview-buttons-overview%}) now expose a __SimplifiedImage__ property. This image will be used when the layout of the control is simplified. If the SimplifiedImage property is not set, then the __SmallImage__ property will be used instead.

## SimplifiedRibbon MVVM

In order to benefit from the simplified ribbon layout in an MVVM scenario, you can utilize the __SimplifiedItemTemplate__ property. For an example implementation, check out the [Use MVVM in RadRibbonView]({%slug howto-use-mvvm-in-radribbonview%}) article. 

## See Also

* [Getting Started]({%slug radribbonview-gettingstarted%})
* [Events]({%slug radribbonview-events-overview%})