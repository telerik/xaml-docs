---
title: Worksheet UI Layers Builder
page_title: Worksheet UI Layers Builder
description: Check our &quot;Worksheet UI Layers Builder&quot; documentation article for the RadSpreadsheet {{ site.framework_name }} control.
slug: radspreadsheet-worksheet-ui-layers-builder
tags: worksheet,ui,layers,builder
published: True
position: 14
---

# Worksheet UI Layers Builder

The `RadSpreadsheet` control has a built-in mechanism for building the UI layers of the worksheet. Each UI layer is responsible for rendering a specific aspect of the worksheet. They are added via the `WorksheetUILayersBuilder` property of the RadSpreadsheet control. The following list is the default set of UI layers that are added via the `WorksheetUILayersBuilder` class:

* `GridlinesUILayer`
* `CellFillUILayer`
* `CellBordersUILayer`
* `BarsUILayer`
* `IconsUILayer`
* `CellValuesUILayer`
* `PageBreaksUILayer`
* `PrintAreaUILayer`
* `SelectionUILayer`
* `CellInputUILayer`
* `ResizeDecorationUILayer`
* `FilteringUILayer`
* `ShapesUILayer`
* `AdornerUILayer`
* `DataValidationListUILayer`
* `PaneSeparatorsUILayer`
* `DataValidationCirclesUILayer`
* `DataValidationInputMessageUILayer`
* `NotesUILayer`
* `CommentsUILayer`

## Custom Layers

RadSpreadsheet allows you to customize the UI layers by adding your own custom layers or by removing existing ones. You can do this by creating a new class that inherits from `WorksheetUILayersBuilder` class and overriding the `BuildUILayers` method. In this method, you can add your custom layers or remove existing ones. Once you have created your custom `WorksheetUILayersBuilder`, you can assign it to the `WorksheetUILayersBuilder` property of the RadSpreadsheet control.

To create custom layers, you can add a new class that inherits from the `WorksheetUILayerBase` class and implements the necessary logic for rendering the layer. Then, you can add an instance of your custom layer to the `UILayers` collection in the `BuildUILayers` method of your custom `WorksheetUILayersBuilder`.

__Creating a custom layer__
<snippet id='radspreadsheet-features-worksheetuilayersbuilder-block_1-cs' />

__Creating the custom layers builder and registering the custom layer__
<snippet id='radspreadsheet-features-worksheetuilayersbuilder-block_2-cs' />

__Registering the custom layers builder__
<snippet id='radspreadsheet-features-worksheetuilayersbuilder-block_3-cs' />

>tip To download a runnable project with the example from this article, visit our [SDK repository](https://github.com/telerik/xaml-sdk/). You can find the example in the __Spreadsheet/WPF/CustomUILayer__ folder.