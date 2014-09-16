---
title: Localization
page_title: Localization
description: Localization
slug: radpivotgrid-features-localization
tags: localization
publish: True
position: 3
---

# Localization



The built-in localization mechanism in {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} allows you to localize any string resource used by __RadPivotGrid__ and __RadPivotFieldList__ controls.
        Once translated you might use the resources in your projects without changing anything. You can find more information on the localization of the RadControls
        {% if site.site_name == 'WPF' %}[here](http://www.telerik.com/help/wpf/common-localization.html){% endif %}{% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/help/silverlight/common-localization.html){% endif %}.
      

>The __LocalDataSourceProvider__ provides an additional __Culture__ support option which allows you to localize the underlying data using any desired Culture. 
          For more details please check the [Culture Support]({%slug radpivotgrid-features-culture-support%}) article from the __LocalDataSourceProvider__ section.
        

## Localization Using Custom Localization Manager

__Telerik.Windows.Controls.LocalizationManager__ allows you to easily localize any of the Telerik controls.
          To apply custom localization to your controls just instantiate your custom LocalizationManager and set it to the static property LocalizationManager.Manager, before the creation of the UI:
        

#### __C#__

{{region radpivotgrid-features-localization_1}}
	LocalizationManager.Manager = new CustomLocalizationManager();
	InitializeComponent();
	{{endregion}}



#### __VB.NET__

{{region radpivotgrid-features-localization_1}}
	LocalizationManager.Manager = New CustomLocalizationManager()
	InitializeComponent()
	'#End Region
	
	' #Region "radpivotgrid-features-localization_2"
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
	' #End Region



*CustomLocalizationManager* must inherit __LocalizationManager__ and override its *GetStringOverride* method. Here is an
          implementation of a custom localization:
        

#### __C#__

{{region radpivotgrid-features-localization_2}}
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
	{{endregion}}



#### __VB.NET__

{{region radpivotgrid-features-localization_2}}
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
	' #End Region



As you can see, there are a lot of keys that have to be localized. In the table below you can find more information about each of them.
        

>In the code above there are two keys, that will reflect not only __RadPivotGrid__, but all buttons in your applications. These are the resources with keys "Ok" and "Cancel".
            
<table><th><tr><td>

Key</td><td>

English Value of the Key</td><td>

Comment
                </td></tr></th><tr><td>

Pivot_AggregateAverage</td><td>

Average</td><td>

Average aggregate function. <i>
                  Example: <b>Average</b> of Quantity
                </i></td></tr><tr><td>

Pivot_AggregateCount</td><td>

Count</td><td>

Count aggregate function. <i>
                  Example: <b>Count</b> of Products
                </i></td></tr><tr><td>

Pivot_AggregateMax</td><td>

Max</td><td>

Max aggregate function. <i>
                  Example: <b>Max</b> of Net
                </i></td></tr><tr><td>

Pivot_AggregateMin</td><td>

Min</td><td>

Min aggregate function. <i>
                  Example: <b>Min</b> of Net
                </i></td></tr><tr><td>

Pivot_AggregateProduct</td><td>

Product</td><td>

Product aggregate function. <i>
                  Example: <b>Product</b> of Quantity
                </i></td></tr><tr><td>

Pivot_AggregateStdDev</td><td>

StdDev</td><td>

Sample Standard Deviation aggregate function. <i>
                  Example: <b>StdDev</b> of Net
                </i></td></tr><tr><td>

Pivot_AggregateStdDevP</td><td>

StdDevP</td><td>

Population Standard Deviation aggregate function. <i>
                  Example: <b>StdDevP</b> of Net
                </i></td></tr><tr><td>

Pivot_AggregateSum</td><td>

Sum</td><td>

Sum aggregate function. <i>
                  Example: <b>Sum</b> of Net
                </i></td></tr><tr><td>

Pivot_AggregateVar</td><td>

Var</td><td>

Simple Variance aggregate function. <i>
                  Example: <b>Var</b> of Net
                </i></td></tr><tr><td>

Pivot_AggregateVarP</td><td>

VarP</td><td>

Population Variance aggregate function. <i>
                  Example: <b>VarP</b> of Net
                </i></td></tr><tr><td>

Pivot_AggregateP0ofP1</td><td>

{0} of {1}</td><td>

When you apply aggregate function for a specific property, <b>RadPivotGrid</b> and <b>RadPivotFieldList</b> show similar string: <i>Sum of Quantity</i>.
                This key will help you to localize such strings and particularly the "of" part. In the common scenario you should have {0} to show the aggregate function, your string that will replace the "of" part and {1} for
                property name.
              </td></tr><tr><td>

Pivot_Column</td><td>

Column</td><td>

Used in tooltip to mark the <b>Column</b> in which is the current value.
              </td></tr><tr><td>

Pivot_GrandTotal</td><td>

Grand Total</td><td>

Used in <b>RadPivotGrid</b> as the header of the row/column showing the Grand Totals of the aggregation.
              </td></tr><tr><td>

Pivot_GroupP0AggregateP1</td><td>

{0} {1}</td><td>

Used in <b>RadPivotGrid</b> as header of the rows/columns, which is showing SubTotal when there are more than one aggregate description.
                {0} parameter is replaced by items name, while {1} parameter is replaced by  <b>Pivot_AggregateP0ofP1</b> value.
                <i>
                  Example: For the {0}='Copy Holder' group, the aggregated {1}='Sum of Quantity' it will format
                  the aggregate group name as <b>Copy Holder Sum of Quantity</b></i></td></tr><tr><td>

Pivot_P0Total</td><td>

{0} Total</td><td>

Used in <b>RadPivotGrid</b> as header of the row/column, which is showing SubTotals. The {0} parameter is replaced by group name.
                <i>
                  Example: Newspaper <b>Total</b></i></td></tr><tr><td>

Pivot_Row</td><td>

Row</td><td>

Used in tooltip to mark the <b>Row</b> in which is the current value.
              </td></tr><tr><td>

Pivot_TotalP0</td><td>

Total {0}</td><td>

Used in <b>RadPivotGrid</b> as header of the row/column, which is showing the Totals for each of the aggregate description when there are more than one. If <i>AggregatesPosition</i>
                property of <b>RadPivotGrid</b> is set to "Rows", than the last rows in <b>RadPivotGrid</b> will show the "Totals" for each of the aggregate descriptions. The headers of these last rows can be modified
                with this key. {0} is replaced by  <b>Pivot_AggregateP0ofP1</b> value.
                <i>
                  Example: <b>Total</b> Sum of Quantity
                </i></td></tr><tr><td>

Pivot_Value</td><td>

Value: {0}</td><td>

Used in tooltip to mark the <b>Value</b> of the current cell.
              </td></tr><tr><td>

Pivot_Values</td><td>

Values</td><td>

Used in the tooltip, when there are more than one aggregate descriptions, to describe the special "Values" group that is created (you can see it in rows/columns in <b>RadPivotFieldList</b>).</td></tr><tr><td>

Pivot_Error</td><td>

Error</td><td>

Used in <b>RadPivotGrid</b> to mark that the value in the cell is not correct. You may see this string when the property which you are trying to aggregate is not a number, when there is division with 0, etc.
              </td></tr><tr><td>

PivotFieldList_And</td><td>

and</td><td>

Used in <b>RadPivotFieldList</b> dialogs.
                <i>
                  Example: between 10 <b>and</b> 20
                </i></td></tr><tr><td>

PivotFieldList_AscendingBy</td><td>

Ascending
                (A to Z) by:
              </td><td>

Used in <b>RadPivotFieldList</b> buttons and dialogs for ascending sorting.
                <i>
                  Example: <b>Sort Ascending (A to Z) by</b></i></td></tr><tr><td>

PivotFieldList_BaseField</td><td>

Base field:</td><td>

Used in the calculations dialog of <b>RadPivotFieldList</b>. It stays as a Label of the ListBox in which
                you are able to select the group description by which the calculation will be applied.
              </td></tr><tr><td>

PivotFieldList_BaseItem</td><td>

Base item:</td><td>

Used in the calculations dialog of <b>RadPivotFieldList</b>. It stays as a Label of the ListBox in which
                you are able to select the group by which the calculation will be applied.
              </td></tr><tr><td>

PivotFieldList_BeginsWith</td><td>

begins with</td><td>

Used in the label filter dialog of <b>RadPivotFieldList</b>. It indicates that only groups that "begins with" string that is typed in the nearby TextBox will be displayed.
              </td></tr><tr><td>

PivotFieldList_BottomItems</td><td>

Bottom</td><td>

Used in the Top 10 Filter dialog of <b>RadPivotFieldList</b>. It indicates that the "last" items matching specified conditions, will be displayed.
              </td></tr><tr><td>

PivotFieldList_By</td><td>

by</td><td>

Used in Top 10 Filter dialog of <b>RadPivotFieldList</b>. In this dialog there are several options to choose how to apply the filter and this key provides value for a TextBlock, that will display <b>by</b> which
                    aggregate the filter will be applied. 
                     <i>
                      Example: Top 10 items <b>by</b> Sum of Quantity
                    </i></td></tr><tr><td>

PivotFieldList_ChooseAggregateFunction</td><td>

Choose the
                type of calculation that you want to use to summarize data from the selected
                field.
              </td><td>

Used in <b>RadPivotFieldList</b> calculations dialog. It explains the function of the dialog.
              </td></tr><tr><td>

PivotFieldList_ChooseFieldsToAddToReport</td><td>

Choose fields to add to report:
              </td><td>

Used at the top part of <b>RadPivotFieldList</b> as a Header describing what to do with below fields.
              </td></tr><tr><td>

PivotFieldList_ClearCalculations</td><td>

Clear
                Calculations
              </td><td>

Used in drop-down menus of the buttons in <b>RadPivotFieldList</b>. It is shown only after calculation is applied and when you click it, the calculation is cleared.
              </td></tr><tr><td>

PivotFieldList_ClearFilter</td><td>

Clear
                Filter
              </td><td>

Used in drop-down menus of the buttons in <b>RadPivotFieldList</b>. It is shown only after group filter is applied and when you click it, the filter is cleared.
              </td></tr><tr><td>

PivotFieldList_ColumnLabels</td><td>

Column Labels
              </td><td>

Used in <b>RadPivotFieldList</b> as a header of the box, showing ColumnGroupDescriptions.
              </td></tr><tr><td>

PivotFieldList_ConditionEquals</td><td>

equals</td><td>

Used in <b>RadPivotFieldList</b> filter dialogs to mark that only items, that have equal value with the one entered in the TextBox nearby, will be shown.
              </td></tr><tr><td>

PivotFieldList_Contains</td><td>

contains</td><td>

Used in <b>RadPivotFieldList</b> filter dialogs to mark that only items, that contain value with the one entered in the TextBox nearby, will be shown.
              </td></tr><tr><td>

PivotFieldList_DeferLayoutUpdate</td><td>

Defer Layout Update
              </td><td>

Used in the below part of <b>RadPivotFieldList</b> as a Checkbox by which you can enable defer of update and nearby button.
              </td></tr><tr><td>

PivotFieldList_DescendingBy</td><td>

Descending
                (Z to A) by:
              </td><td>

Used in <b>RadPivotFieldList</b> buttons and dialogs for ascending sorting.
                <i>
                  Example: <b>Sort Descending (A to Z) by</b></i></td></tr><tr><td>

PivotFieldList_DifferenceFrom</td><td>

Difference From
              </td><td>

Used in the calculation dialog of <b>RadPivotFieldList</b>. It marks that <b>RadPivotGrid</b> must show the values as a difference from a specific group
                selected in the other ListBox.
              </td></tr><tr><td>

PivotFieldList_DoesNotBeginWith</td><td>

does not
                begin with
              </td><td>

Used in <b>RadPivotFieldList</b> filter dialogs to mark that only items, that does not begin with the value entered in the TextBox nearby, will be shown.
              </td></tr><tr><td>

PivotFieldList_DoesNotContains</td><td>

does not
                contain
              </td><td>

Used in <b>RadPivotFieldList</b> filter dialogs to mark that only items, that does not contain the value entered in the TextBox nearby, will be shown.
              </td></tr><tr><td>

PivotFieldList_DoesNotEndWith</td><td>

does not
                end with
              </td><td>

Used in <b>RadPivotFieldList</b> filter dialogs to mark that only items, that does not end with the value entered in the TextBox nearby, will be shown.
              </td></tr><tr><td>

PivotFieldList_DoesNotEqual</td><td>

does not
                equal
              </td><td>

Used in <b>RadPivotFieldList</b> filter dialogs to mark that only items, that are not equal with the value entered in the TextBox nearby, will be shown.
              </td></tr><tr><td>

PivotFieldList_DragFieldsBetweenAreasBelow</td><td>

Drag fields
                between areas below:
              </td><td>

Used in the middle of <b>RadPivotFieldList</b> to explain how to move items between areas below.
              </td></tr><tr><td>

PivotFieldList_EndsWith</td><td>

ends with</td><td>

Used in <b>RadPivotFieldList</b> filter dialogs to mark that only items, that are ends with the value entered in the TextBox nearby, will be shown.
              </td></tr><tr><td>

PivotFieldList_FilterItemsP0</td><td>

Filter Items ({0})
              </td><td>

Used in Report Filter dialog of <b>RadPivotFieldList</b>. This is the header of the window that is used for this dialog. The {0} is replaced by the name of the
                group description.
                <i>
                  Example: <b>Filter Items</b> (Product)
                </i></td></tr><tr><td>

PivotFieldList_Format</td><td>

Format:</td><td>

Used in Number Format dialog of <b>RadPivotFieldList</b> as a label to show that the nearby TextBox is used to format the values in the cells.
              </td></tr><tr><td>

PivotFieldList_FormatCellsP0</td><td>

Format Cells ({0})
              </td><td>

Used in Number Format dialog of <b>RadPivotFieldList</b>. This is the header of the window, that is used for this dialog. The {0} is replaced by the value of Pivot_AggregateP0ofP1.
                <i>
                  Example: <b>Format Cells</b> (Sum of Quantity)
                </i></td></tr><tr><td>

PivotFieldList_GeneralFormat</td><td>

General Format
              </td><td>

Used in Number Format dialog of <b>RadPivotFieldList</b> to mark the area where you are able to select string format for the cells.
              </td></tr><tr><td>

PivotFieldList_IgnoreCase</td><td>

Ignore Case</td><td>

Used in Label Filter dialog of <b>RadPivotFieldList</b>. This is the text of the checkbox, that marks if the value entered in the above TextBox and group names in <b>RadPivotGrid</b>
                should ignore uppercase/lowercase differences.
              </td></tr><tr><td>

PivotFieldList_Index</td><td>

Index</td><td>

Used in <b>RadPivotFieldList</b> drop-down button of aggregate functions and calculations dialog. It marks index calculation.
              </td></tr><tr><td>

PivotFieldList_IsBetween</td><td>

is between</td><td>

Used in Value filter dialog of <b>RadPivotFieldList</b>. It is used in ComboBox inside the dialog, which selects how to use the value in the nearby numeric. When <b>is between</b> is selected, two numerics will be visible and the user can select range with them. Only groups which value is in the range will be visible.
              </td></tr><tr><td>

PivotFieldList_IsGreaterThan</td><td>

is greater than
              </td><td>

Used in Value filter dialog of <b>RadPivotFieldList</b>. It is used in ComboBox inside the dialog, which selects how to use the value in the nearby numeric. When <b>is greater than</b> is selected, only groups with value higher than entered, will be visible.
              </td></tr><tr><td>

PivotFieldList_IsGreaterThanOrEqualTo</td><td>

is greater than or equal to
              </td><td>

Used in Value filter dialog of <b>RadPivotFieldList</b>. It is used in ComboBox inside the dialog, which selects how to use the value in the nearby numeric. When <b>is greater than or equal to</b> is selected, only groups with value higher than entered or equal to it, will be visible.
              </td></tr><tr><td>

PivotFieldList_IsLessThan</td><td>

is less than
              </td><td>

Used in Value filter dialog of <b>RadPivotFieldList</b>. It is used in ComboBox inside the dialog, which selects how to use the value in the nearby numeric. When <b>is less than</b> is selected, only groups with value less than entered, will be visible.
              </td></tr><tr><td>

PivotFieldList_IsLessThanOrEqualTo</td><td>

is less than or equal to
              </td><td>

Used in Value filter dialog of <b>RadPivotFieldList</b>. It is used in ComboBox inside the dialog, which selects how to use the value in the nearby numeric. When <b>is less than or equal to</b> is selected, only groups with value less than entered or equal to it, will be visible.
              </td></tr><tr><td>

PivotFieldList_IsNotBetween</td><td>

is not between
              </td><td>

Used in Value filter dialog of <b>RadPivotFieldList</b>. It is used in ComboBox inside the dialog, which selects how to use the value in the nearby numeric. When <b>is not between</b> is selected, two numerics will be visible and the user can select range with them. Only groups which value is not in the range will be visible.
              </td></tr><tr><td>

PivotFieldList_LabelFilter</td><td>

Label Filter
              </td><td>

Used in drop-down buttons of <b>RadPivotFieldList</b>. This value indicates that a Label filter will be applied. When you select this option in the drop-down menu, a new dialog will be opened.
              </td></tr><tr><td>

PivotFieldList_LabelFilterP0</td><td>

Label Filter ({0})
              </td><td>

Used in Label Filter dialog of <b>RadPivotFieldList</b>. This is the header of the window that is used for this dialog. The {0} is replaced by the name of the
                group description that will be filtered.
                <i>
                  Example: <b>Label Filter</b> (Product)
                </i></td></tr><tr><td>

PivotFieldList_MoreAggregateOptions</td><td>

More
                Aggregate Options...
              </td><td>

Used in drop-down buttons of <b>RadPivotFieldList</b>. When this option is selected, a new dialog will be opened in which the user can select an aggregate function that will be used.
              </td></tr><tr><td>

PivotFieldList_MoreCalculationOptions</td><td>

More
                Calculation Options...
              </td><td>

Used in drop-down buttons of <b>RadPivotFieldList</b>. When this option is selected, a new dialog will be opened in which the user can select calculation function that will be used.
              </td></tr><tr><td>

PivotFieldList_MoreSortingOptions</td><td>

More
                Sorting Options...
              </td><td>

Used in drop-down buttons of <b>RadPivotFieldList</b>. When this option is selected, a new dialog will be opened in which the user can select how to sort <b>RadPivotGrid</b>.
              </td></tr><tr><td>

PivotFieldList_NoCalculation</td><td>

No
                Calculation
              </td><td>

Used in calculation dialog of <b>RadPivotFieldList</b> to indicate that a calculation will not be applied.
              </td></tr><tr><td>

PivotFieldList_NumberFormat</td><td>

Number
                Format
              </td><td>

Used in drop-down buttons of <b>RadPivotFieldList</b>. When this option is selected, a new dialog will be opened in which the user can select the string format of the numbers shown in <b>RadPivotGrid</b>.
              </td></tr><tr><td>

PivotFieldList_PercentDifferenceFrom</td><td>

%
                Difference From
              </td><td>

Used in calculation dialog of <b>RadPivotFieldList</b> to indicate that for each value in <b>RadPivotGrid</b> a difference from another group (selected in the next ListBox) will be calculated and the value will be shown as percent.
              </td></tr><tr><td>

PivotFieldList_PercentOf</td><td>

% Of</td><td>

Used in calculation dialog of <b>RadPivotFieldList</b> to indicate that the values in <b>RadPivotGrid</b> will be shown as percent of another group (selected in the next ListBox).
              </td></tr><tr><td>

PivotFieldList_PercentOfColumnTotal</td><td>

% of Column
                Total
              </td><td>

Used in calculation dialog of <b>RadPivotFieldList</b> to indicate that the values in <b>RadPivotGrid</b> will be shown as percent of Colum Total.
              </td></tr><tr><td>

PivotFieldList_PercentOfGrandTotal</td><td>

% of Grand Total
              </td><td>

Used in drop-down buttons and calculation dialog of <b>RadPivotFieldList</b> to indicate that the values in <b>RadPivotGrid</b> will be shown as percent of the Grand Total.
              </td></tr><tr><td>

PivotFieldList_PercentOfRowTotal</td><td>

% of Row
                Total
              </td><td>

Used in calculation dialog of <b>RadPivotFieldList</b> to indicate that the values in <b>RadPivotGrid</b> will be shown as percent of Row Total.
              </td></tr><tr><td>

PivotFieldList_PercentRunningTotalIn</td><td>

% Running
                Total In
              </td><td>

Used in calculation dialog of <b>RadPivotFieldList</b> to indicate that the values in <b>RadPivotGrid</b> will be shown as percentages. The value shown in each cell is calculated as a sum of its own value and all of the
                values above. This sum is presented as a percent of the total (the value in the last cell of the column). So the last cell will have value 100% in all cases.
              </td></tr><tr><td>

PivotFieldList_PleaseRefreshThePivot</td><td>

Please
                refresh the pivot.
              </td><td>

Used in the dialogs of <b>RadPivotFieldList</b> to indicate that in order to show the content of the dialog, a refresh of <b>RadPivotGrid</b> is necessary. This option may show only in cases when Defer Updates option is turned on.
              </td></tr><tr><td>

PivotFieldList_RankLargestToSmallest</td><td>

Rank
                Largest to Smallest
              </td><td>

Used in calculation dialog of <b>RadPivotFieldList</b> to indicate that the values in <b>RadPivotGrid</b> will ranked and the largest one will be set to 1, the next to 2, etc..
              </td></tr><tr><td>

PivotFieldList_RankSmallestToLargest</td><td>

Rank
                Smallest to Largest
              </td><td>

Used in calculation dialog of <b>RadPivotFieldList</b> to indicate that the values in <b>RadPivotGrid</b> will ranked and the smallest one will be set to 1, the next to 2, etc..
              </td></tr><tr><td>

PivotFieldList_Refresh</td><td>

Refresh</td><td>

Used in a button inside the dialogs of <b>RadPivotFieldList</b>. The button indicates that a Refresh is needed in order to show the content of the dialog. This button may became visible
                only when Defer Updates is set to true.
              </td></tr><tr><td>

PivotFieldList_RelativeToNext</td><td>

(next)</td><td>

Used in calculation dialog of <b>RadPivotFieldList</b>. This item is visible in the second ListBox only for specific calculations (Difference from, % Difference From, etc.) and it marks that the values in <b>RadPivotGrid</b>
                will be shown as difference from the next group values.
              </td></tr><tr><td>

PivotFieldList_RelativeToPrevious</td><td>

(previous)</td><td>

Used in calculation dialog of <b>RadPivotFieldList</b>. This item is visible in the second ListBox only for specific calculations (Difference from, % Difference From, etc.) and it marks that the values in <b>RadPivotGrid</b>
                will be shown as difference from the previous group values.
              </td></tr><tr><td>

PivotFieldList_ReportFilter</td><td>

Report Filter
              </td><td>

Used in <b>RadPivotFieldList</b> as a header of the area where FilterGroupDescriptions are added.
              </td></tr><tr><td>

PivotFieldList_RowLabels</td><td>

Row Labels</td><td>

Used in <b>RadPivotFieldList</b> as a header of the area where RowGroupDescriptions are added.
              </td></tr><tr><td>

PivotFieldList_RunningTotalIn</td><td>

Running
                Total In
              </td><td>

Used in calculation dialog of <b>RadPivotFieldList</b> to indicate that the values in <b>RadPivotGrid</b> will be calculated in the following way: the value shown in each cell is calculated as a sum of its own value and all of the
                values above. So the last cell will have the value of the Total (sum of all values).
              </td></tr><tr><td>

PivotFieldList_SelectAll</td><td>

(Select
                All)
              </td><td>

Used in report filter dialog of <b>RadPivotFieldList</b>. When this option is selected, all items inside the dialog will be selected.
              </td></tr><tr><td>

PivotFieldList_SelectItem</td><td>

Select Item</td><td>

Used in report filter dialog of <b>RadPivotFieldList</b> to mark the area where you can choose which groups to see in <b>RadPivotGrid</b>.
              </td></tr><tr><td>

PivotFieldList_SelectItems</td><td>

Select
                Items
              </td><td>

Used in the drop-down button inside report filter box of <b>RadPivotFieldList</b>. When this option is selected, a new dialog will open.
              </td></tr><tr><td>

PivotFieldList_SetAverageAggregate</td><td>

Average</td><td>

Used in the drop-down button inside Values filter box of <b>RadPivotFieldList</b>. When this option is selected, Average aggregate function will be applied to the values inside <b>RadPivotGrid</b>.</td></tr><tr><td>

PivotFieldList_SetCountAggregate</td><td>

Count</td><td>

Used in the drop-down button inside Values filter box of <b>RadPivotFieldList</b>. When this option is selected, Count aggregate function will be applied to the values inside <b>RadPivotGrid</b>.
              </td></tr><tr><td>

PivotFieldList_SetIndexTotalFormat</td><td>

Index</td><td>

Used in the drop-down button inside Values filter box of <b>RadPivotFieldList</b>. When this option is selected, Index calculation will be applied to the values inside <b>RadPivotGrid</b>.
              </td></tr><tr><td>

PivotFieldList_SetPercentOfGrandTotalFormat</td><td>

% of Grand
                Total
              </td><td>

Used in the drop-down button inside Values filter box of <b>RadPivotFieldList</b>. When this option is selected, the values inside <b>RadPivotGrid</b> will be shown as percent of the Grand Total.
              </td></tr><tr><td>

PivotFieldList_SetSumAggregate</td><td>

Sum</td><td>

Used in the drop-down button inside Values filter box of <b>RadPivotFieldList</b>. When this option is selected, Sum aggregate function will be applied to the values inside <b>RadPivotGrid</b>.
              </td></tr><tr><td>

PivotFieldList_Show</td><td>

Show</td><td>

Used in the Top 10 Filter dialog of <b>RadPivotFieldList</b>. It marks the area where users can select different options for the filter.
              </td></tr><tr><td>

PivotFieldList_ShowEmptyGroups</td><td>

Show Empty Groups
              </td><td>

Used in the drop-down button inside Rows and Columns boxes of <b>RadPivotFieldList</b>. When this option is selected, the empty groups will be shown in <b>RadPivotGrid</b>.
              </td></tr><tr><td>

PivotFieldList_ShowItemsForWhich</td><td>

Show items
                for which
              </td><td>

Used in Values filter dialog of <b>RadPivotFieldList</b>. It marks the area where users can select different options for the filter.
              </td></tr><tr><td>

PivotFieldList_ShowItemsForWhichTheLabel</td><td>

Show items
                for which the label
              </td><td>

Used in Label filter dialog of <b>RadPivotFieldList</b>. It marks the area where users can select different options for the filter.
              </td></tr><tr><td>

PivotFieldList_ShowValuesAs</td><td>

Show Values
                As
              </td><td>

Used in calculation dialog of <b>RadPivotFieldList</b>. It marks the area where users can select which calculation function to apply.
              </td></tr><tr><td>

PivotFieldList_ShowValuesAsP0</td><td>

Show Values
                As ({0})
              </td><td>

Used as header of the calculation dialog of <b>RadPivotFieldList</b>. {0} is replaced by <b>Pivot_AggregateP0ofP1</b> value.
                <i>
                  Example: <b>Show Values As</b> (Sum of Quantity)
                </i></td></tr><tr><td>

PivotFieldList_SortAtoZ</td><td>

Sort A to Z</td><td>

Used in drop-down menu of buttons inside Rows and Columns boxes of <b>RadPivotFieldList</b>. When this option is selected, ascending order is applied.
              </td></tr><tr><td>

PivotFieldList_SortOptions</td><td>

Sort options
              </td><td>

Used in sorting dialog of <b>RadPivotFieldList</b>. It marks the area where users can select what kind of sorting to apply.
              </td></tr><tr><td>

PivotFieldList_SortP0</td><td>

Sort ({0})</td><td>

Used as header of the sorting dialog in <b>RadPivotFieldList</b>. {0} is replaced by the property name that is used.
                <i>
                  Example: <b>Sort</b> (Product)
                </i></td></tr><tr><td>

PivotFieldList_SortZtoA</td><td>

Sort Z to A</td><td>

Used in drop-down menu of buttons inside Rows and Columns boxes of <b>RadPivotFieldList</b>. When this option is selected, descending order is applied.
              </td></tr><tr><td>

PivotFieldList_StringFormatDescription</td><td>

The format
                should identify the measurement type of the value. The format would be used
                for general computations such as Sum, Average, Min, Max and others.
              </td><td>

Used inside Number Format dialog of <b>RadPivotFieldList</b>. This is the description what can be achieved via the dialog.
              </td></tr><tr><td>

PivotFieldList_SummarizeValuesBy</td><td>

Summarize
                Values By
              </td><td>

Used in a dialog of <b>RadPivotFieldList</b> where the user can change the aggregate function. It marks the area where users can select which function to apply.
              </td></tr><tr><td>

PivotFieldList_TheActionRequiresMoreRecentInformation</td><td>

The action
                requires more recent information.
              </td><td>

Used in the dialogs of <b>RadPivotFieldList</b> to indicate that in order to show the content of the dialog, additional information is needed. It is combined with the value of <b>
                  PivotFieldList_PleaseRefreshThePivot
                </b> to indicate that Refresh of <b>RadPivotGrid</b> is necessary. This option may show only in cases when Defer Updates option is turned on.
              </td></tr><tr><td>

PivotFieldList_Top10FilterP0</td><td>

Top10
                Filter ({0})
              </td><td>

Used as header of the Top 10 filter dialog in <b>RadPivotFieldList</b>. {0} is replaced by the property name that is used.
                <i>
                  Example: <b>Top10 Filter</b> (Product)
                </i></td></tr><tr><td>

PivotFieldList_Top10Items</td><td>

Items</td><td>

This value is used inside Top 10 Filter dialog of <b>RadPivotFieldList</b>. It is one of the options in the ComboBox, in which the user can select if the filter should be on Items, Percent or Sum.
                When this option is selected, user can show specific number of groups in <b>RadPivotGrid</b> - for example Top 10 groups by Sum of Quantity.
              </td></tr><tr><td>

PivotFieldList_Top10Percent</td><td>

Percent</td><td>

This value is used inside Top 10 Filter dialog of <b>RadPivotFieldList</b>. It is one of the options in the ComboBox, in which the user can select if the filter should be on Items, Percent or Sum.
                When this option is selected, user can show specific percent of groups in <b>RadPivotGrid</b> - for example Top 10 percent by Sum of Quantity. </td></tr><tr><td>

PivotFieldList_Top10Sum</td><td>

Sum</td><td>

This value is used inside Top 10 Filter dialog of <b>RadPivotFieldList</b>. It is one of the options in the ComboBox, in which the user can select if the filter should be on Items, Percent or Sum.
                When this option is selected, user can show groups, which summarize to a specific sum - for example Top 100 Sum by Sum of Quantity. </td></tr><tr><td>

PivotFieldList_TopItems</td><td>

Top</td><td>

This value is used inside Top 10 Filter dialog of <b>RadPivotFieldList</b>. It is one of the options in the ComboBox, where the user can select if the Top or Bottom results of applied filter will be shown.
              When this option is selected, the Top results will be shown.
            </td></tr><tr><td>

PivotFieldList_TopTenFilter</td><td>

Top 10
                Filter
              </td><td>

Used in drop-down menu of buttons inside Rows and Columns boxes of <b>RadPivotFieldList</b>. When this option is selected, a new dialog will be opened, where the user can apply Top 10 filter.</td></tr><tr><td>

PivotFieldList_Update</td><td>

Update</td><td>

Used as a content of a button inside <b>RadPivotFieldList</b>. When the button is clicked, <b>RadPivotGrid</b> is refreshed. The button is enabled only when Defer Updates is set to true.</td></tr><tr><td>

PivotFieldList_ValueFilter</td><td>

Value
                Filter
              </td><td>

Used in drop-down menu of buttons inside Rows and Columns boxes of <b>RadPivotFieldList</b>. When this option is selected, a new dialog will be opened, where the user can apply Value filter.</td></tr><tr><td>

PivotFieldList_ValueFilterP0</td><td>

Value
                Filter ({0})
              </td><td>

Used as a header of the Value Filter dialog of <b>RadPivotGrid</b>. {0} is replaced by the property name that is used. 
              <i>
                  Example: <b>Value Filter</b> (Product)
                </i></td></tr><tr><td>

PivotFieldList_ValueSummarizationP0</td><td>

Value Summarization ({0})
              </td><td>

Used as a header of the aggregate description dialog of <b>RadPivotGrid</b>. {0} is replaced by <b>Pivot_AggregateP0ofP1</b> value.
              <i>
                  Example: <b>Value Summarization</b> (Sum of Quantity)
                </i></td></tr><tr><td>

PivotFiledList_Values</td><td>

Values</td><td>

Used in <b>RadPivotFieldList</b>. This is the header of the box in which are the aggregate descriptions. </td></tr><tr><td>

PivotFieldList_Null</td><td>

(null)</td><td>

Appears in the "Select Items" dialog for properties with null value.
              </td></tr><tr><td>

Pivot_HourGroup</td><td>

{0} - Hour</td><td>

Used as a DisplayName of the Hour Step of a Field with DateTime dataType. {0} is replaced by the property name that is used.
                <i>
                  Example: <b>ShippingDate-Hour</b></i></td></tr><tr><td>

Pivot_MinuteGroup</td><td>

{0} - Minute</td><td>

Used as a DisplayName of the Minute Step of a Field with DateTime dataType. {0} is replaced by the property name that is used.
                <i>
                  Example: <b>ShippingDate-Minute</b></i></td></tr><tr><td>

Pivot_SecondGroup</td><td>

{0} - Second</td><td>

Used as a DisplayName of the Second Step of a Field with DateTime dataType. {0} is replaced by the property name that is used.
                <i>
                  Example: <b>ShippingDate-Second</b></i></td></tr><tr><td>

Pivot_DayGroup</td><td>

{0} - Day</td><td>

Used as a DisplayName of the Day Step of a Field with DateTime dataType. {0} is replaced by the property name that is used.
                <i>
                  Example: <b>ShippingDate-Day</b></i></td></tr><tr><td>

Pivot_WeekGroup</td><td>

{0} - Week</td><td>

Used as a DisplayName of the Week Step of a Field with DateTime dataType. {0} is replaced by the property name that is used.
                <i>
                  Example: <b>ShippingDate-Week</b></i></td></tr><tr><td>

Pivot_MonthGroup</td><td>

{0} - Month</td><td>

Used as a DisplayName of the Month Step of a Field with DateTime dataType. {0} is replaced by the property name that is used.
                <i>
                  Example: <b>ShippingDate-Month</b></i></td></tr><tr><td>

Pivot_QuarterGroup</td><td>

{0} - Quarter</td><td>

Used as a DisplayName of the Quarter Step of a Field with DateTime dataType. {0} is replaced by the property name that is used.
                <i>
                  Example: <b>ShippingDate-Quarter</b></i></td></tr><tr><td>

Pivot_YearGroup</td><td>

{0} - Year</td><td>

Used as a DisplayName of the Year Step of a Field with DateTime dataType. {0} is replaced by the property name that is used.
                <i>
                  Example: <b>ShippingDate-Year</b></i></td></tr><tr><td>

Pivot_CalculatedFields</td><td>

Calculated Fields</td><td>

Used as a DisplayName of the Calculated Fields folder in the field list.
              </td></tr><tr><td>

PivotFieldList_ItemFilterConditionCaption</td><td>

Show items with value that</td><td>

Used as caption of the label filter condition in the Label Filter dialog of a group description.
              </td></tr><tr><td>

PivotFieldList_None</td><td>

Data source order</td><td>

Used as a content of a RadioButton in the More Sorting Options dialog of a group description.
              </td></tr><tr><td>

PivotFieldList_Sort_BySortKeys</td><td>

by Sort Keys</td><td>

Used in the More Sorting Options dialog of a group description when data provider is OLAP Cube.
              </td></tr></table>

# See Also

 * [RadPivotGrid Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [Features]({%slug radpivotgrid-features%})
