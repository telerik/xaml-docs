---
title: Animation
page_title: Animation
description: Animation
slug: radtileview-animation
tags: animation
publish: True
position: 4
---

# Animation



##  Modifying the default animations

There are two different animations available in the __RadTileView__

* __Reordering animation__- when the items are dragged and reordered when in __Restore__ state.
					

* __Resizing animation__- when the items change their state.
					

The following properties are available for modifying the animations:

* __ReorderingDuration__ - controls the duration of the reordering animation. It is of type __TimeSpan__.
					

* __ReorderingEasing__ - controls the easing type of the reordering animation. It is of type __IEasingFunction__ allowing you to create a custom easing or to use the one found in the Silverlight framework.
					

* __ResizingDuration__ - controls the duration of the resizing animation. It is of type __TimeSpan__.
					

* __ResizingEasing__ - controls the easing type of the resize animation. It is of type __IEasingFunction__ allowing you to create a custom easing or to use the one found in the Silverlight framework.
					

#### __XAML__

{{region radtileview-animation_0}}
	<Grid x:Name="LayoutRoot">
	        <Grid.Resources>
	            <ElasticEase x:Name="ResizingEase"/>
	        </Grid.Resources>
	        <telerik:RadTileView ReorderingDuration="0:0:2" ResizingDuration="0:0:1.5" ResizingEasing="{StaticResource ResizingEase}" x:Name="RadTileView1" MaxColumns="2" MaxRows="1">
	            <telerik:RadTileViewItem Header="Item1">
	                <TextBlock Text="Item1 Content"/>
	            </telerik:RadTileViewItem>
	            <telerik:RadTileViewItem Header="Item2">
	                <TextBlock Text="Item2 Content"/>
	            </telerik:RadTileViewItem>
	            <telerik:RadTileViewItem Header="Item3" >
	                <TextBlock Text="Item3 Content"/>
	            </telerik:RadTileViewItem>
	            <telerik:RadTileViewItem Header="Item4" >
	                <TextBlock Text="Item4 Content"/>
	            </telerik:RadTileViewItem>
	            <telerik:RadTileViewItem Header="Item5" >
	                <TextBlock Text="Item5 Content"/>
	            </telerik:RadTileViewItem>
	            <telerik:RadTileViewItem Header="Item6" >
	                <TextBlock Text="Item6 Content"/>
	            </telerik:RadTileViewItem>
	        </telerik:RadTileView>
	    </Grid>
	{{endregion}}



## Disabling the Animation

To disable the animation developers can use the __IsItemsAnimationEnabled__ property and set it to __False__.
				

#### __XAML__

{{region radtileview-animation_1}}
	<telerik:RadTileView IsItemsAnimationEnabled="False"  x:Name="RadTileView1" MaximizeMode="One">
	    <telerik:RadTileViewItem Header="Item1">
	        <TextBlock Text="Item1 Content"/>
	    </telerik:RadTileViewItem>
	    <telerik:RadTileViewItem Header="Item2">
	        <TextBlock Text="Item2 Content"/>
	    </telerik:RadTileViewItem>
	    <telerik:RadTileViewItem Header="Item3" >
	        <TextBlock Text="Item3 Content"/>
	    </telerik:RadTileViewItem>
	    <telerik:RadTileViewItem Header="Item4" >
	        <TextBlock Text="Item4 Content"/>
	    </telerik:RadTileViewItem>
	    <telerik:RadTileViewItem Header="Item5" >
	        <TextBlock Text="Item5 Content"/>
	    </telerik:RadTileViewItem>
	    <telerik:RadTileViewItem Header="Item6" >
	        <TextBlock Text="Item6 Content"/>
	    </telerik:RadTileViewItem>
	</telerik:RadTileView>
	{{endregion}}



# See Also

 * [Getting Started]({%slug radtileview-getting-started%})

 * [Events]({%slug radtileview-events%})
