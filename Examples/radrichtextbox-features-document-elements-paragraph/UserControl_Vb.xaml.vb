Public Class Default_Vb


' #region radrichtextbox-features-document-elements-paragraph_2
Dim section As New Section()
Dim paragraph As New Paragraph()
section.Blocks.Add(paragraph)
Dim document As New RadDocument()
document.Sections.Add(section)

Me.radRichTextBox.Document = document
' #endregion

' #region radrichtextbox-features-document-elements-paragraph_5
Dim section As New Section()
Dim paragraph As New Paragraph()
Dim span As New Span("Span declared in code-behind")
paragraph.Inlines.Add(span)
section.Blocks.Add(paragraph)
Dim document As New RadDocument()
document.Sections.Add(section)

Me.radRichTextBox.Document = document
' #endregion
End Class
