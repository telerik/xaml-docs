---
title: Developer Focused Examples
page_title: Developer Focused Examples
description: Developer Focused Examples
slug: radgridview-sdk-examples
tags: sdk,examples
published: True
position: 1
---

# Developer Focused Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadGridView__.

## List of all RadGridView SDK examples:

{% if site.site_name == 'WPF' %}

* __[Alternation with RowStyleSelector](https://github.com/telerik/xaml-sdk/tree/master/GridView/AlternationRowStyleSelector)__ - 
This example demonstrates how simulate rows alternation with RowStyleSelector.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/style-selectors/rowstyleselector.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/style-selectors/rowstyleselector.html
* __[Auto complete string filter editor](https://github.com/telerik/xaml-sdk/tree/master/GridView/AutoCompleteStringFilterEditor)__ - This example demonstrates how you can extend a string column, so that its field filter editors have the auto-complete functionality. A custom AutoCompleteFilterStringColumn is defined.
In order to observe it, you need to open the FilteringControl of that column and start typing in any of the editors.
* __[Binding columns from view model](https://github.com/telerik/xaml-sdk/tree/master/GridView/BindingColumnsFromViewModel)__ - This example demonstrates how to implement custom attached behavior in order to bind columns from your view-model. You can check the code in MyColumnsBindingBehavior.cs file.
* __[Binding row details element width](https://github.com/telerik/xaml-sdk/tree/master/GridView/BindingRowDetailsElementWidth)__ - This example demonstrates how to synchronize the width of the element defined in RowDetailsTemplate to its parent grid in RadGridView for Silverlight and WPF
* __[Binding selected items from view model](https://github.com/telerik/xaml-sdk/tree/master/GridView/BindingSelectedItemsFromViewModel)__ - This example demonstrates how to implement custom attached behavior in order to bind SelectedItems from and to your view-model for Silverlight and WPF
* __[Bound GridViewSelectColumn](https://github.com/telerik/xaml-sdk/tree/master/GridView/BoundSelectColumn)__ - 
GridViewSelectColumn is bound internally to IsSelected property of GridViewRow. This example demonstrates how to bind GridViewRow's IsSelected property to a property of your business object.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/column-types-select-column.html
* __[Cascading combobox columns](https://github.com/telerik/xaml-sdk/tree/master/GridView/CascadingComboboxColumns)__ - This example demonstrates a common scenario when entering data is a cascade of comboboxes, where the list in the next combo is populated after selecting a value in the previous one.

* __[Cell Style Selector](https://github.com/telerik/xaml-sdk/tree/master/GridView/CellStyleSelector)__ - 
This example demonstrates how to style conditionally RadGridView cells using a CellStyleSelector.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/style-selectors/cell-style-selector.html
* __[Cell tooltip when text trimmed](https://github.com/telerik/xaml-sdk/tree/master/GridView/CellTooltipWhenTextTrimmed)__ - This example demonstrates how you can conditionally show a Tooltip only when the text displayed in GridViewCell has been trimmed. The example is only for WPF.
* __[Change Cell Background From ViewModel](https://github.com/telerik/xaml-sdk/tree/master/GridView/ChangeCellBackgroundFromViewModel)__ - 
This example demonstrates how to change GridViewCell's background based on a value of a property from ViewModel 
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/style-selectors/cell-style-selector.html
* __[Changing themes runtime](https://github.com/telerik/xaml-sdk/tree/master/GridView/ChangingThemesRuntime)__ - This example demonstrates how to implement runtime change for all implicit themes.
See also:
http://docs.telerik.com/devtools/wpf/styling-and-appearance/styling-apperance-themes-runtime.html

* __[Close filtering popup](https://github.com/telerik/xaml-sdk/tree/master/GridView/CloseFilteringPopupFilterButton)__ - 
This example demonstrates how to override the OnApplyFilter method of our FilteringControl in order to close Filtering Popup on pressing the Filter button.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/how-to/howto-close-filtering-popup-on-pressing-the-filter-button.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/filtering/how-to/howto-close-filtering-popup-on-pressing-the-filter-button.html
* __[Column chooser](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnChooser)__ - This example demonstrates how to implement custom column chooser in order to hide/show desired columns in RadGridView for Silverlight and WPF
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/features/overview-controlpanel.html
* __[Column Selection](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnSelection)__ - 
This example demonstrates how to select all cells from a column.
* __[Column settings](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnSettings)__ - This example demonstrates usage of different column's properties. You can use the configuration panel on the left to try different setup. 
* __[Columns Reorder Sync With ListBox](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnsReorderSyncWithListBox)__ - 
This example demonstrates how to reorder RadGridView's columns through drag and drop on a ListBox outside RadGridView.
* __[Combobox column](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumn)__ - This example demonstrates how to configure GridViewComboBoxColumn setting ItemsSource property for it.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/column-types-combobox-column
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/columntypes/column-types-combobox-column
* __[Combobox column editable](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumnEditable)__ - This example demonstrates how use GridViewComboBoxColumn and allow the user to edit it adding new items for its ItemsSource. 
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/column-types-combobox-column
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/columntypes/column-types-combobox-column
* __[Combobox column items source binding](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumnItemsSourceBinding)__ - This example demonstrates how to configure GridViewComboBoxColumn with ItemsSourceBinding and FilterMemberPath properties in RadGridView.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/column-types-combobox-column
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/columntypes/column-types-combobox-column
* __[Control panel](https://github.com/telerik/xaml-sdk/tree/master/GridView/ControlPanel)__ - This example demonstrates how you can configure ControlPanelItems for RadGridView
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/features/overview-controlpanel
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/features/overview-controlpanel
* __[ControlPanel Events](https://github.com/telerik/xaml-sdk/tree/master/GridView/ControlPanelEvents)__ - 
This example demonstrates how to subscribe to events of ControlPanel's button.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/features/overview-controlpanel
http://docs.telerik.com/devtools/silverlight/controls/radgridview/features/overview-controlpanel
* __[Copy paste functionality](https://github.com/telerik/xaml-sdk/tree/master/GridView/CopyPasteFunctionality)__ - This example demonstrates different copy/paste scenarios supported by RadGridView. You can configure ClipboardCopyMode and ClipboardPasteMode through a ContextMenu displayed on right click over the control.
There are also various additional options to be configured on the most right side of the window.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/clipboard/copying.html
http://docs.telerik.com/devtools/wpf/controls/radgridview/clipboard/pasting.html

* __[Create Custom DateTimePicker Column](https://github.com/telerik/xaml-sdk/tree/master/GridView/CreateCustomDateTimePickerColumn)__ - 
This example demonstrates how you can create a custom DateTimePickerColumn column bound to a specific property of the business object, 
as well a reusable custom DateTimePickerColumn bound to its SelectedDate property.

Additional information about creating a custom DateTimePickerColumn can be found in the following articles: 
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/how-to/create-date-time-picker-column.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/how-to/create-date-time-picker-column.html

WPF: http://localhost/devtools/wpf/controls/radgridview/columns/how-to/create-generic-date-time-picker-column
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/how-to/create-generic-date-time-picker-column

	
* __[Custom column](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomColumn)__ - This example demonstrates how to implement custom column inherited from GridViewDataColumn.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/how-to/add-button-column
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/how-to/add-button-column
* __[Custom column filter descriptor](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomColumnFilterDescriptor)__ - This example demonstrates how you can extend the stock ColumnFilterDescriptor in order to change the filtering expression that it generates.  This expression will be the one used for filtering by our data engine.  This example requires advanced knowledge of LINQ Expression Trees.  You can learn more about LINQ Expression Trees at http://msdn.microsoft.com/en-us/library/bb397951.aspx
* __[Custom filter control](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomFilterControl)__ - This example demonstrates how to create and apply a custom filtering control for RadGridView.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/how-to/howto-create-a-custom-field-filter-editor
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/filtering/how-to/howto-create-a-custom-field-filter-editor
* __[Custom hierarchy using row details](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomHierarchyUsingRowDetails)__ - This example demonstrates how to implement custom hierarchy using row-details and GridViewToggleRowDetailsColumn.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/row-details/overview
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/row-details/overview
* __[Custom Keyboard Command Provider](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomKeyboardCommandProvider)__ - 
This example demonstrates how to predefine the default KeyboardProvider.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/commands/KeyboardCommandProvider
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/commands/KeyboardCommandProvider
* __[Case-InSensitive Distinct Values](https://github.com/telerik/xaml-sdk/tree/master/GridView/DistinctValuesFilteringCaseSensitivity)__ - 
This example demonstrates how to configure case insensitive distinct values in filter.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/how-to/howto-display-all-distinct-values.htmldisplay-case-insensitive-distinct-values
* __[Drag Drop within RadGridView](https://github.com/telerik/xaml-sdk/tree/master/GridView/DragDropWithLines)__ - 
This example demonstrates how to implement drag and drop within RadGridView, giving the user feedback where the dragged item will be dropped.

See also:
http://docs.telerik.com/devtools/wpf/controls/dragdropmanager/how-to/howto-draganddrop-within-radgridview
http://docs.telerik.com/devtools/silverlight/controls/dragdropmanager/how-to/howto-draganddrop-within-radgridview
* __[Expand All RowDetails](https://github.com/telerik/xaml-sdk/tree/master/GridView/ExpandAllRowDetails)__ - 
This example demonstrates how to expand all RowDetails.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/row-details/overview
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/row-details/overview
* __[Export paged data excel](https://github.com/telerik/xaml-sdk/tree/master/GridView/ExportPagedDataExcel)__ - This example demonstrates how to export paged data to Excel.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/export/export-xlsx
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/export/export-xlsx
* __[Filter as you type grid view inside combo box](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilterAsYouTypeGridViewInsideComboBox)__ - This example demonstrates how to implement filter as you type in RadGridView placed inside RadComboBox.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/basic.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/filtering/basic.html
* __[Filter As You Type With FilterRow](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilterAsYouTypeWithFilterRow)__ - 
This example demonstrates how to search as you type in the FilterRow's TextBoxes.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/basic.htmlfilter-row
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/filtering/basic.htmlfilter-row
* __[Filtering on Boolean Property](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilteringBooleanProperty)__ - 
This example demonstrates how to show user-friendly text instead of True and False when filtering boolean property.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/basic.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/filtering/basic.html
* __[States of filtering buttons](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilteringButtonsStates)__ - 
This example demonstrates how to control the enabled and disabled state of the Filter and Close buttons in the FilterngControl.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/basic.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/filtering/basic.html
* __[Filtering collection properties](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilteringCollectionProperties)__ - This example demonstrates how you can extend the stock ColumnFilterDescriptor in order to filter collection properties. This example requires advanced knowledge of LINQ Expression Trees.  You can learn more about LINQ Expression Trees at http://msdn.microsoft.com/en-us/library/bb397951.aspx. See also: WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/basic.html SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/filtering/basic.html
* __[Modify ForegroundColor of selected row](https://github.com/telerik/xaml-sdk/tree/master/GridView/ForegroundColorSelectedHoveredRow)__ - 
This example demonstrates how to modify the Foreground color of selected/hovered row.
See also:
http://docs.telerik.com/devtools/wpf/styling-and-appearance/styling-apperance-implicit-styles-overview
http://docs.telerik.com/devtools/wpf/styling-and-appearance/styling-apperance-editing-control-templates

* __[Group selection](https://github.com/telerik/xaml-sdk/tree/master/GridView/GroupSelection)__ - This example demonstrates how to implement an item selection on grouprow level when using GridViewSelectColumn.
* __[Image column filtering](https://github.com/telerik/xaml-sdk/tree/master/GridView/ImageColumnFiltering)__ - This example demonstrates how to override GridViewImageColumn's distinct values to be images and not a string path.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/image-column.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/columntypes/image-column.html

* __[Lightweight GridViewComboBoxColumn](https://github.com/telerik/xaml-sdk/tree/master/GridView/LightweightComboBoxColumn)__ - 
This example demonstrates how to configure lightweight GridViewComboBoxColumn with validation.
Validation rules:
- ItemKey can not be 0
- CustomerItem can not be empty
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/column-types-combobox-column 
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/columntypes/column-types-combobox-column
* __[Lightweight template for cells](https://github.com/telerik/xaml-sdk/tree/master/GridView/LightweightTemplateForCells)__ - This example demonstrates how to implement custom lightweight template for GridViewCell.
* __[Lightweight templates](https://github.com/telerik/xaml-sdk/tree/master/GridView/LightweightTemplates)__ - This example demonstrates how to apply lightweight templates for RadGridView.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/features/overview-lightweight-template.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/features/overview-lightweight-template.html
* __[Locate row as you type](https://github.com/telerik/xaml-sdk/tree/master/GridView/LocateRowAsYouType)__ - This example demonstrates how to implement search as you type functionality. The first row to match the search text is scrolled into view.
* __[Merged cells](https://github.com/telerik/xaml-sdk/tree/master/GridView/MergedCells)__ - As of Q3 2014 we have introduced support for merged cells in RadGridView control. As a result the serial cells with equal values can be merged vertically or horizontally. 
Each time you click on the "Change Merge Direction" button, the way the cells are merged will change.
For more information please check: http://www.telerik.com/help/wpf/gridview-merged-cells.html
* __[New row position](https://github.com/telerik/xaml-sdk/tree/master/GridView/NewRowPosition)__ - This example demonstrates how you can configure NewRowPosition property of RadGridView.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/rows/adding-rows.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/rows/adding-rows.html
* __[Read only binding](https://github.com/telerik/xaml-sdk/tree/master/GridView/ReadOnlyBinding)__ - This example demonstrates how to control which rows or cells to be read only.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/how-to/read-only-rows-cells.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/how-to/read-only-rows-cells.html
* __[Row Details Template Selector](https://github.com/telerik/xaml-sdk/tree/master/GridView/RowDetailsTemplateSelector)__ - 
This example demonstrates how you can use the RowDetailsTemplateSelector property of RadGridView to apply different templates based on some value.

Additional information about TemplateSelectors can be found in the following articles: 
	- http://www.telerik.com/help/wpf/gridview-template-selectors-overview.html (WPF)
	- http://www.telerik.com/help/silverlight/gridview-template-selectors-overview.html	(Silverlight)
* __[Expand / Collapse Row Details](https://github.com/telerik/xaml-sdk/tree/master/GridView/RowDetailsVisibilityOptions)__ - 
This example demonstrates how to expand / collapse the RowDetails of the GridView. 
Additional information about the Row Details Visibility feature can be found in the following articles:
WPF: http://www.telerik.com/help/wpf/radgridview-row-details-visibility.html   
SL: http://www.telerik.com/help/silverlight/radgridview-row-details-visibility.html
* __[Row Style Selector](https://github.com/telerik/xaml-sdk/tree/master/GridView/RowStyleSelector)__ - 
This example demonstrates how to style conditionally RadGridView rows using a RowStyleSelector.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/style-selectors/rowstyleselector.html

* __[ScrollIntoViewAsync MVVM](https://github.com/telerik/xaml-sdk/tree/master/GridView/ScrollIntoViewAsyncMvvm)__ - 
This example demonstrates how to create an attached behavior, that allows you to scroll to the newly added item. 
In order to do that ScrollIntoViewAsync method is invoked.
See also:
WPF: http://www.telerik.com/help/wpf/gridview-scroll-item.html
SL: http://www.telerik.com/help/silverlight/gridview-scroll-item.html

* __[Scroll two grids simultaneously](https://github.com/telerik/xaml-sdk/tree/master/GridView/ScrollTwoGridsSimultaneously)__ - 
This example demonstrates how to scroll two GridViews simultaneously.
* __[Select Single Item in Hierarchy](https://github.com/telerik/xaml-sdk/tree/master/GridView/SelectSingleItemHierarchy)__ - 
This example demonstrates how select single item in hierarchical GridView.
* __[Tooltip showing Column's SortDirection](https://github.com/telerik/xaml-sdk/tree/master/GridView/SortDirectionTooltip)__ - 
This example demonstrates how to add a Tooltip for GridViewDataColumn's Header which shows its SortDirection.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/sorting/programmatic.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/sorting/programmatic.html
* __[Sort group by aggregate](https://github.com/telerik/xaml-sdk/tree/master/GridView/SortGroupByAggregate)__ - This example demonstrates how to sort groups by defined aggregate functions. 
You can press the two buttons below RadGridView to test different cases:
 -Sort by first aggregate
 -Sort by second aggregate
 
Note: this example have lightweight templates applied for RadGridView.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/features/overview-lightweight-template.html

* __[Sort group by different property](https://github.com/telerik/xaml-sdk/tree/master/GridView/SortGroupByDifferentProperty)__ - This example demonstrates how to sort groups by different property

Note: this example have lightweight templates applied for RadGridView.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/features/overview-lightweight-template.html
* __[Validation with IDataErrorInfo Interface](https://github.com/telerik/xaml-sdk/tree/master/GridView/ValidationIDataErrorInfo)__ - 
This example demonstrates how to perform validation with IDataErrorInfo Interface.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/features/managing-data-validation.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/features/managing-data-validation.html
* __[Validation with INotifyDataErrorInfo Interface](https://github.com/telerik/xaml-sdk/tree/master/GridView/ValidationINotifyDataErrorInfo)__ - 
This example demonstrates how to perform validation with INotifyDataErrorInfo Interface.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/features/managing-data-validation.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/features/managing-data-validation.html
* __[Various data sources](https://github.com/telerik/xaml-sdk/tree/master/GridView/VariousDataSources)__ - This example demonstrates how to bind RadGridView to different DataSources.
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Alternation with RowStyleSelector](https://github.com/telerik/xaml-sdk/tree/master/GridView/AlternationRowStyleSelector)__ - 
This example demonstrates how simulate rows alternation with RowStyleSelector.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/style-selectors/rowstyleselector.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/style-selectors/rowstyleselector.html
* __[Auto complete string filter editor](https://github.com/telerik/xaml-sdk/tree/master/GridView/AutoCompleteStringFilterEditor)__ - This example demonstrates how you can extend a string column, so that its field filter editors have the auto-complete functionality. A custom AutoCompleteFilterStringColumn is defined.
In order to observe it, you need to open the FilteringControl of that column and start typing in any of the editors.
* __[Binding columns from view model](https://github.com/telerik/xaml-sdk/tree/master/GridView/BindingColumnsFromViewModel)__ - This example demonstrates how to implement custom attached behavior in order to bind columns from your view-model. You can check the code in MyColumnsBindingBehavior.cs file.
* __[Binding row details element width](https://github.com/telerik/xaml-sdk/tree/master/GridView/BindingRowDetailsElementWidth)__ - This example demonstrates how to synchronize the width of the element defined in RowDetailsTemplate to its parent grid in RadGridView for Silverlight and WPF
* __[Binding selected items from view model](https://github.com/telerik/xaml-sdk/tree/master/GridView/BindingSelectedItemsFromViewModel)__ - This example demonstrates how to implement custom attached behavior in order to bind SelectedItems from and to your view-model for Silverlight and WPF
* __[Bound GridViewSelectColumn](https://github.com/telerik/xaml-sdk/tree/master/GridView/BoundSelectColumn)__ - 
GridViewSelectColumn is bound internally to IsSelected property of GridViewRow. This example demonstrates how to bind GridViewRow's IsSelected property to a property of your business object.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/column-types-select-column.html
* __[Cascading combobox columns](https://github.com/telerik/xaml-sdk/tree/master/GridView/CascadingComboboxColumns)__ - This example demonstrates a common scenario when entering data is a cascade of comboboxes, where the list in the next combo is populated after selecting a value in the previous one.

* __[Cell Style Selector](https://github.com/telerik/xaml-sdk/tree/master/GridView/CellStyleSelector)__ - 
This example demonstrates how to style conditionally RadGridView cells using a CellStyleSelector.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/style-selectors/cell-style-selector.html
* __[Change Cell Background From ViewModel](https://github.com/telerik/xaml-sdk/tree/master/GridView/ChangeCellBackgroundFromViewModel)__ - 
This example demonstrates how to change GridViewCell's background based on a value of a property from ViewModel 
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/style-selectors/cell-style-selector.html
* __[Changing themes runtime](https://github.com/telerik/xaml-sdk/tree/master/GridView/ChangingThemesRuntime)__ - This example demonstrates how to implement runtime change for all implicit themes.
See also:
http://docs.telerik.com/devtools/wpf/styling-and-appearance/styling-apperance-themes-runtime.html

* __[Close filtering popup](https://github.com/telerik/xaml-sdk/tree/master/GridView/CloseFilteringPopupFilterButton)__ - 
This example demonstrates how to override the OnApplyFilter method of our FilteringControl in order to close Filtering Popup on pressing the Filter button.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/how-to/howto-close-filtering-popup-on-pressing-the-filter-button.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/filtering/how-to/howto-close-filtering-popup-on-pressing-the-filter-button.html
* __[Column chooser](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnChooser)__ - This example demonstrates how to implement custom column chooser in order to hide/show desired columns in RadGridView for Silverlight and WPF
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/features/overview-controlpanel.html
* __[Column Selection](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnSelection)__ - 
This example demonstrates how to select all cells from a column.
* __[Column settings](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnSettings)__ - This example demonstrates usage of different column's properties. You can use the configuration panel on the left to try different setup. 
* __[Columns Reorder Sync With ListBox](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnsReorderSyncWithListBox)__ - 
This example demonstrates how to reorder RadGridView's columns through drag and drop on a ListBox outside RadGridView.
* __[Combobox column](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumn)__ - This example demonstrates how to configure GridViewComboBoxColumn setting ItemsSource property for it.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/column-types-combobox-column
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/columntypes/column-types-combobox-column
* __[Combobox column editable](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumnEditable)__ - This example demonstrates how use GridViewComboBoxColumn and allow the user to edit it adding new items for its ItemsSource. 
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/column-types-combobox-column
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/columntypes/column-types-combobox-column
* __[Combobox column items source binding](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumnItemsSourceBinding)__ - This example demonstrates how to configure GridViewComboBoxColumn with ItemsSourceBinding and FilterMemberPath properties in RadGridView.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/column-types-combobox-column
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/columntypes/column-types-combobox-column
* __[Control panel](https://github.com/telerik/xaml-sdk/tree/master/GridView/ControlPanel)__ - This example demonstrates how you can configure ControlPanelItems for RadGridView
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/features/overview-controlpanel
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/features/overview-controlpanel
* __[ControlPanel Events](https://github.com/telerik/xaml-sdk/tree/master/GridView/ControlPanelEvents)__ - 
This example demonstrates how to subscribe to events of ControlPanel's button.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/features/overview-controlpanel
http://docs.telerik.com/devtools/silverlight/controls/radgridview/features/overview-controlpanel
* __[Copy paste functionality](https://github.com/telerik/xaml-sdk/tree/master/GridView/CopyPasteFunctionality)__ - This example demonstrates different copy/paste scenarios supported by RadGridView. You can configure ClipboardCopyMode and ClipboardPasteMode through a ContextMenu displayed on right click over the control.
There are also various additional options to be configured on the most right side of the window.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/clipboard/copying.html
http://docs.telerik.com/devtools/wpf/controls/radgridview/clipboard/pasting.html

* __[Create Custom DateTimePicker Column](https://github.com/telerik/xaml-sdk/tree/master/GridView/CreateCustomDateTimePickerColumn)__ - 
This example demonstrates how you can create a custom DateTimePickerColumn column bound to a specific property of the business object, 
as well a reusable custom DateTimePickerColumn bound to its SelectedDate property.

Additional information about creating a custom DateTimePickerColumn can be found in the following articles: 
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/how-to/create-date-time-picker-column.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/how-to/create-date-time-picker-column.html

WPF: http://localhost/devtools/wpf/controls/radgridview/columns/how-to/create-generic-date-time-picker-column
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/how-to/create-generic-date-time-picker-column

	
* __[Custom column](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomColumn)__ - This example demonstrates how to implement custom column inherited from GridViewDataColumn.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/how-to/add-button-column
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/how-to/add-button-column
* __[Custom column filter descriptor](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomColumnFilterDescriptor)__ - This example demonstrates how you can extend the stock ColumnFilterDescriptor in order to change the filtering expression that it generates.  This expression will be the one used for filtering by our data engine.  This example requires advanced knowledge of LINQ Expression Trees.  You can learn more about LINQ Expression Trees at http://msdn.microsoft.com/en-us/library/bb397951.aspx
* __[Custom filter control](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomFilterControl)__ - This example demonstrates how to create and apply a custom filtering control for RadGridView.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/how-to/howto-create-a-custom-field-filter-editor
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/filtering/how-to/howto-create-a-custom-field-filter-editor
* __[Custom hierarchy using row details](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomHierarchyUsingRowDetails)__ - This example demonstrates how to implement custom hierarchy using row-details and GridViewToggleRowDetailsColumn.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/row-details/overview
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/row-details/overview
* __[Custom Keyboard Command Provider](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomKeyboardCommandProvider)__ - 
This example demonstrates how to predefine the default KeyboardProvider.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/commands/KeyboardCommandProvider
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/commands/KeyboardCommandProvider
* __[Case-InSensitive Distinct Values](https://github.com/telerik/xaml-sdk/tree/master/GridView/DistinctValuesFilteringCaseSensitivity)__ - 
This example demonstrates how to configure case insensitive distinct values in filter.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/how-to/howto-display-all-distinct-values.htmldisplay-case-insensitive-distinct-values
* __[Drag Drop within RadGridView](https://github.com/telerik/xaml-sdk/tree/master/GridView/DragDropWithLines)__ - 
This example demonstrates how to implement drag and drop within RadGridView, giving the user feedback where the dragged item will be dropped.

See also:
http://docs.telerik.com/devtools/wpf/controls/dragdropmanager/how-to/howto-draganddrop-within-radgridview
http://docs.telerik.com/devtools/silverlight/controls/dragdropmanager/how-to/howto-draganddrop-within-radgridview
* __[Expand All RowDetails](https://github.com/telerik/xaml-sdk/tree/master/GridView/ExpandAllRowDetails)__ - 
This example demonstrates how to expand all RowDetails.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/row-details/overview
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/row-details/overview
* __[Export paged data excel](https://github.com/telerik/xaml-sdk/tree/master/GridView/ExportPagedDataExcel)__ - This example demonstrates how to export paged data to Excel.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/export/export-xlsx
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/export/export-xlsx
* __[Filter as you type grid view inside combo box](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilterAsYouTypeGridViewInsideComboBox)__ - This example demonstrates how to implement filter as you type in RadGridView placed inside RadComboBox.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/basic.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/filtering/basic.html
* __[Filter As You Type With FilterRow](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilterAsYouTypeWithFilterRow)__ - 
This example demonstrates how to search as you type in the FilterRow's TextBoxes.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/basic.htmlfilter-row
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/filtering/basic.htmlfilter-row
* __[Filtering on Boolean Property](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilteringBooleanProperty)__ - 
This example demonstrates how to show user-friendly text instead of True and False when filtering boolean property.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/basic.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/filtering/basic.html
* __[States of filtering buttons](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilteringButtonsStates)__ - 
This example demonstrates how to control the enabled and disabled state of the Filter and Close buttons in the FilterngControl.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/basic.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/filtering/basic.html
* __[Filtering collection properties](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilteringCollectionProperties)__ - This example demonstrates how you can extend the stock ColumnFilterDescriptor in order to filter collection properties. This example requires advanced knowledge of LINQ Expression Trees.  You can learn more about LINQ Expression Trees at http://msdn.microsoft.com/en-us/library/bb397951.aspx. See also: WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/filtering/basic.html SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/filtering/basic.html
* __[Modify ForegroundColor of selected row](https://github.com/telerik/xaml-sdk/tree/master/GridView/ForegroundColorSelectedHoveredRow)__ - 
This example demonstrates how to modify the Foreground color of selected/hovered row.
See also:
http://docs.telerik.com/devtools/wpf/styling-and-appearance/styling-apperance-implicit-styles-overview
http://docs.telerik.com/devtools/wpf/styling-and-appearance/styling-apperance-editing-control-templates

* __[Group selection](https://github.com/telerik/xaml-sdk/tree/master/GridView/GroupSelection)__ - This example demonstrates how to implement an item selection on grouprow level when using GridViewSelectColumn.
* __[Image column filtering](https://github.com/telerik/xaml-sdk/tree/master/GridView/ImageColumnFiltering)__ - This example demonstrates how to override GridViewImageColumn's distinct values to be images and not a string path.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/image-column.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/columntypes/image-column.html

* __[Lightweight GridViewComboBoxColumn](https://github.com/telerik/xaml-sdk/tree/master/GridView/LightweightComboBoxColumn)__ - 
This example demonstrates how to configure lightweight GridViewComboBoxColumn with validation.
Validation rules:
- ItemKey can not be 0
- CustomerItem can not be empty
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/column-types-combobox-column 
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/columntypes/column-types-combobox-column
* __[Lightweight template for cells](https://github.com/telerik/xaml-sdk/tree/master/GridView/LightweightTemplateForCells)__ - This example demonstrates how to implement custom lightweight template for GridViewCell.
* __[Lightweight templates](https://github.com/telerik/xaml-sdk/tree/master/GridView/LightweightTemplates)__ - This example demonstrates how to apply lightweight templates for RadGridView.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/features/overview-lightweight-template.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/features/overview-lightweight-template.html
* __[Locate row as you type](https://github.com/telerik/xaml-sdk/tree/master/GridView/LocateRowAsYouType)__ - This example demonstrates how to implement search as you type functionality. The first row to match the search text is scrolled into view.
* __[New row position](https://github.com/telerik/xaml-sdk/tree/master/GridView/NewRowPosition)__ - This example demonstrates how you can configure NewRowPosition property of RadGridView.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/rows/adding-rows.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/rows/adding-rows.html
* __[Read only binding](https://github.com/telerik/xaml-sdk/tree/master/GridView/ReadOnlyBinding)__ - This example demonstrates how to control which rows or cells to be read only.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/how-to/read-only-rows-cells.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/columns/how-to/read-only-rows-cells.html
* __[Row Details Template Selector](https://github.com/telerik/xaml-sdk/tree/master/GridView/RowDetailsTemplateSelector)__ - 
This example demonstrates how you can use the RowDetailsTemplateSelector property of RadGridView to apply different templates based on some value.

Additional information about TemplateSelectors can be found in the following articles: 
	- http://www.telerik.com/help/wpf/gridview-template-selectors-overview.html (WPF)
	- http://www.telerik.com/help/silverlight/gridview-template-selectors-overview.html	(Silverlight)
* __[Expand / Collapse Row Details](https://github.com/telerik/xaml-sdk/tree/master/GridView/RowDetailsVisibilityOptions)__ - 
This example demonstrates how to expand / collapse the RowDetails of the GridView. 
Additional information about the Row Details Visibility feature can be found in the following articles:
WPF: http://www.telerik.com/help/wpf/radgridview-row-details-visibility.html   
SL: http://www.telerik.com/help/silverlight/radgridview-row-details-visibility.html
* __[Row Style Selector](https://github.com/telerik/xaml-sdk/tree/master/GridView/RowStyleSelector)__ - 
This example demonstrates how to style conditionally RadGridView rows using a RowStyleSelector.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/style-selectors/rowstyleselector.html

* __[ScrollIntoViewAsync MVVM](https://github.com/telerik/xaml-sdk/tree/master/GridView/ScrollIntoViewAsyncMvvm)__ - 
This example demonstrates how to create an attached behavior, that allows you to scroll to the newly added item. 
In order to do that ScrollIntoViewAsync method is invoked.
See also:
WPF: http://www.telerik.com/help/wpf/gridview-scroll-item.html
SL: http://www.telerik.com/help/silverlight/gridview-scroll-item.html

* __[Scroll two grids simultaneously](https://github.com/telerik/xaml-sdk/tree/master/GridView/ScrollTwoGridsSimultaneously)__ - 
This example demonstrates how to scroll two GridViews simultaneously.
* __[Select Single Item in Hierarchy](https://github.com/telerik/xaml-sdk/tree/master/GridView/SelectSingleItemHierarchy)__ - 
This example demonstrates how select single item in hierarchical GridView.
* __[Tooltip showing Column's SortDirection](https://github.com/telerik/xaml-sdk/tree/master/GridView/SortDirectionTooltip)__ - 
This example demonstrates how to add a Tooltip for GridViewDataColumn's Header which shows its SortDirection.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/sorting/programmatic.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/sorting/programmatic.html
* __[Sort group by aggregate](https://github.com/telerik/xaml-sdk/tree/master/GridView/SortGroupByAggregate)__ - This example demonstrates how to sort groups by defined aggregate functions. 
You can press the two buttons below RadGridView to test different cases:
 -Sort by first aggregate
 -Sort by second aggregate
 
Note: this example have lightweight templates applied for RadGridView.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/features/overview-lightweight-template.html

* __[Sort group by different property](https://github.com/telerik/xaml-sdk/tree/master/GridView/SortGroupByDifferentProperty)__ - This example demonstrates how to sort groups by different property

Note: this example have lightweight templates applied for RadGridView.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/features/overview-lightweight-template.html
* __[Validation with IDataErrorInfo Interface](https://github.com/telerik/xaml-sdk/tree/master/GridView/ValidationIDataErrorInfo)__ - 
This example demonstrates how to perform validation with IDataErrorInfo Interface.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/features/managing-data-validation.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/features/managing-data-validation.html
* __[Validation with INotifyDataErrorInfo Interface](https://github.com/telerik/xaml-sdk/tree/master/GridView/ValidationINotifyDataErrorInfo)__ - 
This example demonstrates how to perform validation with INotifyDataErrorInfo Interface.
See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radgridview/features/managing-data-validation.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radgridview/features/managing-data-validation.html
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).