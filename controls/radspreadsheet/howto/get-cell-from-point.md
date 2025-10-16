---
title: Get Cell from Point
page_title:  Get Cell from Point
description:  Get Cell from Point.
slug: radspreadsheet-get-cell-from-point
tags: cell, point, location
published: True
position: 10
---

# Get cell from Point

This article describes how you can get a cell index by using a specific location on the screen.

In order to get the cell under the mouse you need the position related to the top left corner of the grid that contains all cells. This is why you need to get the position relative to the WorksheetEditorPresenter. Then you can use the __GetCellIndexFromViewPoint__ method to get the cell under the mouse. 

#### __C# Example 1: Get the cell under the mouse__

```C#

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
        var worksheetEditor = this.radSpreadsheet.ActiveWorksheetEditor;
        if (worksheetEditor != null)
        {
            var presenter = worksheetEditor.ActivePresenter as NormalWorksheetEditorPresenter;
            presenter.PreviewMouseMove += Presenter_PreviewMouseMove;
        }
    }

    private void Presenter_PreviewMouseMove(object sender, MouseEventArgs e)
    {
        var presenter = sender as NormalWorksheetEditorPresenter;
        Point position = e.GetPosition(presenter);

        CellIndex clickedCellIndex = presenter.GetCellIndexFromViewPoint(position);
        string clickValue = String.Format("Hovered!");
        this.radSpreadsheet.ActiveWorksheet.Cells[clickedCellIndex].SetValue(clickValue);
    }

```

