#region radpivotgrid-features-filter-olap_1
XmlaGroupDescription groupDescription1 = new XmlaGroupDescription();
groupDescription1.MemberName = "[Promotion].[Promotion Category]";
OlapLabelGroupFilter labelGroupFilter1 = new OlapLabelGroupFilter();
labelGroupFilter1.Condition = new OlapTextCondition() { Comparison = TextComparison.Contains, Pattern = "C" };
groupDescription1.GroupFilter = labelGroupFilter1;

XmlaGroupDescription groupDescription2 = new XmlaGroupDescription();
groupDescription2.MemberName = "[Product].[Category]";
OlapLabelGroupFilter labelGroupFilter2 = new OlapLabelGroupFilter();
labelGroupFilter2.Condition = new OlapComparisonCondition() { Condition = Comparison.Equals, Than = "[Product].[Category].&[3]" };
groupDescription2.GroupFilter = labelGroupFilter2;
#endregion

#region radpivotgrid-features-filter-olap_2
AdomdGroupDescription groupDescription1 = new AdomdGroupDescription();
groupDescription1.MemberName = "[Promotion].[Promotion Category]";
OlapLabelGroupFilter labelGroupFilter1 = new OlapLabelGroupFilter();
labelGroupFilter1.Condition = new OlapTextCondition() { Comparison = TextComparison.Contains, Pattern = "C" };
groupDescription1.GroupFilter = labelGroupFilter1;

AdomdGroupDescription groupDescription2 = new AdomdGroupDescription();
groupDescription2.MemberName = "[Product].[Category]";
OlapLabelGroupFilter labelGroupFilter2 = new OlapLabelGroupFilter();
labelGroupFilter2.Condition = new OlapComparisonCondition() { Condition = Comparison.Equals, Than = "[Product].[Category].&[3]" };
groupDescription2.GroupFilter = labelGroupFilter2;
#endregion


#region radpivotgrid-features-filter-olap_3
XmlaGroupDescription groupDescription1 = new XmlaGroupDescription();
groupDescription1.MemberName = "[Promotion].[Promotion Category]";
OlapValueGroupFilter valueGroupFilter1 = new OlapValueGroupFilter();
valueGroupFilter1.AggregateIndex = 1;
valueGroupFilter1.Condition = new OlapIntervalCondition() { Condition = IntervalComparison.IsBetween, From = 1000, To = 5000 };
groupDescription1.GroupFilter = valueGroupFilter1;

XmlaGroupDescription groupDescription2 = new XmlaGroupDescription();
groupDescription2.MemberName = "[Product].[Category]";
OlapValueGroupFilter valueGroupFilter2 = new OlapValueGroupFilter();
valueGroupFilter2.AggregateIndex = 0;
valueGroupFilter2.Condition = new OlapComparisonCondition() { Condition = Comparison.IsGreaterThan, Than = 50000 };
groupDescription2.GroupFilter = valueGroupFilter2;
#endregion

#region radpivotgrid-features-filter-olap_4
AdomdGroupDescription groupDescription1 = new AdomdGroupDescription();
groupDescription1.MemberName = "[Promotion].[Promotion Category]";
OlapValueGroupFilter valueGroupFilter1 = new OlapValueGroupFilter();
valueGroupFilter1.AggregateIndex = 1;
valueGroupFilter1.Condition = new OlapIntervalCondition() { Condition = IntervalComparison.IsBetween, From = 1000, To = 5000 };
groupDescription1.GroupFilter = valueGroupFilter1;

AdomdGroupDescription groupDescription2 = new AdomdGroupDescription();
groupDescription2.MemberName = "[Product].[Category]";
OlapValueGroupFilter valueGroupFilter2 = new OlapValueGroupFilter();
valueGroupFilter2.AggregateIndex = 0;
valueGroupFilter2.Condition = new OlapComparisonCondition() { Condition = Comparison.IsGreaterThan, Than = 50000 };
groupDescription2.GroupFilter = valueGroupFilter2;
#endregion

#region radpivotgrid-features-filter-olap_5
XmlaGroupDescription groupDescription = new XmlaGroupDescription();
groupDescription.MemberName = "[Promotion].[Promotions]";

XmlaLevelGroupDescription levelGroupDescription1 = new XmlaLevelGroupDescription();
levelGroupDescription1.MemberName = "[Promotion].[Promotions].[Category]";
OlapLabelGroupFilter labelGroupFilter1 = new OlapLabelGroupFilter();
labelGroupFilter1.Condition = new OlapTextCondition() { Comparison = TextComparison.Contains, Pattern = "E" };
levelGroupDescription1.GroupFilter = labelGroupFilter1;
groupDescription.Levels.Add(levelGroupDescription1);

