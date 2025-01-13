---
title: 2024 Releases
description: Handle the changes in the 2024 releases of the Telerik UI for WPF components.
page_title: Breaking Changes in Telerik UI for WPF 2024
slug: breaking-changes-2024-releases
position: 1
---

# 2024 Releases

This article lists the breaking changes introduced with the Telerik UI for WPF releases in 2024. For the complete list of changes in the UI components, see the [product release history](https://www.telerik.com/support/whats-new/wpf/release-history).

In 2024 there are breaking changes only in the Q2 and Q4 releases.

Currently, this section of the documentation contains only the latest release notes (starting from 2024). For older changes, check the __Breaking Changes__ and __Backward Compatibility__ help articles of the individual Telerik controls.

## 2024 Q2

#### Common Changes

* Removed the __.NET Core 3.1__ distribution of the Telerik dlls.

* Removed the __.NET Framework__ distribution of the Telerik dlls. It was replaced with __.NET Framework 4.6.2__ dlls.

* Removed the `Telerik.Windows.Controls.Automation.Peers.RadRangeBaseAutomationPeer` class. Use the `Telerik.Windows.Automation.Peers.RadRangeBaseAutomationPeer` class instead.

#### Docking

* Removed the `ElementSaving` and `ElementCleaning` events of `RadDocking`. Use the `ElementLayoutSaving` and `ElementLayoutCleaning` events instead. 

* Removed the `Telerik.Windows.Controls.PaneHeaderAutomationPeer` class. Use the `Telerik.Windows.Automation.Peers.PaneHeaderAutomationPeer` class insteand.

* Removed the `PreviewResizeStart` event of `RadGridResizer` as was not used.

* Removed one of the `PreviewShowCompassEventArgs` constructors.

* Removed the `DraggedSplitContainer` property of `PreviewShowCompassEventArgs`. Use the `DraggedElement` property instead.

#### DateTimePicker

* Changed the name of the `RadDateTimePicker`'s `BlackoutDatesDatesProperty` dependency property to `BlackoutDatesProperty` because of a typo.

* Changed the name of the `RadDateTimePicker`'s `IsDownOpenProperty` dependency property to `IsDropDownOpenProperty` because of a typo.

#### DragDropManager

* Removed the `DragDropManager.TouchDragTrigger` attached property and the `TouchDragTrigger` enumeration. Use the `TouchManager.DragStartTrigger` attached property and the `TouchDragStartTrigger` enumeration instead.

#### Expander

* Removed the `Telerik.Windows.Controls.RadExpanderAutomationPeer` class. Use `Telerik.Windows.Automation.Peers.RadExpanderAutomationPeer` instead.

#### GridView

* Removed the `CurrentCellChanged` event of `RadGridView`. Use the `CurrentCellInfoChanged` event instead. 

* Removed the `ExportFormat.Xlsx` and `ExportFormat.Pdf` values from the `ExportFormat` enumeration. Use the [ExportToXlsx]({%slug gridview-export-xlsx%}) and [ExportToPdf]({%slug gridview-export-pdf%}) methods instead.

#### ListBox

* Removed the `OnIsReadOnlyChanged` protected method of `RadListBox`, because it doesn't do anything.

#### ProgressBar

* Removed the `Telerik.Windows.Controls.RadProgressBarAutomationPeer` class. Use `Telerik.Windows.Automation.Peers.RadProgressBarAutomationPeer` instead.

#### RichTextBox

* Removed the `HandleDocumentCaretPositionChanging` and `HandleDocumentCaretPositionChanged` methods from the `KeyboardSelectionHandler` class. Use the [ExpandTopRight and ExpandDownLeft methods]({%slug radrichtextbox-features-selection%}) instead.

#### TouchManager

* Removed the `TouchManager.IsTouchHitTestVisible` attached property. Use the `TouchManager.TouchMode` property instead.

## 2024 Q4

#### Common Changes

* Removed the __.NET 7__ distribution of the Telerik dlls.

* Removed __.NET Core Convert Wizard__ from the Telerik Visual Studio Extensions.

#### Barcode

* Removed the old barcode engine. Use the `RadBarcode` control instead. Read more in the [following article]({%slug barcode-upgrading%}).

#### Diagram

* Removed the `DiagramCommands.Print` command. Use the `DiagramExtensionCommands.Print` command instead.

* Removed the `Services` protected property of the `RadDiagramItem` class. Use the `ServiceLocator` property instead.

* Removed the single parameter `OnZIndexChanged` protected virtual method overload of the `RadDiagramItem` class. Use the other overload (with the two parameters) instead.

* Removed the `UnionRects` method of the `GraphExtensions` class. Use the `Utils.Union` static method instead.

* Removed the `ZoomFactor` property of the `DiagramConstants` class. Use the `ZoomScaleFactor` property instead. 

* Removed the `InflatedRouterMinimumMargin` property of the `DiagramConstants` class. Use the `RouterInflationValue` property instead. 

* Removed the `RotationHitTestRadius` property of the `DiagramConstants` class. Use the `RotationHitTestRadius` property of the `ManipulationAdorner` class instead. 

* Removed the `Create` method of the `SerializationInfo` class. Use one of the following methods instead: `CreateItemsInfo`, `CreateDiagramInfo` or `CreateMetadataInfo`.

* Removed the `IsLocalValueSet` method of the `CommonExtensions` class. Use the same method from the `DependencyObjectExtensions` class.

* Removed the `FromLtrd` method of the `Utils` class. Use the constructor of the native `Rect` class instead: `new Rect(new Point(left, top), new Point(right, bottom))`

* Removed the `IsPointInRectangle` methods of the `Utils` class. Use the `Contains` method of the native `Rect` class instead: `rect.Contains(point)`

* Removed the `Center` property of the `TreeLayoutProcessor` class. Use the non-static `LayoutCenter` property instead.

* Removed the `ILayer` interface because it was never used. 

* Removed the `FitTo` method of the `RadDiagram` class. Use the `BringIntoView` method instead.

#### Docking

* Removed the `OnElementSaving` and `OnElementCleaning` protected virtual methods of `RadDocking`. Use the `OnElementLayoutCleaning` and `OnElementLayoutSaving` methods instead.

* Removed the `GetRootlevelSplitContainer ` method of the `DockingLogicalTreeHelper` class because of a typo. Use the `GetRootLevelSplitContainer` method instead.

#### GanttView

* Removed the `GetCorrectedSize` and `GetCorrectedRect` methods of the `LogicalCanvasPanel` class. The methods were a legacy code used only in the Silverlight branch of the source code. These are not used in WPF.

#### PdfViewer

* Removed the `Commands` property of `RadPdfViewer`. Use `CommandDescriptors` property instead. 

* Hid the `FixedDocumentViewerCommands` class. Use the `DefaultCommandDescriptors` class instead.

* Removed the `MoveCaretCommand` class. Use the other caret-related command descriptors in the `DefaultCommandDescriptors` class (`MoveCaretToPreviousCharacterCommandDescriptor`, `MoveCaretToNextCharacterCommandDescriptor`, etc.) instead.

* Removed the `CaretMovementType` enumeration, because it was no longer needed. Use the caret-related commands of the `DefaultCommandDescriptors` class (`MoveCaretToPreviousCharacterCommandDescriptor`, `MoveCaretToNextCharacterCommandDescriptor`, etc.) instead. 

* Removed the `OnExceptionEventArgs` class. Use the `DocumentUnhandledExceptionEventArgs` class instead.

#### RibbonView

* Removed the `DividerDarkBrush` and `DividerLightBrush` properties of the `ButtonGroupPanel` class. Use the `BorderBrush` property of the `RadButtonGroupItem` instead.

* Removed the `Position` property of the `QuickAccessToolBar` class. Use the `QuickAccessToolBarPosition` property of `RadRibbonView` instead.  

* Removed the `ViewportHeight` property of the `RadGallery` class. Use the `Height` property instead.

* Removed the `IsFixedSize` property of the `RadRibbonContextualGroup` class. 

* Removed the following properties from the `RadRibbonView` class, because are not used by the control:
	* `RightTemplate`
	* `Align`
	* `AllowDragOverTab`
	* `AllowDragReorder`
	* `AllTabsEqualHeight` 
	* `DropDownButtonStyle` 
	* `DropDownDisplayMemberPath` 
	* `DropDownDisplayMode`
	* `DropDownStyle`
	* `IsDropDownOpen` 
	* `ItemDropDownContentTemplate` 
	* `ItemDropDownContentTemplateSelector` 
	* `LeftTemplate` 
	* `OverflowMode` 
	* `ScrollMode`
	* `TabOrientation`
	* `TabStripPlacement` 
	* `TopTemplate` 
	* `BottomTemplate`

#### RichTextBox

* Removed the `RadRichTextPageView` class. 

* Removed the `DocumentPosition`'s constructor that used callback. Use any of the other constructors instead.

* Removed the `ForbiddentPropertiesForExportCollection` class. 

* Removed the `Distribute` value from the `RadTextAlignment` because it was supported only in Silverlight. 

* Removed the `ListType` enumeration. Use `ListStyle` instead. 

* Removed the `RadDocumentBindingSource` class.

* Removed the `DocumentPageItem` class. 

* Removed the `URL` and `Target` properties from the `ImageInline` class. Use the `HyperlinkRangeStart` and `HyperlinkRangeEnd` objects to add links instead.

* Removed the `RegisterFieldUpadtePriority` method from the `FieldsUpdateManager` class. Use the `RegisterFieldUpdateInfo` method instead.

* Removed `EMUsToDIP` method of the `Unit` class. Use the `EmuToDip` method instead.

* Removed the `Selector` property of the `StylePropertyDefinition` class. Use the `GetStyleProperty` method of the `DocumentElementPropertiesBase` class instead.

* Removed the `PreserveAnnotationContent` value of the `AnnotationMarkerDeleteBehavior` enumeration. Use the `AnnotationRangeStart.IsRangeDeletable` and `AnnotationRangeStart.IsRangeEditable` properties instead.

* Removed the `DefaultStyleSettings` property of the `DocumentElement` class. Use the `Style` property of the `RadDocument` class instead.

* Removed the `Hyperlink` class. Use the `HyperlinkRangeStart` and `HyperlinkRangeEnd` classes instead.

* Removed the `InsertHyperlink` method overloads that take style as a parameter from the `IDocumentEditor` interface. Use the other overloads of the method instead.

* Removed the `DeleteAtDocumentPosition` method of `RadDocument`. Use the `Delete` method of `RadDocumentEditor` instead.

* Removed the `InsertFragment` method of `RadDocument`. Use the `InsertFramgment` method of `RadDocumentEditor` instead.

* Removed the `InsertReadOnlyRange` method of `RadDocument`. Use the `InsertReadOnlyRange` method of `RadDocumentEditor` instead.

* Removed the `DeleteReadOnlyRange` method of `RadDocument`. Use the `DeleteReadOnlyRange` method of `RadDocumentEditor` instead.

* Removed the `DeleteComment` method of `RadDocument`. Use the `DeleteComment` method of `RadDocumentEditor` instead.

* Removed the `InsertComment` method of `RadDocument`. Use the `InsertComment` method of `RadDocumentEditor` instead.

* Removed the `Delete` method of `RadDocument`. Use the `Delete` method of `RadDocumentEditor` instead.

* Removed the `DeleteRange` method of `RadDocument`. Use the `Delete` method of `RadDocumentEditor` instead.

* Removed the `UpdateSelectedSpansStyle` method of `RadDocument`.

* Removed the `UpdateSelectedParagraphsStyle` method of `RadDocument`.

* Removed the `UpdateSectionsStyle` method of `RadDocument`.

* Removed the `UpdateSelectedSectionsStyle` method of `RadDocument`.

* Removed the `InsertPageBreak` method of `RadDocument`. Use the `InsertPageBreak` method of `RadDocumentEditor` instead.

* Removed the `InsertLineBreak` method of `RadDocument`. Use the `InsertLineBreak` method of `RadDocumentEditor` instead.

* Removed the `InsertInline` method of `RadDocument`. Use the `InsertInline` method of `RadDocumentEditor` instead.

* Removed the `Insert` method of `RadDocument`. Use the `InsertInline` method of `RadDocumentEditor` instead.

* Removed the `InsertField` method of `RadDocument`. Use the `InsertField` method of `RadDocumentEditor` instead.

* Removed the `InsertFootnote` method of `RadDocument`. Use the `InsertFootnote` method of `RadDocumentEditor` instead.

* Removed the `InsertEndnote` method of `RadDocument`. Use the `InsertEndnote` method of `RadDocumentEditor` instead.

* Removed the `InsertPermissionRange` method of `RadDocument`. Use the `InsertPermissionRange` method of `RadDocumentEditor` instead.

* Removed the `InsertBookmark` method of `RadDocument`. Use the `InsertBookmark` method of `RadDocumentEditor` instead.

* Removed the `InsertCustomAnnotationRange` method of `RadDocument`. Use the `InsertAnnotationRange` method of `RadDocumentEditor` instead.

* Removed the `InsertSectionBreak` method of `RadDocument`. Use the `InsertSectionBreak` method of `RadDocumentEditor` instead.

* Removed the `InsertHyperlink` method of `RadDocument`. Use the `InsertHyperlink` method of `RadDocumentEditor` instead.

* Removed the `DeletePermissionRange` method of `RadDocument`. Use the `DeletePermissionRange` method of `RadDocumentEditor` instead.

* Removed the `DeleteCustomAnnotationRange` method of `RadDocument`. Use the `DeleteAnnotationRange` method of `RadDocumentEditor` instead.

* Removed the `DeleteBookmark` method of `RadDocument`. Use the `DeleteBookmark` method of `RadDocumentEditor` instead.

* Removed the `UpdatePermissionRanges` method of `RadDocument`. Use the `UpdatePermissionRanges` method of `RadDocumentEditor` instead.

* Removed the `UpdateField` method of `RadDocument`. Use the `UpdateField` method of `RadDocumentEditor` instead.

* Removed the `UpdateAllFields` method of `RadDocument`. Use the `UpdateAllFields` method of `RadDocumentEditor` instead.

* Removed the `ToggleFieldCodes` method of `RadDocument`. Use the `ToggleFieldCodes` method of `RadDocumentEditor` instead.

* Removed the `ChangeFieldDisplayMode` method of `RadDocument`. Use the `ChangeFieldDisplayMode` method of `RadDocumentEditor` instead.

* Removed the `ChangeAllFieldsDisplayMode` method of `RadDocument`. Use the `ChangeAllFieldsDisplayMode` method of `RadDocumentEditor` instead.

* Removed the `ChangeBibliographicStyle` method of `RadDocument`. Use the `ChangeBibliographicStyle` method of `RadDocumentEditor` instead.

* Removed the `PageViewMargin` property of `RadDocument`. Use the `PageMargin` property of the corresponding `Section` object instead.

* Removed the `DefaultPageLayoutSettings` property of `RadDocument`. Use the `SectionDefaultPageSize` property instead.

* Removed the parameterized constructor of the `TableLook` class. Use the default constructor instead.

* Removed the `RemoveCustomDictionary` method overload of the `DocumentSpellChecker` class that accepts `ICustomWordDictionary` as a parameter. Use the method overload with the `CultureInfo` parameter instead.

* Removed the parameterized overloads of the `BeginUpdate` and `EndUpdate` methods of the `DocumentSelection` class. Use the parameterless overloads of the methods instead.

* Removed the `Telerik.Windows.Documents.Proofing.Converters.BooleanToVisibilityConverter` class. Use `Telerik.Windows.Controls.BooleanToVisibilityConverter` instead.

* Removed the `Telerik.Windows.Controls.RichTextBoxUI.RibbonControls.TableStylesGallery.Converters.ColorToBrushConverter` class. Use `Telerik.Windows.Controls.ColorToBrushConverter` instead.

* Removed the `DoubleToVisibilityConverter` class. 

#### Sparklines

* Removed `IndicatorsVisiblity` property of the `RadLinearSparklineBase` class. Use the `IndicatorsVisibilityProperty` instead. 

* Removed the `Telerik.Windows.Controls.Sparklines.RectToRectangleGeometryConveter` class. Use the `Telerik.Windows.Controls.Sparklines.RectToRectangleGeometryConverter` class instead.

#### Spreadsheet

* Removed the `DocumentContentChanged` event of the `CellEditor` class. Use the `TextChanged` event instead. 

* Removed the `OnDocumentContentChanged` protected method if `CellEditor`. Use the `OnTextChanged` method instead.

#### TimeBar

* Removed the `IntervalContainerBase` class. Use the `TimeBarIntervalContainerBase` class instead.

* Removed the `IntervalControlBase` class. Use the `TimeBarIntervalControlBase` class instead. 

#### Timeline

* Removed the `TimelinePeriodContainerBase` class. Use the `TimeIntervalContainerBase` class instead.

* Removed the `TimelinePeriodControlBase` class. Use the `TimeIntervalControlBase` class instead. 

#### TreeMap

* Removed the `AbsoluteValueBrushColorizer` class. Use the `ValueBrushColorizer` class instead. 

* Removed the `AbsoluteValueGradientColorizer` class. Use use `ValueGradientColorizer` class instead. 

* Removed the `RelativeValueBrushColorizer` class. Use the `ValueBrushColorizer` class instead. 

* Removed the `RelativeValueGradientColorizer` class. Use the `ValueGradientColorizer` class instead. 

#### WebCam

* Replaced the __SharpDX__ dependencies with __SkiaSharp__. This was needed because the SharpDX library is no longer maintained since May 2019.
