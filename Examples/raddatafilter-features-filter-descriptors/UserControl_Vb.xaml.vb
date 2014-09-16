Public Class Default_Vb


' #region raddatafilter-features-filter-descriptors_2
Me.radDataFilter.Source = SampleData.GetEmployees()
Me.radDataFilter.FilterDescriptors.Add(New FilterDescriptor("Name", FilterOperator.Contains, "m"))
' #endregion
End Class
