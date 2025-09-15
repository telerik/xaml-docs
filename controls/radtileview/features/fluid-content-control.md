---
title: Fluid Content Control
page_title: Fluid Content Control
description: Check our &quot;Fluid Content Control&quot; documentation article for the RadTileView {{ site.framework_name }} control.
slug: radtileview-fluid-content-control
tags: fluid,content,control
published: True
position: 2
---

# Fluid Content Control

__RadFluidContentControl__ is a flexible content control used to build responsive layouts. 

This article shows how to integrate the RadFluidContentControl in RadTileView.

RadFluidContentControl exposes three content properties - `Content`, `SmallContent` and `LargeContent`. Only the content of one of these three properties is visible at any given time. The currently visible content can be changed manually by setting the `ContentChangeMode` property to `Manual` and selecting the current state using the `State` property. Or it can be changed automatically using the `NormalToLargeThreshold` and `NormalToSmallThreshold` properties. 

## Automatic Content Changing

By default the currently visible content of RadFluidContentControl is automatically changed based on the current size of the control. To manually define the sizes, set the `NormalToLargeThreshold` and `NormalToSmallThreshold` properties. The `NormalToSmallThreshold` is used to determine when the small content will be shown, in the cases when the normal `Content` is currently visible and vice versa. The `NormalToLargeThreshold` property controls when the normal content will be hidden and the `LargeContent` shown.

The next example works with the following content sizes - SmallContent (200px X 200px), NormalContent (400px X 400px) and LargeContent (600px X 600px).

__Example 1: Automatic Content Changing__  
```XAML
	<telerik:RadFluidContentControl NormalToSmallThreshold="400 400" NormalToLargeThreshold="600 600">
		<telerik:RadFluidContentControl.SmallContent>
			<Border Background="LightBlue" Width="200" Height="200">
				<TextBlock Text="Small Content" />
			</Border>
		</telerik:RadFluidContentControl.SmallContent>
		<telerik:RadFluidContentControl.Content>
			<Border Background="LightGreen" Width="400" Height="400">
				<TextBlock Text="Normal Content" />
			</Border>
		</telerik:RadFluidContentControl.Content>
		<telerik:RadFluidContentControl.LargeContent>
			<Border Background="LightYellow" Width="600" Height="600">
				<TextBlock Text="Large Content" />
			</Border>
		</telerik:RadFluidContentControl.LargeContent>
	</telerik:RadFluidContentControl>
```

The following list describes how to threshold properties work.

* __NormalToSmallThreshold__: Setting it to the size of the normal content means that as soon as enough space (400px X 400px from the example) is available, the normal content will be shown. Alternatively, the control will hide the normal content (and show the small content) as soon as the available size is not enough to properly render the normal content.                        

* __NormalToLargeThreshold__: Setting it to the size of the large content means that as soon as enough space (600px X 600px from the example) is available, the large content will be shown. Alternatively, the control will hide the large content (and show the normal content) as soon as the available size is not enough to properly render the large content.

In case you need to specify only the width or height of a threshold, you can set the other value to 0 - this way it will be disregarded.

## Manual Content Changing

To change the currently visible content manually, set the `ContentChangeMode` property of RadFluidContentControl to `Manual` and select the current state using the `State` property. The `State` property can be synced with the `TileState` property of the RadTileView items.

The following example shows how to use the `TileStateChanged` event of RadTileView in order to  update the `State` property of RadFluidContentControl.

