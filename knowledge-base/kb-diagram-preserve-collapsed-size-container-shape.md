---
title: How to Change Size in Collapsed RadDiagramContainerShape
page_title: How to Cache Collapsed Width and Height of RadDiagram Container Shape
description: How to preserve the collapsed size of RadDiagramContainerShape.
type: how-to
slug: kb-diagram-preserve-collapsed-size-container-shape
position: 0
tags: container,shape,size,preserve,iscollapsed
ticketid: 1414353
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2.510</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadDiagram for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to preserve the collapsed size of RadDiagramContainerShape.

## Solution

To preserve the collapsed size of a diagram container shape, cache the size when the resizing is finished and if the container is collapsed. And then restore it back when the container get collapsed again.

Use the __CompleteResizing__ event of the RadDiagram's __ResizingService__ to store the collapsed size. And the __IsCollapsedChanged__ event of RadDiagramContainerShape to restore the size.


```XAML
	 <telerik:RadDiagram x:Name="diagram">
		<telerik:RadDiagramContainerShape Position="300, 300" Width="300" Height="100" IsCollapsible="true"  
										  IsCollapsedChanged="RadDiagramContainerShape_IsCollapsedChanged"/>
	</telerik:RadDiagram>
```


```C#
	public partial class MainWindow : Window
    {
        private Dictionary<RadDiagramContainerShape, double> containerToHeightCache = new Dictionary<RadDiagramContainerShape, double>();

        public MainWindow()
        {
            InitializeComponent();
            var service = this.diagram.ServiceLocator.GetService<IResizingService>() as ResizingService;
            service.CompleteResizing += Service_CompleteResizing;
        }

        private void Service_CompleteResizing(object sender, ResizingEventArgs e)
        {
            if (e.Items.Count() == 1 && e.Items.ElementAt(0) is RadDiagramContainerShape)
            {
                var container = (RadDiagramContainerShape)e.Items.ElementAt(0);
                if (container.IsCollapsed)
                {
                    if (!containerToHeightCache.ContainsKey(container))
                    {
                        containerToHeightCache.Add(container, e.NewBounds.Height);
                    }
                    else
                    {
                        containerToHeightCache[container] = e.NewBounds.Height;
                    }
                }                
            }
        }

        private void RadDiagramContainerShape_IsCollapsedChanged(object sender, RoutedEventArgs e)
        {
            var container = (RadDiagramContainerShape)sender;
            if (container.IsCollapsed)
            {
                container.IsResizingEnabled = true;
                if (containerToHeightCache.ContainsKey(container))
                {
                    container.Height = containerToHeightCache[container];
                }
            }
        }
    }
```

## See Also  
* [Services]({%slug raddiagram-features-services%})