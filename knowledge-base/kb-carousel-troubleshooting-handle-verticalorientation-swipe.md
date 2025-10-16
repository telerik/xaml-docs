---
title: Handle Animation Swipe Direction When RadCarouselPanel is Vertical Orientated 
description: Swipe animation respect horizontal orientated RadCarouselPanel.
type: troubleshooting
page_title: Vertical Swipe Animation is Always in The Same Direction
slug: kb-carousel-troubleshooting-handle-verticalorientation-swipe
position: 0
tags: carousel, swipe, vertical, orientation
ticketid: 1452565
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.1.115</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadCarousel for WPF</td>
		</tr>
	</tbody>
</table>


## Description
By default, the orientation of the RadCarouselPanel is horizontal. When the RadCarouselPanel is set in vertical mode, the swipe animation does not work correctly. The build-in swiping logic only checks the horizontal offset of the swipe, which occurs. 

## Solution

You can override this logic in order for the panel to work as expected when its orientation is vertical. To do so and affect all panels in your application, you can create an attached behavior in which to handle the various swiping events.


```C#
	public class VerticalSwipeBehavior
	{
		private RadCarouselPanel carouselPanel;
		private double swipeOffset;

		public static bool GetIsEnabled(DependencyObject obj)
		{
			return (bool)obj.GetValue(IsEnabledProperty);
		}

		public static void SetIsEnabled(DependencyObject obj, bool value)
		{
			obj.SetValue(IsEnabledProperty, value);
		}

		// Using a DependencyProperty as the backing store for IsEnabled.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty IsEnabledProperty =
			DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(VerticalSwipeBehavior), new PropertyMetadata(false, OnIsEnabledChanged));

		private static void OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var panel = d as RadCarouselPanel;

			if (panel != null && (bool)e.NewValue)
			{
				var behavior = new VerticalSwipeBehavior();

				behavior.Attach(panel);
			}
		}

		public void Attach(RadCarouselPanel panel)
		{
			this.carouselPanel = panel;
			TouchManager.AddSwipeStartedEventHandler(this.carouselPanel, OnSwipeStarted);
			TouchManager.AddSwipeEventHandler(this.carouselPanel, OnSwipe);
			TouchManager.AddSwipeFinishedEventHandler(this.carouselPanel, OnSwipeFinished);
		}

		private void OnSwipeStarted(object sender, Telerik.Windows.Input.Touch.TouchEventArgs args)
		{
			args.Handled = true;
		}

		private void OnSwipe(object sender, SwipeEventArgs args)
		{
			args.Handled = true;

			this.swipeOffset += args.VerticalChange;

		}

		private void OnSwipeFinished(object sender, Telerik.Windows.Input.Touch.TouchEventArgs args)
		{
			args.Handled = true;

			if (this.swipeOffset > 0)
			{
				this.carouselPanel.MoveBy(this.carouselPanel.ItemsPerSwipe);
			}
			else
			{
				this.carouselPanel.MoveBy(-this.carouselPanel.ItemsPerSwipe);
			}

			this.swipeOffset = 0;
		}
	}
```

We can create implicit style to target all RadCarouselPanel's.


```XAML
	<Style  TargetType="telerik:RadCarouselPanel">           
		<Setter Property="local:VerticalSwipeBehavior.IsEnabled" Value="true" />
	</Style>
```


