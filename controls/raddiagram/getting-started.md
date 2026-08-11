---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagram-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started with {{ site.framework_name }} Diagram

Telerik __RadDiagrams__ are a powerful diagramming framework that can bring to life your rich data-visualization scenarios. This tutorial will walk you through the main concepts and tools of the diagramming framework and help you to create the flow diagram of an "if-else" operator.

#### __Figure 1: Flow diagram example__  
![Rad Diagram Getting Started Sample](images/RadDiagram_GettingStartedSample.png)

## Adding Telerik Assemblies Using NuGet

To use `RadDiagram` when working with NuGet packages, install the `Telerik.Windows.Controls.Diagrams.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Diagrams__
* __Telerik.Windows.Diagrams.Core__

To use the RadDiagram [MVVM support]({%slug raddiagram-data-extensionsviewmodels%}) or one of the extensions tools like the [settings pane]({%slug raddiagram-extensions-settingspane-overview%}) or the [toolbox]({%slug raddiagram-extensions-toolbox%}) you will need to add reference also to the following assemblies:

* __Telerik.Windows.Controls.Diagrams.Extensions__ 
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Controls.Navigation__

The following picture shows the interdependency between the RadDiagram main assemblies. Note that the Telerik.Windows.Controls.Diagrams.Extensions relies also on Telerik.Windows.Controls.Input and Telerik.Windows.Controls.Navigation.

#### __Figure 2: Interdependency of the RadDiagram control main assemblies__  
![Rad Diagram Getting Started Dependancies](images/RadDiagram_GettingStarted_Dependancies.png)

>tip You can find more info about the __Telerik UI for WPF__ dependencies in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Graph Object Model

The __Graph Object Model__ is the main concept behind the diagramming framework. It contains the following three main objects:		

* __Graph__ - this is the structure that contains the __RadDiagramShapes__ and __RadDiagramConnections__. In the __Telerik Diagramming Framework__, the graph is represented by the __RadDiagram__ class.

* __Shape__ - the shape describes a node of a __Graph__ that in the __Telerik Diagramming Framework__ is represented by the __RadDiagramShape__ class.			

* __Connection__ - the connection describes the edges of the graph and it is basically an object that connects zero, one or two shapes. In the __Telerik Diagramming Framework__, the connection is represented by the __RadDiagramConnection__ class.			

>tip The __RadDiagram__ items are represented by the __RadDiagramItem__ class. Therefore, both __RadDiagramConnection__ and __RadDiagramShape__ classes derive from the __RadDiagramItem__ class.		  

>important In order to populate the __RadDiagram__ with __RadDiagramItems__, you can add __RadDiagramShapes__ and __RadDiagramConnections__ in the __RadDiagram.Items__ collection from code-behind ([read more]({%slug raddiagram-data-code-behind%})) or declaratively in xaml ([read more]({%slug raddiagram-data-declaratively%})). Also, because the __RadDiagram__ control is a data-driven control, it supports data binding. In order to bind the __RadDiagram__ to a collection, you can use its __GraphSource__ property. Note that when the __GraphSource__ property is set, the __Items__ collection is made read-only and fixed-size.  For more information, please refer to the [DataBinding]({%slug raddiagram-data-databinding%}) tutorial.	

>Please note that the examples in this tutorial are showcasing the Telerik Windows8 theme. In the {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.		

## Setting Up the Drawing Canvas

Before proceeding with adding __RadDiagram__ to your project, make sure the required assembly references are added to the project. When you want to create a diagram in your application, you first need to add the __RadDiagram__ control, as it represents the main canvas onto which the diagramming tools and shapes are drawn.		

__Example 1: Adding RadDiagram in XAML__  
<snippet id='raddiagram-getting-started-example_1_adding_raddiagram_in_xaml-xaml' />


#### __Figure 3: Default drawing canvas:__  
![Rad Diagram Getting Started](images/RadDiagram_GettingStarted.png)

> __RadDiagram__ exposes a set of properties that allow you to customize the graph layout and operations. For example, you can set up the active mouse tool, specify if a cut, copy, paste or delete operation is allowed, and customize the background color, the cells' height and width as well as the __GridLine__ thickness of the drawing canvas.		  

## Adding RadDiagramShapes

In order to create a diagram describing the flow of an "if-else" operator, you will need four shapes - two will represent the statements, one will describe the condition and one will represent the final result of the operator.

Let's start with the condition of the "if-else" operator. In a block diagram, a condition is usually described by a diamond shape, called a __decision__ shape.		

>tip The __RadDiagramShape__ exposes a __Geometry__ property that allows you to create a custom geometry or use predefined shape geometry. The predefined shape geometries in the __Telerik Diagramming Framework__ are described by the __ArrowShape__, __CommonShape__ and __FlowChartShape__ extension classes. For more information, pelase refer to the [DiagramShapes]({%slug raddiagrams-features-shapes%}) tutorial.		  

__Example 2: Adding RadDiagramShape in XAML__  
<snippet id='raddiagram-getting-started-example_2_adding_raddiagramshape_in_xaml-xaml' />


#### __Figure 4: DecisionShape default visual look__  
![Rad Diagram Getting Started Decision Shape](images/RadDiagram_GettingStarted_DecisionShape.png)

You can define the size of the shape and set its __Content__ and __x:Name__ properties to better describe it.		

__Example 3: Customize DecisionShape in XAML__  
<snippet id='raddiagram-getting-started-example_3_customize_decisionshape_in_xaml-xaml' />


#### __Figure 5: Customized DecisionShape visual look__  
![Rad Diagram Getting Started Decision Shape Cont](images/RadDiagram_GettingStarted_DecisionShapeCont.png)

To describe the statements of the "if-else" operator you can use the default geometry of the __RadDiagramShape__.		

__Example 4: Setting default geometry of the RadDiagramShape in XAML__  
<snippet id='raddiagram-getting-started-example_4_setting_default_geometry_of_the_raddiagramshape_in_xaml-xaml' />


#### __Figure 6: RadDiagramShapes without its Position property set__  
![Rad Diagram Getting Started Diagram Shape](images/RadDiagram_GettingStarted_DiagramShape.png)

Adding multiple shapes in the __RadDiagram__ without setting their position, by default, will position all shapes at the top left corner of the drawing canvas. In order to rearrange their layout, you need to set the __Position__ property of each shape. This property is of type __Point__ and it gets or sets the coordinates of the top left point of a shape.		

__Example 5: Set the Position property in XAML__  
<snippet id='raddiagram-getting-started-example_5_set_the_position_property_in_xaml-xaml' />


#### __Figure 7: RadDiagramShape with its Position property set__  
![Rad Diagram Getting Started Position Shapes](images/RadDiagram_GettingStarted_PositionShapes.png)

To describe the final result of the operator you can use an ellipse shape. __Telerik Diagramming Framework__ provides such a predefined shape. You can find a shape of type __EllipseShape__ in the __CommonShape__ extension class.		

__Example 6: Declaring EllipseShape in XAML__  
<snippet id='raddiagram-getting-started-example_6_declaring_ellipseshape_in_xaml-xaml' />


#### __Figure 8: Customized EllipseShape look__  
![Rad Diagram Getting Started Start Shape](images/RadDiagram_GettingStarted_StartShape.png)

>tip The __RadDiagramItem__ class exposes __ContentTemplate__ and __ContentTemplateSelector__ properties that allow you to customize the content of the __RadDiagramShapes__ and __RadDiagramConnections__.		  

You can customize the content of the ellipse __RadDiagramShape__ to mark it as the end of the "if-else" flow diagram.		

__Example 7: Customize EllipseShape in XAML__  
<snippet id='raddiagram-getting-started-example_7_customize_ellipseshape_in_xaml-xaml' />


#### __Figure 9: Customized EllipseShape__

![Rad Diagram Getting Started Shapes](images/RadDiagram_GettingStartedShapes.png)

## Adding RadDiagramConnections

Finally, you can connect all shapes using __RadDiagramConnections__.		

>tip The __RadDiagramConnection__ class exposes a set of properties that allow you to define and customize the source and target of the connection. For more information, please refer to the [DiagramConnection]({%slug raddiagrams-features-connections%}) tutorial.		  

In order to connect the shapes and finish the flow diagram of the "if-else" operator, you need to set up 5 connections: 

* Add connections between the 'condition' shape and the 'statements' shapes:			

	__Example 8: Adding RadDiagramConnection in XAML__  
	<snippet id='raddiagram-getting-started-example_8_adding_raddiagramconnection_in_xaml-xaml' />


	#### __Figure 10: RadDiagramConnection visual example__
	![Rad Diagram Getting Started Condition Connect](images/RadDiagram_GettingStartedConditionConnect.png)

* Add connections between the 'statements' shape and the 'final result' shapes:		

	__Example 9: Add connection between shapes__
	<snippet id='raddiagram-getting-started-example_9_add_connection_between_shapes-xaml' />


	#### __Figure 11: RadDiagramConnection visual example__
	![Rad Diagram Getting Started End Connection](images/RadDiagram_GettingStartedEndConnection.png)

* Add the connection that points to the start of the operator:			

	__Example 10: Setting custom DataTemplate to RadDiagramConnection__
	<snippet id='raddiagram-getting-started-example_10_setting_custom_datatemplate_to_raddiagramconnection-xaml' />

	
	#### __Figure 12: Customized RadDiagramConnection__
	![Rad Diagram Getting Started Start Connection](images/RadDiagram_GettingStartedStartConnection.png)

## RadDiagram Example - "if-else" Operator Flow Diagram

You can find the final XAML definition of the "if-else" flow diagram in __Example 11__.

__Example 11: Final "if-else" flow diagram XAML__
<snippet id='raddiagram-getting-started-example_11_final_if_else_flow_diagram_xaml-xaml' />


#### __Figure 13: "if-else" operator flow diagram visual look__  
![Rad Diagram Getting Started Result](images/RadDiagram_GettingStartedResult.png)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#Diagrams/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadDiagram__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Diagrams__
	* __Telerik.Windows.Controls.Diagrams.Extensions__ 
	* __Telerik.Windows.Controls.Input__
	* __Telerik.Windows.Controls.Navigation__

__Example 12__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

__Example 12: Merge the ResourceDictionaries__  
<snippet id='raddiagram-getting-started-example_12_merge_the_resourcedictionaries-xaml' />


>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 14__ shows a __RadDiagram__ with the **Windows8** theme applied.

#### __Figure 14: RadDiagram with the Windows8 theme__
![RadDiagram with Windows8 theme](images/raddiagram-setting-theme.png)


{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF Diagrams Component](https://www.telerik.com/products/wpf/diagrams.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-guide%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Items Editing]({%slug raddiagrams-features-edit%})
 * [Removing Items]({%slug raddiagrams-features-delete%})
 * [Mouse Tools]({%slug raddiagrams-features-mouse-tools%})
 * [Keyboard Support]({%slug raddiagrams-features-shortcuts%})
 * [Rotation]({%slug raddiagrams-features-rotation%})
 * [Resizing]({%slug raddiagrams-features-resizing%})
 * [ZOrder]({%slug raddiagrams-features-zorder%})
 * [Selection]({%slug raddiagrams-features-selection%})
 * [Diagram Events]({%slug raddiagrams-events-diagram%})
 * [Items Events]({%slug raddiagrams-events-item%})
 * [Customized Appearance]({%slug raddiagram-styling-appearance%})
 * [Global Settings]({%slug raddiagram-features-global-settings%})

