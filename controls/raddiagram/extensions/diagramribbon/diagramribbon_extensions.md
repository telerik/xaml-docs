---
title: Extensions
page_title: Extensions
description: This article will get you familiar with the RadDiagramRibbon control extensions.
slug: raddiagram-extensions-diagramribbon-extensions
tags: diagram,ribbon,extensions
published: True
position: 1
---

# Extensions

The __RadDiagramRibbon__ control allows you to easily add one or all of the following RadDiagram and RadRibbonView extensions. This way you can give the user ability to show/hide any of the specified extensions dynamically.

#### __Figure 1: DiagramRibbon Extensions__ 
![Diagram Ribbon Overview](images/RadDiagram_DiagramRibbon_Extensions.png)

## RadDiagramToolBox

To add a __RadDiagramToolbox__ to the RadDiagramRibbon control, you can bind the __ToolBox__ property to a RadDiagramToolBox using an ElementName binding.

__Example 1: Add RadDiagramToolbox to DiagramRibbon__
<snippet id='raddiagram-extensions-diagramribbon-diagramribbon-extensions-example_1_add_raddiagramtoolbox_to_diagramribbon-xaml' />


## DiagramNavigationPane

To add a __RadDiagramNavigationPane__ to the RadDiagramRibbon control, you can bind the __NavigationPane__ property to a RadDiagramNavigationPane using an ElementName binding.

__Example 2: Add RadDiagramNavigationPane to DiagramRibbon__
<snippet id='raddiagram-extensions-diagramribbon-diagramribbon-extensions-example_2_add_raddiagramnavigationpane_to_diagramribbon-xaml' />


## RadDiagramRuler

To add a __RadDiagramRuler__ to the DiagramRibbon the __VerticalRuler__ and __HorizontalRuler__ properties can be bound to RadDiagramRuler instances using an ElementName binding.

__Example 3: Add RadDiagramRuler to DiagramRibbon__
<snippet id='raddiagram-extensions-diagramribbon-diagramribbon-extensions-example_3_add_raddiagramruler_to_diagramribbon-xaml' />


## QuickAccessToolBar

To add __QuickAccessToolBar__ to the DiagramRibbon you can bind the **QuickAccessToolBar** property a QuickAccessToolBar instance using an ElementName binding.

__Example 4: Add QuickAccessToolBar to DiagramRibbon__
<snippet id='raddiagram-extensions-diagramribbon-diagramribbon-extensions-example_4_add_quickaccesstoolbar_to_diagramribbon-xaml' />


## RadRibbonBackstage

To add a __Backstage__ to the DiagramRibbon you can use the __Backstage__ property and declare a __RadRibbonBackstage__ element.

__Example 5: Add Backstage to DiagramRibbon__
<snippet id='raddiagram-extensions-diagramribbon-diagramribbon-extensions-example_5_add_backstage_to_diagramribbon-xaml' />


## See Also

* [Getting Started]({%slug raddiagram-getting-started%})
* [DiagramExtensions ViewModels]({%slug raddiagram-data-extensionsviewmodels%})
* [Extensions Overview]({%slug raddiagram-extensions%})