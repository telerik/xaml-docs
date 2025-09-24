---
title: Colorizer
page_title: Colorizer
description: Check our &quot;Colorizer&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-colorizer
tags: colorizer
published: True
position: 9
---

# Colorizer

The __Colorizer__ feature of the __InformationLayer__ allows you to colorize the __MapShape__ objects inside it on the basis of a condition. This allows you to create maps that display shapes for each country with fill color depending on the population of the country.

In order to allow you to color the shapes depending on a condition, the __InformationLayer__ class exposes the __Colorizer__ property, which is of type __ColorMeasureScale__. This section will explain the usage of this object and its main features:

* [Using the ColorMeasureScale object](#using-the-colormeasurescale_object)

* [Extended Data Property](#extended-data-property)

* [Mode](#mode)

* [Colors](#colors)

* [Ranges](#ranges)

## Using the ColorMeasureScale object

To use the __ColorMeasureScale__ object in a layer, just set the __Colorizer__ property of the respective layer to a new instance of it. Here is an example:


```XAML
	<telerik:RadMap x:Name="radMap"
	                Width="600"
	                Height="480">
	    <telerik:InformationLayer x:Name="informationLayer">
	        <telerik:InformationLayer.Colorizer>
	            <telerik:ColorMeasureScale />
	        </telerik:InformationLayer.Colorizer>
	    </telerik:InformationLayer>
	</telerik:RadMap>
```

## Extended Data Property

The __ColorMeasureScale__ object colors the __MapShape__ objects inside a layer on the basis of a value. This value should be specified through the __Extended Data__ for the __MapShape__ object. 

>tip The __Extended Data__ represents a set of properties and their respective values.

In order to specify the desired property from the __Extended Data__, you have to use the __ExtendedPropertyName__ property of the __ColorMeasureScale__ object. 

>The property specified through the __ExtendedPropertyName__ should be of type __double__.

Here is an example, in which the __MapShapes__ get colored depending on the value of their area:


```XAML
	<telerik:RadMap x:Name="radMap"
	                Width="600"
	                Height="480">
	    <telerik:InformationLayer x:Name="informationLayer">
	        <telerik:InformationLayer.Colorizer>
	            <telerik:ColorMeasureScale ExtendedPropertyName="SQKM" />
	        </telerik:InformationLayer.Colorizer>
	    </telerik:InformationLayer>
	</telerik:RadMap>
```

## Mode

The __ColorMeasureScale__ splits the values passed through its __ExtendedPropertyName__ property and associates a fill color and highlight color for each one. It can automatically create ranges in two ways. For that purpose you have to use the Mode property of the __ColorMeasureScale__ object. It can have the following values:

* __Auto__

* __Count__ - specifies that the data will get split into __N__ equally sized ranges. The __N__ is equal to the value of the __TickMarkCount__ property of the __ColorMeasureScale__.

* __Step__ - specifies that the data will get split in ranges with step between them equal to __X__. The __X__ is equal to the value of the __TickMarkStep__ property of the __ColorMeasureScale__ object.

* __Ranges__ - specifies that the filling of the ranges will be calculated automatically by the __ColorMeasureScale__ colorizer.

* __RangesPredefinedColors__ - specifies that the __ColorMeasureScale__ colorizer will use filling settings which are set in the MapRange definition.

>tip When using the __InformationLayer__ object together with a __MapShapeReader__ object, the latter one automatically pass information about the __Min__ and __Max Values__ of the __ColorMeasureScale__. In this case you have to only use the __Mode__ and one of the two additional properties. When you are using manually generated shapes, you have to create the ranges manually. To learn more read the [Ranges](#ranges) section in this topic.

Here is an example of a __ColorMeasureScale__ with __7__ ranges:


```XAML
	<telerik:RadMap x:Name="radMap"
	                Width="600"
	                Height="480">
	    <telerik:InformationLayer x:Name="informationLayer">
	        <telerik:InformationLayer.Colorizer>
	            <telerik:ColorMeasureScale ExtendedPropertyName="SQKM"
	                                        Mode="Count"
	                                        TickMarkCount="7">
	            </telerik:ColorMeasureScale>
	        </telerik:InformationLayer.Colorizer>
	    </telerik:InformationLayer>
	</telerik:RadMap>
```

When you are using the __Count__ mode you can extend the __ColorMeasureScale__ with the ability to specify the value ranges distribution. For the purpose the __RangeDistribution__ property is provided. You can choose between:

* __ExponentialRangeDistribution__ - creates exponential range distribution

* __LogarithmicRangeDistribution__ - creates logarithmic range distribution

The following example shows how to use the __ColorMeasureScale__ with __Ranges__ mode:


```XAML
	<telerik:InformationLayer.Colorizer>
		<telerik:ColorMeasureScale ExtendedPropertyName="Population" MinValue="0" MaxValue="40000000" Mode="Ranges" TickMarkStep="5000000">
			<telerik:ColorMeasureScale.ShapeFillCollection>
				<telerik:MapShapeFill Fill="#FFFAB935" Stroke="White" StrokeThickness="2" />
				<telerik:MapShapeFill Fill="#FFC9441C" Stroke="White" StrokeThickness="2" />
			</telerik:ColorMeasureScale.ShapeFillCollection>
			<telerik:ColorMeasureScale.RangeCollection>
				<telerik:MapRange MinValue="0"
				 MaxValue="1000000" />
				<telerik:MapRange MinValue="1000000"
				 MaxValue="5000000" />
				<telerik:MapRange MinValue="5000000"
				 MaxValue="10000000" />
				<telerik:MapRange MinValue="10000000"
				 MaxValue="15000000" />
				<telerik:MapRange MinValue="15000000"
				 MaxValue="20000000" />
				<telerik:MapRange MinValue="20000000"
				 MaxValue="25000000" />
				<telerik:MapRange MinValue="25000000"
				 MaxValue="30000000" />
				<telerik:MapRange MinValue="35000000"
				 MaxValue="40000000" />
			</telerik:ColorMeasureScale.RangeCollection>
		</telerik:ColorMeasureScale>
	</telerik:InformationLayer.Colorizer>
```

And the following demonstrates the __ColorMeasureScale__ with __RangesPredefinedColors__ mode:


```XAML
	<telerik:InformationLayer.Colorizer>
		<telerik:ColorMeasureScale ExtendedPropertyName="Population" MinValue="0" MaxValue="40000000" Mode="RangesPredefinedColors" TickMarkStep="5000000">
			<telerik:ColorMeasureScale.ShapeFillCollection>
				<telerik:MapShapeFill Fill="#FFFAB935" Stroke="White" StrokeThickness="2" />
				<telerik:MapShapeFill Fill="#FFC9441C" Stroke="White" StrokeThickness="2" />
			</telerik:ColorMeasureScale.ShapeFillCollection>
			<telerik:ColorMeasureScale.RangeCollection>
				<telerik:MapRange MinValue="0" MaxValue="1000000">
					<telerik:MapRange.ShapeFill>
						<telerik:MapShapeFill Fill="Red" />
					</telerik:MapRange.ShapeFill>
				</telerik:MapRange>
			</telerik:ColorMeasureScale.RangeCollection>
		</telerik:ColorMeasureScale>
	</telerik:InformationLayer.Colorizer>
```

## Colors

The __ColorMeasureScale__ can apply a different color to each range it creates. You are able to specify the desired set of colors not only for the normal fill of the shapes, but for the highlighted one too. This is done by using the __ShapeFillCollection__ and __HighlightFillCollection__ properties. They are collections of __MapShapeFill__ objects.

>If you are creating the ranges manually, you can pass the __MapShapeFill__ object directly to the __MapRange__ object. To learn more read the [Ranges](#ranges) section.

>tip To learn more about the __MapShapeFill__ object read [here](#using-the-mapshapefill-object-on-the-control-level).

Add the desired colors inside the collections and they will be applied in their respective order.

>The first color will get applied to the lowest layer. 

In case you have more ranges than colors, after reaching the last color in the collection, the others will get reused starting from the beginning. For example if you want to have the same highlight color for all of the ranges, you just define one entry in the __HighlightFillCollection__ property.

Here is an example:


```XAML
	<telerik:RadMap x:Name="radMap"
	                Width="600"
	                Height="480">
	    <telerik:InformationLayer x:Name="informationLayer">
	        <telerik:InformationLayer.Colorizer>
	            <telerik:ColorMeasureScale ExtendedPropertyName="SQKM"
	                                        Mode="Auto"
	                                        TickMarkCount="7">
	                <telerik:ColorMeasureScale.ShapeFillCollection>
	                    <telerik:MapShapeFill Fill="#FFF0D9"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFE4BA"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFDBA3"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFD28D"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFBF5C"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFAF33"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#E2942D"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                </telerik:ColorMeasureScale.ShapeFillCollection>
	                <telerik:ColorMeasureScale.HighlightFillCollection>
	                    <telerik:MapShapeFill Fill="Orange"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                </telerik:ColorMeasureScale.HighlightFillCollection>
	            </telerik:ColorMeasureScale>
	        </telerik:InformationLayer.Colorizer>
	    </telerik:InformationLayer>
	</telerik:RadMap>
```

>important With the approach shown above any 2 shapes (even if they are neighbours) may be colored equally. To avoid this you should use the [GraphColorizer]({%slug radmap-features-graph-colorizer%})

## Ranges

The ranges for the __ColorMeasureScale__ can be defined in several different ways. The first one is by only using the __Mode__ and the __TickMarkCount__ or __TickMarkStep__ property. This approach is applicable when using the __InformationLayer__ object together with a __MapShapeReader__ object. Here is an example:

>tip To learn more about the __Mode__ property read the [Mode](#mode) section.


```XAML
	<telerik:RadMap x:Name="radMap"
	                Width="600"
	                Height="480">
	    <telerik:InformationLayer x:Name="informationLayer">
	        <telerik:InformationLayer.Colorizer>
	            <telerik:ColorMeasureScale ExtendedPropertyName="SQKM"
	                                        Mode="Count"
	                                        TickMarkCount="7">
	                <telerik:ColorMeasureScale.ShapeFillCollection>
	                    <telerik:MapShapeFill Fill="#FFF0D9"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFE4BA"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFDBA3"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFD28D"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFBF5C"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFAF33"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#E2942D"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                </telerik:ColorMeasureScale.ShapeFillCollection>
	                <telerik:ColorMeasureScale.HighlightFillCollection>
	                    <telerik:MapShapeFill Fill="Orange"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                </telerik:ColorMeasureScale.HighlightFillCollection>
	            </telerik:ColorMeasureScale>
	        </telerik:InformationLayer.Colorizer>
	    </telerik:InformationLayer>
	</telerik:RadMap>
```

Another approach that extends the previous one is to handle the __PrepareCompleted__ event of the __ColorMeasureScale__ object in addition. This will allow you to modify the collection containing the ranges after the __ColorMeasureScale__ object has been prepared. In the event handler you can modify the __Min and Max Values__ of the existing ranges. Here is an example:


```XAML
	<telerik:RadMap x:Name="radMap"
	                Width="600"
	                Height="480">
	    <telerik:InformationLayer x:Name="informationLayer">
	        <telerik:InformationLayer.Colorizer>
	            <telerik:ColorMeasureScale ExtendedPropertyName="SQKM"
	                                        Mode="Count"
	                                        TickMarkCount="7" PrepareCompleted="ColorMeasureScale_PrepareCompleted">
	                <telerik:ColorMeasureScale.ShapeFillCollection>
	                    <telerik:MapShapeFill Fill="#FFF0D9"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFE4BA"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFDBA3"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFD28D"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFBF5C"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFAF33"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#E2942D"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                </telerik:ColorMeasureScale.ShapeFillCollection>
	                <telerik:ColorMeasureScale.HighlightFillCollection>
	                    <telerik:MapShapeFill Fill="Orange"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                </telerik:ColorMeasureScale.HighlightFillCollection>
	            </telerik:ColorMeasureScale>
	        </telerik:InformationLayer.Colorizer>
	    </telerik:InformationLayer>
	</telerik:RadMap>
```


```C#
	private void ColorMeasureScale_PrepareCompleted( object sender, Telerik.Windows.Controls.Map.ShapeColorizerEventArgs e )
	{
	    ColorMeasureScale scale = sender as ColorMeasureScale;
	    if ( scale != null )
	    {
	        //this lines of code modify the second last item and remove the last item.
	        scale.RangeCollection[ scale.RangeCollection.Count - 2 ].MaxValue = scale.RangeCollection.Last().MaxValue;
	        scale.RangeCollection.Remove( scale.RangeCollection.Last() );
	    }
	}
```


```VB.NET
	Private Sub ColorMeasureScale_PrepareCompleted(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.Map.ShapeColorizerEventArgs)
	 Dim scale As ColorMeasureScale = TryCast(sender, ColorMeasureScale)
	 If scale IsNot Nothing Then
	  'this lines of code modify the second last item and remove the last item.'
	  scale.RangeCollection(scale.RangeCollection.Count - 2).MaxValue = scale.RangeCollection.Last().MaxValue
	  scale.RangeCollection.Remove(scale.RangeCollection.Last())
	 End If
	End Sub
```

The next approach is to manually define the __Min__ and __Max Values__ of the __ColorMeasureScale__ object and to use the __Mode__ property together with the __TickMarkCount__ or __TickMarkStep__ property. This approach is useful, when having __InformationLayer__ that displays manually generated shapes. 

>Note that setting the __Min__ and __Max Values__ will make the __ColorMeasureScale__ behave as if it works with __MapShapeReader__. This means that you can still use the __HightlightFillCollection__ and __ShapeFillCollection__ properties.


```XAML
	<telerik:RadMap x:Name="radMap"
	                Width="600"
	                Height="480">
	    <telerik:InformationLayer x:Name="informationLayer">
	        <telerik:InformationLayer.Colorizer>
	            <telerik:ColorMeasureScale ExtendedPropertyName="SQKM"
	                                        Mode="Count"
	                                        TickMarkCount="7"
	                                        MinValue="371.72"
	                                        MaxValue="16911282.0">
	                <telerik:ColorMeasureScale.ShapeFillCollection>
	                    <telerik:MapShapeFill Fill="#FFF0D9"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFE4BA"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFDBA3"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFD28D"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFBF5C"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#FFAF33"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                    <telerik:MapShapeFill Fill="#E2942D"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                </telerik:ColorMeasureScale.ShapeFillCollection>
	                <telerik:ColorMeasureScale.HighlightFillCollection>
	                    <telerik:MapShapeFill Fill="Orange"
	                                            Stroke="#B1946D"
	                                            StrokeThickness="1" />
	                </telerik:ColorMeasureScale.HighlightFillCollection>
	            </telerik:ColorMeasureScale>
	        </telerik:InformationLayer.Colorizer>
	    </telerik:InformationLayer>
	</telerik:RadMap>
```

In addition to the previous approach you can again use the __PrepareCompleted__ event. Additionally with the __Min__ and __Max Values__ defined you can directly define the desired ranges at design-time via the __RangeCollection__ property of the __ColorMeasureScale__ object. In this case you shouldn't use the __HighlightFillCollection__ and __ShapeFillCollection__ properties, as they are used only when the ranges are automatically generated. You have to specify the desired colors via the __HighlightFill__ and __ShapeFill__ properties of the __MapRange__ object. Here is an example.


```XAML
	<telerik:RadMap x:Name="radMap"
	                Width="600"
	                Height="480">
	    <telerik:InformationLayer x:Name="informationLayer">
	        <telerik:InformationLayer.Colorizer>
	            <telerik:ColorMeasureScale ExtendedPropertyName="SQKM"
	                                        Mode="Auto"
	                                        MinValue="371.2"
	                                        MaxValue="16911282">
	                <telerik:ColorMeasureScale.RangeCollection>
	                    <telerik:MapRange MinValue="371.2"
	                                        MaxValue="8000000">
	                        <telerik:MapRange.ShapeFill>
	                            <telerik:MapShapeFill Fill="#FFF0D9"
	                                                    Stroke="#B1946D"
	                                                    StrokeThickness="1" />
	                        </telerik:MapRange.ShapeFill>
	                        <telerik:MapRange.HighlightFill>
	                            <telerik:MapShapeFill Fill="Orange"
	                                                    Stroke="#B1946D"
	                                                    StrokeThickness="1" />
	                        </telerik:MapRange.HighlightFill>
	                    </telerik:MapRange>
	                    <telerik:MapRange MinValue="8000000"
	                                        MaxValue="16911282">
	                        <telerik:MapRange.ShapeFill>
	                            <telerik:MapShapeFill Fill="#E2942D"
	                                                    Stroke="#B1946D"
	                                                    StrokeThickness="1" />
	                        </telerik:MapRange.ShapeFill>
	                        <telerik:MapRange.HighlightFill>
	                            <telerik:MapShapeFill Fill="Orange"
	                                                    Stroke="#B1946D"
	                                                    StrokeThickness="1" />
	                        </telerik:MapRange.HighlightFill>
	                    </telerik:MapRange>
	                </telerik:ColorMeasureScale.RangeCollection>
	            </telerik:ColorMeasureScale>
	        </telerik:InformationLayer.Colorizer>
	    </telerik:InformationLayer>
	</telerik:RadMap>
```

## See Also
 * [Map Legend]({%slug radmap-features-map-legend%})
 * [Shape Appearance]({%slug radmap-features-shape-appearance%})
 * [Extended Data]({%slug radmap-features-extended-data%})