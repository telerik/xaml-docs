Public Class Default_Vb


    ' #region radrichtextbox-features-import-export_1
    Public Function ExportToXAML(ByVal document As RadDocument) As String
        Dim provider As New XamlFormatProvider()
        Return provider.Export(document)
    End Function
    ' #endregion

    ' #region radrichtextbox-features-import-export_3
    Public Sub ExportToDocx(ByVal document As RadDocument)
        Dim provider As New DocxFormatProvider()
        Dim saveDialog As New SaveFileDialog()
        saveDialog.DefaultExt = ".docx"
        saveDialog.Filter = "Documents|*.docx"
        Dim dialogResult? As Boolean = saveDialog.ShowDialog()
        If dialogResult = True Then
            Using output As Stream = saveDialog.OpenFile()
                provider.Export(document, output)
                MessageBox.Show("Saved Successfuly!")
            End Using
        End If
    End Sub
    ' #endregion

    ' #region radrichtextbox-features-import-export_5
    Public Function ImportXaml(ByVal content As String) As RadDocument
        Dim provider As New XamlFormatProvider()
        Return provider.Import(content)
    End Function
    ' #endregion

    ' #region radrichtextbox-features-import-export_7
    Public Function ImportDocx() As RadDocument
        Dim document As RadDocument = Nothing
        Dim provider As IDocumentFormatProvider = New DocxFormatProvider()
        Dim openDialog As New OpenFileDialog()
        openDialog.Filter = "Documents|*.docx"
        openDialog.Multiselect = False
        Dim dialogResult As System.Nullable(Of Boolean) = openDialog.ShowDialog()
        If dialogResult = True Then
            Using stream As FileStream = openDialog.OpenFile()
                document = provider.Import(stream)
            End Using
        End If
        Return document
    End Function
    ' #endregion

    ' #region radrichtextbox-features-import-export_9
    Public Function ImportDocx() As RadDocument
        Dim document As RadDocument = Nothing
        Dim provider As IDocumentFormatProvider = New DocxFormatProvider()
        Dim openDialog As New OpenFileDialog()
        openDialog.Filter = "Documents|*.docx"
        openDialog.Multiselect = False
        Dim dialogResult As System.Nullable(Of Boolean) = openDialog.ShowDialog()
        If dialogResult = True Then
            Using stream As FileStream = openDialog.File.OpenRead()
                document = provider.Import(stream)
            End Using
        End If
        Return document
    End Function
    ' #endregion
End Class
