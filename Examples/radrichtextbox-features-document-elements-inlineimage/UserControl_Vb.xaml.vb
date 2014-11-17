Public Class Default_Vb


' #region radrichtextbox-features-document-elements-inlineimage_2
Dim section As New Section()
Dim paragraph As New Paragraph()
Dim stream As Stream = Application.GetResourceStream(New Uri("/Silverlight.Help.RadRichTextBoxSamples;component/Demos/Images/RadRichTextBox.png", UriKind.RelativeOrAbsolute)).Stream
Dim size As New Size(236, 50)
Dim image As New ImageInline(stream, size, "png")
paragraph.Inlines.Add(image)
section.Children.Add(paragraph)
Me.radRichTextBox.Document.Sections.Add(section)
' #endregion

' #region radrichtextbox-features-document-elements-inlineimage_5
Private Sub ImageButton_Click(sender As Object, e As RoutedEventArgs)
 Dim openDialog As New OpenFileDialog()
 openDialog.Filter = "Images|*.jpg;*.png"
 openDialog.Multiselect = False
 Dim dialogResult As System.Nullable(Of Boolean) = openDialog.ShowDialog()
 If dialogResult = True Then
  Dim stream As Stream = openDialog.File.OpenRead()
  Dim extension As String = openDialog.File.Extension
  Me.radRichTextBox.InsertImage(stream, extension)
 End If
End Sub
' #endregion
End Class
