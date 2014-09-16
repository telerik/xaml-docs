Public Class Default_Vb


' #region gridview-export-events_2
AddHandler RadGridView1.ElementExporting, AddressOf RadGridView1_ElementExporting
AddHandler RadGridView1.ElementExported, AddressOf RadGridView1_ElementExported
' #endregion

' #region gridview-export-events_4
Private Sub RadGridView1_ElementExporting(ByVal sender As Object, ByVal e As GridViewElementExportingEventArgs)
    'Change the font size and the background color of the table header only
    If e.Element = ExportElement.HeaderRow OrElse e.Element = ExportElement.HeaderCell Then
        e.FontSize = e.FontSize + 4
        e.Background = Colors.DarkGray
    'Change the font size and the background color of the group headers only
    ElseIf e.Element = ExportElement.GroupHeaderCell OrElse e.Element = ExportElement.GroupHeaderRow Then
        e.FontSize = e.FontSize + 2
        e.Background = Colors.LightGray
    End If
End Sub
' #endregion

' #region gridview-export-events_6
Private Sub RadGridView1_ElementExported(sender As Object, e As GridViewElementExportedEventArgs)
 If e.Element = ExportElement.Row Then
  Dim obj As Employees = TryCast(e.Context, Employees)
  If obj IsNot Nothing Then
   e.Writer.Write([String].Format("<tr><td style=""background-color:#CCC;"" colspan=""{0}"">", DirectCast(RadGridView1.Columns, IEnumerable(Of Telerik.Windows.Controls.GridViewColumn)).Count()))
   e.Writer.Write([String].Format("<b>Birth date:</b> {0} <br />", obj.BirthDate))
   e.Writer.Write([String].Format("<b>Hire date:</b> {0} <br />", obj.HireDate))
   e.Writer.Write([String].Format("<b>Address:</b> {0} <br />", obj.Address))
   e.Writer.Write([String].Format("<b>City:</b> {0} <br />", obj.City))
   e.Writer.Write([String].Format("<b>Notes:</b> {0} <br />", obj.Notes))
   e.Writer.Write("</td></tr>")
  End If
 End If
End Sub
' #endregion
End Class
