---
title: Predefined Dialogs
page_title: Predefined Dialogs
description: This article describes the predefined modal dialogs, which can be used in order to alert, prompt or request confirmation from the user. 
slug: radwindow-features-predefined-dialogs
tags: predefined,dialogs
published: True
position: 1
---

# Predefined Dialogs

The __RadWindow__ provides you with a set of predefined dialog windows that are an easy way to handle a few scenarios:

* Alert the user with a certain message

* Prompt the user for certain information

* Allow the user to confirm an action

These windows can be shown using the respective static methods of the __RadWindow__ class:

* __Alert()__ - 3 overloads

* __Confirm()__ - 2 overloads

* __Prompt()__ - 3 overloads

>All of the predefined windows are modal.

Each of the methods has an overload that takes an object of type __DialogParameters__ as an argument. The __DialogParameters__ class has members similar to the specific ones of the __RadWindow__. This allows you to configure the predefined dialogs via the argument of the method.

Here is a list of the __DialogParameters__ class members:

* __CancelButtonContent__

* __Closed__

* __Content__

* __ContentStyle__

* __DefaultPromptResultValue__

* __Header__

* __IconContent__

* __ModalBackground__

* __OkButtonContent__

* __Opened__

* __Owner__

* __Theme__

* __WindowStyle__

{% if site.site_name == 'WPF' %}

* __DefaultFocusedButton__

{% endif %}

