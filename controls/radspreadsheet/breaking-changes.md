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

This article lists and describes the breaking changes introduced in the RadSpreadsheet component. For a full list of changes, see the [Release History](https://www.telerik.com/support/whats-new/wpf/release-history) pages of the Telerik UI for WPF product.

## 2018 R2

The default value of `Telerik.Windows.Documents.Spreadsheet.Model.Printing.SheetPageSetupBase::PaperType` has been changed from `A4` to `Letter`.

If you need to keep the document with A4 PaperType, you can apply this setting before exporting it:

```C#  
	foreach (Worksheet worksheet in workbook.Worksheets)
	{
		worksheet.WorksheetPageSetup.PaperType = PaperTypes.A4;
	}
```