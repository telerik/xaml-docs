#region radpivotgrid-features-sort_1
Telerik.Pivot.Core.PropertyGroupDescription propGroupDescription = new Telerik.Pivot.Core.PropertyGroupDescription();
propGroupDescription.PropertyName = "Name";
propGroupDescription.SortOrder = SortOrder.Descending;

DoubleGroupDescription doubleGroupDescription = new DoubleGroupDescription();
doubleGroupDescription.PropertyName = "Price";
doubleGroupDescription.SortOrder = SortOrder.Ascending;

DateTimeGroupDescription dateTimeGroupDescription = new DateTimeGroupDescription();
dateTimeGroupDescription.PropertyName = "Date";
dateTimeGroupDescription.SortOrder = SortOrder.Descending;
#endregion

#region radpivotgrid-features-sort_2
Telerik.Pivot.Core.PropertyGroupDescription propGroupDescription = new Telerik.Pivot.Core.PropertyGroupDescription();
propGroupDescription.PropertyName = "Name";
propGroupDescription.SortOrder = SortOrder.Descending;
propGroupDescription.GroupComparer = new GrandTotalComparer() { AggregateIndex = 0 };

DoubleGroupDescription doubleGroupDescription = new DoubleGroupDescription();
doubleGroupDescription.PropertyName = "Price";
doubleGroupDescription.SortOrder = SortOrder.Ascending;
doubleGroupDescription.GroupComparer = new GrandTotalComparer() { AggregateIndex = 1 };

DateTimeGroupDescription dateTimeGroupDescription = new DateTimeGroupDescription();
dateTimeGroupDescription.PropertyName = "Date";
dateTimeGroupDescription.SortOrder = SortOrder.Descending;
dateTimeGroupDescription.GroupComparer = new GrandTotalComparer() { AggregateIndex = 0 };
#endregion

#region radpivotgrid-features-sort_3
//XmlaDataProvider:
XmlaGroupDescription topGroupDescription = new XmlaGroupDescription();
topGroupDescription.MemberName = "[Date].[Calendar]";
XmlaLevelGroupDescription levelGroupDescription1 = new XmlaLevelGroupDescription();
levelGroupDescription1.MemberName = "[Date].[Calendar].[Calendar Year]";
levelGroupDescription1.SortOrder = Telerik.Pivot.Core.SortOrder.Descending;
topGroupDescription.Levels.Add(levelGroupDescription1);

//AdomdDataProvider
AdomdGroupDescription topGroupDescription = new AdomdGroupDescription();
topGroupDescription.MemberName = "[Date].[Calendar]";
AdomdLevelGroupDescription levelGroupDescription1 = new AdomdLevelGroupDescription();
levelGroupDescription1.MemberName = "[Date].[Calendar].[Calendar Year]";
levelGroupDescription1.SortOrder = Telerik.Pivot.Core.SortOrder.Descending;
topGroupDescription.Levels.Add(levelGroupDescription1);
#endregion

#region radpivotgrid-features-sort_4
Telerik.Pivot.Core.PropertyGroupDescription propGroupDescription = new Telerik.Pivot.Core.PropertyGroupDescription();
propGroupDescription.PropertyName = "Name";
propGroupDescription.SortOrder = SortOrder.None;

DoubleGroupDescription doubleGroupDescription = new DoubleGroupDescription();
doubleGroupDescription.PropertyName = "Price";
doubleGroupDescription.SortOrder = SortOrder.None;

DateTimeGroupDescription dateTimeGroupDescription = new DateTimeGroupDescription();
dateTimeGroupDescription.PropertyName = "Date";
dateTimeGroupDescription.SortOrder = SortOrder.None;
#endregion