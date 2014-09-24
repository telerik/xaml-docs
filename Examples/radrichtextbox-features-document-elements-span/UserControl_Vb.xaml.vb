Public Class Default_Vb


' #region radrichtextbox-features-document-elements-span_2
Dim section As New Section()
Dim paragraph As New Paragraph()
Dim span As New Span("Span declared in code-behind")
paragraph.Inlines.Add(span)
section.Blocks.Add(paragraph)
Me.radRichTextBox.Document.Sections.Add(section)
' #endregion

' #region radrichtextbox-features-document-elements-span_5
Dim span As New Span()
span.Text = "Thank you for choosing Telerik RadRichTextBox!"
' #endregion
End Class
