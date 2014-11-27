---
title: ContainerShapes
page_title: ContainerShapes
description: ContainerShapes
slug: raddiagram-features-container-shapes
tags: containershapes
published: True
position: 2
---

# ContainerShapes

This tutorial will walk you through the functionality and the main features of the RadDiagramContainerShape. 

## Overview

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the{% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.		  

The __RadDiagramContainerShape__ allows you to place multiple shapes into one container shape. The __RadDiagramContainerShapes__ are, much like [groups]({%slug raddiagram-features-grouping%}) , a way to logically combine other shapes but add to this the capability to have a visual wrapper including a header. You can drag shapes in and out of a __ContainerShape__ in runtime and take advantage of its built-in auto-sizing logic that can extend the size of a container to wrap  a shape. The __Diagramming Framework__ provides a visual feedback when a shape is being dragged over a __RadDiagramContainerShape__ and even if part of the shape is outside the bounds of the container, the framework internally handles the drop and expands the size of the container to place the shape inside the content area of the container.		

Illustration of the ContainerShape auto-sizing capabilities

![Rad Diagram Container Shape Overview](images/RadDiagram_ContainerShape_Overview.png)

A container can be compared with a __HeaderedItemsControl__ but is also a true diagramming shape which can be connected and handled like other shapes. 		

>The __RadDiagramContainerShape__ derives from the __DiagramShapeBase__ class and this is why it exposes similar properties to those of the __RadDiagramShape__. To get familiar with the __RadDiagramShape__ features and properties, please refer to the [Diagram Shapes]({%slug raddiagrams-features-shapes%}) tutorial.		

### Setting a header

The __RadDiagramContainerShape__ header is controlled via the __Content__ property:

#### __XAML__
    <Grid>
        <telerik:RadDiagram>
            <telerik:RadDiagramContainerShape Content="Container" />
        </telerik:RadDiagram>
    </Grid>			  

![Rad Diagram Features Containers Content](images/RadDiagram_Features_Containers_Content.png)

If you bind the __Content__ property to a business property, you can use the __ContentTemplate__ to apply a __DataTemplate__ and control the way your business data is displayed in the header of the __RadDiagramContainerShape__:		  

#### __XAML__
    <Grid>
        <telerik:RadDiagram>
            <telerik:RadDiagramContainerShape Content="{Binding}">
                <telerik:RadDiagramContainerShape.ContentTemplate>
                    <DataTemplate>
                        <TextBlock Text="{Binding Header}" />
                    </DataTemplate>
                </telerik:RadDiagramContainerShape.ContentTemplate>
            </telerik:RadDiagramContainerShape>
        </telerik:RadDiagram>
    </Grid>

### Edit Mode

By default you can edit the header of the __RadDiagramContainerShape__ out-of-the-box by double-clicking on the container or by hitting F2. If you'd like to disable the editing functionality, you can set the __IsEditable__ property to __False__.

You can manually put the  __RadDiagramContainerShape__ in an edit mode by setting its __IsInEditMode__ property to __True__. This is the property that gets and sets the edit mode of the container.

### Populating with items

The main purpose of the __RadDiagramContainerShape__ is to allow you to drop shapes on it thus grouping them in one container. This is why dragging and dropping shapes onto the container is the main approach for populating its __Items__collection. 

You can also populate it manually in xaml:
			
#### __XAML__
	
    <telerik:RadDiagram>
        <telerik:RadDiagramContainerShape  x:Name="containerShape" Content="Container">
            <telerik:RadDiagramShape Content="Shape1" />
        </telerik:RadDiagramContainerShape>
    </telerik:RadDiagram>	

Or in code-behind:

#### __C#__
    containerShape.Items.Add(new RadDiagramShape() { Content = "Shape 1"});			  

#### __VB.NET__
    containerShape.Items.Add(New RadDiagramShape() With {.Content = "Shape 1"})

You can also populate the __RadDiagramContainerShape__ from a collection of business items. You can use the __ItemsSource__ property to bind it to your data objects. For example, if the __RadDiagram.DataContext__ contains a collection of business nodes:		  

#### __C#__
    public class MainViewModel
    {
        public ObservableCollection<NodeViewModelBase> Nodes { get; set; }

        public MainViewModel()
        {
            this.Nodes = new ObservableCollection<NodeViewModelBase>();
            for (int i = 1; i < 6; i++)
            {
                this.Nodes.Add(new NodeViewModelBase()
                {
                    Content = String.Format("Shape {0}", i),
                    Position = new Point(i * 20, i * 45)
                });
            }
        }
    }

    public partial class ContainerShapeSample : UserControl
    {
        public ContainerShape()
        {
            InitializeComponent();
            this.xDiagram.DataContext = new MainViewModel();
        }
    }    
    
#### __VB.NET__
    Public Class MainViewModel
        Public Property Nodes() As ObservableCollection(Of NodeViewModelBase)
            Get
                Return m_Nodes
            End Get
            Set
                m_Nodes = Value
            End Set
        End Property
        Private m_Nodes As ObservableCollection(Of NodeViewModelBase)

        Public Sub New()
            Me.Nodes = New ObservableCollection(Of NodeViewModelBase)()
            For i As Integer = 1 To 5
                Me.Nodes.Add(New NodeViewModelBase() With { .Content = [String].Format("Shape {0}", i), 
                                                            .Position = New Point(i * 20, i * 45)
                                                          })
            Next
        End Sub
    End Class

    Public Partial Class ContainerShapeSample
        Inherits UserControl
        Public Sub New()
            InitializeComponent()
            Me.xDiagram.DataContext = New MainViewModel()
        End Sub
    End Class

You can display that collection in a __RadDiagramContainerShape__:
		  

#### __XAML__
    <telerik:RadDiagram x:Name="xDiagram">
        <telerik:RadDiagram.ShapeStyle>
            <Style TargetType="telerik:RadDiagramShape">
                <Setter Property="Position" Value="{Binding Position, Mode=TwoWay}" />
            </Style>
        </telerik:RadDiagram.ShapeStyle>
        <telerik:RadDiagram.ShapeTemplate>
            <DataTemplate>
                <TextBlock Text="{Binding Content}" />
            </DataTemplate>
        </telerik:RadDiagram.ShapeTemplate>
        <telerik:RadDiagramContainerShape x:Name="cShape"
                                    Content="Container"
                                    ItemsSource="{Binding Nodes}" />
    </telerik:RadDiagram>			  			  

![Rad Diagram Container Shape Items Source](images/RadDiagram_ContainerShape_ItemsSource.png)

### Container Bounds

You can get the bounds of the __RadDiagramContainerShape__ through the __ContainerBounds__ property, which is of type __Rect__ and it gets the width, height and location of the container’s bounds.			

## Collapsible ContainerShapes

With Q2 2013, you can make your __RadDiagramContainerShape__ collapsible. In order to use such a container in your solution, you simply need to set the __IsCollapsible__ property of the container to __True__.		

For instance, if you take the above __RadDiagramContainerShape__ data-bound definition, you can extend it to set the __IsCollapsible__ property to __True__ in the following manner:	  

#### __XAML__
    <telerik:RadDiagram x:Name="xDiagram">
        <telerik:RadDiagram.ShapeStyle>
            <Style TargetType="telerik:RadDiagramShape">
                <Setter Property="Position" Value="{Binding Position, Mode=TwoWay}" />
            </Style>
        </telerik:RadDiagram.ShapeStyle>
        <telerik:RadDiagram.ShapeTemplate>
            <DataTemplate>
                <TextBlock Text="{Binding Content}" />
            </DataTemplate>
        </telerik:RadDiagram.ShapeTemplate>
        <telerik:RadDiagramContainerShape x:Name="cShape"
                                          Content="Container"
                                          IsCollapsible="True"
                                          ItemsSource="{Binding Nodes}" />
    </telerik:RadDiagram>		  

This should result in the following layout:
![Rad Diagram Container Shape Collapsible](images/RadDiagram_ContainerShape_Collapsible.png)

Below you can find a list of all __RadDiagramContainerShape__ members that are related to the collapsible feature of the shape:

* __IsCollapsible__ - a property of type __bool__ that controls the collapsible state of a __RadDiagramContainerShape__.			

* __IsCollapsed__ - a property of type __bool__ that controls whether a collapsible __RadDiagramContainerShape__ is currently collapsed.			

* __CollapsedContent__ - gets or sets an __object__ that defines the content displayed inside a collapsed __RadDiagramContainerShape__.		  

#### __XAML__
    <telerik:RadDiagram x:Name="xDiagram">
        <telerik:RadDiagram.ShapeStyle>
            <Style TargetType="telerik:RadDiagramShape">
                <Setter Property="Position" Value="{Binding Position, Mode=TwoWay}" />
            </Style>
        </telerik:RadDiagram.ShapeStyle>
        <telerik:RadDiagram.ShapeTemplate>
            <DataTemplate>
                <TextBlock Text="{Binding Content}" />
            </DataTemplate>
        </telerik:RadDiagram.ShapeTemplate>
        <telerik:RadDiagramContainerShape x:Name="cShape"
                                          Content="Container"
                                          CollapsedContent="Collapsed!"
                                          IsCollapsible="True"
                                          ItemsSource="{Binding Nodes}" />
    </telerik:RadDiagram>

![Rad Diagram Container Shape Collapsed Content](images/RadDiagram_ContainerShape_CollapsedContent.png)

* __CollapsedContentTemplate__ -  gets or sets a __DataTemplate__ used to display the content inside a collapsed __RadDiagramContainerShape__.

* __IsCollapsedChanged__ - an event that is raised by a __RadDiagramContainerShape__ to inform that the collapsed state of the shape is changed.

## Interaction

Below you can find a list of the interactions supported by the __RadDiagramContainerShape__: 

* __Rotation__ - you can rotate only the __RadDiagramContainerShape__. This means that the rotation won't affect the container's children. You can find more information about shapes rotation in [this tutorial]({%slug raddiagrams-features-rotation%}).			

* __Translation__ - you can translate the __ContainerShape__ along with its children.			

* __Scaling__ - you can scale only the __ContainerShape__ without affecting its children scale. You can find more information about __RadDiagramItems__ resizing in [this tutorial]({%slug raddiagrams-features-resizing%}).			

* __Cut and Copy__ - these clipboard operations work only on the __ContainerShape__. The shapes inside the container won't be cut or copied. You can find more information about the clipboard operations supported in the __RadDiagram__ in [this tutorial]({%slug raddiagrams-features-clipboard%}).			

If you do wish to rotate, scale, cut or copy both the container and its children simultaneously, you can do so by dragging a selection rectangle around the container (instead of just clicking-selecting the container). This selection will contain both the container and the children thus allowing you to perform the aforementioned actions on all items at the same time.  

## Customize the ContainerShape Appearance

You can easily customize the visual appearance of the __RadDiagramContainerShape__ by using the following properties:		

* __Background__ - gets or sets the brush that specifies the __RadDiagramContainerShape__ background color.			

* __BorderBrush__ - gets or sets the brush that specifies the __RadDiagramContainerShape__ border color.			

* __BorderThickness__ - gets or sets the width of the __RadDiagramContainerShape__ outline.			

>tip You can use the __RadDiagram.ContainerShapeStyle__ property to explicitly apply a style on all __RadDiagramContainerShapes__ in a __RadDiagram__ instance.		  

# See Also
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Customize a ContainerShape]({%slug raddiagram-howto-customize-containers%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Custom Connectors]({%slug raddiagram-features-custom-connectors%})
 * [Grouping]({%slug raddiagram-features-grouping%})