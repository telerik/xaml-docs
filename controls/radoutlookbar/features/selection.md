---
title: Selection
page_title: Selection
description: Selection
slug: radoutlookbar-selection
tags: selection
published: True
position: 0
---

# Selection

## Handling selection changes

To handle changes in the selection you can use the __SelectionChanged__ event: 

#### __XAML__
{{region radoutlookbar-selection_0}}
	<telerik:RadOutlookBar x:Name="RadOutlookBar1" 
	                       PreviewSelectionChanged="RadOutlookBar1_PreviewSelectionChanged"
	                       SelectionChanged="RadOutlookBar1_SelectionChanged">
	    <telerik:RadOutlookBarItem Header="Item 1" Icon="Letter.png">
	        <TextBlock Text="Item 1 Content" />
	    </telerik:RadOutlookBarItem>
	    <telerik:RadOutlookBarItem Header="Item 2" 
	                               Icon="Letter.png"
	                               IsSelected="True">
	        <TextBlock Text="Item 2 Content" />
	    </telerik:RadOutlookBarItem>
	    <telerik:RadOutlookBarItem Header="Item 3" Icon="Letter.png">
	        <TextBlock Text="Item 3 Content" />
	    </telerik:RadOutlookBarItem>
	</telerik:RadOutlookBar>
{{endregion}}

#### __C#__
{{region radoutlookbar-selection_0}}
	private void RadOutlookBar1_SelectionChanged(object sender, RoutedEventArgs e)
	{
		RadOutlookBarItem newSelectedItem = (sender as
		RadOutlookBar).SelectedItem as RadOutlookBarItem;
	}
	private void RadOutlookBar1_PreviewSelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
	{
		//use the Handled property to prevent the selection           
	}
{{endregion}}

#### __VB.NET__
{{region radoutlookbar-selection_0}}
	Private Sub RadOutlookBar1_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Dim newSelectedItem As RadOutlookBarItem = TryCast(TryCast(sender, RadOutlookBar).SelectedItem, RadOutlookBarItem)
	End Sub
	Private Sub RadOutlookBar1_PreviewSelectionChanged(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.SelectionChangedEventArgs)
		'use the Handled property to prevent the selection'
	End Sub
{{endregion}}

## Setting selected item

You can set the selected item by using its __IsSelected__ property:
        
#### __XAML__
{{region radoutlookbar-selection_1}}
	<telerik:RadOutlookBar x:Name="RadOutlookBar1">
	    <telerik:RadOutlookBarItem Header="Item 1" Icon="Letter.png">
	        <TextBlock Text="Item 1 Content" />
	    </telerik:RadOutlookBarItem>
	    <telerik:RadOutlookBarItem Header="Item 2" 
	                               Icon="Letter.png"
	                               IsSelected="True">
	        <TextBlock Text="Item 2 Content" />
	    </telerik:RadOutlookBarItem>
	    <telerik:RadOutlookBarItem Header="Item 3" Icon="Letter.png">
	        <TextBlock Text="Item 3 Content" />
	    </telerik:RadOutlookBarItem>
	</telerik:RadOutlookBar>
{{endregion}}

## Properties

The following properties are related to the selection mechanism of the __RadOutlookBar__:        

* __SelectedItem__ - get or set the selected item

* __SelectedIndex__ - get the index of selected item

* __SelectedContent__ - get the selected content

There are also the following properties related to the styling of the selected content and item:

* __SelectedContentTemplate__ - template for the selected content.

* __SelectedContentTemplateSelector__ - template selector for the selected content

# See Also
 * [Getting Started]({%slug radoutlookbar-getting-started%})
 * [Visual Structure]({%slug radoutlookbar-visual-structure%})