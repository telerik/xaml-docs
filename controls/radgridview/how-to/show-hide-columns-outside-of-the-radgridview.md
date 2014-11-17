---
title: Show/Hide Columns outside of the RadGridView
page_title: Show/Hide Columns outside of the RadGridView
description: Show/Hide Columns outside of the RadGridView
slug: radgridview-how-to-show-hide-columns-outside-of-the-radgridview
tags: show/hide,columns,outside,of,the,radgridview
published: True
position: 2
---

# Show/Hide Columns outside of the RadGridView


This topic will show you how to choose which columns to be visible from outside of __RadGridView__. 
The example will represent a __ListBox__ and __RadGridView__. The __ListBox__ will list the available columns for __RadGridView__ and each of the items in this list will have a check box for determining the visibility of the column.

Here are the definitions of the __ListBox__ and __RadGridView__.

#### __XAML__

{{region radgridview-how-to-show-hide-columns-outside-of-the-radgridview_0}}

	<Grid Background="White">
	    <Grid.ColumnDefinitions>
	        <ColumnDefinition Width="150"/>
	        <ColumnDefinition Width="*"/>
	    </Grid.ColumnDefinitions>
	    <ListBox />
	    <telerik:RadGridView x:Name="radGridView"
	                         Grid.Column="1"
	                         Margin="10,0,0,0" />
	 </Grid>
{{endregion}}

Next bind the __ItemsSource__ property of the __ListBox__ to the __Columns__ property of __RadGridView__ via Element Binding.

#### __XAML__

{{region radgridview-how-to-show-hide-columns-outside-of-the-radgridview_1}}

	<Grid Background="White">
	    <Grid.ColumnDefinitions>
	        <ColumnDefinition Width="150"/>
	        <ColumnDefinition Width="*"/>
	    </Grid.ColumnDefinitions>
	    <ListBox ItemsSource="{Binding Columns, ElementName=radGridView}" />
	    <telerik:RadGridView x:Name="radGridView"
	                         Grid.Column="1" 
	                         Margin="10,0,0,0" />
	</Grid>
{{endregion}}

After that define the __DataTemplate__ for the __ItemTemplate__ property of the ListBox. It should include a __CheckBox__and as the __DataContext__ of the item will be a __GridViewColumn__, you can bind the __IsChecked__ property of the __CheckBox__ to the __IsVisible__ property of the column using a __TwoWay__ Data Binding.

#### __XAML__

{{region radgridview-how-to-show-hide-columns-outside-of-the-radgridview_2}}

	<Grid Background="White">
	    <Grid.ColumnDefinitions>
	        <ColumnDefinition Width="150"/>
	        <ColumnDefinition Width="*"/>
	    </Grid.ColumnDefinitions>
	    <ListBox ItemsSource="{Binding Columns, ElementName=radGridView}">
	        <ListBox.ItemTemplate>
	            <DataTemplate>
	                <CheckBox Content="{Binding Header}"
	                          IsChecked="{Binding IsVisible, Mode=TwoWay}" />
	            </DataTemplate>
	        </ListBox.ItemTemplate>
	    </ListBox>
	    <telerik:RadGridView x:Name="radGridView"
	                         Grid.Column="1" 
	                         Margin="10,0,0,0" />
	</Grid>
{{endregion}}

Provide __RadGridView__ with an appropriate data source and run your application. The result should be similar to this snapshot:

![Rad Grid View radgridview how to column chooser 2](images/RadGridView_radgridview_how_to_column_chooser_2.png)

>tipYou can download a runnable project of the previous example from our online SDK repository [here](https://github.com/telerik/xaml-sdk/), the example is listed as __GridView__ / __ColumnChooser__  .
          
