#region radpivotgrid-data-xmla_1
XmlaDataProvider xmlaDataProvider = new XmlaDataProvider();
this.radPivotGrid.DataProvider = xmlaDataProvider;
this.radPivotFieldList.DataProvider = xmlaDataProvider;
#endregion

#region radpivotgrid-data-xmla_2
XmlaConnectionSettings cubeConnectionDetails = new XmlaConnectionSettings();
cubeConnectionDetails.Cube = "Adventure Works";
cubeConnectionDetails.Database = "Adventure Works DW 2008R2";
cubeConnectionDetails.ServerAddress = "http://demos.telerik.com/olap/msmdpump.dll";

XmlaDataProvider xmlaDataProvider = new XmlaDataProvider();
xmlaDataProvider.ConnectionSettings = cubeConnectionDetails;
#endregion

#region radpivotgrid-data-xmla_3
XmlaGroupDescription rowGroupDescription1 = new XmlaGroupDescription();
rowGroupDescription1.MemberName = "[Date].[Calendar Year]";

XmlaGroupDescription columnGroupDescription1 = new XmlaGroupDescription();
columnGroupDescription1.MemberName = "[Promotion].[Promotion Category]";

XmlaAggregateDescription aggregateDescription1 = new XmlaAggregateDescription();
aggregateDescription1.MemberName = "[Measures].[Internet Order Quantity]";

XmlaDataProvider xmlaDataProvider = new XmlaDataProvider();
xmlaDataProvider.BeginInit();
xmlaDataProvider.RowGroupDescriptions.Add(rowGroupDescription1);
xmlaDataProvider.ColumnGroupDescriptions.Add(columnGroupDescription1);
xmlaDataProvider.AggregateDescriptions.Add(aggregateDescription1);
xmlaDataProvider.EndInit();
#endregion

#region radpivotgrid-data-xmla_4
XmlaFilterDescription filterDescription = new XmlaFilterDescription();
filterDescription.MemberName = "[Date].[Calendar Year]";
OlapSetCondition condition = new OlapSetCondition();
condition.Comparison = SetComparison.Includes;
condition.Items.Add("[Date].[Calendar Year].&[2005]");
filterDescription.Condition = condition;
#endregion

#region radpivotgrid-data-xmla_5
XmlaFilterDescription topFilterDescription = new XmlaFilterDescription();
topFilterDescription.MemberName = "[Date].[Calendar]";

OlapSetCondition condition1 = new OlapSetCondition();
condition1.Comparison = SetComparison.Includes;
condition1.Items.Add("[Date].[Calendar].[Calendar Year].&[2007]");
XmlaLevelFilterDescription levelFilterDescription1 = new XmlaLevelFilterDescription();
levelFilterDescription1.MemberName = "[Date].[Calendar].[Calendar Year]";
levelFilterDescription1.Condition = condition1;

OlapSetCondition condition2 = new OlapSetCondition();
condition2.Comparison = SetComparison.Includes;
condition2.Items.Add("[Date].[Calendar].[Calendar Semester].&[2007]&[2]");
XmlaLevelFilterDescription levelFilterDescription2 = new XmlaLevelFilterDescription();
levelFilterDescription2.MemberName = "[Date].[Calendar].[Calendar Semester]";
levelFilterDescription2.Condition = condition2;

topFilterDescription.Levels.Add(levelFilterDescription1);
topFilterDescription.Levels.Add(levelFilterDescription2);
#endregion

#region radpivotgrid-data-xmla_6
XmlaConnectionSettings cubeConnectionDetails = new XmlaConnectionSettings();
cubeConnectionDetails.Cube = "LocalizedCube";
cubeConnectionDetails.Database = "OrdersCube";
cubeConnectionDetails.ServerAddress = "http://localhost/olap/msmdpump.dll";

XmlaQueryProperty localization = new XmlaQueryProperty();
localization.Name = "LocaleIdentifier";
localization.Value = "1036";

cubeConnectionDetails.QueryProperties.Add(localization);
#endregion