---
title: Use generic SortDescriptor
page_title: Use generic SortDescriptor
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to create generic expression SortDescriptor.
slug: gridview-sorting-generic-descriptor
tags: use,generic,sortdescriptor
published: True
position: 1
---

# Use generic SortDescriptor

This help article will show you how to create generic expression SortDescriptor&lt;T&gt; for a databound __RadGridView__. 

> This article will use the viewmodel and model defined in __Examples 3 and 4__ in the [Getting Started]({%slug gridview-getting-started2%}) article. Before continuing, you should familiarize yourself with it.

## Generic SortDescriptor

The __RadGridView__ control allows for ordering the data items by the result of a complex calculation without having to expose it through a read-only property. All you need to do is to use a __SortDescriptor&lt;TElement, TKey=&gt;__. In order to demonstrate this, we will setup the RadGridView as demonstrated in __Example 1__.

__Example 1: Setting up the RadGridView__

```XAML
	<Grid>
        <Grid.DataContext>
            <my:MyViewModel />
        </Grid.DataContext>
        <Grid.RowDefinitions>
            <RowDefinition Height="*" />
            <RowDefinition Height="Auto" />
        </Grid.RowDefinitions>

        <telerik:RadGridView Name="clubsGrid" 
                             ItemsSource="{Binding Clubs}"
                             AutoGenerateColumns="False"
                             GroupRenderMode="Flat">
            <telerik:RadGridView.Columns>
                <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"  />
                <telerik:GridViewDataColumn DataMemberBinding="{Binding StadiumCapacity}" 
                                            Header="Stadium" 
                                            DataFormatString="{}{0:N0}"/>
            </telerik:RadGridView.Columns>
        </telerik:RadGridView>

        <StackPanel Grid.Row="1">
            <Button Content="Add Generic SortDescriptor" Click="Button_Click" />
        </StackPanel>
    </Grid>
```

After that, when the button is clicked we will create a generic SortDescriptor and add it to the __SortDescriptors__ collection of the RadGridView. Note, that in __Example 2__ we are simply returning a property of the bound object, however we have the option of working with all of its properties in order to construct a SortingExpression. 

__Example 2: Create a generic SortDescriptor__

```C#
	private void Button_Click(object sender, RoutedEventArgs e)
	{
		var descriptor = new SortDescriptor<Club, int>
		{
			SortingExpression = c => c.StadiumCapacity,
			SortDirection = ListSortDirection.Descending
		};

		this.clubsGrid.SortDescriptors.Add(descriptor);
	}
```
        
> For more information you can check the [Sorting section]({%slug gridview-sorting-basics%}).
        
## See Also

 * [Use expression descriptors]({%slug gridview-howto-use-expression-descriptors%})
