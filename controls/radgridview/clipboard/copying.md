---
title: Copying
page_title: Copying
description: Check out an example on how to copy column headers as well as selected data in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-copying
tags: copying
published: True
position: 1
---

# Copying

This article will give you a basic understanding on how to use:

* [ClipboardCopyMode](#clipboardcopymode)

* [Copying Events](#events)

## ClipboardCopyMode

Copying to the Clipboard is controlled by the __ClipboardCopyMode__ property on __RadGridView__. It is a Flags Enumeration of type {% if site.site_name == 'Silverlight' %}[GridViewClipboardCopyMode](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_gridviewclipboardcopymode.html){% endif %}{% if site.site_name == 'WPF' %}[GridViewClipboardCopyMode](http://www.telerik.com/help/wpf/t_telerik_windows_controls_gridviewclipboardcopymode.html){% endif %}.

Here's a list of all the available values:

* **None:** Copying is disabled.
* **Cells:** Copy grid cells.
* **Header:** Copy grid header.
* **Footer:** Copy grid footer.
* **SkipEmptyRows:** Will not copy rows with values that are all null or empty. (introduced with __Q1 2016__)
* **SkipEmptyColumns:** Will not copy columns with values that are null or empty. (introduced as of __R3 2017 SP1__) 
* **All:** Copy cells, header and footer.

>The default value is **Cells**.

Here is an example on how to copy column headers as well as selected data:

__Example 1: Setting the ClipboardCopyMode in code__

```C#
	this.radGridView.ClipboardCopyMode = GridViewClipboardCopyMode.Cells |
	GridViewClipboardCopyMode.Header;
```
```VB.NET
	Me.radGridView.ClipboardCopyMode = GridViewClipboardCopyMode.Cells Or GridViewClipboardCopyMode.Header
```

__Example 2: Setting the ClipboardCopyMode in xaml__

```XAML
	<telerik:RadGridView ClipboardCopyMode="Cells, Header" />
```

## Events

> With the initial implementation, the __CopyingCellClipboardContent__ will be thrown for the cells only. As of the 2017.3.1023 latest internal build and with the __R1 2018__ official version, the event will be thrown for the header and footer cells as well.

There are two events that allow you to control the copying operation: __Copying__ and __CopyingCellClipboardContent.__ The first allows you to cancel a copying operation, whereas the second event allows you to cancel copying for a single cell or override the value to be copied to the Clipboard. The latter is especially useful if you have columns with custom cell templates and you would like to be able to place their values in the clipboard. Here is an example of how you can accomplish that:

__Example 3: The CopyingCellClipboardContent Event__

```C#
	private void radGridView_CopyingCellClipboardContent(object sender, GridViewCellClipboardEventArgs e)
	{
	    if (e.Cell.Column.UniqueName == "FullName")
	    {
	        var person = e.Cell.Item as Person;
	        e.Value = string.Format("{0} {1} {2}", person.FirstName, person.MiddleName, person.LastName);
	    }
	}
```
```VB.NET
	Private Sub radGridView_CopyingCellClipboardContent(sender As Object, e As GridViewCellClipboardEventArgs)
	    If e.Cell.Column.UniqueName = "FullName" Then
	        Dim person = TryCast(e.Cell.Item, Person)
	        e.Value = String.Format("{0} {1} {2}", person.FirstName, person.MiddleName, person.LastName)
	    End If
	End Sub
```

>For some interesting examples, like how to skip copying of GridViewSelectColumn and GridViewToggleRowDetailsColumn, please check our [SDK example browser](https://demos.telerik.com/xaml-sdkbrowser/).

## See also

* [Pasting]({%slug gridview-pasting%})
