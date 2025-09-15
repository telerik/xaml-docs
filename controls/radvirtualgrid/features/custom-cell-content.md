---
title: Custom Cell Content
page_title: Custom Cell Content
description: Learn how you can use custom controls as the content of the RadVirtualGrid cells by specifying a custom DataTemplate.
slug: radvirtualgrid-custom-cell-content
tags: celltooltip,virtualgrid,
published: True
position: 11
---

# Custom Cell Content

As of **R2 2022**, the RadVirtualGrid allows you to display any control as the content of its cells.

You can do so via the new `CellTemplateNeeded` event. Its `CellTemplateEventArgs` expose the following properties:

* **ColumnIndex**: The index of the column.
* **RowIndex**: The index of the row.
* **DataItem**: The object that represents the row in case a **DataProvider** is used, otherwise it's `null`.
* **DataTemplate**: The DataTemplate to be applied for this cell.

When a [DataProvider]({%slug virtualgrid-custom-dataprovider%}) is used, the CellTemplateNeeded event also provides the data item, which will be the DataContext inside the DataTemplate. In scenarios without a DataProvider, the DataContext inside the cell will be whatever is passed to the [CellValueNeeded]({%slug virtualgrid-getting-started2%}#cellvalueneeded) event for the given cell. 

Here's an example of how you can display an image for one of the columns.

__Define the template for the cells__
```C#
    <Window.Resources>
        <DataTemplate x:Key="ImageTemplate">
            <!-- This example assumes the bound objects expose a public Image property
            which holds the path to the actual image -->
            <Image Source="{Binding Image}" />
        </DataTemplate>
    </Window.Resources>
```

__Display image as the content of the cells__
```C#
    private void VirtualGrid_CellTemplateNeeded(object sender, Telerik.Windows.Controls.VirtualGrid.CellTemplateEventArgs e)
    {
        if (e.ColumnIndex == 3)
        {
            e.DataTemplate = this.Resources["ImageTemplate"] as DataTemplate;
        }
    }
```

![Display image as the content of the cells](images/radvirtualgrid-features-custom-cell-content-1.png)
	
## See Also

* [Custom Data Provider]({%slug virtualgrid-custom-dataprovider%})
* [Editing]({%slug virtualgrid-editing%})
* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})
* [Pinned Rows and Columns]({%slug virtualgrid-pinned-rows-and-columns%})