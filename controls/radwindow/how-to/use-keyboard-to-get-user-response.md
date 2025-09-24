---
title: Use Keyboard to Get User Response
page_title: Use Keyboard to Get User Response
description: Check our &quot;Use Keyboard to Get User Response&quot; documentation article for the RadWindow {{ site.framework_name }} control.
slug: radwindow-how-to-use-keyboard-to-get-user-response
tags: use,keyboard,to,get,user,response
published: True
position: 0
---

# Use Keyboard to Get User Response

When you have an application that uses __RadWindow__ to get user response, it's common to alleviate the user experience by giving the user a chance to use the keyboard. For example, it's natural to accept response button by clicking the keyboard __Enter__ button, and respectively to cancel response by pressing the __ESC__ button. __RadWindow__ addresses this issue by the __ResponseButton__ attached property.

__ResponseButton__ is an attached property that specifies the behavior of the default buttons part of __RadWindow__ upon keystrokes.

* __Accept__ - Setting this value to any button part of the __RadWindow__ will invoke the button's __Click__ event whenever __Enter__ is pressed.

* __Cancel__ - Setting this value to any button part of the __RadWindow__ will invoke the button's __Click__ event whenever __ESC__ is pressed.

Here is an example of how to create a window that responds to __Enter__ and __ESC__ keyboard strokes. The example uses the RadWindow as a user control:

>tipTo learn more about how to use the __RadWindow__ as user control read [this topic]({%slug radwindow-how-to-use-radwindow-as-user-control%}).



```XAML
	<telerik:RadWindow x:Class="RadWindowSamples.RadWindowControl"
	                   xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	                   xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	                   xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	    <Grid>
	        <Grid.RowDefinitions>
	            <RowDefinition Height="100" />
	            <RowDefinition Height="*" />
	        </Grid.RowDefinitions>
	        <Rectangle Grid.Row="0"
	                   Fill="LemonChiffon"
	                   Width="100"
	                   Height="100" />
	        <StackPanel Grid.Row="1"
	                    Orientation="Horizontal">
	            <Button Click="OnButtonAcceptClicked"
	                    Content="Accept"
	                    telerik:RadWindow.ResponseButton="Accept" />
	            <Button Click="OnButtonCancelClicked"
	                    Content="Cancel"
	                    telerik:RadWindow.ResponseButton="Cancel" />
	        </StackPanel>
	    </Grid>
	</telerik:RadWindow>
```



```C#
	private void OnButtonAcceptClicked(object sender, RoutedEventArgs e)
	{
	    this.DialogResult = true;
	    this.Close();
	}
	private void OnButtonCancelClicked(object sender, RoutedEventArgs e)
	{
	    this.DialogResult = false;
	    this.Close();
	}
```



```VB.NET
	Private Sub OnButtonAcceptClicked(sender As Object, e As RoutedEventArgs)
	    Me.DialogResult = True
	    Me.Close()
	End Sub
	Private Sub OnButtonCancelClicked(sender As Object, e As RoutedEventArgs)
	    Me.DialogResult = False
	    Me.Close()
	End Sub
```

## See Also

 * [End-User Capabilities]({%slug radwindow-end-user-capabilities%})

 * [Working with RadWindow]({%slug radwindow-features-working-with-radwindow%})

 * [RadWindowManager]({%slug radwindow-features-radiwindowmanager%})
