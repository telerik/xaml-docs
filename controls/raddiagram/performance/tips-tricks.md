---
title: Tips and Tricks
page_title: Tips and Tricks
description: Tips and Tricks
slug: raddiagram-performance-tips-tricks
tags: tips,and,tricks
published: True
position: 1
---

# Tips and Tricks

__RadDiagram__ API allows you to tweak your application for optimal performance. You should be familiar with the following performance and optimization tips:

## Increase performance

* __Automation Peers__: The automation peers can be turned off if they are not used. This can be done using the global __AutomationMode__ property of the __AutomationManager__. You can check the [UI Automation Support]({%slug common-ui-automation%}) article on how to set the AutomationMode property to Disabled.

* __Virtualization__: The virtualization of the RadDiagram is turned off by default. To turn it on the __telerik:DiagramSurface.IsVirtualizing__ attached property needs to be set to __True__. The __UI Virtualization__ of the RadDiagram will collapse all shapes which are outside of the diagram Viewport. More information can be found in the [Virtualization]({%slug raddiagrams-features-virtualization%}) help article.

* __Align and Snap__: To optimize the dragging behavior, the aligning and snapping mechanism can be turned off. To disable them you can set the __IsSnapToGridEnabled__ and __IsSnapToItemsEnabled__ properties of the RadDiagram control to __False__.

* __Information adorner__: The information adorner is constantly updated on drag. If it is not needed you can remove it. To disable it the __IsInformationAdornerVisible__ property of the RadDiagram can be set to __False__.

* __Pan and Zoom animations__: In case you don't need the animations while zooming or panning you can disable them. In order to turn them off, you can set the __IsPanAnimationEnabled__ and __IsZoomAnimationEnabled__ attached properties to __False__.

* __RadDiagramThumbnail__: The __RadDiagramThumbnail__ mechanism represent the current ViewPort of the RadDiagram. The Thumbnail is updated on every pan, zoom, position changed operation etc. In a case with a large number of items in the ViewPort, this could lead to a slow performance. In such scenarios, you can try avoiding using the __RadDiagramThumbnail__.

* __Disable Thumbnail from refreshing__: By default __RadDiagramThumbnail__ is refresh on every UI operation performed into the RadDiagram. You can disable its auto refreshing mechanism and manually refresh it only when necessary. You can do that via the __IsAutoRefreshEnabled__ property and the __RefreshThumbnail()__ method.

* __Number of shapes in ViewPort__:  Work with a small number of shapes in the ViewPort. The smaller the number of shapes in the Viewport the faster diagram will be.

## Optimize Layout

* __Layout and LayoutAsync__: Choosing which method should be used depends on your custom scenario and requirements. A good practice is to first evaluate how the __Layout()__ method works and then to move to the __LayoutAsync()__ if needed. Generally speaking, the __Layout()__ method should be faster because __LayoutAsync()__ waits for __LayoutUpdated events__. Still, it depends on the concrete scenario.

* __Shapes Width and Height__: To improve layout time, it is important the shapes ploted on the diagram to be with equal width and height. Layouting the diagram with different size of the shapes could lead to slower performance.

* __Suspend Connection Update__: For better performance is better to suspend the connection update before calling the __Layout()__ method.

#### __[XAML] Example 1: Suspend connection update__
{{region raddiagram-performance-tips-tricks_0}}
	this.xDiagram.Connections.ForEach(x => RadDiagramConnection.SetIsAutoUpdateSuppressed((RadDiagramConnection)x, true)); 
	this.xDiagram.Layout(LayoutType.Tree, settings);
	this.xDiagram.Connections.ForEach(x => RadDiagramConnection.SetIsAutoUpdateSuppressed((RadDiagramConnection)x, false));
	this.xDiagram.Connections.ForEach(x => x.Update());
{{endregion}}

* __Simplify Shapes Template__: In a scenario with a large number of shapes you can try to simplify the template of the shapes as much as possible. This way you can increase the initial load time. You can check the [Create Custom Shape]({%slug raddiagram-howto-create-custom-shape%}) help article which desribes how you can create a custom shape. __Example 2__ demonstrate possible template. 

#### __[XAML] Example 2: Simplify Shapes Template__
{{region raddiagram-performance-tips-tricks_1}}
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
{{endregion}}

* __Routing__: The routing functionality of the diagram provides several algorithms __(OrgTreeRouter, AStarRouter, InflatedRectRouter)__ which can used to reduce the crossing of the connection. In some cases, one can be musch faster than others. You can test your scenario with all of them and used the one which works best for your case.
       
## Optimize Copy Paste 

* __Disable Selection__: When copying and pasting hundreds of shapes could lead to performance issues. This is because thousands of visual elements are added in a Canvas (every shape has borders, resizing / rotation thumbs, many other visuals in its control template). What you can do to optimize the process is to disable the selection behavior of the paste shapes. In order to do that you can create a custom class which derives from RadDiagram control and override the __Paste()__ method. Then you can create a dummy boolean value which we are going to use to handle the selection of the control in its __PreviewSelectionChanged__ event handler.

#### __[XAML] Example 3: Simplify Shapes Template__
{{region raddiagram-performance-tips-tricks_2}}
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
{{endregion}}
	   
## See Also

* [Getting Started]({%slug raddiagram-getting-started%})
* [DiagramExtensions ViewModels]({%slug raddiagram-data-extensionsviewmodels%})
* [Extensions Overview]({%slug raddiagram-extensions%})
