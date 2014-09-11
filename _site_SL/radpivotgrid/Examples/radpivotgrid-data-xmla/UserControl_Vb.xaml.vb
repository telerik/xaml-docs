' #region radpivotgrid-data-xmla_1
Dim xmlaDataProvider As New XmlaDataProvider()
Me.radPivotGrid.DataProvider = xmlaDataProvider
Me.radPivotFieldList.DataProvider = xmlaDataProvider
' #endregion

'#region radpivotgrid-data-xmla_2
Dim cubeConnectionDetails As New XmlaConnectionSettings()
cubeConnectionDetails.Cube = "Adventure Works"
cubeConnectionDetails.Database = "Adventure Works DW 2008R2"
cubeConnectionDetails.ServerAddress = "http://demos.telerik.com/olap/msmdpump.dll"

Dim xmlaDataProvider As New XmlaDataProvider()
xmlaDataProvider.ConnectionSettings = cubeConnectionDetails
'#endregion

'#region radpivotgrid-data-xmla_3
Dim rowGroupDescription1 As New XmlaGroupDescription()
rowGroupDescription1.MemberName = "[Date].[Calendar Year]"

Dim columnGroupDescription1 As New XmlaGroupDescription()
columnGroupDescription1.MemberName = "[Promotion].[Promotion Category]"

Dim aggregateDescription1 As New XmlaAggregateDescription()
aggregateDescription1.MemberName = "[Measures].[Internet Order Quantity]"

Dim xmlaDataProvider As New XmlaDataProvider()
xmlaDataProvider.BeginInit()
xmlaDataProvider.RowGroupDescriptions.Add(rowGroupDescription1)
xmlaDataProvider.ColumnGroupDescriptions.Add(columnGroupDescription1)
xmlaDataProvider.AggregateDescriptions.Add(aggregateDescription1)
xmlaDataProvider.EndInit()
'#endregion

'#region radpivotgrid-data-xmla_4
Dim filterDescription As New XmlaFilterDescription()
filterDescription.MemberName = "[Date].[Calendar Year]"
Dim condition As New OlapSetCondition()
condition.Comparison = SetComparison.Includes
condition.Items.Add("[Date].[Calendar Year].&[2005]")
filterDescription.Condition = condition
'#endregion

'#region radpivotgrid-data-xmla_5
Dim topFilterDescription As New XmlaFilterDescription()
topFilterDescription.MemberName = "[Date].[Calendar]"

Dim condition1 As New OlapSetCondition()
condition1.Comparison = SetComparison.Includes
condition1.Items.Add("[Date].[Calendar].[Calendar Year].&[2007]")
Dim levelFilterDescription1 As New XmlaLevelFilterDescription()
levelFilterDescription1.MemberName = "[Date].[Calendar].[Calendar Year]"
levelFilterDescription1.Condition = condition1

Dim condition2 As New OlapSetCondition()
condition2.Comparison = SetComparison.Includes
condition2.Items.Add("[Date].[Calendar].[Calendar Semester].&[2007]&[2]")
Dim levelFilterDescription2 As New XmlaLevelFilterDescription()
levelFilterDescription2.MemberName = "[Date].[Calendar].[Calendar Semester]"
levelFilterDescription2.Condition = condition2

topFilterDescription.Levels.Add(levelFilterDescription1)
topFilterDescription.Levels.Add(levelFilterDescription2)
'#endregion

'#region radpivotgrid-data-xmla_6
Dim cubeConnectionDetails As New XmlaConnectionSettings()
cubeConnectionDetails.Cube = "LocalizedCube"
cubeConnectionDetails.Database = "OrdersCube"
cubeConnectionDetails.ServerAddress = "http://localhost/olap/msmdpump.dll"

Dim localization As New XmlaQueryProperty()
localization.Name = "LocaleIdentifier"
localization.Value = "1036"

cubeConnectionDetails.QueryProperties.Add(localization)
'#endregion