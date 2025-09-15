---
title: How to Change the RadGlyph Icons' Color when Changing the Theme Variation During Runtime
description: This article explains how to change the color of a RadGlyph when the theme's variation changes while the application is running.
type: how-to
page_title: Switch RadGlyph Color when Changing Theme Variation During Runtime
slug: kb-theming-change-icon-color-variation
position: 0
tags: theming, change, theme, variation, runtime, radglyph, color, icon
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2021.2.615</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>Progress® Telerik® UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to change the RadGlyph icons' color when changing the theme variation during runtime.

## Solution

To have the RadGlyph icon reflect the change of the theme variation, you can use a **GeometryDrawing** object and bind it's brush's **Color** property to a specified color from the respective theme palette.



```XAML
	<telerik:RadMenuItem.Icon>
		<Image Stretch="UniformToFill" Width="35" Height="20" Margin="2">
			<Image.Source>
				<DrawingImage>
					<DrawingImage.Drawing>
						<GeometryDrawing Geometry="{telerik:RadGlyph Type=Path, Glyph={StaticResource GlyphCs}}">
							<GeometryDrawing.Brush>
								<SolidColorBrush Color="{Binding Source={x:Static telerik:Office2019Palette.Palette}, Path=MainForegroundColor}" />
							</GeometryDrawing.Brush>
						</GeometryDrawing>
					</DrawingImage.Drawing>
				</DrawingImage>
			</Image.Source>
		</Image>
	</telerik:RadMenuItem.Icon>
```

>The above example uses the Office2019Palette, but you can replace this with the palette for the theme(s) you're using.

## See Also
* [Available Themes]({%slug common-styling-appearance-available-themes%})