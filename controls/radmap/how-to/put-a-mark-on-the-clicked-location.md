---
title: Put a Mark on the clicked Location
page_title: Put a Mark on the clicked Location
description: Check our &quot;Put a Mark on the clicked Location&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-how-to-put-a-mark-on-the-clicked-location
tags: put,a,mark,on,the,clicked,location
published: True
position: 4
---

# Put a Mark on the clicked Location

If you want to mark the position where the user has clicked, you just have to handle the __MapMouseClick__ event and add the desired mark element to the __InformationLayer__ of the __RadMap__ on the clicked location.

The following example will use a __RadMap__ with one __InformationLayer__. The __InformationLayer__ has its __ItemTemplate__ property set. The __DataTemplate__ contains a red __Ellipse__. In this example, the object that will be passed to the __InformationLayer__ will be of type Location, so the __MapLayer.Location__ property of the ellipse is bound to the __DataContext__ of the template.

>tip More detailed information regarding the data binding can be found in the [Data Binding]({%slug radmap-features-data-binding%}) topic.

>tip To learn how to define a provider for the __RadMap__, read the [Providers]({%slug radmap-features-providers%}) topic.

Here is the code for the example:


```XAML
	<telerik:RadMap x:Name="radMap"
	                Width="600"
	                Height="480"
	                MapMouseClick="radMap_MapMouseClick">
	    <telerik:InformationLayer x:Name="informationLayer">
	        <telerik:InformationLayer.ItemTemplate>
	            <DataTemplate>
	                <Ellipse telerik:MapLayer.Location="{Binding}"
	                            Width="20"
	                            Height="20"
	                            Stroke="Red"
	                            StrokeThickness="3"
	                            Fill="Transparent">
	                    <telerik:MapLayer.HotSpot>
	                        <telerik:HotSpot X="0.5"
	                                            Y="0.5" />
	                    </telerik:MapLayer.HotSpot>
	                </Ellipse>
	            </DataTemplate>
	        </telerik:InformationLayer.ItemTemplate>
	    </telerik:InformationLayer>
	</telerik:RadMap>
```


```C#
	private void radMap_MapMouseClick( object sender, MapMouseRoutedEventArgs eventArgs )
	{
	    this.informationLayer.Items.Clear();
	    this.informationLayer.Items.Add( eventArgs.Location );
	}
```
```VB.NET
	Private Sub radMap_MapMouseClick(ByVal sender As Object, ByVal eventArgs As MapMouseRoutedEventArgs)
		Me.informationLayer.Items.Clear()
		Me.informationLayer.Items.Add(eventArgs.Location)
	End Sub
```

## See Also
 * [Information Layer]({%slug radmap-features-information-layer%})
 * [Framework Elements]({%slug radmap-features-information-layer-framework-elements%})
 * [Map Shapes]({%slug radmap-features-map-shapes%})
 * [Set the Best View for the InformationLayer]({%slug radmap-how-to-set-the-best-view-for-the-informationlayer%})
 * [Bring a Location into View]({%slug radmap-how-to-bring-a-location-into-view%})
