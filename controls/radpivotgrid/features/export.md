---
title: Export
page_title: Export
description: Check our &quot;Export&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-export
tags: export
published: True
position: 2
---

# Export

__RadPivotGrid__ allows you to export data to different formats using the **GenerateExport** method. In this article you will learn how to export __RadPivotGrid__ to the following formats: **XLSX** (Microsoft Excel), **DOCX** (Microsoft Word), **PDF** and **HTML**.

## GenerateExport Method

__RadPivotGrid__'s **GenerateExport** method returns an object of type **PivotExportModel** which describes each cell of the control and can be used to export the control's data to the aforementioned formats. Through the **PivotExportModel** you can access the following properties:

* **Cells**: The collection cells to be exported. This is an **IEnumeration<PivotExportCellInfo>** and each object holds information about various appearance settings such as **Background**, **TextAlignment** and **Indent**. The **PivotExportCellInfo** class also exposes the cell's **Column**, **Row** and **Value**.
* **ColumnCount**: The number of columns to be exported.
* **RowCount**: The number of rows to be exported.

>To export __RadPivotGrid__ with all colors and fonts applied, you have to set the [QuickStyle]({%slug radpivotgrid-styles-and-templates-quickstyles%}) property. It is set to default value when __RadPivotGrid__ is loaded, so if you have not set it, you must show the pivot at least once before exporting it.   

The GenerateExport method has two overloads:

* **public PivotExportModel GenerateExport()**
* **public PivotExportModel GenerateExport(bool ignoreCollapsedGroups)**

By default, RadPivotGrid will export all groups' items, no matter if some of them are collapsed. By passing **True** as the **ignoreCollapsedGroups** parameter of the second overload, collapsed groups will not be exported. 

## Export to Excel

>In order to use Export to xlsx (Excel) format, you will have to add reference to the following assemblies:
>	* __Telerik.Windows.Documents.Core__
>	* __Telerik.Windows.Documents.Spreadsheet__
>	* __Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml__

In order to export __RadPivotGrid__ to xlsx format (Excel file), you have to use __XlsxFormatProvider__ from *Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx* namespace. The __XlsxFormatProvider__ has *Export* method, which has two arguments - first one is a Workbook that has to be exported and the second one is the output stream. In our case we'll create a simple Workbook (instance of *Telerik.Windows.Documents.Spreadsheet.Model.Workbook*) with a single Worksheet (instance of *Telerik.Windows.Documents.Spreadsheet.Model.Workbook*) in it.        

Our first task is to get needed information from __RadPivotGrid__ by using Export method. After that we'll create a new Workbook and new Stylesheet. By using the information from the Export method, we'll set the cells in the stylesheet and we'll set the FontSize, FontFamily, Fill, Indent, Value, Borders, etc. The final step is to use the __XlsxFormatProvider__ and its Export method, which will help us to create the xlsx file.        

>You can use the method below and call it on a click of a button for example. By using it, __RadPivotGrid__ will be exported with the same fonts and colors as it is in your application. You can remove the properties, which you do not want to export (for example fill, indent or alignment).         

__Example 1: Generating the exported workbook__

