---
title: Events
page_title: Events
description: This article lists and explains the events exposed by the RadCallout control.
slug: radcallout-events
tags: radcallout, events
published: True
position: 3
---

# Events

This article lists the events of the RadCallout control when placed inside a Popup. Subscribing to the events of the control can be achieved through the __CalloutPopupService__ class. The service exposes several methods to add/remove event handlers for the RadCallout control events. 

> The following events are related only for the placement target element.

## Subscribe to RadCallout Events in XAML

You can subscribe to the placement target element events of the Popup holding the RadCallout, using the CalloutPopupService.

#### __[C#] Example 1: Add event handler to PopupOpening in XAML__
		{{region xaml-radcallout-events_0}}			
			<telerik:RadButton x:Name="myPlacementTargetElement" telerik:CalloutPopupService.PopupOpening="OnPopupOpening" Content="My Button"  />
		{{endregion}}

## Subscribe to RadCallout Events in Code Behind

* **PopupOpening**: Occurs before the RadCallout is shown. Through the __CancelRoutedEventArgs__, you can access the following property:

	* **Cancel**: A boolean property that can be used to cancel the control from appearing. 

	#### __[C#] Example 2: Add event handler to PopupOpening__
		{{region cs-radcallout-events_1}}			
			public MainWindow()
			{
				InitializeComponent();
				CalloutPopupService.AddPopupOpeningHandler(myPlacementTargetElement, OnPopupOpening);
			}						
			private void OnPopupOpening(object sender, CancelRoutedEventArgs e)
			{						
			}
		{{endregion}}

* **PopupOpened**: Occurs after the RadCallout is shown.

	#### __[C#] Example 3: Add event handler to PopupOpened__
		{{region cs-radcallout-events_2}}
			public MainWindow()
			{
				InitializeComponent();
				CalloutPopupService.AddPopupOpenedHandler(myPlacementTargetElement, OnPopupOpened);
			}
			private void OnPopupOpened(object sender, RoutedEventArgs e)
			{						
			}
		{{endregion}}
		
* **PopupClosing**: Occurs before the RadCallout is closed. Through the __CancelRoutedEventArgs__, you can access the following property:

	* **Cancel**: A boolean property that can be used to cancel the RadCallout control from closing. 

	#### __[C#] Example 4: Add event handler to PopupClosing__
		{{region cs-radcallout-events_3}}
			public MainWindow()
			{
				InitializeComponent();
				CalloutPopupService.AddPopupClosingHandler(myPlacementTargetElement, OnPopupClosing);
			}
			private void OnPopupClosing(object sender, CancelRoutedEventArgs e)
			{						
			}
		{{endregion}}

* **PopupClosed**: Occurs after the RadCallout is closed.

	#### __[C#] Example 5: Add event handler to PopupClosed__
		{{region cs-radcallout-events_4}}
			public MainWindow()
			{
				InitializeComponent();
				CalloutPopupService.AddPopupClosedHandler(myPlacementTargetElement, OnPopupClosed);
			}
			private void OnPopupClosed(object sender, RoutedEventArgs e)
			{						
			}
		{{endregion}}
		
## Unsubscribe from RadCallout Events

The __CalloutPopupService__ class expose several methods to remove the events handlers.

#### __[C#] Example 6: Remove event handlers__
	{{region cs-radcallout-events_5}}
		public MainWindow()
		{
			InitializeComponent();
			CalloutPopupService.RemovePopupOpeningHandler(myPlacementTargetElement, OnPopupOpening);
			CalloutPopupService.RemovePopupOpenedHandler(myPlacementTargetElement, OnPopupOpened);
			CalloutPopupService.RemovePopupClosingHandler(myPlacementTargetElement, OnPopupClosing);				
			CalloutPopupService.RemovePopupClosedHandler(myPlacementTargetElement, OnPopupClosed);
		}			
	{{endregion}}

## See Also

* [Getting Started]({%slug radcallout-getting-started%})
* [Key Properties]({%slug radcallout-key-properties%})
* [Animations]({%slug radcallout-features-animations%})
