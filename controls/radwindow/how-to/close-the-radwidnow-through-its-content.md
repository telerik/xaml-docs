---
title: Close the RadWindow Through its Content
page_title: Close the RadWindow Through its Content
description: Check our &quot;Close the RadWindow Through its Content&quot; documentation article for the RadWindow {{ site.framework_name }} control.
slug: radwindow-how-to-close-the-radwidnow-through-its-content
tags: close,the,radwindow,through,its,content
published: True
position: 5
---

# Close the RadWindow Through its Content

To close the __RadWindow__ through its content you have to get the instance of the __RadWindow__ and call its __Close()__ method. This tutorial will handle two possible scenarios:

* [When the content is directly set to the RadWindow](#content-directly-set-to-the-radwindow)

* [When the content is represented by a UserControl](#content-represented-by-a-usercontrol)

## Content, directly set to the RadWindow

>tipTo learn more about how to use the __RadWindow__ as user control read [this topic]({%slug radwindow-how-to-use-radwindow-as-user-control%}).

Here is a sample __RadWindow__, used as user control, with a button in it:

#### __XAML__

```XAML
	<telerik:RadWindow x:Class="RadWindowSamples.RadWindowControl"
	                   xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	                   xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	                   xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	    <Grid x:Name="LayoutRoot" Background="White">
	        <Button Content="Close me!" HorizontalAlignment="Center" VerticalAlignment="Center" />
	    </Grid>
	</telerik:RadWindow>
```

As the button is in the same control like the __RadWindow__, you can get the __RadWindow__ instance in the code-behind. In order to close the window through the button you have to attach to its __Click__ event and call the __Close()__ method of the __RadWindow__.

#### __XAML__

```XAML
	<Button Content="Close me!"
	        Click="Button_Click"
	        HorizontalAlignment="Center"
	        VerticalAlignment="Center" />
```

#### __C#__

```C#
	private void Button_Click(object sender, RoutedEventArgs e)
	{
	    this.Close();
	}
```

#### __VB.NET__

```VB.NET
	Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
	    Me.Close()
	End Sub
```

>tipInstead of event handler you can use a __RadButton__ with the __Close__ command for the __RadWindow__. Here is an example:

#### __XAML__

```XAML
	<telerik:RadButton Content="Close me!"
	                   HorizontalAlignment="Center"
	                   VerticalAlignment="Center"
	                   Command="telerik:WindowCommands.Close" />
```

## Content, represented by a UserControl

In this scenario the __Button__ is placed inside a __UserControl__, which is passed as the __Content__ of the __RadWindow__. In this case you cannot access the __RadWindow__ directly from the __UserControl__ as it is not aware of its existance. In order to close the __RadWindow__ when the button is clicked, you have to use the __ParentOfType\<T\>()__ extension method to get the __RadWindow__ instance.

>tipThe __ParentOfType\<T\>()__ is available when you use the __Telerik.Windows.Controls__ namespace from the __Telerik.Windows.Controls__. It returns the first element of this type up in the __Visual Tree__.

#### __C#__

```C#
	private void Button_Click(object sender, RoutedEventArgs e)
	{
	    RadWindow window = this.ParentOfType<RadWindow>();
	    window.Close();
	}
```

#### __VB.NET__

```VB.NET
	Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
	    Dim window As RadWindow = Me.ParentOfType(Of RadWindow)()
	    window.Close()
	End Sub
```

## See Also

 * [Working with RadWindow]({%slug radwindow-features-working-with-radwindow%})

 * [Use Keyboard to Get User Response]({%slug radwindow-how-to-use-keyboard-to-get-user-response%})

 * [Prevent Dragging Off the Screen]({%slug radwindow-how-to-prevent-dragging-off-the-screen%})
