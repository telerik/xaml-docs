---
title: ExportFormat.Html
page_title: ExportFormat.Html
description: ExportFormat.Html
slug: gridview-export-html
tags: exportformat.html
published: True
position: 4
---

# ExportFormat.Html

You can use the ExportFormat.Html to export RadGridView in HTML format.


>important As of __Q3 2013 GridViewElementExportingEventArgs__ exposes a new argument __VisualParameters__. The value of the property depends on the export format. Please note that it is only valid when exporting with __ExportFormat.ExcelML__ and __ExportFormat.Html__.
        
## Set Exported Element's VisualParameters 

When using the ElementExporting event, the type of the VisualParameters property for this format is __GridViewHtmlVisualExportParameters__. It has the following properties:
        
* *Background*
* *FontFamily*
* *FontSize*
* *FontWeight* 
* *Foreground*
* *Height*
* *TextAlignment*
* *VerticalAlignment*
* *Width*

For example:
        

#### __[C#]Example 1: Set the properties of the VisualParameters:__

{{region gridview-export-async_6}}

	  private void clubsGrid_ElementExporting(object sender, GridViewElementExportingEventArgs e)
        {
            if (e.VisualParameters is GridViewHtmlVisualExportParameters)
            {
                var param = e.VisualParameters as GridViewHtmlVisualExportParameters;
                param.Background = Colors.AliceBlue;
                param.FontFamily = new FontFamily("Verdana");
                param.FontSize = 15;
                param.FontWeight = FontWeights.Bold;
                param.Foreground = Colors.Black;
                param.Height = 30;
                param.TextAlignment = TextAlignment.Center;
                param.VerticalAlignment = VerticalAlignment.Bottom;
                param.Width = 200;
            }
        }
{{endregion}}

You can read more about the export events [here]({%slug gridview-export-events%}).

# See Also

 * [RadGridView Overview]({%slug gridview-overview2%})

 * [Export]({%slug gridview-export%})

 * [Export Async]({%slug gridview-export-async%})

 * [Export Events]({%slug gridview-export-events%})
