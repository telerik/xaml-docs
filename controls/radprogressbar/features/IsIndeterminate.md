---
title: IsIndeterminate
page_title: IsIndeterminate
description: IsIndeterminate
slug: isindeterminate
tags: isindeterminate
published: True
position: 2
---

# IsIndeterminate

__RadProgressBar__ supports two modes of operation:

* __Determinate__ - aimed at scenarios in which the progress of an operation can be precisely measured.

* __Indeterminate__ - aimed at scenarios in which there is no way of determining the current progress of an operation.

The __IsIndeterminate__ property specifies whether the control is in __InDeterminate__ mode or not. The property is of *boolean* type and the default value is *false*. Below you can see examples of how to set the property in *C#* and *XAML* code:

#### __XAML__
{{region xaml-IsIndeterminate_0}}
	<telerik:RadProgressBar Height="30" Width="150" IsIndeterminate="False" Value="35" />
{{endregion}}

#### __C#__
{{region cs-IsIndeterminate_1}}
	RadProgressBar progressBar = new RadProgressBar();
	progressBar.IsIndeterminate = false;
{{endregion}}

#### __VB.NET__
{{region vb-IsIndeterminate_2}}
	Dim progressBar As New RadProgressBar()
	progressBar.IsIndeterminate = False
{{endregion}}

![](images/progress_horizontal.jpg)

#### __XAML__		
{{region xaml-IsIndeterminate_3}}
	<telerik:RadProgressBar Height="30" Width="150" IsIndeterminate="True" />
{{endregion}}

#### __C#__
{{region cs-IsIndeterminate_4}}
	RadProgressBar progressBar = new RadProgressBar();
	progressBar.IsIndeterminate = true;
{{endregion}}

#### __VB.NET__
{{region vb-IsIndeterminate_5}}
	Dim progressBar As New RadProgressBar()
	progressBar.IsIndeterminate = True
{{endregion}}

	
![](images/progress_indeterminate.jpg)