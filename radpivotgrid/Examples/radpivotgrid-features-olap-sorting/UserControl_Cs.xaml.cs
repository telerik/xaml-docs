#region radpivotgrid-features-olap-sort_1
XmlaGroupDescription groupDescription = new XmlaGroupDescription();
groupDescription.MemberName = "[Product].[Category]";
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending;
#endregion

#region radpivotgrid-features-olap-sort_2
AdomdGroupDescription groupDescription = new AdomdGroupDescription();
groupDescription.MemberName = "[Product].[Category]";
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending;
#endregion

#region radpivotgrid-features-olap-sort_3
XmlaGroupDescription groupDescription = new XmlaGroupDescription();
groupDescription.MemberName = "[Product].[Category]";
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
groupDescription.GroupComparer = new GrandTotalComparer() { AggregateIndex = 1 };
#endregion

#region radpivotgrid-features-olap-sort_4
AdomdGroupDescription groupDescription = new AdomdGroupDescription();
groupDescription.MemberName = "[Product].[Category]";
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending;
groupDescription.GroupComparer = new GrandTotalComparer() { AggregateIndex = 1 };
#endregion

#region radpivotgrid-features-olap-sort_5
XmlaGroupDescription topGroupDescription = new XmlaGroupDescription();
topGroupDescription.MemberName = "[Date].[Calendar]";
XmlaLevelGroupDescription levelGroupDescription1 = new XmlaLevelGroupDescription();
levelGroupDescription1.MemberName = "[Date].[Calendar].[Calendar Year]";
levelGroupDescription1.SortOrder = Telerik.Pivot.Core.SortOrder.Descending;
topGroupDescription.Levels.Add(levelGroupDescription1);
#endregion

#region radpivotgrid-features-olap-sort_6
AdomdGroupDescription topGroupDescription = new AdomdGroupDescription();
topGroupDescription.MemberName = "[Date].[Calendar]";
AdomdLevelGroupDescription levelGroupDescription1 = new AdomdLevelGroupDescription();
levelGroupDescription1.MemberName = "[Date].[Calendar].[Calendar Year]";
levelGroupDescription1.SortOrder = Telerik.Pivot.Core.SortOrder.Descending;
topGroupDescription.Levels.Add(levelGroupDescription1);
#endregion

#region radpivotgrid-features-olap-sort_7
XmlaGroupDescription groupDescription = new XmlaGroupDescription();
groupDescription.MemberName = "[Product].[Category]";
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None;
#endregion

#region radpivotgrid-features-olap-sort_8
AdomdGroupDescription groupDescription = new AdomdGroupDescription();
groupDescription.MemberName = "[Product].[Category]";
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.None;
#endregion

#region radpivotgrid-features-olap-sort_9
XmlaGroupDescription groupDescription = new XmlaGroupDescription();
groupDescription.MemberName = "[Product].[Category]";
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
groupDescription.GroupComparer = new OlapGroupComparer();
#endregion

#region radpivotgrid-features-olap-sort_10
AdomdGroupDescription groupDescription = new AdomdGroupDescription();
groupDescription.MemberName = "[Product].[Category]";
groupDescription.SortOrder = Telerik.Pivot.Core.SortOrder.Descending;
groupDescription.GroupComparer = new OlapGroupComparer();
#endregion