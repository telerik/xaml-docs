Public Class Default_Vb


' #region radrichtextbox-features-headers-and-footers_2
Dim section As New Section()
Dim paragraph As New Paragraph()
section.Blocks.Add(paragraph)
Me.radRichTextBox.Document.Sections.Add(section)
' #endregion
End Class
