---
title: Layout
page_title: Layout
description: Check our &quot;Layout&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagram-features-diagram-layout
tags: layout
published: True
position: 10
---

# Layout

__Layout__ in the __RadDiagram__ refers to the way the __Shapes__ are arranged on the diagramming surface. __RadDiagram__ provides a dozen of Layout algorithms which can be easily customized.	  

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.		

## Sugiyama Layout

The __Sugiyama__ is a __layered__ layout type which organizes a diagram in layers and attempts to minimize the amount of crossings between the connections and the layers.		

Sugiyama is the default layout algorithm in __RadDiagram__. Using it is straightforward - just invoke the __RadDiagram.Layout()__ method or use the __Layout__ DiagramCommand:		

* use the __RadDiagram Layout()__ method:
			  
#### __XAML__
```XAML
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto" />
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>
        <StackPanel HorizontalAlignment="Center" Orientation="Horizontal">
            <telerik:RadButton Margin="5,0"
                               Click="Layout"
                               Content="Layout" />
        </StackPanel>
        <telerik:RadDiagram x:Name="diagram"
                            Grid.Row="1"
                            Margin="5" />
    </Grid>		
```

#### __C#__
```C#
    private void Layout(object sender, RoutedEventArgs e)
    {
        diagram.Layout();
    }		  
```

#### __VB.NET__
```VB.NET
    Private Sub Layout(sender As Object, e As RoutedEventArgs)
        diagram.Layout()
    End Sub			  
```

* use the __DiagramCommands Layout__ command:
			  
#### __XAML__
```XAML
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto" />
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>
        <StackPanel HorizontalAlignment="Center" Orientation="Horizontal">
            <telerik:RadButton Margin="5,0"
                               Command="telerik:DiagramCommands.Layout"
                               CommandTarget="{Binding ElementName=diagram}"
                               Content="LayoutCommand" />
        </StackPanel>
        <telerik:RadDiagram x:Name="diagram"
                            Grid.Row="1"
                            Margin="5" />
    </Grid>		
```	

The __Layout()__ method provides two optional parameters - the type of the Layout (Sugiyama or Tree) and the corresponding layout settings (SugiyamaSettings or TreeLayoutSettings):

#### __C#__
```C#
	private void RadButton_Click(object sender, RoutedEventArgs e)
	{
		SugiyamaSettings settings = new SugiyamaSettings()
		{
			HorizontalDistance = 50,
			VerticalDistance = 20,
			Orientation =  Telerik.Windows.Diagrams.Core.Orientation.Horizontal,
			TotalMargin = new Size(20,20),
			ShapeMargin = new Size(10,10),	
		};
		this.diagram.Layout(LayoutType.Sugiyama, settings);
	}
```

#### __VB.NET__
```VB.NET
	Private Sub RadButton_Click(sender As Object, e As RoutedEventArgs)
		Dim settings As New SugiyamaSettings() With { 
			 .HorizontalDistance = 50, 
			 .VerticalDistance = 20, 
			 .Orientation = Telerik.Windows.Diagrams.Core.Orientation.Horizontal, 
			 .TotalMargin = New Size(20, 20), 
			 .ShapeMargin = New Size(10, 10) 
		}
		Me.diagram.Layout(LayoutType.Sugiyama, settings)
	End Sub
```

Below you can see how random shapes and connections are being arranged with the given layout configuration:
![raddiagram-features-layout-Sugiyama](images/raddiagram-features-layout-Sugiyama.png)

## Tree Layout

The Tree Layout Type organizes a diagram in a tree-like fashion. There are eight additional subtypes of Tree Layout:		

* __Tree-down:__ - a standard hierarchical layout with node spreading from the root downwards.			  

* __Tree-up:__ - a standard hierarchical layout with node spreading from the root upwards.			  

* __Tree-left:__ - a standard hierarchical layout with node spreading from the root to the left.			  

* __Tree-right:__ - a standard hierarchical layout with node spreading from the root to the right.			  

* __Mindmap-vertical:__ - a classic mindmapping pattern with wings stacked vertically.			  

