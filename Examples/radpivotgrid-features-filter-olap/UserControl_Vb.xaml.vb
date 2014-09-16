'#region radpivotgrid-features-filter-olap_1
Dim groupDescription1 As New XmlaGroupDescription()
groupDescription1.MemberName = "[Promotion].[Promotion Category]"
Dim labelGroupFilter1 As New OlapLabelGroupFilter()
labelGroupFilter1.Condition = New OlapTextCondition() With {.Comparison = TextComparison.Contains, .Pattern = "C"}
groupDescription1.GroupFilter = labelGroupFilter1

Dim groupDescription2 As New XmlaGroupDescription()
groupDescription2.MemberName = "[Product].[Category]"
Dim labelGroupFilter2 As New OlapLabelGroupFilter()
labelGroupFilter2.Condition = New OlapComparisonCondition() With {.Condition = Comparison.Equals, .Than = "[Product].[Category].&[3]"}
groupDescription2.GroupFilter = labelGroupFilter2
'#endregion

'#region radpivotgrid-features-filter-olap_2
Dim groupDescription1 As New AdomdGroupDescription()
groupDescription1.MemberName = "[Promotion].[Promotion Category]"
Dim labelGroupFilter1 As New OlapLabelGroupFilter()
labelGroupFilter1.Condition = New OlapTextCondition() With {.Comparison = TextComparison.Contains, .Pattern = "C"}
groupDescription1.GroupFilter = labelGroupFilter1

Dim groupDescription2 As New AdomdGroupDescription()
groupDescription2.MemberName = "[Product].[Category]"
Dim labelGroupFilter2 As New OlapLabelGroupFilter()
labelGroupFilter2.Condition = New OlapComparisonCondition() With {.Condition = Comparison.Equals, .Than = "[Product].[Category].&[3]"}
groupDescription2.GroupFilter = labelGroupFilter2
'#endregion

'#region radpivotgrid-features-filter-olap_3
groupDescription1.MemberName = "[Promotion].[Promotion Category]"
Dim valueGroupFilter1 As New OlapValueGroupFilter()
valueGroupFilter1.AggregateIndex = 1
valueGroupFilter1.Condition = New OlapIntervalCondition() With {.Condition = IntervalComparison.IsBetween, .From = 1000, .To = 5000}
groupDescription1.GroupFilter = valueGroupFilter1

Dim groupDescription2 As New XmlaGroupDescription()
groupDescription2.MemberName = "[Product].[Category]"
Dim valueGroupFilter2 As New OlapValueGroupFilter()
valueGroupFilter2.AggregateIndex = 0
valueGroupFilter2.Condition = New OlapComparisonCondition() With {.Condition = Comparison.IsGreaterThan, .Than = 50000}
groupDescription2.GroupFilter = valueGroupFilter2
'#endregion

'#region radpivotgrid-features-filter-olap_4
Dim groupDescription1 As New AdomdGroupDescription()
groupDescription1.MemberName = "[Promotion].[Promotion Category]"
Dim valueGroupFilter1 As New OlapValueGroupFilter()
valueGroupFilter1.AggregateIndex = 1
valueGroupFilter1.Condition = New OlapIntervalCondition() With {.Condition = IntervalComparison.IsBetween, .From = 1000, .To = 5000}
groupDescription1.GroupFilter = valueGroupFilter1

Dim groupDescription2 As New AdomdGroupDescription()
groupDescription2.MemberName = "[Product].[Category]"
Dim valueGroupFilter2 As New OlapValueGroupFilter()
valueGroupFilter2.AggregateIndex = 0
valueGroupFilter2.Condition = New OlapComparisonCondition() With {.Condition = Comparison.IsGreaterThan, .Than = 50000}
groupDescription2.GroupFilter = valueGroupFilter2
'#endregion

'#region radpivotgrid-features-filter-olap_5
Dim groupDescription As New XmlaGroupDescription()
groupDescription.MemberName = "[Promotion].[Promotions]"

Dim levelGroupDescription1 As New XmlaLevelGroupDescription()
levelGroupDescription1.MemberName = "[Promotion].[Promotions].[Category]"
Dim labelGroupFilter1 As New OlapLabelGroupFilter()
labelGroupFilter1.Condition = New OlapTextCondition() With {.Comparison = TextComparison.Contains, .Pattern = "E"}
levelGroupDescription1.GroupFilter = labelGroupFilter1
groupDescription.Levels.Add(levelGroupDescription1)

