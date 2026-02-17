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
```C#
    public class CustomCellEditUILayer : WorksheetUILayerBase
    {
        #region Constants

        public const string CustomCellEditUILayerName = "CustomCellButtonUILayer";

        #endregion


        #region Properties

        public override string Name
        {
            get
            {
                return CustomCellEditUILayerName;
            }
        }

        #endregion


        #region Constructors

        public CustomCellEditUILayer(RadSpreadsheet sheet)
        {
            this.ContainerManager.UILayerContainer.IsHitTestVisible = true;
        }

        #endregion


        #region Methods

        private void CalculateCellEditorSize(RadButton button, CellLayoutBox activeCellBox)
        {
            if (activeCellBox == null)
            {
                return;
            }

            if (button != null)
            {
                button.Width = activeCellBox.Width;
                button.Height = activeCellBox.Height;

                Canvas.SetLeft(button, activeCellBox.Left);
                Canvas.SetTop(button, activeCellBox.Top);
            }
        }

        public override void UpdateUIOverride(WorksheetUIUpdateContextBase updateContext)
        {
            this.Clear();

            WorksheetUIUpdateContext worksheetUIUpdateContext = updateContext as WorksheetUIUpdateContext;

            if (worksheetUIUpdateContext == null || !worksheetUIUpdateContext.WorksheetEditor.Selection.IsCellSelection)
            {
                return;
            }

            SheetViewport viewport = updateContext.SheetViewport;

            for (int paneIndex = 0; paneIndex < viewport.ViewportPanesCount; paneIndex++)
            {
                var pane = viewport.ViewportPanes[paneIndex];
                CellRange visibleRange = pane.VisibleRange;

                for (int i = visibleRange.FromIndex.RowIndex; i <= visibleRange.ToIndex.RowIndex; i++)
                {
                    CellIndex cellIndex = new CellIndex(i, Constants.ButtonColumnIndex);
                    if (this.Worksheet.UsedCellRange.Contains(cellIndex))
                    {
                        RadButton button = this.GetElementFromPool<RadButton>(pane.ViewportPaneType);
                        button.Content = "Show age";
                        button.Click += this.Button_Click;
                        button.Tag = cellIndex;

                        this.CalculateCellEditorSize(button, updateContext.GetVisibleCellBox(cellIndex));
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CellIndex cellIndex = (sender as Button).Tag as CellIndex;
            ICellValue cellValue = this.Owner.Worksheet.Cells[cellIndex].GetValue().Value;
            MessageBox.Show("Age: " + cellValue.RawValue);
        }

        protected override void TranslateAndScale(UIUpdateContext updateContext)
        {
            ScaleTransform scaleTransform = new ScaleTransform
            {
                ScaleX = updateContext.ScaleFactor.Width,
                ScaleY = updateContext.ScaleFactor.Height,
            };

            this.ContainerManager.SetRenderTransform(updateContext, scaleTransform);
        }

        protected override void ResetPooledElementProperties(object element)
        {
            RadButton button = element as RadButton;
            if (button != null)
            {
                button.Click -= this.Button_Click;
                button.Tag = null;
            }
        }

        #endregion
    }
```

__Creating the custom layers builder and registering the custom layer__
```C#
    public class CustomLayersBuilder : WorksheetUILayersBuilder
    {
        private readonly RadSpreadsheet radSpreadsheet;
        private CustomCellEditUILayer cellEditorLayer;

        public CustomLayersBuilder(RadSpreadsheet radSpreadsheet)
        {
            this.radSpreadsheet = radSpreadsheet;
        }

        public override void BuildUILayers(UILayerStack<WorksheetUILayerBase> uiLayers)
        {
            this.cellEditorLayer = new CustomCellEditUILayer(this.radSpreadsheet);
            base.BuildUILayers(uiLayers);
            uiLayers.Remove(this.cellEditorLayer);
            uiLayers.AddLast(this.cellEditorLayer);
        }

        public RadSpreadsheet RadSpreadsheet
        {
            get
            {
                return this.radSpreadsheet;
            }
        }
    }
```

__Registering the custom layers builder__
```C#
    this.radSpreadsheet.WorksheetUILayersBuilder = new CustomLayersBuilder(this.radSpreadsheet);
```

>tip To download a runnable project with the example from this article, visit our [SDK repository](https://github.com/telerik/xaml-sdk/). You can find the example in the __Spreadsheet/WPF/CustomUILayer__ folder.