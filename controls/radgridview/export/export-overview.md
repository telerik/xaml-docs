---
title: Export Events
page_title:  Export Events
description:  Export Events
slug: gridview-export-events
tags: grid,export,events
published: True
position: 0
---

# Overview

__RadGridView__ provides built-in methods for exporting its data to various formats. Underneath, the control utilizes the [RadSpreadProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/overview) library for handling these operations. 

## Export to Xlsx

The control provides the __ExportToXlsx__ method for exporting to __Xlsx__  format out of the box. The functionality is illustrated in details [here]({%slug gridview-export-xlsx%}).

## Export to Pdf

For the purpose of exporting to __Pdf__, __RadGridView__ exposes the __ExportToPdf__ method. More information can be found [here]({%slug gridview-export-pdf%}).

## Customizing the Export

There are two approaches that can be used for customizing the export operations. The first one would be to benefit from the __ElementExportingToDocument__ event. Its event arguments provide a set of properties through which the exported data can be modified. A detailed information on this topic can be found in the [Export Events]({%slug gridview-export-async%}) article. However, the customization capabilities of this approach are limited. 

The second approach consists of utilizing the [RadSpreadProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/overview) library and exporting the data manually. Thus, heavier customizations such as adding or removing visual elements from the exported data can be applied. Such implementation is demonstrated in the {% if site.site_name == 'WPF' %} [RadGridView Integration](https://demos.telerik.com/wpf/) {% endif %} {% if site.site_name == 'Silverlight' %} [RadGridView Integration](https://demos.telerik.com/silverlight/#SpreadProcessing/RadGridViewIntegration) {% endif %} example.

## Obsolete methods

The following methods are not utilizing the [RadSpreadProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/overview) library for exporting __RadGridView__ and are obsolete. They are used when exporting to __Html__, __Csv__ and __ExcelML__ is needed.

* Export
* ExportAsync

## See Also

 * [Grid Export]({#slug gridview-export})
 * [Grid Async Export]({%slug gridview-export-async%})
 * [ExportFormat.ExcelML]({%slug gridview-export-excelml%})
 * [ExportFormat.Html]({%slug gridview-export-html%}) 
 * [ExportFormat.Xlsx]({%slug gridview-export-xlsx%}) 
 * [ExportFormat.Pdf]({%slug gridview-export-pdf%})
