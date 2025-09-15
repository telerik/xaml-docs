---
title: How to edit Dockresizer
description: How to style the resizer element of RadDocking.
type: how-to
page_title: Customizing the normal and preview state colors of the GridResizer
slug: kb-docking-styling-dockresizer
position: 0
tags: dockresizer, gridresizer, dockresizerstyle, gridresizerstyle, previewstyle
ticketid: 1415844
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2 624</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadDocking for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to customize the background colors of the normal and preview states of the DockResizer element.

## Solution

To customize the colors of the DockResizer's normal and preview states add the following two Styles: 


```XAML
    <!--If the NoXaml binaries are used, the following style needs to be based on the default one, like so:--> 
    <!--<Style TargetType="Control" BasedOn="{StaticResource GridResizerPreviewStyle}">-->

    <Style x:Key="ResizerPreviewStyle" TargetType="Control">
        <Setter Property="Background" Value="#4A1B7E"/>
	<!--The template can be omitted for the NoXaml as it will come from the base Style.
	    Omitting it for StyleManager will lead to empty template and no visual change.-->
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="Control">
                    <Border BorderThickness="{TemplateBinding BorderThickness}"
                            BorderBrush="{TemplateBinding BorderBrush}"
                            Background="{TemplateBinding Background}" />
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>

    <!--If the NoXaml binaries are used, the following style needs to be based on the default one, like so:--> 
    <!--<Style TargetType="telerik:RadGridResizer" BasedOn="{StaticResource RadGridResizerStyle}">-->

    <Style TargetType="telerik:RadGridResizer">
        <Setter Property="Background" Value="#190099BC"/>
        <Setter Property="PreviewStyle" Value="{StaticResource ResizerPreviewStyle}"/>
    </Style>
```
