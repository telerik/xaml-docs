'#Region "radpivotgrid-features-localization_1"
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