---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radspreadsheet-getting-started
tags: getting,started
published: True
position: 0
---

# Getting Started



This article explains how to add a __RadSpreadsheet__ control to a page in your application.
      

It contains the following sections:

* [Assembly References](#assembly-references)

* [Namespaces](#namespaces)

* [Spreadsheet and RibbonView](#spreadsheet-and-ribbonview)

* [Open/Save Documents](#opensave-documents)

## Assembly References

The assemblies that contain the implementation of __RadSpreadsheet__ and must be referenced in order to use the control are:
        

* **Telerik.Windows.Controls.dll**

* **Telerik.Windows.Controls.GridView.dll**

* **Telerik.Windows.Controls.Input.dll**

* **Telerik.Windows.Controls.Navigation.dll**

* **Telerik.Windows.Controls.Spreadsheet.dll**

* **Telerik.Windows.Data.dll**

* **Telerik.Windows.Documents.Core.dll**

* **Telerik.Windows.Documents.Spreadsheet.dll**


For export and import to **XLSX**:

* **Telerik.Windows.Zip.dll**

* **Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.dll**


To export a document to **PDF**, you will need to add a reference to the corresponding assembly:

* **Telerik.Windows.Documents.Spreadsheet.FormatProviders.Pdf.dll**


Note that in order to import/export in XLSX or export to PDF, the format provider must be registered manually. More information on Import/Export can be found [here]({%slug radspreadsheet-import-export%}).

If you want to use the sample UI provided in our demos you should add this reference as well:
        

* **Telerik.Windows.Controls.RibbonView.dll**
{% if site.site_name == 'WPF' %}* **Telerik.Windows.Controls.SpreadsheetUI.dll**{% endif%}

## Namespaces

For a bare-bone Spreadsheet control, you only need a declaration of the telerik schema:

#### __XAML__

{{region radspreadsheet-schemas_0}}

	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" 
{{endregion}}



For the UI that enables the full-featured use of the control, you should also declare:

#### __XAML__

{{region radspreadsheet-schemas_1}}

	xmlns:spreadsheetControls="clr-namespace:Telerik.Windows.Controls.Spreadsheet.Controls;assembly=Telerik.Windows.Controls.Spreadsheet"
	xmlns:spreadsheet="clr-namespace:Telerik.Windows.Controls.Spreadsheet;assembly=Telerik.Windows.Controls.Spreadsheet"
	{{endregion}}


Then, all that is left is to add the __Spreadsheet__ component to the page:
      

#### __XAML__

{{region radspreadsheet-getting-started_2}}

	<telerik:RadSpreadsheet x:Name="radSpreadsheet" />
{{endregion}}



## Spreadsheet and RibbonView


__RadSpreadsheet__ is easy to integrate with all kinds of UI thanks to the commanding mechanism that it employs. If you would like to use the control with a [RadRibbonView]({%slug radribbonview-overview%}), which shows the full potential of the control, you can refer to the {% if site.site_name == 'Silverlight' %}[SDK repository](https://github.com/telerik/xaml-sdk/tree/master/Spreadsheet/FirstLook).{% endif %}{% if site.site_name == 'WPF' %} [Spreadsheet UI]({%slug radspreadsheet-getting-started-spreadsheet-ui%}) topic that describes how you can take advantage of **RadSpreadsheetRibbon**.{% endif %}        

## Open/Save Documents

To open a document, you need to import it and the export functionalities will help you to save one. To work with documents of the formats supported by **RadSpreadsheet**, you should use the format provider classes. For more information on the matter, please check the [Import/Export]({%slug radspreadsheet-import-export%}) topic.

## See Also

* [Import/Export]({%slug radspreadsheet-import-export%})
* [Spreadsheet UI]({%slug radspreadsheet-getting-started-spreadsheet-ui%})
* [SpreadProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/overview)