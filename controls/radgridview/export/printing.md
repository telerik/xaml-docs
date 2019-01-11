---
title: Printing
page_title: Printing
description: Printing
slug: gridview-export-printing
tags: grid,printing
published: True
position: 6
---

# Printing

* As of __Q1 2015__ RadGridView exposes a new method – [ExportToPdf]({%slug gridview-export-pdf%}) which allows exporting to Pdf format without the need to integrate RadGridView with RadSpreadProcessing.

* Another way would be to follow the approach illustrated in the "Print and Print Preview" {% if site.site_name == 'WPF' %}[ demo.](https://demos.telerik.com/wpf/){% endif %}{% if site.site_name == 'Silverlight' %}[online demo.](https://demos.telerik.com/silverlight/#GridView/PrintAndPrintPreview){% endif %}

* Another way would be to manually create the document to be exported.
You can go through the articles about using the [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%}) and about the document viewer control - [RadRichTextBox]({%slug radrichtextbox-overview%}). You could as well review [this article]({%slug radrichtextbox-features-document-elements-tables%}) on how you could create the document elements.

* You can also print data with __RadSpreadProcessing__, which model is completely independent from UI. You can check our new example {% if site.site_name == 'WPF' %}[Export with RadSpreadProcessing](https://demos.telerik.com/wpf/){% endif %}{% if site.site_name == 'Silverlight' %}[Export with RadSpreadProcessing](https://demos.telerik.com/silverlight/#SpreadProcessing/RadGridViewIntegration){% endif %} on how to do so.

>In order to print or export with more advanced options you can check the __Telerik Reporting__ product. You can find more information about it [here.](http://www.telerik.com/products/reporting.aspx)
        
## See Also

 * [Grid Async Export]({%slug gridview-export-async%})

 * [ExportFormat.ExcelML]({%slug gridview-export-excelml%})

 * [ExportFormat.Html]({%slug gridview-export-html%})
 
 * [ExportFormat.Xlsx]({%slug gridview-export-xlsx%})
 
 * [ExportFormat.Pdf]({%slug gridview-export-pdf%})

 * [Export Events]({%slug gridview-export-events%})
 
 * [Online Demo - Exporting to various formats](https://demos.telerik.com/silverlight/#GridView/Exporting)
 
 * [Online Demo - Exporting Row Details](https://demos.telerik.com/silverlight/#GridView/ExportingRowDetails)
