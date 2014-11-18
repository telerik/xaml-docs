---
title: Add a button column
page_title: Add a button column
description: Add a button column
slug: gridview-add-button-column
tags: add,a,button,column
published: True
position: 5
---

# Add a button column



This article will show how to add a column to RadGridView which contains a delete button. We will use the [RadGridViewCommands]({%slug gridview-commands-overview%}) to automatically delete the corresponding row.

![](images/delete_column_gridview.png)

There are several ways to achieve this. Let's look at some of them.

## Creating a custom column

With this approach we are inheriting the __GridViewColumn__ and override the __CreateCellElement__ method. In this method we create the button, if not already created, and set its properties:

#### __C#__

{{region gridview-add-button-column_0}}

	public class MyButtonColumn : GridViewColumn
	{
	 public override FrameworkElement CreateCellElement(GridViewCell cell, object dataItem)
	 {
	  RadButton button = cell.Content as RadButton;
	  if (button == null)
	  {
	   button = new RadButton();
	   button.Content = "Delete";
	   button.Command = RadGridViewCommands.Delete;
	  }
	
	  button.CommandParameter = dataItem;
	
	  return button;
	 }
	}
{{endregion}}

Now we need to add this custom column to our gridview. We can do it either in XAML:

#### __XAML__

{{region gridview-add-button-column_1}}

	<telerik:RadGridView.Columns>
	    ...
	    <my:MyButtonColumn Header="Delete" />
	</telerik:RadGridView.Columns>
{{endregion}}

or in the code (in the DataLoaded event of the gridview):

#### __C#__

{{region gridview-add-button-column_2}}

	private void clubsGrid_DataLoaded(object sender, EventArgs e)
	{
	 if ( clubsGrid.Columns.Last<GridViewColumn>() is MyButtonColumn )
	 {
	  return;
	 }
	 this.clubsGrid.Columns.Add(new MyButtonColumn() 
	 { 
	  Header = "Delete"
	 });
	}
{{endregion}}


## Using the CellTemplate of GridViewColumn

With this approach we are re-defining the template of the cells for that column. It is a simple DataTemplate which contains our button:

#### __XAML__

{{region gridview-add-button-column_3}}

	<telerik:RadGridView.Columns>
	    ...
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
{{endregion}}

# See Also

 * [Create Custom DateTimePicker Column]({%slug gridview-how-to-create-date-time-picker-column%})

 * [Create Custom Editor with RadGridView]({%slug radgridview-howto-create-custom-editor%})
