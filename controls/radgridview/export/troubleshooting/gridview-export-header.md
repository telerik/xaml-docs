---
title: Export Custom Header
page_title: Export Custom Header
description: Export Custom Header
slug: gridview-export-troubleshooting-export-header
tags: export,custom,header
published: True
position: 1
---

# Export Custom Header



## 

__PROBLEM__

Sometimes __custom headers__ for the columns are used. When __exporting__ the RadGridView, the actual text in the custom header is not exported the right way.
        



__CAUSE__

When you insert a custom UIElement in the header of a GridViewColumn, the RadGridView does not know the meaningful value of the UIElement.



__SOLUTION__

In case you insert a custom UIElement in the header of a GridViewColumn,
          you will need to handle the __ElementExporting__ event of RadGridView. Then check if the exported element is a header cell and set the appropriate value to be exported. This is needed since
          there is no way for the RadGridView to know the meaningful value of a UIElement.
          

Here is a small sample code:
        

1. Define a custom header with a TextBlock
        

#### __XAML__

{{region gridview-export-troubleshooting-export-header_0}}
	<telerik:GridViewDataColumn DataMemberBinding="{Binding StadiumCapacity}">
	    <telerik:GridViewDataColumn.Header>
	        <TextBlock Text="Stadium capacity (seats)"
	                        TextWrapping="Wrap"/>
	    </telerik:GridViewDataColumn.Header>
	</telerik:GridViewDataColumn>
	{{endregion}}



2. Handle the ElementExporting event for the exported RadGridView
        

#### __C#__

{{region gridview-export-troubleshooting-export-header_1}}
	void clubsGrid_ElementExporting(object sender, GridViewElementExportingEventArgs e)
	{
	    if (e.Value != null && e.Value.GetType() == typeof(TextBlock))
	         e.Value = (e.Value as TextBlock).Text;
	}
	{{endregion}}



#### __VB.NET__

{{region gridview-export-troubleshooting-export-header_2}}
	Private Sub clubsGrid_ElementExporting(sender As Object, e As GridViewElementExportingEventArgs)
	        If e.Value IsNot Nothing AndAlso e.Value.[GetType]() = GetType(TextBlock) Then
	            e.Value = TryCast(e.Value, TextBlock).Text
	        End If
	    End Sub
	{{endregion}}


         When you set the __Value__ in the GridViewElementExportingEventArgs object to the correct header text, the headers will be exported as expected.
        


