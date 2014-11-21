---
title: Adding RadPivotFieldList to your project
page_title: Adding RadPivotFieldList to your project
description: Adding RadPivotFieldList to your project
slug: radpivotgrid-fieldlist-started
tags: adding,radpivotfieldlist,to,your,project
published: True
position: 1
---

# Adding RadPivotFieldList to your project

In this article we will show how to integrate __RadPivotFieldList__ with __RadPivotGrid__. We will extend our project from the [Getting Started]({%slug radpivotgrid-getting-started%}) article for __RadPivotGrid__.

## Adding RadPivotFieldList

>__RadPivotFieldList__ can be used after adding reference to the following assemblies:
{% if site.site_name == 'WPF' %}
>	* Telerik.Windows.Controls
>	* Telerik.Windows.Controls.PivotFieldList
>	* Telerik.Windows.Controls.Navigation
>	* Telerik.Windows.Controls.Input
>	* Telerik.Windows.Controls.Data
>	* Telerik.Windows.Controls.Pivot
>	* Telerik.Pivot.Core
{% endif %}
{% if site.site_name == 'Silverlight' %}
>	* Telerik.Windows.Controls
>	* Telerik.Windows.Controls.PivotFieldList
>	* Telerik.Windows.Controls.Navigation
>	* Telerik.Windows.Controls.Input
>	* Telerik.Windows.Controls.Pivot
>	* Telerik.Pivot.Core
>	* System.Runtime.Serialization
{% endif %}

You can add your __RadPivotFieldList__ directly in the XAML. First step is to define __pivot__ namespace: __xmlns:pivot="http://schemas.telerik.com/2008/xaml/presentation/pivot"__. After that add the code below:        	

#### __XAML__

{{region radpivotgrid-fieldlist-getting-started_1}}
	<pivot:RadPivotFieldList Name="radPivotFieldList1" Grid.Column="1" />
{{endregion}}

Now the only thing you have to set is the DataProvider:        	

#### __XAML__

{{region radpivotgrid-fieldlist-getting-started_2}}
	<pivot:RadPivotFieldList Name="radPivotFieldList1" Grid.Column="1"  DataProvider="{StaticResource LocalDataProvider}"/>
{{endregion}}

Here's the result of the modified application from [Getting Started]({%slug radpivotgrid-getting-started%}) article:
![Rad Pivot Grid Rad Field List Getting Started 01](images/RadPivotGrid_RadFieldList_GettingStarted_01.png)

Now by using __RadPivotFieldList__ you are able to modify __RadPivotGrid__ at runtime and to generate reports with entire new structure and information. For example:
![Rad Pivot Grid Rad Field List Getting Started 02](images/RadPivotGrid_RadFieldList_GettingStarted_02.png)

# See Also

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [RadPivotGrid Getting Started]({%slug radpivotgrid-getting-started%})

 * [Populating with Data]({%slug radpivotgrid-populating-with-data%})