__Example 2 (part 1): Manual Content Changing__
```XAML
	<telerik:RadTileView TileStateChanged="RadTileView_TileStateChanged" Width="600" Height="400">
		<telerik:RadTileViewItem Header="Item A">
			<telerik:RadFluidContentControl ContentChangeMode="Manual">
				<telerik:RadFluidContentControl.SmallContent>
					<TextBlock Text="Small Content A" TextAlignment="Center" VerticalAlignment="Center"/>
				</telerik:RadFluidContentControl.SmallContent>
				<telerik:RadFluidContentControl.Content>
					<TextBlock Text="Normal Content A" TextAlignment="Center" VerticalAlignment="Center"/>
				</telerik:RadFluidContentControl.Content>
				<telerik:RadFluidContentControl.LargeContent>
					<TextBlock Text="Large Content A" TextAlignment="Center" VerticalAlignment="Center"/>
				</telerik:RadFluidContentControl.LargeContent>
			</telerik:RadFluidContentControl>
		</telerik:RadTileViewItem>

		<telerik:RadTileViewItem Header="Item B">
			<telerik:RadFluidContentControl ContentChangeMode="Manual">
				<telerik:RadFluidContentControl.SmallContent>
					<TextBlock Text="Small Content B" TextAlignment="Center" VerticalAlignment="Center"/>
				</telerik:RadFluidContentControl.SmallContent>
				<telerik:RadFluidContentControl.Content>
					<TextBlock Text="Normal Content B" TextAlignment="Center" VerticalAlignment="Center"/>
				</telerik:RadFluidContentControl.Content>
				<telerik:RadFluidContentControl.LargeContent>
					<TextBlock Text="Large Content B" TextAlignment="Center" VerticalAlignment="Center"/>
				</telerik:RadFluidContentControl.LargeContent>
			</telerik:RadFluidContentControl>
		</telerik:RadTileViewItem>

		<telerik:RadTileViewItem Header="Item C">
			<telerik:RadFluidContentControl ContentChangeMode="Manual">
				<telerik:RadFluidContentControl.SmallContent>
					<TextBlock Text="Small Content C" TextAlignment="Center" VerticalAlignment="Center"/>
				</telerik:RadFluidContentControl.SmallContent>
				<telerik:RadFluidContentControl.Content>
					<TextBlock Text="Normal Content C" TextAlignment="Center" VerticalAlignment="Center"/>
				</telerik:RadFluidContentControl.Content>
				<telerik:RadFluidContentControl.LargeContent>
					<TextBlock Text="Large Content C" TextAlignment="Center" VerticalAlignment="Center"/>
				</telerik:RadFluidContentControl.LargeContent>
			</telerik:RadFluidContentControl>
		</telerik:RadTileViewItem>
	</telerik:RadTileView>
```

__Example 2 (part 2): Handling the TileStateChanged event__  
```C#
	private void RadTileView_TileStateChanged(object sender, Telerik.Windows.RadRoutedEventArgs e)
	{
		var item = (RadTileViewItem)e.Source;
		var fluidControl = (RadFluidContentControl)item.Content;
		switch (item.TileState)
		{
			case TileViewItemState.Maximized:
				fluidControl.State = FluidContentControlState.Large;
				break;
			case TileViewItemState.Minimized:
				fluidControl.State = FluidContentControlState.Small;
				break;
			case TileViewItemState.Restored:
				fluidControl.State = FluidContentControlState.Normal;
				break;
		}
	}
```
```VB.NET
	Private Sub RadTileView_TileStateChanged(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
		Dim item = CType(e.Source, RadTileViewItem)
		Dim fluidControl = CType(item.Content, RadFluidContentControl)

		Select Case item.TileState
			Case TileViewItemState.Maximized
				fluidControl.State = FluidContentControlState.Large
			Case TileViewItemState.Minimized
				fluidControl.State = FluidContentControlState.Small
			Case TileViewItemState.Restored
				fluidControl.State = FluidContentControlState.Normal
		End Select
	End Sub
```

![Fluid Control Large and Small Content](images/radtileview-fluid-content-control-0.png)  
![Fluid Control Normal Content](images/radtileview-fluid-content-control-1.png)

>tip See how to use the Manual ContentChangeMode in a data binding scenario in the [Use RadFluidContentControl in RadTileView]({%slug radtileview-howto-use-fluidcontentcontrol-in-tileview%}) article.
