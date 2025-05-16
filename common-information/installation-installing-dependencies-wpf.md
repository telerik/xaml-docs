---
title: Controls Dependencies
page_title: Controls Dependencies
description: The article will list all controls from UI for WPF suite and their required assemblies.
slug: installation-installing-controls-dependencies-wpf
tags: controls,dependencies
published: True
position: 13
site_name: WPF
---

# Controls Dependencies

The following topic describes all controls from UI for WPF and the assemblies they require when deploying your application.

The following two assemblies should be always referenced in the project:

* `Telerik.Windows.Controls.dll`
* `Telerik.Licensing.Runtime.dll`&mdash;We recommend installing the dll via the `Telerik.Licensing` NuGet package.

In general we recommend [using the NuGet packages]({%slug nuget-installation%}) to install Telerik UI for WPF in the corresponding project. There are several different types of packages which you can find listed in the [following article]({%slug nuget-available-packages%}) article. 
          
Controls	|	Assembly
---	|	---
TouchManager | Telerik.Windows.Controls
DragDropManager	|	Telerik.Windows.Controls
RadAIPrompt | Telerik.Windows.Controls, Telerik.Windows.Controls.ConversationalUI, Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation, Telerik.Windows.Data
RadAutoCompleteBox	|	Telerik.Windows.Controls.Input
RadAutoSuggestBox	|	Telerik.Windows.Controls.Input
RadBadge | Telerik.Windows.Controls
RadBarcode	|	Telerik.Windows.Controls.DataVisualization, Telerik.Windows.Data
RadBook	|	Telerik.Windows.Controls.Navigation
RadBreadcrumb	|	Telerik.Windows.Controls.Navigation, Telerik.Windows.Data
RadBulletGraph	|	Telerik.Windows.Controls.DataVisualization, Telerik.Windows.Data
RadBusyIndicator	|	Telerik.Windows.Controls
RadButtons	|	Telerik.Windows.Controls
RadCalculator	|	Telerik.Windows.Controls.Input
RadCalendar	|	Telerik.Windows.Controls.Input
RadCallout  |  Telerik.Windows.Controls
RadCardView | Telerik.Windows.Controls.Data, Telerik.Windows.Controls.Input, Telerik.Windows.Data
RadCarousel	|	Telerik.Windows.Controls.Navigation, Telerik.Windows.Data
RadChart	|	Telerik.Windows.Controls.Charting
RadChartView	|	Telerik.Windows.Controls.Chart, Telerik.Windows.Data
	|	
	|	Note: Additionally the Direct2D Rendering feature requires the SharpDX, SharpDX.Direct2D1, SharpDX.Direct2D10, SharpDX.Direct2D9, SharpDX.DXGI and Telerik.Windows.Controls.Chart.Direct2D assemblies. The SharpDX binaries are located in a SharpDX folder with the other dlls for the specific .NET version in the UI for WPF installation directory.
