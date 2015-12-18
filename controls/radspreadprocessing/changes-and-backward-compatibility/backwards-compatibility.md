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

## What's Different in 2016 Q1

### Changed

**Telerik.Windows.Maths.dll** is removed and integrated in Telerik.Windows.Documents.Spreadsheet.

### Changed

Telerik.Windows.Maths::**InterpolationExtensions** is now internal.

### Changed

Telerik.Windows.Maths::**RVector** is now internal.

### Changed

Telerik.Windows.Documents.Spreadsheet.Expressions.Functions::**FunctionBase.Evaluate(RadExpression[] arguments)** method is obsolete.

### What to do now

Use Telerik.Windows.Documents.Spreadsheet.Expressions.Functions::**FunctionBase.Evaluate(FunctionEvaluationContext context)** instead.

### Changed

Telerik.Windows.Documents.Spreadsheet.Expressions.Functions::**FunctionBase.EvaluateOverride(RadExpression[] arguments)** is obsolete.

### What to do now

Use Telerik.Windows.Documents.Spreadsheet.Expressions.Functions::**FunctionBase.EvaluateOverride(FunctionEvaluationContext context)** instead.


### Changed

Telerik.Windows.Documents.Spreadsheet.Expressions.Functions::**FunctionWithArguments.EvaluateOverride(object[] arguments)** is obsolete.

### What to do now

Use Telerik.Windows.Documents.Spreadsheet.Expressions.Functions::**FunctionWithArguments.EvaluateOverride(FunctionEvaluationContext&lt;object&gt; context)** instead.

### Changed

Telerik.Windows.Documents.Spreadsheet.Expressions.Functions::**FunctionWithSameTypeArguments&lt;T&gt;.EvaluateOverride(T[] arguments)** instead.

### What to do now

Use Telerik.Windows.Documents.Spreadsheet.Expressions.Functions::**FunctionWithSameTypeArguments&lt;T&gt;.EvaluateOverride(FunctionEvaluationContext&lt;T&gt; context)** instead.



## What's Different in 2015 Q2

### Changed

Telerik.Windows.Documents.Spreadsheet.Layout.Layers.WorksheetRenderUpdateContext::__ViewportPaneTypeToVisibleCellBoxes__ property is removed.

### What to do now
 
Use Telerik.Windows.Documents.Spreadsheet.Layout.Layers.WorksheetRenderUpdateContext::__VisibleCellLayoutBoxes__ property instead.


### Changed

Telerik.Windows.Documents.Spreadsheet.Measurement.__FontManager__ is removed.

### What to do now

Use Telerik.Windows.Documents.Core.Fonts.__SystemFontsManager__ class instead.


### Changed

Telerik.Windows.Documents.Spreadsheet.Model.SpreadsheetNameCollectionScope::__Name__ property is removed.


### Changed

Telerik.Windows.Documents.Spreadsheet.Model.SelectionState::__SelectionState(IEnumerable selectedRanges, CellIndex activeCellIndex)__ constructor is removed.


### Changed 

Use Telerik.Windows.Documents.Spreadsheet.Model.SelectionState::__SelectionState(IEnumerable selectedRanges, CellIndex activeCellIndex, ViewportPaneType pane)__ constructor instead.


### Changed

Telerik.Windows.Documents.Spreadsheet.Utilities.UnitHelper::__EMUsToDIP(int value)__ is removed.

### What to do now

Use __EmuToDip(double value)__ method instead.



## What's Different in 2014 Q3

### Changed

The default value of the IsEnabled property of the WorkbookHistory class is changed to false.
        

### What to do now

You can enable the history of a Workbook by setting the property to true.
        

### Changed

The Width, Height and RotationAngle properties of the FloatingShapeBase class no longer update the CellIndex, OffsetX and OffsetY properties.
        

### What to do now

If it is necessary for them to be updated automatically, the SetWidth, SetHeight and SetRotationAngle methods can be used instead with the bool adjustCellIndex parameter set to true.
        

### Changed

String Name property of SpreadsheetNameCollectionScope is marked obsolete.
        

### What to do now

The property is related to the RadSpreadsheet UI control and is not used in the processing library.
        
