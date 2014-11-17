Public Class Default_Vb


    ' #region radchart-features-export-to-pdf_1
    Dim section As New Section()
    Dim paragraph As New Paragraph()
    Dim bi As New BitmapImage()
Using ms As New MemoryStream()
RadChart1.ExportToImage(ms, New PngBitmapEncoder())
bi.SetSource(ms)
      End Using
    Dim image As New ImageInline(New WriteableBitmap(bi))
      700, Height = 500
      Width = 700, Height
paragraph.Inlines.Add(image)
section.Blocks.Add(paragraph)
document.Sections.Add(section)
    ' #endregion

    ' #region radchart-features-export-to-pdf_3
    Dim section As New Section()
    Dim paragraph As New Paragraph()

    Dim ms As New MemoryStream()
RadChart1.ExportToImage(ms, New PngBitmapEncoder())
    Dim image As New ImageInline(ms, New Size(700, 500), "png")

paragraph.Inlines.Add(image)
section.Blocks.Add(paragraph)
document.Sections.Add(section)

ms.Close()
    ' #endregion

    ' #region radchart-features-export-to-pdf_5
    Private Sub Export_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
        Dim dialog As New SaveFileDialog()
        dialog.DefaultExt = "*.pdf"
        dialog.Filter = "Adobe PDF Document (*.pdf)|*.pdf"
        If dialog.ShowDialog() = True Then
            Dim document As RadDocument = Me.CreateDocument()
            document.LayoutMode = DocumentLayoutMode.Paged
            document.Measure(RadDocument.MAX_DOCUMENT_SIZE)
            document.Arrange(New RectangleF(PointF.Empty, document.DesiredSize))
            Dim provider As New PdfFormatProvider()
            Using output As Stream = dialog.OpenFile()
                provider.Export(document, output)
            End Using
        End If
    End Sub
    ' #endregion

    ' #region radchart-features-export-to-pdf_7
    Dim chart As New RadChart()
               chart.BeginInit()
                chart.DefaultView.ChartArea.EnableAnimations = False
                chart.DefaultView.ChartArea.AxisX.LabelStep = 5
                chart.Width = 600
                chart.Height = 400
    Dim sm As New SeriesMapping()
                sm.ItemsSource = (TryCast(Me.DataContext, ExamplesDataContext)).RandomProducts
                sm.SeriesDefinition = New BarSeriesDefinition() With {.ShowItemLabels = False, .ItemStyle = TryCast(Me.LayoutRoot.Resources("ExportStyle"), Style)}
                sm.ItemMappings.Add(New ItemMapping("UnitPRice", DataPointMember.YValue))
                chart.SeriesMappings.Add(sm)
                chart.EndInit()
                chart.Measure(New System.Windows.Size(chart.Width, chart.Height))
                chart.Arrange(New System.Windows.Rect(New Point(0, 0), chart.DesiredSize))
    Dim section As New Section()
    Dim paragraph As New Paragraph()

    Dim ms As New MemoryStream()
    RadChart1.ExportToImage(ms, New PngBitmapEncoder())
    Dim image As New ImageInline(ms, New Size(700, 500), "png")

    paragraph.Inlines.Add(image)
    section.Blocks.Add(paragraph)
    document.Sections.Add(section)

    ms.Close()
    ' #endregion
End Class