For more info about the class read {% if site.site_name == 'Silverlight' %}[here](https://docs.telerik.com/devtools/silverlight/api/telerik.windows.controls.dialogparameters){% endif %}{% if site.site_name == 'WPF' %}[here](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.dialogparameters){% endif %}.

## Alert

The alert dialog window allows you to alert the user with a certain message. It is shown by calling the __Alert()__ method of the static __RadWindow__ class. It can take one of the following argument groups:

* __DialogParameters dialogParameters__ - an object of type __DialogParameters__.

__Example 1: Showing RadAlert with DialogParameters__

```C#
	RadWindow.Alert(new DialogParameters()
	{
		Content = "Hello",
		Closed = this.OnClosed
	});
       

	private void OnClosed(object sender, WindowClosedEventArgs e)
	{
		var result = e.DialogResult;
		if (result == true)
		{
			// handle confirmation
		}
	}
```
```VB.NET
	RadWindow.Alert(New DialogParameters() With {
		.Content = "Hello",
		.Closed = AddressOf Me.OnClosed
	})

	Private Sub OnClosed(sender As Object, e As WindowClosedEventArgs)
	    Dim result = e.DialogResult
		If result = True Then
			' handle confirmation
		End If
	End Sub
```

* __object content__ - an object that represents the content.

__Example 2: Showing RadAlert without DialogParameters__

```C#
	RadWindow.Alert("Hello");
```
```VB.NET
	RadWindow.Alert("Hello")
```

* __object content, EventHandler\<WindowsClosedEventArgs\> closed__ - an object, that represents the content and an event handler that should handle the __Closed__ event of the __RadWindow__.

__Example 3: Handling RadAlert's Closed event__

```C#
	public void ShowAlert()
	{
	    RadWindow.Alert("Hello", this.OnClosed);
	}
	private void OnClosed(object sender, WindowClosedEventArgs e)
	{
	    var result = e.DialogResult;
	    if (result == true)
	    {
	        // handle confirmation
	    }
	}
```
```VB.NET
	Public Sub ShowAlert()
	    RadWindow.Alert("Hello", AddressOf Me.OnClosed)
	End Sub
	Private Sub OnClosed(sender As Object, e As WindowClosedEventArgs)
	    Dim result = e.DialogResult
		If result = True Then
			' handle confirmation
		End If
	End Sub
```

![RadAlert](images/RadWindow_Features_Predefined_Windows_01.png)

>The **DialogResult** of the WindowClosedEventArgs will be **True** if the user has pressed **OK** and **null** if the user clicked the **close button** of the window. The **PromptResult** property will always be **null**.

## Confirm 

The confirm dialog window allows the user to confirm an action. It is shown by calling the __Confirm()__ method of the static __RadWindow__ class. It can take one of the following argument groups:

* __DialogParameters dialogParameters__ - an object of type __DialogParameters__.

__Example 4: Showing RadConfirm__

```C#
	RadWindow.Confirm(new DialogParameters()
	{
		Content = "Are you sure ?",
		Closed = this.OnClosed
	});

	private void OnClosed(object sender, WindowClosedEventArgs e)
	{
		var result = e.DialogResult;
		if (result == true)
		{
			// handle confirmation
		}
	}
```
```VB.NET
	RadWindow.Confirm(New DialogParameters() With {
		.Content = "Are you sure ?",
		.Closed = AddressOf Me.OnClosed
	})

	Private Sub OnClosed(sender As Object, e As WindowClosedEventArgs)
	    Dim result = e.DialogResult
		If result = True Then
			' handle confirmation
		End If
	End Sub
```

* __object content, EventHandler\<WindowsClosedEventArgs\> closed__ - an object that represents the content and an event handler that should handle the __Closed__ event of the __RadWindow__.

__Example 5: Handling RadConfirm's Closed event__

```C#
	public void ShowConfirm()
	{
	    RadWindow.Confirm("Are you sure?", this.OnClosed);
	}
	private void OnClosed(object sender, WindowClosedEventArgs e)
	{
	    var result = e.DialogResult;
	    if (result == true)
	    {
	        // handle confirmation
	    }
	}
```
```VB.NET
	Public Sub ShowConfirm()
	    RadWindow.Confirm("Are you sure?", AddressOf Me.OnClosed)
	End Sub
	Private Sub OnClosed(sender As Object, e As WindowClosedEventArgs)
	    Dim result = e.DialogResult
		If result = True Then
			' handle confirmation
		End If
	End Sub
```

![RadConfirm](images/RadWindow_Features_Predefined_Windows_03.png)

>The **DialogResult** of the WindowClosedEventArgs will be **True** if the user has pressed **OK**, **False** if the user clicked **Cancel** and **null** if the user clicked the **close button** of the window. The **PromptResult** property will always be **null**.

## Prompt

The prompt dialog window allows the user to input information. It is shown by calling the __Prompt()__ method of the static __RadWindow__ class. It can take one of the following argument groups:

* __DialogParameters dialogParameters__ - an object of type __DialogParameters__.

__Example 6: Showing RadPrompt__

```C#
	RadWindow.Prompt(new DialogParameters()
	{
		Content = "Enter your name:",
		Closed = this.OnClosed
	});

	private void OnClosed(object sender, WindowClosedEventArgs e) 
	{ 
		var result = e.PromptResult; 
		var message = "Hello " + result + "!"; 
	} 
```
```VB.NET
	RadWindow.Prompt(New DialogParameters() With {
		.Content = "Enter your name:",
		.Closed = AddressOf Me.OnClosed
	})

	Private Sub OnClosed(sender As Object, e As WindowClosedEventArgs)
		Dim result = e.PromptResult
		Dim message = "Hello " & result & "!"
	End Sub
```

* __object content, EventHandler\<WindowsClosedEventArgs\> closed__ - an object that represents the content and an event handler that should handle the __Closed__ event of the __RadWindow__.

__Example 7: Handling RadPrompt's Closed event__

```C#
	public void ShowPrompt()
	{
	    RadWindow.Prompt("Enter your name:", this.OnClosed);
	}
	private void OnClosed(object sender, WindowClosedEventArgs e)
	{
	    var result = e.PromptResult;
	    var message = "Hello " + result + "!";
	}
```
```VB.NET
	Public Sub ShowPrompt()
	    RadWindow.Prompt("Enter your name:", AddressOf Me.OnClosed)
	End Sub
	Private Sub OnClosed(sender As Object, e As WindowClosedEventArgs)
		Dim result = e.PromptResult
		Dim message = "Hello " & result & "!"
	End Sub
```

* __object content, EventHandler\<WindowsClosedEventArgs\> closed, string defaultPropmptResult__ - an object that represents the content, an event handler that should handle the __Closed__ event of the __RadWindow__ and a default result value.

__Example 8: Showing RadPrompt with a default result__

```C#
	public void ShowPrompt()
	{
	    RadWindow.Prompt("Enter your name:", this.OnClosed, "John Doe");
	}
	private void OnClosed(object sender, WindowClosedEventArgs e)
	{
	    var result = e.PromptResult;
	    var message = "Hello " + result + "!";
	}
```
```VB.NET
	Public Sub ShowPrompt()
	    RadWindow.Prompt("Enter your name:", AddressOf Me.OnClosed, "John Doe")
	End Sub
	Private Sub OnClosed(sender As Object, e As WindowClosedEventArgs)
		Dim result = e.PromptResult
		Dim message = "Hello " & result & "!"
	End Sub
```

>The **DialogResult** of the WindowClosedEventArgs will be **True** if the user has pressed **OK**, **False** if the user clicked **Cancel** and **null** if the user clicked the **close button** of the window. The **PromptResult** property will hold the value entered by the user if they clicked **OK** and **null** otherwise.

![RadPrompt](images/RadWindow_Features_Predefined_Windows_02.png)

## Styling the Predefined Windows

If you want to change the appearance of the predefined window, you have to show it by calling the overload that takes a __DialogParameters__ object as an argument. Create an appropriate style and set it to its __WindowStyle__ property. To learn more read [here]({%slug radwindow-styles-and-templates-styling-the-predefined-windows%}).

{% if site.site_name == 'WPF' %}

## Setting the Default Focused Button

Since the __2019.1.415__ internal build version and the __R2 2019__ official release, the DialogParameters expose a __DefaultFocusedButton__ property. It allows you to set the button that will be focused by default when the modal window is shown. This property is of type [ResponseButton](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.responsebutton).

__Example 9: Setting the default focused button of a RadConfirm to Cancel__

```C#
    DialogParameters parameters = new DialogParameters();
	parameters.Content = "Are you sure?";
	parameters.DefaultFocusedButton = ResponseButton.Cancel;
	RadWindow.Confirm(parameters);
```
```VB.NET
	Dim parameters As New DialogParameters()
	parameters.Content = "Are you sure?"
	parameters.DefaultFocusedButton = ResponseButton.Cancel
	RadWindow.Confirm(parameters)
```

{% endif %}

## See Also

 * [Working with RadWindow]({%slug radwindow-features-working-with-radwindow%})

 * [Styling the Predefined Windows]({%slug radwindow-styles-and-templates-styling-the-predefined-windows%})

 * [RadWindowManager]({%slug radwindow-features-radiwindowmanager%})