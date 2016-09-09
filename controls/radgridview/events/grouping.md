---
title: Grouping events
page_title: Grouping events
description: Grouping events
slug: gridview-events-grouping
tags: grouping,events
published: True
position: 8
---

# Grouping events

There are two events that are raised, when the data in RadGridView is __grouped from the UI__.
      

* [Grouping event](#grouping-event)- it is raised before the data is grouped. 
          

* [Grouped event](#grouped-event) - it is raised when the data has been already grouped.
          

There are two events that are raised, when a user __expands/collapses a group row__ in RadGridView.
      

* [GroupRowIsExpandedChanging event](#grouprowisexpandedchanging-event) - it is raised when the data has been already grouped.
          

* [GroupRowIsExpandedChanged event](#grouprowisexpandedchanged-event) - it is raised when the data has been already grouped.
          

The code snippets below show how to subscribe for those events:

#### __XAML__

{{region xaml-gridview-events-grouping_0}}

	<telerik:RadGridView Name="clubsGrid" 
	                    ItemsSource="{Binding Clubs}"
	                    Grouping="clubsGrid_Grouping"
	                    Grouped="clubsGrid_Grouped"
	                    GroupRowIsExpandedChanged="clubsGrid_GroupRowIsExpandedChanged"
	                    GroupRowIsExpandedChanging="clubsGrid_GroupRowIsExpandedChanging">
{{endregion}}

#### __C#__

{{region cs-gridview-events-grouping_5}}

	clubsGrid.Grouping += new EventHandler<GridViewGroupingEventArgs>(clubsGrid_Grouping);
	clubsGrid.Grouped += new EventHandler<GridViewGroupedEventArgs>(clubsGrid_Grouped);
	clubsGrid.GroupRowIsExpandedChanged += new EventHandler<GroupRowEventArgs>(radGridView_GroupRowIsExpandedChanged);
	clubsGrid.GroupRowIsExpandedChanging +=new EventHandler<GroupRowCancelEventArgs>(rgv2_GroupRowIsExpandedChanging);
{{endregion}}


#### __VB.NET__

{{region vb-gridview-events-grouping_6}}

	clubsGrid.Grouping += New EventHandler(Of GridViewGroupingEventArgs)(clubsGrid_Grouping)
	clubsGrid.Grouped += New EventHandler(Of GridViewGroupedEventArgs)(clubsGrid_Grouped)
	clubsGrid.GroupRowIsExpandedChanged += New EventHandler(Of GroupRowEventArgs)(radGridView_GroupRowIsExpandedChanged)
	clubsGrid.GroupRowIsExpandedChanging += New EventHandler(Of GroupRowCancelEventArgs)(rgv2_GroupRowIsExpandedChanging)
{{endregion}}


## Grouping event

Via the __Telerik.Windows.Controls.GridViewGroupingEventArgs__ of the __Grouping__ event you can get the:

* __GroupDescriptor__ that defines the group to be added. It is of type IGroupDescriptor and you can cast it to __ColumnGroupDescriptor__ if the grouping is done from the UI or to __GroupDescriptor__ if you have added a GroupDescriptor to the GroupDescriptors collection of the gridview (this was the legacy way). From the __ColumnGroupDescriptor__ you can access: 

* __Column__ - the column the group is performed against

* __SortDirection__ - either ascending or descending

* __DisplayContent__ - the display content

* __Index__ of the descriptor in the __GroupDescriptors__ collection

* __Action__ to be performed on the __GroupDescriptor__. The actions could be:
            

* __Place__ - the group descriptor is added to the GroupDescriptors collection (the user grouped by the column).

* __Move__ - the group descriptor is being moved to another index in the GroupDescriptors collection (the user rearranged the grouped columns).

* __Remove__ - the group descriptor is removed from the GroupDescriptors collection (the user ungrouped the column)

* __Sort__ - the user has sorted the grouped column by clicking on the rectangle in the group panel

* __Cancel__ - if you set it to True, the grouping is not performed.
              

For example, you can use the __Grouping__ event to prevent the user from adding more than one group.

#### __C#__

{{region cs-gridview-events-grouping_1}}
	
	private void clubsGrid_Grouping(object sender, GridViewGroupingEventArgs e)
	{
	 if (e.Action == GroupingEventAction.Place && e.Index > 0)
	 {
	  e.Cancel = true;
	 }
	}
	    
{{endregion}}


#### __VB.NET__

{{region vb-gridview-events-grouping_2}}
	
	Private Sub clubsGrid_Grouping(sender As Object, e As GridViewGroupingEventArgs)
	 If e.Action = GroupingEventAction.Place AndAlso e.Index > 0 Then
	  e.Cancel = True
	 End If
	End Sub
{{endregion}}


## Grouped event

The __Grouped__ event is raised when the data has already been grouped. All the additional actions performed on the group (for example sorting or removing it) will also raise the event with the relevant GridViewGroupedEventArgs.__Action__.
        

Via the __GridViewGroupedEventArgs__ arguments you can get the:

* __GroupDescriptor__ that has been manipulated. It is of type IGroupDescriptor and you can cast it to __ColumnGroupDescriptor__ if the grouping is done from the UI or to __GroupDescriptor__ if you have added a GroupDescriptor to the GroupDescriptors collection of the gridview (this was the legacy way). From the __ColumnGroupDescriptor__ you can access:  


* __Column__ - the column the group is performed against

* __SortDirection__ - either ascending or descending

* __DisplayContent -__the display content____

* __Action__ performed on it. The actions could be:
            

* __Place__ - the group descriptor is added to the GroupDescriptors collection (the user grouped by the column).
            

* __Move__ - the group descriptor is being moved to another index in the GroupDescriptors collection (the user rearranged the grouped columns).
            

* __Remove__ - the group descriptor is removed from the GroupDescriptors collection (the user ungrouped the column)
            

* __Sort__ - the user has sorted the grouped column by clicking on the rectangle in the group panel
            

For example, you can use the __Grouped__ event to get the column that is grouped by.
        

#### __C#__

{{region cs-gridview-events-grouping_3}}
	
	private void clubsGrid_Grouped(object sender, GridViewGroupedEventArgs e)
	{
	    GridViewDataColumn column = ((Telerik.Windows.Controls.GridView.ColumnGroupDescriptor)(e.GroupDescriptor)).Column as GridViewDataColumn;
	    MessageBox.Show("The GridView was grouped by column: "+ column.Header.ToString());
	}
{{endregion}}

#### __VB.NET__

{{region vb-gridview-events-grouping_4}}
	
	    Private Sub clubsGrid_Grouped(sender As Object, e As GridViewGroupedEventArgs)
	        Dim column As GridViewDataColumn = TryCast(DirectCast(e.GroupDescriptor, Telerik.Windows.Controls.GridView.ColumnGroupDescriptor).Column, GridViewDataColumn)
	        MessageBox.Show("The GridView was grouped by column: " + column.Header.ToString())
	    End Sub
{{endregion}}


## GroupRowIsExpandedChanging event

The __GroupRowIsExpandedChanging__ event is raised when the user expands a group row.
        

Via the __GroupRowCancelEventArgs__ arguments you can __Cancel__ the action of expanding the group row. You can also get the __GridViewGroupRow (e.Row)__ you have just expanded.
        

For example, you can use the __GroupRowIsExpandedChanging__ event like so.
        

#### __C#__

{{region cs-gridview-events-grouping_7}}

	void clubsGrid_GroupRowIsExpandedChanging(object sender, Telerik.Windows.Controls.GridView.GroupRowCancelEventArgs e)
	{
	    e.Cancel = true;
	}
{{endregion}}


#### __VB.NET__

{{region vb-gridview-events-grouping_8}}

    Private Sub clubsGrid_GroupRowIsExpandedChanging(sender As Object, e As Telerik.Windows.Controls.GridView.GroupRowCancelEventArgs)
        e.Cancel = True
    End Sub
{{endregion}}


## GroupRowIsExpandedChanged event

The __GroupRowIsExpandedChanged__ event is raised when the user expands a group row.
        

Via the __GroupRowEventArgs__ arguments you can get the __GridViewGroupRow (e.Row)__ you have just expanded.
        

For example, you can use the __GroupRowIsExpandedChanged__ event to get the expanded group row and set a different Background for it.
        

#### __C#__

{{region cs-gridview-events-grouping_9}}

	void clubsGrid_GroupRowIsExpandedChanged(object sender, Telerik.Windows.Controls.GridView.GroupRowEventArgs e)
	{
	    GridViewGroupRow expandedGroup = e.Row as GridViewGroupRow;
	    if (expandedGroup.IsExpanded)
	    {
	        expandedGroup.Background = new SolidColorBrush(Colors.Red);
	    }
	    else
	    {
	        expandedGroup.Background = new SolidColorBrush(Colors.Green);
	    }
	}
{{endregion}}


#### __VB.NET__

{{region vb-gridview-events-grouping_10}}

    Private Sub clubsGrid_GroupRowIsExpandedChanged(sender As Object, e As Telerik.Windows.Controls.GridView.GroupRowEventArgs)
        Dim expandedGroup As GridViewGroupRow = TryCast(e.Row, GridViewGroupRow)
        If expandedGroup.IsExpanded Then
            expandedGroup.Background = New SolidColorBrush(Colors.Red)
        Else
            expandedGroup.Background = New SolidColorBrush(Colors.Green)
        End If
    End Sub
{{endregion}}


# See Also

 * [Programmatic Grouping]({%slug gridview-programmatic-grouping%})

 * [Multiple-column Grouping]({%slug gridview-multiple-column-grouping%})

 * [Group Aggregates]({%slug gridview-grouping-aggregates%})

 * [Group Footers]({%slug gridview-group-footers%})

 * [Modifying the Group Panel]({%slug gridview-modifying-group-panel%})
