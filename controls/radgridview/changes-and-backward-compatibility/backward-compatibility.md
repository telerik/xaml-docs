---
title: Backward Compatibility
page_title: Backward Compatibility
description: Backward Compatibility
slug: radgridview-backward-compatibility
tags: backward,compatibility
published: True
position: 1
---

# Backward Compatibility


Release history of the control

## Latest Release Notes

You can check the latest Release Notes {% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}

## Q2 2014
      

__Changed__

* GridViewMaskedTextBoxColumn was deleted. You can use GridViewMaskedInputColumn instead.
            

__What to do now:__

You can check our [online documentation]({%slug radgridview-columns-column-types-masked-input-column%}) on how to use GridViewMaskedInputColumn.
        

__Changed__

* GridViewIndicatorCell was deleted.
            

__What to do now:__

GridViewIndicatorCell and its style consequently have not been used for a long time. As an alternative solution, you can substitute it with a single Border element or any ContentControl.
        

## Q3 2013
      

__Changed__

* ShowInsertRow marked as Obsolete.Use NewRowPosition instead.
            

__What to do now:__

You can check our [online documentation]({%slug gridview-rows-adding-rows%}) and demos on how to control the position of GridViewNewRow by using the property NewRowPosition.
        

__Changed__

* GridViewIndicatorCell is marked as obsolete.
            

__What to do now:__

GridViewIndicatorCell and its style consequently have not been used for a long time.
        

