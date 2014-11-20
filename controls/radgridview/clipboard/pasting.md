---
title: Pasting
page_title: Pasting
description: Pasting
slug: gridview-pasting
tags: pasting
published: True
position: 2
---

# Pasting

Pasting is controlled similarly to [Copying]({%slug gridview-copying%}). The __ClipboardPasteMode__ property on __RadGridView__, also a flags enumeration of type 
  {% if site.site_name == 'Silverlight' %}[GridViewClipboardPasteMode](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_gridviewclipboardpastemode.html){% endif %}{% if site.site_name == 'WPF' %}[GridViewClipboardPasteMode](http://www.telerik.com/help/wpf/t_telerik_windows_controls_gridviewclipboardpastemode.html){% endif %}, dictates how pasting is performed. The values __None__, __Cells__, __SkipFirstLine__ and __SkipLastLine__ are counterparts of 
  {% if site.site_name == 'Silverlight' %}[GridViewClipboardCopyMode](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_gridviewclipboardpastemode.html){% endif %}{% if site.site_name == 'WPF' %}[GridViewClipboardCopyMode](http://www.telerik.com/help/wpf/t_telerik_windows_controls_gridviewclipboardcopymode.html){% endif %}’s __None__, __Cells__, __Header__ and __Footer__, respectively. There are few more values which are of interest:

* __OverwriteWithEmptyValues__ – If the data you are pasting from the Clipboard contains empty cells, the respective cells in the receiving __RadGridView__ will be cleared.
            

* __SkipHiddenColumns__ - if a column is hidden, you will still paste in its underlying property unless this flag is on. Added in Q2 2010 SP1.
            

* __AllSelectedCells__ - if pasting only one cell's value from the Clipboard, RadGridView will try to paste it to each selected cell.
            

* __AllSelectedRows__ - if pasting one or more items from the Clipboard, RadGridView will try to paste it to each selected row.
            

* __InsertNewRows__ - if pasting one or more items from the Clipboard, RadGridView will try to create new row for them.
            

>The default mode is pasting into __Cells__.
          

The __Pasting__ event allows you to cancel a paste operation, whereas the __PastingCellClipboardContent__ allows you to cancel pasting for the cell or replace the Clipboard value with your own. Example:
         

#### __C#__

{{region gridview-pasting_0}}
	
	private void radGridView1_Pasting(object sender, GridViewClipboardEventArgs e)
	{
	    e.Cancel = true;
	}
	
	private void radGridView1_PastingCellClipboardContent(object sender, GridViewCellClipboardEventArgs e)
	{
	   if (e.Cell.Column.UniqueName == "Company")
	   {
	      var companyName = e.Value.ToString();
	      var company = this.EFContext.Companies.Where(c => c.Name == companyName).FirstOrDefault();
	      if (company != null)
	      {
	          e.Value = company;
	      }
	      else
	      {
	          e.Cancel = true;
	      }
	   }
	}
{{endregion}}

#### __VB.NET__

{{region gridview-pasting_1}}

    Private Sub radGridView1_Pasting(sender As Object, e As GridViewClipboardEventArgs)
        e.Cancel = True
    End Sub
	    
	Private Sub radGridView1_PastingCellClipboardContent(sender As Object, e As GridViewCellClipboardEventArgs)
	 If e.Cell.Column.UniqueName = "Company" Then
	  Dim companyName = e.Value.ToString()
	  Dim company = Me.EFContext.Companies.Where(Function(c) c.Name = companyName).FirstOrDefault()
	  If company IsNot Nothing Then
	   e.Value = company
	  Else
	   e.Cancel = True
	  End If
	 End If
	End Sub
{{endregion}}

As of version Q2 2013:
        

* The user can copy one cell and __paste its value to all the selected cells__ for a column. You should set the __AllSelectedCells__ ClipboardPasteMode together with __SelectionUnit=“Cell”__ for the RadGridView.
            

* The user can copy a row and paste it to __multiple selected rows__. You should set the __AllSelectedRows__ ClipboardPasteMode together with __SelectionUnit=“Row”__ for the RadGridView.
            

* The user can copy more items than the selected rows. When pasting them in the GridView, then __new items will be created__ and the values will be pasted to them. You should set the __InsertNewRows__ ClipboardPasteMode.
            

For an example please check the __GridView/CopyPasteFunctionalities__ example [here](https://github.com/telerik/xaml-sdk/).
        
