---
title: UI freeze with deep nested grouping
page_title: UI freeze with deep nested grouping
description: Learn how to troubleshoot a slow response or freeze of the UI when grouping by a number of columns within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-troubleshooting-nested-grouping
tags: ui,freeze,with,deep,nested,grouping
published: False
position: 9
---

# {{ site.framework_name }} RadGridView UI freeze with deep nested grouping

__PROBLEM__

When the RadGridView is bound to a large data and you group by a number of columns (e.g. 6 or more columns) you might experience a slow response or freeze of the UI.

__SOLUTION__

Until we find a decent solution please use the following workaround:

Subscribe to the __Grouping__ event and define its handler as below:

#### __C#__

{{region cs-gridview-troubleshooting-nested-grouping_0}}
	private void RadGridView1_Grouping(object sender, GridViewGroupingEventArgs e)
	{
	    Dispatcher.BeginInvoke((Action)(() =>
	    {
	        this.RadGridView1.CurrentItem = null;
	    }));
	}
{{endregion}}

#### __VB.NET__

{{region vb-gridview-troubleshooting-nested-grouping_1}}
	Private Sub RadGridView1_Grouping(ByVal sender As Object, ByVal e As GridViewGroupingEventArgs)
	    Dispatcher.BeginInvoke(CType(Sub()
	                                     Me.RadGridView1.CurrentItem = Nothing
	                                 End Sub, Action))
	End Sub
{{endregion}}


