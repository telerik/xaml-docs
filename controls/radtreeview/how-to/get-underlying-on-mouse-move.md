---
title: Get the Underlying TreeView Item on MouseMove
page_title: Get the Underlying TreeView Item on MouseMove
description: Get the Underlying TreeView Item on MouseMove
slug: radtreeview-how-to-get-underlying-on-mouse-move
tags: get,the,underlying,treeview,item,on,mousemove
published: False
position: 6
---

# Get the Underlying TreeView Item on MouseMove



## 

If you want to get the underlying item when you move your mouse over the treeview, you need to do the following steps:

1. First, you need to attach to the __MouseMove__event of the __RadTreeView__: 

#### __XAML__

{{region radtreeview-how-to-get-underlying-on-mouse-move_0}}
	<telerik:RadTreeView x:Name="radTreeView" MouseMove="radTreeView_MouseMove">
	{{endregion}}



2. Second, in the code-behind you need to add the following code: 

#### __C#__

{{region radtreeview-how-to-get-underlying-on-mouse-move_1}}
	private void radTreeView_MouseMove( object sender, MouseEventArgs e )
	{
	     FrameworkElement element = e.OriginalSource as FrameworkElement;
	     if ( element != null )
	     {
	         while ( VisualTreeHelper.GetParent( element ) != null )
	         {
	             element = VisualTreeHelper.GetParent( element ) as FrameworkElement;
	             RadTreeViewItem item = element as RadTreeViewItem;
	             if ( item != null )
	             {
	                 // Perform custom logic here
	                 // You have to return here because otherwise the method will traverse
	                 // the whole visual tree on every mouse move and there will be performance
	                 // implications
	                 return;
	             }
	         }
	     }
	}
	{{endregion}}



#### __VB.NET__

{{region radtreeview-how-to-get-underlying-on-mouse-move_2}}
	Private Sub radTreeView_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
	    Dim element As FrameworkElement = TryCast(e.OriginalSource, FrameworkElement)
	    If element IsNot Nothing Then
	        While VisualTreeHelper.GetParent(element) IsNot Nothing
	            element = TryCast(VisualTreeHelper.GetParent(element), FrameworkElement)
	            Dim item As RadTreeViewItem = TryCast(element, RadTreeViewItem)
	            If item IsNot Nothing Then
	
	                    ' Perform custom logic here
	
	                    ' You have to return here because otherwise the method will traverse
	                    ' the whole visual tree on every mouse move and there will be performance
	                    ' implications
	                Exit Sub
	            End If
	        End While
	    End If
	End Sub
	{{endregion}}



>When you perform your custom logic, you have to return from the method because otherwise the method will traverse the whole visual tree on every mouse move and there will be performance implications.

# See Also

 * [Get Item by Path]({%slug radtreeview-how-to-get-item-by-path%})

 * [Implement Drag and Drop Between TreeView and ListBox]({%slug radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox%})

 * [Disable Drop at Specific Location]({%slug radtreeview-how-to-disable-drop-specific-location%})
