#region radpivotgrid-features-export_1
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
                provider.Export(workbook, stream);
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
#endregion

#region radpivotgrid-features-export_2
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
#endregion

#region radpivotgrid-features-export_3
private static void SaveFile(SaveFileDialog dialog, IDocumentFormatProvider provider, RadDocument document)
{
    var result = dialog.ShowDialog();
    if (result == true)
    {
        try
        {
            using (var stream = dialog.OpenFile())
            {
                provider.Export(document, stream);
            }
        }
        catch (IOException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
#endregion

#region radpivotgrid-features-export_4
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
#endregion

#region radpivotgrid-features-export_5
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
#endregion

#region radpivotgrid-features-export_6
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
#endregion