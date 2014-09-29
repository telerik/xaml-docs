---
title: ExportFormat.Html
page_title: ExportFormat.Html
description: ExportFormat.Html
slug: gridview-export-html
tags: exportformat.html
published: True
position: 2
---

# ExportFormat.Html



## 
          ExportForms.Html
        

As of __Q3 2013 GridViewElementExportingEventArgs__ exposes a new argument __VisualParameters__. The value of the property depends on the export format. Please note that it is only valid when exporting with __ExportFormat.ExcelML__ and __ExportFormat.Html__.
        

>You can read more about the export events [here]({%slug gridview-export-events%}).
          

The type of the property for this format is __GridViewHtmlVisualExportParameters__. It has the following properties:
        

* __Background__

* __FontFamily__

* __FontSize__

* __FontWeight - you can find the supported formats described__

* __Foreground__

* __Height__

* __TextAlignment__

* __VerticalAlignment__

* __Width__

For example:
        

#### __C#__

{{region gridview-export-async_6}}
	private void clubsGrid_ElementExporting_1(object sender, GridViewElementExportingEventArgs e)
	{
	    if (e.VisualParameters is GridViewHtmlVisualExportParameters)
	    {
	        var param = e.VisualParameters as GridViewHtmlVisualExportParameters;
		    param.Background = Colors.Red;
		    param.FontFamily = new FontFamily("Verdana");
		    param.FontSize = 30;
		    param.FontWeight = FontWeights.Bold;
		    param.Foreground = Colors.Green;
		    param.Height = 50;
		    param.TextAlignment = TextAlignment.Center;
		    param.VerticalAlignment = VerticalAlignment.Bottom;
		    param.Width = 500;
	    }
	}
	
	{{endregion}}



# See Also

 * [
        RadGridView Overview
      ]({%slug gridview-overview2%})

 * [
        Export
      ]({%slug gridview-export%})

 * [
        Export Async
      ]({%slug gridview-export-async%})

 * [Export Events]({%slug gridview-export-events%})
