---
title: Scroll Selected in Code Item to top of RadGridView   
description: How to bring programmatically selected row to top.
type: how-to
page_title: Bring selected object in code to the top 
slug: kb-gridview-howto-scroll-selected-item-into-view
position: 1
tags: scroll, selected, item, bring, top
ticketid: 1107805
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGridView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to scroll a programmatically selected item to the top.

## Solution

Create an attached behavior that handles the __SelectionChanged__ event of the RadGridView. Access the GridViewsScrollViewer element using the [ChildrenOfType]({%slug common-visual-tree-helpers%}#childrenoftypeextensions) extesion method. Using its __VerticalOffset__ and __ViewportHeight__ properties determine whether the SelectedItem is within the viewport. If it is not, the selection was made from code and you can use the __ScrollToVerticalOffset__ method in order to scroll the selected item to the top of the RadGridView.


```C#
    public class RadGridView_ScrollSelectedIntoViewBehaviour
    {
        public static readonly DependencyProperty ScrollSelectedIntoViewProperty =
            DependencyProperty.Register("ScrollSelectedIntoView", typeof(bool), typeof(RadGridView), new FrameworkPropertyMetadata(ScrollSelectedIntoViewPropertyChanged));

        public static bool GetScrollSelectedIntoView(DependencyObject obj)
        {
            return (bool)obj.GetValue(ScrollSelectedIntoViewProperty);
        }

        public static void SetScrollSelectedIntoView(DependencyObject obj, bool value)
        {
            obj.SetValue(ScrollSelectedIntoViewProperty, value);
        }

        private static void ScrollSelectedIntoViewPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            RadGridView grid = d as RadGridView;
            var shouldScrollSelectedItemIntoView = (bool)e.NewValue;
            if (grid != null && shouldScrollSelectedItemIntoView)
            {
                grid.SelectionChanged += Grid_SelectionChanged;
            }
        }

        private static void Grid_SelectionChanged(object sender, SelectionChangeEventArgs e)
        {
            RadGridView grid = sender as RadGridView;

            object selectedItem = grid.SelectedItem;

            if (selectedItem != null)
            {
                var scrollOffset = grid.Items.IndexOf(selectedItem) * grid.RowHeight;
                var scrollViewer = grid.ChildrenOfType<GridViewScrollViewer>().First();
                var verticalOffset = scrollViewer.VerticalOffset;
                var viewportHeight = scrollViewer.ViewportHeight;

                if (scrollOffset < verticalOffset || scrollOffset > (verticalOffset + viewportHeight))
                {
                    scrollViewer.ScrollToVerticalOffset(scrollOffset);
                }
            }
        }
    }
```



```XAML
    <telerik:RadGridView local:RadGridView_ScrollSelectedIntoViewBehaviour.ScrollSelectedIntoView="True" />
```

> Note, that the namespace "local" refers to the namespace where the RadGridView_ScrollSelectedIntoViewBehaviour class is defined.

## See Also

* [Scroll to Newly Added Item]({%slug gridview-how-to-scroll-to-newly-added-item%})