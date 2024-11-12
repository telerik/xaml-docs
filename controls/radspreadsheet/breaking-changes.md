---
title: Breaking Changes
page_title: Backward Compatibility
description: Check our &quot;Backward Compatibility&quot; documentation article for the RadSpreadsheet {{ site.framework_name }} control.
slug: radspreadsheet-backward-compatibility
tags: backward,compatibility
published: True
position: 5
---

# Breaking Changes

This article lists the breaking changes and how they can be fixed when upgrading from a specific version of the controls to the next one.

## What's Different in 2018 R2

### Changed

The default value of Telerik.Windows.Documents.Spreadsheet.Model.Printing.SheetPageSetupBase::**PaperType** has been changed from `A4` to `Letter`.

### What to do now

If you need to keep the document with A4 PaperType, you can apply this setting before exporting it:

#### __[C#]__

{{region radspreadprocessing-backward-compatibility_0}}  
	foreach (Worksheet worksheet in workbook.Worksheets)
	{
		worksheet.WorksheetPageSetup.PaperType = PaperTypes.A4;
	}
{{endregion}}

## What's Different in 2016 R3

### Changed

Telerik.Windows.Controls.Spreadsheet.Controls::**ProtectionButton** is obsolete. 

### What to do now

The control can be replaced with any other button.

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

Use Telerik.Windows.Documents.Spreadsheet.Layout.Layers.WorksheetRenderUpdateContext::__VisibleCellLayoutBoxes__  property instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.WorksheetUIUpdateContextBase::__ViewportPaneTypeToVisibleCellBoxes__ property is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.WorksheetUIUpdateContextBase::__VisibleCellLayoutBoxes__  property instead.

### Changed

Telerik.Windows.Documents.Spreadsheet.Measurement.__FontManager__ is removed.

### What to do now

Use Telerik.Windows.Documents.Core.Fonts.__SystemFontsManager__ class instead.

### Changed

Telerik.Windows.Documents.Spreadsheet.Model.SpreadsheetNameCollectionScope::__Name__ property is removed.

### What to do now

Use the ScopeName property of the Telerik.Windows.Controls.Spreadsheet.Dialogs.__SpreadsheetNameView__ class instead.

### Changed

Telerik.Windows.Documents.Spreadsheet.Model.SelectionState::__SelectionState(IEnumerable<CellRange> selectedRanges, CellIndex activeCellIndex)__ constructor is removed.

### What to do now

Use Telerik.Windows.Documents.Spreadsheet.Model.SelectionState::__SelectionState(IEnumerable<CellRange> selectedRanges, CellIndex activeCellIndex, ViewportPaneType pane)__ constructor instead.

### Changed

Telerik.Windows.Documents.Spreadsheet.Utilities.UnitHelper::__EMUsToDIP(int value)__ is removed.

### What to do now

Use __EmuToDip(double value)__ method instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Controls.PrintWhatDropDownItemModel::__PrintWhat__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Controls.PrintWhatDropDownItemModel::__ExportWhat__ property instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Dialogs.NameManagerDialogViewModel::__SpreadsheetNames__ is removed.

### What to do now

Use the Telerik.Windows.Controls.Spreadsheet.Dialogs.NameManagerDialogViewModel::__SpreadsheetNameViews__ property instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Dialogs.NameManagerDialogViewModel::__SelectedSpreadsheetName__ is removed.

### What to do now

Use the __SelectedSpreadsheetNameView__ property instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.IRadSheetEditor::__Viewport__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.IRadSheetEditor::__SheetViewport__ property instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Layers.UILayer::__Container__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Layers.UILayer::__ContainerManager__ property instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Layers.UILayer::__GetAddedUIElements__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Layers.UILayer::__GetAddedUIElements(ViewportPaneType viewportPaneType)__ instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.__PrintWhat__ is removed.

### What to do now

Use Telerik.Windows.Documents.Spreadsheet.FormatProviders.__ExportWhat__ enum instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.Margins.IRowColumnHeadingMargin::__Container__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.Margins.IRowColumnHeadingMargin::__ContainerManager__ property instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.BoxBasedUILayer<Т>::__GetAssociatedBoxForUIElement(UIElement uiElement)__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.BoxBasedUILayer<Т>::__GetAssociatedBoxForUIElement(ViewportPaneType viewportPaneType, UIElement uiElement)__ instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.BoxBasedUILayer<Т>::__GetAssociatedUIElementForBox(T box)__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.BoxBasedUILayer<Т>::__GetAssociatedUIElementForBox(ViewportPaneType viewportPaneType, T box)__ instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.BoxBasedUILayer<Т>::__IsUIElementValidOverride(T box, WorksheetUIUpdateContext updateContext)__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.BoxBasedUILayer<Т>::__IsUIElementValidOverride(T box, WorksheetUIUpdateContextBase updateContext)__ instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.BoxBasedUILayer<Т>::__GetVisibleBoxes(WorksheetUIUpdateContext updateContext)__ is removed.

### What to do now

