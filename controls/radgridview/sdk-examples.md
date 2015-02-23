---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radgridview-sdk-examples
tags: sdk,examples
published: True
position: 1
---

# SDK Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadGridView__.

## List of all RadGridView SDK examples:

{% if site.site_name == 'WPF' %}

* __[Alternation with RowStyleSelector](https://github.com/telerik/xaml-sdk/tree/master/GridView/AlternationRowStyleSelector)__ - 
This example demonstrates how simulate rows alternation with RowStyleSelector.
* __[Auto complete string filter editor](https://github.com/telerik/xaml-sdk/tree/master/GridView/AutoCompleteStringFilterEditor)__ - This example demonstrates how you can extend a string column, so that its field filter editors have the auto-complete functionality
* __[Binding columns from view model](https://github.com/telerik/xaml-sdk/tree/master/GridView/BindingColumnsFromViewModel)__ - This example demonstrates how to implement custom attached behavior in order to bind columns from your view-model for Silverlight and WPF
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
* __[Column chooser](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnChooser)__ - This example demonstrates how to implement custom column chooser in order to hide/show desired columns in RadGridView for Silverlight and WPF
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/features/overview-controlpanel.html
* __[Column Selection](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnSelection)__ - 
This example demonstrates how to select all cells from a column.
* __[Column settings](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnSettings)__ - This example demonstrates usage of different column's properties. You can use the configuration panel on the left to try different setup. 
* __[Columns reorder sync with list box](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnsReorderSyncWithListBox)__ - This example demonstrates how to reorder RadGridView's columns through drag and drop on a ListBox outside RadGridView.
* __[Combobox column](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumn)__ - This example demonstrates how use GridViewComboBoxColumn with the ItemsSource property in RadGridView for Silverlight and WPF.
* __[Combobox column editable](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumnEditable)__ - This example demonstrates how use GridViewComboBoxColumn and allow the user to edit it and add new items for its ItemsSource. The example is available for Silverlight and WPF.
* __[Combobox column items source binding](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumnItemsSourceBinding)__ - This example demonstrates how use GridViewComboBoxColumn with ItemsSourceBinding and FilterMemberPath properties in RadGridView for Silverlight and WPF.
* __[Control panel](https://github.com/telerik/xaml-sdk/tree/master/GridView/ControlPanel)__ - This example demonstrates how you can configure ControlPanelItems for RadGridView
* __[ControlPanel Events](https://github.com/telerik/xaml-sdk/tree/master/GridView/ControlPanelEvents)__ - 
This example demonstrates how to subscribe to events of ControlPanel's button.
* __[Copy paste functionality](https://github.com/telerik/xaml-sdk/tree/master/GridView/CopyPasteFunctionality)__ - This example demonstrates different copy/paste scenarios supported by RadGridView. You can configure ClipboardCopyMode and ClipboardPasteMode through a ContextMenu displayed on right click over the control.
There are also various additional options to be configured on the most right side of the window.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/clipboard/copying.html
http://docs.telerik.com/devtools/wpf/controls/radgridview/clipboard/pasting.html

* __[Create Custom DateTimePicker Column](https://github.com/telerik/xaml-sdk/tree/master/GridView/CreateCustomDateTimePickerColumn)__ - 
This example demonstrates how you can create a custom DateTimePickerColumn column.

Additional information about creating a custom DateTimePickerColumn can be found in the following articles: 
	- http://www.telerik.com/help/wpf/gridview-how-to-create-date-time-picker-column.html (WPF)
	- http://www.telerik.com/help/silverlight/gridview-how-to-create-date-time-picker-column.html (Silverlight)
* __[Custom column](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomColumn)__ - This example demonstrates how to implement custom column inherited from GridViewDataColumn.
* __[Custom column filter descriptor](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomColumnFilterDescriptor)__ - This example demonstrates how you can extend the stock ColumnFilterDescriptor in order to change the filtering expression that it generates.  This expression will be the one used for filtering by our data engine.  This example requires advanced knowledge of LINQ Expression Trees.  You can learn more about LINQ Expression Trees at http://msdn.microsoft.com/en-us/library/bb397951.aspx
* __[Custom filter control](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomFilterControl)__ - This example demonstrates how to create and apply a custom filtering control for RadGridView.
* __[Custom hierarchy using row details](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomHierarchyUsingRowDetails)__ - This example demonstrates how to implement custom hierarchy using row-details and GridViewToggleRowDetailsColumn.
* __[Custom Keyboard Command Provider](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomKeyboardCommandProvider)__ - 
This example demonstrates how predefine the default KeyboardProvider.
* __[Case-InSensitive Distinct Values](https://github.com/telerik/xaml-sdk/tree/master/GridView/DistinctValuesFilteringCaseSensitivity)__ - 
This example demonstrates how make the distinct values in filter.
* __[Expand All RowDetails](https://github.com/telerik/xaml-sdk/tree/master/GridView/ExpandAllRowDetails)__ - 
This example demonstrates how expand all RowDetails.
* __[Filter as you type grid view inside combo box](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilterAsYouTypeGridViewInsideComboBox)__ - This example demonstrates how to implement filter as you type in RadGridView inside RadComboBox.
* __[Filter As You Type With FilterRow](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilterAsYouTypeWithFilterRow)__ - 
This example demonstrates how to search as you type in the FilterRow's TextBoxes.
* __[Filtering on Boolean Property](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilteringBooleanProperty)__ - 
This example demonstrates how to show user-friendly text instead of True and False when filtering boolean property.
* __[States of filtering buttons](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilteringButtonsStates)__ - 
This example demonstrates how to control the enabled and disabled state of the Filter and Close buttons in the FilterngControl.
* __[Filtering collection properties](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilteringCollectionProperties)__ - This example demonstrates how you can extend the stock ColumnFilterDescriptor in order to filter collection properties. This example requires advanced knowledge of LINQ Expression Trees.  You can learn more about LINQ Expression Trees at http://msdn.microsoft.com/en-us/library/bb397951.aspx
* __[Modify ForegroundColor of selected row](https://github.com/telerik/xaml-sdk/tree/master/GridView/ForegroundColorSelectedHoveredRow)__ - 
This example demonstrates how to modify the ForegroundColor of selected/hovered row.
* __[Group selection](https://github.com/telerik/xaml-sdk/tree/master/GridView/GroupSelection)__ - This example demonstrates how to implement group selection.
* __[Image column filtering](https://github.com/telerik/xaml-sdk/tree/master/GridView/ImageColumnFiltering)__ - This example demonstrates how to implement image column distinct values.
* __[Lightweight template for cells](https://github.com/telerik/xaml-sdk/tree/master/GridView/LightweightTemplateForCells)__ - This example demonstrates how to implement custom lightweight template for GridViewCell.
* __[Lightweight templates](https://github.com/telerik/xaml-sdk/tree/master/GridView/LightweightTemplates)__ - This example demonstrates how to apply lightweight templates for RadGridView and RadTreeListView.
* __[Locate row as you type](https://github.com/telerik/xaml-sdk/tree/master/GridView/LocateRowAsYouType)__ - This example demonstrates how to implement search as you type functionality. The first row to match the search text is scrolled into view.
* __[Merged cells](https://github.com/telerik/xaml-sdk/tree/master/GridView/MergedCells)__ - As of Q3 2014 we have introduced support for merged cells in RadGridView control. As a result the serial cells with equal values can be merged vertically or horizontally. 
Each time you click on the "Change Merge Direction" button, the way the cells are merged will change.
For more information please check: http://www.telerik.com/help/wpf/gridview-merged-cells.html
* __[New row position](https://github.com/telerik/xaml-sdk/tree/master/GridView/NewRowPosition)__ - This example demonstrates how you can configure NewRowPosition property of RadGridView
* __[RowDetails TemplateSelector](https://github.com/telerik/xaml-sdk/tree/master/GridView/RowDetailsTemplateSelector)__ - 
This example demonstrates how you can use the RowDetailsTemplateSelector property of RadGridView to apply different templates based on some value.

Additional information about TemplateSelectors can be found in the following articles: 
	- http://www.telerik.com/help/wpf/gridview-template-selectors-overview.html (WPF)
	- http://www.telerik.com/help/silverlight/gridview-template-selectors-overview.html	(Silverlight)
* __[Expand / Collapse RowDetails](https://github.com/telerik/xaml-sdk/tree/master/GridView/RowDetailsVisibilityOptions)__ - 
This example demonstrates how to expand / collapse the RowDetails of the GridView. Additional information about the Row Details Visibility feature can be found in the following article: http://www.telerik.com/help/wpf/radgridview-row-details-visibility.html    http://www.telerik.com/help/silverlight/radgridview-row-details-visibility.html
* __[Row Style Selector](https://github.com/telerik/xaml-sdk/tree/master/GridView/RowStyleSelector)__ - 
This example demonstrates how to style conditionally RadGridView rows using a RowStyleSelector.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/style-selectors/rowstyleselector.html

* __[ScrollIntoViewAsync MVVM](https://github.com/telerik/xaml-sdk/tree/master/GridView/ScrollIntoViewAsyncMvvm)__ - 
This example demonstrates how you can create an attached behavior, that will allow you to scroll to the newly added club. In order to do that the project uses the [ScrollIntoViewAsync() WPF](http://www.telerik.com/help/wpf/gridview-scroll-item.html) / [ScrollIntoViewAsync() Silverlight](http://www.telerik.com/help/silverlight/gridview-scroll-item.html).

* __[Scroll two grids simultaneously](https://github.com/telerik/xaml-sdk/tree/master/GridView/ScrollTwoGridsSimultaneously)__ - 
This example demonstrates how to scroll two GridViews simultaneously.
* __[Select Single Item in Hierarchy](https://github.com/telerik/xaml-sdk/tree/master/GridView/SelectSingleItemHierarchy)__ - 
This example demonstrates how select single item in hierarchical GridView.
* __[Tooltip showing Column's SortDirection](https://github.com/telerik/xaml-sdk/tree/master/GridView/SortDirectionTooltip)__ - 
This example demonstrates how to add a Tooltip for GridViewDataColumn's Header which shows its SortDirection.
* __[Validation with IDataErrorInfo Interface](https://github.com/telerik/xaml-sdk/tree/master/GridView/ValidationIDataErrorInfo)__ - 
This example demonstrates how to perform validation with IDataErrorInfo Interface.
* __[Validation with INotifyDataErrorInfo Interface](https://github.com/telerik/xaml-sdk/tree/master/GridView/ValidationINotifyDataErrorInfo)__ - 
This example demonstrates how to perform validation with INotifyDataErrorInfo Interface.
* __[Various data sources](https://github.com/telerik/xaml-sdk/tree/master/GridView/VariousDataSources)__ - This example demonstrates how to bind RadGridView to different DataSources.
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Alternation with RowStyleSelector](https://github.com/telerik/xaml-sdk/tree/master/GridView/AlternationRowStyleSelector)__ - 
This example demonstrates how simulate rows alternation with RowStyleSelector.
* __[Auto complete string filter editor](https://github.com/telerik/xaml-sdk/tree/master/GridView/AutoCompleteStringFilterEditor)__ - This example demonstrates how you can extend a string column, so that its field filter editors have the auto-complete functionality
* __[Binding columns from view model](https://github.com/telerik/xaml-sdk/tree/master/GridView/BindingColumnsFromViewModel)__ - This example demonstrates how to implement custom attached behavior in order to bind columns from your view-model for Silverlight and WPF
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
* __[Column chooser](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnChooser)__ - This example demonstrates how to implement custom column chooser in order to hide/show desired columns in RadGridView for Silverlight and WPF
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/features/overview-controlpanel.html
* __[Column Selection](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnSelection)__ - 
This example demonstrates how to select all cells from a column.
* __[Column settings](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnSettings)__ - This example demonstrates usage of different column's properties. You can use the configuration panel on the left to try different setup. 
* __[Columns reorder sync with list box](https://github.com/telerik/xaml-sdk/tree/master/GridView/ColumnsReorderSyncWithListBox)__ - This example demonstrates how to reorder RadGridView's columns through drag and drop on a ListBox outside RadGridView.
* __[Combobox column](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumn)__ - This example demonstrates how use GridViewComboBoxColumn with the ItemsSource property in RadGridView for Silverlight and WPF.
* __[Combobox column editable](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumnEditable)__ - This example demonstrates how use GridViewComboBoxColumn and allow the user to edit it and add new items for its ItemsSource. The example is available for Silverlight and WPF.
* __[Combobox column items source binding](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumnItemsSourceBinding)__ - This example demonstrates how use GridViewComboBoxColumn with ItemsSourceBinding and FilterMemberPath properties in RadGridView for Silverlight and WPF.
* __[Control panel](https://github.com/telerik/xaml-sdk/tree/master/GridView/ControlPanel)__ - This example demonstrates how you can configure ControlPanelItems for RadGridView
* __[ControlPanel Events](https://github.com/telerik/xaml-sdk/tree/master/GridView/ControlPanelEvents)__ - 
This example demonstrates how to subscribe to events of ControlPanel's button.
* __[Copy paste functionality](https://github.com/telerik/xaml-sdk/tree/master/GridView/CopyPasteFunctionality)__ - This example demonstrates different copy/paste scenarios supported by RadGridView. You can configure ClipboardCopyMode and ClipboardPasteMode through a ContextMenu displayed on right click over the control.
There are also various additional options to be configured on the most right side of the window.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/clipboard/copying.html
http://docs.telerik.com/devtools/wpf/controls/radgridview/clipboard/pasting.html

* __[Create Custom DateTimePicker Column](https://github.com/telerik/xaml-sdk/tree/master/GridView/CreateCustomDateTimePickerColumn)__ - 
This example demonstrates how you can create a custom DateTimePickerColumn column.

Additional information about creating a custom DateTimePickerColumn can be found in the following articles: 
	- http://www.telerik.com/help/wpf/gridview-how-to-create-date-time-picker-column.html (WPF)
	- http://www.telerik.com/help/silverlight/gridview-how-to-create-date-time-picker-column.html (Silverlight)
* __[Custom column](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomColumn)__ - This example demonstrates how to implement custom column inherited from GridViewDataColumn.
* __[Custom column filter descriptor](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomColumnFilterDescriptor)__ - This example demonstrates how you can extend the stock ColumnFilterDescriptor in order to change the filtering expression that it generates.  This expression will be the one used for filtering by our data engine.  This example requires advanced knowledge of LINQ Expression Trees.  You can learn more about LINQ Expression Trees at http://msdn.microsoft.com/en-us/library/bb397951.aspx
* __[Custom filter control](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomFilterControl)__ - This example demonstrates how to create and apply a custom filtering control for RadGridView.
* __[Custom hierarchy using row details](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomHierarchyUsingRowDetails)__ - This example demonstrates how to implement custom hierarchy using row-details and GridViewToggleRowDetailsColumn.
* __[Custom Keyboard Command Provider](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomKeyboardCommandProvider)__ - 
This example demonstrates how predefine the default KeyboardProvider.
* __[Case-InSensitive Distinct Values](https://github.com/telerik/xaml-sdk/tree/master/GridView/DistinctValuesFilteringCaseSensitivity)__ - 
This example demonstrates how make the distinct values in filter.
* __[Expand All RowDetails](https://github.com/telerik/xaml-sdk/tree/master/GridView/ExpandAllRowDetails)__ - 
This example demonstrates how expand all RowDetails.
* __[Filter as you type grid view inside combo box](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilterAsYouTypeGridViewInsideComboBox)__ - This example demonstrates how to implement filter as you type in RadGridView inside RadComboBox.
* __[Filter As You Type With FilterRow](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilterAsYouTypeWithFilterRow)__ - 
This example demonstrates how to search as you type in the FilterRow's TextBoxes.
* __[Filtering on Boolean Property](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilteringBooleanProperty)__ - 
This example demonstrates how to show user-friendly text instead of True and False when filtering boolean property.
* __[States of filtering buttons](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilteringButtonsStates)__ - 
This example demonstrates how to control the enabled and disabled state of the Filter and Close buttons in the FilterngControl.
* __[Filtering collection properties](https://github.com/telerik/xaml-sdk/tree/master/GridView/FilteringCollectionProperties)__ - This example demonstrates how you can extend the stock ColumnFilterDescriptor in order to filter collection properties. This example requires advanced knowledge of LINQ Expression Trees.  You can learn more about LINQ Expression Trees at http://msdn.microsoft.com/en-us/library/bb397951.aspx
* __[Modify ForegroundColor of selected row](https://github.com/telerik/xaml-sdk/tree/master/GridView/ForegroundColorSelectedHoveredRow)__ - 
This example demonstrates how to modify the ForegroundColor of selected/hovered row.
* __[Group selection](https://github.com/telerik/xaml-sdk/tree/master/GridView/GroupSelection)__ - This example demonstrates how to implement group selection.
* __[Image column filtering](https://github.com/telerik/xaml-sdk/tree/master/GridView/ImageColumnFiltering)__ - This example demonstrates how to implement image column distinct values.
* __[Lightweight template for cells](https://github.com/telerik/xaml-sdk/tree/master/GridView/LightweightTemplateForCells)__ - This example demonstrates how to implement custom lightweight template for GridViewCell.
* __[Lightweight templates](https://github.com/telerik/xaml-sdk/tree/master/GridView/LightweightTemplates)__ - This example demonstrates how to apply lightweight templates for RadGridView and RadTreeListView.
* __[Locate row as you type](https://github.com/telerik/xaml-sdk/tree/master/GridView/LocateRowAsYouType)__ - This example demonstrates how to implement search as you type functionality. The first row to match the search text is scrolled into view.
* __[New row position](https://github.com/telerik/xaml-sdk/tree/master/GridView/NewRowPosition)__ - This example demonstrates how you can configure NewRowPosition property of RadGridView
* __[RowDetails TemplateSelector](https://github.com/telerik/xaml-sdk/tree/master/GridView/RowDetailsTemplateSelector)__ - 
This example demonstrates how you can use the RowDetailsTemplateSelector property of RadGridView to apply different templates based on some value.

Additional information about TemplateSelectors can be found in the following articles: 
	- http://www.telerik.com/help/wpf/gridview-template-selectors-overview.html (WPF)
	- http://www.telerik.com/help/silverlight/gridview-template-selectors-overview.html	(Silverlight)
* __[Expand / Collapse RowDetails](https://github.com/telerik/xaml-sdk/tree/master/GridView/RowDetailsVisibilityOptions)__ - 
This example demonstrates how to expand / collapse the RowDetails of the GridView. Additional information about the Row Details Visibility feature can be found in the following article: http://www.telerik.com/help/wpf/radgridview-row-details-visibility.html    http://www.telerik.com/help/silverlight/radgridview-row-details-visibility.html
* __[Row Style Selector](https://github.com/telerik/xaml-sdk/tree/master/GridView/RowStyleSelector)__ - 
This example demonstrates how to style conditionally RadGridView rows using a RowStyleSelector.
See also:
http://docs.telerik.com/devtools/wpf/controls/radgridview/style-selectors/rowstyleselector.html

* __[ScrollIntoViewAsync MVVM](https://github.com/telerik/xaml-sdk/tree/master/GridView/ScrollIntoViewAsyncMvvm)__ - 
This example demonstrates how you can create an attached behavior, that will allow you to scroll to the newly added club. In order to do that the project uses the [ScrollIntoViewAsync() WPF](http://www.telerik.com/help/wpf/gridview-scroll-item.html) / [ScrollIntoViewAsync() Silverlight](http://www.telerik.com/help/silverlight/gridview-scroll-item.html).

* __[Scroll two grids simultaneously](https://github.com/telerik/xaml-sdk/tree/master/GridView/ScrollTwoGridsSimultaneously)__ - 
This example demonstrates how to scroll two GridViews simultaneously.
* __[Select Single Item in Hierarchy](https://github.com/telerik/xaml-sdk/tree/master/GridView/SelectSingleItemHierarchy)__ - 
This example demonstrates how select single item in hierarchical GridView.
* __[Tooltip showing Column's SortDirection](https://github.com/telerik/xaml-sdk/tree/master/GridView/SortDirectionTooltip)__ - 
This example demonstrates how to add a Tooltip for GridViewDataColumn's Header which shows its SortDirection.
* __[Validation with IDataErrorInfo Interface](https://github.com/telerik/xaml-sdk/tree/master/GridView/ValidationIDataErrorInfo)__ - 
This example demonstrates how to perform validation with IDataErrorInfo Interface.
* __[Validation with INotifyDataErrorInfo Interface](https://github.com/telerik/xaml-sdk/tree/master/GridView/ValidationINotifyDataErrorInfo)__ - 
This example demonstrates how to perform validation with INotifyDataErrorInfo Interface.
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).