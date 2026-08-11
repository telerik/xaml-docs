---
title: Export Custom Header
page_title: Export Custom Header
description: Read this article to learn how to define the value of a custom header in Telerik's {{ site.framework_name }} DataGrid in order to export it correctly.
slug: gridview-export-troubleshooting-export-header
tags: export,custom,header
published: True
position: 3
---

# Export Custom Header

__PROBLEM__

When exporting __RadGridView__ and you have defined __custom headers__ for some columns, the actual text within the custom header is not exported correctly unless you explicitly define the value. 


__CAUSE__

When you insert a custom UIElement in the header of a GridViewColumn, the RadGridView does not know the meaningful value of the UIElement.

__SOLUTION__

In case you insert a custom UIElement in the header of a GridViewColumn, you will need to handle the __ElementExporting__ event of RadGridView. Then check if the exported element is a header cell and set the appropriate value to be exported. This is needed since there is no way for the RadGridView to know the meaningful value of a UIElement.
          
Here is a small sample code:      

* Define a custom header with a TextBlock
        
__Example 1: Define a custom header:__

<snippet id='radgridview-export-how-to-export-header-example_1_define_a_custom_header-xaml' />


* Handle the ElementExporting event for the exported RadGridView
        
__Example 2: Handle the ElementExporting event:__

<snippet id='radgridview-export-how-to-export-header-example_2_handle_the_elementexporting_event-cs' />

<snippet id='radgridview-export-how-to-export-header-example_2_handle_the_elementexporting_event-vb' />


When you set the __Value__ in the GridViewElementExportingEventArgs object to the correct header text, the headers will be exported as expected.
        


