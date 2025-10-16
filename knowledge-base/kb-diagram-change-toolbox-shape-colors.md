---
title: Change the Colors of the Shape Dropped from RadDiagram Toolbox
description: How to modify the brush of the drag/dropped shape added from the RadDiagram Toolbox to the RadDiagram canvas in a WPF application.
type: how-to
page_title: Modify the Color of the Shape Dragged from RadDiagramToolbox
slug: change-shape-colors-raddiagram-wpf
tags: radDiagram, wpf, shape, color, toolbox, brush
res_type: kb
ticketid: 1627931
---

## Environment

| Product | Version |
| --- | --- |
| RadDiagram for WPF | 2023.2.606 |

## Description

How to change the background and border brush a shape dragged from the RadDiagramToolBox, when the shape get dropped onto the RadDiagram surface.

## Solution

You can subscribe to the `SerializationService.Default.ItemSerializing` event. In the event handler, you can update the "Background" and "BorderBrush" settings of the `SerializationInfo` object.


```C#
	public MainWindow()
	{
		InitializeComponent();
		SerializationService.Default.ItemSerializing += Default_ItemSerializing;
	}

	private void Default_ItemSerializing(object sender, SerializationEventArgs<IDiagramItem> e)
	{
		var shape = e.Entity as RadDiagramShape;
		if (shape != null && shape.ParentOfType<RadDiagramToolbox>() != null)
		{
			e.SerializationInfo["Background"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8EC251"));
			e.SerializationInfo["BorderBrush"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8EC251"));
		}
	}
```

In case you need to change also the colors of the shape when displayed inside the RadDiagramToolBox, then you can add an implicit style in the `RadDiagramToolBox.Resources` tag and target the `RadDiagramShape` controls.


```XAML
       <telerik:RadDiagramToolbox.Resources>
		<Style TargetType="telerik:RadDiagramShape">
			<Setter Property="Background" Value="#8EC251" />
			<Setter Property="BorderBrush" Value="#8EC251" />
		</Style>
	</telerik:RadDiagramToolbox.Resources>
```

