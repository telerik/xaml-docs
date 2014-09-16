Public Class Default_Vb

' #region gridview-filtering-howto-remove-some-of-the-available-filter-operators_0
	Private Sub OnRadGridViewFilterOperatorsLoading(sender As Object, e As Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs)
		If e.Column.UniqueName = "HireDate" Then
			e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsEqualTo)
			e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNotEqualTo)

			e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsGreaterThanOrEqualTo)
			e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsLessThanOrEqualTo)

			e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNull)
			e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNotNull)

			e.DefaultOperator1 = Telerik.Windows.Data.FilterOperator.IsGreaterThan
			e.DefaultOperator2 = Telerik.Windows.Data.FilterOperator.IsLessThan
		End If
	End Sub
' #endregion

End Class