Dim levelGroupDescription2 As New XmlaLevelGroupDescription()
levelGroupDescription2.MemberName = "[Promotion].[Promotions].[Type]"
Dim labelGroupFilter2 As New OlapLabelGroupFilter()
labelGroupFilter2.Condition = New OlapComparisonCondition() With {.Condition = Comparison.Equals, .Than = "[Promotion].[Promotions].[Category].&[Reseller].&[Excess Inventory]"}
levelGroupDescription2.GroupFilter = labelGroupFilter2
groupDescription.Levels.Add(levelGroupDescription2)
'#endregion

'#region radpivotgrid-features-filter-olap_6
Dim groupDescription As New AdomdGroupDescription()
groupDescription.MemberName = "[Promotion].[Promotions]"

Dim levelGroupDescription1 As New AdomdLevelGroupDescription()
levelGroupDescription1.MemberName = "[Promotion].[Promotions].[Category]"
Dim labelGroupFilter1 As New OlapLabelGroupFilter()
labelGroupFilter1.Condition = New OlapTextCondition() With {.Comparison = TextComparison.Contains, .Pattern = "E"}
levelGroupDescription1.GroupFilter = labelGroupFilter1
groupDescription.Levels.Add(levelGroupDescription1)

Dim levelGroupDescription2 As New AdomdLevelGroupDescription()
levelGroupDescription2.MemberName = "[Promotion].[Promotions].[Type]"
Dim labelGroupFilter2 As New OlapLabelGroupFilter()
labelGroupFilter2.Condition = New OlapComparisonCondition() With {.Condition = Comparison.Equals, .Than = "[Promotion].[Promotions].[Category].&[Reseller].&[Excess Inventory]"}
levelGroupDescription2.GroupFilter = labelGroupFilter2
groupDescription.Levels.Add(levelGroupDescription2)
'#endregion

'#region radpivotgrid-features-filter-olap_7
Dim groupDescription As New XmlaGroupDescription()
groupDescription.MemberName = "[Promotion].[Promotions]"

Dim levelGroupDescription1 As New XmlaLevelGroupDescription()
levelGroupDescription1.MemberName = "[Promotion].[Promotions].[Category]"
Dim valueGroupFilter1 As New OlapValueGroupFilter()
valueGroupFilter1.AggregateIndex = 1
valueGroupFilter1.Condition = New OlapIntervalCondition() With {.Condition = IntervalComparison.IsBetween, .From = 900, .To = 1000}
levelGroupDescription1.GroupFilter = valueGroupFilter1
groupDescription.Levels.Add(levelGroupDescription1)

Dim levelGroupDescription2 As New XmlaLevelGroupDescription()
levelGroupDescription2.MemberName = "[Promotion].[Promotions].[Type]"
Dim valueGroupFilter2 As New OlapValueGroupFilter()
valueGroupFilter2.AggregateIndex = 0
valueGroupFilter2.Condition = New OlapComparisonCondition() With {.Condition = Comparison.IsGreaterThan, .Than = 300}
levelGroupDescription2.GroupFilter = valueGroupFilter2
groupDescription.Levels.Add(levelGroupDescription2)
'#endregion

'#region radpivotgrid-features-filter-olap_8
Dim groupDescription As New AdomdGroupDescription()
groupDescription.MemberName = "[Promotion].[Promotions]"

Dim levelGroupDescription1 As New AdomdLevelGroupDescription()
levelGroupDescription1.MemberName = "[Promotion].[Promotions].[Category]"
Dim valueGroupFilter1 As New OlapValueGroupFilter()
valueGroupFilter1.AggregateIndex = 1
valueGroupFilter1.Condition = New OlapIntervalCondition() With {.Condition = IntervalComparison.IsBetween, .From = 900, .To = 1000}
levelGroupDescription1.GroupFilter = valueGroupFilter1
groupDescription.Levels.Add(levelGroupDescription1)

Dim levelGroupDescription2 As New AdomdLevelGroupDescription()
levelGroupDescription2.MemberName = "[Promotion].[Promotions].[Type]"
Dim valueGroupFilter2 As New OlapValueGroupFilter()
valueGroupFilter2.AggregateIndex = 0
valueGroupFilter2.Condition = New OlapComparisonCondition() With {.Condition = Comparison.IsGreaterThan, .Than = 300}
levelGroupDescription2.GroupFilter = valueGroupFilter2
groupDescription.Levels.Add(levelGroupDescription2)
'#endregion