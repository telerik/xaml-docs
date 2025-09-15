---
title: IsIndeterminate
page_title: IsIndeterminate
description: Check our &quot;IsIndeterminate&quot; documentation article for the RadProgressBar {{ site.framework_name }} control.
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
```XAML
	<telerik:RadProgressBar Height="30" Width="150" IsIndeterminate="False" Value="35" />
```

#### __C#__
```C#
	RadProgressBar progressBar = new RadProgressBar();
	progressBar.IsIndeterminate = false;
```

#### __VB.NET__
```VB.NET
	Dim progressBar As New RadProgressBar()
	progressBar.IsIndeterminate = False
```

![{{ site.framework_name }} RadProgressBar Horizontal Determinate](images/progress_horizontal.jpg)

#### __XAML__		
```XAML
	<telerik:RadProgressBar Height="30" Width="150" IsIndeterminate="True" />
```

#### __C#__
```C#
	RadProgressBar progressBar = new RadProgressBar();
	progressBar.IsIndeterminate = true;
```

#### __VB.NET__
```VB.NET
	Dim progressBar As New RadProgressBar()
	progressBar.IsIndeterminate = True
```

	
![{{ site.framework_name }} RadProgressBar Horizontal Indeterminate](images/progress_indeterminate.jpg)