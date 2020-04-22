---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadCallout {{ site.framework_name }} control.
slug: radcallout-getting-started
tags: getting,started
published: True
position: 2
---


# Getting Started

This tutorial will walk you through the creation of a sample application that contains a RadCallout control.

## Assembly References

To use RadCallout, you will need to add references to the following assemblies:

* __Telerik.Windows.Controls__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Defining RadCallout in XAML

The control can be used as a static element to highlight an element from your application. This gives you the freedom to place the control in any type of parent.

#### __[XAML] Example 1: Defining in XAML__
{{region xaml-radcallout-getting-started-0}}
    <Grid>
		<telerik:RadButton Content="My Button" VerticalAlignment="Center" HorizontalAlignment="Center" />
		<telerik:RadCallout Margin="0 0 0 100" Content="Click on the button" />
	</Grid>
{{endregion}}

## Defining as a Popup

The control can be placed inside a Popup element. This way, you can dynamically show/hide the control per your needs. For the purpose of this tutorial, we are going to show the RadCallout on a button click. First, we need to define our RadButton control and subscribe to its __Click__ event.

#### __[XAML] Example 2: Defining RadButton__
{{region xaml-radcallout-getting-started-0}}
    <Grid>        
		<telerik:RadButton Content="My Button" VerticalAlignment="Center" HorizontalAlignment="Center" Click="RadButton_Click" />
	</Grid>
{{endregion}}

In the click event handler, we can declare our RadCallout control. To show the control, we need to use the CalloutPopupService.Show() static method. The third parameter (not required) of this method accepts CalloutPopupSettings object. You can use these settings, for example, to change the position of the control, add animation, etc.

#### __[C#] Example 3: Setting RadCallout in code behind__
{{region csharp-radcallout-getting-started-1}}
    private void RadButton_Click(object sender, RoutedEventArgs e)
	{
		RadCallout callout = new RadCallout() { Background = Brushes.DeepSkyBlue, Content = "My Callout" };

		CalloutPopupSettings settings = new CalloutPopupSettings()
		{
			Placement = System.Windows.Controls.Primitives.PlacementMode.Top,
		};

		CalloutPopupService.Show(callout, sender as FrameworkElement, settings);
	}
{{endregion}}

If you run the application now, you should see the RadCallout control on top of the button when you click it like in __Figure 1__:

#### Figure 1: RadCallout sample
![Telerik Callout Getting-Started 0](images/callout_getting_started_1.png)

## See Also

* [Animations]({%slug radcallout-features-animations%})
* [CalloutPopupSettings]({%slug radcallout-features-calloutpopupsettings%})
