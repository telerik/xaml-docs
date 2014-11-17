Public Class Default_Vb


' #region gridview-setting-filters-programmatically_1
Public Class CustomFD
Inherits FilterDescription
Private filterValue As String
Private rowHeader As String
Public Sub New(ByVal filter As String, ByVal rowHeader As String) 
    Me.filterValue = filter
    Me.rowHeaderToFilter = rowHeader
End Sub
Public Overloads Overrides Function SatisfiesFilter(ByVal dataItem As Object) As Boolean
    Dim row As DataRow = DirectCast(dataItem, DataRow)
    If row(rowHeaderToFilter) = filterValue Then
      Return True
    End If
    Return False
End Function
End Class
' #endregion

' #region gridview-setting-filters-programmatically_3
CompositeFilterDescriptor compositeFD = New CompositeFilterDescriptor()
compositeFD.FilterDescriptors.Add(New CustomFD("Bulgaria", "Country"))
compositeFD.FilterDescriptors.Add(New CustomFD("Sofia", "City"))
filteringRadGridView.FilterDescriptors.Add(compositeFD)
' #endregion
End Class
