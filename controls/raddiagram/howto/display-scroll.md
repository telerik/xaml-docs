---
title: Display ScrollViewer Inside the Diagram
page_title: Display ScrollViewer Inside the Diagram
description: Check our &quot;Display ScrollViewer Inside the Diagram&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagram-howto-display-scroll
tags: display,scrollviewer,inside,the,diagram
published: True
position: 2
---

# {{ site.framework_name }} RadDiagram Display ScrollViewer Inside the Diagram

This tutorial describes how to display the RadDiagram built-in ScrollViewer.

For the purpose of this tutorial we'll examine the following simple Diagramming structure:

#### __XAML__
{{region raddiagram-howto-display-scroll-0}}
    <Grid Height="350" Width="525">
        <telerik:RadDiagram x:Name="xDiagram">
            <telerik:RadDiagramShape x:Name="shape1" Position="20,20" Content="Shape 1" />
            <telerik:RadDiagramShape x:Name="shape2" Position="520,520" Content="Shape 2" />
            <telerik:RadDiagramConnection Source="{Binding ElementName=shape1}"
                    Target="{Binding ElementName=shape2}" />
        </telerik:RadDiagram>
    </Grid>		  
{{endregion}}

As the __Grid__ hosting our __RadDiagram__ has a limited size, we can't see the second shape in the viewport:
![Rad Diagram How To Scroll No Scroll](images/RadDiagram_HowTo_Scroll_NoScroll.png)

In such scenarios it's useful to use the __RadDiagram__ built-in __ScrollViewer__, which you can display to get a better view of the area described by the position and size of your __RadDiagramItems__. 
![Rad Diagram How To Scroll Scroll](images/RadDiagram_HowTo_Scroll_Scroll.png)

In order to enable the horizontal and/or vertical __ScrollBar__ you need to add the following attribute(s) to the __RadDiagram__ declaration:		

#### __XAML__
{{region raddiagram-howto-display-scroll-1}}
    <telerik:RadDiagram Grid.Row="1" x:Name="xDiagram" 
                        ScrollViewer.HorizontalScrollBarVisibility="Visible" 
                        ScrollViewer.VerticalScrollBarVisibility="Visible">
      ...
    </telerik:RadDiagram>		  
{{endregion}}

The same operation can be done in code-behind as well:

#### __C#__
{{region raddiagram-howto-display-scroll-2}}
    private void EnableScrollBars()
    {
        ScrollViewer.SetHorizontalScrollBarVisibility(xDiagram, ScrollBarVisibility.Visible);
        ScrollViewer.SetVerticalScrollBarVisibility(xDiagram, ScrollBarVisibility.Visible);
    }		  
{{endregion}}
		  
#### __VB.NET__
{{region raddiagram-howto-display-scroll-3}}
    Private Sub EnableScrollBars()
        ScrollViewer.SetHorizontalScrollBarVisibility(xDiagram, ScrollBarVisibility.Visible)
        ScrollViewer.SetVerticalScrollBarVisibility(xDiagram, ScrollBarVisibility.Visible)
    End Sub		
{{endregion}}

## See Also
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Create Custom Shape]({%slug raddiagram-howto-create-custom-shape%})
 * [Overview]({%slug raddiagram-data-overview%})
 * [Use MVVM in RadDiagram]({%slug raddiagrams-howto-mvvm%})