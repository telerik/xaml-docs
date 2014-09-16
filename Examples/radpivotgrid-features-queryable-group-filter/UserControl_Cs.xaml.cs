#region radpivotgrid-features-queryable-group-filter_1
var shipCountryGroupDescription = new QueryableDoubleGroupDescription();
shipCountryGroupDescription.PropertyName = "ShipCountry";
var labelGroupFilter = new LabelGroupFilter();
var textCondition = new TextCondition();
textCondition.Comparison = TextComparison.Contains;
textCondition.Pattern = "C";
labelGroupFilter.Condition = textCondition;
shipCountryGroupDescription.GroupFilter = labelGroupFilter;
#endregion

#region radpivotgrid-features-queryable-group-filter_2
var shipCountryGroupDescription = new QueryablePropertyGroupDescription();
shipCountryGroupDescription.PropertyName = "ShipCountry";
var intervalCondition = new IntervalCondition();
intervalCondition.Condition = IntervalComparison.IsBetween;
intervalCondition.From = 50;
intervalCondition.To = 70;

var valueGroupFilter = new ValueGroupFilter();
valueGroupFilter.AggregateIndex = 0;
valueGroupFilter.Condition = intervalCondition;
shipCountryGroupDescription.GroupFilter = valueGroupFilter;
#endregion

#region radpivotgrid-features-queryable-group-filter_3
var shipCountryGroupDescription = new QueryablePropertyGroupDescription();
shipCountryGroupDescription.PropertyName = "ShipCountry";
var countFilter = new GroupsCountFilter();
countFilter.AggregateIndex = 0;
countFilter.Count = 4;
countFilter.Selection = SortedListSelection.Top;
shipCountryGroupDescription.GroupFilter = countFilter;
#endregion

#region radpivotgrid-features-queryable-group-filter_4
var shipCountryGroupDescription = new QueryablePropertyGroupDescription();
shipCountryGroupDescription.PropertyName = "ShipCountry";

var textCondition = new TextCondition();
textCondition.Comparison = TextComparison.Contains;
textCondition.Pattern = "n";

var distinctCondition = new SetCondition();
distinctCondition.Comparison = SetComparison.Includes;
distinctCondition.Items.Add("Brazil");
distinctCondition.Items.Add("Canada");
distinctCondition.Items.Add("Denmark");

var itemsFilterCondition = new ItemsFilterCondition();
itemsFilterCondition.Condition = textCondition;
itemsFilterCondition.DistinctCondition = distinctCondition;

var labelGroupFilter = new LabelGroupFilter();
labelGroupFilter.Condition = itemsFilterCondition;
shipCountryGroupDescription.GroupFilter = labelGroupFilter;
#endregion