Use __GetVisibleBoxes(ViewportPaneType viewportPaneType, WorksheetUIUpdateContextBase updateContext)__ instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.BoxBasedUILayer<Т>::__CreateUIElementForBox(T box, WorksheetUIUpdateContext updateContext)__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.BoxBasedUILayer<Т>::__CreateUIElementForBox(ViewportPaneType viewportPaneType, T box, WorksheetUIUpdateContextBase updateContext)__ instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.BoxBasedUILayer<Т>::__SetUIElementPropertiesForBox(UIElement uiElement, T box, WorksheetUIUpdateContext updateContext)__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.BoxBasedUILayer<Т>::__SetUIElementPropertiesForBox(UIElement uiElement, T box, WorksheetUIUpdateContextBase updateContext)__ instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.RadSheetEditorBase::__Viewport__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.RadSheetEditorBase::__SheetViewport__ property instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.UIUpdateContext::__Viewport__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.UIUpdateContext::__SheetViewport__ property instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.UIUpdateContext::__Translate(Point point)__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.UIUpdateContext::__Translate(Point point, ViewportPaneType viewportPaneType)__ instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.Commands.Descriptors.__ActiveCellDependentCommandDescriptor__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Commands.Descriptors.__CommandDescriptor__ class instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.Commands.Descriptors.__HistoryDependentCommandDescriptor__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Commands.Descriptors.__CommandDescriptor__ class instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.Commands.Descriptors.__SelectionDependentCommandDescriptor__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Commands.Descriptors.__CommandDescriptor__ class instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.Commands.Descriptors.__SheetCollectionDependentCommandDescriptor__  is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Commands.Descriptors.__CommandDescriptor__ class instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.IRadWorksheetEditorPresenter::__VisibleCellRange__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.IRadWorksheetEditorPresenter::__SheetViewport__ property instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.IRadWorksheetEditorPresenter::__Viewport__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.IRadWorksheetEditorPresenter::__SheetViewport__ property instead.


### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.WorksheetUILayerBase::__UpdateUIOverride(WorksheetUIUpdateContext updateContext)__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.Layers.WorksheetUILayerBase::__UpdateUIOverride(WorksheetUIUpdateContextBase updateContext)__ instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.RadWorksheetEditorHistoryState::__SelectionState__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.RadWorksheetEditorHistoryState::__SheetViewState__ property instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.RadWorksheetEditorPresenterBase::__UpdateHorizontalScrollBar(Rect viewport, double smallChange)__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.RadWorksheetEditorPresenterBase::__UpdateHorizontalScrollBar(SheetViewport sheetViewport, double smallChange)__ instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.RadWorksheetEditorPresenterBase::__UpdateVerticalScrollBar(Rect viewport, double smallChange)__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.RadWorksheetEditorPresenterBase::__UpdateVerticalScrollBar(SheetViewport sheetViewport, double smallChange)__ instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.RadWorksheetEditorPresenterBase::__ViewportChanged__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.RadWorksheetEditorPresenterBase::__SheetViewportChanged__ event instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Worksheets.RadWorksheetEditorPresenterBase::__OnViewportChanged__ is removed.

### What to do now

Use Telerik.Windows.Controls.Spreadsheet.Worksheets.RadWorksheetEditorPresenterBase::__OnSheetViewportChanged__ instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.Controls.PrintWhatDropDownItemModel::__PrintWhat__ is removed.

### What to do now

Use __ExportWhat__ property instead.

### Changed

Telerik.Windows.Controls.Spreadsheet.PrintWhatSettings::__PrintWhat__ is removed.

### Changed

Telerik.Windows.Controls.Spreadsheet.PrintWhatSettings::__PrintWhatSettings__ is removed.

### What to do now

Use __PrintWhatSettings(ExportWhat exportWhat, bool ignorePrintArea)__ constructor instead.

### Changed

Telerik.Windows.Controls.__IconManager__ is removed.

### What to do now

Use __IconResource__ MarkupExtension instead. You can read more about the markup extension at [the common Switching Icons at Runtime article]({%slug styling-apperance-switching-icons-at-runtime%}) and [the one for Spreadsheet]({%slug radspreadsheet-howto-switching-icons-at-runtime%}).

## What's Different in 2015 Q1

### Changed

__CellEditorBase__ no longer inherits from __Textbox__.

### Changed

Removed __CellEditor__'s InsertText(string), SetText(string, int), SetText(string) and ClearContent() methods.

### What to do now

Use the Text property.

### Changed

__ICellEditor__ interface:

* Changed the __TextChanged__ type from TextChangedEventHandler to EventHandler
* Changed the __SelectionChanged__ type from RoutedEventHandler to EventHandler
* Removed the __int CaretIndex__ property

### Changed      

The __DocumentContentChanged__ event of __CellEditor__ is obsolete.

### What to do now

Use the __TextChanged__ event instead.

## What's Different in 2014 Q3

### Changed

The __IsEnabled__ property of the WorkbookHistory class is changed to be by default false. . It is set to true when the Workbook is assigned to a RadSpreadsheet.            

### What to do now

If you are modifying a Workbook without showing it in RadSpreadsheet and need to preserve the history, set the IsEnabled property to true.            

## What's Different in 2014 Q1

### Changed

The __NameBox__ class uses a ViewModel.            

### What to do now

Use the properties of the __NameBoxViewModel__.