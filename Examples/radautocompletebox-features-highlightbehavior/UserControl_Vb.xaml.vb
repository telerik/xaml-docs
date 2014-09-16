Public Class Default_Vb


' #region radautocompletebox-features-highlightbehavior-0
Public Class MyHighlightBehavior
	Inherits HighlightBehavior

End Class
' #endregion

' #region radautocompletebox-features-highlightbehavior-1
Public Overrides Function FindHighlightedIndex(ByVal searchText As String, ByVal filteredItems As System.Collections.IList, ByVal escapedItems As IEnumerable(Of Object), ByVal textSearchPath As String, ByVal textSearchMode As TextSearchMode) As Integer
	Dim items = filteredItems.OfType(Of Item)().ToList()

	If items IsNot Nothing Then
		If items.Any(Function(x) x.Name = searchText) Then
			' there is an exact match
			Dim matchedItem = items.First(Function(x) x.Name = searchText)
			' return the index of the matched item
			Return items.IndexOf(matchedItem)
		End If
	End If

	' there isn't exact match
	' return the index of the last item from the filtered items 
	Return items.Count - 1
End Function
' #endregion
End Class
