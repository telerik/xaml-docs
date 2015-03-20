---
title: Tips and Tricks
page_title: Tips and Tricks
description: Tips and Tricks
slug: radgridview-performance-tips-tricks
tags: tips,and,tricks
published: True
position: 1
---

# Tips and Tricks

The __RadGridView__ API allows you to tweak your application for optimal performance. If you are a developer who wants to use __RadGridView__, you should be familiar with the following features regarding the performance exposed by the __RadGridView__:

* The __RadGridView__ API supports __UI Virtualization__, which processes only information loaded in the viewable area, which reduces the memory footprint of the application and speeds up loading time thus enhancing additionally the UI performance. [Read more]({%slug radgridview-features-ui-virtualization%})

* Binding large dataset to the __RadGridView__ is a time consuming task that can at times test the user’s patience. To provide better user experience the __RadGridView allows you set it IsBusy property__ accordingly until the data has been loaded.
            

* __RadGridView__ offers an excellent integration with Telerik's __RadDataPager__. [Read more]({%slug radgridview-paging-using-telerik-raddatapager%})

* In general, the fastest performance can be achieved if you bind to a simple property because we will use lambda to get the value. If you bind to complex property (sub property) the __RadGridView__ have to use bindings to get the value for the cell. Using bindings is much slower then lambdas.
            

* Avoid using converters. Calling a converter is a time-consuming operation and this will slow down the performance.
            

* Try not to place __RadGridView__ in controls/panels which will measure it with infinity. For example, __ScrollViewer__, __StackPanel__ and __Grid__ with __Row.Height=Auto__ or __Column.Width=Auto__ will measure with infinity. If __RadGridView__ is measured with infinity the virtualization turns off.  
            

* Setting __RadGridView.ColumnWidth__ to a specific width (like 100) will increase both horizontal and vertical scrolling performance. __Auto__ is a little bit slower and __Star__ is the slowest (most noticeable when you have a lot of columns).
            

* __DataLoadMode="Asynchronous"__ - using this mode is __not recommended__, it leads to potential problems. Please do not use it.
            

* If applicable, try to stick to the default templates and avoid overriding templates of rows and cells.
            

* As of __Q1 2012 SP1__ you have the option to disable the Telerik StyleManager and to style the controls using Implicit Styles. There are a number of benefits of using implicit styles over the Telerik StyleManager. For more information, please refer to the respective [help article]({%slug styling-apperance-implicit-styles-overview%}).
            

* Avoid using of __RowStyle__ and/or __AlternateRowStyle__ - use implicit styles instead. 
            

* As of __Q3 2012__ we have introduced a new rendering mode of RadGridView - Flat. The default __GroupRenderMode__ is Nested, and the new one is Flat. When you set the __Flat mode__, the GridView will render rows one below the other. This leads to a very good perfromance when the grid is grouped on several levels and has a lot of data. You can also refer to the [GroupingModes]({%slug gridview-grouping-groupingmodes%}) article.
              

* As of __2013 Q2 SP__ we have introduced __Lightweight Templates__ for RadGridView and RadTreeListView. Their main idea is to limit the number of visual elements within the templates in order to speed up the performance of the control. [Read more]({%slug gridview-overview-lightweight-template%})

* RadGridView with applied __Windows8, Windows8Touch or Office2013 Theme__
                - Telerik controls in these themes use resources, which are linked to a one major singleton that contains the colors used in them. Such an approach slows down the performance of virtualized components, such as RadGridView. You can consider applying the __Lightweight Templates__ in order to speed up the performance of RadGridView. Please check [this detailed article]({%slug gridview-overview-lightweight-template%}), which explain the purpose of these styles.
              

* As of __Q2 2014 SP__ release we introduced the option to __turn off the generating of the automation peers through the new global AutomationMode property of the AutomationManager__. You can check the [UI Automation Support]({%slug common-ui-automation%}) article on how to set the AutomationMode property to Disabled.
            

* __TouchManager__ -  another optimization would be to __disable the Touch Support__. You can refer to the [Touch Support]({%slug touch-support%}) article.
            

# See Also

 * [Degraded Performance]({%slug gridview-troubleshooting-performance%})

 * [Lightweight Templates]({%slug gridview-overview-lightweight-template%})

 * [Sorting]({%slug gridview-overview-sorting%})

 * [Grouping]({%slug gridview-overview-grouping%})

 * [Filtering]({%slug gridview-overview-filtering%})
