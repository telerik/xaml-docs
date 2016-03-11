---
title: Modify Content Before Exporting
page_title: ExportFormat.Xlsx
description: ExportFormat.Xlsx
slug: gridview-export-xlsx
tags: exportformat.xlsx
published: True
position: 8
---

# Modify RadGridView`s Content Before Exporting

As of __Q1 2016__, we have introduced two new extension methods related to the exporting of RadGridView - *ExportToWorkBook()* and *ExportToRadFixedDocument()*. You can use them if you need to modify the content of the exported RadGridView and avoid styling the document manually.

__Assembly References__

ExportToWorkbook and ExportToRadFixedDocument methods use additional libraries so you need to add references to the following assemblies:

* Telerik.Windows.Documents.Core.dll
* Telerik.Windows.Documents.SpreadSheet.dll 
* Telerik.Windows.Documents.SpreadSheet.FormatProviders.OpenXml.dll
* Telerik.Windows.Zip.dll
* Telerik.Windows.Controls.GridView.Export.dll

## ExportToWorkBook 

The method exports the associated RadGridView to a Workbook object.

#### __[C#] Example 1: Export RadGridView to a Workbook on Button click:__
 
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


## ExportToRadFixedDocument

The method exports the associated RadGridView to a RadFixedDocument object.

#### __[C#] Example 2: Export RadGridView to a RadFixedDocument on Button click:__

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


Both methods can be overloaded and take __GridViewDocumentExportOptions__ as parameter. You can use them to set the following export options:

* Culture
* Items
* ShowColumnFooters
* ShowGroupFooters
* ShowColumnHeaders
* ExportDefaultStyles  

## See Also

 * [RadGridView Overview]({%slug gridview-overview2%})

 * [Export]({%slug gridview-export%})

 * [Export Async]({%slug gridview-export-async%})

 * [Export Events]({%slug gridview-export-events%})
