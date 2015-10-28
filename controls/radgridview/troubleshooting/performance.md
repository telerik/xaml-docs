---
title: Degraded Performance
page_title: Degraded Performance
description: Degraded Performance
slug: gridview-troubleshooting-performance
tags: degraded,performance
published: True
position: 0
---

# Degraded Performance

You might notice a reduced performance of RadGridView control. Below are listed some possible reasons:

* RadGridView is placed in a control that measures its children with __infinity__ - such controls are:
	*  ScrollViewer
	*  StackPanel (when vertical it measures with infinite height and when horizontal - with infinite width)
	*  Grid with RowDefinition Height="Auto" or ColumnDefinition Width="Auto".

	When RadGridView is measured with infinity [UI virtualization]({%slug radgridview-features-ui-virtualization%}) is turned off which results in reduced performance. Modify your code so that RadGridView is placed in a container that will not measure it with infinity, for example Grid with RowDefinition Height="*".

* Set __fixed Width__ for the columns.

* Disable validation in view mode through configuring [ValidateOnDataErrors="InEditMode"]({%slug gridview-managing-data-validation%}).

* __Binding to complex properties__ - If you bind to complex property (sub property) RadGridView uses bindings to get the value for the cell. Better performance will be achieved if you bind to a simple property as we then use the .Net expression API to get the value.    

* __Converters__ - calling converters will slow down the performance.
 
* __CellTemplates__ - using CellTemplates is a time consuming operation. If applicable, try to stick to the Default Templates.

* As of __Q1 2012 SP1__ you have the option to disable the Telerik StyleManager and to style the controls using Implicit Styles. There are a number of benefits of using implicit styles over the Telerik StyleManager. For more information, please refer to this [help article]({%slug styling-apperance-implicit-styles-overview%}).

* As of __Q3 2012__ a __new rendering mode - Flat__ is available. When you set Flat mode, the control will render rows one below other. This leads to a very good perfromance when there is grouping on several levels defined and a lot of data is populated. You can also refer to the [Grouping Modes]({%slug gridview-grouping-groupingmodes%}) article.

* __DataLoadMode="Asynchronous"__ - using this mode is not recommended, it leads to potential problems. Please do not use it.

* __Degraded performance with Windows8, Windows8Touch and Office2013 Themes__ - you can consider applying the lightweight templates in order to speed up the performance. Please check [this detailed article]({%slug gridview-overview-lightweight-template%}), which explain the purpose of these styles.
  
* __TouchManager__ -  another optimization would be to __disable Touch Support__. You can refer to the [Touch Support]({%slug touch-support%}) article.
            
* As of __Q2 2014 SP__ release we introduced the option to __turn off generating of automation peers through the new global AutomationMode property of the AutomationManager__. You can check the [UI Automation Support]({%slug common-ui-automation%}) article on how to set the AutomationMode property to Disabled.

* __Alternation__ is a very slow operation. Avoid it unless it is definetely needed. 

* __AlternateRowStyle__ - using AlternateRowStyle is a time consuming operation. If you just need to set background simulating alternating rows we recommend using [RowStyleSelector]({%slug gridview-rowstyleselector%}).
            
* __RowStyle__ - using RowStyle is a time consuming operation. Please apply implicit Styles.

__Not Recommended__ (using the RowStyle):

#### __XAML__

{{region gridview-troubleshooting-performance_0}}

	<telerik:RadGridView RowStyle="{StaticResource myRowStyle}"                     
	                     ItemsSource="{Binding Data}" />
{{endregion}}

__Recommended__ (using implicit Style):

#### __XAML__

{{region gridview-troubleshooting-performance_1}}

	<UserControl.Resources> 
	    <Style TargetType="telerik:GridViewRow" BasedOn="{StaticResource GridViewRowStyle}>
	  <Setter Property="Background" Value="Blue"/>   
	    </Style>        
	</UserControl.Resources>
	<Grid x:Name="LayoutRoot" Margin="100">   
	   <telerik:RadGridView ItemsSource="{Binding Data}" />
	</Grid>
{{endregion}}

* __IsPropertyChangedAggregationEnabled__ - Introduced as of __Q2 2015 SP1__. Basically, through this property you can control how __RadGridView__ will handle __PropertyChanged__ event. Its default value is __True__, meaning that the event occurrency will be handled on a fixed time period using a __DispatcherTimer__, which improves the rendering performance for multiple value updates. When set to __False__, the resources taken by the aforementioned __DispatcherTimer__ will be freed, thus the overall performance of the control will be improved. 

           

You can also refer to the documentation on [Implicit Styles and NoXaml binaries]({%slug styling-apperance-implicit-styles-overview%}).
        
>As of __2013 Q2 SP__ we introduced __Lightweight Templates__ for RadGridView and RadTreeListView. Their main idea is to limit the number of visual elements within the templates in order to speed up the performance of the control. [Read more]({%slug gridview-overview-lightweight-template%}).

>tipYou can also find the blog post on [How To Boost RadGridView Performance for WPF and Silverlight Using Lightweight templates](http://www.telerik.com/blogs/how-to-boost-radgridview-performance-for-wpf-and-silverlight-using-lightweight-templates).

# See Also

 * [Tips and Tricks]({%slug radgridview-performance-tips-tricks%})

 * [Lightweight Templates]({%slug gridview-overview-lightweight-template%})
 
 * [Grouped Performance]({%slug gridview-performance-grouped%})
