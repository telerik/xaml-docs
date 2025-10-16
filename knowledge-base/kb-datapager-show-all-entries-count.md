---
title: Show the Total Count of Items in RadDataPager.
page_title: Show the Count of All Items in RadDataPager.
description: This article demonstrates how to show the total count of the items in RadDataPager and RadGridView scenario.
type: how-to
slug: kb-datapager-show-all-entries-count
position: 0
tags: raddatapager, radgridview, total count
ticketid: 1583246
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2022.3.912</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadDataPager for WPF</td>
	</tr>
</table>

## Description

How to show the total count of all items in the RadDataPager control in a RadGridView scenario.

## Solution

1. Subscribe to the `Loaded` event of the `RadDataPager` control and retrieve the first `Grid` panel using the [ChildrenOfType]({%slug common-visual-tree-helpers%}#childrenoftypeextensions) extension method.

2. Add a new `ColumnDefinition` with `Width` set to `Auto`, to the `ColumnDefinitions` property if the retrieved Grid panel.

3. Move the last child element of the Grid panel to the newly added ColumnDefinition using the `Grid.SetColumn` method.

4. Create a new element to display the total count of the entries and bind it to the `TotalItemCount` property of the `ItemsSource` property of `RadGridView` instance.

5. Set the newly added element to the second column via the Grid.SetColumn method and add it to the `Children` collection of the Grid panel.

__Sample implementation__
```C#
    private void RadDataPager_Loaded(object sender, RoutedEventArgs e)
    {
        RadDataPager radDataPager = (RadDataPager)sender;

        //Retrieve the Grid panel
        Grid gridPanel = radDataPager.ChildrenOfType<Grid>().FirstOrDefault();

        if (gridPanel != null)
        {
            //Include an additional ColumnDefinition to the ColumnDefinitions of the Grid panel and set its     Width to Auto
            gridPanel.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(0, GridUnitType.    Auto) });
            //Change the Grid.Column attached property for the element that holds the current page  information
            Grid.SetColumn(gridPanel.Children[1], 2);

            //A StackPanel that will hold the total entries information (Different panel can be used if     needed)
            StackPanel totalInfoPanel = new StackPanel()
            {
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Center,
            };

            Grid.SetColumn(totalInfoPanel, 1);

            TextBlock text = new TextBlock() { Text = "Total entries:", Margin = new Thickness(0, 0, 3, 0) };
            TextBlock totalText = new TextBlock();

            //Bind the ItemsSource.TotalItemCount property of the RadGridView instance to the Text property     of the created TextBlock
            BindingOperations.SetBinding(totalText, TextBlock.TextProperty, new Binding("ItemsSource.   TotalItemCount") { ElementName = "gridView" });

            totalInfoPanel.Children.Add(text);
            totalInfoPanel.Children.Add(totalText);

            //Add the created StackPanel to the Grid panel
            gridPanel.Children.Add(totalInfoPanel);
        }
    }
```
```VB.NET
    Private Sub RadDataPager_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim radDataPager As RadDataPager = CType(sender, RadDataPager)
        Dim gridPanel As Grid = radDataPager.ChildrenOfType(Of Grid)().FirstOrDefault()
    
        If gridPanel IsNot Nothing Then
            gridPanel.ColumnDefinitions.Add(New ColumnDefinition() With {
                .Width = New GridLength(0, GridUnitType.Auto)
            })
            Grid.SetColumn(gridPanel.Children(1), 2)
            Dim totalInfoPanel As StackPanel = New StackPanel() With {
                .Orientation = Orientation.Horizontal,
                .HorizontalAlignment = HorizontalAlignment.Right,
                .VerticalAlignment = VerticalAlignment.Center
            }
            Grid.SetColumn(totalInfoPanel, 1)
            Dim text As TextBlock = New TextBlock() With {
                .Text = "Total entries:",
                .Margin = New Thickness(0, 0, 3, 0)
            }
            Dim totalText As TextBlock = New TextBlock()
            BindingOperations.SetBinding(totalText, TextBlock.TextProperty, New Binding("ItemsSource.       TotalItemCount") With {
                .ElementName = "gridView"
            })
            totalInfoPanel.Children.Add(text)
            totalInfoPanel.Children.Add(totalText)
            gridPanel.Children.Add(totalInfoPanel)
        End If
    End Sub
```

__RadDataPager displaying the total items count__

![{{ site.framework_name }} RadDataPager Displaying the Total Items Count](images/kb-datapager-show-total-entries-count.png)