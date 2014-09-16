Public Class Default_Vb


' #region radrichtextbox-features-document-elements-inlineuicontainer_2
Dim _section As New Section()
Dim _paragraph As New Paragraph()
Dim container As New InlineUIContainer()
container.UiElement = New Button()
container.Height = 25
container.Width = 70
_paragraph.Inlines.Add(container)
_section.Blocks.Add(_paragraph)
Me.radRichTextBox.Document.Sections.Add(_section)
' #endregion

' #region radrichtextbox-features-document-elements-inlineuicontainer_4
Private Shared defaultSize As New Size(900, 400)
Private Sub InsertMedia(ByVal _size As Size)
 Dim ofd As New OpenFileDialog()
 If ofd.ShowDialog() = True Then
  Dim _stream As Stream = ofd.File.OpenRead()
  Dim media As New MediaElement()
  media.SetSource(_stream)
  media.AutoPlay = True
  Dim container As New InlineUIContainer() With {.UiElement = media}
  If _size <> Size.Empty Then
   container.Height = _size.Height
   container.Width = _size.Width
  End If
  Me.radRichTextBox1.InsertInline(container)
 End If
End Sub
Private Sub buttonInsertVideo_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
 InsertMedia(defaultSize)
End Sub
Private Sub buttonInsertAudio_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
 InsertMedia(Size.Empty)
End Sub
' #endregion
End Class
