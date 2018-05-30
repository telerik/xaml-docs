---
title: Modify Content Before Exporting
page_title: Modify Content Before Exporting
description: This article describes RadGridView's ExportToWorkbook and ExportToRadFixedDocument extension methods which can be used to modify the exported documents.
slug: gridview-export-howto-modify-exported-content
tags: modify,content,before,exporting
published: True
position: 7
---

# Modify RadGridView's Content Before Exporting

In __R1 2016__, we introduced two new extension methods related to the exporting of RadGridView - *ExportToWorkbook()* and *ExportToRadFixedDocument()*. You can use them if you need to modify the content of the exported RadGridView and avoid styling the document manually.

## Assembly References

__ExportToWorkbook__ and __ExportToRadFixedDocument__ methods use additional libraries so you need to add references to the following assemblies:

* Telerik.Windows.Documents.Core.dll
* Telerik.Windows.Documents.Spreadsheet.dll 
* Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.dll
* Telerik.Windows.Zip.dll
* Telerik.Windows.Controls.GridView.Export.dll

## ExportToWorkbook 

This method exports the associated RadGridView to a [Workbook](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/working-with-workbooks/working-wtih-workbooks-what-is-workbook) object. Examples 1 and 2 show how you can modify that object before exporting.

#### __[C#] Example 1: Export RadGridView to a Workbook and modify cell style:__
{{region gridview-export-howto-modify-exported-content-0}}
	  private void Button_Click(object sender, RoutedEventArgs e)
        {
			//Instantiate the Workbook object
            Workbook workbook = this.clubsGrid.ExportToWorkbook();

			//Modify the created Workbook
            CellStyle wbStyle = workbook.Styles["Normal"];
            wbStyle.ForeColor = new ThemableColor(Colors.Green);
            wbStyle.FontFamily = new ThemableFontFamily(ThemeFontType.Major);
            wbStyle.FontSize = UnitHelper.PointToDip(16);
            wbStyle.VerticalAlignment = RadVerticalAlignment.Top;

			//Export the Workbook to an Excel file
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "*.xlsx";
            dialog.Filter = String.Format("{1} files (*.{0})|*.{0}|All files (*.*)|*.*", "xlsx", "Excel");
            dialog.FilterIndex = 1;

            if (dialog.ShowDialog() == true)
            {
                var provider = new XlsxFormatProvider();
                using (var output = dialog.OpenFile())
                {
                    provider.Export(workbook, output);
                }
            }
        }
{{endregion}}

#### __[C#] Example 2: Double the width of the exported columns:__
{{region gridview-export-howto-modify-exported-content-1}}
    for (int i = 0; i < workbook.ActiveWorksheet.UsedCellRange.ColumnCount; i++)
    {
        workbook.ActiveWorksheet.Columns[i].SetWidth(new ColumnWidth(this.clubsGrid.Columns[i].ActualWidth * 2, true));
    }
{{endregion}}

## ExportToRadFixedDocument

This method exports the associated RadGridView to a [RadFixedDocument](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/model/radfixeddocument) object.

#### __[C#] Example 3: Export RadGridView to a RadFixedDocument and rotate the page 90 degrees__
{{region gridview-export-howto-modify-exported-content-2}}
	private void Button2_Click(object sender, RoutedEventArgs e)
        {	
			//Instantiate the RadFixedDocument object
            RadFixedDocument fixedDoc = this.clubsGrid.ExportToRadFixedDocument();
			
			//Modify the RadFixedDocument object
            foreach (var page in fixedDoc.Pages)
            {
                var actualPage = page as RadFixedPage;
                actualPage.Rotation =  Telerik.Windows.Documents.Fixed.Model.Data.Rotation.Rotate90;
            }

			//Export the RadFixedDocument to a PDF file
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "*.pdf";
          
            if (dialog.ShowDialog() == true)
            {

                var provider = new PdfFormatProvider();
                using (var output = dialog.OpenFile())
                {
                    provider.Export(fixedDoc, output);
                }
            }
        }
{{endregion}}

Both methods can be overloaded and take __GridViewDocumentExportOptions__ as parameter. You can use it to set the following export options:

* Culture
* Items
* ShowColumnFooters
* ShowGroupFooters
* ShowColumnHeaders
* ExportDefaultStyles  

>important __ExportToRadFixedDocument__ method utilizes [PdfProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/overview) library and __ExportToWorkbook__ method utilizes [SpreadProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/overview) library. You can check their documentation for more information on how to modify them.

## See Also
 * [RadGridView Overview]({%slug gridview-overview2%})
 * [Export]({%slug gridview-export%})
 * [Export Async]({%slug gridview-export-async%})
 * [Export Events]({%slug gridview-export-events%})
