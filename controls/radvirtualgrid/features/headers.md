---
title: Headers
page_title: Headers
description: Check our &quot;Headers&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-headers
tags: headers
published: True
position: 5
---

# Headers

__RadVirtualGrid__ has __Header__ elements for both its rows and columns. A more detailed look over the visual elements of the control can be found in the [Styling and Appearance]({%slug virtualgrid-styling-and-appearance%}) topic. The API of the control provides the __HeaderValueNeeded__ and __HeaderSizeNeeded__ events for setting the values and size of its headers. The properties that the event arguments expose are listed below.

## HeaderValueNeeded

>important If the default __DataProvider__ is used for populating the control with data, it handles the __HeaderValueNeeded__ event. In order the default behavior to be altered, a [Custom Data Provider]({%slug virtualgrid-custom-dataprovider%}) can be utilized.

* __HeaderOrientation__: Enumeration which has two values: __Horizontal__ and __Vertical__. If the HeaderOrientation is Horizontal, the event is thrown for a Row Header, whereas if it is Vertical, it is thrown for a Column Header.

* __Index__: Provides information regarding the index of the Header.

* __Value__: The actual value to be applied to the Header.

## HeaderSizeNeeded

* __HeaderOrientation__: Enumeration similar to the one provided from the event arguments of the __HeaderValueNeeded__ event.

* __Index__: Provides information regarding the index of the Header.

* __Size__: Sets the width or height of the header depending on the value of the __HeaderOrientation__ property.

* __SizeUnit__: An enumeration that provides two values - __Pixel__ and __Star__. The first one sets a precise pixel size, whereas the second one applies a relative size for the header.

__Example 1: Handling the HeaderSizeNeededEvent__

```C#
	private void VirtualGrid_HeaderSizeNeeded(object sender, Telerik.Windows.Controls.VirtualGrid.HeaderSizeEventArgs e)
        {
            if (e.HeaderOrientation == Telerik.Windows.Controls.VirtualGrid.VirtualGridOrientation.Horizontal)
            {
                if (e.Index % 2 == 0)
                {
                    e.SizeUnit = Telerik.Windows.Controls.VirtualGrid.HeaderSizeUnit.Star;
                }
                else
                {
                    e.Size = 130;
                }
            }
        }
```

#### __Figure 1: RadVirtualGrid with custom size for the headers__

![RadVirtualGrid with custom size for the headers](images/RadVirtualGrid_Features_Headers01.png)

>tip To learn how to conditionally style the cells (including the header cells), you can read the [Conditional Styling]({%slug virtualgrid-conditional-styling%}).

## See Also

* [Custom Data Provider]({%slug virtualgrid-custom-dataprovider%})

* [Editing]({%slug virtualgrid-editing%})

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})

* [Pinned Rows and Columns]({%slug virtualgrid-pinned-rows-and-columns%})
