Public Class Default_Vb


	' #region gridview-filtering-programmatic_0
	Dim countryColumn As Telerik.Windows.Controls.GridViewColumn = Me.radGridView.Columns("Country")
	Dim countryFilter As Telerik.Windows.Controls.GridView.IColumnFilterDescriptor = countryColumn.ColumnFilterDescriptor

	' Suspend the notifications to avoid multiple data engine updates
	countryFilter.SuspendNotifications()

	' This is the same as the end user selecting a distinct value through the UI.
	countryFilter.DistinctFilter.AddDistinctValue("Poland")
	countryFilter.DistinctFilter.AddDistinctValue("Spain")
	countryFilter.DistinctFilter.AddDistinctValue("Uzbekistan")
	countryFilter.DistinctFilter.AddDistinctValue("Netherlands")
	countryFilter.DistinctFilter.AddDistinctValue("Austria")
	countryFilter.DistinctFilter.AddDistinctValue("Finland")
	countryFilter.DistinctFilter.AddDistinctValue("Pakistan")

	' This is the same as the end user configuring the upper field filter.
	countryFilter.FieldFilter.Filter1.[Operator] = Telerik.Windows.Data.FilterOperator.Contains
	countryFilter.FieldFilter.Filter1.Value = "land"
	countryFilter.FieldFilter.Filter1.IsCaseSensitive = True

	' This is the same as the end user changing the logical operator between the two field filters.
	countryFilter.FieldFilter.LogicalOperator = Telerik.Windows.Data.FilterCompositionLogicalOperator.[Or]

	' This is the same as the end user configuring the lower field filter.
	countryFilter.FieldFilter.Filter2.[Operator] = Telerik.Windows.Data.FilterOperator.Contains
	countryFilter.FieldFilter.Filter2.Value = "stan"
	countryFilter.FieldFilter.Filter2.IsCaseSensitive = True

	' Resume the notifications to force the data engine to update the filter.
	countryFilter.ResumeNotifications()
	' #endregion

	' #region gridview-filtering-programmatic_1
	Me.radGridView.FilterDescriptors.SuspendNotifications()
	' ... filter as many columns as you wish here...
	Me.radGridView.FilterDescriptors.ResumeNotifications()
	' #endregion

	' #region gridview-filtering-programmatic_2
	Me.radGridView.FilterDescriptors.SuspendNotifications()
	For Each column As Telerik.Windows.Controls.GridViewColumn In Me.radGridView.Columns
		column.ClearFilters()
	Next
	Me.radGridView.FilterDescriptors.ResumeNotifications()
	' #endregion

	' #region gridview-filtering-programmatic_3
	' Give me all people that are named John.
	Dim fd As New Telerik.Windows.Data.FilterDescriptor()
	fd.Member = "FirstName"
	fd.[Operator] = Telerik.Windows.Data.FilterOperator.IsEqualTo
	fd.Value = "John"
	fd.IsCaseSensitive = True
	' In most cases the data engine will discover this automatically so you do not need to set it.
	fd.MemberType = GetType(String)
	' #endregion

	' #region gridview-filtering-programmatic_4
	' Give me all people that are named John.
	Dim olderThan18Filter As New Telerik.Windows.Data.FilterDescriptor("Age", Telerik.Windows.Data.FilterOperator.IsGreaterThanOrEqualTo, 18)
	Dim youngerThan60Filter As New Telerik.Windows.Data.FilterDescriptor("Age", Telerik.Windows.Data.FilterOperator.IsLessThan, 60)

	Dim ageFilter As New Telerik.Windows.Data.CompositeFilterDescriptor()
	ageFilter.FilterDescriptors.Add(olderThan18Filter)
	ageFilter.FilterDescriptors.Add(youngerThan60Filter)
	ageFilter.LogicalOperator = Telerik.Windows.Data.FilterCompositionLogicalOperator.[And]

	Dim liveInSpainFilter As New Telerik.Windows.Data.FilterDescriptor("Country", Telerik.Windows.Data.FilterOperator.IsEqualTo, "Spain")

	Dim mainFilter As New Telerik.Windows.Data.CompositeFilterDescriptor()
	mainFilter.FilterDescriptors.Add(ageFilter)
	mainFilter.FilterDescriptors.Add(liveInSpainFilter)
	mainFilter.LogicalOperator = Telerik.Windows.Data.FilterCompositionLogicalOperator.[And]

	Me.radGridView.FilterDescriptors.Add(mainFilter)
	' #endregion
End Class

