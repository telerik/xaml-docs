Public Class Default_Vb

' #region common-export-support_0
 Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	Dim extension As String = "png"
	Dim dialog As New SaveFileDialog() With {.DefaultExt = extension, .Filter = "Png (*.png)|*.png"}

	If dialog.ShowDialog() = True Then
		Using stream As Stream = dialog.OpenFile()
			Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(Me.radGauge, stream, New System.Windows.Media.Imaging.PngBitmapEncoder())
		End Using
	End If
 End Sub
' #endregion
' #region common-export-support_1
 Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	Dim extension As String = "png"
	Dim dialog As New SaveFileDialog() With {.DefaultExt = extension, .Filter = "Png (*.png)|*.png"}

	If dialog.ShowDialog() = True Then
		Using stream As Stream = dialog.OpenFile()
			Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(Me.radGauge, stream, New Telerik.Windows.Media.Imaging.PngBitmapEncoder())
		End Using
	End If
 End Sub
' #endregion


    ' #region common-export-support_2
    Public Sub export_click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim sfd As New SaveFileDialog()
        sfd.DefaultExt = "docx"
        sfd.Filter = "docx File (*.docx) | *.docx"
        If sfd.ShowDialog() = True Then
            Using saveFileStream As Stream = sfd.OpenFile()
                Dim document As New RadDocument()
                Dim section As New Section()
                document.Sections.Add(section)
                Dim paragraph As New Paragraph()
                section.Blocks.Add(paragraph)
                Dim span As New Span("Here comes a RadChart:")
                paragraph.Inlines.Add(span)

                Using stream = New MemoryStream()
                    Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(Me.radChart, stream, New PngBitmapEncoder())
                    stream.Flush()
                    stream.Seek(0, SeekOrigin.Begin)
                    paragraph.Inlines.Add(New ImageInline(stream))
                End Using

                Dim paragraph2 As New Paragraph()
                section.Blocks.Add(paragraph2)
                Dim span2 As New Span("And this is a RadGauge in the same document:")
                paragraph2.Inlines.Add(span2)
                Using stream2 = New MemoryStream()
                    Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(Me.radGauge, stream2, New PngBitmapEncoder())
                    stream2.Flush()
                    stream2.Seek(0, SeekOrigin.Begin)
                    paragraph2.Inlines.Add(New ImageInline(stream2))
                End Using
                Dim docx As New DocxFormatProvider()
                document.EnsureDocumentMeasuredAndArranged()
                docx.Export(document, saveFileStream)
            End Using
        End If

    End Sub
    ' #endregion
End Class
