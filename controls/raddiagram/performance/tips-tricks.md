---
title: Tips and Tricks
page_title: Tips and Tricks
description: Check our &quot;Tips and Tricks&quot; documentation article for the RadDiagram WPF control.
slug: raddiagram-performance-tips-tricks
tags: tips,and,tricks
published: True
position: 1
---

# Tips and Tricks

The API of the `RadDiagram` control allows you to tweak your application for optimal performance. You should be familiar with the following performance and optimization tips:

## Increase performance

* __Automation Peers__&mdash;The automation peers can be turned off if they are not used. This can be done using the global `AutomationMode` property of the `AutomationManager`. You can check the [UI Automation Support]({%slug common-ui-automation%}) article on how to set the AutomationMode property to Disabled.
* __Virtualization__&mdash;The virtualization of the RadDiagram is turned off by default. To turn it on, set the `DiagramSurface.IsVirtualizing` attached property to __True__. The __UI Virtualization__ of the RadDiagram will collapse all shapes which are outside of the diagram viewport. More information can be found in the [Virtualization]({%slug raddiagrams-features-virtualization%}) help article.
* __Align and Snap__&mdash;To optimize the dragging behavior, the aligning and snapping mechanism can be turned off. To disable them, you can set the `IsSnapToGridEnabled` and `IsSnapToItemsEnabled` properties of the RadDiagram control to __False__.
* __Information adorner__&mdash;The information adorner is constantly updated on drag. If it is not needed, you can remove it. To disable it the `IsInformationAdornerVisible` property of the RadDiagram can be set to __False__.
* __Pan and Zoom animations__&mdash;In case you don't need the animations while zooming or panning, you can disable them. In order to turn them off, you can set the `DiagramAnimations.IsPanAnimationEnabled` and `DiagramAnimations.IsZoomAnimationEnabled` attached properties to __False__.
* `RadDiagramThumbnail`&mdash;The RadDiagramThumbnail mechanism represent the current viewport of the RadDiagram. The thumbnail is updated on every pan, zoom, position changed operation etc. In a case with a large number of items in the viewport, this could lead to a slow performance. In such scenarios, you can try avoiding using the RadDiagramThumbnail.
* __Disable thumbnail from refreshing__&mdash;By default, RadDiagramThumbnail is refreshed on every UI operation performed into the RadDiagram. You can disable its auto refreshing mechanism and manually refresh it only when necessary. You can do that via the `IsAutoRefreshEnabled` property and the `RefreshThumbnail` method of the RadDiagramThumbnail class.

  	__Disabling the thumbnail auto refresh__
	```XAML
		<telerik:RadDiagramThumbnail Diagram="{Binding ElementName=radDiagram}" IsAutoRefreshEnabled="False" /> 
	```

* __Number of shapes in viewport__&mdash;Work with a small number of shapes in the viewport. The smaller the number of shapes in the viewport the faster diagram will be.
* __Clear the Diagram Cache__&mdash;When an item (node) is removed from the `GraphSource`, its corresponding UI container (RadDiagramShape) is stored in collection of 'recycled' shapes for future use. This aims to speed up the diagram performance in extensive undo-redo and container generation operations (loading process). However, in a scenario where large number of Add/Remove operation are performed, the recycled collection store in memory every operation which could lead to a possible memory issues. What can be done here is to manually clear this collection at some moment by calling the `ClearCache` method.

	__Clear the RadDiagram Cache__
	```C#
		(this.xDiagram.ContainerGenerator as GenericContainerGenerator<Telerik.Windows.Controls.Diagrams.RadDiagramItem>).ClearCache();
	```

* __Disable the segmentation service__&mdash;It is responsible for continually dividing the RadDiagram into segments in order to more easily retrieve "nearby" shapes for certain operations. Disabling this service should be considered and tested on a "per application" basis as it could increase the overall performance, but slow down specific scenarios such as creating a connection and snapping. 

	__Disabling the SegmentationService__
	```C#
		public MainWindow()
		{
			InitializeComponent();
			this.xDiagram.ServiceLocator.Register<ISegmentationService>(new CustomSegmentationService(this.xDiagram));
		}
	
		public class CustomSegmentationService : SegmentationService
	    	{
		        public CustomSegmentationService(IGraphInternal graph) : base(graph)
		        {
		        }
		
		        public override bool IsSegmentationEnabled => false;
	    	}
	```

## Optimize Layout

* __Layout and LayoutAsync__&mdash;Choosing which method should be used depends on your custom scenario and requirements. A good practice is to first evaluate how the `Layout` method works and then to move to the `LayoutAsync` if needed. Generally speaking, the Layout method should be faster because LayoutAsync waits for `LayoutUpdated` events. Still, it depends on the concrete scenario.
* __Shapes Width and Height__&mdash;To improve layout time, it is important the shapes ploted on the diagram to be with equal width and height. Layouting the diagram with different size of the shapes could lead to slower performance.
* __Suspend Connection Update__&mdash;For better performance it is better to suspend the connection update before calling the Layout method.

