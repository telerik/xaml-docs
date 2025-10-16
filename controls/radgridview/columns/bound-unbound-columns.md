---
title: Bound/Unbound Columns
page_title: Bound/Unbound Columns
description: Learn more about RadGridView's bound columns supporting sorting, filtering, grouping, etc. and unbound columns used for displaying custom content.
slug: gridview-columns-bound-unbound-columns
tags: bound/unbound,columns
published: True
position: 2
---

# Bound/Unbound Columns

When populating __RadGridView__ with data two logical types of columns can be used - __bound and unbound__.

__Bound columns__ represent the data from __RadGridView's__ ItemsSource. They support data related functionality such as [sorting]({%slug gridview-sorting-basics%}), [filtering]({%slug gridview-filtering-basic%}), [grouping]({%slug gridview-grouping-basics%}), [aggregates]({%slug gridview-grouping-aggregates%}), etc. Typically the bound columns are of type __GridViewDataColumn__ with its __DataMemberBinding__ property set.



```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding EmployeeID}"
	                Header="ID (Bound)" />
```

![Telerik {{ site.framework_name }} DataGrid Bound Unbound Columns 1](images/RadGridView_BoundUnboundColumns_1.png)

__Unbound__ columns are used for displaying a custom content. Such custom content can be buttons which are not directly related to the underlying data, textbox for adding comments, images etc. The unbound column's content is defined by setting cell template. When using unbound columns you will be unable to perform filtering, sorting and grouping.

Here is an example for unbound column:



```XAML
	<telerik:GridViewColumn Header="Name">
	    <telerik:GridViewColumn.CellTemplate>
	        <DataTemplate>
	            <StackPanel Orientation="Horizontal">
	                <Image Stretch="None"
	       Source="../../Images/User.png"
	       Margin="0,0,5,0" />
	                <TextBlock Text="{Binding Name}"
	           VerticalAlignment="Center" />
	            </StackPanel>
	        </DataTemplate>
	    </telerik:GridViewColumn.CellTemplate>
	</telerik:GridViewColumn>
```

![Telerik {{ site.framework_name }} DataGrid Bound Unbound Columns 2](images/RadGridView_BoundUnboundColumns_2.png)

In the example above a __DataTemplate__ containing a __StackPanel__ with an __Image__ and a __TextBox__ is shown. In this case the __StackPanel__ and the __Image__ are not related to the data items. The __TextBox__ is bound to the data item. In the same time the unbound column lacks such data functionalities as sorting, grouping and filtering. 

Using __GridViewDataColumn__, however, can give you the advantages of both the bound and unbound column allowing you to perform data operations like sorting, grouping and filtering. In this case you can simultaneously set __DataMemberBinding__ and provide [CellTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%}), thus giving you the freedom to create rich visualizations. 

Here is the above sample of an unbound column transformed into a template column.



```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" Header="Name (Unbound)">
	    <telerik:GridViewDataColumn.CellTemplate>
	        <DataTemplate>
	            <StackPanel Orientation="Horizontal">
	                <Image Stretch="None"
	       Source="../../Images/User.png"
	       Margin="0,0,5,0" />
	                <TextBlock Text="{Binding Name}"
	           VerticalAlignment="Center" />
	            </StackPanel>
	        </DataTemplate>
	    </telerik:GridViewDataColumn.CellTemplate>
	</telerik:GridViewDataColumn>
```

![Telerik {{ site.framework_name }} DataGrid Bound Unbound Columns 3](images/RadGridView_BoundUnboundColumns_3.png)

## See Also

 * [Customizing Columns]({%slug gridview-columns-customizing-columns%})

 * [Data Formatting]({%slug gridview-columns-data-formatting%})
