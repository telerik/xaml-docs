---
title: UI Virtualization
page_title: UI Virtualization
description: The article describes the UI Virtualization in WPF and Telerik Rad controls.
slug: common-ui-virtualization
tags: virtualization,ui
published: True
position: 4
---

# UI Virtualization

The Telerik items controls used to display big amounts of data (like RadGridView, RadTreeView, etc.) support UI virtualization, which boosts the application's performance and memory footprint immensely. This article describes the basics of this mechanism and gives tips and tricks on how to avoid issues related to the virtualization.

__UI virtualization__ is a technique used to generate visual containers only for the visible part of the control (the viewport). For example, if the data items collection contains 1000 records, but the size of the control allows to show only 20 at once, only 20 containers will be generated. When the viewport changes, the number of generated containers may increase or decrease based on the available size. On scrolling up and down (or left and right, based on the orientation of the control), the same visual container instances are re-used. 

It is strongly recommended to __avoid setting properties of the containers directly, when UI virtualization is enabled__. That is because the containers can be re-used for a different data item, which means that the corresponding setting will be rendered obsolete when the control's viewport is updated, and the container won't be up to date with the settings. 

The following example illustrates what should be avoided:

__Setting properties of GridViewRow directly (not recommended when virtualization is enabled)__
```C#
	gridViewRowInstance.DetailsVisibility = Visibility.Visible;
	gridViewRowInstance.Background = Brushes.Green;
```

__Setting properties of RadTreeViewItem directly (not recommended when virtualization is enabled)__
```C#
	radTreeViewItemInstance.Background = Brushes.Green;
	radTreeViewItemInstance.Opacity = 0.5;
```

Instead of setting the properties directly, you can use data bindings via the corresponding style properties. The data binding should point to the underlying item model. The following example shows how to do this with the `GridViewRow` and `RadTreeViewItem` shown above:

__Binding properties of GridViewRow via RowStyle__
```XAML
	<telerik:RadGridView.RowStyle>
		<!-- in case you use NoXaml dlls, you should also set the following attribute to the Style object -->
		<!-- BasedOn="{StaticResource GridViewRowStyle}" -->
		<Style TargetType="telerik:GridViewRow">
			<Setter Property="DetailsVisibility" Value="{Binding MyDetailsVisibilityProperty}" />
			<Setter Property="Background" Value="{Binding MyBackgroundProperty}" />
		</Style>
	</telerik:RadGridView.RowStyle>
```

__Binding properties of RadTreeViewItem via the ItemContainerStyle__
```XAML
	<telerik:RadTreeView.ItemContainerStyle>
		<!-- in case you use NoXaml dlls, you should also set the following attribute to the Style object -->
		<!-- BasedOn="{StaticResource RadTreeViewItemStyle}" -->
		<Style TargetType="telerik:RadTreeViewItem">			
			<Setter Property="Background" Value="{Binding MyBackgroundProperty}" />
			<Setter Property="Opacity" Value="{Binding MyOpacityProperty}" />
		</Style>
	</telerik:RadTreeView.ItemContainerStyle>
```

To make changes to the corresponding container, you can update the data-bound properties of its underlying data item.

In order for the UI virtualization to work correctly, the virtualizing panel should be aware of the size of its parent items control. This means that __the items control should not be hosted in panels that measure its children with `double.PositiveInfinity`__ (as much space as the children need). Examples of such panels include `StackPanel` and a `RowDefinition`/`ColumnDefinitions` of a `Grid` with its size (`Height`/`Width`) set to `Auto`. __Panels that are good for the virtualization__ are such that measure their children with the available size. For example, a `Grid` with `RowDefinition`/`ColumnDefinitions` which size is set to star-size or to a fixed value, or any other panel that uses the available size. 

__The infinity measuring panels will disable the UI virtualization unless you set a fixed size to the virtualizing control__
```XAML	
	<StackPanel>	
		<telerik:RadGridView />
	</StackPanel>
	
	<Grid>
		<Grid.RowDefinitions>
			<RowDefinition Height="Auto" />
		</Grid.RowDefinitions>
		
		<telerik:RadGridView Grid.Row="0" />
	</Grid>
	
	<!-- In case the StackPanel or similar panels usage is necessary, you can re-enable the UI virtualization by setting a fixed size to the virtualized control -->
	<!-- Example: <telerik:RadGridView Height="500" /> -->
```

__Host the virtualized controls in panels that measure its children with the available size in order for the virtualization to work__
```XAML
	<Grid>
		<telerik:RadGridView />
	</Grid>
	
	<Grid>
		<Grid.RowDefinitions>
			<RowDefinition Height="\*" />
		</Grid.RowDefinitions>
		
		<telerik:RadGridView Grid.Row="0" />
	</Grid>
```

The UI virtualization feature is created with a special [Panel](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/controls/how-to-create-a-custom-panel-element?view=netframeworkdesktop-4.8) implementation. In most controls this panel is assined via the `ItemsPanel` property of the control. Replacing the `ItemsPanel` setting will disable the virtualization.

## See Also  
* [RadTreeView UI Virtualization]({%slug radtreeview-features-ui-virtualization%})
* [RadListBox UI Virtualization]({%slug radlistbox-features-virtualizingwrappanel%})
* [RadGridView UI Virtualization]({%slug radgridview-features-ui-virtualization%})
* [RadScheduleView UI Virtualization]({%slug radscheduleview-ui-virtualization%})
* [RadTreeListView UI Virtualization]({%slug radtreelistview-features-ui-virtualization%})
* [RadSpreadsheet UI Virtualization]({%slug radspreadsheet-ui-virtualization%})
* [RadPropertyGrid UI Virtualization]({%slug radpropertygrid-virtualization%})
* [RadTileView UI Virtualization]({%slug radtileview-features-virtualization%})
* [RadDiagram UI Virtualization]({%slug raddiagrams-features-virtualization%})
* [RadBook UI Virtualization]({%slug virtualization%})
* [RadComboBox UI Virtualization]({%slug radcombobox-howto-virtualization%})
