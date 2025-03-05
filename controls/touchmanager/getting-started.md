---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the TouchManager {{ site.framework_name }} control.
slug: touchmanager-getting-started
tags: getting,started,touch,manager,touchmanager
published: True
position: 2
---

# Getting started with {{ site.framework_name }} TouchManager

This article demonstrates a simple image gallery implemented with __TouchManager__ and demonstrates the basic usage of the manager.

## Adding Telerik Assemblies Using NuGet

To use __TouchManager__ when working with NuGet packages, install the `Telerik.Windows.Controls.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:		

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

First, we can create the UI of the gallery (Example 1). We will use one panel to hold several Image elements that will represent the gallery with the small images (the thumbnails). Then we can add another panel that will display the selected image.

#### __[XAML] Example 1: Defining the UI of the TouchManager example__
{{region touchmanager-getting-started-0}}
	<Window x:Class="WpfApplication2.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
        Title="MainWindow">
		<Grid Background="#323232">
			<Border x:Name="galleryContainer"
					Background="#E4E4E4" 
					Width="800" 
					Height="320">
				<Border.Clip>
					<RectangleGeometry Rect="0, 0, 800, 320"/>
				</Border.Clip>
				<StackPanel x:Name="galleryPanel" Orientation="Horizontal">
					<Image Source="Images/001.jpg" Height="320" Stretch="UniformToFill" Width="150" Margin="5 0 5 0" />
					<Image Source="Images/002.jpg" Height="320" Stretch="UniformToFill" Width="150" Margin="5 0 5 0" />
					<Image Source="Images/003.jpg" Height="320" Stretch="UniformToFill" Width="150" Margin="5 0 5 0" />
					<Image Source="Images/004.jpg" Height="320" Stretch="UniformToFill" Width="150" Margin="5 0 5 0" />
					<Image Source="Images/005.jpg" Height="320" Stretch="UniformToFill" Width="150" Margin="5 0 5 0" />
					<Image Source="Images/006.jpg" Height="320" Stretch="UniformToFill" Width="150" Margin="5 0 5 0" />
					<Image Source="Images/007.jpg" Height="320" Stretch="UniformToFill" Width="150" Margin="5 0 5 0" />
					<Image Source="Images/008.jpg" Height="320" Stretch="UniformToFill" Width="150" Margin="5 0 5 0" />
					<Image Source="Images/009.jpg" Height="320" Stretch="UniformToFill" Width="150" Margin="5 0 5 0" />
					<Image Source="Images/010.jpg" Height="320" Stretch="UniformToFill" Width="150" Margin="5 0 5 0" />
					<Image Source="Images/011.jpg" Height="320" Stretch="UniformToFill" Width="150" Margin="5 0 5 0" />                
				</StackPanel>
			</Border>

			<Border x:Name="largeImageContainer" Visibility="Collapsed" Width="500" Height="500">
				<Border.Clip>
					<RectangleGeometry Rect="0, 0, 500, 500"/>
				</Border.Clip>               
				<Image x:Name="largeImage" Stretch="UniformToFill" />
			</Border>
		</Grid>
	</Window>
{{endregion}}

This is the frame over which we will implement the touch interactions - swipe and tap. 

Here is an image that demonstrates the view:
![Getting Started 01](images/touchmanager_getting_started_01.png)

Let us start by implementing the swipe of the gallery items. We can do that by handling the swipe and swipe inertia events of TouchManager. Example 2 demonstrates how to subscribe to the events:

#### __[C#] Example 2: Subscribing to TouchManager events__
{{region touchmanager-getting-started-1}}
	TouchManager.AddSwipeStartedEventHandler(this.galleryContainer, new TouchEventHandler(OnGallerySwipeStarted));
	TouchManager.AddSwipeEventHandler(this.galleryContainer, new SwipeEventHandler(OnGallerySwipe));
	TouchManager.AddSwipeFinishedEventHandler(this.galleryContainer, new TouchEventHandler(OnGallerySwipeFinished));

	TouchManager.AddSwipeInertiaStartedEventHandler(this.galleryContainer, new RadRoutedEventHandler(OnGallerySwipeInertiaStarted));
	TouchManager.AddSwipeInertiaEventHandler(this.galleryContainer, new SwipeInertiaEventHandler(OnGallerySwipeInertia));
	TouchManager.AddSwipeInertiaFinishedEventHandler(this.galleryContainer, new RadRoutedEventHandler(OnGallerySwipeInertiaFinished));
{{endregion}}

#### __[VB.NET] Example 2: Subscribing to TouchManager events__
{{region touchmanager-getting-started-2}}
	TouchManager.AddSwipeStartedEventHandler(Me.galleryContainer, New TouchEventHandler(AddressOf OnGallerySwipeStarted))
	TouchManager.AddSwipeEventHandler(Me.galleryContainer, New SwipeEventHandler(AddressOf OnGallerySwipe))
	TouchManager.AddSwipeFinishedEventHandler(Me.galleryContainer, New TouchEventHandler(AddressOf OnGallerySwipeFinished))

	TouchManager.AddSwipeInertiaStartedEventHandler(Me.galleryContainer, New RadRoutedEventHandler(AddressOf OnGallerySwipeInertiaStarted))
	TouchManager.AddSwipeInertiaEventHandler(Me.galleryContainer, New SwipeInertiaEventHandler(AddressOf OnGallerySwipeInertia))
	TouchManager.AddSwipeInertiaFinishedEventHandler(Me.galleryContainer, New RadRoutedEventHandler(AddressOf OnGallerySwipeInertiaFinished))
{{endregion}}

The logic for the swipe action will be implemented in the Swipe and SwipeInertia event handlers. We can place the implementation in a separate method and use it in the handlers.

#### __[C#] Example 3: Event handlers implementation__
{{region touchmanager-getting-started-3}}
	private void OnGallerySwipe(object sender, SwipeEventArgs args)
	{
		args.Handled = true;
		this.MoveGallery(args.HorizontalChange);
	}	

	private void OnGallerySwipeInertia(object sender, SwipeInertiaEventArgs args)
	{
		args.Handled = true;
		this.MoveGallery(args.HorizontalChange);
	}
	
	private void MoveGallery(double horizontalOffset)
	{
		var margin = this.galleryPanel.Margin;
		var newLeft = margin.Left + horizontalOffset;
		newLeft = Math.Min(newLeft, 0);
		newLeft = Math.Max(newLeft, this.galleryContainer.ActualWidth - this.galleryPanel.ActualWidth);
		this.galleryPanel.Margin = new Thickness(newLeft, margin.Top, margin.Right, margin.Bottom);
	}
{{endregion}}

#### __[VB.NET] Example 3: Event handlers implementation__
{{region touchmanager-getting-started-4}}
	Private Sub OnGallerySwipe(sender As Object, args As SwipeEventArgs)
		args.Handled = True
		Me.MoveGallery(args.HorizontalChange)
	End Sub
	
	Private Sub OnGallerySwipeInertia(sender As Object, args As SwipeInertiaEventArgs)
		args.Handled = True
		Me.MoveGallery(args.HorizontalChange)
	End Sub

	Private Sub MoveGallery(horizontalOffset As Double)
		Dim margin = Me.galleryPanel.Margin
		Dim newLeft = margin.Left + horizontalOffset
		newLeft = Math.Min(newLeft, 0)
		newLeft = Math.Max(newLeft, Me.galleryContainer.ActualWidth - Me.galleryPanel.ActualWidth)
		Me.galleryPanel.Margin = New Thickness(newLeft, margin.Top, margin.Right, margin.Bottom)
	End Sub
{{endregion}}

Although we are working directly only with the Swipe and SwipeInertia events, we are going to handle the related events for consistency - SwipeStarted, SwipeFinisihed, SwipeInertiaStarted and SwipeInertiaFinished. 

#### __[C#] Example 4: Event handlers implementation__
{{region touchmanager-getting-started-5}}
	private void OnGallerySwipeStarted(object sender, TouchEventArgs args)
	{
		args.Handled = true;
	}
	
	private void OnGallerySwipeFinished(object sender, TouchEventArgs args)
	{
		args.Handled = true;
	}

	private void OnGallerySwipeInertiaStarted(object sender, RadRoutedEventArgs e)
	{            
		e.Handled = true;            
	}
	
	private void OnGallerySwipeInertiaFinished(object sender, RadRoutedEventArgs e)
	{
		e.Handled = true;
	}
{{endregion}}
	
#### __[VB.NET] Example 4: Event handlers implementation__
{{region touchmanager-getting-started-6}}
	Private Sub OnGallerySwipeStarted(sender As Object, args As TouchEventArgs)
		args.Handled = True
	End Sub
	
	Private Sub OnGallerySwipeFinished(sender As Object, args As TouchEventArgs)
		args.Handled = True
	End Sub

	Private Sub OnGallerySwipeInertiaStarted(sender As Object, e As RadRoutedEventArgs)
		e.Handled = True
	End Sub
	
	Private Sub OnGallerySwipeInertiaFinished(sender As Object, e As RadRoutedEventArgs)
		e.Handled = True
	End Sub
{{endregion}}
	
> The __SwipeInertia__ event won't be fired unless the __SwipeInertiaStarted__ is handled.
> `args.Handled=true`

Now when you swipe horizontally through the gallery, the images will scroll.

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF TouchManager Component](https://www.telerik.com/products/wpf/touch-manager.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also
* [Overview]({%slug touchmanager-overview%})
* [Events]({%slug touchmanager-events%})
* [Features]({%slug touchmanager-features%})
