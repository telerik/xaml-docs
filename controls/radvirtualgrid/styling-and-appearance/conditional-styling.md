---
title: Conditional Styling
page_title: Conditional Styling
description: Conditional Styling
slug: virtualgrid-conditional-styling
tags: conditional,styling
published: True
position: 1
---

# Conditional Styling

This topic will demonstrate how the cells of __RadVirtualGrid__ can be styled conditionally.

This is achieved through the usage of the following two events in conjunction.

* __OverlayBrushesNeeded__: The event arguments expose a __Brushes__ collection which can be populated with the Brushes that will be conditionally applied further. When they are preliminarily known, the respective Geometry can be easily drawn at once, instead of applying a style for each cell individually. Thus, the rendering performance of the control is kept unaffected.

#### __[C#] Example 1: Adding Brushes to through the OverlayBrushesNeeded event__

{{region radvirtualgrid-styling_conditionalstyling_0}}
	private void VirtualGrid_OverlayBrushesNeeded(object sender, 
            Telerik.Windows.Controls.VirtualGrid.OverlayBrushesEventArgs e)
        {
            e.Brushes.Add(Brushes.Red);
            e.Brushes.Add(Brushes.Yellow);
        }
{{endregion}}

* __CellDecorationsNeeded__: This is the event through which the actual styling of the cells can be applied. The event arguments expose the following properties:

	- __Background__: Its value must be set to be one of the Brushes provided by the __Brushesh__ collection populated through the __OverlayBrushesNeeded__ event
	- __ColumnIndex__: The column the given cell corresponds to
	- __RowIndex__: The row the given cell corresponds to
	- __FontFamily__: Sets the FontFamily of the cell
	- __FontSize__: Sets the FontSize of the cell
	- __Foreground__: Sets the Brush for the Foreground of the cell

#### __[C#] Applying conditional styling through the CellDecorationsNeeded event__

{{region radvirtualgrid-styling_conditionalstyling_1}}
	private void VirtualGrid_CellDecorationsNeeded(object sender, 
            Telerik.Windows.Controls.VirtualGrid.CellDecorationEventArgs e)
        {
            if (e.ColumnIndex % 2 == 0)
            {
                e.Background = Brushes.Red;
            }
            else
            {
                e.Background = Brushes.Yellow;
                e.Foreground = Brushes.Red;
                e.FontSize = 18;
            }
        }
{{endregion}}

#### __Figure 1: RadVirtualGrid with conditional styling applied__

![](images/RadVirtualGrid_Styling_02.png)

## See also

* [Styling and Appearance]({%slug virtualgrid-styling-and-appearance%})


