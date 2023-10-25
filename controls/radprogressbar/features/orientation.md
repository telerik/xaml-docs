---
title: Orientation
page_title: Orientation
description: Check our &quot;Orientation&quot; documentation article for the RadProgressBar {{ site.framework_name }} control.
slug: orientation
tags: orientation
published: True
position: 1
---

# Orientation

`RadProgressBar` has an `Orientation` property which can be set to either __Horizontal__ or __Vertical__. The two allowed values specify the direction in which the control is being "filled".

#### __[XAML] Setting the Orientation property to Horizontal__
{{region xaml-Orientation_0}}
	<telerik:RadProgressBar Value="35" Height="30" Width="150" Orientation="Horizontal" />
{{endregion}}

#### __[C#] Setting the Orientation property to Horizontal__
{{region cs-Orientation_1}}
	RadProgressBar progressBar = new RadProgressBar();
	progressBar.Orientation = System.Windows.Controls.Orientation.Horizontal;
{{endregion}}

#### __[VB.NET] Setting the Orientation property to Horizontal__
{{region vb-Orientation_2}}
	Dim progressBar As New RadProgressBar()
	progressBar.Orientation = System.Windows.Controls.Orientation.Horizontal
{{endregion}}

![{{ site.framework_name }} RadProgressBar Horizontal Orientation](images/progress_horizontal.jpg)


#### __[XAML] Setting the Orientation property to Vertical__
{{region xaml-Orientation_3}}
	<telerik:RadProgressBar Value="35" Height="150" Width="30" Orientation="Vertical" />
{{endregion}}

#### __[C#] Setting the Orientation property to Vertical__
{{region cs-Orientation_4}}
	RadProgressBar progressBar = new RadProgressBar();
	progressBar.Orientation = System.Windows.Controls.Orientation.Vertical;
{{endregion}}

#### __[VB.NET] Setting the Orientation property to Vertical__
{{region vb-Orientation_5}}
	Dim progressBar As New RadProgressBar()
	progressBar.Orientation = System.Windows.Controls.Orientation.Vertical
{{endregion}}	

![{{ site.framework_name }} RadProgressBar Vertical Orientation](images/progress_vertical.jpg)

>Whenever you change the __Orientation__ property, it will make sense to also change the height and width of the control since the property only changes the direction in which __RadProgressBar__ is filled.