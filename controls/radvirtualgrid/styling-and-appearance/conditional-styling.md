---
title: Conditional Styling
page_title: Conditional Styling
description: Check our &quot;Conditional Styling&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-conditional-styling
tags: conditional,styling
published: True
position: 1
---

# {{ site.framework_name }} RadVirtualGrid Conditional Styling

This topic will demonstrate how the cells of `RadVirtualGrid` can be styled conditionally.

This is achieved through the usage of the following three events in conjunction.

* `OverlayBrushesNeeded`&mdash;The event arguments expose a `Brushes` collection which can be populated with the Brushes that will be conditionally applied further. When they are preliminarily known, the respective Geometry can be easily drawn at once, instead of applying a style for each cell individually. Thus, the rendering performance of the control is kept unaffected.

#### __[C#] Adding Brushes through the OverlayBrushesNeeded event__

{{region cs-radvirtualgrid-styling_conditionalstyling_0}}
	private void VirtualGrid_OverlayBrushesNeeded(object sender, 
            Telerik.Windows.Controls.VirtualGrid.OverlayBrushesEventArgs e)
        {
            e.Brushes.Add(Brushes.Red);
            e.Brushes.Add(Brushes.Yellow);
        }
{{endregion}}

* `CellDecorationsNeeded`&mdash;This is the event through which the actual styling of the cells can be applied. The event arguments expose the following properties:

	- `Background`&mdash;Its value must be set to be one of the Brushes provided by the `Brushes` collection populated through the `OverlayBrushesNeeded` event.
	- `ColumnIndex`&mdash;The column the given cell corresponds to.
	- `RowIndex`&mdash;The row the given cell corresponds to.
	- `FontFamily`&mdash;Sets the FontFamily of the cell.
	- `FontSize`&mdash;Sets the FontSize of the cell.
    - `FontStyle`&mdash;Sets the FontStyle of the cell.
    - `FontWeight`&mdash;Sets the FontWeight of the cell.
	- `Foreground`&mdash;Sets the Brush for the Foreground of the cell.
	- `CellTextAlignment`&mdash;Sets the cell's text alignment.

#### __[C#] Applying conditional styling through the CellDecorationsNeeded event__

{{region cs-radvirtualgrid-styling_conditionalstyling_1}}
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
                e.CellTextAlignment = TextAlignment.Right;
            }
        }
{{endregion}}

>For the effects of the `CellTextAlignment` property to be applied, the control's [MeasureTextOnRender]({%slug virtualgrid-getting-started2%}#measuretextonrender) property has to be set to `True`.

__RadVirtualGrid with conditional styling applied__

![RadVirtualGrid with conditional styling applied](images/RadVirtualGrid_Styling_02.png)

* `HeaderCellDecorationsNeeded`&mdash;This event allows for the styling of the header cells. Its event arguments are the same as the ones for the `CellDecorationsNeeded` event.

## See also

* [Styling and Appearance]({%slug virtualgrid-styling-and-appearance%})
