---
title: Retrieve the Clicked Item When Opening a RadContextMenu
description: This article shows how to retrieve the clicked item when opening the RadContextMenu
page_title: Retrieve the Item That is Clicked on When a RadContextMenu is Opened
type: troubleshooting
slug: kb-contextmenu-retrieve-clicked-item-when-opening
position: 0
tags: 
ticketid: 1613605
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2023.3.1114</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadContextMenu for WPF</td>
	</tr>
</table>

## Description

Retrieve the clicked item when the RadContextMenu is opened.

## Solution

You can derive from the `RadContextMenu` class and add an additional dependency property.

__Deriving from the RadContextMenu class and adding an additional dependency property__
```C#
	public class ExtendedContextMenu : RadContextMenu
	{
	    public static readonly DependencyProperty ClickedItemProperty =
	        DependencyProperty.Register("ClickedItem", typeof(FrameworkElement), typeof(ExtendedContextMenu), new PropertyMetadata(null));

	    public FrameworkElement ClickedItem
	    {
	        get { return (FrameworkElement)GetValue(ClickedItemProperty); }
	        set { SetValue(ClickedItemProperty, value); }
	    }
	}
```
```VB.NET
	Public Class ExtendedContextMenu
	    Inherits RadContextMenu

	    Public Shared ReadOnly ClickedItemProperty As DependencyProperty = DependencyProperty.Register("ClickedItem", GetType(FrameworkElement), GetType(ExtendedContextMenu), New PropertyMetadata(Nothing))

	    Public Property ClickedItem As FrameworkElement
	        Get
	            Return CType(GetValue(ClickedItemProperty), FrameworkElement)
	        End Get
	        Set(ByVal value As FrameworkElement)
	            SetValue(ClickedItemProperty, value)
	        End Set
	    End Property
	End Class
```

To assign a value to the dependency property, override the `OnOpened` method and call the `GetClickedElement` method. This method will allow you to retrieve the first element of the given type at the click point coordinates. 

In the following example, the custom RadContextMenu is used in the `RadTreeListView` control and a reference to the clicked `TreeListViewRow` instance is retrieved in the OnOpened method.

__Retrieving the clicked TreeListViewRow instance inside the OnOpened method of the custom RadContextMenu__
```C#
	public class ExtendedContextMenu : RadContextMenu
	{
	    public static readonly DependencyProperty ClickedItemProperty =
	        DependencyProperty.Register("ClickedItem", typeof(FrameworkElement), typeof(ExtendedContextMenu), new PropertyMetadata(null));
	
	    public FrameworkElement ClickedItem
	    {
	        get { return (FrameworkElement)GetValue(ClickedItemProperty); }
	        set { SetValue(ClickedItemProperty, value); }
	    }
	
	    protected override void OnOpened(RadRoutedEventArgs e)
	    {
	        base.OnOpened(e);
	
	        this.ClickedItem = null;
	        this.ClickedItem = this.GetClickedElement<TreeListViewRow>();
	    }
	}
```
```VB.NET
	Public Class ExtendedContextMenu
	    Inherits RadContextMenu

	    Public Shared ReadOnly ClickedItemProperty As DependencyProperty = DependencyProperty.Register("ClickedItem", GetType(FrameworkElement), GetType(ExtendedContextMenu), New PropertyMetadata(Nothing))

	    Public Property ClickedItem As FrameworkElement
	        Get
	            Return CType(GetValue(ClickedItemProperty), FrameworkElement)
	        End Get
	        Set(ByVal value As FrameworkElement)
	            SetValue(ClickedItemProperty, value)
	        End Set
	    End Property

	    Protected Overrides Sub OnOpened(ByVal e As RadRoutedEventArgs)
	        MyBase.OnOpened(e)
	        Me.ClickedItem = Nothing
	        Me.ClickedItem = Me.GetClickedElement(Of TreeListViewRow)()
	    End Sub
	End Class
```