---
title: Changes
page_title: Changes
description: Changes
slug: radgridview-changes
tags: changes
published: True
position: 0
---

# Changes

## Latest Release Notes

You can check the latest Release Notes {% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}

## Q1 2015

You can check the {% if site.site_name == 'Silverlight' %}[Release Notes for version Q1 2015.](http://www.telerik.com/support/whats-new/silverlight/release-history/ui-for-silverlight-q1-2015){% endif %}{% if site.site_name == 'WPF' %}[Release Notes for version Q1 2015.](http://www.telerik.com/support/whats-new/wpf/release-history/ui-for-wpf-q1-2015){% endif %}

## Q3 2014
      

__What's Fixed__

* FooterTextAlignment property does not affect group footer cells in Windows8 theme
            

* Expressions with a formula containing column's value when the column is bound to indexer property are not calculated.
            

* (CodedUI) DateTimePicker in Filter2ContentControl (FilteringControl) is not recognized on playback.
            

* StackOverflowException is thrown when performing sorting, filtering or grouping on GridView bound to DynamicObject.
            

* Visible RowDetails get collapsed when maximizing/minimizing the window with GroupRenderMode Flat.
            

* Elements in RadGridView are not recognized by Narrator.
            

* NullReferenceException is thrown in TryGetGenericElementType method when RadGridView is in TabControl and you move to its containing TabItem.
            

* Not all properties are transferred from CopyPropertiesFrom method.
            

* Validation border of validated item is not fully visible in Windows8 theme.
            

* Validation style is not correct in Windows8Touch theme with lightweight templates and validation enabled.
            

* Pasting multiple values in GridViewComboBoxColumn which are not in its source, is not correct for more than one item.
            

* When a row is invalid, SelectionUnit is Cell and lightweight templates are applied the cell content is not correctly aligned.
            

* All types of editors jump into edit mode when lightweight templates are applied.
            

* MouseOver effect of a row goes over selected and validated item when lightweight templates are applied.
            

* An exception is thrown on working with FilteringControl of GridViewComboBoxColumn on touch monitor.
            

* When exporting RadGridView.ToHtml() the Width of a column is not exported.
            

* An exception is thrown when working with FilteringControl of GridViewComboBoxColumn on touch monitor.
            

* ArgumentOutOfRange exception is thrown on scrolling RadGridView with ColumnGroups set after changing the data context.
            

* Cannot set any custom content to filtering distinct values content.
            

* (CodedUI) AutomationProperties AutomationID and Name cannot be customized.
            

* (CodedUI) Peers for elements inside HierarchyChildTemplate are not found.
            

* Cross-thread access exception in ItemsContainerGenrator.
            

* Current cell in the last row is not visible when NewRowPosition property of RadGridView is set to Bottom and Windows8 theme is applied.
            

* FieldFilter Editors do not have AutomationIDs when column is bound to properties of type int, DateTime and enum.
            

* Foreground property of CheckBox in FilteringControl is not applied when setting via simple Style.
            

* GridView AutoScrolling area is now relative to whole GridView instead of ViewPort only.
            

* Horizontal grid line of each row overlaps its cells in Windows8Touch theme.
            

* Numeric GridViewHtmlVisualExportParameters exported wrong based on the CurrentCulture.
            

* RadGridView placed in RadDocking does not process batch PropertyChanges when not in view.
            

* RowDetails can be seen through the row indicator on scrolling horizontally with VisualStudio2013 theme applied.
            

* SelectedCells collection holds non-existing cells after deleting a row.
            

__What's New__

* Introduced cancel editing support of properties added through ICustomTypeDescriptor.
            

* Merged cells – Allows horizontal and vertical auto-merged of cells that have equal values for GridViewDataControl column. RadGridView.MergedCellsDirection property has three values – None, Horizontal and Vertical. GridViewDataColumn.IsCellMergingEnabled property enables or disables cell merging on a column level.
            

## Q2 2014
      
__What's Fixed__

* There is no horizontal scroll bar if you group by a column and all groups are collapsed
          

* Columns data gets overlapped when columns are hidden and shown again
          

* Memory leak when CellStyle is applied to GridViewCheckBoxColumn
          

* IsReorderable of a column is not respected when ReorderColumnsMode is different than the default one
          

* ArgumentOutOfRangeException when scrolling a grouped grid with Flat GroupRenderMode
          

* Cannot insert with Insert key in grouped grid with NewRowPosition Bottom
          

* ArgumentOutOfRandeException in FlatLayoutStrategy.RealizeRows()
          

* InvalidOperationException in FilteringViewModel.ClearFilters()
          

* Once validation is triggered, after editing CalculatorPicker in a CellEditTemplate, you cannot cancel cell/row editing by pressing Esc key
          

* Checkbox editors in all types of GridView columns jump to the left in edit mode
          

* The Item of a SelectedCell is not updated correctly after GridView's ItemsSource is changed
          

* SelectedCells collections is in incorrect state after pasting
          

* NewRow gets misaligned when RadGridView is grouped
          

* RowDetails are shown through the row indicator on scrolling horizontally (Office2013 theme)
          

* Height greater that the default applied to group row when GroupRenderMode is Flat leads to incorrect result
          

* Design time error (NullReferenceException) when implicit themes are used
          

* Group rows borders are not aligned with header row borders in Windows8 theme
          

* Wrong selection when data is real time updated in GroupRenderMode="Flat"
          

* "Element is already a child of another element" exception is thrown when ControlPanelItem has custom content
          

* SelectedCells count is incorrect after selecting all rows
          

* First group top border is missing when there is a new row and it is in edit mode - Windows8 theme
          

* Element is already a child of another element exception is thrown at design time - Windows8, Office2013 themes
          

* RadGridView.SelectedItem binding is broken when SelectionUnit is changed to Cell
          

* Columns data get overlapped after updating simultaneously DisplayIndex and IsVisible properties
          

* Pasted rows are not correct after coping all rows with SelectionMode Extended due to the additional cells that remain in SelectedCells collection
          

* SelectedCells count is not correct when selecting multiple items with Extended mode
          

* Columns and column groups get misaligned after restoring GridView settings using PersistenceFramework
          

* InvalidOperationException in GridViewItemContainerGenerator.LinkContainerToItem()
          

* Only the first cell from SelectedCells remains in the collection after changing the mode to Multiple or Extended
          

* Infinite Layout cycle when UI virtualization is disabled
          

* RadGridView is consuming resources when its IsBusy property is set to False
          

* GridViewCell's ToolTip disappears after leaving edit mode
          

* NullReferenceException in GridViewCell.Editor_Loaded method
          

* NullReferenceException in GridViewCellInfo.ctor
          

* CheckBox content in FilteringControl do not show seconds when parent column is bound to DateTime property
          

* NullRefException in design time in GridViewVirtualizingPanel.DestroyContainers and GridViewVirtualizingPanel.NestedLayoutStrategy
          

## Q1 2014
      
__What's Fixed__

* Content of ValidationToolTip is not properly aligned when ValidatesOnDataErrors is set to "InViewMode"
          

* RadGridView goes into unfocused state when ContextMenu is opened
          

* When all columns in view port become frozen, there is no way to scroll into view any other column
          

* Runtime theme exception - Office2013
          

* NullReferenceException in ConvertMemberAccessExpressionIfNecessary method
          

* When all columns in view port become frozen, there is no way to scroll into view any other column
          

* Scrolling performance is degraded when the RowStyle property is set
          

* Row becomes valid when its invalid cells get out of the viewport (IDataErrorInfo)
          

* GroupPanelBackground cannot be altered through the Office2013 palette
          

* Office2013Theme issues when RadGridView is grouped or a column need to be resized
          

* GridViewDataColumn can be grouped, even though the IsGroupableProperty on that column is set to false and the grid is bound to DynamicObject
          

* GridViewDataColumn can be grouped, even though the IsGroupableProperty on that column is set to false and the grid is bound to DynamicObject
          

* Memory leak when updating the ItemsSource when a grid is bound to DataTable
          

* NullReferenceException in InternalSelectionItemsStorage constructor
          

* NullReferenceException in GridViewCellsPanel.InitializeMeasureData()
          

* GridViewDynamicHyperlinkColumn does not resolve Member paths with dynamics
          

* AgumentOutOfRangeException in RealizeRows when NewRowPosition=Bottom/Top and RadGridView is grouped
          

* RowUnloaded and RowLoaded are fired for each item when CollectionChanged is raised, GroupRenderMode=Flat and row virtualization is turned off
          

* ValidationTooltip shows the error multiple times when CustomValidation attribute is assigned on class level
          

* Partially blank rows in GridView when multiple ViewportChanged events get batched
          

* In flat mode removing last column/s runtime causes incorrect columns arrangement
          

* Grouped grid with a column with * width initially shows horizontal scroll bar
          

* ColumnGroups are not correctly rendered at initial load when RadGridView.RowIndicatorVisibility=”Collapsed”
          

* Cannot insert with Insert key in grouped grid with NewRowPosition="Bottom"
          

* The Background property of GridViewFooterCell does not work correctly
          

* Column groups get misaligned on scrolling after a new column with existing DisplayIndex is added after frozen columns
          

* GridViewToggleButton's Foreground in RadGridView is not correct in Windows8 theme
          

* NullReferenceException in GetEnumerator in QCV
          

You can check the  Release Notes for __Q3 2013 SP1__{% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/support/whats-new/silverlight/release-history/q3-2013-sp1){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/support/whats-new/wpf/release-history/q3-2013-sp1){% endif %}

You can check the  Release Notes for __Q3 2013 SP2__{% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/support/whats-new/silverlight/release-history/q3-2013-sp2){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/support/whats-new/wpf/release-history/q3-2013-sp2){% endif %}

## Q3 2013
      

You can check the  Release Notes for __Q3 2013__{% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes/q3-2013-version-2013-3-1016-432255941.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history/q3-2013-version-2013-3-1016-2120428450.aspx){% endif %}

## Q2 2013
      

You can check the  Release Notes for __Q2 2013__{% if site.site_name == 'Silverlight' %}[here.](http://www.telerik.com/products/silverlight/whats-new/release_notes/q2-2013-version-2013-2-0611-3259441291.aspx#gridview){% endif %}{% if site.site_name == 'WPF' %}[here.](http://www.telerik.com/products/wpf/whats-new/release-history/q2-2013-version-2013-2-0611.aspx#gridview){% endif %}

## Q1 2013
      

You can check the Release Notes for __Q1 2013__{% if site.site_name == 'Silverlight' %}[here.](http://www.telerik.com/products/silverlight/whats-new/release_notes/q1-2013-version-2013-1-0220-963710774.aspx#gridview){% endif %}{% if site.site_name == 'WPF' %}[here.](http://www.telerik.com/products/wpf/whats-new/release-history/q1-2013-version-2013-1-0220.aspx#gridview){% endif %}

## Q3 2012 SP
     
__What's New__ 

* Overloads for the Expand/CollapseHierarchyItem/Items Methods for RadGridView, indicating whether the localSettings of IsExpandable are overridden
          

* GridViewSelectionMode.Mixed
          

* Add/remove functionality if such methods are defined for the custom collection
          

* Typing a letter in GridViewComboBoxColumn will point to the first ComboBox item that starts with the same letter
          

* IsEmpty and IsNotEmpty string filter operators
    
__What's Fixed__       

* GroupHeaderTemplate is not correctly updated while scrolling vertically with virtualization turned on
          

* When scrolling with frozen columns and dynamically added columns, merged headers were sometimes misaligned
          

* Setting IsValid in RadGridView.RowValidating does not mark row as "invalid" when RadGridView.ValidatesOnDataErrors is set to "InViewMode"
          

* AmbiguousMatchException with DataAnnotation Attributes
          

* Drop indicator in group panel was not shown after the last item
          

* GridView headerCell null reference exception when starting drag and column isn't reorderable
          

* In GroupRenderMode=Flat, an empty white space may appear at the bottom of the grid when there is a custom RowHeight defined and the grid is grouped
          

* ReorderColumnMode does not work with DragDropManager modifications
          

* Incorrect rows rendering in grouped scenario when custom control template is used
          

* Row of child GridView is not committed when it loses focus and ActionOnLostFocus is set to CommitEdit
          

* Column Width is not updated on ItemsSource changed
          

* GroupRenderMode cannot be set through a Style
          

* ExcelML "string" type fixed to "String"
          

* Missing vertical borders for cells after column reordering due to a pixel overlapping with the neighbor cell
          

* MoveCurrentToNext results in an exception if the current item is the last one
          

* The FilterEditor placeholder control receives focus when tabbing and it really should not
          

* When bound to a collection of ICustomTypeDescriptors, RadGridView cannot correctly resolve dotted property names in some cases
          

* Validation issue when ValidatesOnDataErrors is set to "InViewMode"
          

* GridView can reorder columns even if the datacontrol has CanUserReorderColumns set to false
          

* Exception is thrown when exporting ComboBox column with headers
          

* When SelectionMode is Extended and GridViewRow is resized to increase its height the row below is selected
          

* Container for newly added row is incorrectly used for another item
          

* When invalid value is committed cancel edit cannot be performed
          

* The frozen indicator does not appear when CanUserFreezeColumns is set initially to False and it’s changed to True runtime
          

* Examples Row Reordering - When dragging the last item of the GridView before the second last one, it does not reorder
          

* Incorrect width rendered for merged headers when frozen columns set on horizontal scroll
          

* At certain pixel positions borders between common headers in RadGridView became invisible due to layout rounding
          

* Column remained hidden after ungrouping in case the user toggled the ShowColumnWhenGrouped property runtime
          

## Q3 2012
      
__What's New__ 

* Flat strategy for grouped scenario (GroupRenderMode property)
          

* ShowGroupHeaderColumnAggregates feature (Only for Flat mode)
          

* touch support (scrolling)
          

* CanUserSortGroups property
          

* DisplayFormat NullDisplayText support
          

* GridView AutoScrolling implemented
          

* Virtualization for merged headers added. Improved initial load time and scrolling performance
          
__What's Fixed__ 

* The filtering drop down stops working after column reordering when there is HeaderCellStyle defined
            

* A NullReferenceException connected with row resizing may be thrown when a row is being recycled
            

* The filter row view model for a given column is not properly disposed when the column is removed which might lead to unhandled exceptions
            

* Setting a theme directly on RadGridView breaks the filtering of columns which were not initially in the viewport
            

* The Filtering and Filtered events are not raised when the field filter logical operator is changed from AND to OR or vice versa
            

* The Filtering and Filtered events are fired twice when the Clear button is clicked and there are two active field filters combined with an OR
            

* Memory leak for DoubleClick event
            

* Exception on theme change with custom Header/Footer
            

* SelectedItem binding does not work at first time (when set before RadGridView.DataLoad)
            

* SelectedUnfocusedState improved for all themes
            

* UnfocusedSelected state is lost on scrolling in grouped scenario
            

* Wrong selection state combining actions select item, unfocus grid, scroll grid
            

* Copying is disabled when selecting items through dragging (SelectionMode="Extended")
            

* ArgumentOutOfRange exception when navigate a grid in SL Out-of-browser application
            

* Child items are not removed when the parent item is removed
            

* A design-time exception in grouped and sorted scenarios
            

* HeaderCheckBoxStyle not applied properly
            

* InvalidCastException occurs when clear group descriptor in DataLoadMode="Asynchronous"
            

* IsRowValid does not get updated when a DataAnnotationValidation error gets fixed externally (ViewMode)
            

* Scrolling performance of grouped grid improved
            

* When GridViewRow template is predefined and there is no SelectedUnfocusedState, the item is visually not selected
            

* Layout cycles when EnableRowVirtualization is set to false
            

* RadGridView erroneously displayed the type of a property, even when the ToString() was overridden in the class for that property
            

* Changing Language property is not respected
            

* Exception when dynamically adding a column group that does not have a matching column
            

* Incorrect recycling of the bottom visible item
            

* Issues when using MaskedInput controls in CellEditTemplates
            

* Aggregate function applied twice in the Column Footer when a function is reused for more than one column
            

* When bound to CollectionViewSource all cells in a combo box column displayed the same values after edit (in a theme different than Office_Black)
            

* Scrolling orientation of common headers was not correctly set for the virtualized items
            

* When a column's custom FilteringControl is replaced with a new one at runtime, a reference to the old one remains which leads to incorrect behavior
            

* Validation issue when ValidatesOnDataErrors is set to "InViewMode"
            

* Focus issue with TextBox in CellTemplate and theme is different from Office_Black e.NewValue inside CellValidating event args is not set properly when fast scrolling is performed (via KeyDown)
            

* A visual gap occurred in hierarchy at the level of the column groups
            

* RadGridView would not insert new row more than once when the row is custom templated (custom row layout) and has no cells
            

* Current cell scrolled horizontally in certain situations, even when under frozen column
            

* OnGroupPanel drop always request grouping with SortDirection "Ascending"
            

* Broken IsVisible Binding if you set IsFilterable to False
            

* Error "Warning as Error: Possible unintended reference comparison"
            

* Null reference exception within FooterCellBase class
            

* GridView Header Cell Content DependencyObject
            

* Incorrect behavior when child grid (within RowDetails) is focused - parent row is committed
            

* RadGridView evaluates Binding when exporting HeaderContent
            

* RadGridView does not recalculate correctly widths of "star" columns with disabled row virtualization
            

* RadGridView does not refresh cell's valid state correctly (via INotifyDataErrorInfo)
            

* RadGridView did not take care of delayed column width computation and renderer insufficient count of common headers
            

* Validation for newly added row and ValidatesOnDataErrors = "InViewMode" does not work on cell level
            

* RadGridView shows new row for Insert if CancelEdit was performed
            

* GridView Column width SizeToCells not reducing width fix
            

* Designer crashes on adding reference to TWCGridView dll
            

* No scroll bars are displayed on adding columns, changing their visibility or making a column wider
            

## Q2 2012 SP2
      

* CanUserSortGroups property addeds
          
__What's Fixed__ 
      

* RadGridView __erroneously displayed the type of a property__, even when the ToString() was overridden in the class for that property.
          

* Changing __Language property is not respected__.
          

* Exception when dynamically __adding a column group__ that does not have a matching column.
          

* __Incorrect recycling__ of the bottom visible item.
          

* Issues when using __MaskedInput__ controls in __CellEditTemplates__.
          

* __Aggregate function__ applied twice in the Column Footer when a function is reused for more than one column.
          

* When bound to __CollectionViewSource__ all cells in a combo box column displayed the same values after edit (in a theme different than Office_Black)
          

* Scrolling orientation of common headers was not correctly set for the virtualized items.
          

* When a column's __custom FilteringControl__ is replaced with a new one at runtime, a reference to the old one remains which leads to incorrect behavior.
          

* Validation issue when __ValidatesOnDataErrors__ is set to "InViewMode".
          

* Focus issue with __TextBox in CellTemplate__ and theme is different from Office_Black e.NewValue inside CellValidating event args is not set properly when fast scrolling is performed (via KeyDown).
          

* A visual gap occurred in hierarchy at the level of the __column groups__.
          

* RadGridView would not insert new row more than once when the row is custom templated (__custom row layout__) and has no cells.
          

* __Current cell scrolled__ horizontally in certain situations, even when under frozen column.
          

*  __OnGroupPanel drop__ always request grouping with SortDirection "Ascending".
          

* Broken __IsVisible Binding__ if you set IsFilterable to False.
          

* __Error__ "Warning as Error: Possible unintended reference comparison".
          

* Language property of the parent FrameworkElement is not respected. Changing Language property is not respected.
          

* Null reference exception within FooterCellBase class.
          

*  GridView Header Cell Content DependencyObject.
          

* Incorrect behavior when child grid (within RowDetails) is focused - __parent row is committed__.
          

* Language property is not set properly.
          

## Q2 2012 SP1
      

* __CUIT__ improved.
          

* Virtualization for merged headers. Improved initial load time and scrolling performance
          
__What's Fixed__ 
      

* The filtering drop down stops working after column reordering when there is __HeaderCellStyle__ defined
          

* __EnumDataSource__ does not respect the __DisplayAttribute.Order__ property of enum members when generating the view models
          

* A __NullReferenceException__ connected with row resizing may be thrown when a row is being recycled
          

* The filter row view model for a given column is not properly disposed when the column is removed which might lead to unhandled exceptions
          

* Setting a theme directly on __RadGridView__ breaks the filtering of columns which were not initially in the viewport
          

* The __Filtering__ and __Filtered__ events are not raised when the field filter logical operator is changed from __AND__ to __OR__ or vice versa
          

* The __Filtering__ and __Filtered__ events are fired twice when the __Clear button__ is clicked and there are two active field filters combined with an __OR__

* Memory leak for __DoubleClick__ event
          

* Exception on theme change with custom __Header__/__Footer__

* __SelectedItem__ binding does not work at first time (when set before __RadGridView.DataLoad__) __SelectedUnfocusedState__ improved for all themes
          

* __UnfocusedSelected__ state is lost on scrolling in grouped scenario
          

* Wrong selection state combining actions select item, unfocus grid, scroll grid
          

* Copying is disabled when selecting items through dragging (__SelectionMode="Extended"__)
          

* __CancelEdit__ for the newly added item does not remove the item from changed items collection
          

* Child items are not removed when the parent item is removed
          

* A design-time exception in grouped scenarios
          

* __InvalidCastException__ occurs when clear group descriptor in __DataLoadMode="Asynchronous"____IsRowValid__ does not get updated when a __DataAnnotationValidation__ error gets fixed externally (__ViewMode__)
          

* __OutOfMemory__ exception when __RadGridView__ try to load large dataset in .NET3.5 Scrolling performance of grouped grid improved
          

*  When __GridViewRow__ template is predefined and there is not __SelectedUnfocusedState__, the item is visually not selected Layout cycles when __EnableRowVirtualization__ is set to false is now fixed.
          


## Q2 2012
      
__What's New__ 

* Delete key behavior with __RadGridView.SelectionUnit = "Cell"__ improved.
          

* Merged headers scrolling performance optimization.
          

* Option to leave the __frozen columns splitter__ visible, even when the user is not allowed to freeze columns.
          

* Insert in paged scenario now improved.
          

* Validation improvement to support better various validation scenarios.
          

* Frozen column splitter behavior improved.
          

* __Merged headers__ will now create an empty merged header, rather than raising an exception when group name is empty.
          

* __GetRowForItem(dataItem)__ method of __GridViewDataControl__ is now public.
          

* Distinct value list behavior improved.
          

* __TimeSpan__ property filtering support
          

* Filter-row new feature
          

* __GroupPanelItemStyle__ and __GroupPanelStyle__ mechanism improved.
          

* GridViewRow SelectedUnfocused state
          

* __CheckBoxStyle__ and __HeaderCheckBoxStyle__ properties added for __GridViewSelectColumn__.
          

* __GridViewHeaderCell__ states improved when the grid is sorted and filtered.
          
__What's Fixed 
      

* Wrong background of frozen column splitter in __Expression_Dark__ theme is now fixed.
          

* Setting display indices in reverse order for columns in XAML results in exception is now fixed.
          

* The last item cannot be selected while scrolling with down key.
          

* The __DataMemberBinding____IValueConverter__ is used when the column has __GroupMemberPath__ defined is now fixed.
          

* Star columns were not recalculated properly on resize is now fixed.
          

* White spaces appear on deleting items in grouped scenario is now fixed.
          

* Wrong background of frozen column splitter in __Expression_Dark__ theme is now fixed.
          

* __Frozen column splitter__ not correctly positioned in __Metro__ theme is now fixed.
          

* Copy and Paste commands are executed if other modifiers than Control are pressed is now fixed.
          

* Cells not rendering in Expression Dark with many columns is now fixed.
          

* Last item not updated correctly when property changed is now fixed.
          

* Continuously calling of __RadGridView.BeginInsert()__ results in more than one rows in edit mode is now fixed.
          

* Additional white spaces are added to the header row data when copy /pasting in certain scenarios are now fixed.
          

* Expand group row with no columns throws exception is now fixed.
          

* The default filter operators are not honored when the Clear button is clicked is now fixed.
          

* Changing the Field Filter Logical Operator of a column with __IsFilteringDeferred="True"__ now works properly.
          

* __RowActivated__ event is fired on a single click in Silverlight 4 is now fixed.
          

* Item is not scrolled into view properly when the grid is grouped is now fixed.
          

* Cannot edit properly new items when __RadGridView__ is bound to dynamic data is now fixed.
          

* Group panel connecting arrow remained visible for the first item is now fixed.
          

* __GridViewCheckBoxColumn____CheckBox__ styles fixed.
          

* Pasting is not performed on __ClipboardPasteMode="AllSelectedCells"__ is now fixed.
          

* Design-time exception when refer implicit theme is now fixed.
          

* __Footers__ not exported when no aggregate functions were defined is now fixed.
          

* __IsTabStop__ is set incorrectly to false in some cases is now fixed.
          

* The grid creates new items on paste even when __CanUserInsertRows__ is set to false is now fixed.
          

* Fixed a null reference exception in __CreateCellAutomationPeer__.
          

* Fixed a null reference exception in __CreateCellAutomationPeer__.
          

* __CurrentItem__ is lost on changing the __ItemsSource__ is now fixed.
          

* Null reference exception when binding to __CompositeCollection__ is now fixed.
          

* Some items are not loaded when parent container is resized is now fixed.
          

* Converter will be called with null for __ConverterParameter__ is now fixed.
          

* Hidden columns show a gap after grouping by this column is now fixed.
          

* Misalignment on merged headers when scrolling to the left with frozen columns now fixed.
          

* Exception with __ShowColumnWhenGroupedBy__ when user groups runtime is now fixed.
          



## Q1 2012
      

__NOTE!!!__

__Filtering BREAKING CHANGES !!!__

__NOTE!!!__

In order to enable filtering for our GridViewExpressionColumn, we had to rewrite our entire filtering infrastructure from scratch. We have made as __few breaking changes__ as possible, but some of them were inevitable, for which we would like to apologize. Here is the list of breaking changes that you should be aware of. Do not hesitate to write us if you are having problems with upgrading your project. We will do our best to assist you.
        

* The __IFilteringControl.Prepare__ method now expects the more general type __GridViewColumn__ instead of a __GridViewBoundColumnBase__ as its argument. If you were relying on GridViewBoundColumnBase-specific methods or properties you will have to add a check and a cast.
          

* The __GridViewDistinctValuesLoadingEventArgs.Column__ property is now of the more general type __GridViewColumn__. If you were relying on __GridViewBoundColumnBase__-specific methods or properties you will have to add a check and a cast in your __DistinctValuesLoading__ event handler.
          

* The __GridViewDataControl.GetDistinctValues__ family of methods now accept a __GridViewColumn__ instead of an IDataFieldDescriptor as their first parameter.
          

* The __EditorCreatedEventArgs.Column__ is now of the more general type __GridViewColumn__. __If you were relying on GridViewBoundColumnBase__-specific methods or properties you will have to add a check and a cast in your __DistinctValuesLoading__ event handler.
          

* The __FilterOperatorsLoadingEventArgs.Column__ property is now of type __GridViewColumn__ instead of __IDataFieldDescriptor__.
          

* The __ColumnFilterDescriptor__ class has been made internal. Use the __IColumnFilterDescriptor__ interface instead. It contains all relevant properties and methods.
          

* You can't directly instantiate a __ColumnFilterDescriptor__ anymore since the class has been made internal. When you access the __GridViewColumn.ColumnFilterDescriptor__  property, it will be automatically created on demand by the column and you will be given an __IColumnFilterDescriptor__  to work with. For [example]({%slug radgridview-filtering-icolumn-filter-descriptors%}): __IColumnFilterDescriptor cfd = myColumnInstance.ColumnFilterDescriptor;__

* The __IColumnFilterDescriptor.Column__ property is now of type __GridViewColumn__ instead of __IDataFieldDescriptor__.
          

* The __IColumnFilterDescriptor.DistinctFilter__ property is now of type __IDistinctValuesFilterDescriptor__ instead of __DistinctValuesFilterDescriptor__.
          

* The __IColumnFilterDescriptor.FieldFilter__ property is now of type __IFieldFilterDescriptor__ instead of __FieldFilterDescriptor__.
          

* The __DistinctValuesFilterDescriptor__ class has been made internal. It is not supposed to be used directly from your code. Use the __IDistinctValuesFilterDescriptor__ interface instead.
          

* The __FieldFilterDescriptor__ class has been made internal. It is not supposed to be used directly from your code. Use the __IFieldFilterDescriptor__ interface instead.
          

* If you were using code from the __GridViewCustomSerialization PersistenceFramework__ example, please update it according to the updated example.
          

* The __GridViewDataControl.OnFiltering__ method is marked as __obsolete__ now. It is not supposed to be used directly from your code and will be made internal in a future realease.
          

* The __GridViewDataControl.OnFiltered__ method is marked as __obsolete__ now. It is not supposed to be used directly from your code and will be made internal in a future realease.
          

Some __code changes__ are needed after the __upgrade__. Find the list with code snippets below.

* __Filtering a Column____Before:__

#### __C#__

{{region cs-radgridview-changes_0}}

	    GridViewColumn ageColumn = this.radGridView.Columns["Age"];
	    ColumnFilterDescriptor ageColumnFilter = new ColumnFilterDescriptor(ageColumn);
	    // ...
	    ageColumnFilter.DistinctFilter.DistinctValues.Add(5);
	    ageColumnFilter.FieldFilter.Filter1.Operator = FilterOperator.IsLessThan;
	    ageColumnFilter.FieldFilter.Filter1.Value = 10;
	    // ...
	    this.radGridView.FilterDescriptors.Add(ageColumnFilter);
	{{endregion}}



#### __VB.NET__

{{region vb-radgridview-changes_1}}

	    Dim ageColumn As GridViewColumn = Me.radGridView.Columns("Age")
	    Dim ageColumnFilter As New ColumnFilterDescriptor(ageColumn)
	    ' ...
	    ageColumnFilter.DistinctFilter.DistinctValues.Add(5)
	    ageColumnFilter.FieldFilter.Filter1.[Operator] = FilterOperator.IsLessThan
	    ageColumnFilter.FieldFilter.Filter1.Value = 10
	    ' ...
	    Me.radGridView.FilterDescriptors.Add(ageColumnFilter)
	#End Region
	
	#Region "radgridview-changes_3"

	    Dim ageColumn As GridViewColumn = Me.radGridView.Columns("Age")
	    ' Getting it from the property will create it and associate it with its column automatically.
	    Dim ageColumnFilter As IColumnFilterDescriptor = ageColumn.ColumnFilterDescriptor
	    ageColumnFilter.SuspendNotifications()
	    ' ...
	    ageColumnFilter.DistinctFilter.AddDistinctValue(5)
	    ageColumnFilter.FieldFilter.Filter1.[Operator] = FilterOperator.IsLessThan
	    ageColumnFilter.FieldFilter.Filter1.Value = 10
	    ' ...
	    ' There is no need to manually add the column filter to this.radGridView.FilterDescriptors
	    ' When the column filter is activated/deactivated it is automatically added/removed to this collection.
	    ageColumnFilter.ResumeNotifications()
	#End Region
	
	#Region "radgridview-changes_5"
	    Me.radGridView.FilterDescriptors.Remove(columnFilterDescriptor)
	#End Region
	
	#Region "radgridview-changes_7"
	    ' Calling ClearFilter will automatically remove filter descriptor from the grid.
	    myColumn.ClearFilters()
	#End Region
	
	#Region "radgridview-changes_9"
	    Me.radGridView.FilterDescriptors.Clear()
	#End Region
	#Region "radgridview-changes_11"
	    Me.radGridView.FilterDescriptors.SuspendNotifications()
	    For Each column As var In Me.radGridView.Columns
		    column.ClearFilters()
	    Next
	    Me.radGridView.FilterDescriptors.ResumeNotifications()
	    End Class
	#End Region

__After:__

#### __C#__

{{region radgridview-changes_2}}

	    GridViewColumn ageColumn = this.radGridView.Columns["Age"];
	    // Getting it from the property will create it and associate it with its column automatically.
	    IColumnFilterDescriptor ageColumnFilter = ageColumn.ColumnFilterDescriptor;
	    ageColumnFilter.SuspendNotifications();
	    // ...
	    ageColumnFilter.DistinctFilter.AddDistinctValue(5);
	    ageColumnFilter.FieldFilter.Filter1.Operator = FilterOperator.IsLessThan;
	    ageColumnFilter.FieldFilter.Filter1.Value = 10;
	    // ...
	    // There is no need to manually add the column filter to this.radGridView.FilterDescriptors
	    // When the column filter is activated/deactivated it is automatically added/removed to this collection.
	    ageColumnFilter.ResumeNotifications();
	{{endregion}}



#### __VB.NET__

{{region vb-radgridview-changes_3}}

	    Dim ageColumn As GridViewColumn = Me.radGridView.Columns("Age")
	    ' Getting it from the property will create it and associate it with its column automatically.
	    Dim ageColumnFilter As IColumnFilterDescriptor = ageColumn.ColumnFilterDescriptor
	    ageColumnFilter.SuspendNotifications()
	    ' ...
	    ageColumnFilter.DistinctFilter.AddDistinctValue(5)
	    ageColumnFilter.FieldFilter.Filter1.[Operator] = FilterOperator.IsLessThan
	    ageColumnFilter.FieldFilter.Filter1.Value = 10
	    ' ...
	    ' There is no need to manually add the column filter to this.radGridView.FilterDescriptors
	    ' When the column filter is activated/deactivated it is automatically added/removed to this collection.
	    ageColumnFilter.ResumeNotifications()
	#End Region
	
	#Region "radgridview-changes_5"
	    Me.radGridView.FilterDescriptors.Remove(columnFilterDescriptor)
	#End Region
	
	#Region "radgridview-changes_7"
	    ' Calling ClearFilter will automatically remove filter descriptor from the grid.
	    myColumn.ClearFilters()
	#End Region
	
	#Region "radgridview-changes_9"
	    Me.radGridView.FilterDescriptors.Clear()
	#End Region
	#Region "radgridview-changes_11"
	    Me.radGridView.FilterDescriptors.SuspendNotifications()
	    For Each column As var In Me.radGridView.Columns
		    column.ClearFilters()
	    Next
	    Me.radGridView.FilterDescriptors.ResumeNotifications()
	    End Class
	#End Region



* __Clearing a Column Filter____Before:__

#### __C#__

{{region radgridview-changes_4}}

	    this.radGridView.FilterDescriptors.Remove(columnFilterDescriptor);
	{{endregion}}

__After:__

#### __C#__

{{region cs-radgridview-changes_6}}

	    // Calling ClearFilter will automatically remove filter descriptor from the grid.
	    myColumn.ClearFilters();
	{{endregion}}



* __Clearing All RadGridView Filters____Before:__

#### __C#__

{{region cs-radgridview-changes_8}}

	    this.radGridView.FilterDescriptors.Clear();
	{{endregion}}

__After:__

#### __C#__

{{region cs-radgridview-changes_10}}

	    this.radGridView.FilterDescriptors.SuspendNotifications();
	    foreach (var column in this.radGridView.Columns)
	    {
		    column.ClearFilters();
	    }
	    this.radGridView.FilterDescriptors.ResumeNotifications();
	{{endregion}}



#### __VB.NET__

{{region vb-radgridview-changes_11}}

	    Me.radGridView.FilterDescriptors.SuspendNotifications()
	    For Each column As var In Me.radGridView.Columns
		    column.ClearFilters()
	    Next
	    Me.radGridView.FilterDescriptors.ResumeNotifications()
	    End Class
	#End Region



## Q3 2011
      
__What's New__ 

* [FilterOperatorsLoading](58E28F2D-0079-457E-AD57-EB837D43C2BE#Events) event for the RadGridView.
          

* Support for IEditableCollectionViewAddNewItem interface.
          

* [Merged column headers](156FD9F4-FC2C-471A-A3A5-EECE86AAAA7F#Merging_The_Headers) (column groups).
          

* DynamicObject editing support.
          

* Error indicator tooltip for GridViewRow and GridViewNewRow.
          

* RadGridView.RowDetailsVisibilityChanging event.
          

* API for scrolling item into view by item's index
          

* Deferred filtering mode (GridViewColumn has two new properties now - __IsFilteringDeferred__ and __ShowFilterButton__)
          

* Missing resources in the external themes
          

* Partial binding support for column group and sort descriptors
          

* RowResizing/RowResized events
          

* Special localizable representations for null and string.Empty values in the distinct values list. The respective resource keys are "GridViewFilterDistinctValueStringEmpty" and "GridViewFilterDistinctValueNull" respectively
          

* New property [MatchCaseVisibility](1C8AABBD-E451-4FFA-8EC7-B37C95C7F7AE#MatchCaseVisibility) to the StringFilterEditor
          

* Added comparison filtering (>, >=, <, >=) for TimeSpan values
          



## Q3 2010 SP1
      
__What's New__ 

* [GetValueForItem()]({%slug radgridview-columns-column-types-boundcolumnbase%}) method added for GridViewExpressionColumn and GridViewBoundColumnBase
          

* A __ColumnFilterDescriptor__ property to GridViewFilteringEventArgs and GridViewFilteredEventArgs
          


##  Q3 2010 (Version Number: 2010.3.1110)
      
__What's New__ 

* [SelectionChanging]({%slug gridview-selection-events%}) event which allows you to cancel the selection
          

* [GridViewExpressionColumn]({%slug gridview-expression-column%}) which allows you to display various calculations in the RadGridView itself
          

* [PreparingCellForEdit](7928EA2C-360A-4C57-ACBF-0BFC155E955A#PreparingCellForEdit_Event) and [PreparedCellForEdit](7928EA2C-360A-4C57-ACBF-0BFC155E955A#PreparedCellForEdit_Event) events of RadGridView. They help you manipulate the editing element just before the actual edit.
          

* RowDetails are visible when adding new row
          

* Selection keyboard shortcuts for Mac (via KeyboardModifiers)
          

* Full Copy/Paste support on Mac
          

* [TextInput]({%slug gridview-managing-data-updating-entry%}) EditTrigger which will allow focused cell to enter into edit mode on text input.
          

* __CellLoaded__ and __CellUnloaded__ events.
          

* Tab navigation inside RowDetails and cells
          

* TripleClick functionality (select all text on triple click) for all textboxes created by RadGridView (when cell enters into edit mode). 



## Q2 2010 SP2 (Version Number: 2010.2.924)
     
__What's New__  

* __ValidatesOnDataErrors__ property which can switch validation modes (InViewMode, InEditMode).
          

* [IsReadOnlyBinding]({%slug gridview-read-only-rows-cells%}) property for RadGridView and GridViewBoundColumnBase.
          

* Caching to __GridViewComboBox__ column elements.
          

* Select the whole content in the textboxes on TripleClick in Edit mode.
          

* TAB navigation inside RowDetails and cells.
          

* [Copied]({%slug gridview-copying%}) and [Pasted]({%slug gridview-pasting%}) events.
          

* Copy & Paste commands are now handled by the KeyboardCommandProvider instead of the OnKeyDown override.
          

*  Exporting numbers to ExcelML now always uses InvariantCulture
          

* [Bug-fixes](http://www.telerik.com/products/silverlight/whats-new/release-history/q2-2010-sp2-version-2010-2-0924.aspx)[Bug-fixes](http://www.telerik.com/products/wpf/whats-new/release-history/q2-2010-sp2-version-2010-2-0924-762081665.aspx){% if site.site_name == 'WPF' %}{% endif %}



## Q2 2010 SP1 (Version Number: 2010.2.812)
      
__What's New__ 

* [SkipHiddenColumns]({%slug gridview-pasting%}) flag to the ClipboardPasteMode enumeration.
          

* HierarchyExpandButtonStyle and HierarchyExpandButtonStyleSelector for GridViewDataControl
          

* [ShouldEncodeValue](#exporting) property to GridViewElementExportingEventArgs
          

* RowIsExpandedChanged event to GridViewDataControl
          

* ExpandHierarchyItem and CollapseHierarchyItem commands
          

* [GridViewBoundColumnBase.FilteringControlStyle]({%slug radgridview-columns-column-types-boundcolumnbase%})

* New design for current row indicator
          

* [GridViewColumn.ShowFieldFilters]({%slug radgridview-columns-column-types-basic-column%}) property
          

* [Bug-fixes](http://www.telerik.com/products/silverlight/whats-new/release-history/q2-2010-sp1-version-2010-2-0812.aspx)[Bug-fixes](http://www.telerik.com/products/wpf/whats-new/release-history/q2-2010-sp1-version-2010-2-0812-2056448248.aspx)



## Q2 2010 (Version Number: 2010.2.714)
      
__What's New__ 

*  __cell selection__. Now you can select a single cell or individual cells as opposed to selecting the full row. The corresponding new properties are: [SelectionUnit](95D98659-5436-4CF0-8CEC-7C16469C3F61#selectionUnits), [SelectedItems](FF215C19-F399-4BDD-8E79-802D282DD583#selectedItems), [GridViewCellInfo](FF215C19-F399-4BDD-8E79-802D282DD583#selectedCells). The corresponding new event is: [SelectedCellChanged]({%slug gridview-selection-events%}).
          
*  __clipboard support - now you can easily copy and paste cells to/from Excel and/or another GridView__. Please read more [here](http://blogs.telerik.com/silverlightteam/posts/10-07-05/introducing-cell-copy-paste-in-radgridview-for-wpf-silverlight.aspx).
          

* RadGridView.__PreparingCellForEdit__ event.
          

* Property __ShowHeaderAggregates__ of GridViewGroupRow to hide/show group header aggregates.
          

* [CellStyleSelector]({%slug gridview-cell-style-selector%}) and GroupFooterCellStyleSelector for GridViewColumn.
          

* AlternateRowStyleSelector, GroupFooterRowStyleSelector, GroupRowStyleSelector, RowDetailsStyleSelector and [RowStyleSelector]({%slug gridview-rowstyleselector%}) for GridViewDataControl.
          

* HierarchyChildTemplateSelector for GridViewDataControl.
          

* GroupHeaderTemplateSelector, GroupFooterTemplateSelector and ToolTipTemplateSelector for GridViewColumn.
          

* RowDetailsTemplateSelector for GridViewDataControl.
          

* CellTemplateSelector and CellEditTemplateSelector DataTemplateSelectors for GridViewColumn.
          

* [Bug-fixes](http://www.telerik.com/products/silverlight/whats-new/release-history/q2-2010-version-2010-2-0714-183628555.aspx)[Bug-fixes](http://www.telerik.com/products/wpf/whats-new/release-history/q2-2010-version-2010-2-0714.aspx)

## Q1 2010 SP2 (Version Number: 2010.1.603)
      
__What's New__ 

*  [ItemTemplate](#itemTemplate) property to GridViewComboBoxColumn.
          

* [ColumnWidthChanged and ColumnWidthChanging]({%slug gridview-column-resize-event%}) events.
          

* [GridViewCsvExportOptions]({%slug gridview-export%}) type to control exporting in CSV format.
          

* [ElementExporting and ElementExported]({%slug gridview-export-events%}) events.
          

* __CurrentCellInfo__ class which allows you to [set the current cell]({%slug gridview-how-to-set-current-cell%}).
          

* [GridViewCheckBox]({%slug gridview-checkbox-column%}) column which performs better when the underlying data is of type boolean
          

* [Bug-fixes](http://www.telerik.com/products/silverlight/whats-new/release-history/q1-2010-sp2-version-2010-1-0603.aspx)[Bug-fixes](http://www.telerik.com/products/wpf/whats-new/release-history/q1-2010-sp2-version-2010-1-0603-773983963.aspx)



## Q1 2010 SP1 (Version Number: 2010.1.0422)
      
__What's New__ 

* Built against the official Silverlight 4 version (4.0.50401.0)
          

* [Bug-fixes](http://www.telerik.com/products/silverlight/whats-new/release-history/q1-2010-sp1-version-2010-1-0422.aspx)[Bug-fixes](http://www.telerik.com/products/wpf/whats-new/release-history/q1-2010-sp1-version-2010-1-0422-777131095.aspx)

## New or improved features:

* Added support for BorderBrush and BorderThickness for GridViewRow.
          

* Editable field filter logical composition operator (And/Or).
          

* New overload of the GridViewDataContro.GetDistinctValues method that accepts the number of distinct values to return as a parameter.
          

* Group footer row now uses its Item as aggregate source.
          

* HorizontalContentAlignment property of the GridViewGroupRow now properly aligns the AggregateResultsList. There is no need to edit GroupRowTemplate to position aggregates to the left or right.
          

* The GridViewFooterCell and GridViewGroupFooterCell had incorrect padding which are now removed. The text in those cells is now properly aligned with the one in the GridViewCell 

## Q1 2010 (Version Number: 2010.1.0309)
      

* [Bug-fixes](http://www.telerik.com/products/silverlight/whats-new/release-history/q1-2010-version-2010-1-0309.aspx)[Bug-fixes](http://www.telerik.com/products/wpf/whats-new/release-history/q1-2010-version-2010-1-0309-1209734456.aspx)

* All RadControls skins now get a major facelift. Your custom themes might not work as expected. 

## New properties and methods:

* New Feature: [RadDataPager]({%slug radgridview-paging-using-telerik-raddatapager%})

* New Property: KeyboardCommandProvider
          

* GroupHeaderTemplate property for GridViewColumn
          

* Support for the Shift + Enter navigation
          

* New Feature: GridViewToggleRowDetailsColumn.ExpandMode.
          

* SelectedItem is now the first item that appears in the SelectedItems collection
          

* Group ItemsSource is set when the group is expanded (performance improvement - Lazy Load content)
          

* Overload of ScrollIntoViewAsync method for horizontal scrolling.
          

* CurrentColumn property
          

* Programmatically adding and selecting a new row fails to properly update an external DetailsPresenter.
          

* DefaultRowHeight value
          

* IEditableCollectionView and IPagedCollectionView implementation for DataItemCollection
          

* EditOperationType property to the GridViewRowValidatingEventArgs
          

* Commands to support more custom scenarios with keyboard navigation
          

* Extending grouping to support grouping by expression and group sorting by expression.
          

* Exporting refactored + Export() method added allowing more control over which elements are included in the exported data
          

* Combobox column - virtualization turned on by default
          

* Column Reordering Event
          

* IsCustomScrollingEnabled property
          

* Caching for GridViewDataColumn extended
          

* Grand totals exported by default - no need to handle exporting event
          

* "OldValues" property to the RowEditEnded event arguments
          

* Include footers and group footers in exporting
          

* Refactor RowEditEnded event to use data item instead of UI object
          

* Group descriptions synchronization for DataItemCollection, Domain Data Source support
          

* Added functionality to cancel edit for an editing unit (cell, row), as a result when Esc key is pressed only cell gets out of edit mode, after second Esc key press and row leaves edit mode
          

* Synchronization between source collection Sort descriptions and DataItemCollection Sort descriptors.
          

* Return old values to the GridViewRow when edit is canceled, also bug while getting these old values
          

* Now when GridViewCell enters into edit mode first "IsTabStop" control will be focused
          

* Filtering "Match case" functionality.
          

* Enabled RadGridView programmatic pre-filtering.
          

* An overload of the PrintToHTML() method to get better control over what is being printed
          

* CanUserDeleteRows property
          

* TextAlignment property added for the exporting event args
          

* GroupPanelStyle and GroupPanelItemStyle
          

* RowUnloaded event
          

* RowUnloadedEventArgs class
          

* Users can now select rows by clicking anywhere on a row
          

* RowActivated Event
          

* CellDoubleClick Event on GridViewCellBase 

## Removed properties and methods:

* Redundant FrameworkElementToImageconverter class
          

* GridViewDataControl (base class for RadGridView)
            

* UseAlternateRowStyle property - use AlternationCount property instead.
              

* AlternateExpandableRowStyle property - use AlternateRowStyle property instead.
              

* ExpandableRowStyle property - use RowStyle instead.
              

* ItemsGenerator property - use ItemContainerGenerator instead.
              

* ColumnsWidthMode property - use ColumnWidth instead.
              

* ValidationMode property - not used anymore. Use cell and row validation events if you want to control validation on cell or row level
              

* VerticalLineThickness, VerticalLineVisibility, and VerticalLineFill properties - use GridLinesVisibility instead.
              

* EditorSettings property - use appropriate column type, or create custom column which inherits from the GridViewBoundColumnBase class
              

* BringDataItemIntoView method - use ScrollIntoView(...) or use ScrollIntoViewAsync(...) 

* GridViewFooterCell, GridViewGroupFooterCell and GridViewGroupRow contstructors accepting GridViewDataControl - use the default constructors.
          

* AddedDescriptors - use Added property instead
          

* RemovedDescriptors  - use Remove property instead.
          

* GridViewExpandableRow class - use GridViewRow.IsExpandable property to control whether given row has hierarchy
          

* GridViewCell
          

* Editor property removed - use the Content of the cell which is EditorPresenter when cell is in edit mode.
            

* CellRequestBringIntoViewEvent - use GridViewCell.BringIntoVew() instead. 

* CheckBoxEditorSettings, ComboBoxEditorSettings, MaskedTextBoxEditorSettings, TextBoxEditorSettings, DatePickerEditorSettings, EditorSettings<T> classes and IEditorSettings interface - use appropriate column type, or create custom column which inherits from the GridViewBoundColumnBase class
          

* GridViewCellEditor, GridViewCheckBoxEditor, GridViewComboBoxEditor, GridViewDatePickerEditor, GridViewMaskedtextBoxEditor and GridViewTextBoxEditor classes - standard controls which have valid validation states are used instead.
          

* RegisterDefaultEditor and ResotreDefaultEditors methods of EditorsLoader class
          

* IExpandState interface
          

* NullableDateConverter class - RadDatePicker handles nullable values out of the box.
          

* ValidationMode property of GridViewNewRow class
          
