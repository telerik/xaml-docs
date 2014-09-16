---
title: Degraded Performance
page_title: Degraded Performance
description: Degraded Performance
slug: gridview-troubleshooting-performance
tags: degraded,performance
publish: True
position: 3
---

# Degraded Performance



## 

You might notice a reduced performance of the RadGridView control. 

Here are some possible reasons:

* The GridView is placed in a control that measures its children with __infinity -__such controls are ScrollViewer, StackPanel (when vertical it measures with infinite height and when horizontal - with infinite width), and Grid with RowDefinition Height="Auto" or ColumnDefinition Width="Auto". When RadGridView (or any other grid) is measured with infinity __virtualization is turned off__ which results in reduced performance. Modify your code so that RadGridView is placed in a container that will not measure it with infinity and the performance will be back to normal.
            

* __Binding to complex properties__ - If you bind to complex property (sub property) the __RadGridView__ have to use bindings to get the value for the cell. The better performance will be achieved if you bind to a simple property because we will use lambda to get the value. Using lambdas is much faster than bindings.
          

* __Converters__ - calling converters will slow down the performance.
          

* __CellTemplates__ - using CellTemplates is a time consuming operation. If applicable, try to stick to the Default Templates.
          

* As of __Q1 2012 SP1__ you have the option to disable the Telerik StyleManager and to style the controls using Implicit Styles. There are a number of benefits of using implicit styles over the Telerik StyleManager. For more information, please refer to this [help article]({%slug styling-apperance-implicit-styles-overview%}).
            

* __DataLoadMode="Asynchronous"__ - using this mode is not recommended, it leads to potential problems. Please do not use it.
          

* __Degraded performance with Windows8, Windows8Touch and Office2013 Themes__
              - you can consider applying the lightweight templates in order to speed up the performance of RadGridView. Please check [this detailed article]({%slug gridview-overview-lightweight-template%}), which explain the purpose of these styles.
            

* __TouchManager__ -  another optimization would be to __disable the Touch Support__. You can refer to the [Touch Support](737cc59b-2828-49eb-be56-3bac4b9ad992#States) article.
            

* As of __Q2 2014 SP__ release we introduced the option to __turn off the generating of the automation peers through the new global AutomationMode property of the AutomationManager__. You can check the [UI Automation Support]({%slug common-ui-automation%}) article on how to set the AutomationMode property to Disabled.
            

* __Alternation__ (setting AlternationCount) is a very slow operation. Avoid it unless it is definetely needed. __AlternateRowStyle__ - using AlternateRowStyle is a time consuming operation. If you just need to set the background of the alternating rows we recommend using the __AlternateRowBackground__ property.
            

* __RowStyle__ - using the RowStyle is a time consuming operation. Please use implicit Styles.
            

Not Recommended (using the RowStyle):

#### __XAML__

{{region gridview-troubleshooting-performance_0}}
	<telerik:RadGridView RowStyle="{StaticResource myRowStyle}"                     
	                     ItemsSource="{Binding Data}" />
	{{endregion}}



Recommended (using implicit Style):

#### __XAML__

{{region gridview-troubleshooting-performance_1}}
	<UserControl.Resources> 
	    <Style TargetType="telerik:GridViewRow">
	  <Setter Property="Background" Value="Blue"/>   
	    </Style>        
	</UserControl.Resources>
	<Grid x:Name="LayoutRoot" Margin="100">   
	   <telerik:RadGridView ItemsSource="{Binding Data}" />
	</Grid>
	{{endregion}}



You can also refer to this [help article]({%slug styling-apperance-implicit-styles-overview%}) on Implicit Styles and NoXaml binaries.
        

>As of __2013 Q2 SP__ we have introduced __Lightweight Templates__ for RadGridView and RadTreeListView. Their main idea is to limit the number of visual elements within the templates in order to speed up the performance of the control.
            [Read more]({%slug gridview-overview-lightweight-template%})

# See Also

 * [Tips and Tricks]({%slug radgridview-performance-tips-tricks%})

 * [Lightweight Templates]({%slug gridview-overview-lightweight-template%})
