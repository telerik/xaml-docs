---
title: Printing
page_title: Printing
description: Learn how you can print the data in Telerik's {{ site.framework_name }} DataGrid with RadSpreadProcessing, the model of which is completely independent from the UI.
slug: gridview-export-printing
tags: grid,printing
published: True
position: 6
---

# {{ site.framework_name }} RadGridView Printing

* As of __Q1 2015__ RadGridView exposes a new method – [ExportToPdf]({%slug gridview-export-pdf%}) which allows exporting to Pdf format without the need to integrate RadGridView with RadSpreadProcessing.

* Another way would be to follow the approach illustrated in the "Print and Print Preview" {% if site.site_name == 'WPF' %}[ demo.](https://demos.telerik.com/wpf/){% endif %}{% if site.site_name == 'Silverlight' %}[online demo.](https://demos.telerik.com/silverlight/#GridView/PrintAndPrintPreview){% endif %}

* Alternatively, you can manually create the document to be exported.
You can go through the articles about using the [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%}) and about the document viewer control - [RadRichTextBox]({%slug radrichtextbox-overview%}). You could as well review [this article]({%slug radrichtextbox-features-document-elements-tables%}) on how you could create the document elements.

* You can also print data with __RadSpreadProcessing__, the model of which is completely independent from the UI. You can check the {% if site.site_name == 'WPF' %}[Export with RadSpreadProcessing](https://demos.telerik.com/wpf/){% else %}[Export with RadSpreadProcessing](https://demos.telerik.com/silverlight/#SpreadProcessing/RadGridViewIntegration){% endif %} example on how to do so.

>In order to print or export with more advanced options you can check the __Telerik Reporting__ product. You can find more information about it [here.](http://www.telerik.com/products/reporting.aspx)
        
## See Also

* [SpreadsheetStreamingExport]({%slug gridview-export-spreadsheetstreamingexport%})
* [ExportToXlsx]({%slug gridview-export-xlsx%})
* [ExportToPdf]({%slug gridview-export-pdf%})
