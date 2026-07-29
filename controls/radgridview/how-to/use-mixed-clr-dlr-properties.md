---
title: Data Bind to Dynamic Object with CLR and Dynamic Properties
page_title: Data Bind to Dynamic Object with CLR and Dynamic Properties
description: This article describes how to implement DynamicObject with dynamic (DLR) and static (CLR) fields, and data bind it to Progress Telerik RadGridView (DataGrid).
slug: gridview-how-to-use-mixed-clr-dlr-properties
tags: have,mixed,clr,and,dlr,properties
published: True
position: 12
---

# Data Bind to Dynamic Object with CLR and Dynamic Properties

This article describes how to implement DynamicObject with dynamic (DLR) and static (CLR) fields, and data bind it to RadGridView.

The following model shows a class that derives from [DynamicObject](https://docs.microsoft.com/en-us/dotnet/api/system.dynamic.dynamicobject?view=netframework-4.8) and containing one CLR property called `Id`. When the RadGridView auto-generates its columns, the [TryGetMember](https://docs.microsoft.com/en-us/dotnet/api/system.dynamic.dynamicobject.trygetmember?view=netframework-4.8) method of the DynamicObject class will be used to fetch the values for each column. This said, you will need to implement some logic in the method in order to allow RadGridView to work with the data - both CLR (Common Language Runtime) and DLR (Dynamic Language Runtime).

__Example 1: DynamicObject implementation__
<snippet id='radgridview-how-to-use-mixed-clr-dlr-properties-example_1_dynamicobject_implementation-cs' />

<snippet id='radgridview-how-to-use-mixed-clr-dlr-properties-example_1_dynamicobject_implementation-vb' />


__Example 2: Populating with data__
<snippet id='radgridview-how-to-use-mixed-clr-dlr-properties-example_2_populating_with_data-cs' />

<snippet id='radgridview-how-to-use-mixed-clr-dlr-properties-example_2_populating_with_data-vb' />


__Example 3: RadGridView definition__
<snippet id='radgridview-how-to-use-mixed-clr-dlr-properties-example_3_radgridview_definition-xaml' />


![Telerik UI for {{ site.framework_name }} RadGridView auto-generating columns for mixed CLR and dynamic DLR properties](images/gridview-how-to-use-mixed-clr-dlr-properties-0.png)

>tip Another code example with dynamic data can be found in the {% if site.site_name == 'Silverlight' %}[Various Data Sources](https://demos.telerik.com/silverlight/#GridView/DataSources){% else %}[Various Data Sources](https://demos.telerik.com/wpf){% endif %} demo.
