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



Copying to the Clipboard is controlled by the __ClipboardCopyMode__ property on __RadGridView__. It is a Flags Enumeration of type {% if site.site_name == 'Silverlight' %}[GridViewClipboardCopyMode](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_gridviewclipboardcopymode.html){% endif %}{% if site.site_name == 'WPF' %}[GridViewClipboardCopyMode](http://www.telerik.com/help/wpf/t_telerik_windows_controls_gridviewclipboardcopymode.html){% endif %}.

In the API Reference you can find a description on what is the functionality each of the copy modes allow.

Here is an example on how to copy column headers as well as selected data:

#### __C#__

{{region gridview-copying_0}}

	this.radGridView.ClipboardCopyMode = GridViewClipboardCopyMode.Cells | 
	GridViewClipboardCopyMode.Header;
{{endregion}}

#### __VB.NET__

{{region gridview-copying_1}}

	Me.radGridView.ClipboardCopyMode = GridViewClipboardCopyMode.Cells Or GridViewClipboardCopyMode.Header
{{endregion}}

There are two events that allow you to control this operation: __Copying__ and __CopyingCellClipboardContent.__ The first allows you to cancel a copying operation, whereas the second event allows you to cancel copying for a single cell or override the value to be copied to the Clipboard. The latter is especially useful if you have columns with custom cell templates and you would like to be able to place their values in the clipboard. Here is an example of how you can accomplish that:

#### __C#__

{{region gridview-copying_2}}

	private void radGridView_CopyingCellClipboardContent(object sender, GridViewCellClipboardEventArgs e)
	{
	     if (e.Cell.Column.UniqueName == "FullName")
	     {
	          var person = e.Cell.Item as Person;
	          e.Value = string.Format("{0} {1} {2}", person.FirstName, person.MiddleName, person.MiddleName);
	     }
	}
{{endregion}}

#### __VB.NET__

{{region gridview-copying_3}}

	Private Sub radGridView_CopyingCellClipboardContent(sender As Object, e As GridViewCellClipboardEventArgs)
	 If e.Cell.Column.UniqueName = "FullName" Then
	  Dim person = TryCast(e.Cell.Item, Person)
	  e.Value = String.Format("{0} {1} {2}", person.FirstName, person.MiddleName, person.MiddleName)
	 End If
	End Sub
{{endregion}}

As of version Q2 2013 you can also:
        

* Copy with headers
          

* Copy with footers (aggregates)
          

* Skip copying GridViewSelectColumn and GridViewToggleRowDetailsColumn. This is supported by implementing an additional code in code-behind. For an example please check the CopyPasteFunctionalities example
[here](https://github.com/telerik/xaml-sdk)>, the example is listed as __GridView/CopyPasteFunctionalities__.
          