XmlaLevelGroupDescription levelGroupDescription2 = new XmlaLevelGroupDescription();
levelGroupDescription2.MemberName = "[Promotion].[Promotions].[Type]";
OlapLabelGroupFilter labelGroupFilter2 = new OlapLabelGroupFilter();
labelGroupFilter2.Condition = new OlapComparisonCondition() { Condition = Comparison.Equals, Than = "[Promotion].[Promotions].[Category].&[Reseller].&[Excess Inventory]" };
levelGroupDescription2.GroupFilter = labelGroupFilter2;
groupDescription.Levels.Add(levelGroupDescription2);
#endregion

#region radpivotgrid-features-filter-olap_6
AdomdGroupDescription groupDescription = new AdomdGroupDescription();
groupDescription.MemberName = "[Promotion].[Promotions]";

AdomdLevelGroupDescription levelGroupDescription1 = new AdomdLevelGroupDescription();
levelGroupDescription1.MemberName = "[Promotion].[Promotions].[Category]";
OlapLabelGroupFilter labelGroupFilter1 = new OlapLabelGroupFilter();
labelGroupFilter1.Condition = new OlapTextCondition() { Comparison = TextComparison.Contains, Pattern = "E" };
levelGroupDescription1.GroupFilter = labelGroupFilter1;
groupDescription.Levels.Add(levelGroupDescription1);

AdomdLevelGroupDescription levelGroupDescription2 = new AdomdLevelGroupDescription();
levelGroupDescription2.MemberName = "[Promotion].[Promotions].[Type]";
OlapLabelGroupFilter labelGroupFilter2 = new OlapLabelGroupFilter();
labelGroupFilter2.Condition = new OlapComparisonCondition() { Condition = Comparison.Equals, Than = "[Promotion].[Promotions].[Category].&[Reseller].&[Excess Inventory]" };
levelGroupDescription2.GroupFilter = labelGroupFilter2;
groupDescription.Levels.Add(levelGroupDescription2);
#endregion

#region radpivotgrid-features-filter-olap_7
XmlaGroupDescription groupDescription = new XmlaGroupDescription();
groupDescription.MemberName = "[Promotion].[Promotions]";

XmlaLevelGroupDescription levelGroupDescription1 = new XmlaLevelGroupDescription();
levelGroupDescription1.MemberName = "[Promotion].[Promotions].[Category]";
OlapValueGroupFilter valueGroupFilter1 = new OlapValueGroupFilter();
valueGroupFilter1.AggregateIndex = 1;            
valueGroupFilter1.Condition = new OlapIntervalCondition() { Condition = IntervalComparison.IsBetween, From = 900, To = 1000 };
levelGroupDescription1.GroupFilter = valueGroupFilter1;
groupDescription.Levels.Add(levelGroupDescription1);

XmlaLevelGroupDescription levelGroupDescription2 = new XmlaLevelGroupDescription();
levelGroupDescription2.MemberName = "[Promotion].[Promotions].[Type]";
OlapValueGroupFilter valueGroupFilter2 = new OlapValueGroupFilter();
valueGroupFilter2.AggregateIndex = 0;
valueGroupFilter2.Condition = new OlapComparisonCondition() { Condition = Comparison.IsGreaterThan, Than = 300 };
levelGroupDescription2.GroupFilter = valueGroupFilter2;
groupDescription.Levels.Add(levelGroupDescription2);
#endregion

#region radpivotgrid-features-filter-olap_8
AdomdGroupDescription groupDescription = new AdomdGroupDescription();
groupDescription.MemberName = "[Promotion].[Promotions]";

AdomdLevelGroupDescription levelGroupDescription1 = new AdomdLevelGroupDescription();
levelGroupDescription1.MemberName = "[Promotion].[Promotions].[Category]";
OlapValueGroupFilter valueGroupFilter1 = new OlapValueGroupFilter();
valueGroupFilter1.AggregateIndex = 1;            
valueGroupFilter1.Condition = new OlapIntervalCondition() { Condition = IntervalComparison.IsBetween, From = 900, To = 1000 };
levelGroupDescription1.GroupFilter = valueGroupFilter1;
groupDescription.Levels.Add(levelGroupDescription1);

AdomdLevelGroupDescription levelGroupDescription2 = new AdomdLevelGroupDescription();
levelGroupDescription2.MemberName = "[Promotion].[Promotions].[Type]";
OlapValueGroupFilter valueGroupFilter2 = new OlapValueGroupFilter();
valueGroupFilter2.AggregateIndex = 0;
valueGroupFilter2.Condition = new OlapComparisonCondition() { Condition = Comparison.IsGreaterThan, Than = 300 };
levelGroupDescription2.GroupFilter = valueGroupFilter2;
groupDescription.Levels.Add(levelGroupDescription2);
#endregion