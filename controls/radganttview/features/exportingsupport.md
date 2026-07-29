---
title: Exporting Support
page_title: Exporting Support
description: Check our &quot;Exporting Support&quot; documentation article for the RadGanttView {{ site.framework_name }} control.
slug: radganttview-exportingsupport
tags: exporting,support
published: True
position: 6
---

# Exporting Support

With the Q2 2013 release of __RadGanttView__ the control provides an image exporting mechanism which enables its printing functionality.

The exporting functionality is simple and all you need to do is pass the desired image size, printable areas etc. to the built-in exporting service which would generate images containing the contents of the control. The exporting functionality supports exporting the controls __GridView__ area, __TimeLine__ area or both. It is also customizable to include or exclude the Headers of the control.

The built-in exporting to images functionality of the RadGanttView control works in the following matter. By calling the ExportingService.BeginExporting method of the control you will need to pass an object of type ImageExportSettings. The BeginExporting method returns an object of __ImageExporter__ type which holds a collection of wrappers which are used to export the __BitmapSource__. Then next screenshot shows the principal with which the images are exported by the __ExportingService__:

![radganttview-exportingsupport-1](images/radganttview-exportingsupport-1.png)

## Export for Printing

The next example will demonstrate how to export the contents of the RadGanttView control in order for them to be printed on A4 format.

>Note: Before proceeding with the next example you should get familiar with [Implementing View-ViewModel]({%slug radganttview-populating-with-data-viewmodel%})

1. First you should create a collection of __GanttTasks__, in the ViewModel and populate it with some sample data.

1. Create a DateRange object for the __VisibleRange__ property and set in in the ViewModel.

1. After we will need to create a custom __DocumentPaginator__ class and override its GetPage(),IsPageCountValid(),PageCount() and PageSize() methods:

	<snippet id='radganttview-features-exportingsupport-block_1-cs' />


1. Next we need to create a __PrintingService__ class that will handle the printing functionality with the use of a PrintDialog:

	<snippet id='radganttview-features-exportingsupport-block_2-cs' />


1. Finally we need to create a button that will make use of the newly created __PrintingService__ class:

	<snippet id='radganttview-features-exportingsupport-block_3-xaml' />


	<snippet id='radganttview-features-exportingsupport-block_4-cs' />


>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/GanttView/PrintingAndExporting).

The next screenshots show the final result:

1. The RadGanttView control with the Print button:

	![radganttview-exportingsupport-2](images/radganttview-exportingsupport-2.jpg)

1. The default printing dialog that is opened from the Print button:

	![radganttview-exportingsupport-3](images/radganttview-exportingsupport-3.jpg)

1. The generated .oxps file:

	![radganttview-exportingsupport-4](images/radganttview-exportingsupport-4.png)