__Suspend connection update__
```XAML
	this.xDiagram.Connections.ForEach(x => RadDiagramConnection.SetIsAutoUpdateSuppressed((RadDiagramConnection)x, true)); 
	this.xDiagram.Layout(LayoutType.Tree, settings);
	this.xDiagram.Connections.ForEach(x => RadDiagramConnection.SetIsAutoUpdateSuppressed((RadDiagramConnection)x, false));
	this.xDiagram.Connections.ForEach(x => x.Update());
```

* __Simplify Shapes Template__&mdash;In a scenario with a large number of shapes you can try to simplify the template of the shapes as much as possible. This way you can increase the initial load time. You can check the [Create Custom Shape]({%slug raddiagram-howto-create-custom-shape%}) help article which desribes how you can create a custom shape. The following example demonstrate possible template: 

__Simplify Shapes Template__
```XAML
	<Style TargetType="{x:Type telerik:RadDiagramShape}">
		<Setter Property="Template">
			<Setter.Value>
				<ControlTemplate TargetType="telerik:RadDiagramShape">
					<Grid Background="Orange">
						<ContentPresenter Margin="{TemplateBinding Padding}"
							  HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
							  VerticalAlignment="{TemplateBinding VerticalContentAlignment}" />
					</Grid>
				</ControlTemplate>
			</Setter.Value>
		</Setter>
	</Style>
```

* __Disable connection bridges__&mdash;In a scenario with many connections and enabled [connections bridge]({%slug raddiagrams-features-connections%}#connection-bridge) functionality, the performance can be reduced. The reason for this is because the algorithm for combining and calculating crossing geometries is a complex one. To disable it, set the `ConnectionBridge` property of RadDiagram to __None__.
       
## Optimize Copy Paste 

* __Disable Selection__&mdash;Copying and pasting hundreds of shapes could lead to performance issues. This is because thousands of visual elements are added in a Canvas (every shape has borders, resizing / rotation thumbs, many other visuals in its control template). What you can do to optimize the process is to disable the selection behavior of the paste shapes. In order to do that you can create a custom class which derives from RadDiagram control and override the `Paste` method. Then you can create a dummy boolean value which RadDiagram are going to use to handle the selection of the control in its `PreviewSelectionChanged` event handler.

__Suppress selection while pasting__
```XAML
	public class CustomDiagram : RadDiagram
	{
		internal bool IsPasteInPrrogress { get; set; }
		public override void Paste()
		{
		   this.IsPasteInPrrogress = true;
		   base.Paste();
		   this.IsPasteInPrrogress = false;
		}
	}

	private void diagram_PreviewSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	   if (this.diagram.IsPasteInPrrogress == true)
	   {
		   e.Handled = true;
	   }
	}
```

## Dynamic GraphSource Change

To use the diagram in a scenario with dynamic change of the graph source, you need to set the GraphSource property of the control in code behind. This allows you to make dynamic changes to the graph source. If you layout the diagram after the GraphSource change, you need to ensure that, e.g., layout roots are set correctly.

__Suppress selection while pasting__
```C#
    MainViewModel viewModel;
	public MainWindow()
	{
		InitializeComponent();
		this.viewModel = new MainViewModel();
		this.diagram.GraphSource = this.viewModel.GraphSource;
	}
	private void LayoutButtonClicked(object sender, RoutedEventArgs e)
	{         
		this.diagram.GraphSource = null;
		this.diagram.GraphSource = this.viewModel.GraphSource;
	 
	    // In a case you are using Diagram Layout
		this.SetLayoutRoots(); // custom method to set again the roots
		this.diagram.LayoutAsync(LayoutType.Tree, settings);
	}
```

## Routing

* __Increase routing grid size__&mdash;Increasing the `DiagramConstants.RoutingGridSize` property's value will result in faster calculations for the routing paths with the cost of not so well-looking corners and routings around shapes.

### AStarRouter

* __Use the AStarRouter__&mdash;The `AStarRouter` uses a version of the [A* search algorithm](http://en.wikipedia.org/wiki/A*_search_algorithm) to find the best route between two points. This is not the default router of RadDiagram. To set it, create a new instance of the AStarRouter class and assign it to the `RoutingService.Router` property of the `RadDiagram` instance. There are some penalties when using this router. To learn more about them, check out the [AStarRouter]({%slug raddiagram-features-routing%}#astarrouter) section.
* __Disable the AvoidShapes functionality__&mdash;The `AvoidShapes` property of the AStarRouter will make the connections go around the shapes. The default value is __True__, which will reduce the performance when having many shapes and connections in the current viewport. To disable it, set the AvoidShapes property to __False__.
* __WallOptimization functionality__&mdash;If the `WallOptimization` property of the AStarRouter is set to __True__, the router will try to optimize the some of the steps, in order to reduce the amount of corners. This feature will increase the calculation time and may result in reduced perfomance.

## See Also

* [Getting Started]({%slug raddiagram-getting-started%})
* [DiagramExtensions ViewModels]({%slug raddiagram-data-extensionsviewmodels%})
* [Extensions Overview]({%slug raddiagram-extensions%})