* __Mindmap-horizontal:__ - a classic mindmapping pattern with wings stacked horizontally.			  

* __Tip-over tree:__ - much like the tree-down layout but nodes are organized as standard trees from the first-child level on to reduce the spreading and usage of space.			  

* __Radial:__ - siblings are organized on circular level emanating from the center/root outwards.			  

Below you can see a snapshots of random diagrams laid out with Tree Layout types:

* Tree-down: ![raddiagram-features-layout-tree-down](images/raddiagram-features-layout-tree-down.png) 

* Tree-up: ![raddiagram-features-layout-tree-up](images/raddiagram-features-layout-tree-up.png) 

* Tree-left: ![raddiagram-features-layout-tree-left](images/raddiagram-features-layout-tree-left.png) 

* Tree-right: ![raddiagram-features-layout-tree-right](images/raddiagram-features-layout-tree-right.png) 

* Mindmap-vertical: ![raddiagram-features-layout-mindmap-vertical](images/raddiagram-features-layout-mindmap-vertical.png) 

* Mindmap-horizontal: ![raddiagram-features-layout-mindmap-horizontal](images/raddiagram-features-layout-mindmap-horizontal.png) 

* Tip-over tree: ![raddiagram-features-layout-tipovertree](images/raddiagram-features-layout-tipovertree.png) 

* Radial: ![raddiagram-features-layout-radial](images/raddiagram-features-layout-radial.png)

Here is how this could be achieved in code behind.	

#### __C#__
```C#
	private void RadButton_Click(object sender, RoutedEventArgs e)
	{
		TreeLayoutSettings settings = new TreeLayoutSettings()
		{
			TreeLayoutType = TreeLayoutType.TreeDown,
			VerticalDistance = 20,				
		};
		settings.Roots.Add(this.diagram.Shapes[0]);
		this.diagram.Layout(LayoutType.Tree, settings);
	}
```

#### __VB.NET__
```VB.NET
	Private Sub RadButton_Click(sender As Object, e As RoutedEventArgs)
		Dim settings As New TreeLayoutSettings() With { 
			 .TreeLayoutType = TreeLayoutType.TreeDown, 
			 .VerticalDistance = 20 
		}
		settings.Roots.Add(Me.diagram.Shapes(0))
		Me.diagram.Layout(LayoutType.Tree, settings)
	End Sub
```

## Layout Settings

__Component Layout and Settings__

One important aspect with respect to diagram layout is the concept of graph component. If a diagram consists of separate sub-diagrams with no connection between them they are called components of a diagram.

When applying a diagram layout to a diagram consisting of one or more components a layout is applied to each components and thereafter the components are organized in a grid.

![raddiagram-features-layout-gridcomponent](images/raddiagram-features-layout-gridcomponent.png)

The splitting in components is automatic and the grid layout of the components applied to both the tree layout and the layered layout types.

The grid layout has the following settings which are both present as part of the __SugiyamaLayoutSettings__ and the __TreeLayoutSettings__:	

* __AnimateTransitions__: This property allows you to animate the dynamic changes of a Diagram layout. When you set the value of the property to __True__ and dynamically change the layout settings of a Diagramming solution, an animation will be applied during the transition of the settings.	
* __ComponentMargin:__ the margin each component has in the grid layout.		
* __ComponentsGridWidth:__ the total width of the grid wherein the components are laid out.			
* __IgnoreContainers__: Gets or sets a boolean valu indicating whether the shape containers are ignored when laying out the graph. If __false__, the shape containers will be considered as ordinary shapes in the tree layout process. You can additionally set the flag to perform a separate layout pass on the content of the containers. On the other hand, if this property is set to __true__ the flag will have no effect since the layout process will be oblivious to the containers.
* __IgnoreInvisible__: Gets or sets a boolean valu indicating whether the non-visible diagram items have to be taken into account. If set to true shapes with Visibility not set to Visibl  will be ignored.
* __LayoutContainerChildren__: Gets or sets a boolean value indicating whether the content of the containers is processed on top of the global layout. This flag has only an effect if is set to __false__.
* __TotalMargin:__ the margin around the (virtual) grid.		  

