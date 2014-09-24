#region radpivotgrid-data-adomd_1
AdomdDataProvider adomdDataProvider = new AdomdDataProvider();

this.radPivotGrid.DataProvider = adomdDataProvider;
this.radPivotFieldList.DataProvider = adomdDataProvider;
#endregion

#region radpivotgrid-data-adomd_2
AdomdConnectionSettings connectionSettings = new AdomdConnectionSettings();
connectionSettings.Cube = "Adventure Works";
connectionSettings.Database = "Adventure Works DW 2008R2";
connectionSettings.ConnectionString = "Provider=MSOLAP.5;Data Source=ServerName;Initial Catalog=Adventure Works DW 2008R2;User Id=domain\user;Password=myPassword;";

AdomdDataProvider adomdDataProvider = new AdomdDataProvider();
adomdDataProvider.ConnectionSettings = connectionSettings;
#endregion

#region radpivotgrid-data-adomd_3
AdomdGroupDescription rowGroupDescription1 = new AdomdGroupDescription();
rowGroupDescription1.MemberName = "[Date].[Calendar Year]";
AdomdGroupDescription columnGropuDescription1 = new AdomdGroupDescription();
columnGropuDescription1.MemberName = "[Promotion].[Promotion Category]";
AdomdAggregateDescription aggregateDescription1 = new AdomdAggregateDescription();
aggregateDescription1.MemberName = "[Measures].[Internet Order Quantity]";

AdomdDataProvider adomdDataProvider = new AdomdDataProvider();
adomdDataProvider.BeginInit();
adomdDataProvider.RowGroupDescriptions.Add(rowGroupDescription1);
adomdDataProvider.ColumnGroupDescriptions.Add(columnGropuDescription1);
adomdDataProvider.AggregateDescriptions.Add(aggregateDescription1);
adomdDataProvider.EndInit();
#endregion

#region radpivotgrid-data-adomd_4
OlapSetCondition condition = new OlapSetCondition();
condition.Comparison = SetComparison.Includes;
condition.Items.Add("[Date].[Calendar Year].&[2005]");
AdomdFilterDescription filterDescription = new AdomdFilterDescription();
filterDescription.MemberName = "[Date].[Calendar Year]";
filterDescription.Condition = condition;
#endregion

#region radpivotgrid-data-adomd_5
AdomdFilterDescription topFilterDescription = new AdomdFilterDescription();
topFilterDescription.MemberName = "[Date].[Calendar]";

OlapSetCondition condition1 = new OlapSetCondition();
condition1.Comparison = SetComparison.Includes;
condition1.Items.Add("[Date].[Calendar].[Calendar Year].&[2007]");
AdomdLevelFilterDescription levelFilterDescription1 = new AdomdLevelFilterDescription();
levelFilterDescription1.MemberName = "[Date].[Calendar].[Calendar Year]";
levelFilterDescription1.Condition = condition1;

OlapSetCondition condition2 = new OlapSetCondition();
condition2.Comparison = SetComparison.Includes;
condition2.Items.Add("[Date].[Calendar].[Calendar Semester].&[2007]&[2]");
AdomdLevelFilterDescription levelFilterDescription2 = new AdomdLevelFilterDescription();
levelFilterDescription2.MemberName = "[Date].[Calendar].[Calendar Semester]";
levelFilterDescription2.Condition = condition2;
topFilterDescription.Levels.Add(levelFilterDescription1);
topFilterDescription.Levels.Add(levelFilterDescription2);
#endregion