RadChartView3D	|	Telerik.Windows.Controls.Chart, Telerik.Windows.Data
RadChat(ConversationalUI)	|	Telerik.Windows.Controls, Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation, Telerik.Windows.Controls.ConversationalUI
RadCircularProgressBar	|	Telerik.Windows.Controls
RadCloudUpload	|	Telerik.Windows.Cloud, Telerik.Windows.Cloud.Controls
RadCollectionNavigator	|	Telerik.Windows.Controls.Data, Telerik.Windows.Data
RadColorEditor	|	Telerik.Windows.Controls.Input
RadColorPicker	|	Telerik.Windows.Controls.Input
RadComboBox	|	Telerik.Windows.Controls.Input
RadContextMenu	|	Telerik.Windows.Controls.Navigation
RadDataBar	|	Telerik.Windows.Controls.DataVisualization, Telerik.Windows.Data
RadDataFilter	|	Telerik.Windows.Controls.Data, Telerik.Windows.Data
RadDataForm	|	Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Data, Telerik.Windows.Data
RadDataPager	|	Telerik.Windows.Controls.Data, Telerik.Windows.Data
RadDatePicker	|	Telerik.Windows.Controls.Input
RadDateTimePicker	|	Telerik.Windows.Controls.Input
RadDateRangePicker	|	Telerik.Windows.Controls.Input
RadDataServiceDataSource	|	Telerik.Windows.Data, Telerik.Windows.Controls.DataServices
RadDesktopAlert	|	Telerik.Windows.Controls.Navigation
RadDiagram	|	Telerik.Windows.Controls.Diagrams, Telerik.Windows.Diagrams.Core
RadDocking	|	Telerik.Windows.Controls.Docking, Telerik.Windows.Controls.Navigation, Telerik.Windows.Data
RadEntityFrameworkDataSource	|	Telerik.Windows.Data, Telerik.Windows.Controls.EntityFramework
RadEntityFrameworkCoreDataSource	|	Telerik.Windows.Data, Telerik.Windows.Controls.EntityFrameworkCore (.NET Core version)
RadExpander	|	Telerik.Windows.Controls.Navigation, Telerik.Windows.Data
RadExpressionEditor	|	Telerik.Windows.Controls.Expressions, Telerik.Windows.Data, Telerik.Windows.Documents, Telerik.Windows.Controls.Navigation
RadFileDialogs | Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation, Telerik.Windows.Controls.GridView, Telerik.Windows.Controls.FileDialogs, Telerik.Windows.Data
RadFilePathPicker | Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation, Telerik.Windows.Controls.GridView, Telerik.Windows.Controls.FileDialogs, Telerik.Windows.Data
RadGanttView	|	Telerik.Windows.Controls.GanttView, Telerik.Windows.Scheduling.Core
RadGauge	|	Telerik.Windows.Controls.DataVisualization, Telerik.Windows.Data
RadGridView	|	Telerik.Windows.Controls.GridView, Telerik.Windows.Data, Telerik.Windows.Controls.Input
RadHeatMap	|	Telerik.Windows.Controls.DataVisualization, Telerik.Windows.Data
RadHighlightTextBlock	|	Telerik.Windows.Controls
RadImageEditor	|	Telerik.Windows.Controls.ImageEditor, Telerik.Windows.Controls.Input
RadLayoutControl	|	Telerik.Windows.Controls, Telerik.Windows.Controls.Navigation
RadLegend	|	Telerik.Windows.Controls
RadListBox	|	Telerik.Windows.Controls
RadMap	|	Telerik.Windows.Controls.DataVisualization, Telerik.Windows.Data
RadMaskedInput	|	Telerik.Windows.Controls.Input
RadMenu	|	Telerik.Windows.Controls.Navigation
RadNavigationView |	Telerik.Windows.Controls.Navigation, Telerik.Windows.Data
RadNotifyIcon | Telerik.Windows.Controls.Navigation
RadNumericUpDown	|	Telerik.Windows.Controls.Input
RadOfficeNavigationBar	|	Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation
RadOutlookBar	|	Telerik.Windows.Controls.Navigation, Telerik.Windows.Data
RadPanelBar	|	Telerik.Windows.Controls.Navigation, Telerik.Windows.Data
RadPdfViewer	|	Telerik.Windows.Documents.Fixed, Telerik.Windows.Documents.Core, Telerik.Windows.Controls.FixedDocumentViewers
RadPersistenceFramework	|	Telerik.Windows.PersistenceFramework
RadPipsPager	|	Telerik.Windows.Controls
RadPivotFieldList	|	Telerik.Pivot.Core, Telerik.Windows.Controls.PivotFieldList, Telerik.Windows.Controls.Pivot, Telerik.Windows.Controls.Navigation, Telerik.Windows.Controls.Input
RadPivotGrid	|	Telerik.Pivot.Core, Telerik.Windows.Controls.Pivot
RadPivotMap	|	Telerik.Windows.Controls.DataVisualization, Telerik.Windows.Data
RadProgressBar	|	Telerik.Windows.Controls
RadPropertyGrid	|	Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Data, Telerik.Windows.Data
RadRadialMenu	|	Telerik.Windows.Controls.Navigation
RadRating	|	Telerik.Windows.Controls.Input
RadRibbonView	|	Telerik.Windows.Controls.RibbonView, Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation, Telerik.Windows.Data
RadRichTextBox	|	System.ComponentModel.Composition, Telerik.Windows.Data, Telerik.Windows.Documents, Telerik.Windows.Documents.Core, Telerik.Windows.Documents.Flow
RadRichTextBoxRibbonUI	|	Telerik.Windows.Controls.RichTextBoxUI, Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation, Telerik.Windows.Controls.RibbonView, Telerik.Windows.Controls.ImageEditor
RadScheduleView	|	Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation, Telerik.Windows.Controls.ScheduleView, Telerik.Windows.Data
RadSlider	|	Telerik.Windows.Controls
RadSlideView	|	Telerik.Windows.Controls
RadSparkLine	|	Telerik.Windows.Controls.Charting, Telerik.Windows.Controls.DataVisualization, Telerik.Windows.Data
RadSpellChecker	|	Telerik.Windows.Documents.Proofing, Telerik.Windows.Documents.Proofing.DataGrid, Telerik.Windows.Documents.Proofing.RadGridView, Telerik.Windows.Documents, Telerik.Windows.Documents.FormatProviders.MsRichTextBoxXaml
RadSplashScreen	|	Telerik.Windows.Controls.Navigation
RadSpreadsheet	|	Telerik.Windows.Controls, Telerik.Windows.Controls.GridView, Telerik.Windows.Controls.Input, Telerik.Windows.Controls.Navigation, Telerik.Windows.Controls.Spreadsheet, Telerik.Windows.Data, Telerik.Windows.Documents.Core, Telerik.Windows.Documents.Spreadsheet, Telerik.Windows.Maths
RadStepProgressBar	|	Telerik.Windows.Controls
RadSvgImage	|	Telerik.Windows.Controls
RadSyntaxEditor	|	Telerik.Windows.Controls.Input, Telerik.Windows.SyntaxEditor.Core
RadTabbedWindow	|	Telerik.Windows.Controls.Navigation, Telerik.Windows.Data
RadTabControl	|	Telerik.Windows.Controls.Navigation, Telerik.Windows.Data
RadTaskBoard |	Telerik.Windows.Controls
RadTileList	|	Telerik.Windows.Controls
RadTileView	|	Telerik.Windows.Controls.Navigation, Telerik.Windows.Data
RadTimeBar	|	Telerik.Windows.Controls.DataVisualization, Telerik.Windows.Data
RadTimeline	|	Telerik.Windows.Controls.DataVisualization, Telerik.Windows.Data
RadTimePicker	|	Telerik.Windows.Controls.Input
RadTimeSpanPicker	|	Telerik.Windows.Controls.Input
RadToolBar	|	Telerik.Windows.Controls.Navigation
RadToolTip	|	Telerik.Windows.Controls
RadTransitionControl	|	Telerik.Windows.Controls
RadTreeListView	|	Telerik.Windows.Controls.GridView, Telerik.Windows.Data, Telerik.Windows.Controls.Input
RadTreeMap	|	Telerik.Windows.Controls.DataVisualization, Telerik.Windows.Data
RadTreeView	|	Telerik.Windows.Controls.Navigation, Telerik.Windows.Data
RadVirtualGrid | Telerik.Windows.Controls.VirtualGrid, Telerik.Windows.Controls, Telerik.Windows.Data
RadVirtualKeyboard | Telerik.Windows.Controls.Navigation
RadWatermarkTextBox	|	Telerik.Windows.Controls
RadWebCam	|	Telerik.Windows.Controls, Telerik.Windows.Controls.Media, Telerik.Windows.MediaFoundation, MediaFoundation, the SkiaSharp NuGet package
RadWindow	|	Telerik.Windows.Controls.Navigation
RadWizard	|	Telerik.Windows.Controls, Telerik.Windows.Data, Telerik.Windows.Controls.Navigation 
RadZipLibrary	|	Telerik.Windows.Zip
LayoutControls	|	Telerik.Windows.Controls

## See Also 
 * [Adding UI for WPF to the Visual Studio Toolbox]({%slug installation-adding-to-vs-2015-toolbox-wpf%}) 
 * [Namespace Declaration]({%slug installation-adding-application-namespace-declaration%})
