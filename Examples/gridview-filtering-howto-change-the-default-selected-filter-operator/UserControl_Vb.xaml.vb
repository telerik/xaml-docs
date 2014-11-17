Public Class Default_Vb

' #region gridview-filtering-howto-change-the-default-selected-filter-operator_0
	Private Sub OnRadGridViewFilterOperatorsLoading(sender As Object, e As Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs)
		If e.Column.UniqueName = "HireDate" Then
			e.DefaultOperator1 = Telerik.Windows.Data.FilterOperator.IsGreaterThan
			e.DefaultOperator2 = Telerik.Windows.Data.FilterOperator.IsLessThan
		End If
	End Sub
' #endregion

End Class
