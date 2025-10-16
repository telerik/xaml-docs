---
title: How to Orient RadExpander Header Content Vertically
description: This article demonstrates how to switch the header orientation of RadExpander.
type: how-to
page_title: Rotate the header of the RadExpander when the ExpandDirection is Right or Left
slug: kb-expander-howto-orient-header-content
position: 0
tags: expander, header, orientation, expand, direction
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadExpander for WPF</td>
	</tr>
</table>

## Description

How to display the header vertically when the ExpandDirection is Right or Left.

## Solution

To achieve this requirement you can set use a LayoutTransformControl and place it inside the Header of the RadExpander as demonstrated in __Example 1__.

__Example 1: Change Header Orientation__
```XAML

    <Grid x:Name="LayoutRoot" ShowGridLines="True">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*" />
            <ColumnDefinition Width="*" />
        </Grid.ColumnDefinitions>

        <telerik:RadExpander ExpandDirection="Right" IsExpanded="True">
            <telerik:RadExpander.Header>
                <telerik:LayoutTransformControl VerticalAlignment="Top">
                    <telerik:LayoutTransformControl.LayoutTransform>
                        <RotateTransform Angle="-90" />
                    </telerik:LayoutTransformControl.LayoutTransform>
                    <telerik:LayoutTransformControl.Content>
                        <TextBlock Text="Expand: Right" />
                    </telerik:LayoutTransformControl.Content>
                </telerik:LayoutTransformControl>
            </telerik:RadExpander.Header>
            <telerik:RadExpander.Content>
                <Rectangle Width="200" Height="10" Fill="Green" />
            </telerik:RadExpander.Content>
        </telerik:RadExpander>

        <telerik:RadExpander Grid.Column="1" ExpandDirection="Left" IsExpanded="True">
            <telerik:RadExpander.Header>
                <telerik:LayoutTransformControl>
                    <telerik:LayoutTransformControl.LayoutTransform>
                        <RotateTransform Angle="-90" />
                    </telerik:LayoutTransformControl.LayoutTransform>
                    <telerik:LayoutTransformControl.Content>
                        <TextBlock Text="Expand: Left" />
                    </telerik:LayoutTransformControl.Content>
                </telerik:LayoutTransformControl>
            </telerik:RadExpander.Header>
            <telerik:RadExpander.Content>
                <Rectangle Width="200" Height="10"  Fill="Yellow" />
            </telerik:RadExpander.Content>
        </telerik:RadExpander>
    </Grid>
```

## See Also
* [Expand Direction]({%slug radexpander-features-expand_direction%})
