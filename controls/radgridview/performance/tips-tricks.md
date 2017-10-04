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

__RadGridView__ API allows you to tweak your application for optimal performance. You should be familiar with the following performance tips:

* RadGridView API supports __UI Virtualization__, which processes only information loaded in the viewable area, which reduces the memory footprint of the application and speeds up loading time thus enhancing additionally the UI performance. [Read more]({%slug radgridview-features-ui-virtualization%}).
          
* Try not to place RadGridView in controls/panels which will measure it with infinity. For example, __ScrollViewer__, __StackPanel__ and __Grid__ with __Row.Height=Auto__ or __Column.Width=Auto__ will measure with infinity. When the control is measured with infinity the [virtualization]({%slug radgridview-features-ui-virtualization%}) turns off.  

* Binding large dataset to the control is a time consuming task that can at times test the user’s patience. To provide better user experience RadGridView exposes __IsBusy property__.
            
* RadGridView offers an excellent integration with Telerik's __RadDataPager__. [Read more]({%slug radgridview-paging-using-telerik-raddatapager%}).

* In general, the fastest performance can be achieved if you bind the columns to a simple property because we will use lambda to get the value. If you bind to complex property (sub property) we have to use bindings to get the value for the cell, which is much slower then lambdas.            

* Set __fixed Width__ for the columns. 
	* Configuring __RadGridView.ColumnWidth to a specific width__ (like 100) will increase both horizontal and vertical scrolling performance. 
	* __Auto__ is a little bit slower 
	* __Star__ is the slowest (this is most noticeable when you have a lot of columns).

* Disable validation in view mode through configuring [ValidatesOnDataErrors="InEditMode"]({%slug gridview-managing-data-validation%}).

* Avoid using converters. Calling a converter is a time-consuming operation and this will slow down the performance.

* Avoid using __RowStyle__ and/or __AlternateRowStyle__ - use [implicit styles]({%slug styling-apperance-implicit-styles-overview%}) instead. 
            
* __DataLoadMode="Asynchronous"__ - using this mode is __not recommended__, it leads to potential problems. Please do not use it.        

* If applicable, try to stick to the default templates and avoid overriding templates of rows and cells.
            
* As of __Q1 2012 SP1__ you have the option to disable the Telerik StyleManager and to style the controls using Implicit Styles. There are a number of benefits of using implicit styles over the Telerik StyleManager. For more information, please refer to the respective [help article]({%slug styling-apperance-implicit-styles-overview%}).
            
* As of __Q3 2012__ we introduced a new rendering mode - Flat. Configuring it, involves rendering rows one below the other, which leads to better perfromance results. You can also refer to the [GroupingModes]({%slug gridview-grouping-groupingmodes%}) article.
              
* As of __2013 Q2 SP__ we introduced __Lightweight Templates__ for RadGridView and RadTreeListView. Their main idea is to limit the number of visual elements within the templates in order to speed up the performance of the control. [Read more]({%slug gridview-overview-lightweight-template%}).

>tipYou can also find the blog post on [How To Boost RadGridView Performance for WPF and Silverlight Using Lightweight templates](http://www.telerik.com/blogs/how-to-boost-radgridview-performance-for-wpf-and-silverlight-using-lightweight-templates).

* RadGridView with applied __Windows8, Windows8Touch or Office2013 Theme__
                - Telerik controls in these themes use resources, which are linked to a one major singleton that contains the colors used in them. Such an approach slows down the performance of virtualized components, such as RadGridView. You can consider applying the __Lightweight Templates__ in order to speed up the performance. Please check [this detailed article]({%slug gridview-overview-lightweight-template%}), which explain the purpose of these styles.
              
* As of __Q2 2014 SP__ release we introduced the option to __turn off generating of automation peers through the new global AutomationMode property of the AutomationManager__. You can check the [UI Automation Support]({%slug common-ui-automation%}) article on how to set the AutomationMode property to Disabled.
            
* __TouchManager__ -  another optimization would be to __disable the Touch Support__. You can refer to the [Touch Support]({%slug touch-support%}) article.

* As of __R2 2016__ GridViewComboBoxColumn exposes a new property - __IsLightweightModeEnabled__. Setting it to __true__ significantly increases the lookup logic of __GridViewComboBoxColumn__. Thus, the overall performance of RadGridView will be improved as well.
            
## See Also

 * [Degraded Performance]({%slug gridview-troubleshooting-performance%})

 * [Lightweight Templates]({%slug gridview-overview-lightweight-template%})

 * [Sorting]({%slug gridview-overview-sorting%})

 * [Grouping]({%slug gridview-overview-grouping%})

 * [Filtering]({%slug gridview-overview-filtering%})
