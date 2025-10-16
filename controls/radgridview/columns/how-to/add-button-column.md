---
title: Customize Cell Content
page_title: Add a Button Column
description: See examples demonstrating how to add a column with a delete button for each row within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-add-button-column
tags: add,a,button,column
published: True
position: 1
---

# Customize Cell Content

This article demonstrates how to add a column with a delete button for each row. We will benefit from the static [RadGridViewCommands]({%slug gridview-commands-overview%}) class to automatically delete the corresponding row item upon clicking the button. **Figure 1** illustrates the desired result.

#### Figure 1: RadGridView with custom button column

![Custom Button Column in RadGridView - Telerik's {{ site.framework_name }} DataGrid](images/delete_column_gridview.png)

There are several ways to achieve this. Let's look at some of them.

* [Create a Custom Column](#create-a-custom-column)
* [Use the GridViewColumn's CellTemplate Property](#use-the-gridviewcolumn-celltemplate-property)

## Create a Custom Column

This approach involves inheriting from __GridViewColumn__ and overriding the __CreateCellElement__ method. In this method, you can create the button (if it has not already been created) and set its properties as demonstrated in **Example 1**.

>important In order to automatically export a custom column, it should implement the **IExportableColumn** interface.

__Example 1: Override the CreateCellElement method__

```C#
	public class MyButtonColumn : Telerik.Windows.Controls.GridViewColumn
	{
	    public override FrameworkElement CreateCellElement(GridViewCell cell, object dataItem)
	    {
	        RadButton button = new RadButton();
	        button.Content = "Delete";
	        button.Command = RadGridViewCommands.Delete;
	        button.CommandParameter = dataItem;	
	        return button;
	    }
	}
```
```VB.NET
	Public Class MyButtonColumn
	Inherits Telerik.Windows.Controls.GridViewColumn

		Public Overrides Function CreateCellElement(ByVal cell As GridViewCell, ByVal dataItem As Object) As FrameworkElement
			Dim button As RadButton = TryCast(cell.Content, RadButton)
			If button Is Nothing Then
				button = New RadButton()
				button.Content = "Delete"
				button.Command = RadGridViewCommands.Delete
			End If

			button.CommandParameter = dataItem

			Return button
		End Function
	End Class
```

Now you need to add this custom column to our RadGridView's **Columns** collection. **Example 2** shows how to do this in XAML.

__Example 2: Define the custom column in XAML__

```XAML
	<telerik:RadGridView.Columns>
	    <!-- ... -->
	    <my:MyButtonColumn Header="Delete" />
	</telerik:RadGridView.Columns>
```

The same can be achieved in code-behind as illustrated in **Example 3**.

__Example 3: Define the custom column in code-behind__

```C#
	private void clubsGrid_DataLoaded(object sender, EventArgs e)
	{
	    this.clubsGrid.Columns.Add(new MyButtonColumn()
	    {
	        Header = "Delete"
	    });
	}
```
```VB.NET
	Private Sub clubsGrid_DataLoaded(ByVal sender As Object, ByVal e As EventArgs)
		Me.clubsGrid.Columns.Add(New MyButtonColumn() With {.Header = "Delete"})
	End Sub
```

## Use the GridViewColumn CellTemplate Property

With this approach we will re-define the template of the cells for that column. In this case, we specify a simple **DataTemplate** which contains our delete button.

__Specify the GridViewColumn's CellTemplate__

```XAML
	<telerik:RadGridView.Columns>
	    <!-- ... -->
	    <telerik:GridViewColumn Header="Delete" >
	        <telerik:GridViewColumn.CellTemplate>
	            <DataTemplate>
	                <telerik:RadButton Content="Delete" 
	                        Command="telerik:RadGridViewCommands.Delete"
	                        CommandParameter="{Binding}" />
	            </DataTemplate>
	        </telerik:GridViewColumn.CellTemplate>
	    </telerik:GridViewColumn>
	</telerik:RadGridView.Columns>
```

Notice that we've set the **Command** of the button to the **RadGridViewCommands.Delete** command and passed in the current row item (the DataContext of the cell) as the **CommandParameter**.

## See Also

 * [CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%})
 * [Create Custom Column Editor]({%slug gridview-how-to-create-custom-column-editor%})
 * [Create Custom Editor with RadGridView]({%slug radgridview-howto-create-custom-editor%})
