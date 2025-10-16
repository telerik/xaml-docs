---
title: Breaking Changes
page_title: Breaking Changes
description: This article lists the breaking changes introduced in the RadGridView for WPF component through the releases.
slug: gridview-breaking-changes
tags: breaking, changes, backward,compadibility
published: True
position: 4
---

# Breaking Changes

This article lists and describes the breaking changes introduced in the RadGridView component. For a full list of changes, see the [Release History](https://www.telerik.com/support/whats-new/wpf/release-history) pages of the Telerik UI for WPF product.

## 2025 Q2

* The export functionality no longer needs a reference to `Telerik.Windows.Zip.dll`.

## 2024 Q2 (2024.2.514)

* Removed the `Telerik.Windows.Controls.ExportFormat.Xlsx` and `Telerik.Windows.Controls.ExportFormat.Pdf` enum options. Use the [ExportToPdf]({%slug gridview-export-pdf%}) and [ExportToXlsx]({%slug gridview-export-xlsx%}) methods instead.

## R3 2022 SP1

* The `CurrentCellChanged` event was removed. Use [CurrentCellInfoChanged]({%slug gridview-selection-events%}#currentcellinfochanged) instead. The event was removed because it was using visual containers in its arguments which cannot be provided successfully in a virtualized scenario because of the containers recycling.

## Q2 2015

* Removed the obsoleted class `GridViewExportEventArgs` and TextAlignment, VerticalAlignment, Background, Foreground, FontFamily, FontSize, FontWeight, Width, Height, Styles and Attributes properties from `GridViewElementExportingEventArgs` class.
	
	As of Q3 2013 `GridViewElementExportingEventArgs` exposes a new property called `VisualParameters`. The value of the property depends on the export format. You can use this to style the exported element.
	
	__Replacing the GridViewExportEventArgs styling with the GridViewElementExportingEventArgs__
	```C#
		// before
		private void radGrid_ElementExporting(object sender, GridViewElementExportingEventArgs e) 
		{ 
			e.Background = Colors.Red; 
			e.FontFamily = new FontFamily("Verdana"); 
			e.FontSize = 30; 
			e.FontWeight = FontWeights.Bold; 
			e.Foreground = Colors.Green; 
			e.Height = 50; 
			e.TextAlignment = TextAlignment.Center; 
			e.VerticalAlignment = VerticalAlignment.Bottom; 
		} 
		
		// after
		private void clubsGrid_ElementExporting_1(object sender, GridViewElementExportingEventArgs e) 
		{ 
			if (e.VisualParameters is GridViewHtmlVisualExportParameters) 
			{ 
				var param = e.VisualParameters as GridViewHtmlVisualExportParameters; 
				param.Background = Colors.Red; 
				param.FontFamily = new FontFamily("Verdana"); 
				param.FontSize = 30; 
				param.FontWeight = FontWeights.Bold; 
				param.Foreground = Colors.Green; 
				param.Height = 50; 
				param.TextAlignment = TextAlignment.Center; 
				param.VerticalAlignment = VerticalAlignment.Bottom; 
				param.Width = 500; 
			} 
		}
	```	

* Removed obsoleted property `DefaultOperator` of `FilterOperatorsLoadingEventArgs`. Use the `DefaultOperator1` and `DefaultOperator2` properties instead.

* Removed obsoleted property `ParentGroupRow` of `GridViewGroupFooterRow`.

* Removed obsoleted property `ShowInsertRow` of `RadGridView`. Use the [NewRowPosition]({%slug gridview-rows-adding-rows%}) property instead.

## Q2 2014

* `GridViewMaskedTextBoxColumn` was removed. Use [GridViewMaskedInputColumn]({%slug radgridview-columns-column-types-masked-input-column%}) instead.

* `GridViewIndicatorCell` was removed. Use another visual, like a Border or any ContentControl instead.

## Q2 2013

* DragDrop logic now depends on `DragDropManager`. The `RadDragAndDropManager` logic was removed from the `GridViewDataControl` (inherited by `RadGridView`). For any drag/drop customizations, use `DragDropManager`.

## Q1 2012

The filtering enablement in the `GridViewExpressionColumn` required to write to rewrite the entire filtering infrastructure for the Q1 2012 release. The number of breaking changes was minimized as possible, but some were inevitable. 

* The `IFilteringControl.Prepare` method now expects the more general type `GridViewColumn` instead of `GridViewBoundColumnBase` as its argument.           

* The `GridViewDistinctValuesLoadingEventArgs.Column` property is now of the more general type `GridViewColumn`.           

* The `GridViewDataControl.GetDistinctValues` family of methods now accept `GridViewColumn` instead of `IDataFieldDescriptor` as their first parameter.          

* The `EditorCreatedEventArgs.Column` is now of the more general type `GridViewColumn`.           

* The `FilterOperatorsLoadingEventArgs.Column` property is now of type `GridViewColumn` instead of `IDataFieldDescriptor`.          

* The `ColumnFilterDescriptor` class has been made internal. Use the `IColumnFilterDescriptor` interface instead.           

* You can't directly instantiate a `ColumnFilterDescriptor` anymore since the class has been made internal. When you access the `GridViewColumn.ColumnFilterDescriptor` property, it will be automatically created on demand by the column and you will be given an `IColumnFilterDescriptor` to work with. 

	__Accessing the ColumnFilterDescriptor of a column__
	```C#
		IColumnFilterDescriptor cfd = myColumnInstance.ColumnFilterDescriptor;
	```	

* The `IColumnFilterDescriptor.Column` property is now of type `GridViewColumn` instead of `IDataFieldDescriptor`.          

* The `IColumnFilterDescriptor.DistinctFilter` property is now of type `IDistinctValuesFilterDescriptor` instead of `DistinctValuesFilterDescriptor`.      
	  
* The `IColumnFilterDescriptor.FieldFilter` property is now of type `IFieldFilterDescriptor` instead of `FieldFilterDescriptor`.
      
* The `DistinctValuesFilterDescriptor` class has been made internal. It is not supposed to be used directly from your code. Use the `IDistinctValuesFilterDescriptor` interface instead.
      
* The `FieldFilterDescriptor` class has been made internal. It is not supposed to be used directly from your code. Use the `IFieldFilterDescriptor` interface instead.          

The following examples show some of the changes.

__Filtering a Column__
```C#
	// before	
	GridViewColumn ageColumn = this.radGridView.Columns["Age"];
	ColumnFilterDescriptor ageColumnFilter = new ColumnFilterDescriptor(ageColumn);	
	ageColumnFilter.DistinctFilter.DistinctValues.Add(5);
	ageColumnFilter.FieldFilter.Filter1.Operator = FilterOperator.IsLessThan;
	ageColumnFilter.FieldFilter.Filter1.Value = 10;
	this.radGridView.FilterDescriptors.Add(ageColumnFilter);
	
	// after
	GridViewColumn ageColumn = this.radGridView.Columns["Age"];	
	IColumnFilterDescriptor ageColumnFilter = ageColumn.ColumnFilterDescriptor;
	ageColumnFilter.SuspendNotifications();
	ageColumnFilter.DistinctFilter.AddDistinctValue(5);
	ageColumnFilter.FieldFilter.Filter1.Operator = FilterOperator.IsLessThan;
	ageColumnFilter.FieldFilter.Filter1.Value = 10;
	ageColumnFilter.ResumeNotifications()
```

__Clearing All RadGridView Filters__  
```C#
	// before
	this.radGridView.FilterDescriptors.Clear();
	
	// after
	this.radGridView.FilterDescriptors.SuspendNotifications();
	foreach (var column in this.radGridView.Columns)
	{
	    column.ClearFilters();
	}
	this.radGridView.FilterDescriptors.ResumeNotifications();
```

## See Also  
 * [Getting Started]({%slug gridview-getting-started2%})
 * [Release History](https://www.telerik.com/support/whats-new/wpf/release-history)
 * [UI for WPF Demos](https://demos.telerik.com/wpf/) 
