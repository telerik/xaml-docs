---
title: Copying
page_title: Copying
description: Copying
slug: gridview-copying
tags: copying
published: True
position: 1
---

# Copying

This article will give you a basic understanding on how to use:

* [ClipboardCopyMode](#cliboardcopymode)

* [Copying Events](#events)

## CliboardCopyMode

Copying to the Clipboard is controlled by the __ClipboardCopyMode__ property on __RadGridView__. It is a Flags Enumeration of type {% if site.site_name == 'Silverlight' %}[GridViewClipboardCopyMode](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_gridviewclipboardcopymode.html){% endif %}{% if site.site_name == 'WPF' %}[GridViewClipboardCopyMode](http://www.telerik.com/help/wpf/t_telerik_windows_controls_gridviewclipboardcopymode.html){% endif %}.

Here's a list of all the available values:

* **None:** Copying is disabled.
* **Cells:** Copy grid cells.
* **Header:** Copy grid header.
* **Footer:** Copy grid footer.
* **SkipEmptyRows:** Will not copy rows with values that are all null or empty. (introduced with Q1 2016)
* **All:** Copy cells, header and footer.

>The default value is **Cells**.

Here is an example on how to copy column headers as well as selected data:

#### __[C#] Example 1: Setting the ClipboardCopyMode__

{{region cs-gridview-copying_0}}
	this.radGridView.ClipboardCopyMode = GridViewClipboardCopyMode.Cells |
	GridViewClipboardCopyMode.Header;
{{endregion}}

#### __[VB.NET] Example 1: Setting the ClipboardCopyMode__

{{region vb-gridview-copying_1}}
	Me.radGridView.ClipboardCopyMode = GridViewClipboardCopyMode.Cells Or GridViewClipboardCopyMode.Header
{{endregion}}

## Events

There are two events that allow you to control the copying operation: __Copying__ and __CopyingCellClipboardContent.__ The first allows you to cancel a copying operation, whereas the second event allows you to cancel copying for a single cell or override the value to be copied to the Clipboard. The latter is especially useful if you have columns with custom cell templates and you would like to be able to place their values in the clipboard. Here is an example of how you can accomplish that:

#### __[C#] Example 2: The CopyingCellClipboardContent Event__

{{region cs-gridview-copying_2}}
	private void radGridView_CopyingCellClipboardContent(object sender, GridViewCellClipboardEventArgs e)
	{
	    if (e.Cell.Column.UniqueName == "FullName")
	    {
	        var person = e.Cell.Item as Person;
	        e.Value = string.Format("{0} {1} {2}", person.FirstName, person.MiddleName, person.LastName);
	    }
	}
{{endregion}}

#### __[VB.NET] Example 2: The CopyingCellClipboardContent Event__

{{region vb-gridview-copying_3}}
	Private Sub radGridView_CopyingCellClipboardContent(sender As Object, e As GridViewCellClipboardEventArgs)
	    If e.Cell.Column.UniqueName = "FullName" Then
	        Dim person = TryCast(e.Cell.Item, Person)
	        e.Value = String.Format("{0} {1} {2}", person.FirstName, person.MiddleName, person.LastName)
	    End If
	End Sub
{{endregion}}

>For some interesting examples, like how to skip copying of GridViewSelectColumn and GridViewToggleRowDetailsColumn, please check our [SDK example browser](https://demos.telerik.com/xaml-sdkbrowser/).

## See also

* [Pasting]({%slug gridview-pasting%})