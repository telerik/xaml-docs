---
title: Backwards Compatibility
page_title: Backwards Compatibility
description: Backwards Compatibility
slug: radspreadprocessing-backwards-compatibility
tags: backwards,compatibility
published: True
position: 1
---

# Backwards Compatibility



This article will list the breaking changes and how they can be fixed when upgrading from a specific version of the controls to the next one.



## What's Different in 2015 Q2

__Changed__

Telerik.Windows.Documents.Spreadsheet.Layout.Layers.WorksheetRenderUpdateContext::__ViewportPaneTypeToVisibleCellBoxes__ property is removed.

__What to do now__
 
Use Telerik.Windows.Documents.Spreadsheet.Layout.Layers.WorksheetRenderUpdateContext::__VisibleCellLayoutBoxes__ property instead.


__Changed__

Telerik.Windows.Documents.Spreadsheet.Measurement.__FontManager__ is removed.

__What to do now__

Use Telerik.Windows.Documents.Core.Fonts.__SystemFontsManager__ class instead.


__Changed__

Telerik.Windows.Documents.Spreadsheet.Model.SpreadsheetNameCollectionScope::__Name__ property is removed.


__Changed__

Telerik.Windows.Documents.Spreadsheet.Model.SelectionState::__SelectionState(IEnumerable selectedRanges, CellIndex activeCellIndex)__ constructor is removed.


__What to do now__     

Use Telerik.Windows.Documents.Spreadsheet.Model.SelectionState::__SelectionState(IEnumerable selectedRanges, CellIndex activeCellIndex, ViewportPaneType pane)__ constructor instead.


__Changed__

Telerik.Windows.Documents.Spreadsheet.Utilities.UnitHelper::__EMUsToDIP(int value)__ is removed.

__What to do now__

Use __EmuToDip(double value)__ method instead.



## What's Different in 2014 Q3

__Changed__

The default value of the IsEnabled property of the WorkbookHistory class is changed to false.
        

__What to do now__

You can enable the history of a Workbook by setting the property to true.
        

__Changed__

The Width, Height and RotationAngle properties of the FloatingShapeBase class no longer update the CellIndex, OffsetX and OffsetY properties.
        

__What to do now__

If it is necessary for them to be updated automatically, the SetWidth, SetHeight and SetRotationAngle methods can be used instead with the bool adjustCellIndex parameter set to true.
        

__Changed__

String Name property of SpreadsheetNameCollectionScope is marked obsolete.
        

__What to do now__

The property is related to the RadSpreadsheet UI control and is not used in the processing library.
        