```C#
	private void ExportToExcel()
	{
	    SaveFileDialog dialog = new SaveFileDialog();
	    dialog.DefaultExt = "xlsx";
	    dialog.Filter = "Excel Workbook (xlsx) | *.xlsx |All Files (*.*) | *.*";
	
	    var result = dialog.ShowDialog();
	    if ((bool)result)
	    {
	        try
	        {
	            using (var stream = dialog.OpenFile())
	            {
	                var workbook = GenerateWorkbook();
	
	                XlsxFormatProvider provider = new XlsxFormatProvider();
	                provider.Export(workbook, stream, null);
	            }
	        }
	        catch (IOException ex)
	        {
	            MessageBox.Show(ex.Message);
	        }
	    }
	}
	
	private Workbook GenerateWorkbook()
	{
	    var export = pivot.GenerateExport();
	    
	    Workbook workbook = new Workbook();
	    workbook.History.IsEnabled = false;
	
	    var worksheet = workbook.Worksheets.Add();
	
	    workbook.SuspendLayoutUpdate();
	    int rowCount = export.RowCount;
	    int columnCount = export.ColumnCount;
	
	    var allCells = worksheet.Cells[0, 0, rowCount - 1, columnCount - 1];
	    allCells.SetFontFamily(new ThemableFontFamily(pivot.FontFamily));
	    allCells.SetFontSize(12);
	    allCells.SetFill(GenerateFill(pivot.Background));
	
	    foreach (var cellInfo in export.Cells)
	    {
	        int rowStartIndex = cellInfo.Row;
	        int rowEndIndex = rowStartIndex + cellInfo.RowSpan - 1;
	        int columnStartIndex = cellInfo.Column;
	        int columnEndIndex = columnStartIndex + cellInfo.ColumnSpan - 1;
	
	        CellSelection cellSelection = worksheet.Cells[rowStartIndex, columnStartIndex];
	
	        var value = cellInfo.Value;
	        if (value != null)
	        {
	            cellSelection.SetValue(Convert.ToString(value));
	            cellSelection.SetVerticalAlignment(RadVerticalAlignment.Center);
	            cellSelection.SetHorizontalAlignment(GetHorizontalAlignment(cellInfo.TextAlignment));
	            int indent = cellInfo.Indent;
	            if (indent > 0)
	            {
	                cellSelection.SetIndent(indent);
	            }
	        }
	
	        cellSelection = worksheet.Cells[rowStartIndex, columnStartIndex, rowEndIndex, columnEndIndex];
	
	        SetCellProperties(cellInfo, cellSelection);
	    }
	
	    for (int i = 0; i < columnCount; i++)
	    {
	        var columnSelection = worksheet.Columns[i];
	        columnSelection.AutoFitWidth();
	
	        //NOTE: workaround for incorrect autofit.
	        var newWidth = worksheet.Columns[i].GetWidth().Value.Value + 15;
	        columnSelection.SetWidth(new ColumnWidth(newWidth, false));
	    }
	
	    workbook.ResumeLayoutUpdate();
	    return workbook;
	}
	
	private RadHorizontalAlignment GetHorizontalAlignment(TextAlignment textAlignment)
	{
	    switch (textAlignment)
	    {
	        case TextAlignment.Center:
	            return RadHorizontalAlignment.Center;
	
	        case TextAlignment.Left:
	            return RadHorizontalAlignment.Left;
	
	        case TextAlignment.Right:
	            return RadHorizontalAlignment.Right;
	
	        case TextAlignment.Justify:
	        default:
	            return RadHorizontalAlignment.Justify;
	    }
	}
	
	private static void SetCellProperties(PivotExportCellInfo cellInfo, CellSelection cellSelection)
	{
	    var fill = GenerateFill(cellInfo.Background);
	    if (fill != null)
	    {
	        cellSelection.SetFill(fill);
	    }
	
	    SolidColorBrush solidBrush = cellInfo.Foreground as SolidColorBrush;
	    if (solidBrush != null)
	    {
	        cellSelection.SetForeColor(new ThemableColor(solidBrush.Color));
	    }
	
	    if (cellInfo.FontWeight.HasValue && cellInfo.FontWeight.Value != FontWeights.Normal)
	    {
	        cellSelection.SetIsBold(true);
	    }
	
	    SolidColorBrush solidBorderBrush = cellInfo.BorderBrush as SolidColorBrush;
	    if (solidBorderBrush != null && cellInfo.BorderThickness.HasValue)
	    {
	        var borderThickness = cellInfo.BorderThickness.Value;
	        var color = new ThemableColor(solidBorderBrush.Color);
	        var leftBorder = new CellBorder(GetBorderStyle(borderThickness.Left), color);
	        var topBorder = new CellBorder(GetBorderStyle(borderThickness.Top), color);
	        var rightBorder = new CellBorder(GetBorderStyle(borderThickness.Right), color);
	        var bottomBorder = new CellBorder(GetBorderStyle(borderThickness.Bottom), color);
	        var insideBorder = cellInfo.Background != null ? new CellBorder(CellBorderStyle.None, color) : null;
	        cellSelection.SetBorders(new CellBorders(leftBorder, topBorder, rightBorder, bottomBorder, insideBorder, insideBorder, null, null));
	    }
	}
	
	private static CellBorderStyle GetBorderStyle(double thickness)
	{
	    if (thickness < 1)
	    {
	        return CellBorderStyle.None;
	    }   
	    else if (thickness < 2)
	    {
	        return CellBorderStyle.Thin;
	    }
	    else if (thickness < 3)
	    {
	        return CellBorderStyle.Medium;
	    }
	    else
	    {
	        return CellBorderStyle.Thick;
	    }
	}
	
	private static IFill GenerateFill(Brush brush)
	{
	    if (brush != null)
	    {
	        SolidColorBrush solidBrush = brush as SolidColorBrush;
	        if (solidBrush != null)
	        {
	            return PatternFill.CreateSolidFill(solidBrush.Color);
	        }
	    }
	
	    return null;
	}
```
```VB.NET
	Private Sub ExportToExcel()
		Dim dialog As New SaveFileDialog()
		dialog.DefaultExt = "xlsx"
		dialog.Filter = "Excel Workbook (xlsx) | *.xlsx |All Files (*.*) | *.*"
	
		Dim result = dialog.ShowDialog()
		If CBool(result) Then
			Try
				Using stream = dialog.OpenFile()
					Dim workbook = GenerateWorkbook()
	
					Dim provider As New XlsxFormatProvider()
					provider.Export(workbook, stream, null)
				End Using
			Catch ex As IOException
				MessageBox.Show(ex.Message)
			End Try
		End If
	End Sub
	
	Private Function GenerateWorkbook() As Workbook
		Dim export = pivot.GenerateExport()
	
		Dim workbook As New Workbook()
		workbook.History.IsEnabled = False
	
		Dim worksheet = workbook.Worksheets.Add()
	
		workbook.SuspendLayoutUpdate()
		Dim rowCount As Integer = export.RowCount
		Dim columnCount As Integer = export.ColumnCount
	
		Dim allCells = worksheet.Cells(0, 0, rowCount - 1, columnCount - 1)
		allCells.SetFontFamily(New ThemableFontFamily(pivot.FontFamily))
		allCells.SetFontSize(12)
		allCells.SetFill(GenerateFill(pivot.Background))
	
		For Each cellInfo In export.Cells
			Dim rowStartIndex As Integer = cellInfo.Row
			Dim rowEndIndex As Integer = rowStartIndex + cellInfo.RowSpan - 1
			Dim columnStartIndex As Integer = cellInfo.Column
			Dim columnEndIndex As Integer = columnStartIndex + cellInfo.ColumnSpan - 1
	
			Dim cellSelection As CellSelection = worksheet.Cells(rowStartIndex, columnStartIndex)
	
			Dim value = cellInfo.Value
			If value IsNot Nothing Then
				cellSelection.SetValue(Convert.ToString(value))
				cellSelection.SetVerticalAlignment(RadVerticalAlignment.Center)
				cellSelection.SetHorizontalAlignment(GetHorizontalAlignment(cellInfo.TextAlignment))
				Dim indent As Integer = cellInfo.Indent
				If indent > 0 Then
					cellSelection.SetIndent(indent)
				End If
			End If
	
			cellSelection = worksheet.Cells(rowStartIndex, columnStartIndex, rowEndIndex, columnEndIndex)
	
			SetCellProperties(cellInfo, cellSelection)
		Next cellInfo
	
		For i As Integer = 0 To columnCount - 1
			Dim columnSelection = worksheet.Columns(i)
			columnSelection.AutoFitWidth()
	
			'NOTE: workaround for incorrect autofit.
			Dim newWidth = worksheet.Columns(i).GetWidth().Value.Value + 15
			columnSelection.SetWidth(New ColumnWidth(newWidth, False))
		Next i
	
		workbook.ResumeLayoutUpdate()
		Return workbook
	End Function
	
	Private Function GetHorizontalAlignment(ByVal textAlignment As TextAlignment) As RadHorizontalAlignment
		Select Case textAlignment
			Case TextAlignment.Center
				Return RadHorizontalAlignment.Center
	
			Case TextAlignment.Left
				Return RadHorizontalAlignment.Left
	
			Case TextAlignment.Right
				Return RadHorizontalAlignment.Right
	
			Case Else
				Return RadHorizontalAlignment.Justify
		End Select
	End Function
	
	Private Shared Sub SetCellProperties(ByVal cellInfo As PivotExportCellInfo, ByVal cellSelection As CellSelection)
		Dim fill = GenerateFill(cellInfo.Background)
		If fill IsNot Nothing Then
			cellSelection.SetFill(fill)
		End If
	
		Dim solidBrush As SolidColorBrush = TryCast(cellInfo.Foreground, SolidColorBrush)
		If solidBrush IsNot Nothing Then
			cellSelection.SetForeColor(New ThemableColor(solidBrush.Color))
		End If
	
		If cellInfo.FontWeight.HasValue AndAlso cellInfo.FontWeight.Value <> FontWeights.Normal Then
			cellSelection.SetIsBold(True)
		End If
	
		Dim solidBorderBrush As SolidColorBrush = TryCast(cellInfo.BorderBrush, SolidColorBrush)
		If solidBorderBrush IsNot Nothing AndAlso cellInfo.BorderThickness.HasValue Then
			Dim borderThickness = cellInfo.BorderThickness.Value
			Dim color = New ThemableColor(solidBorderBrush.Color)
			Dim leftBorder = New CellBorder(GetBorderStyle(borderThickness.Left), color)
			Dim topBorder = New CellBorder(GetBorderStyle(borderThickness.Top), color)
			Dim rightBorder = New CellBorder(GetBorderStyle(borderThickness.Right), color)
			Dim bottomBorder = New CellBorder(GetBorderStyle(borderThickness.Bottom), color)
			Dim insideBorder = If(cellInfo.Background IsNot Nothing, New CellBorder(CellBorderStyle.None, color), Nothing)
			cellSelection.SetBorders(New CellBorders(leftBorder, topBorder, rightBorder, bottomBorder, insideBorder, insideBorder, Nothing, Nothing))
		End If
	End Sub
	
	Private Shared Function GetBorderStyle(ByVal thickness As Double) As CellBorderStyle
		If thickness < 1 Then
			Return CellBorderStyle.None
		ElseIf thickness < 2 Then
			Return CellBorderStyle.Thin
		ElseIf thickness < 3 Then
			Return CellBorderStyle.Medium
		Else
			Return CellBorderStyle.Thick
		End If
	End Function
	
	Private Shared Function GenerateFill(ByVal brush As Brush) As IFill
		If brush IsNot Nothing Then
			Dim solidBrush As SolidColorBrush = TryCast(brush, SolidColorBrush)
			If solidBrush IsNot Nothing Then
				Return PatternFill.CreateSolidFill(solidBrush.Color)
			End If
		End If
	
		Return Nothing
	End Function
```

