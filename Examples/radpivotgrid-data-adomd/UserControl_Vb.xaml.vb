'#region radpivotgrid-data-adomd_1
Dim adomdDataProvider As New AdomdDataProvider()

Me.radPivotGrid.DataProvider = adomdDataProvider
Me.radPivotFieldList.DataProvider = adomdDataProvider
'#endregion

'#region radpivotgrid-data-adomd_2
Dim connectionSettings As New AdomdConnectionSettings()
connectionSettings.Cube = "Adventure Works"
connectionSettings.Database = "Adventure Works DW 2008R2"
connectionSettings.ConnectionString = "Provider=MSOLAP.5;Data Source=ServerName;Initial Catalog=Adventure Works DW 2008R2;User Id=domain\user;Password=myPassword;"

Dim adomdDataProvider As New AdomdDataProvider()
adomdDataProvider.ConnectionSettings = connectionSettings
'#endregion

'#region radpivotgrid-data-adomd_3
Dim rowGroupDescription1 As New AdomdGroupDescription()
rowGroupDescription1.MemberName = "[Date].[Calendar Year]"
Dim columnGropuDescription1 As New AdomdGroupDescription()
columnGropuDescription1.MemberName = "[Promotion].[Promotion Category]"
Dim aggregateDescription1 As New AdomdAggregateDescription()
aggregateDescription1.MemberName = "[Measures].[Internet Order Quantity]"

Dim adomdDataProvider As New AdomdDataProvider()
adomdDataProvider.BeginInit()
adomdDataProvider.RowGroupDescriptions.Add(rowGroupDescription1)
adomdDataProvider.ColumnGroupDescriptions.Add(columnGropuDescription1)
adomdDataProvider.AggregateDescriptions.Add(aggregateDescription1)
adomdDataProvider.EndInit()
'#endregion

'#region radpivotgrid-data-adomd_4
Dim condition As New OlapSetCondition()
condition.Comparison = SetComparison.Includes
condition.Items.Add("[Date].[Calendar Year].&[2005]")
Dim filterDescription As New AdomdFilterDescription()
filterDescription.MemberName = "[Date].[Calendar Year]"
filterDescription.Condition = condition
'#endregion

'#region radpivotgrid-data-adomd_5
Dim topFilterDescription As New AdomdFilterDescription()
topFilterDescription.MemberName = "[Date].[Calendar]"

Dim condition1 As New OlapSetCondition()
condition1.Comparison = SetComparison.Includes
condition1.Items.Add("[Date].[Calendar].[Calendar Year].&[2007]")
Dim levelFilterDescription1 As New AdomdLevelFilterDescription()
levelFilterDescription1.MemberName = "[Date].[Calendar].[Calendar Year]"
levelFilterDescription1.Condition = condition1

Dim condition2 As New OlapSetCondition()
condition2.Comparison = SetComparison.Includes
condition2.Items.Add("[Date].[Calendar].[Calendar Semester].&[2007]&[2]")
Dim levelFilterDescription2 As New AdomdLevelFilterDescription()
levelFilterDescription2.MemberName = "[Date].[Calendar].[Calendar Semester]"
levelFilterDescription2.Condition = condition2
topFilterDescription.Levels.Add(levelFilterDescription1)
topFilterDescription.Levels.Add(levelFilterDescription2)
'#endregion