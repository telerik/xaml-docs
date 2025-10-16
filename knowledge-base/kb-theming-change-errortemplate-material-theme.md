---
title: Validation Tooltip Clipped When No Space
description: The error template visual feedback is clipped if it goes outside of the element that hosts its owner control
type: troubleshooting
page_title: Error Template Position Outside of Window If Not Enough Space in Material Theme
slug: kb-theming-change-errortemplate-material-theme
position: 0
tags: material,clip,tooltip
ticketid: 1504343
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.3.1023</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The data validation error visual is clipped if it goes outside of the element that hosts it or outside of the window. This happens in the Material theme because it doesn't use a tooltip element as the other Telerik themes.

## Solution 

To change this behavior you can create a custom error template or modify the default one. Then apply the template using the [Validation.ErrorTemplate attached property](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.validation.errortemplate?view=netcore-3.1). 

You can find the default data validation error template in the [Telerik.Windows.Controls.Input.xaml file for the Material theme]({%slug styling-apperance-editing-control-templates%}). The file contains ControlTemplates for the default error template (x:Key="StaticValidationTooltipTemplate") of the Material theme and also a version with the tooltip (x:Key="ValidationTooltipTemplate").

If you use [NoXaml dlls]({%slug xaml-vs-noxaml%}) you can directly access the "ValidationTooltipTemplate" ControlTemplate element using the StaticResource keyword and assign it to the `Validation.ErrorTemplate` property.


```XAML
	<telerik:RadComboBox Validation.ErrorTemplate="{StaticResource ValidationTooltipTemplate}" />
```

In case you use the __Xaml dlls__ you can copy the "ValidationTooltipTemplate" ControlTemplate from the *Telerik.Windows.Controls.Input.xaml* file and assign it to the `Validation.ErrorTemplate` property.


```XAML
	<Window.Resources>
		<Geometry x:Key="ArrowTopRight8x8">M0,0 L8,0 8,8 z</Geometry>
		<ControlTemplate x:Key="ErrorTooltipTemplate" TargetType="ToolTip">
			<Grid x:Name="RootVisual" HorizontalAlignment="Right" RenderTransformOrigin="0 0" Opacity="0" SnapsToDevicePixels="True">
				<VisualStateManager.VisualStateGroups>
					<VisualStateGroup x:Name="OpenStates">
						<VisualStateGroup.Transitions>
							<VisualTransition GeneratedDuration="0"/>
							<VisualTransition To="Open" GeneratedDuration="0:0:0.3">
								<Storyboard>
									<DoubleAnimation Storyboard.TargetName="xform" Storyboard.TargetProperty="X" To="0" Duration="0:0:0.3">
										<DoubleAnimation.EasingFunction>
											<BackEase Amplitude=".4" EasingMode="EaseOut"/>
										</DoubleAnimation.EasingFunction>
									</DoubleAnimation>
									<DoubleAnimation Storyboard.TargetName="RootVisual" Storyboard.TargetProperty="Opacity" To="1" Duration="0:0:0.3"/>
								</Storyboard>
							</VisualTransition>
						</VisualStateGroup.Transitions>
						<VisualState x:Name="Closed">
							<Storyboard>
								<DoubleAnimation Storyboard.TargetName="RootVisual" Storyboard.TargetProperty="Opacity" To="0" Duration="0"/>
							</Storyboard>
						</VisualState>
						<VisualState x:Name="Open">
							<Storyboard>
								<DoubleAnimation Storyboard.TargetName="xform" Storyboard.TargetProperty="X" To="0" Duration="0"/>
								<DoubleAnimation Storyboard.TargetName="RootVisual" Storyboard.TargetProperty="Opacity" To="1" Duration="0"/>
							</Storyboard>
						</VisualState>
					</VisualStateGroup>
				</VisualStateManager.VisualStateGroups>
				<Grid.RenderTransform>
					<TranslateTransform x:Name="xform" X="-25"/>
				</Grid.RenderTransform>
				<Border Background="{telerik:MaterialResource ResourceKey=ValidationBrush}" Margin="10 0 0 0" UseLayoutRounding="True">
					<ContentPresenter
							Content="{Binding ErrorContent}"
							Margin="16 10 16 10"
							TextBlock.Foreground="{telerik:MaterialResource ResourceKey=MarkerInvertedBrush}"
							TextBlock.FontSize="{telerik:MaterialResource ResourceKey=FontSize}"/>
				</Border>
				<ContentControl/>
			</Grid>
		</ControlTemplate>
		
		<ControlTemplate x:Key="ValidationTooltipTemplate">
			<Grid SnapsToDevicePixels="True" VerticalAlignment="Top">
				<Border Background="Transparent" HorizontalAlignment="Right" VerticalAlignment="Top" Width="3" Height="3"/>
				<AdornedElementPlaceholder x:Name="Holder"/>
				<Border BorderBrush="{telerik:MaterialResource ResourceKey=ValidationBrush}" BorderThickness="0 0 0 3"/>
				<Path
						Data="{StaticResource ArrowTopRight8x8}"
						Fill="{telerik:MaterialResource ResourceKey=ValidationBrush}"
						Width="8"
						Height="8"
						HorizontalAlignment="Right"
						VerticalAlignment="Top"/>
				<ToolTipService.ToolTip>
					<ToolTip x:Name="PART_ToolTip"
							DataContext="{Binding RelativeSource={RelativeSource Mode=Self}, Path=PlacementTarget.DataContext}"
							Template="{StaticResource ErrorTooltipTemplate}"
							Placement="Right"/>
				</ToolTipService.ToolTip>
			</Grid>
		</ControlTemplate>
	</Window.Resources>
```


```XAML
	<telerik:RadComboBox Validation.ErrorTemplate="{StaticResource ValidationTooltipTemplate}" />
```
