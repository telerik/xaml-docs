---
title: Set StaysOpen Property to False of Parent Popup of FilteringControl
description: How to set StaysOpen property of FilteringControl's parent Popup to False.
page_title: Set FilteringControl Parent Popup StaysOpen Property
type: how-to
slug: kb-virtualgrid-filteringcontrol-parent-popup-staysopen
position: 0
tags: virtualgrid, filteringcontrol, parent, popup, staysopen
ticketid: 1617868
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2023.2.606</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadVirtualGrid for WPF</td>
	</tr>
</table>

## Description

How to set the StaysOpen property of the RadVirtualGrid FilteringControl's parent Popup element.

## Solution

To achieve this requirement,  utilize the `EventManager.RegisterClassHandler` method to subscribe to the `Loaded` event of each `FilteringControl` instance:

__Subscribing to Loaded event of FilteringControl__
```C#
    public partial class MainWindow : Window
    {
        static MainWindow()
        {
            EventManager.RegisterClassHandler(typeof(FilteringControl), LoadedEvent, new RoutedEventHandler (OnLoaded));
        }
    }
```
```VB.NET
    Public Partial Class MainWindow
        Inherits Window

        Private Shared Sub New()
            EventManager.RegisterClassHandler(GetType(FilteringControl), LoadedEvent, New RoutedEventHandler(OnLoaded))
        End Sub
    End Class
```

In the added event handler, retrieve the parent `Popup` element of the FilteringControl instance using the [ParentOfType]({%slug common-visual-tree-helpers%}#parentoftypeextensions) extension method. Then, set its `StaysOpen` property to __False__.

__Set the StaysOpen property of the parent Popup__
```C#
public partial class MainWindow : Window
    {
        static MainWindow()
        {
            EventManager.RegisterClassHandler(typeof(FilteringControl), LoadedEvent, new    RoutedEventHandler(OnLoaded));
        }

        private static void OnLoaded(object sender, RoutedEventArgs e)
        {
            FilteringControl filteringControl = (FilteringControl)sender;

            Popup popup = filteringControl.ParentOfType<Popup>();

            if (popup != null)
            {
                popup.StaysOpen = false;
            }
        }
    }
```
```VB.NET
    Public Partial Class MainWindow
        Inherits Window
    
        Private Shared Sub New()
            EventManager.RegisterClassHandler(GetType(FilteringControl), LoadedEvent, New   RoutedEventHandler(AddressOf OnLoaded))
        End Sub
    
        Private Shared Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim filteringControl As FilteringControl = CType(sender, FilteringControl)
            Dim popup As Popup = filteringControl.ParentOfType(Of Popup)()
    
            If popup IsNot Nothing Then
                popup.StaysOpen = False
            End If
        End Sub
    End Class
```