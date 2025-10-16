---
title: How to Change the Funnel Filter Icon in RadGridView
description: Changing the filter image of the column header with a RadGlyph element.
type: how-to
page_title: How to Replace the Icon of FilteringDropDown in RadGridView
slug: kb-gridview-change-funnel-filter-icon
position: 0
tags: glyph, filteringdropdown
ticketid: 278258
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadGridView for WPF</td>
	</tr>
</table>

## Description

How to change the filter icon of the FilteringDropDown control in RadGrdView

## Solution

1. Extract the ControlTemplate of the `FilteringDropDown` control.
2. In the template, remove the Grid that holds the two Path elements representing the funnel icon.
3. Then add a RadGlyph (or whatever element you prefer) in the Grid's place.
4. Use an implicit style (a Style object without x:Key) to apply the customized template to the Template property of FilteringDropDown.


```XAML
	<Window.Resources>
		<ControlTemplate TargetType="telerik:FilteringDropDown" x:Key="DistinctFilterControlTemplate">
			<Grid>
				<Button x:Name="PART_DropDownButton">
					<Button.Template>
						<ControlTemplate TargetType="Button">
							<ContentPresenter/>
						</ControlTemplate>
					</Button.Template>
					<Border Cursor="Hand" MinWidth="22" Background="Transparent">
						<!-- the custom icon -->
						<telerik:RadGlyph FontSize="16" Glyph="&#xe91e;" Foreground="{TemplateBinding Foreground}" />                     
					</Border>
				</Button>
				<Popup x:Name="PART_DropDownPopup" StaysOpen="True" AllowsTransparency="True" PopupAnimation="Slide"/>
			</Grid>
		</ControlTemplate>
		<Style TargetType="telerik:FilteringDropDown">
			<Setter Property="Template" Value="{StaticResource DistinctFilterControlTemplate}"/>
		</Style>
	</Window.Resources>
```

## See Also
* [Editing Control Templates]({%slug styling-apperance-editing-control-templates%})
* [Filtering]({%slug gridview-filtering-basic%})
* [RadGlyph]({%slug common-styling-appearance-radglyph%})
