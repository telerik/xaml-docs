'#region radpivotgrid-features-sort_1
Dim propGroupDescription As New Telerik.Pivot.Core.PropertyGroupDescription()
propGroupDescription.PropertyName = "Name"
propGroupDescription.SortOrder = SortOrder.Descending

Dim doubleGroupDescription As New DoubleGroupDescription()
doubleGroupDescription.PropertyName = "Price"
doubleGroupDescription.SortOrder = SortOrder.Ascending

Dim dateTimeGroupDescription As New DateTimeGroupDescription()
dateTimeGroupDescription.PropertyName = "Date"
dateTimeGroupDescription.SortOrder = SortOrder.Descending
'#endregion

'#region radpivotgrid-features-sort_2
Dim propGroupDescription As New Telerik.Pivot.Core.PropertyGroupDescription()
propGroupDescription.PropertyName = "Name"
propGroupDescription.SortOrder = SortOrder.Descending
propGroupDescription.GroupComparer = New GrandTotalComparer() With {.AggregateIndex = 0}

Dim doubleGroupDescription As New DoubleGroupDescription()
doubleGroupDescription.PropertyName = "Price"
doubleGroupDescription.SortOrder = SortOrder.Ascending
doubleGroupDescription.GroupComparer = New GrandTotalComparer() With {.AggregateIndex = 1}

Dim dateTimeGroupDescription As New DateTimeGroupDescription()
dateTimeGroupDescription.PropertyName = "Date"
dateTimeGroupDescription.SortOrder = SortOrder.Descending
dateTimeGroupDescription.GroupComparer = New GrandTotalComparer() With {.AggregateIndex = 0}
'#endregion

'#region radpivotgrid-features-sort_3
'XmlaDataProvider:
Dim topGroupDescription As New XmlaGroupDescription()
topGroupDescription.MemberName = "[Date].[Calendar]"
Dim levelGroupDescription1 As New XmlaLevelGroupDescription()
levelGroupDescription1.MemberName = "[Date].[Calendar].[Calendar Year]"
levelGroupDescription1.SortOrder = Telerik.Pivot.Core.SortOrder.Descending
topGroupDescription.Levels.Add(levelGroupDescription1)

'AdomdDataProvider
Dim topGroupDescription As New AdomdGroupDescription()
topGroupDescription.MemberName = "[Date].[Calendar]"
Dim levelGroupDescription1 As New AdomdLevelGroupDescription()
levelGroupDescription1.MemberName = "[Date].[Calendar].[Calendar Year]"
levelGroupDescription1.SortOrder = Telerik.Pivot.Core.SortOrder.Descending
topGroupDescription.Levels.Add(levelGroupDescription1)
'#endregion

'#region radpivotgrid-features-sort_4
Dim propGroupDescription As New Telerik.Pivot.Core.PropertyGroupDescription()
propGroupDescription.PropertyName = "Name"
propGroupDescription.SortOrder = SortOrder.None

Dim doubleGroupDescription As New DoubleGroupDescription()
doubleGroupDescription.PropertyName = "Price"
doubleGroupDescription.SortOrder = SortOrder.None

Dim dateTimeGroupDescription As New DateTimeGroupDescription()
dateTimeGroupDescription.PropertyName = "Date"
dateTimeGroupDescription.SortOrder = SortOrder.None
'#endregion