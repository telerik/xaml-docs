Public Class Default_Vb


    ' #region radrichtextbox-features-read-only-ranges_0
        Me.radRichTextBox.InsertReadOnlyRange()
    ' #endregion

    ' #region radrichtextbox-features-read-only-ranges_1
    Dim document As New RadDocument()
    Dim section As New Section()
    Dim paragraph As New Paragraph()
    Dim span As New Span("Content prior range[")
    Dim span2 As New Span("]Content after range")
    Dim readOnlyContent As New Span("READ ONLY")

    Dim rangeStart As New ReadOnlyRangeStart()
    Dim rangeEnd As New ReadOnlyRangeEnd()
    rangeEnd.PairWithStart(rangeStart)

    paragraph.Inlines.Add(span)
    paragraph.Inlines.Add(rangeStart)
    paragraph.Inlines.Add(readOnlyContent)
    paragraph.Inlines.Add(rangeEnd)
    paragraph.Inlines.Add(span2)

    section.Blocks.Add(paragraph)
    document.Sections.Add(section)
    ' #endregion

    ' #region radrichtextbox-features-read-only-ranges_2
    Me.radRichTextBox.DeleteReadOnlyRange()
    ' #endregion

    ' #region radrichtextbox-features-read-only-ranges_3
    Dim start As ReadOnlyRangeStart = Me.radRichTextBox.Document.EnumerateChildrenOfType(Of ReadOnlyRangeStart)().Where(Function(x) x.Tag = "ReadOnly").FirstOrDefault()
    If start IsNot Nothing Then
	    Me.radRichTextBox.DeleteReadOnlyRange(start)
    End If
    ' #endregion
End Class
