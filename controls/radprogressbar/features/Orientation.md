---
title: Orientation
page_title: Orientation
description: Orientation
slug: orientation
tags: orientation
published: True
position: 1
---

# Orientation



## 

__RadProgressBar__ has an __Orientation__ property which can be set to either *Horizontal* or *Vertical*. The two allowed values specify the direction in which the control is being "filled". Below you can see examples of how to set the __Orientation__ property both in *C#* and *XAML* code:

#### __XAML__

{{region Orientation_1}}
	<telerik:RadProgressBar Value="35" Height="30" Width="150" Orientation="Horizontal" />
	{{endregion}}



#### __C#__

{{region Orientation_0}}
	RadProgressBar progressBar = new RadProgressBar();
	progressBar.Orientation = System.Windows.Controls.Orientation.Horizontal;
	{{endregion}}



#### __VB.NET__

{{region Orientation_0}}
		Dim progressBar As New RadProgressBar()
		progressBar.Orientation = System.Windows.Controls.Orientation.Horizontal
	#End Region
	
	#Region "Orientation_2"
		Dim progressBar As New RadProgressBar()
		progressBar.Orientation = System.Windows.Controls.Orientation.Vertical
	#End Region
	
	End Class



![](images/progress_horizontal.jpg)

*Fig. 1 Horizontal ProgressBar*

#### __XAML__

{{region Orientation_3}}
	<telerik:RadProgressBar Value="35" Height="150" Width="30" Orientation="Vertical" />
	{{endregion}}



#### __C#__

{{region Orientation_2}}
	RadProgressBar progressBar = new RadProgressBar();
	progressBar.Orientation = System.Windows.Controls.Orientation.Vertical;
	{{endregion}}



#### __VB.NET__

{{region Orientation_2}}
		Dim progressBar As New RadProgressBar()
		progressBar.Orientation = System.Windows.Controls.Orientation.Vertical
	#End Region
	
	End Class



![](images/progress_vertical.jpg)

*Fig. 2 Vertical ProgressBar*

Note that whenever you change the __Orientation__ property, it will make sense to also change the height and width of the control since the property only changes the direction in which __RadProgressBar__ is filled.
