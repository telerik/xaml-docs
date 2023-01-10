---
title: Tips and Tricks
page_title: Tips and Tricks
description: Check out our list of tips and tricks related to Telerik's {{ site.framework_name }} DataGrid that will help you tweak your application for optimal performance.
slug: radgridview-performance-tips-tricks
tags: tips,and,tricks
published: True
position: 1
---

# {{ site.framework_name }} RadGridView Tips and Tricks

__RadGridView__'s API allows you to tweak your application for optimal performance. To get the best out of the control you have to be familiar with the following performance tips.

* RadGridView supports [UI virtualization]({%slug radgridview-features-ui-virtualization%}) which processes only these visual elements that are loaded in its viewable area. This reduces the memory footprint of the application and speeds up the loading time, thus enhancing the UI performance.
          
* Placing RadGridView in panels/controls which measure it with infinity disables the UI virtualization mechanism of the control and can greatly impact performance when dealing with large amounts of data. Examples of such panels include __ScrollViewer__, __StackPanel__ and __Grid__ with a definition with **Width/Height** set to **Auto**.
            
* It is recommended to use the **Flat** [GroupRenderMode]({%slug gridview-grouping-groupingmodes%}). Configuring it involves rendering rows one below the other, which leads to better performance results as opposed to the Nested mode where rows are nested into one another in case nesting is required (grouping or hierarchy). The Flat mode also resolves few rendering issues related to the Nested mode.

* You can also speed up the performance of the control by using the [lightweight templates]({%slug gridview-overview-lightweight-template%}) for RadGridView and RadTreeListView. Their main idea is to limit the number of visual elements within the templates of the rows and cells and reduce the amount of time it takes to render them.

* If applicable, you can also __turn off the generation of automation peers__ through the new global __AutomationMode__ property of the __AutomationManager__. By setting it to **Disabled** you can greatly improve the performance of the control in certain scenarios.
            
* Another optimization would be to __disable__ the [touch support]({%slug touch-support%}) which will prevent any touch events to be fired. 

* When using [combobox columns]({%slug radgridview-columns-column-types-combobox-column%}) in your RadGridView instance, you can set their __IsLightweightModeEnabled__ property to __true__ which will significantly increase the performance of their lookup logic. Thus, the overall performance of RadGridView will be improved as well.

* When you have child RadGridViews placed in [row details]({%slug radgridview-row-details-template%}) or a [hierarchy structure]({%slug gridview-basic-hierarchies%}), make sure to specify fixed dimensions for them (**Height/MaxHeight** and **Width/MaxWidth**). Otherwise their [UI virtualization]({%slug radgridview-features-ui-virtualization%}) mechanism will be disabled. 

* Binding large datasets to the control is a time consuming task that can at times test the users' patience. To provide better user experience RadGridView exposes an __IsBusy__ property through which you can display a [busy indicator]({%slug gridview-busy-indicator%}) while the data is loading.
            
* RadGridView offers excellent integration with the [RadDataPager control]({%slug radgridview-paging-using-telerik-raddatapager%}) which can be extremely helpful when working with large collections of data.

* In general, the fastest performance can be achieved if you bind the columns to simple properties because, in this case, lambda expressions are used to get the values. If you bind to nested (sub) properties the control uses bindings to get the values for the cells, which is a much slower operation.            

* Set а __fixed Width__ for the columns. Here's a list of the different options when setting the column widths, ordered from best to worst performance.
	* __Fixed__: Providing a fixed valued (such as 100) for the columns' width increases both horizontal and vertical scrolling performance. 
	* __Auto__: Setting a width size of **Auto** provides similar, but worse performance.
	* __Star__: Providing a star-based width results in the slowest performance. This is most noticeable when you have a lot of columns.

* Disable validation in view-mode by setting the [ValidatesOnDataErrors]({%slug gridview-managing-data-validation%}) property to **InEditMode**.

* Avoid using [converters](https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.ivalueconverter) for the bindings. Calling a converter is a time-consuming operation and this will slow down the performance.

* Avoid applying a __RowStyle__ and/or an __AlternateRowStyle__ which modify the default control template of the GridViewRow element. This will result in a significant performance hit.
            
* If possible, try not to modify to the default cell templates and avoid overriding them by setting the [CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%}) properties unless really necessary.

* Using the __DataLoadMode="Asynchronous"__ is __not recommended__ as it can lead to potential problems.

* It is also recommended to set the **IsPropertyChangedAggregationEnabled** property to **False**. Its default value is **True**, meaning that the occurrence of the PropertyChanged event will be handled on a fixed time period using a DispatcherTimer, which improves the rendering performance when there are a large number of value updates in a short period of time. If this is not the case in your application, you can disable this property so that the resources taken by the aforementioned DispatcherTimer will be freed, thus improving the overall performance of the control.
            
## See Also

* [UI Virtualization]({%slug radgridview-features-ui-virtualization%})
* [Grouping Modes]({%slug gridview-grouping-groupingmodes%})
* [Busy Indicator]({%slug gridview-busy-indicator%})
* [RadDataPager Integration]({%slug radgridview-paging-using-telerik-raddatapager%})
* [CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%})
* [Lightweight Templates]({%slug gridview-overview-lightweight-template%})
* [Managing Data Validation]({%slug gridview-managing-data-validation%})
* [UI Automation Support]({%slug common-ui-automation%})
