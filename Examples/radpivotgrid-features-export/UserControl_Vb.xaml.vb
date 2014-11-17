' #Region "radpivotgrid-features-export_1"
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
				provider.Export(workbook, stream)
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
' #End Region

' #Region "radpivotgrid-features-export_2"
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
' #End Region

' #Region "radpivotgrid-features-export_3"
Private Shared Sub SaveFile(ByVal dialog As SaveFileDialog, ByVal provider As IDocumentFormatProvider, ByVal document As RadDocument)
	Dim result = dialog.ShowDialog()
	If result = True Then
		Try
			Using stream = dialog.OpenFile()
				provider.Export(document, stream)
			End Using
		Catch ex As IOException
			MessageBox.Show(ex.Message)
		End Try
	End If
End Sub
' #End Region

' #Region "radpivotgrid-features-export_4"
Private Sub WordExport_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	Dim document As RadDocument = GenerateRadDocument()
	richTextBox.Document = document

	Dim provider = New DocxFormatProvider()
	Dim dialog As New SaveFileDialog()
	dialog.DefaultExt = "docx"
	dialog.Filter = "Word document (docx) | *.docx |All Files (*.*) | *.*"
	SaveFile(dialog, provider, document)
End Sub
' #End Region

' #Region "radpivotgrid-features-export_5"
Private Sub PdfExport_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	Dim document As RadDocument = GenerateRadDocument()
	rtb.Document = document

	Dim provider = New PdfFormatProvider()
	Dim dialog As New SaveFileDialog()
	dialog.DefaultExt = "pdf"
	dialog.Filter = "Pdf document (pdf) | *.pdf |All Files (*.*) | *.*"
	SaveFile(dialog, provider, document)
End Sub
' #End Region

' #Region "radpivotgrid-features-export_6"
Private Sub HtmlExport_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	Dim document As RadDocument = GenerateRadDocument()
	rtb.Document = document

	Dim provider = New HtmlFormatProvider()
	Dim dialog As New SaveFileDialog()
	dialog.DefaultExt = "html"
	dialog.Filter = "Html document (html) | *.html |All Files (*.*) | *.*"
	SaveFile(dialog, provider, document)
End Sub
' #End Region