You can check the full Release Notes for __Q3 2013__{% if site.site_name == 'Silverlight' %}[here.](http://www.telerik.com/products/silverlight/whats-new/release_notes/q3-2013-version-2013-3-1016-432255941.aspx){% endif %}{% if site.site_name == 'WPF' %}[here.](http://www.telerik.com/products/wpf/whats-new/release-history/q3-2013-version-2013-3-1016-2120428450.aspx){% endif %}

## Q2 2013
      

__Changed__

* DragDrop logic now depends on DragDropManager. The RadDragAndDropManager logic was removed from GridViewDataControl.
          

__What to do now:__

You can use DragDropManager.

You can check the full Release Notes for __Q2 2013__{% if site.site_name == 'Silverlight' %}[here.](http://www.telerik.com/products/silverlight/whats-new/release_notes/q2-2013-version-2013-2-0611-3259441291.aspx#gridview){% endif %}{% if site.site_name == 'WPF' %}[here.](http://www.telerik.com/products/wpf/whats-new/release-history/q2-2013-version-2013-2-0611.aspx#gridview){% endif %}

## Q1 2013
      

There are no breaking changes introduced with that official version.
        

You can check the full Release Notes for __Q1 2013__{% if site.site_name == 'Silverlight' %}[here.](http://www.telerik.com/products/silverlight/whats-new/release_notes/q1-2013-version-2013-1-0220-963710774.aspx#gridview){% endif %}{% if site.site_name == 'WPF' %}[here.](http://www.telerik.com/products/wpf/whats-new/release-history/q1-2013-version-2013-1-0220.aspx#gridview){% endif %}

## Q3 2012 SP
      

* __IndicatorPresenter__ class has been removed.
          

* FrozenColumnSplitter Logic now depends on DragDropManager
          

##  Q3 2012
      

* As of __Q3 2012__ we have introduced a new property of the RadGridView __GroupRenderMode__. It has two options: __Nested__ mode and __Flat__ mode. Please note that when you use the __Flat__ mode, you should work with __GroupHeaderRow, not GridViewGroupRow__. If you use the default __Nested__ mode, then you could still use the __GridViewGroupRow__.
          

* GridView Drag and Drop logic implementation migration. Migrated from RadDragAndDropManager to DragDropManager.
          

* Now __the Culture used for formatting the GridView is the one specified as a Language__ for it or for the containing Window. You should set the Language property to be the CurrentCulture and the GridView will be formatted based on it.
          

* GridViewVirtualizingPanel Status, Orientation and VirtualizationMode removed (obsolete since 2009).
          

* public method Telerik.Windows.Controls.GridViewRowValidatingEventArgs.ctor is removed. Please, use another one instead.
          

* public class Telerik.Windows.Controls.GridView.CheckBoxEditor is removed. Please, use CheckBox instead.
          

* public method Telerik.Windows.Controls.GridView.GridViewDataControl.OnFiltered is not supposed to be used from your code and is made internal.
          

* public method Telerik.Windows.Controls.GridView.GridViewDataControl.OnFiltering is not supposed to be used from your code and is made internal.
          

* public class Telerik.Windows.Controls.GridView.TextBoxEditor is removed. Please, use TextBox instead.
          

* public class Telerik.Windows.Controls.GridView.Automation.GridViewCellAutomationPeer is made obsolete and will be removed in a future version. Please, use Telerik.Windows.Automation.Peers.GridViewCellAutomationPeer instead.
          

* public class Telerik.Windows.Controls.GridView.Automation.GridViewDataItemAutomationPeer is made obsolete and will be removed in a future version. Please, use Telerik.Windows.Automation.Peers.GridViewDataItemAutomationPeer instead.
          

* public class Telerik.Windows.Controls.GridView.Automation.GridViewHeaderRowAutomationPeer is made obsolete and will be removed in a future version. Please, use Telerik.Windows.Automation.Peers.GridViewHeaderRowAutomationPeer instead.
          

* public class Telerik.Windows.Controls.GridView.Automation.GridViewVirtualizingPanelAutomationPeer is made obsolete and will be removed in a future version. Please, use Telerik.Windows.Automation.Peers.GridViewVirtualizingPanelAutomationPeer instead.
          

* public class Telerik.Windows.Controls.GridView.Automation.RadGridViewAutomationPeer is made obsolete and will be removed in a future version. Please, use Telerik.Windows.Automation.Peers.RadGridViewAutomationPeer instead.
          

* public class Telerik.Windows.Controls.GridView.GridView.Automation.DetailsPresenterAutomationPeer is made obsolete and will be removed in a future version. Please, use Telerik.Windows.Automation.Peers.DetailsPresenterAutomationPeer instead.
          

## Q2 2012 SP2
      

Now the Culture used is the one specified as a Language for the GridView (or the containing {% if site.site_name == 'WPF' %}Window{% endif %}{% if site.site_name == 'Silverlight' %}UserControl{% endif %}). You could set the Language property to the CurrentCulture like so: {% if site.site_name == 'WPF' %}

#### __C#__

{{region radgridview-backward-compatibility_12}}

    public MainWindow()
    {
        InitializeComponent();
        this.Language = XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag);
    }
{{endregion}}

{% endif %}{% if site.site_name == 'Silverlight' %}

#### __C#__

{{region radgridview-backward-compatibility_14}}

    public MainPage()
    {
        InitializeComponent();
        Dispatcher.BeginInvoke(new Action(() => this.Language = XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.Name)));
    }
{{endregion}}

{% endif %}


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

{{region radgridview-backward-compatibility_0}}

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

{{region radgridview-backward-compatibility_1}}

    Dim ageColumn As GridViewColumn = Me.radGridView.Columns("Age")
    Dim ageColumnFilter As New ColumnFilterDescriptor(ageColumn)
    ' ...
    ageColumnFilter.DistinctFilter.DistinctValues.Add(5)
    ageColumnFilter.FieldFilter.Filter1.[Operator] = FilterOperator.IsLessThan
    ageColumnFilter.FieldFilter.Filter1.Value = 10
    ' ...
    Me.radGridView.FilterDescriptors.Add(ageColumnFilter)
#End Region

#Region "radgridview-backward-compatibility_3"

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

#Region "radgridview-backward-compatibility_5"

    Me.radGridView.FilterDescriptors.Remove(columnFilterDescriptor)
#End Region

#Region "radgridview-backward-compatibility_7"

    ' Calling ClearFilter will automatically remove filter descriptor from the grid.
    myColumn.ClearFilters()
#End Region

#Region "radgridview-backward-compatibility_9"

    Me.radGridView.FilterDescriptors.Clear()
#End Region

#Region "radgridview-backward-compatibility_11"

    Me.radGridView.FilterDescriptors.SuspendNotifications()
    For Each column As var In Me.radGridView.Columns
	    column.ClearFilters()
    Next
    Me.radGridView.FilterDescriptors.ResumeNotifications()
    End Class
#End Region

__After:__

#### __C#__

{{region radgridview-backward-compatibility_2}}

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

{{region radgridview-backward-compatibility_3}}

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
	
	#Region "radgridview-backward-compatibility_5"
	    Me.radGridView.FilterDescriptors.Remove(columnFilterDescriptor)
	#End Region
	
	#Region "radgridview-backward-compatibility_7"
	    ' Calling ClearFilter will automatically remove filter descriptor from the grid.
	    myColumn.ClearFilters()
	#End Region
	
	#Region "radgridview-backward-compatibility_9"
	    Me.radGridView.FilterDescriptors.Clear()
	#End Region
	
	#Region "radgridview-backward-compatibility_11"
	    Me.radGridView.FilterDescriptors.SuspendNotifications()
	    For Each column As var In Me.radGridView.Columns
		    column.ClearFilters()
	    Next
	    Me.radGridView.FilterDescriptors.ResumeNotifications()
	    End Class
	#End Region



* __Clearing a Column Filter____Before:__

#### __C#__

{{region radgridview-backward-compatibility_4}}

	    this.radGridView.FilterDescriptors.Remove(columnFilterDescriptor);
	{{endregion}}

__After:__

#### __C#__

{{region radgridview-backward-compatibility_6}}

	    // Calling ClearFilter will automatically remove filter descriptor from the grid.
	    myColumn.ClearFilters();
	{{endregion}}



* __Clearing All RadGridView Filters____Before:__

#### __C#__

{{region radgridview-backward-compatibility_8}}

	    this.radGridView.FilterDescriptors.Clear();
	{{endregion}}

__After:__

#### __C#__

{{region radgridview-backward-compatibility_10}}

	    this.radGridView.FilterDescriptors.SuspendNotifications();
	    foreach (var column in this.radGridView.Columns)
	    {
		    column.ClearFilters();
	    }
	    this.radGridView.FilterDescriptors.ResumeNotifications();
	{{endregion}}



#### __VB.NET__

{{region radgridview-backward-compatibility_11}}

	    Me.radGridView.FilterDescriptors.SuspendNotifications()
	    For Each column As var In Me.radGridView.Columns
		    column.ClearFilters()
	    Next
	    Me.radGridView.FilterDescriptors.ResumeNotifications()
	    End Class
	#End Region


## Q3 2011
      

* The default __filter editor for numeric__ types is now __TextBox__ instead of RadMaskedTextBox
          

*  The __StringFilterEditor__ control has two new properties now -- Text and IsCaseSensitive. If you create this editor manually instead of relying on the FilterEditorFactory, you have to bind these two properties to the "Value" and "IsCaseSensitive" properties of the view model respectively
          

* Deleting the entire text from the __StringFilterEditor__ will now clear the filter instead of filtering on string.Empty
          

## Q3 2010 (Version Number: 2010.3.1110)
      

* The __GroupDescriptor__ property of [GridViewGroupedEventArgs and GridViewGroupingEventArgs]({%slug gridview-events-grouping%}) is now of type __IGroupDescriptor__.
          

* The __Action__ property of the [GridViewGroupedEventArgs and GridViewGroupingEventArgs]({%slug gridview-events-grouping%}) is now of type __GroupingEventAction__ instead of CollectionChangeAction.
          

* The __GroupDescriptors__ property of RadGridView is now a collection of __IGroupDescriptor__, instead of GroupDescriptor.
          

* RadGridView now generates the new __ColumnGroupDescriptor__ when grouping from the UI.
          

* The __Grouping__ and __Grouped__ events now fire only when a grouping operation has been performed on the UI.
          

* The __PropertyName__ of GridViewSortingEventArgs has been marked as obsolete and will be removed in a future release. You should use the __Column__ property to identify which column/data field is to be sorted.
          

* RadGridView now generates the new [ColumnSortDescriptor]({%slug gridview-sorting-programmatic%}) when sorting from the UI.
          

* The __SortDescriptors__ property of RadGridView is now a collection of __ISortDescriptor__, instead of SortDescriptor.
          

* The __GroupMemberPath__, __SortMemberPath__ and __GroupHeaderFormatString__ properties have been moved from __GridViewBoundColumnBase__ to __GridViewColumn__ class__.__



## Q2 2010 (Version Number: 2010.2.714)
      

* The __RadDataPager__ control has been moved from the Telerik.Windows.Controls.GridView assembly to the new __Telerik.Windows.Controls.Data__ assembly. Since its namespace remains the same as before (Telerik.Windows.Controls) existing applications only need to add a reference to the new assembly. No other changes should be necessary.
          

* __Exporting__ event marked as obsolete. Use [ElementExporting](74308197-B2E6-4A20-9390-04937F1D845E#exporting) instead.
          


## Q1 2010 SP2 (Version Number: 2010.1.603)
      

* Changed the namespace of __LookupElement__ from Telerik.Windows.Controls to Telerik.Windows.Controls.Gridview.
          


## Breaking changes for Telerik RadGridView for SilverlightWPF Q1 2010 SP1 (Version Number: 2010.1.0422)
      

* The enumerator of RadGridView.Items now enumerates data items only (use RadGridView.Items.Groups to retrieve group items). 



## Removed properties and methods for Telerik RadGridView for SilverlightWPF Q1 2010 (Version Number: 2010.1.0309)
      

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
          
## Obsolete or changed properties and methods for Telerik RadGridView for SilverlightWPF Q1 2010 (Version Number: 2010.1.0309)

* AlignmentContentPresenter - normal ContentPresenter is used in GridViewCell's Template
              

* GridViewHeaderSplitter class
              

* HorizontalScrollPanel class - GridViewCellsPanel is used instead.
              

* GridViewCellBase
                

* MouseDoubleClick in Silverlight is now obsolete
                  

* TextAlignment, TextDecorations and TextWrapping properties- use the ones on the GridViewColumn instead. 

* IsCustomScrollingEnabled property moved to GridViewScrollViewer - used to handle server side scrolling scenarios
              


