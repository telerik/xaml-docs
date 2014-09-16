'#region radpivotgrid-features-filter_1
Dim dateTimeGroupDescription As New DateTimeGroupDescription()
dateTimeGroupDescription.PropertyName = "Date"
dateTimeGroupDescription.Step = DateTimeStep.Month
Dim labelFilter As New LabelGroupFilter()
Dim textCondition As New TextCondition()
textCondition.Pattern = "Pe"
textCondition.Comparison = TextComparison.BeginsWith
labelFilter.Condition = textCondition
dateTimeGroupDescription.GroupFilter = labelFilter
'#endregion

'#region radpivotgrid-features-filter_2
Dim dateTimeGroupDescription As New DateTimeGroupDescription()
dateTimeGroupDescription.PropertyName = "Date"
dateTimeGroupDescription.Step = DateTimeStep.Month
Dim intervalCondition As New IntervalCondition()
intervalCondition.Condition = IntervalComparison.IsBetween
intervalCondition.From = "13"
intervalCondition.To = "15"
Dim valueGroupFilter As New ValueGroupFilter()
valueGroupFilter.Condition = intervalCondition
valueGroupFilter.AggregateIndex = 0
dateTimeGroupDescription.GroupFilter = valueGroupFilter
'#endregion

'#region radpivotgrid-features-filter_3
Dim dateTimeGroupDescription As New DateTimeGroupDescription()
dateTimeGroupDescription.PropertyName = "Date"
dateTimeGroupDescription.Step = DateTimeStep.Month
Dim countFilter As New GroupsCountFilter()
countFilter.Count = 4
countFilter.Selection = SortedListSelection.Top
countFilter.AggregateIndex = 0
dateTimeGroupDescription.GroupFilter = countFilter
'#endregion

'#region radpivotgrid-features-filter_4
Dim propertyGroupDescription As New Telerik.Pivot.Core.PropertyGroupDescription()
propertyGroupDescription.PropertyName = "Name"

Dim labelFilter = New LabelGroupFilter()
Dim textCondition = New TextCondition()
textCondition.Pattern = "c"
textCondition.Comparison = TextComparison.Contains

Dim setCondition = New SetCondition()
setCondition.Comparison = SetComparison.Includes
setCondition.Items.Add("Pen")
setCondition.Items.Add("Pencil")

Dim itemsFilterCondition = New ItemsFilterCondition()
itemsFilterCondition.Condition = textCondition
itemsFilterCondition.DistinctCondition = setCondition

labelFilter.Condition = itemsFilterCondition
propertyGroupDescription.GroupFilter = labelFilter
'#endregion