__Sugiyama specific settings__

* __Orientation__: Gets or sets the orientation in which the layout process should organize the diagram.
* __ShapeMargin__: 
* __VerticalDistance__: the vertical spacing between the layers.	
* __HorizontalDistance__: the horizontal spacing between the layers.			  

__Tree layout settings__

* __TreeLayoutType__: the subtype of the tree layout: TreeDown, TreeUp, TreeLeft, TreeRight, TipOverTree, RadialTree, MindmapVertical, MindmapHorizontal. See the examples above for more details.			  
* __VerticalSeparation__: (applies only to the four standard tree types  and the TipOverTree) the vertical separation between tree level.			  
* __HorizontalSeparation__: (applies only to the four standard tree types and the TipOverTree) the horizontal separation between siblings on the same level.			  
* __UnderneathVerticalTopOffset__: (applies only to the TipOverTree type) the offset from the parent of the first child.			  
* __UnderneathHorizontalOffset__: (applies only to the TipOverTree type) the horizontal offset between parent and child.			  
* __UnderneathVerticalSeparation__: (applies only to the TipOverTree type) the vertical offset between subsequent children.			  
* __Roots__: The Roots of the components. Use this collection of IShapes to set the roots of the trees in your diagram before layout. If no shape is specified as a root element, the diagram will automatically analyze the most probable tree, which will be based on the longest path in the graph. In an MVVM scenario, the RadDiagram will have to be loaded and its shapes to be generated before specifing the root elements.	  
* __TipOverTreeStartLevel__: this property applies only to the TipOverTree type and gets or sets the level from which a tip-over tree arrangement should be applied. A value of zero means that the children underneath the root will have a tip-over arrangement, a value of one means the grand-children of the root will have this applied and so on.			  
* __RadialSeparation__: (applies only to the RadialTree type) the radial distance between levels.			  
* __RadialFirstLevelSeparation__: (applies only to the RadialTree type) the radial distance between the root and the first level.			  
* __KeepComponentsInOneRadialLayout__: (applies only to the RadialTree type) if set to true the default behavior of organizing components into a grid will be overridden and the components will be considered as part of one radial tree. To this end a virtual root will be added which unifies the different components. See the example below.			  
* __StartRadialAngle__: The radial layout allows you to use a sector instead of the full 360 degrees. This start angle defines the beginning of this sector.			  
* __EndRadialAngle__: This end angle defines the end of the sector used (the part of 360 degrees used).			  		  

Below you can see the explanation of the main __TreeLayout Settings__ for the base 4 types (Up, Down, Left, Right) + TipOverTree.

![raddiagram-features-layout-settings](images/raddiagram-features-layout-settings.png)

Below you can see how the __KeepComponentsInOneRadialLayout__ actually works when you have more than one component:

![raddiagram-features-layout-radiallayout](images/raddiagram-features-layout-radiallayout.png)

## Properties and Methods
The RadDiagram’s methods related with the Layout feature are the following ones:

* __Layout()__ – of type void which organizes all the items in the RadDiagram using specified layout type and settings. By default the type is set to Sugiyama and the settings are set to null.  You can define your custom layout type and settings and use them with the method.
* __LayoutAsync()__ – just like the __Layout()__ but acts _asynchronously_. This is why you should be careful when using this method. Keep in mind that it waits until all shapes, containers and connections are already generated and then gets executed within the following layout pass. 

>Note: Choosing which method should be used depends on your custom scenario and requirements this is why no specific rule can be made. A good practice is to first evaluate how the __Layout()__ method works and then to move to the __LayoutAsync()__ if needed.

The properties that are related with the same feature are:

* __AutoLayout__ – Boolean property that controls whether the __RadDiagram__ should automatically layout the items hosted in it whenever a new item is added or removed.

>Note: If you need to change the settings that are used when the automatic layout is triggered you should once call the __LayoutAsync()__ method with the new settings. In other words, the automatic layout uses the last settings that are used in the context of the __RadDiagram__. By default this feature is disabled.

## See Also
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Routing]({%slug raddiagram-features-routing%})
