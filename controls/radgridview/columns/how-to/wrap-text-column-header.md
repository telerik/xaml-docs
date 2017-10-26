---
title: Wrap text in column header
page_title: Wrap text in column header
description: Wrap text in column header
slug: gridview-howto-wrap-text-column-header
tags: wrap,text,in,column,header
published: True
position: 8
---

# Wrap the text in the column header

This article shows how you can wrap the text of the column header, i.e. to have a multi-line text in the header. The end result will look like this:

![](images/gridview_how_to_multiline_header.png)


We will take advantage of the fact that the __Header__ property of the GridView column is of type Object so we can put everything in it. In this case this would be a TextBlock which has a convenient property __TextWrapping__

#### __XAML__
{{region xaml-gridview-howto-wrap-text-column-header_0}}

	<telerik:GridViewDataColumn DataMemberBinding="{Binding Established}" 
	                            DataFormatString="{}{0:yyyy}"
	                            Width="100" >
	    <telerik:GridViewDataColumn.Header>
	        <TextBlock Text="Stadium Established Date" TextWrapping="Wrap" />
	    </telerik:GridViewDataColumn.Header>
	</telerik:GridViewDataColumn>
{{endregion}}

That is it, now you have a multi-line header. 

## See also
 * [Column Headers]({%slug gridview-columns-column-headers%})
 * [Foreground color does not change in a custom header]({%slug gridview-troubleshooting-styling-custom-header%})
