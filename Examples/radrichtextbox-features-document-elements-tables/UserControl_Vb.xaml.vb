Public Class Default_Vb


' #region radrichtextbox-features-document-elements-tables_3
    Dim document As New RadDocument()
    Dim section As New Section()
    section.Blocks.Add(New Paragraph())

    Dim table As New Table()
    table.StyleName = RadDocumentDefaultStyles.DefaultTableGridStyleName

    Dim row1 As New TableRow()

    Dim cell1 As New TableCell()
    Dim p1 As New Paragraph()
    Dim s1 As New Span()
    s1.Text = "Cell 1"
    p1.Inlines.Add(s1)
    cell1.Blocks.Add(p1)
    row1.Cells.Add(cell1)

    Dim cell2 As New TableCell()
    Dim p2 As New Paragraph()
    Dim s2 As New Span()
    s2.Text = "Cell 2"
    p2.Inlines.Add(s2)
    cell2.Blocks.Add(p2)
    row1.Cells.Add(cell2)
    table.Rows.Add(row1)

    Dim row2 As New TableRow()

    Dim cell3 As New TableCell()
    cell3.ColumnSpan = 2
    Dim p3 As New Paragraph()
    Dim s3 As New Span()
    s3.Text = "Cell 3"
    p3.Inlines.Add(s3)
    cell3.Blocks.Add(p3)
    row2.Cells.Add(cell3)
    table.Rows.Add(row2)

    section.Blocks.Add(table)
    section.Blocks.Add(New Paragraph())
    document.Sections.Add(section)

    Me.radRichTextBox.Document = document
' #endregion
End Class
