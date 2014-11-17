#region radpivotgrid-features-filter_1
DateTimeGroupDescription dateTimeGroupDescription = new DateTimeGroupDescription();
dateTimeGroupDescription.PropertyName = "Date";
dateTimeGroupDescription.Step = DateTimeStep.Month;
LabelGroupFilter labelFilter = new LabelGroupFilter();
TextCondition textCondition = new TextCondition();
textCondition.Pattern = "Pe";
textCondition.Comparison = TextComparison.BeginsWith;
labelFilter.Condition = textCondition;
dateTimeGroupDescription.GroupFilter = labelFilter;
#endregion

#region radpivotgrid-features-filter_2
DateTimeGroupDescription dateTimeGroupDescription = new DateTimeGroupDescription();
dateTimeGroupDescription.PropertyName = "Date";
dateTimeGroupDescription.Step = DateTimeStep.Month;
IntervalCondition intervalCondition = new IntervalCondition();
intervalCondition.Condition = IntervalComparison.IsBetween;
intervalCondition.From = "13";
intervalCondition.To = "15";
ValueGroupFilter valueGroupFilter = new ValueGroupFilter();
valueGroupFilter.Condition = intervalCondition;
valueGroupFilter.AggregateIndex = 0;
dateTimeGroupDescription.GroupFilter = valueGroupFilter;
#endregion

#region radpivotgrid-features-filter_3
DateTimeGroupDescription dateTimeGroupDescription = new DateTimeGroupDescription();
dateTimeGroupDescription.PropertyName = "Date";
dateTimeGroupDescription.Step = DateTimeStep.Month;
GroupsCountFilter countFilter = new GroupsCountFilter();
countFilter.Count = 4;
countFilter.Selection = SortedListSelection.Top;
countFilter.AggregateIndex = 0;
dateTimeGroupDescription.GroupFilter = countFilter;
#endregion

#region radpivotgrid-features-filter_4
Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription = new Telerik.Pivot.Core.PropertyGroupDescription();
propertyGroupDescription.PropertyName = "Name";

var labelFilter = new LabelGroupFilter();
var textCondition = new TextCondition();
textCondition.Pattern = "c";
textCondition.Comparison = TextComparison.Contains;

var setCondition = new SetCondition();
setCondition.Comparison = SetComparison.Includes;
setCondition.Items.Add("Pen");
setCondition.Items.Add("Pencil");

var itemsFilterCondition = new ItemsFilterCondition();
itemsFilterCondition.Condition = textCondition;
itemsFilterCondition.DistinctCondition = setCondition;

labelFilter.Condition = itemsFilterCondition;
propertyGroupDescription.GroupFilter = labelFilter;
#endregion