---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: touchmanager-getting-started
tags: getting,started,touch,manager,touchmanager
published: True
position: 2
---
<<Comment: For better SEO, the title, description and H1 should all include the word TouchManager.>>
# Getting started

This article demonstrates a simple image gallery implemented with __TouchManager__ and demonstrates the basic usage of the manager.

> TouchManager requires the __Telerik.Windows.Controls__ assembly to be referenced in the project.

First, we can create the UI of the gallery (Example 1). We will use one panel to hold several Image elements that will represent the gallery with the small images (the thumbnails). Then we can add another panel that will display the selected image.
<<Comment: For better SEO, replace "of the example" with "TouchManger example" in the title of Example 1.>>

#### __[XAML] Example 1: Defining the UI of the TouchManager example__
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
	
This is the frame over which we will implement the touch interactions - swipe and tap. 

Here is an image that demonstrates the view:
![Getting Started 01](images/touchmanager_getting_started_01.png)

Let us start by implementing the swipe of the gallery items. We can do that by handling the swipe and swipe inertia events of TouchManager. Example 2 demonstrates how to subscribe to the events:

#### __[C#] Example 2: Subscribing to TouchManager events__
	TouchManager.AddSwipeStartedEventHandler(this.galleryContainer, new TouchEventHandler(OnGallerySwipeStarted));
	TouchManager.AddSwipeEventHandler(this.galleryContainer, new SwipeEventHandler(OnGallerySwipe));
	TouchManager.AddSwipeFinishedEventHandler(this.galleryContainer, new TouchEventHandler(OnGallerySwipeFinished));

	TouchManager.AddSwipeInertiaStartedEventHandler(this.galleryContainer, new RadRoutedEventHandler(OnGallerySwipeInertiaStarted));
	TouchManager.AddSwipeInertiaEventHandler(this.galleryContainer, new SwipeInertiaEventHandler(OnGallerySwipeInertia));
	TouchManager.AddSwipeInertiaFinishedEventHandler(this.galleryContainer, new RadRoutedEventHandler(OnGallerySwipeInertiaFinished));

#### __[VB.NET] Example 2: Subscribing to TouchManager events__
	TouchManager.AddSwipeStartedEventHandler(Me.galleryContainer, New TouchEventHandler(AddressOf OnGallerySwipeStarted))
	TouchManager.AddSwipeEventHandler(Me.galleryContainer, New SwipeEventHandler(AddressOf OnGallerySwipe))
	TouchManager.AddSwipeFinishedEventHandler(Me.galleryContainer, New TouchEventHandler(AddressOf OnGallerySwipeFinished))

	TouchManager.AddSwipeInertiaStartedEventHandler(Me.galleryContainer, New RadRoutedEventHandler(AddressOf OnGallerySwipeInertiaStarted))
	TouchManager.AddSwipeInertiaEventHandler(Me.galleryContainer, New SwipeInertiaEventHandler(AddressOf OnGallerySwipeInertia))
	TouchManager.AddSwipeInertiaFinishedEventHandler(Me.galleryContainer, New RadRoutedEventHandler(AddressOf OnGallerySwipeInertiaFinished))

The logic for the swipe action will be implemented in the Swipe and SwipeInertia event handlers. We can place the implementation in a separate method and use it in the handlers.

#### __[C#] Example 3: Event handlers implementation__
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

#### __[VB.NET] Example 3: Event handlers implementation__
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

Although we are working directly only with the Swipe and SwipeInertia events, we are going to handle the related events for consistency - SwipeStarted, SwipeFinisihed, SwipeInertiaStarted and SwipeInertiaFinished. 

#### __[C#] Example 4: Event handlers implementation__
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
	
#### __[VB.NET] Example 4: Event handlers implementation__
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
	
> The __SwipeInertia__ event won't be fired unless the __SwipeInertiaStarted__ is handled.
> `args.Handled=true`

Now when you swipe horizontally through the gallery, the images will scroll.

## See Also
* [Overview]({%slug touchmanager-overview%})
* [Events]({%slug touchmanager-events%})
* [Features]({%slug touchmanager-features%})
