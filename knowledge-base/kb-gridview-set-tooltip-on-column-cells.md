---
title: Set a Tooltip on the Cells of a Column
description: This article will show you how to set a tooltip on the cells of a column.
page_title: Display a ToolTip on a Column's Cells
type: how-to
slug: kb-gridview-set-tooltip-on-column-cells
position: 0
tags: gridview, image, column, tooltip, tooltiptemplate
res_type: kb
ticketid: 1655547
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2024.2.514</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to set a tooltip on the cells of a column.

## Solution

The `ToolTip` property of each column type of RadGridView is inherited from the `FrameworkContentElement` class, which is the base class of all of them. There is no implementation for this property in the context of the columns. Instead, you can use the `ToolTipTemplate` property.

__Setting the ToolTipTemplate property of a GridViewImageColumn__
```XAML
    <telerik:RadGridView ItemsSource="{Binding MyCollection}"
                         AutoGenerateColumns="False">
        <telerik:RadGridView.Columns>
            <telerik:GridViewImageColumn DataMemberBinding="{Binding MyImagePath}">
                <telerik:GridViewImageColumn.ToolTipTemplate>
                    <DataTemplate>
                        <TextBlock Text="My ToolTip"/>
                    </DataTemplate>
                </telerik:GridViewImageColumn.ToolTipTemplate>
            </telerik:GridViewImageColumn>
        </telerik:RadGridView.Columns>
    </telerik:RadGridView>
```

You can bind the elements inside the DataTemplate for the ToolTipTemplate property to properties of the underlying data model.

The following example showcases this scenario:

__Defining the model and view model__
```C#
    public class Person
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
    }

    public class MainViewModel
    {
        public MainViewModel()
        {
            this.People = new ObservableCollection<Person>()
            {
                new Person()
                {
                    Name = "Jack",
                    ImagePath = "jack.png"
                },
            };
        }

        public ObservableCollection<Person> People { get; set; }
    }
```

__Binding the Name property to the element inside the DataTemplate for the ToolTipTemplate property__
```XAML
    <Grid>
        <Grid.DataContext>
            <local:MainViewModel/>
        </Grid.DataContext>
        <telerik:RadGridView ItemsSource="{Binding People}"
                             AutoGenerateColumns="False">
            <telerik:RadGridView.Columns>
                <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"/>
                <telerik:GridViewImageColumn DataMemberBinding="{Binding ImagePath}">
                    <telerik:GridViewImageColumn.ToolTipTemplate>
                        <DataTemplate>
                            <TextBlock Text="{Binding Name}"/>
                        </DataTemplate>
                    </telerik:GridViewImageColumn.ToolTipTemplate>
                </telerik:GridViewImageColumn>
            </telerik:RadGridView.Columns>
        </telerik:RadGridView>
    </Grid>
```

__Tooltip of GridViewImageColumn bound to a property of the underlying data model__

![Tooltip of GridViewImageColumn bound to a property of the underlying data model](images/kb-gridview-set-tooltip-on-column-cells-0.png)