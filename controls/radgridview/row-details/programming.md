---
title: Events
page_title: Row Details Events
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn more about the events exposed by the control regarding the Row Details. 
slug: radgridview-row-details-programming
tags: events
published: True
position: 4
---

# Row Details Events

* [Setting the Background of the DetailsPresenter](#setting-the-background-of-the-detailspresenter)
* [Accessing the Expanded Item](#accessing-the-expanded-item)

__RadGridView__ control exposes several events regarding the __RowDetails__:

>tip More about the events that the __RadGridView__ exposes, can be found [here]({%slug gridview-events-overview%}).

* __LoadingRowDetails__: The event is raised immediately after the __FrameworkElement__ has been loaded from the __Row Details DataTemplate__. It is raised the __very first time__ the row details are about to be shown. Once this event has been fired, it will never fire again for that row. However, if the row is recycled and then realized, it starts its "life" again, this event will be fired again the first time the details are about to be shown.

## Setting the Background of the DetailsPresenter

The __GridViewRowDetailsEventArgs__ provide access to the __FrameworkElement__ that has been just loaded (__DetailsElement__) as well as to the respective __GridViewRow(Row)__. Use this event if you want to modify the __FrameworkElement__ in any way before it is displayed.

For example, if you have a __RadGridView__ with the following __RowDetailsTemplate__:

__Example 1: Defining the RowDetailsTemplate__

```XAML
	<telerik:RadGridView x:Name="radGridView"
	                LoadingRowDetails="radGridView_LoadingRowDetails">
	    <telerik:RadGridView.RowDetailsTemplate>
	        <DataTemplate>
	            <StackPanel Orientation="Horizontal">
	                <TextBlock Text="City: " />
	                <TextBlock Text="{Binding City}" />
	            </StackPanel>
	        </DataTemplate>
	    </telerik:RadGridView.RowDetailsTemplate>
	    <!--...-->
	</telerik:RadGridView>
```

You can change the __StackPanel's Background__ depending on is the row alternating:

__Example 2: Setting the Background of the DetailsElement__

```C#
	private void radGridView_LoadingRowDetails(object sender, GridViewRowDetailsEventArgs e)
	{
	    StackPanel element = e.DetailsElement as StackPanel;
	    if (e.Row.IsAlternating)
	    {
	        element.Background = new SolidColorBrush(Colors.Black);
	    }
	    else
	    {
	        element.Background = new SolidColorBrush(Colors.White);
	    }
	}
```
```VB.NET
	Private Sub radGridView_LoadingRowDetails(ByVal sender As Object, ByVal e As GridViewRowDetailsEventArgs)
	    Dim element As StackPanel = TryCast(e.DetailsElement, StackPanel)
	
	    If e.Row.IsAlternating Then
	        element.Background = New SolidColorBrush(Colors.Black)
	    Else
	        element.Background = New SolidColorBrush(Colors.White)
	    End If
	End Sub
```

## Accessing the Expanded Item

The event arguments expose the __Row__ property through which the parent item of the details can be fetched.

__Example 3: Accessing the expanded item__

```C#
	private void clubsGrid_LoadingRowDetails(object sender, 
            Telerik.Windows.Controls.GridView.GridViewRowDetailsEventArgs e)
        {
            var club = e.Row.DataContext as Club;
        }
```
```VB.NET
	Private Sub clubsGrid_LoadingRowDetails(ByVal sender As Object, 
			ByVal e As Telerik.Windows.Controls.GridView.GridViewRowDetailsEventArgs)
    		Dim club = TryCast(e.Row.DataContext, Club)
	End Sub	
```

* __UnloadingRowDetails__: When the __Row Details DataTemplate__ is modified or deleted, the __UnloadingRowDetails__ event is raised in case you need to perform some cleanup for the old template before the new one is loaded.

* __RowDetailsVisiblityChanged__: This event is fired each time the row details are shown or hidden, i.e. by selecting or deselecting the row. Via the __GridViewRowDetailsEventArgs__ you could access the just loaded __DetailsElement__, the respective __GridViewRow__ (Row) as well as the __Visibility__ of the row details. 

>tip To manually change the visibility of a row - set its __DetailsVisibility__ property to either Visibility.Collapsed or Visibility.Visible

## See Also

 * [RowDetails Overview]({%slug radgridview-row-details-overview%})

 * [Toggle RowDetails Column]({%slug radgridview-columns-column-types-toggle-rowdetails-column%})

 * [Row Details TemplateSelector]({%slug radgridview-row-details-templateselector%})

 * [External Row Details]({%slug radgridview-row-details-external-row-details%})

 * [Row Details Template]({%slug radgridview-row-details-template%})
