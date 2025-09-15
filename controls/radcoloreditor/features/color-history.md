---
title: Color History
page_title: Color History
description: Check our &quot;Color History&quot; documentation article for the RadColorEditor {{ site.framework_name }} control.
slug: radcoloreditor-features-color-history
tags: color,history
published: True
position: 1
---

# Color History

The __RadColorEditor__ control enables you to keep track of the previously selected colors through a set of properties.

* __PreviousColor__: This property is of type __Color__ and provides access to the last selected color.					

* __ColorHistory__: This property exposes a collection of all previously selected colors.						

	#### __XAML__
	```XAML
		<StackPanel HorizontalAlignment="Center" VerticalAlignment="Center">
			<StackPanel.Resources>
				<telerik:ColorToBrushConverter x:Key="ColorConverter" />
			</StackPanel.Resources>
			<telerik:RadColorEditor x:Name="colorEditor1" Width="400" Height="220" HistoryCapacity="5" />
			<ItemsControl ItemsSource="{Binding ColorHistory, ElementName=colorEditor1}" Height="20" Margin="8 0">
				<ItemsControl.ItemTemplate>
					<DataTemplate>
						<Border Width="20" Height="20" Margin="5 0"
								Background="{Binding Converter={StaticResource ColorConverter} }" />
					</DataTemplate>
				</ItemsControl.ItemTemplate>
				<ItemsControl.ItemsPanel>
					<ItemsPanelTemplate>
						<telerik:RadWrapPanel />
					</ItemsPanelTemplate>
				</ItemsControl.ItemsPanel>
			</ItemsControl>
		</StackPanel>
	```					

* __HistoryCapacity__: This property is of type __int__. It gets/set the number of previously used colors to be stored in the __ColorHistory__ collection.					

## See Also
 * [Structure]({%slug radcoloreditor-structure%})
 * [Getting Started]({%slug radcoloreditor-getting-started%})
 * [Color Mode]({%slug radcoloreditor-features-color-mode%})