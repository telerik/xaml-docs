---
title: Customizing ToolTip Content
page_title: Customizing ToolTip Content
description: Check our &quot;Customizing ToolTip Content&quot; documentation article for the RadToolTip {{ site.framework_name }} control.
slug: radtooltip-theming
tags: theming
published: True
position: 3
---

# Customizing ToolTip Content

Telerik themes are not turned on by default in __RadToolTip__. In order to use the predefined Telerik styles you can define a __ContentTemplate__ for the __RadToolTip__ component and use the __RadToolTipContentView__ control inside the template.

The following code example demonstrates how to set up __RadToolTip__ to use the Telerik themes.

__Example 1: Setting ToolTipContentTemplate property__
```XAML
    <Ellipse Width="80" Height="80" Fill="#FF1B9DDE" Stroke="#FF1B9DDE" StrokeThickness="2"
              telerik:RadToolTipService.Placement="Top"
              telerik:RadToolTipService.VerticalOffset="-10"
              telerik:RadToolTipService.ToolTipContent="RadToolTip">
        <telerik:RadToolTipService.ToolTipContentTemplate>
            <DataTemplate>
                <telerik:RadToolTipContentView>
                    <TextBlock Text="{Binding}" />
                </telerik:RadToolTipContentView>
            </DataTemplate>
        </telerik:RadToolTipService.ToolTipContentTemplate>
    </Ellipse>
```

Another approach that can be used for setting up the __RadToolTip__ theming is to set the __ToolTipContentTemplate__ property to null and then define the __RadToolTipContentView__ control inside the __ToolTipContent__.

__Example 2: Setting ToolTipContent property__
```XAML
    <Ellipse Width="80" Height="80" Fill="#FF1B9DDE" Stroke="#FF1B9DDE" StrokeThickness="2"
           telerik:RadToolTipService.Placement="Top"
           telerik:RadToolTipService.VerticalOffset="-10"
           telerik:RadToolTipService.ToolTipContentTemplate="{x:Null}">
		<telerik:RadToolTipService.ToolTipContent>
			<telerik:RadToolTipContentView>
				<TextBlock Text="RadToolTip" />
			</telerik:RadToolTipContentView>
		</telerik:RadToolTipService.ToolTipContent>
    </Ellipse>
```        

The end result is demonstrated in the picture below:
![radtooltip-theming-wpf 01](images/radtooltip-theming-wpf_01.png)

## See Also
 * [Getting Started]({%slug radtooltip-getting-started%})
