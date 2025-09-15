---
title: Chart Extensions
page_title: Chart Extensions
description: Check our &quot;Chart Extensions&quot; documentation article for the RadChart {{ site.framework_name }} control.
slug: radchart-features-chart-extensions
tags: chart,extensions
published: True
position: 21
---

# Chart Extensions



__RadChart__ supports extensibility mechanism for the creation of custom chart extensions (tools) via the [Extensible Object](http://msdn.microsoft.com/en-us/library/ms733816.aspx) Pattern. This pattern enables an object to participate in custom behaviors, such as registering for events, or watching state transitions. 

The purpose of this tutorial is to show you how to create a custom chart area extension.

## Extensible Object Pattern Overview

There are three interfaces in the extensible object pattern: [IExtensibleObject](http://msdn.microsoft.com/en-us/library/ms586697.aspx), IExtension, and [IExtensionCollection](http://msdn.microsoft.com/en-us/library/ms586700.aspx).

The __IExtensibleObject__ interface is implemented by types that allow __IExtension__ objects to customize their functionality. __Extensible__ objects allow dynamic aggregation of IExtension objects. __IExtension__ objects are characterized by the following interface:

#### __C#__

```C#
	public interface IExtension<T>
	    where T : IExtensibleObject<T>
	{
	   void Attach(T owner);
	   void Detach(T owner);
	}
```



#### __VB.NET__

```VB.NET
	Public Interface IExtension(Of T As IExtensibleObject(Of T))
	    Sub Attach(ByVal owner As T)
	    Sub Detach(ByVal owner As T)
	End Interface
```



By design the chart extensions work on __ChartArea__ basis (you can add different extensions to the separate __ChartArea__ instances defined in your chart template) thus the __IExtensibleObject__ interface is implemented by the __ChartArea__ class.

## How to Create Custom Chart Extensions

In order to plug your custom tool into the extensibility infrastructure supported by __RadChart__ each extension should inherit from the __Telerik.Windows.Controls.Charting.ChartExtension__ base class that implements the __IExtension__ interface. Then you need to override the two methods of the __IExtension__ interface:

* __Attach(ChartArea owner)__- this method enables an extension object to find out when it has been aggregated. It is called when the extension is added to the __ChartArea.Extensions__ collection property. You can get hold of the __ChartArea__ that "owns" this extension here and use its instance as per the requirements of your custom tool.

* __Detach(ChartArea owner)__ - this method enables an object to find out when it is no longer aggregated. It is called when an extension is removed from the __ChartArea.Extensions__ collection property.

## How to Add Custom Extension to the Chart Control

In order to utilize the already defined custom tool you need to add it to the __Extensions__ collection property of the respective __ChartArea__ which functionality you would like to extend. Here is a sample code snippet that demonstrates adding / removing the __CameraExtension__ on __UserControl.Loaded__ / __Unloaded__ events:

#### __C#__

```C#
	private void UserControl_Loaded(object sender, RoutedEventArgs e)
	{
	    CameraExtension cameraExtension = new CameraExtension();
	    radChart.DefaultView.ChartArea.Extensions.Add(cameraExtension);
	}
	private void UserControl_Unloaded(object sender, RoutedEventArgs e)
	{
	    radChart.DefaultView.ChartArea.Extensions.Clear();
	}
```



#### __VB.NET__

```VB.NET
	Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
	    Dim cameraExtension As New CameraExtension()
	    radChart.DefaultView.ChartArea.Extensions.Add(cameraExtension)
	End Sub
	Private Sub UserControl_Unloaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
	    radChart.DefaultView.ChartArea.Extensions.Clear()
	End Sub
```



__RadChart__ provides out-of-the-box a custom __CameraExtension__ that follows this pattern and handles the zooming and the rotation of the chart in the 3D space:

* On the __Attach__(...) method a 2D canvas wrapper is created that serves as an event source for the mouse-related events associated with zooming and rotation (i.e. __MouseDown__, __MouseUp__, __MouseMove__, __MouseWheel__).

* The __ChartArea__ owner is used as a reference point to inject this canvas element into the control tree of the chart (the 2D element is placed on the top so mouse events can be correctly registered).

* The mouse event handlers use the 2D input to produce the resultant 3D transforms for zooming and rotation.

* These transforms are then applied to the __ChartArea Visual3D__ in order to actually zoom / rotate the __ChartArea__ in the 3D space.

## See Also

 * [Chart Area]({%slug radchart-features-chart-area%})

 * [DefaultView]({%slug radchart-features-default-view%})