## Export to Word, Pdf and HTML

>In order to Export to docx, pdf or HTML format, you will have to add reference to the following assemblies:
>	* __Telerik.Windows.Documents__
>	* __Telerik.Windows.Documents.Core__ 
>Based on the format you have selected, you have to add reference to one more assembly. More information is available in the sections below.

No matter which of these three formats you have chosen, you will have to create a new __RadDocument__, which will hold the content, that will be exported. After that, you have to set this __RadDocument__ instance to the Document property of __RadRichTextBox__. This __RadRichTextBox__ must be visualized in order to be able to export its data. To generate __RadDocument__ you can use the code below:        

>tip You can put __RadRichTextBox__ as a content of a __RadWindow__ and use the window as PrintPreview dialog. You can check a full implementation of this solution in our {% if site.site_name == 'Silverlight' %}[Export](https://demos.telerik.com/silverlight/#PivotGrid/Export){% endif %}{% if site.site_name == 'WPF' %}[Export](https://demos.telerik.com/wpf/){% endif %} demo. If you do not want to show PrintPreview dialog, you can set the visibility of the window to collapsed.          

__Example 2: Generating the exported document__

```C#
	private RadDocument GenerateRadDocument()
	{
	    var export = pivot.GenerateExport();
	    int rowCount = export.RowCount;
	    int columnCount = export.ColumnCount;
	
	    RadDocument document = new RadDocument();
	    document.SectionDefaultPageMargin = new Telerik.Windows.Documents.Layout.Padding(10);
	    document.LayoutMode = DocumentLayoutMode.Paged;
	    document.SectionDefaultPageOrientation = PageOrientation.Landscape;
	    document.Style.SpanProperties.FontFamily = pivot.FontFamily;
	    document.Style.SpanProperties.FontSize = pivot.FontSize;
	    document.Style.ParagraphProperties.SpacingAfter = 0;
	
	    var section = new Telerik.Windows.Documents.Model.Section();
	    document.Sections.Add(section);
	    section.Blocks.Add(new Paragraph());
	
	    var table = new Table(rowCount, columnCount);
	    section.Blocks.Add(table);
	
	    var tableRows = table.Rows.ToArray();
	    foreach (var cellInfo in export.Cells)
	    {
	        int rowStartIndex = cellInfo.Row;
	        int rowEndIndex = rowStartIndex + cellInfo.RowSpan - 1;
	        int columnStartIndex = cellInfo.Column;
	        int columnEndIndex = columnStartIndex + cellInfo.ColumnSpan - 1;
	
	        var value = cellInfo.Value;
	        var text = Convert.ToString(value);
	        if (!string.IsNullOrWhiteSpace(text))
	        {
	            var cells = tableRows[rowStartIndex].Cells.ToArray();
	            var cell = cells[columnStartIndex];
	            Paragraph paragraph = new Paragraph();
	            cell.Blocks.Add(paragraph);
	            var span = new Span(text);
	            paragraph.Inlines.Add(span);
	            paragraph.TextAlignment = GetTextAlignment(cellInfo.TextAlignment);
	
	            if (cellInfo.FontWeight.HasValue)
	            {
	                span.FontWeight = cellInfo.FontWeight.Value;
	            }
	
	            Color foreColor;
	            if (GetColor(cellInfo.Foreground, out foreColor))
	            {
	                span.ForeColor = foreColor;
	            }
	
	            cell.VerticalAlignment = GetVerticalAlignment(cellInfo.VerticalAlignment);
	            paragraph.LeftIndent = cellInfo.Indent * 20;
	        }
	
	        var borderThickness = cellInfo.BorderThickness;
	        var borderBrush = cellInfo.BorderBrush;
	        var background = cellInfo.Background;
	
	        Color backColor;
	        bool hasBackground = GetColor(cellInfo.Background, out backColor);
	
	        if (cellInfo.RowSpan > 1 && cellInfo.ColumnSpan > 1)
	        {
	            for (int k = rowStartIndex; k <= rowEndIndex; k++)
	            {
	                var cells = tableRows[k].Cells.ToArray();
	                for (int j = columnStartIndex; j <= columnEndIndex; j++)
	                {
	                    var cell = cells[j];
	                    if (hasBackground)
	                    {
	                        cell.Background = backColor;
	                    }
	
	                    cell.Borders = GetCellBorders(borderThickness, borderBrush, cell.Borders, k, rowStartIndex, rowEndIndex, j, columnStartIndex, columnEndIndex, hasBackground);
	                }
	
	            }
	        }
	        else if (cellInfo.RowSpan > 1)
	        {
	            for (int j = rowStartIndex; j <= rowEndIndex; j++)
	            {
	                // TODO: check when ColumnSpan > 1;
	                var cell = tableRows[j].Cells.ToArray()[columnStartIndex];
	
	                Position position = j == rowStartIndex ? Position.First : ((j == rowEndIndex) ? Position.Last : Position.Middle);
	
	                cell.Borders = GetCellBorders(borderThickness, borderBrush, position, cell.Borders, true, cellInfo.Background != null);
	                if (hasBackground)
	                {
	                    cell.Background = backColor;
	                }
	            }
	        }
	        else if (cellInfo.ColumnSpan > 1)
	        {
	            var cells = tableRows[rowStartIndex].Cells.ToArray();
	            for (int j = columnStartIndex; j <= columnEndIndex; j++)
	            {
	                // TODO: check when RowSpan > 1;
	                var cell = cells[j];
	
	                Position position = j == columnStartIndex ? Position.First : ((j == columnEndIndex) ? Position.Last : Position.Middle);
	                if (hasBackground)
	                {
	                    cell.Background = backColor;
	                }
	
	                cell.Borders = GetCellBorders(borderThickness, borderBrush, position, cell.Borders, false, hasBackground);
	            }
	        }
	    }
	
	    return document;
	}
	
	private enum Position
	{
	    First,
	    Middle,
	    Last
	}
	
	private bool GetColor(Brush brush, out Color color)
	{
	    SolidColorBrush solidBrush = brush as SolidColorBrush;
	    if (solidBrush != null)
	    {
	        color = solidBrush.Color;
	        return true;
	    }
	
	    color = Colors.White;
	    return false;
	}
	
	private TableCellBorders GetCellBorders(Thickness? borderThickness, Brush borderBrush, TableCellBorders cellBorders,
	    int rowIndex, int rowStartIndex, int rowEndIndex, int columnIndex, int columnStartIndex, int columnEndIndex, bool hasBackground)
	{
	    Color borderBrushColor;
	    GetColor(borderBrush, out borderBrushColor);
	
	    if (!borderThickness.HasValue)
	    {
	        return new TableCellBorders(new Telerik.Windows.Documents.Model.Border(BorderStyle.None));
	    }
	
	    var thickness = borderThickness.Value;
	    Telerik.Windows.Documents.Model.Border topBorder = cellBorders.Top;
	    Telerik.Windows.Documents.Model.Border bottomBorder = cellBorders.Bottom;
	    Telerik.Windows.Documents.Model.Border leftBorder = cellBorders.Left;
	    Telerik.Windows.Documents.Model.Border rightBorder = cellBorders.Right;
	
	    if (rowIndex == rowStartIndex)
	    {
	        topBorder = new Telerik.Windows.Documents.Model.Border((float)thickness.Top, BorderStyle.Single, borderBrushColor);
	    }
	
	    if (rowIndex == rowEndIndex)
	    {
	        bottomBorder = new Telerik.Windows.Documents.Model.Border((float)thickness.Bottom, BorderStyle.Single, borderBrushColor);
	    }
	
	    if (rowStartIndex < rowIndex && rowIndex < rowEndIndex)
	    {
	        topBorder = hasBackground ? new Telerik.Windows.Documents.Model.Border(BorderStyle.None) : cellBorders.Top;
	        bottomBorder = hasBackground ? new Telerik.Windows.Documents.Model.Border(BorderStyle.None) : cellBorders.Bottom;
	    }
	
	    if (columnIndex == columnStartIndex)
	    {
	        leftBorder = new Telerik.Windows.Documents.Model.Border((float)thickness.Left, BorderStyle.Single, borderBrushColor);
	    }
	
	    if (columnIndex == columnEndIndex)
	    {
	        rightBorder = new Telerik.Windows.Documents.Model.Border((float)thickness.Right, BorderStyle.Single, borderBrushColor);
	    }
	
	    if (columnStartIndex < columnIndex && columnIndex < columnEndIndex)
	    {
	        leftBorder = hasBackground ? new Telerik.Windows.Documents.Model.Border(BorderStyle.None) : cellBorders.Left;
	        rightBorder = hasBackground ? new Telerik.Windows.Documents.Model.Border(BorderStyle.None) : cellBorders.Right;
	    }
	
	    return new TableCellBorders(leftBorder, topBorder, rightBorder, bottomBorder);
	}
	
	private TableCellBorders GetCellBorders(Thickness? borderThickness, Brush borderBrush, Position position, TableCellBorders cellBorders, bool isRow, bool hasBackground)
	{
	    Color borderBrushColor;
	    GetColor(borderBrush, out borderBrushColor);
	
	    if (!borderThickness.HasValue)
	    {
	        return new TableCellBorders(new Telerik.Windows.Documents.Model.Border(BorderStyle.None));
	    }
	
	    var thickness = borderThickness.Value;
	    if (isRow)
	    {
	        var leftBorder = new Telerik.Windows.Documents.Model.Border((float)thickness.Left, BorderStyle.Single, borderBrushColor);
	        var rightBorder = new Telerik.Windows.Documents.Model.Border((float)thickness.Right, BorderStyle.Single, borderBrushColor);
	        Telerik.Windows.Documents.Model.Border topBorder;
	        Telerik.Windows.Documents.Model.Border bottomBorder;
	        switch (position)
	        {
	            case Position.First:
	                topBorder = new Telerik.Windows.Documents.Model.Border((float)thickness.Top, BorderStyle.Single, borderBrushColor);
	                bottomBorder = hasBackground ? new Telerik.Windows.Documents.Model.Border(BorderStyle.None) : cellBorders.Bottom;
	                break;
	
	            case Position.Middle:
	                topBorder = hasBackground ? new Telerik.Windows.Documents.Model.Border(BorderStyle.None) : cellBorders.Top;
	                bottomBorder = hasBackground ? new Telerik.Windows.Documents.Model.Border(BorderStyle.None) : cellBorders.Bottom;
	                break;
	
	            case Position.Last:
	            default:
	                topBorder = hasBackground ? new Telerik.Windows.Documents.Model.Border(BorderStyle.None) : cellBorders.Top;
	                bottomBorder = new Telerik.Windows.Documents.Model.Border((float)thickness.Bottom, BorderStyle.Single, borderBrushColor);
	                break;
	        }
	
	        return new TableCellBorders(leftBorder, topBorder, rightBorder, bottomBorder);
	    }
	    else
	    {
	        var topBorder = new Telerik.Windows.Documents.Model.Border((float)thickness.Top, BorderStyle.Single, borderBrushColor);
	        var bottomBorder = new Telerik.Windows.Documents.Model.Border((float)thickness.Bottom, BorderStyle.Single, borderBrushColor);
	        Telerik.Windows.Documents.Model.Border leftBorder;
	        Telerik.Windows.Documents.Model.Border rightBorder;
	        switch (position)
	        {
	            case Position.First:
	                leftBorder = new Telerik.Windows.Documents.Model.Border((float)thickness.Left, BorderStyle.Single, borderBrushColor);
	                rightBorder = hasBackground ? new Telerik.Windows.Documents.Model.Border(BorderStyle.None) : cellBorders.Right;
	                break;
	
	            case Position.Middle:
	                leftBorder = hasBackground ? new Telerik.Windows.Documents.Model.Border(BorderStyle.None) : cellBorders.Left;
	                rightBorder = hasBackground ? new Telerik.Windows.Documents.Model.Border(BorderStyle.None) : cellBorders.Right;
	                break;
	
	            case Position.Last:
	            default:
	                leftBorder = hasBackground ? new Telerik.Windows.Documents.Model.Border(BorderStyle.None) : cellBorders.Left; ;
	                rightBorder = new Telerik.Windows.Documents.Model.Border((float)thickness.Right, BorderStyle.Single, borderBrushColor);
	                break;
	        }
	
	        return new TableCellBorders(leftBorder, topBorder, rightBorder, bottomBorder);
	    }
	}
	
	private Telerik.Windows.Documents.Layout.RadVerticalAlignment GetVerticalAlignment(VerticalAlignment verticalAlignment)
	{
	    switch (verticalAlignment)
	    {
	        case VerticalAlignment.Bottom:
	            return Telerik.Windows.Documents.Layout.RadVerticalAlignment.Bottom;
	
	        case VerticalAlignment.Stretch:
	        case VerticalAlignment.Center:
	            return Telerik.Windows.Documents.Layout.RadVerticalAlignment.Center;
	
	        case VerticalAlignment.Top:
	        default:
	            return Telerik.Windows.Documents.Layout.RadVerticalAlignment.Top;
	    }
	}
	
	private Telerik.Windows.Documents.Layout.RadTextAlignment GetTextAlignment(TextAlignment textAlignment)
	{
	    switch (textAlignment)
	    {
	        case TextAlignment.Center:
	            return Telerik.Windows.Documents.Layout.RadTextAlignment.Center;
	
	        case TextAlignment.Justify:
	            return Telerik.Windows.Documents.Layout.RadTextAlignment.Justify;
	
	        case TextAlignment.Right:
	            return Telerik.Windows.Documents.Layout.RadTextAlignment.Right;
	
	        case TextAlignment.Left:
	        default:
	            return Telerik.Windows.Documents.Layout.RadTextAlignment.Left;
	    }
	}
```
```VB.NET
	Private Function GenerateRadDocument() As RadDocument
		Dim export = pivot.GenerateExport()
		Dim rowCount As Integer = export.RowCount
		Dim columnCount As Integer = export.ColumnCount
	
		Dim document As New RadDocument()
		document.SectionDefaultPageMargin = New Telerik.Windows.Documents.Layout.Padding(10)
		document.LayoutMode = DocumentLayoutMode.Paged
		document.SectionDefaultPageOrientation = PageOrientation.Landscape
		document.Style.SpanProperties.FontFamily = pivot.FontFamily
		document.Style.SpanProperties.FontSize = pivot.FontSize
		document.Style.ParagraphProperties.SpacingAfter = 0
	
		Dim section = New Telerik.Windows.Documents.Model.Section()
		document.Sections.Add(section)
		section.Blocks.Add(New Paragraph())
	
		Dim table = New Table(rowCount, columnCount)
		section.Blocks.Add(table)
	
		Dim tableRows = table.Rows.ToArray()
		For Each cellInfo In export.Cells
			Dim rowStartIndex As Integer = cellInfo.Row
			Dim rowEndIndex As Integer = rowStartIndex + cellInfo.RowSpan - 1
			Dim columnStartIndex As Integer = cellInfo.Column
			Dim columnEndIndex As Integer = columnStartIndex + cellInfo.ColumnSpan - 1
	
			Dim value = cellInfo.Value
			Dim text = Convert.ToString(value)
			If Not String.IsNullOrWhiteSpace(text) Then
				Dim cells = tableRows(rowStartIndex).Cells.ToArray()
				Dim cell = cells(columnStartIndex)
				Dim paragraph As New Paragraph()
				cell.Blocks.Add(paragraph)
				Dim span = New Span(text)
				paragraph.Inlines.Add(span)
				paragraph.TextAlignment = GetTextAlignment(cellInfo.TextAlignment)
	
				If cellInfo.FontWeight.HasValue Then
					span.FontWeight = cellInfo.FontWeight.Value
				End If
	
				Dim foreColor As Color
				If GetColor(cellInfo.Foreground, foreColor) Then
					span.ForeColor = foreColor
				End If
	
				cell.VerticalAlignment = GetVerticalAlignment(cellInfo.VerticalAlignment)
				paragraph.LeftIndent = cellInfo.Indent * 20
			End If
	
			Dim borderThickness = cellInfo.BorderThickness
			Dim borderBrush = cellInfo.BorderBrush
			Dim background = cellInfo.Background
	
			Dim backColor As Color
			Dim hasBackground As Boolean = GetColor(cellInfo.Background, backColor)
	
			If cellInfo.RowSpan > 1 AndAlso cellInfo.ColumnSpan > 1 Then
				For k As Integer = rowStartIndex To rowEndIndex
					Dim cells = tableRows(k).Cells.ToArray()
					For j As Integer = columnStartIndex To columnEndIndex
						Dim cell = cells(j)
						If hasBackground Then
							cell.Background = backColor
						End If
	
						cell.Borders = GetCellBorders(borderThickness, borderBrush, cell.Borders, k, rowStartIndex, rowEndIndex, j, columnStartIndex, columnEndIndex, hasBackground)
					Next j
	
				Next k
			ElseIf cellInfo.RowSpan > 1 Then
				For j As Integer = rowStartIndex To rowEndIndex
					' TODO: check when ColumnSpan > 1;
					Dim cell = tableRows(j).Cells.ToArray()(columnStartIndex)
	
					Dim position As Position = If(j = rowStartIndex, Position.First, (If(j = rowEndIndex, Position.Last, Position.Middle)))
	
					cell.Borders = GetCellBorders(borderThickness, borderBrush, position, cell.Borders, True, cellInfo.Background IsNot Nothing)
					If hasBackground Then
						cell.Background = backColor
					End If
				Next j
			ElseIf cellInfo.ColumnSpan > 1 Then
				Dim cells = tableRows(rowStartIndex).Cells.ToArray()
				For j As Integer = columnStartIndex To columnEndIndex
					' TODO: check when RowSpan > 1;
					Dim cell = cells(j)
	
					Dim position As Position = If(j = columnStartIndex, Position.First, (If(j = columnEndIndex, Position.Last, Position.Middle)))
					If hasBackground Then
						cell.Background = backColor
					End If
	
					cell.Borders = GetCellBorders(borderThickness, borderBrush, position, cell.Borders, False, hasBackground)
				Next j
			End If
		Next cellInfo
	
		Return document
	End Function
	
	Private Enum Position
		First
		Middle
		Last
	End Enum
	
	Private Function GetColor(ByVal brush As Brush, ByRef color As Color) As Boolean
		Dim solidBrush As SolidColorBrush = TryCast(brush, SolidColorBrush)
		If solidBrush IsNot Nothing Then
			color = solidBrush.Color
			Return True
		End If
	
		color = Colors.White
		Return False
	End Function
	
	Private Function GetCellBorders(ByVal borderThickness? As Thickness, ByVal borderBrush As Brush, ByVal cellBorders As TableCellBorders, ByVal rowIndex As Integer, ByVal rowStartIndex As Integer, ByVal rowEndIndex As Integer, ByVal columnIndex As Integer, ByVal columnStartIndex As Integer, ByVal columnEndIndex As Integer, ByVal hasBackground As Boolean) As TableCellBorders
		Dim borderBrushColor As Color
		GetColor(borderBrush, borderBrushColor)
	
		If Not borderThickness.HasValue Then
			Return New TableCellBorders(New Telerik.Windows.Documents.Model.Border(BorderStyle.None))
		End If
	
		Dim thickness = borderThickness.Value
		Dim topBorder As Telerik.Windows.Documents.Model.Border = cellBorders.Top
		Dim bottomBorder As Telerik.Windows.Documents.Model.Border = cellBorders.Bottom
		Dim leftBorder As Telerik.Windows.Documents.Model.Border = cellBorders.Left
		Dim rightBorder As Telerik.Windows.Documents.Model.Border = cellBorders.Right
	
		If rowIndex = rowStartIndex Then
			topBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Top), BorderStyle.Single, borderBrushColor)
		End If
	
		If rowIndex = rowEndIndex Then
			bottomBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Bottom), BorderStyle.Single, borderBrushColor)
		End If
	
		If rowStartIndex < rowIndex AndAlso rowIndex < rowEndIndex Then
			topBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Top)
			bottomBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Bottom)
		End If
	
		If columnIndex = columnStartIndex Then
			leftBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Left), BorderStyle.Single, borderBrushColor)
		End If
	
		If columnIndex = columnEndIndex Then
			rightBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Right), BorderStyle.Single, borderBrushColor)
		End If
	
		If columnStartIndex < columnIndex AndAlso columnIndex < columnEndIndex Then
			leftBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Left)
			rightBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Right)
		End If
	
		Return New TableCellBorders(leftBorder, topBorder, rightBorder, bottomBorder)
	End Function
	
	Private Function GetCellBorders(ByVal borderThickness? As Thickness, ByVal borderBrush As Brush, ByVal cellBorders As TableCellBorders, ByVal rowIndex As Integer, ByVal rowStartIndex As Integer, ByVal rowEndIndex As Integer, ByVal columnIndex As Integer, ByVal columnStartIndex As Integer, ByVal columnEndIndex As Integer, ByVal hasBackground As Boolean) As TableCellBorders
		Dim borderBrushColor As Color
		GetColor(borderBrush, borderBrushColor)
	
		If Not borderThickness.HasValue Then
			Return New TableCellBorders(New Telerik.Windows.Documents.Model.Border(BorderStyle.None))
		End If
	
		Dim thickness = borderThickness.Value
		Dim topBorder As Telerik.Windows.Documents.Model.Border = cellBorders.Top
		Dim bottomBorder As Telerik.Windows.Documents.Model.Border = cellBorders.Bottom
		Dim leftBorder As Telerik.Windows.Documents.Model.Border = cellBorders.Left
		Dim rightBorder As Telerik.Windows.Documents.Model.Border = cellBorders.Right
	
		If rowIndex = rowStartIndex Then
			topBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Top), BorderStyle.Single, borderBrushColor)
		End If
	
		If rowIndex = rowEndIndex Then
			bottomBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Bottom), BorderStyle.Single, borderBrushColor)
		End If
	
		If rowStartIndex < rowIndex AndAlso rowIndex < rowEndIndex Then
			topBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Top)
			bottomBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Bottom)
		End If
	
		If columnIndex = columnStartIndex Then
			leftBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Left), BorderStyle.Single, borderBrushColor)
		End If
	
		If columnIndex = columnEndIndex Then
			rightBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Right), BorderStyle.Single, borderBrushColor)
		End If
	
		If columnStartIndex < columnIndex AndAlso columnIndex < columnEndIndex Then
			leftBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Left)
			rightBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Right)
		End If
	
		Return New TableCellBorders(leftBorder, topBorder, rightBorder, bottomBorder)
	End Function
	
	Private Function GetCellBorders(ByVal borderThickness? As Thickness, ByVal borderBrush As Brush, ByVal position As Position, ByVal cellBorders As TableCellBorders, ByVal isRow As Boolean, ByVal hasBackground As Boolean) As TableCellBorders
		Dim borderBrushColor As Color
		GetColor(borderBrush, borderBrushColor)
	
		If Not borderThickness.HasValue Then
			Return New TableCellBorders(New Telerik.Windows.Documents.Model.Border(BorderStyle.None))
		End If
	
		Dim thickness = borderThickness.Value
		If isRow Then
			Dim leftBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Left), BorderStyle.Single, borderBrushColor)
			Dim rightBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Right), BorderStyle.Single, borderBrushColor)
			Dim topBorder As Telerik.Windows.Documents.Model.Border
			Dim bottomBorder As Telerik.Windows.Documents.Model.Border
			Select Case position
				Case Position.First
					topBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Top), BorderStyle.Single, borderBrushColor)
					bottomBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Bottom)
	
				Case Position.Middle
					topBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Top)
					bottomBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Bottom)
	
				Case Else
					topBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Top)
					bottomBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Bottom), BorderStyle.Single, borderBrushColor)
			End Select
	
			Return New TableCellBorders(leftBorder, topBorder, rightBorder, bottomBorder)
		Else
			Dim topBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Top), BorderStyle.Single, borderBrushColor)
			Dim bottomBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Bottom), BorderStyle.Single, borderBrushColor)
			Dim leftBorder As Telerik.Windows.Documents.Model.Border
			Dim rightBorder As Telerik.Windows.Documents.Model.Border
			Select Case position
				Case Position.First
					leftBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Left), BorderStyle.Single, borderBrushColor)
					rightBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Right)
	
				Case Position.Middle
					leftBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Left)
					rightBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Right)
	
				Case Else
					leftBorder = If(hasBackground, New Telerik.Windows.Documents.Model.Border(BorderStyle.None), cellBorders.Left)
	
					rightBorder = New Telerik.Windows.Documents.Model.Border(CSng(thickness.Right), BorderStyle.Single, borderBrushColor)
			End Select
	
			Return New TableCellBorders(leftBorder, topBorder, rightBorder, bottomBorder)
		End If
	End Function
	
	Private Function GetVerticalAlignment(ByVal verticalAlignment As VerticalAlignment) As Telerik.Windows.Documents.Layout.RadVerticalAlignment
		Select Case verticalAlignment
			Case VerticalAlignment.Bottom
				Return Telerik.Windows.Documents.Layout.RadVerticalAlignment.Bottom
	
			Case VerticalAlignment.Stretch, VerticalAlignment.Center
				Return Telerik.Windows.Documents.Layout.RadVerticalAlignment.Center
	
			Case Else
				Return Telerik.Windows.Documents.Layout.RadVerticalAlignment.Top
		End Select
	End Function
	
	Private Function GetTextAlignment(ByVal textAlignment As TextAlignment) As Telerik.Windows.Documents.Layout.RadTextAlignment
		Select Case textAlignment
			Case TextAlignment.Center
				Return Telerik.Windows.Documents.Layout.RadTextAlignment.Center
	
			Case TextAlignment.Justify
				Return Telerik.Windows.Documents.Layout.RadTextAlignment.Justify
	
			Case TextAlignment.Right
				Return Telerik.Windows.Documents.Layout.RadTextAlignment.Right
	
			Case Else
				Return Telerik.Windows.Documents.Layout.RadTextAlignment.Left
		End Select
	End Function
```

Here is a simple method, that will export the document to the specified file stream. This method is used in all of the below cases.        

__Example 3: Method for exporting the generated document__

```C#
	private static void SaveFile(SaveFileDialog dialog, IDocumentFormatProvider provider, RadDocument document)
	{
	    var result = dialog.ShowDialog();
	    if (result == true)
	    {
	        try
	        {
	            using (var stream = dialog.OpenFile())
	            {
	                provider.Export(document, stream, null);
	            }
	        }
	        catch (IOException ex)
	        {
	            MessageBox.Show(ex.Message);
	        }
	    }
	}
```
```VB.NET
	Private Shared Sub SaveFile(ByVal dialog As SaveFileDialog, ByVal provider As IDocumentFormatProvider, ByVal document As RadDocument)
		Dim result = dialog.ShowDialog()
		If result = True Then
			Try
				Using stream = dialog.OpenFile()
					provider.Export(document, stream, null)
				End Using
			Catch ex As IOException
				MessageBox.Show(ex.Message)
			End Try
		End If
	End Sub
```

### Export To Word

>In order to use Export to Word functionality, you will have to add reference to the __Telerik.Windows.Documents.FormatProviders.OpenXml__ assembly.                

After you've generated the document (instance of __RadDocument__) you have to set the *Document* property of __RadRichTextBox__. Note that __RadRichTextBox__ should be visible in order to create the document based on *Document* property.
              

__Example 4: Exporting the generated document as DOCX__

```C#
	private void WordExport_Click(object sender, RoutedEventArgs e)
	{
	    RadDocument document = GenerateRadDocument();
	    richTextBox.Document = document;
	
	    var provider = new DocxFormatProvider();
	    SaveFileDialog dialog = new SaveFileDialog();
	    dialog.DefaultExt = "docx";
	    dialog.Filter = "Word document (docx) | *.docx |All Files (*.*) | *.*";
	    SaveFile(dialog, provider, document);
	}
```
```VB.NET
	Private Sub WordExport_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Dim document As RadDocument = GenerateRadDocument()
		richTextBox.Document = document
	
		Dim provider = New DocxFormatProvider()
		Dim dialog As New SaveFileDialog()
		dialog.DefaultExt = "docx"
		dialog.Filter = "Word document (docx) | *.docx |All Files (*.*) | *.*"
		SaveFile(dialog, provider, document)
	End Sub
```

### Export To Pdf

>In order to use Export to pdf functionality, you will have to add reference to the __Telerik.Windows.Documents.FormatProviders.Pdf__ assembly.                

After you've generated the document (instance of __RadDocument__) you have to set the *Document* property of __RadRichTextBox__. Note that __RadRichTextBox__ should be visible in order to create the document based on *Document* property.              

__Example 5: Exporting the generated document as PDF__

```C#
	private void PdfExport_Click(object sender, RoutedEventArgs e)
	{
	    RadDocument document = GenerateRadDocument();
	    rtb.Document = document;
	
	    var provider = new PdfFormatProvider();
	    SaveFileDialog dialog = new SaveFileDialog();
	    dialog.DefaultExt = "pdf";
	    dialog.Filter = "Pdf document (pdf) | *.pdf |All Files (*.*) | *.*";
	    SaveFile(dialog, provider, document);
	}
```
```VB.NET
	Private Sub PdfExport_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Dim document As RadDocument = GenerateRadDocument()
		rtb.Document = document
	
		Dim provider = New PdfFormatProvider()
		Dim dialog As New SaveFileDialog()
		dialog.DefaultExt = "pdf"
		dialog.Filter = "Pdf document (pdf) | *.pdf |All Files (*.*) | *.*"
		SaveFile(dialog, provider, document)
	End Sub
```

> The [ExportPivotGrid](https://github.com/telerik/xaml-sdk/tree/master/PivotGrid/ExportPivotGrid) example shows how the RadPivotGrid can be exported to PDF via the [PdfProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/overview) library. The approach that is used is similar to the one from the [ExportUIElement](https://github.com/telerik/document-processing-sdk/tree/master/PdfProcessing/ExportUIElement) example.  

### Export To HTML

>In order to use Export to HTML functionality, you will have to add reference to the __Telerik.Windows.Documents.FormatProviders.Html__ assembly.

After you've generated the document (instance of __RadDocument__) you have to set the *Document* property of __RadRichTextBox__. Note that __RadRichTextBox__ should be visible in order to create the document based on *Document* property.              

__Example 6: Exporting the generated document as HTML__

```C#
	private void HtmlExport_Click(object sender, RoutedEventArgs e)
	{
	    RadDocument document = GenerateRadDocument();
	    rtb.Document = document;
	
	    var provider = new HtmlFormatProvider();
	    SaveFileDialog dialog = new SaveFileDialog();
	    dialog.DefaultExt = "html";
	    dialog.Filter = "Html document (html) | *.html |All Files (*.*) | *.*";
	    SaveFile(dialog, provider, document);
	}
```
```VB.NET
	Private Sub HtmlExport_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Dim document As RadDocument = GenerateRadDocument()
		rtb.Document = document
	
		Dim provider = New HtmlFormatProvider()
		Dim dialog As New SaveFileDialog()
		dialog.DefaultExt = "html"
		dialog.Filter = "Html document (html) | *.html |All Files (*.*) | *.*"
		SaveFile(dialog, provider, document)
	End Sub
```

>A working version of this example is also available in the [SDK Samples Browser](https://demos.telerik.com/xaml-sdkbrowser/), titled **Export PivotGrid**.

## See Also

 * [RadPivotGrid Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [Features]({%slug radpivotgrid-features%})
