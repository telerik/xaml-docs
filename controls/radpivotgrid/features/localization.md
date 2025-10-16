---
title: Localization
page_title: Localization
description: Check our &quot;Localization&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-localization
tags: localization
published: True
position: 6
---

# Localization

The built-in localization mechanism in {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} allows you to localize any string resource used by __RadPivotGrid__ and __RadPivotFieldList__ controls. Once translated you might use the resources in your projects without changing anything. You can find more information on the localization of the UI {% if site.site_name == 'WPF' %}[here](http://www.telerik.com/help/wpf/common-localization.html){% endif %}{% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/help/silverlight/common-localization.html){% endif %}.      

>The __LocalDataSourceProvider__ provides an additional __Culture__ support option which allows you to localize the underlying data using any desired Culture. For more details please check the [Culture Support]({%slug radpivotgrid-features-culture-support%}) article from the __LocalDataSourceProvider__ section.      

## Supported Languages

__RadPivotGrid__ can be translated in one of the following supported languages using the framework’s localization mechanism:

* English
* German
* Spanish
* French
* Italian
* Dutch
* Turkish

More information on how to achieve this you can find in the [Localization Using Built-in Resources] ({%slug common-localization%}) article. 

## Localization Using Custom Localization Manager

__Telerik.Windows.Controls.LocalizationManager__ allows you to easily localize any of the Telerik controls. To apply custom localization to your controls just instantiate your custom LocalizationManager and set it to the static property LocalizationManager.Manager, before the creation of the UI:        



```C#
	LocalizationManager.Manager = new CustomLocalizationManager();
	InitializeComponent();
```
```VB.NET
	LocalizationManager.Manager = New CustomLocalizationManager()
	InitializeComponent()
```

*CustomLocalizationManager* must inherit __LocalizationManager__ and override its *GetStringOverride* method. Here is an implementation of a custom localization:        



```C#
	public class CustomLocalizationManager : LocalizationManager
	{
	    private IDictionary<string, string> dictionary;
	
	    public CustomLocalizationManager()
	    {
	        this.dictionary = new Dictionary<string, string>();
	
	        this.dictionary["Pivot_Row"] = "Row";
	        this.dictionary["Pivot_Column"] = "Column";
	        this.dictionary["Pivot_Value"] = "Value: {0}";
	
	        this.dictionary["PivotFieldList_ShowItemsForWhichTheLabel"] = "Show items for which the label";
	        this.dictionary["PivotFieldList_And"] = "and";
	        this.dictionary["PivotFieldList_AscendingBy"] = "Ascending (A to Z) by:";
	        this.dictionary["PivotFieldList_BaseField"] = "Base field:";
	        this.dictionary["PivotFieldList_BaseItem"] = "Base item:";
	        this.dictionary["PivotFieldList_By"] = "by:";
	        this.dictionary["PivotFieldList_ChooseAggregateFunction"] = "Choose the type of calculation that you want to use to summarize data from the selected field.";
	        this.dictionary["PivotFieldList_ChooseFieldsToAddToReport"] = "Choose fields to add to report:";
	        this.dictionary["PivotFieldList_ColumnLabels"] = "Column Labels";
	        this.dictionary["PivotFieldList_DeferLayoutUpdate"] = "Defer Layout Update";
	        this.dictionary["PivotFieldList_DescendingBy"] = "Descending (Z to A) by:";
	        this.dictionary["PivotFieldList_DragFieldsBetweenAreasBelow"] = "Drag fields between areas below:";
	        this.dictionary["PivotFieldList_Format"] = "Format:";
	        this.dictionary["PivotFieldList_GeneralFormat"] = "General Format";
	        this.dictionary["PivotFieldList_IgnoreCase"] = "Ignore Case";
	        this.dictionary["PivotFieldList_PleaseRefreshThePivot"] = "Please refresh the pivot.";
	        this.dictionary["PivotFieldList_Refresh"] = "Refresh";
	        this.dictionary["PivotFieldList_ReportFilter"] = "Report Filter";
	        this.dictionary["PivotFieldList_RowLabels"] = "Row Labels";
		this.dictionary["PivotFieldList_Search"] = "Search";
		this.dictionary["PivotFieldList_NoResult"] = "No Result";
	        this.dictionary["PivotFieldList_SelectItem"] = "Select Item";
	        this.dictionary["PivotFieldList_Show"] = "Show";
	        this.dictionary["PivotFieldList_ShowItemsForWhich"] = "PivotFieldList_ShowItemsForWhich";
	        this.dictionary["PivotFieldList_ShowValuesAs"] = "Show Values As";
	        this.dictionary["PivotFieldList_SortOptions"] = "Sort options";
	        this.dictionary["PivotFieldList_StringFormatDescription"] = "The format should identify the measurement type of the value. The format would be used for general computations such as Sum, Average, Min, Max and others.";
	        this.dictionary["PivotFieldList_SummarizeValuesBy"] = "Summarize Values By";
	        this.dictionary["PivotFieldList_TheActionRequiresMoreRecentInformation"] = "The action requires more recent information.";
	        this.dictionary["PivotFieldList_Update"] = "Update";
	        this.dictionary["PivotFiledList_Values"] = "Values";
	
	        this.dictionary["Ok"] = "Ok";
	        this.dictionary["Cancel"] = "Cancel";
	
	        this.dictionary["PivotFieldList_SetSumAggregate"] = "Sum";
	        this.dictionary["PivotFieldList_SetCountAggregate"] = "Count";
	        this.dictionary["PivotFieldList_SetAverageAggregate"] = "Average";
	        this.dictionary["PivotFieldList_SetIndexTotalFormat"] = "Index";
	        this.dictionary["PivotFieldList_SetPercentOfGrandTotalFormat"] = "% of Grand Total";
	        this.dictionary["PivotFieldList_SortAtoZ"] = "Sort A to Z";
	        this.dictionary["PivotFieldList_SortZtoA"] = "Sort Z to A";
	        this.dictionary["PivotFieldList_MoreSortingOptions"] = "More Sorting Options...";
	        this.dictionary["PivotFieldList_LabelFilter"] = "Label Filter";
	        this.dictionary["PivotFieldList_ValueFilter"] = "Value Filter";
	        this.dictionary["PivotFieldList_TopTenFilter"] = "Top 10 Filter";
	        this.dictionary["PivotFieldList_ClearFilter"] = "Clear Filter";
	        this.dictionary["PivotFieldList_ShowEmptyGroups"] = "Show Empty Groups";
			this.dictionary["PivotFieldList_ShowSubTotals "] = "Show Subtotals";
	        this.dictionary["PivotFieldList_SelectItems"] = "Select Items";
	        this.dictionary["PivotFieldList_MoreAggregateOptions"] = "More Aggregate Options...";
	        this.dictionary["PivotFieldList_MoreCalculationOptions"] = "More Calculation Options...";
	        this.dictionary["PivotFieldList_ClearCalculations"] = "Clear Calculations";
	        this.dictionary["PivotFieldList_NumberFormat"] = "Number Format";
	
	        this.dictionary["Pivot_GrandTotal"] = "Grand Total";
	        this.dictionary["Pivot_Values"] = "Values";
	        this.dictionary["Pivot_Error"] = "Error";
	        this.dictionary["Pivot_TotalP0"] = "Total {0}";
	        this.dictionary["Pivot_P0Total"] = "{0} Total";
	
	        this.dictionary["Pivot_GroupP0AggregateP1"] = "{0} {1}";
	
	        this.dictionary["Pivot_AggregateP0ofP1"] = "{0} of {1}";
	
	        this.dictionary["Pivot_AggregateSum"] = "Sum";
	        this.dictionary["Pivot_AggregateCount"] = "Count";
	        this.dictionary["Pivot_AggregateAverage"] = "Average";
	        this.dictionary["Pivot_AggregateMin"] = "Min";
	        this.dictionary["Pivot_AggregateMax"] = "Max";
	        this.dictionary["Pivot_AggregateProduct"] = "Product";
	        this.dictionary["Pivot_AggregateVar"] = "Var";
	        this.dictionary["Pivot_AggregateVarP"] = "VarP";
	        this.dictionary["Pivot_AggregateStdDev"] = "StdDev";
	        this.dictionary["Pivot_AggregateStdDevP"] = "StdDevP";
	        this.dictionary["Pivot_HourGroup"] = "{0} - Hour";
	        this.dictionary["Pivot_MinuteGroup"] = "{0} - Minute";
	        this.dictionary["Pivot_MonthGroup"] = "{0} - Month";
	        this.dictionary["Pivot_QuarterGroup"] = "{0} - Quarter";
	        this.dictionary["Pivot_SecondGroup"] = "{0} - Second";
	        this.dictionary["Pivot_WeekGroup"] = "{0} - Week";
	        this.dictionary["Pivot_YearGroup"] = "{0} - Year";
	        this.dictionary["Pivot_DayGroup"] = "{0} - Day";
	        this.dictionary["PivotFieldList_PercentOfColumnTotal"] = "% of Column Total";
	        this.dictionary["PivotFieldList_PercentOfRowTotal"] = "% of Row Total";
	        this.dictionary["PivotFieldList_PercentOfGrandTotal"] = "% of Grand Total";
	        this.dictionary["PivotFieldList_NoCalculation"] = "No Calculation";
	        this.dictionary["PivotFieldList_DifferenceFrom"] = "Difference From";
	        this.dictionary["PivotFieldList_PercentDifferenceFrom"] = "% Difference From";
	        this.dictionary["PivotFieldList_PercentOf"] = "% Of";
	        this.dictionary["PivotFieldList_RankSmallestToLargest"] = "Rank Smallest to Largest";
	        this.dictionary["PivotFieldList_RankLargestToSmallest"] = "Rank Largest to Smallest";
	        this.dictionary["PivotFieldList_PercentRunningTotalIn"] = "% Running Total In";
	        this.dictionary["PivotFieldList_RunningTotalIn"] = "Running Total In";
	        this.dictionary["PivotFieldList_Index"] = "Index";
	
	        this.dictionary["PivotFieldList_RelativeToPrevious"] = "(previous)";
	        this.dictionary["PivotFieldList_RelativeToNext"] = "(next)";
	
	        this.dictionary["PivotFieldList_ConditionEquals"] = "equals";
	        this.dictionary["PivotFieldList_DoesNotEqual"] = "does not equal";
	        this.dictionary["PivotFieldList_IsGreaterThan"] = "is greater than";
	        this.dictionary["PivotFieldList_IsGreaterThanOrEqualTo"] = "is greater than or equal to";
	        this.dictionary["PivotFieldList_IsLessThan"] = "is less than";
	        this.dictionary["PivotFieldList_IsLessThanOrEqualTo"] = "is less than or equal to";
	        this.dictionary["PivotFieldList_BeginsWith"] = "begins with";
	        this.dictionary["PivotFieldList_DoesNotBeginWith"] = "does not begin with";
	        this.dictionary["PivotFieldList_EndsWith"] = "ends with";
	        this.dictionary["PivotFieldList_DoesNotEndWith"] = "does not end with";
	        this.dictionary["PivotFieldList_Contains"] = "contains";
	        this.dictionary["PivotFieldList_DoesNotContains"] = "does not contain";
	        this.dictionary["PivotFieldList_IsBetween"] = "is between";
	        this.dictionary["PivotFieldList_IsNotBetween"] = "is not between";
	
	        this.dictionary["PivotFieldList_SelectAll"] = "(Select All)";
	
	        this.dictionary["PivotFieldList_Top10Items"] = "Items";
	        this.dictionary["PivotFieldList_Top10Percent"] = "Percent";
	        this.dictionary["PivotFieldList_Top10Sum"] = "Sum";
	
	        this.dictionary["PivotFieldList_TopItems"] = "Top";
	        this.dictionary["PivotFieldList_BottomItems"] = "Bottom";
	
	        this.dictionary["PivotFieldList_FilterItemsP0"] = "Fitler Items ({0})";
	        this.dictionary["PivotFieldList_LabelFilterP0"] = "Label Filter ({0})";
	        this.dictionary["PivotFieldList_SortP0"] = "Sort ({0})";
	        this.dictionary["PivotFieldList_FormatCellsP0"] = "Format Cells ({0})";
	        this.dictionary["PivotFieldList_ValueSummarizationP0"] = "Value Summarization ({0})";
	        this.dictionary["PivotFieldList_Top10FilterP0"] = "Top10 Filter ({0})";
	        this.dictionary["PivotFieldList_ShowValuesAsP0"] = "Show Values As ({0})";
	        this.dictionary["PivotFieldList_ValueFilterP0"] = "Value Filter ({0})";
	        this.dictionary["PivotFieldList_Null"] = "(null)";
	
	        this.dictionary["Pivot_CalculatedFields"] = "Calculated Fields";
	        this.dictionary["PivotFieldList_ItemFilterConditionCaption"] = "Show items with value that";
	        this.dictionary["PivotFieldList_None"] = "Data source order";
	        this.dictionary["PivotFieldList_Sort_BySortKeys"] = "by Sort Keys";
	    }
	
	    public override string GetStringOverride(string key)
	    {
	        string localized;
	
	        if (this.dictionary.TryGetValue(key, out localized))
	        {
	            return localized;
	        }
	        else
	        {
	            return base.GetStringOverride(key);
	        }
	    }
	}
```
```VB.NET
	Public Class CustomLocalizationManager
		Inherits LocalizationManager
	
		Private dictionary As IDictionary(Of String, String)
	
		Public Sub New()
			Me.dictionary = New Dictionary(Of String, String)()
	
			Me.dictionary("Pivot_Row") = "Row"
			Me.dictionary("Pivot_Column") = "Column"
			Me.dictionary("Pivot_Value") = "Value: {0}"
	
			Me.dictionary("PivotFieldList_ShowItemsForWhichTheLabel") = "Show items for which the label"
			Me.dictionary("PivotFieldList_And") = "and"
			Me.dictionary("PivotFieldList_AscendingBy") = "Ascending (A to Z) by:"
			Me.dictionary("PivotFieldList_BaseField") = "Base field:"
			Me.dictionary("PivotFieldList_BaseItem") = "Base item:"
			Me.dictionary("PivotFieldList_By") = "by:"
			Me.dictionary("PivotFieldList_ChooseAggregateFunction") = "Choose the type of calculation that you want to use to summarize data from the selected field."
			Me.dictionary("PivotFieldList_ChooseFieldsToAddToReport") = "Choose fields to add to report:"
			Me.dictionary("PivotFieldList_ColumnLabels") = "Column Labels"
			Me.dictionary("PivotFieldList_DeferLayoutUpdate") = "Defer Layout Update"
			Me.dictionary("PivotFieldList_DescendingBy") = "Descending (Z to A) by:"
			Me.dictionary("PivotFieldList_DragFieldsBetweenAreasBelow") = "Drag fields between areas below:"
			Me.dictionary("PivotFieldList_Format") = "Format:"
			Me.dictionary("PivotFieldList_GeneralFormat") = "General Format"
			Me.dictionary("PivotFieldList_IgnoreCase") = "Ignore Case"
			Me.dictionary("PivotFieldList_PleaseRefreshThePivot") = "Please refresh the pivot."
			Me.dictionary("PivotFieldList_Refresh") = "Refresh"
			Me.dictionary("PivotFieldList_ReportFilter") = "Report Filter"
			Me.dictionary("PivotFieldList_RowLabels") = "Row Labels"
			Me.dictionary("PivotFieldList_Search") = "Search";
			Me.dictionary("PivotFieldList_NoResult") = "No Result";
			Me.dictionary("PivotFieldList_SelectItem") = "Select Item"
			Me.dictionary("PivotFieldList_Show") = "Show"
			Me.dictionary("PivotFieldList_ShowItemsForWhich") = "PivotFieldList_ShowItemsForWhich"
			Me.dictionary("PivotFieldList_ShowValuesAs") = "Show Values As"
			Me.dictionary("PivotFieldList_SortOptions") = "Sort options"
			Me.dictionary("PivotFieldList_StringFormatDescription") = "The format should identify the measurement type of the value. The format would be used for general computations such as Sum, Average, Min, Max and others."
			Me.dictionary("PivotFieldList_SummarizeValuesBy") = "Summarize Values By"
			Me.dictionary("PivotFieldList_TheActionRequiresMoreRecentInformation") = "The action requires more recent information."
			Me.dictionary("PivotFieldList_Update") = "Update"
			Me.dictionary("PivotFiledList_Values") = "Values"
	
			Me.dictionary("Ok") = "Ok"
			Me.dictionary("Cancel") = "Cancel"
	
			Me.dictionary("PivotFieldList_SetSumAggregate") = "Sum"
			Me.dictionary("PivotFieldList_SetCountAggregate") = "Count"
			Me.dictionary("PivotFieldList_SetAverageAggregate") = "Average"
			Me.dictionary("PivotFieldList_SetIndexTotalFormat") = "Index"
			Me.dictionary("PivotFieldList_SetPercentOfGrandTotalFormat") = "% of Grand Total"
			Me.dictionary("PivotFieldList_SortAtoZ") = "Sort A to Z"
			Me.dictionary("PivotFieldList_SortZtoA") = "Sort Z to A"
			Me.dictionary("PivotFieldList_MoreSortingOptions") = "More Sorting Options..."
			Me.dictionary("PivotFieldList_LabelFilter") = "Label Filter"
			Me.dictionary("PivotFieldList_ValueFilter") = "Value Filter"
			Me.dictionary("PivotFieldList_TopTenFilter") = "Top 10 Filter"
			Me.dictionary("PivotFieldList_ClearFilter") = "Clear Filter"
			Me.dictionary("PivotFieldList_ShowEmptyGroups") = "Show Empty Groups"
			Me.dictionary("PivotFieldList_ShowSubTotals ") = "Show Subtotals"
			Me.dictionary("PivotFieldList_SelectItems") = "Select Items"
			Me.dictionary("PivotFieldList_MoreAggregateOptions") = "More Aggregate Options..."
			Me.dictionary("PivotFieldList_MoreCalculationOptions") = "More Calculation Options..."
			Me.dictionary("PivotFieldList_ClearCalculations") = "Clear Calculations"
			Me.dictionary("PivotFieldList_NumberFormat") = "Number Format"
	
			Me.dictionary("Pivot_GrandTotal") = "Grand Total"
			Me.dictionary("Pivot_Values") = "Values"
			Me.dictionary("Pivot_Error") = "Error"
			Me.dictionary("Pivot_TotalP0") = "Total {0}"
			Me.dictionary("Pivot_P0Total") = "{0} Total"
	
			Me.dictionary("Pivot_GroupP0AggregateP1") = "{0} {1}"
	
			Me.dictionary("Pivot_AggregateP0ofP1") = "{0} of {1}"
	
			Me.dictionary("Pivot_AggregateSum") = "Sum"
			Me.dictionary("Pivot_AggregateCount") = "Count"
			Me.dictionary("Pivot_AggregateAverage") = "Average"
			Me.dictionary("Pivot_AggregateMin") = "Min"
			Me.dictionary("Pivot_AggregateMax") = "Max"
			Me.dictionary("Pivot_AggregateProduct") = "Product"
			Me.dictionary("Pivot_AggregateVar") = "Var"
			Me.dictionary("Pivot_AggregateVarP") = "VarP"
			Me.dictionary("Pivot_AggregateStdDev") = "StdDev"
			Me.dictionary("Pivot_AggregateStdDevP") = "StdDevP"
	
			Me.dictionary("Pivot_HourGroup") = "{0} - Hour"
			Me.dictionary("Pivot_MinuteGroup") = "{0} - Minute"
			Me.dictionary("Pivot_MonthGroup") = "{0} - Month"
			Me.dictionary("Pivot_QuarterGroup") = "{0} - Quarter"
			Me.dictionary("Pivot_SecondGroup") = "{0} - Second"
			Me.dictionary("Pivot_WeekGroup") = "{0} - Week"
			Me.dictionary("Pivot_YearGroup") = "{0} - Year"
			Me.dictionary("Pivot_DayGroup") = "{0} - Day"
	
			Me.dictionary("PivotFieldList_PercentOfColumnTotal") = "% of Column Total"
			Me.dictionary("PivotFieldList_PercentOfRowTotal") = "% of Row Total"
			Me.dictionary("PivotFieldList_PercentOfGrandTotal") = "% of Grand Total"
			Me.dictionary("PivotFieldList_NoCalculation") = "No Calculation"
			Me.dictionary("PivotFieldList_DifferenceFrom") = "Difference From"
			Me.dictionary("PivotFieldList_PercentDifferenceFrom") = "% Difference From"
			Me.dictionary("PivotFieldList_PercentOf") = "% Of"
			Me.dictionary("PivotFieldList_RankSmallestToLargest") = "Rank Smallest to Largest"
			Me.dictionary("PivotFieldList_RankLargestToSmallest") = "Rank Largest to Smallest"
			Me.dictionary("PivotFieldList_PercentRunningTotalIn") = "% Running Total In"
			Me.dictionary("PivotFieldList_RunningTotalIn") = "Running Total In"
			Me.dictionary("PivotFieldList_Index") = "Index"
	
			Me.dictionary("PivotFieldList_RelativeToPrevious") = "(previous)"
			Me.dictionary("PivotFieldList_RelativeToNext") = "(next)"
	
			Me.dictionary("PivotFieldList_ConditionEquals") = "equals"
			Me.dictionary("PivotFieldList_DoesNotEqual") = "does not equal"
			Me.dictionary("PivotFieldList_IsGreaterThan") = "is greater than"
			Me.dictionary("PivotFieldList_IsGreaterThanOrEqualTo") = "is greater than or equal to"
			Me.dictionary("PivotFieldList_IsLessThan") = "is less than"
			Me.dictionary("PivotFieldList_IsLessThanOrEqualTo") = "is less than or equal to"
			Me.dictionary("PivotFieldList_BeginsWith") = "begins with"
			Me.dictionary("PivotFieldList_DoesNotBeginWith") = "does not begin with"
			Me.dictionary("PivotFieldList_EndsWith") = "ends with"
			Me.dictionary("PivotFieldList_DoesNotEndWith") = "does not end with"
			Me.dictionary("PivotFieldList_Contains") = "contains"
			Me.dictionary("PivotFieldList_DoesNotContains") = "does not contain"
			Me.dictionary("PivotFieldList_IsBetween") = "is between"
			Me.dictionary("PivotFieldList_IsNotBetween") = "is not between"
	
			Me.dictionary("PivotFieldList_SelectAll") = "(Select All)"
	
			Me.dictionary("PivotFieldList_Top10Items") = "Items"
			Me.dictionary("PivotFieldList_Top10Percent") = "Percent"
			Me.dictionary("PivotFieldList_Top10Sum") = "Sum"
	
			Me.dictionary("PivotFieldList_TopItems") = "Top"
			Me.dictionary("PivotFieldList_BottomItems") = "Bottom"
	
			Me.dictionary("PivotFieldList_FilterItemsP0") = "Fitler Items ({0})"
			Me.dictionary("PivotFieldList_LabelFilterP0") = "Label Filter ({0})"
			Me.dictionary("PivotFieldList_SortP0") = "Sort ({0})"
			Me.dictionary("PivotFieldList_FormatCellsP0") = "Format Cells ({0})"
			Me.dictionary("PivotFieldList_ValueSummarizationP0") = "Value Summarization ({0})"
			Me.dictionary("PivotFieldList_Top10FilterP0") = "Top10 Filter ({0})"
			Me.dictionary("PivotFieldList_ShowValuesAsP0") = "Show Values As ({0})"
			Me.dictionary("PivotFieldList_ValueFilterP0") = "Value Filter ({0})"
	        Me.dictionary("PivotFieldList_Null") = "(null)"
	
	        Me.dictionary("Pivot_CalculatedFields") = "Calculated Fields"
	        Me.dictionary("PivotFieldList_ItemFilterConditionCaption") = "Show items with value that"
	        Me.dictionary("PivotFieldList_None") = "Data source order"
	        Me.dictionary("PivotFieldList_Sort_BySortKeys") = "by Sort Keys"
		End Sub
	
		Public Overrides Function GetStringOverride(ByVal key As String) As String
			Dim localized As String
	
			If Me.dictionary.TryGetValue(key, localized) Then
				Return localized
			Else
				Return MyBase.GetStringOverride(key)
			End If
		End Function
	End Class
```

As you can see, there are a lot of keys that have to be localized. In the table below you can find more information about each of them.        

>In the code above there are two keys, that will reflect not only __RadPivotGrid__, but all buttons in your applications. These are the resources with keys "Ok" and "Cancel".
            
Key	|	English Value of the Key	|	Comment
---	|	---	|	---
Pivot_AggregateAverage	|	Average	|	Average aggregate function. Example: Average of Quantity 
Pivot_AggregateCount	|	Count	|	Count aggregate function. Example: Count of Products 
Pivot_AggregateMax	|	Max	|	Max aggregate function. Example: Max of Net 
Pivot_AggregateMin	|	Min	|	Min aggregate function. Example: Min of Net 
Pivot_AggregateProduct	|	Product	|	Product aggregate function. Example: Product of Quantity 
Pivot_AggregateStdDev	|	StdDev	|	Sample Standard Deviation aggregate function. Example: StdDev of Net 
Pivot_AggregateStdDevP	|	StdDevP	|	Population Standard Deviation aggregate function. Example: StdDevP of Net 
Pivot_AggregateSum	|	Sum	|	Sum aggregate function. Example: Sum of Net 
Pivot_AggregateVar	|	Var	|	Simple Variance aggregate function. Example: Var of Net 
Pivot_AggregateVarP	|	VarP	|	Population Variance aggregate function. Example: VarP of Net 
Pivot_AggregateP0ofP1	|	{0} of {1}	|	When you apply aggregate function for a specific property, RadPivotGrid and RadPivotFieldList show similar string: Sum of Quantity. This key will help you to localize such strings and particularly the "of" part. In the common scenario you should have {0} to show the aggregate function, your string that will replace the "of" part and {1} for property name.
Pivot_Column	|	Column	|	Used in tooltip to mark the Column in which is the current value.
Pivot_GrandTotal	|	Grand Total	|	Used in RadPivotGrid as the header of the row/column showing the Grand Totals of the aggregation.
Pivot_GroupP0AggregateP1	|	{0} {1}	|	Used in RadPivotGrid as header of the rows/columns, which is showing SubTotal when there are more than one aggregate description. {0} parameter is replaced by items name, while {1} parameter is replaced by Pivot_AggregateP0ofP1 value. Example: For the {0}='Copy Holder' group, the aggregated {1}='Sum of Quantity' it will format the aggregate group name as Copy Holder Sum of Quantity
Pivot_P0Total	|	{0} Total	|	Used in RadPivotGrid as header of the row/column, which is showing SubTotals. The {0} parameter is replaced by group name. Example: Newspaper Total
Pivot_Row	|	Row	|	Used in tooltip to mark the Row in which is the current value.
Pivot_TotalP0	|	Total {0}	|	Used in RadPivotGrid as header of the row/column, which is showing the Totals for each of the aggregate description when there are more than one. If AggregatesPosition property of RadPivotGrid is set to "Rows", than the last rows in RadPivotGrid will show the "Totals" for each of the aggregate descriptions. The headers of these last rows can be modified with this key. {0} is replaced by Pivot_AggregateP0ofP1 value. Example: Total Sum of Quantity 
Pivot_Value	|	Value: {0}	|	Used in tooltip to mark the Value of the current cell.
Pivot_Values	|	Values	|	Used in the tooltip, when there are more than one aggregate descriptions, to describe the special "Values" group that is created (you can see it in rows/columns in RadPivotFieldList).
Pivot_Error	|	Error	|	Used in RadPivotGrid to mark that the value in the cell is not correct. You may see this string when the property which you are trying to aggregate is not a number, when there is division with 0, etc.
PivotFieldList_And	|	and	|	Used in RadPivotFieldList dialogs. Example: between 10 and 20 
PivotFieldList_AscendingBy	|	Ascending (A to Z) by:	|	Used in RadPivotFieldList buttons and dialogs for ascending sorting. Example: Sort Ascending (A to Z) by
PivotFieldList_BaseField	|	Base field:	|	Used in the calculations dialog of RadPivotFieldList. It stays as a Label of the ListBox in which you are able to select the group description by which the calculation will be applied.
PivotFieldList_BaseItem	|	Base item:	|	Used in the calculations dialog of RadPivotFieldList. It stays as a Label of the ListBox in which you are able to select the group by which the calculation will be applied.
PivotFieldList_BeginsWith	|	begins with	|	Used in the label filter dialog of RadPivotFieldList. It indicates that only groups that "begins with" string that is typed in the nearby TextBox will be displayed.
PivotFieldList_BottomItems	|	Bottom	|	Used in the Top 10 Filter dialog of RadPivotFieldList. It indicates that the "last" items matching specified conditions, will be displayed.
PivotFieldList_By	|	by	|	Used in Top 10 Filter dialog of RadPivotFieldList. In this dialog there are several options to choose how to apply the filter and this key provides value for a TextBlock, that will display by which aggregate the filter will be applied. Example: Top 10 items by Sum of Quantity 
PivotFieldList_ChooseAggregateFunction	|	Choose the type of calculation that you want to use to summarize data from the selected field.	|	Used in RadPivotFieldList calculations dialog. It explains the function of the dialog.
PivotFieldList_ChooseFieldsToAddToReport	|	Choose fields to add to report:	|	Used at the top part of RadPivotFieldList as a Header describing what to do with below fields.
PivotFieldList_ClearCalculations	|	Clear Calculations	|	Used in drop-down menus of the buttons in RadPivotFieldList. It is shown only after calculation is applied and when you click it, the calculation is cleared.
PivotFieldList_ClearFilter	|	Clear Filter	|	Used in drop-down menus of the buttons in RadPivotFieldList. It is shown only after group filter is applied and when you click it, the filter is cleared.
PivotFieldList_ColumnLabels	|	Column Labels	|	Used in RadPivotFieldList as a header of the box, showing ColumnGroupDescriptions.
PivotFieldList_ConditionEquals	|	equals	|	Used in RadPivotFieldList filter dialogs to mark that only items, that have equal value with the one entered in the TextBox nearby, will be shown.
PivotFieldList_Contains	|	contains	|	Used in RadPivotFieldList filter dialogs to mark that only items, that contain value with the one entered in the TextBox nearby, will be shown.
PivotFieldList_DeferLayoutUpdate	|	Defer Layout Update	|	Used in the below part of RadPivotFieldList as a Checkbox by which you can enable defer of update and nearby button.
PivotFieldList_DescendingBy	|	Descending (Z to A) by:	|	Used in RadPivotFieldList buttons and dialogs for ascending sorting. Example: Sort Descending (A to Z) by
PivotFieldList_DifferenceFrom	|	Difference From	|	Used in the calculation dialog of RadPivotFieldList. It marks that RadPivotGrid must show the values as a difference from a specific group selected in the other ListBox.
PivotFieldList_DoesNotBeginWith	|	does not begin with	|	Used in RadPivotFieldList filter dialogs to mark that only items, that does not begin with the value entered in the TextBox nearby, will be shown.
PivotFieldList_DoesNotContains	|	does not contain	|	Used in RadPivotFieldList filter dialogs to mark that only items, that does not contain the value entered in the TextBox nearby, will be shown.
PivotFieldList_DoesNotEndWith	|	does not end with	|	Used in RadPivotFieldList filter dialogs to mark that only items, that does not end with the value entered in the TextBox nearby, will be shown.
PivotFieldList_DoesNotEqual	|	does not equal	|	Used in RadPivotFieldList filter dialogs to mark that only items, that are not equal with the value entered in the TextBox nearby, will be shown.
PivotFieldList_DragFieldsBetweenAreasBelow	|	Drag fields between areas below:	|	Used in the middle of RadPivotFieldList to explain how to move items between areas below.
PivotFieldList_EndsWith	|	ends with	|	Used in RadPivotFieldList filter dialogs to mark that only items, that are ends with the value entered in the TextBox nearby, will be shown.
PivotFieldList_FilterItemsP0	|	Filter Items ({0})	|	Used in Report Filter dialog of RadPivotFieldList. This is the header of the window that is used for this dialog. The {0} is replaced by the name of the group description. Example: Filter Items (Product) 
PivotFieldList_Format	|	Format:	|	Used in Number Format dialog of RadPivotFieldList as a label to show that the nearby TextBox is used to format the values in the cells.
PivotFieldList_FormatCellsP0	|	Format Cells ({0})	|	Used in Number Format dialog of RadPivotFieldList. This is the header of the window, that is used for this dialog. The {0} is replaced by the value of Pivot_AggregateP0ofP1. Example: Format Cells (Sum of Quantity) 
PivotFieldList_GeneralFormat	|	General Format	|	Used in Number Format dialog of RadPivotFieldList to mark the area where you are able to select string format for the cells.
PivotFieldList_IgnoreCase	|	Ignore Case	|	Used in Label Filter dialog of RadPivotFieldList. This is the text of the checkbox, that marks if the value entered in the above TextBox and group names in RadPivotGrid should ignore uppercase/lowercase differences.
PivotFieldList_Index	|	Index	|	Used in RadPivotFieldList drop-down button of aggregate functions and calculations dialog. It marks index calculation.
PivotFieldList_IsBetween	|	is between	|	Used in Value filter dialog of RadPivotFieldList. It is used in ComboBox inside the dialog, which selects how to use the value in the nearby numeric. When is between is selected, two numerics will be visible and the user can select range with them. Only groups which value is in the range will be visible.
PivotFieldList_IsGreaterThan	|	is greater than	|	Used in Value filter dialog of RadPivotFieldList. It is used in ComboBox inside the dialog, which selects how to use the value in the nearby numeric. When is greater than is selected, only groups with value higher than entered, will be visible.
PivotFieldList_IsGreaterThanOrEqualTo	|	is greater than or equal to	|	Used in Value filter dialog of RadPivotFieldList. It is used in ComboBox inside the dialog, which selects how to use the value in the nearby numeric. When is greater than or equal to is selected, only groups with value higher than entered or equal to it, will be visible.
PivotFieldList_IsLessThan	|	is less than	|	Used in Value filter dialog of RadPivotFieldList. It is used in ComboBox inside the dialog, which selects how to use the value in the nearby numeric. When is less than is selected, only groups with value less than entered, will be visible.
PivotFieldList_IsLessThanOrEqualTo	|	is less than or equal to	|	Used in Value filter dialog of RadPivotFieldList. It is used in ComboBox inside the dialog, which selects how to use the value in the nearby numeric. When is less than or equal to is selected, only groups with value less than entered or equal to it, will be visible.
PivotFieldList_IsNotBetween	|	is not between	|	Used in Value filter dialog of RadPivotFieldList. It is used in ComboBox inside the dialog, which selects how to use the value in the nearby numeric. When is not between is selected, two numerics will be visible and the user can select range with them. Only groups which value is not in the range will be visible.
PivotFieldList_LabelFilter	|	Label Filter	|	Used in drop-down buttons of RadPivotFieldList. This value indicates that a Label filter will be applied. When you select this option in the drop-down menu, a new dialog will be opened.
PivotFieldList_LabelFilterP0	|	Label Filter ({0})	|	Used in Label Filter dialog of RadPivotFieldList. This is the header of the window that is used for this dialog. The {0} is replaced by the name of the group description that will be filtered. Example: Label Filter (Product) 
PivotFieldList_MoreAggregateOptions	|	More Aggregate Options...	|	Used in drop-down buttons of RadPivotFieldList. When this option is selected, a new dialog will be opened in which the user can select an aggregate function that will be used.
PivotFieldList_MoreCalculationOptions	|	More Calculation Options...	|	Used in drop-down buttons of RadPivotFieldList. When this option is selected, a new dialog will be opened in which the user can select calculation function that will be used.
PivotFieldList_MoreSortingOptions	|	More Sorting Options...	|	Used in drop-down buttons of RadPivotFieldList. When this option is selected, a new dialog will be opened in which the user can select how to sort RadPivotGrid.
PivotFieldList_NoCalculation	|	No Calculation	|	Used in calculation dialog of RadPivotFieldList to indicate that a calculation will not be applied.
PivotFieldList_NoResult	|	No Result	| Used in label filter dialog of RadPivotFieldList when input does not match values.
PivotFieldList_NumberFormat	|	Number Format	|	Used in drop-down buttons of RadPivotFieldList. When this option is selected, a new dialog will be opened in which the user can select the string format of the numbers shown in RadPivotGrid.
PivotFieldList_PercentDifferenceFrom	|	% Difference From	|	Used in calculation dialog of RadPivotFieldList to indicate that for each value in RadPivotGrid a difference from another group (selected in the next ListBox) will be calculated and the value will be shown as percent.
PivotFieldList_PercentOf	|	% Of	|	Used in calculation dialog of RadPivotFieldList to indicate that the values in RadPivotGrid will be shown as percent of another group (selected in the next ListBox).
PivotFieldList_PercentOfColumnTotal	|	% of Column Total	|	Used in calculation dialog of RadPivotFieldList to indicate that the values in RadPivotGrid will be shown as percent of Colum Total.
PivotFieldList_PercentOfGrandTotal	|	% of Grand Total	|	Used in drop-down buttons and calculation dialog of RadPivotFieldList to indicate that the values in RadPivotGrid will be shown as percent of the Grand Total.
PivotFieldList_PercentOfRowTotal	|	% of Row Total	|	Used in calculation dialog of RadPivotFieldList to indicate that the values in RadPivotGrid will be shown as percent of Row Total.
PivotFieldList_PercentRunningTotalIn	|	% Running Total In	|	Used in calculation dialog of RadPivotFieldList to indicate that the values in RadPivotGrid will be shown as percentages. The value shown in each cell is calculated as a sum of its own value and all of the values above. This sum is presented as a percent of the total (the value in the last cell of the column). So the last cell will have value 100% in all cases.
PivotFieldList_PleaseRefreshThePivot	|	Please refresh the pivot.	|	Used in the dialogs of RadPivotFieldList to indicate that in order to show the content of the dialog, a refresh of RadPivotGrid is necessary. This option may show only in cases when Defer Updates option is turned on.
PivotFieldList_RankLargestToSmallest	|	Rank Largest to Smallest	|	Used in calculation dialog of RadPivotFieldList to indicate that the values in RadPivotGrid will ranked and the largest one will be set to 1, the next to 2, etc..
PivotFieldList_RankSmallestToLargest	|	Rank Smallest to Largest	|	Used in calculation dialog of RadPivotFieldList to indicate that the values in RadPivotGrid will ranked and the smallest one will be set to 1, the next to 2, etc..
PivotFieldList_Refresh	|	Refresh	|	Used in a button inside the dialogs of RadPivotFieldList. The button indicates that a Refresh is needed in order to show the content of the dialog. This button may became visible only when Defer Updates is set to true.
PivotFieldList_RelativeToNext	|	(next)	|	Used in calculation dialog of RadPivotFieldList. This item is visible in the second ListBox only for specific calculations (Difference from, % Difference From, etc.) and it marks that the values in RadPivotGrid will be shown as difference from the next group values.
PivotFieldList_RelativeToPrevious	|	(previous)	|	Used in calculation dialog of RadPivotFieldList. This item is visible in the second ListBox only for specific calculations (Difference from, % Difference From, etc.) and it marks that the values in RadPivotGrid will be shown as difference from the previous group values.
PivotFieldList_ReportFilter	|	Report Filter	|	Used in RadPivotFieldList as a header of the area where FilterGroupDescriptions are added.
PivotFieldList_RowLabels	|	Row Labels	|	Used in RadPivotFieldList as a header of the area where RowGroupDescriptions are added.
PivotFieldList_RunningTotalIn	|	Running Total In	|	Used in calculation dialog of RadPivotFieldList to indicate that the values in RadPivotGrid will be calculated in the following way: the value shown in each cell is calculated as a sum of its own value and all of the values above. So the last cell will have the value of the Total (sum of all values).
PivotFieldList_Search	|	Search	|	Used in label filter dialog of RadPivotFieldList. 
PivotFieldList_SelectAll	|	(Select All)	|	Used in report filter dialog of RadPivotFieldList. When this option is selected, all items inside the dialog will be selected.
PivotFieldList_SelectItem	|	Select Item	|	Used in report filter dialog of RadPivotFieldList to mark the area where you can choose which groups to see in RadPivotGrid.
PivotFieldList_SelectItems	|	Select Items	|	Used in the drop-down button inside report filter box of RadPivotFieldList. When this option is selected, a new dialog will open.
PivotFieldList_SetAverageAggregate	|	Average	|	Used in the drop-down button inside Values filter box of RadPivotFieldList. When this option is selected, Average aggregate function will be applied to the values inside RadPivotGrid.
PivotFieldList_SetCountAggregate	|	Count	|	Used in the drop-down button inside Values filter box of RadPivotFieldList. When this option is selected, Count aggregate function will be applied to the values inside RadPivotGrid.
PivotFieldList_SetIndexTotalFormat	|	Index	|	Used in the drop-down button inside Values filter box of RadPivotFieldList. When this option is selected, Index calculation will be applied to the values inside RadPivotGrid.
PivotFieldList_SetPercentOfGrandTotalFormat	|	% of Grand Total	|	Used in the drop-down button inside Values filter box of RadPivotFieldList. When this option is selected, the values inside RadPivotGrid will be shown as percent of the Grand Total.
PivotFieldList_SetSumAggregate	|	Sum	|	Used in the drop-down button inside Values filter box of RadPivotFieldList. When this option is selected, Sum aggregate function will be applied to the values inside RadPivotGrid.
PivotFieldList_Show	|	Show	|	Used in the Top 10 Filter dialog of RadPivotFieldList. It marks the area where users can select different options for the filter.
PivotFieldList_ShowEmptyGroups	|	Show Empty Groups	|	Used in the drop-down button inside Rows and Columns boxes of RadPivotFieldList. When this option is selected, the empty groups will be shown in RadPivotGrid.
PivotFieldList_ShowSubTotals 	|	Show Subtotals	|	Used in the drop-down button inside Rows and Columns boxes of RadPivotFieldList. When this option is selected, the subtotals will be shown in RadPivotGrid.
PivotFieldList_ShowItemsForWhich	|	Show items for which	|	Used in Values filter dialog of RadPivotFieldList. It marks the area where users can select different options for the filter.
PivotFieldList_ShowItemsForWhichTheLabel	|	Show items for which the label	|	Used in Label filter dialog of RadPivotFieldList. It marks the area where users can select different options for the filter.
PivotFieldList_ShowValuesAs	|	Show Values As	|	Used in calculation dialog of RadPivotFieldList. It marks the area where users can select which calculation function to apply.
PivotFieldList_ShowValuesAsP0	|	Show Values As ({0})	|	Used as header of the calculation dialog of RadPivotFieldList. {0} is replaced by Pivot_AggregateP0ofP1 value. Example: Show Values As (Sum of Quantity) 
PivotFieldList_SortAtoZ	|	Sort A to Z	|	Used in drop-down menu of buttons inside Rows and Columns boxes of RadPivotFieldList. When this option is selected, ascending order is applied.
PivotFieldList_SortOptions	|	Sort options	|	Used in sorting dialog of RadPivotFieldList. It marks the area where users can select what kind of sorting to apply.
PivotFieldList_SortP0	|	Sort ({0})	|	Used as header of the sorting dialog in RadPivotFieldList. {0} is replaced by the property name that is used. Example: Sort (Product) 
PivotFieldList_SortZtoA	|	Sort Z to A	|	Used in drop-down menu of buttons inside Rows and Columns boxes of RadPivotFieldList. When this option is selected, descending order is applied.
PivotFieldList_StringFormatDescription	|	The format should identify the measurement type of the value. The format would be used for general computations such as Sum, Average, Min, Max and others.	|	Used inside Number Format dialog of RadPivotFieldList. This is the description what can be achieved via the dialog.
PivotFieldList_SummarizeValuesBy	|	Summarize Values By	|	Used in a dialog of RadPivotFieldList where the user can change the aggregate function. It marks the area where users can select which function to apply.
PivotFieldList_TheActionRequiresMoreRecentInformation	|	The action requires more recent information.	|	Used in the dialogs of RadPivotFieldList to indicate that in order to show the content of the dialog, additional information is needed. It is combined with the value of PivotFieldList_PleaseRefreshThePivot to indicate that Refresh of RadPivotGrid is necessary. This option may show only in cases when Defer Updates option is turned on.
PivotFieldList_Top10FilterP0	|	Top10 Filter ({0})	|	Used as header of the Top 10 filter dialog in RadPivotFieldList. {0} is replaced by the property name that is used. Example: Top10 Filter (Product) 
PivotFieldList_Top10Items	|	Items	|	This value is used inside Top 10 Filter dialog of RadPivotFieldList. It is one of the options in the ComboBox, in which the user can select if the filter should be on Items, Percent or Sum. When this option is selected, user can show specific number of groups in RadPivotGrid - for example Top 10 groups by Sum of Quantity.
PivotFieldList_Top10Percent	|	Percent	|	This value is used inside Top 10 Filter dialog of RadPivotFieldList. It is one of the options in the ComboBox, in which the user can select if the filter should be on Items, Percent or Sum. When this option is selected, user can show specific percent of groups in RadPivotGrid - for example Top 10 percent by Sum of Quantity.
PivotFieldList_Top10Sum	|	Sum	|	This value is used inside Top 10 Filter dialog of RadPivotFieldList. It is one of the options in the ComboBox, in which the user can select if the filter should be on Items, Percent or Sum. When this option is selected, user can show groups, which summarize to a specific sum - for example Top 100 Sum by Sum of Quantity.
PivotFieldList_TopItems	|	Top	|	This value is used inside Top 10 Filter dialog of RadPivotFieldList. It is one of the options in the ComboBox, where the user can select if the Top or Bottom results of applied filter will be shown. When this option is selected, the Top results will be shown.
PivotFieldList_TopTenFilter	|	Top 10 Filter	|	Used in drop-down menu of buttons inside Rows and Columns boxes of RadPivotFieldList. When this option is selected, a new dialog will be opened, where the user can apply Top 10 filter.
PivotFieldList_Update	|	Update	|	Used as a content of a button inside RadPivotFieldList. When the button is clicked, RadPivotGrid is refreshed. The button is enabled only when Defer Updates is set to true.
PivotFieldList_ValueFilter	|	Value Filter	|	Used in drop-down menu of buttons inside Rows and Columns boxes of RadPivotFieldList. When this option is selected, a new dialog will be opened, where the user can apply Value filter.
PivotFieldList_ValueFilterP0	|	Value Filter ({0})	|	Used as a header of the Value Filter dialog of RadPivotGrid. {0} is replaced by the property name that is used. Example: Value Filter (Product) 
PivotFieldList_ValueSummarizationP0	|	Value Summarization ({0})	|	Used as a header of the aggregate description dialog of RadPivotGrid. {0} is replaced by Pivot_AggregateP0ofP1 value. Example: Value Summarization (Sum of Quantity) 
PivotFiledList_Values	|	Values	|	Used in RadPivotFieldList. This is the header of the box in which are the aggregate descriptions.
PivotFieldList_Null	|	(null)	|	Appears in the "Select Items" dialog for properties with null value.
Pivot_HourGroup	|	{0} - Hour	|	Used as a DisplayName of the Hour Step of a Field with DateTime dataType. {0} is replaced by the property name that is used. Example: ShippingDate-Hour
Pivot_MinuteGroup	|	{0} - Minute	|	Used as a DisplayName of the Minute Step of a Field with DateTime dataType. {0} is replaced by the property name that is used. Example: ShippingDate-Minute
Pivot_SecondGroup	|	{0} - Second	|	Used as a DisplayName of the Second Step of a Field with DateTime dataType. {0} is replaced by the property name that is used. Example: ShippingDate-Second
Pivot_DayGroup	|	{0} - Day	|	Used as a DisplayName of the Day Step of a Field with DateTime dataType. {0} is replaced by the property name that is used. Example: ShippingDate-Day
Pivot_WeekGroup	|	{0} - Week	|	Used as a DisplayName of the Week Step of a Field with DateTime dataType. {0} is replaced by the property name that is used. Example: ShippingDate-Week
Pivot_MonthGroup	|	{0} - Month	|	Used as a DisplayName of the Month Step of a Field with DateTime dataType. {0} is replaced by the property name that is used. Example: ShippingDate-Month
Pivot_QuarterGroup	|	{0} - Quarter	|	Used as a DisplayName of the Quarter Step of a Field with DateTime dataType. {0} is replaced by the property name that is used. Example: ShippingDate-Quarter
Pivot_YearGroup	|	{0} - Year	|	Used as a DisplayName of the Year Step of a Field with DateTime dataType. {0} is replaced by the property name that is used. Example: ShippingDate-Year
Pivot_CalculatedFields	|	Calculated Fields	|	Used as a DisplayName of the Calculated Fields folder in the field list.
PivotFieldList_ItemFilterConditionCaption	|	Show items with value that	|	Used as caption of the label filter condition in the Label Filter dialog of a group description.
PivotFieldList_None	|	Data source order	|	Used as a content of a RadioButton in the More Sorting Options dialog of a group description.
PivotFieldList_Sort_BySortKeys	|	by Sort Keys	|	Used in the More Sorting Options dialog of a group description when data provider is OLAP Cube.
PivotInlineFieldList_RowsEmptyText	|	Drag row items here	| Used in the inline RadPivotFieldList as a header of the area where RowGroupDescriptions can be added.
PivotInlineFieldList_ColumnsEmptyText	|	Drag column items here	| Used in the inline RadPivotFieldList as a header of the area where ColumnGroupDescriptions can be added.
PivotInlineFieldList_ValuesEmptyText	|	Drag data items here	| Used in the inline RadPivotFieldList as a header of the area where AggregateGroupDescriptions can be added.
PivotInlineFieldList_FiltersEmptyText	|	Drag filter items here	| Used in the inline RadPivotFieldList as a header of the area where FilterDescriptions can be added.
PivotInlineFieldList_FieldChooser	|	Field Chooser	| The title displayed for the field chooser dialog.
PivotInlineFieldList_Fields	|	Drag fields in the inline field list:	| The label prompting the user to drag the fields displayed in the field chooser dialog.
PivotInlineFieldList_Sort	|	Sort	| The header for the sort operation in the field context menu.
PivotInlineFieldList_Remove	|	Remove	| The header for the remove operation in the field context menu.
PivotInlineFieldList_ReloadData	|	Reload Data	| The header for the operation of reloading data in the field context menu.
PivotInlineFieldList_ShowFieldList	|	Show Field List	| The header for the menu item responsible for showing the field chooser dialog.


## See Also

 * [RadPivotGrid Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [Features]({%slug radpivotgrid-features%})
