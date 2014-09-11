'#region radpivotgrid-features-queryable-group-filter_1
Dim shipCountryGroupDescription = New QueryableDoubleGroupDescription()
shipCountryGroupDescription.PropertyName = "ShipCountry"
Dim labelGroupFilter = New LabelGroupFilter()
Dim textCondition = New TextCondition()
textCondition.Comparison = TextComparison.Contains
textCondition.Pattern = "C"
labelGroupFilter.Condition = textCondition
shipCountryGroupDescription.GroupFilter = labelGroupFilter
'#endregion

'#region radpivotgrid-features-queryable-group-filter_2
Dim shipCountryGroupDescription = New QueryablePropertyGroupDescription()
shipCountryGroupDescription.PropertyName = "ShipCountry"
Dim intervalCondition = New IntervalCondition()
intervalCondition.Condition = IntervalComparison.IsBetween
intervalCondition.From = 50
intervalCondition.To = 70

Dim valueGroupFilter = New ValueGroupFilter()
valueGroupFilter.AggregateIndex = 0
valueGroupFilter.Condition = intervalCondition
shipCountryGroupDescription.GroupFilter = valueGroupFilter
'#endregion

'#region radpivotgrid-features-queryable-group-filter_3
Dim shipCountryGroupDescription = New QueryablePropertyGroupDescription()
shipCountryGroupDescription.PropertyName = "ShipCountry"
Dim countFilter = New GroupsCountFilter()
countFilter.AggregateIndex = 0
countFilter.Count = 4
countFilter.Selection = SortedListSelection.Top
shipCountryGroupDescription.GroupFilter = countFilter
'#endregion

'#region radpivotgrid-features-queryable-group-filter_4
Dim shipCountryGroupDescription = New QueryablePropertyGroupDescription()
shipCountryGroupDescription.PropertyName = "ShipCountry"

Dim textCondition = New TextCondition()
textCondition.Comparison = TextComparison.Contains
textCondition.Pattern = "n"

Dim distinctCondition = New SetCondition()
distinctCondition.Comparison = SetComparison.Includes
distinctCondition.Items.Add("Brazil")
distinctCondition.Items.Add("Canada")
distinctCondition.Items.Add("Denmark")

Dim itemsFilterCondition = New ItemsFilterCondition()
itemsFilterCondition.Condition = textCondition
itemsFilterCondition.DistinctCondition = distinctCondition

Dim labelGroupFilter = New LabelGroupFilter()
labelGroupFilter.Condition = itemsFilterCondition
shipCountryGroupDescription.GroupFilter = labelGroupFilter
'#endregion