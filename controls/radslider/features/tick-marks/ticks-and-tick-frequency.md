---
title: Ticks and Tick frequency
page_title: Ticks and Tick frequency
description: Check our &quot;Ticks and Tick frequency&quot; documentation article for the RadSlider {{ site.framework_name }} control.
slug: radslider-ticks-and-tick-frequency
tags: ticks,and,tick,frequency
published: True
position: 0
---

# Ticks and Tick frequency



## 

The __Ticks__ property allows you to place marks(ticks) along the track in a __non-uniform__ manner, unlike the __TickFrequency__ property which places the ticks on equal intervals. The __Ticks__ property is of type __DoubleCollection__ and its default value is null. This property has to be combined with setting __TickPlacement__ to something different than __None__.
        

#### __XAML__

```XAML
	<telerik:RadSlider Maximum="10" Ticks="3,5,7" TickPlacement="TopLeft" />
```



#### __C#__

```C#
	RadSlider radSlider1 = new RadSlider();
	radSlider1.Maximum = 10;
	DoubleCollection tickCollection = new DoubleCollection();
	tickCollection.Add(3);
	tickCollection.Add(5);
	tickCollection.Add(7);
	radSlider1.Ticks = tickCollection;
	radSlider1.TickPlacement = TickPlacement.TopLeft;
	LayoutRoot.Children.Add(radSlider1);
```



#### __VB.NET__

```VB.NET
	Dim radSlider1 As New RadSlider()
	radSlider1.Maximum = 10
	Dim tickCollection As New DoubleCollection()
	tickCollection.Add(3)
	tickCollection.Add(5)
	tickCollection.Add(7)
	radSlider1.Ticks = tickCollection
	radSlider1.TickPlacement = TickPlacement.TopLeft
	LayoutRoot.Children.Add(radSlider1)
```

![{{ site.framework_name }} RadSlider Custom Tick Collection](images/radslider_features_ticks_custom.png)

The __TickFrequency__ property on the other hand allows you to place marks(ticks) along the track in a __uniform__ manner. On the example bellow, since the __Maximum__ is 10 and the __TickFrequency__ is 2, this means that there will be tick marks at 0, 2, 4, 6, 8 and 10.

#### __XAML__

```XAML
	<telerik:RadSlider Maximum="10" TickFrequency="2" TickPlacement="BottomRight" />
```

![{{ site.framework_name }} RadSlider Tick Frequency](images/radslider_features_ticks_default.png)
