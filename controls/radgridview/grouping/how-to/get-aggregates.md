---
title: Get aggregates from a group
page_title: Get aggregates from a group
description: Get aggregates from a group
slug: gridview-grouping-how-to-get-aggregates
tags: get,aggregates,from,a,group
published: True
position: 0
---

# Get aggregates from a group

__This article shows how to obtain aggregates from a specific group in RadGridView.__

In some cases when you define aggregates in RadGridView you need to access aggregates in a specific group. You may do this very easily through iterating over the groups in RadGridView check for a specific group key value and get the aggregate result as shown below:

#### __C#__

{{region cs-gridview-grouping-how-to-get-aggregates_0}}
	private void Button1_Click(object sender, RoutedEventArgs e)
	{
	    foreach (QueryableCollectionViewGroup item in this.radGridView.Items.Groups)
	    {
	        if (item.Key.Equals("24"))
	        {
	            MessageBox.Show(item.AggregateResults[0].FormattedValue.ToString());
	        }
	    }
	}
{{endregion}}

#### __VB.NET__

{{region vb-gridview-grouping-how-to-get-aggregates_1}}
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
	    For Each item As QueryableCollectionViewGroup In Me.radGridView.Items.Groups
	        If (item.Key.Equals("24")) Then
	            MessageBox.Show(item.AggregateResults(0).FormattedValue.ToString())
	        End If
	    Next
	End Sub
{{endregion}}

The __QueryableCollectionViewGroup__ class represents a wrapper over an __AggregateFunctionsGroup__ that allows adding and removing of child items/groups.  The snippet above simply checks for a key value equal to 24 and gets the formatted value of the first aggregate result.
        
