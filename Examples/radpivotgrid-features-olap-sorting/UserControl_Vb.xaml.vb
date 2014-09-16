'#region radpivotgrid-features-olap-sort_1
Dim groupDescription As New XmlaGroupDescription()
groupDescription.MemberName = "[Product].[Category]"
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending
'#endregion

'#region radpivotgrid-features-olap-sort_2
Dim groupDescription As New AdomdGroupDescription()
groupDescription.MemberName = "[Product].[Category]"
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending
'#endregion

'#region radpivotgrid-features-olap-sort_3
Dim groupDescription As New XmlaGroupDescription()
groupDescription.MemberName = "[Product].[Category]"
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending
groupDescription.GroupComparer = New GrandTotalComparer() With {.AggregateIndex = 1}
'#endregion

'#region radpivotgrid-features-olap-sort_4
Dim groupDescription As New AdomdGroupDescription()
groupDescription.MemberName = "[Product].[Category]"
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending
groupDescription.GroupComparer = New GrandTotalComparer() With {.AggregateIndex = 1}
'#endregion

'#region radpivotgrid-features-olap-sort_5
Dim topGroupDescription As New XmlaGroupDescription()
topGroupDescription.MemberName = "[Date].[Calendar]"
Dim levelGroupDescription1 As New XmlaLevelGroupDescription()
levelGroupDescription1.MemberName = "[Date].[Calendar].[Calendar Year]"
levelGroupDescription1.SortOrder = Telerik.Pivot.Core.SortOrder.Descending
topGroupDescription.Levels.Add(levelGroupDescription1)
'#endregion

'#region radpivotgrid-features-olap-sort_6
Dim topGroupDescription As New AdomdGroupDescription()
topGroupDescription.MemberName = "[Date].[Calendar]"
Dim levelGroupDescription1 As New AdomdLevelGroupDescription()
levelGroupDescription1.MemberName = "[Date].[Calendar].[Calendar Year]"
levelGroupDescription1.SortOrder = Telerik.Pivot.Core.SortOrder.Descending
topGroupDescription.Levels.Add(levelGroupDescription1)
'#endregion

'#region radpivotgrid-features-olap-sort_7
Dim groupDescription As New XmlaGroupDescription()
groupDescription.MemberName = "[Product].[Category]"
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None
'#endregion

'#region radpivotgrid-features-olap-sort_8
Dim groupDescription As New AdomdGroupDescription()
groupDescription.MemberName = "[Product].[Category]"
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None
'#endregion

'#region radpivotgrid-features-olap-sort_9
Dim groupDescription As New XmlaGroupDescription()
groupDescription.MemberName = "[Product].[Category]"
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending
groupDescription.GroupComparer = New OlapGroupComparer()
'#endregion

'#region radpivotgrid-features-olap-sort_10
Dim groupDescription As New AdomdGroupDescription()
groupDescription.MemberName = "[Product].[Category]"
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending
groupDescription.GroupComparer = New OlapGroupComparer()
'#endregion