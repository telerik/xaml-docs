---
title: Direction
page_title: Direction
description: Check our &quot;Direction&quot; documentation article for the RadSlider {{ site.framework_name }} control.
slug: radslider-direction
tags: direction
published: True
position: 6
---

# Direction



## 

The __IsDirectionReversed__ property determines whether the direction of increasing __Value__ is reversed from the default direction. By default the property is __false__ and values increase __from left to right for a horizontal slider__. 
        

For a __vertical Slider the values increase from bottom to top__. When you set the __IsDirectionReversed__ property to __true__, the direction of increasing value reverses.

#### __XAML__

```XAML
	<telerik:RadSlider Maximum="10" TickFrequency="1" TickPlacement="TopLeft" IsDirectionReversed="False">
	    <telerik:RadSlider.TickTemplate>
	        <DataTemplate>
	            <Grid>
	                <TextBlock Text="{Binding}" FontSize="11" />
	            </Grid>
	        </DataTemplate>
	    </telerik:RadSlider.TickTemplate>
	</telerik:RadSlider>
```

![{{ site.framework_name }} RadSlider Normal Direction Horizontal](images/radslider_features_normal_horizontal.png)

#### __XAML__

```XAML
	<telerik:RadSlider Maximum="10" TickFrequency="1" TickPlacement="TopLeft" IsDirectionReversed="True">
	    <telerik:RadSlider.TickTemplate>
	        <DataTemplate>
	            <Grid>
	                <TextBlock Text="{Binding}" FontSize="11" />
	            </Grid>
	        </DataTemplate>
	    </telerik:RadSlider.TickTemplate>
	</telerik:RadSlider>
```

![{{ site.framework_name }} RadSlider Reversed Direction Horizontal](images/radslider_features_reversed_horizontal.png)

#### __XAML__

```XAML
	<telerik:RadSlider Height="250" 
	           Margin="10"
	           IsDirectionReversed="False"
	           Maximum="10"
	           Orientation="Vertical"
	           TickFrequency="1"
	           TickPlacement="TopLeft">
	    <telerik:RadSlider.TickTemplate>
	        <DataTemplate>
	            <Grid>
	                <TextBlock FontSize="11" Text="{Binding}" />
	            </Grid>
	        </DataTemplate>
	    </telerik:RadSlider.TickTemplate>
	</telerik:RadSlider>
```

![{{ site.framework_name }} RadSlider Normal Direction Vertical](images/radslider_features_normal_vertical.png)

#### __XAML__

```XAML
	<telerik:RadSlider Height="250" 
	           Margin="10"
	           IsDirectionReversed="True"
	           Maximum="10"
	           Orientation="Vertical"
	           TickFrequency="1"
	           TickPlacement="TopLeft">
	    <telerik:RadSlider.TickTemplate>
	        <DataTemplate>
	            <Grid>
	                <TextBlock FontSize="11" Text="{Binding}" />
	            </Grid>
	        </DataTemplate>
	    </telerik:RadSlider.TickTemplate>
	</telerik:RadSlider>
```

![{{ site.framework_name }} RadSlider Reversed Direction Vertical](images/radslider_features_reversed_vertical.png)
