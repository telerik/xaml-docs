---
title: Styling the Predefined Windows
page_title: Styling the Predefined Windows
description: Styling the Predefined Windows
slug: radwindow-styles-and-templates-styling-the-predefined-windows
tags: styling,the,predefined,windows
published: True
position: 3
---

# Styling the Predefined Windows

This topic will explain how you could customize the look and feel of the predefined Windows.

## Modifying the default Style

>To style the predefined dialogs of the __RadWindow__ static class, you have to call them via the overload that takes __DialogParameters__ object as an argument. Learn more about the predefined dialogs [here]({%slug radwindow-features-predefined-dialogs%}).

In the provided in this article example we will use __RadAlert__, but the approach is the same for __RadConfirm__ and __RadPrompt__.

First, you will need to obtain the default style that targets __RadAlert__ - to learn how to do this, take a look at the [Styling the RadWindow]({%slug radwindow-styles-and-templates-styling-the-radwindow%}) topic. The RadAlertStyle will be similar to the following:

#### __XAML__

{{region radwindow-styles-and-templates-styling-the-predefined-windows_0}}
	<Style x:Key="RadAlertStyle" TargetType="telerik:RadAlert">
		<Setter Property="IsTabStop" Value="False"/>
		<Setter Property="MinWidth" Value="275"/>
		<Setter Property="MaxWidth" Value="500"/>
		<Setter Property="SnapsToDevicePixels" Value="True"/>
		<Setter Property="Template">
			<Setter.Value>
				<ControlTemplate TargetType="telerik:RadAlert">
				...
				</ControlTemplate>
			</Setter.Value>    
		</Setter>
	</Style>
{{endregion}}

Now, you could make any modifications in the template, such as removing the OK button, changing the Alert icon, etc.

And finally, you have to pass the customized __RadAlertStyle__ to the predefined dialog via the __DialogParameters__ object and its __ContentStyle__ property.

#### __C#__

{{region radwindow-styles-and-templates-styling-the-predefined-windows_0}}
	DialogParameters parameters = new DialogParameters();
	parameters.ContentStyle = this.Resources["RadAlertStyle"] as Style;
	parameters.Content = "Hello";
	RadWindow.Alert(parameters);
{{endregion}}

#### __VB.NET__

{{region radwindow-styles-and-templates-styling-the-predefined-windows_1}}
	Dim parameters As New DialogParameters()
	parameters.ContentStyle = TryCast(Me.Resources("RadAlertStyle"), Style)
	parameters.Content = "Hello"
	RadWindow.Alert(parameters)
{{endregion}}

__Figure 1__ shows the final result.

Figure 1: RadAlert with custom Style
![](images/RadWindow_Styles_and_Templates_Styling_the_Predefined_Windows_01.png)

## Applying IconTemplate

With the Q1 2016 release version of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} the __IconTemplate__ property was introduced. By using it you are now able to easily change the icon of the predefined windows.  

Basically, a valid DataTemplate needs to be created and that Template should be passed to the predefined windows via the __DialogParameters__ and its __IconTemplate__ property:

#### __XAML__

{{region radwindow-styles-and-templates-styling-the-predefined-windows_0}}
	<DataTemplate x:Key="IconTemplate">
		<Image Source="telerik.png" Stretch="Fill" Width="22" Height="22"/>
	</DataTemplate>
{{endregion}}

#### __C#__

{{region radwindow-styles-and-templates-styling-the-predefined-windows_2}}
	RadWindow.Alert(new DialogParameters()
	{
		Content = "Hello",
		IconTemplate = this.Resources["IconTemplate"] as DataTemplate
	});
{{endregion}}

#### __VB.NET__

{{region radwindow-styles-and-templates-styling-the-predefined-windows_3}}
	RadWindow.Alert(New DialogParameters() With
	{
		.Content = "Hello",
		.IconTemplate = TryCast(Me.Resources("IconTemplate"), DataTemplate
	)})
{{endregion}}

__Figure 2__ shows the final result.

Figure 2: RadAlert with set __IconTemplate__
![](images/RadWindow_Styles_and_Templates_Styling_the_Predefined_Windows_02.png)

# See Also

 * [Template Structure]({%slug radwindow-styles-and-templates-template-structure%})

 * [Styling the RadWindow]({%slug radwindow-styles-and-templates-styling-the-radwindow%})

 * [Change the Default Theme]({%slug radwindow-how-to-change-the-default-theme%})
