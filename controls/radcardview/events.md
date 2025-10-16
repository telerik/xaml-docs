---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadCardView WPF control.
slug: radcardview-events
tags: events
published: True
position: 3
---

# Events

This article lists the events specific for __RadCardView__.

* __AutoGeneratingDataFieldDescriptor__: Occurs when a DataFieldDescriptor is autogenerating. A descriptor is generated for each public property of the card's data item. The event can be used to customize or cancel the creation of data fields. The event arguments are of type `CardViewAutoGeneratingDataFieldDescriptorEventArgs` which expose the following members:

	* __DataFieldDescriptor__: Gets the associated data field descriptor object.
	* __ItemPropertyInfo__: Gets the associated item property info.

	__Example 1: AutoGeneratingDataFieldDescriptor event handler__
	```C#
		private void RadCardView_AutoGeneratingDataFieldDescriptor(object sender, CardViewAutoGeneratingDataFieldDescriptorEventArgs e)
        {
            bool isCanceled = e.Cancel;
            CardDataFieldDescriptor dataFieldDescritor = e.DataFieldDescriptor;
            ItemPropertyInfo propertyInfo = e.ItemPropertyInfo;
        }
	```
	
* __CardDataFieldPreparedEditor__: Occurs when the editor control of a card's data field is prepared, just before the editing of the field starts. The event arguments are of type `CardDataFieldPreparedEditorEventArgs` which expose the following members:
	
	* __FrameworkElement__: Gets the control rerpesenting the editor of the data field. 
	* __DataField__: Gets the associated `DataFormDataField` object.

	__Example 2: CardDataFieldPreparedEditor event handler__
	```C#
		private void RadCardView_CardDataFieldPreparedEditor(object sender, Telerik.Windows.Controls.Data.CardView.CardDataFieldPreparedEditorEventArgs e)
        {
            RadCardViewItem card = e.CardViewItem;
            DataFormDataField dataField = e.DataField;
            FrameworkElement editor = e.Editor;
        }
	```
	
* __SelectionChanged__: Occurs when the selected card is changed. The event arguments are of type `SelectionChangedEventArgs` which expose the following members:
	
	* __AddedItems__: Gets a collection containing the newly selected card.
	* __RemovedItems__: Gets a collection containing the previously selected card.

	__Example 3: SelectionChanged event handler__
	```C#
		private void RadCardView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            IList addedItems = e.AddedItems;
            IList removedItems = e.RemovedItems;
        }
	```
	
## Editing 

* __CardBeginningEdit__: Occurs just before an edit operation is started. The event can be used to cancel the editing by setting the event arguments __Cancel__ property to `true`.  The event arguments are of type `CardViewItemCancelEventArgs` which expose the following members:

	* __CardViewItem__: Gets the associated `RadCardViewItem` object.
	
	__Example 4: CardBeginningEdit event handler__
	```C#
		private void RadCardView_CardBeginningEdit(object sender, Telerik.Windows.Controls.Data.CardView.CardViewItemCancelEventArgs e)
        {
            bool isCanceled = e.Cancel;
            RadCardViewItem card = e.CardViewItem;
        }
	```
	
* __CardEditEnding__: Occurs just before an edit operation is finished. The event arguments are of type `CardDataFieldCancelEventArgs` which expose the following members: 

	* __CardViewItem__: Gets the associated `RadCardViewItem` object.
	* __DataField__: Gets the associated `DataFormDataField` object.

	__Example 5: CardEditEnding event handler__
	```C#
		private void RadCardView_CardEditEnding(object sender, Telerik.Windows.Controls.Data.CardView.CardViewEditEndingEventArgs e)
        {
            bool isCanceled = e.Cancel;
            RadCardViewItem card = e.CardViewItem;
            EditAction editAction = e.EditAction;
        }
	```
	
* __CardEditEnded__: Occurs when an edit operation is finished. The event arguments are of type `CardViewEditEndedEventArgs` which expose the following members:

	* __CardViewItem__: Gets the associated `RadCardViewItem` object.
	* __EditAction__: Gets the edit action - __Cancel__ or __Commit__.

	__Example 6: CardEditEnded event handler__
	```C#
		private void RadCardView_CardEditEnded(object sender, CardViewEditEndedEventArgs e)
        {
            RadCardViewItem card = e.CardViewItem;
            EditAction editAction = e.EditAction;
        }
	```
	
* __CardDataFieldBeginningEdit__: Occurs just before an edit operation is started for a data field. The event arguments are of type `CardDataFieldCancelEventArgs` which expose the following members:

	* __CardViewItem__: Gets the associated `RadCardViewItem` object.
	* __DataField__: Gets the associated `DataFormDataField` object.
	
	__Example 7: CardDataFieldBeginningEdit event handler__
	```C#
		private void RadCardView_CardDataFieldBeginningEdit(object sender, Telerik.Windows.Controls.Data.CardView.CardDataFieldCancelEventArgs e)
        {
            bool isCanceled = e.Cancel;
            RadCardViewItem card = e.CardViewItem;
            DataFormDataField dataField = e.DataField;
        }
	```	
	
* __CardDataFieldEditEnded__: Occurs when an edit operation is finished for a data field. The event arguments are of type `CardDataFieldEditEndedEventArgs` which expose the following members:

	* __CardViewItem__: Gets the associated `RadCardViewItem` object.
	* __EditAction__: Gets the edit action - __Cancel__ or __Commit__.
	* __NewValue__: Gets the edited value.
	* __OldValue__: Gets the previous value.

	__Example 8: CardDataFieldEditEnded event handler__
	```C#
		private void RadCardView_CardDataFieldEditEnded(object sender, Telerik.Windows.Controls.Data.CardView.CardDataFieldEditEndedEventArgs e)
        {
            RadCardViewItem card = e.CardViewItem;
            DataFormDataField dataField = e.DataField;
            EditAction editAction = e.EditAction;
            object oldValue = e.OldValue;
            object newValue = e.NewValue;
        }
	```	

## Validation

* __CardValidating__: Occurs when a card is being validated. The event arguments are of type `CardViewItemCancelEventArgs` which expose the following members:
	
	* __CardViewItem__: Gets the associated `RadCardViewItem` object.

	__Example 9: CardValidating event handler__
	```C#
		private void RadCardView_CardValidating(object sender, Telerik.Windows.Controls.Data.CardView.CardViewItemCancelEventArgs e)
        {
            bool isCanceled = e.Cancel;
            RadCardViewItem card = e.CardViewItem;
        }
	```
	
* __CardDataFieldValidating__: Occurs when a data field starts data validating. The event arguments are of type `CardDataFieldValidatingEventArgs` which expose the following members:
		
	* __IsValid__: Gets the current validating state.
	* __ValidationResults__: Gets a collection with the validation results.
	* __CardViewItem__: Gets the associated `RadCardViewItem` object.
	* __DataField__: Gets the associated `DataFormDataField` object.

	__Example 10: CardDataFieldValidating event handler__
	```C#
		private void RadCardView_CardDataFieldValidating(object sender, Telerik.Windows.Controls.Data.CardView.CardDataFieldValidatingEventArgs e)
        {
            bool isValid = e.IsValid;
            RadCardViewItem card = e.CardViewItem;
            DataFormDataField dataField = e.DataField;
            IEnumerable<ValidationResult> results = e.ValidationResults;
        }
	```
	
* __CardDataFieldValidated__: Occurs when data field is being validated. The event arguments are of type `CardDataFieldEditEndedEventArgs` which expose the following members:

	* __ValidationResults__: Gets a collection with the validation results.
	* __CardViewItem__: Gets the associated `RadCardViewItem` object.
	* __DataField__: Gets the associated `DataFormDataField` object.

	__Example 11: CardDataFieldValidated event handler__
	```C#
		private void RadCardView_CardDataFieldValidated(object sender, Telerik.Windows.Controls.Data.CardView.CardDataFieldValidatedEventArgs e)
        {
            RadCardViewItem card = e.CardViewItem;
            DataFormDataField dataField = e.DataField;
            IEnumerable<ValidationResult> results = e.ValidationResults;
        }
	```

## Filtering

* __FieldFilterEditorCreated__: Occurs when a field filter editor is created. The event arguments are of type `CardViewFilterEditorCreatedEventArgs` which expose the following members:

	* __CardDataFieldFilterDescriptor__: This property gets the corresponding `CardDataFieldFilterDescriptor` object.
	* __Editor__: Gets the control rerpesenting the editor of the data field. 

	__Example 12: FieldFilterEditorCreated event handler__
	```C#
		private void RadCardView_FieldFilterEditorCreated(object sender, Telerik.Windows.Controls.Data.CardView.CardViewFilterEditorCreatedEventArgs e)
        {
            FrameworkElement editor = e.Editor;
            CardDataFieldDescriptor dataFieldDescritor = e.CardDataFieldDescriptor;
        }
	```

* __Filtering__: Occurs before the filtering operation takes effect. The event can be used to cancel the filtering by setting the event arguments __Cancel__ property to `true`. The event arguments are of type `CardViewFilteringEventArgs` which expose the following members:
	
	* __Added__: This property gets the added `IFilterDescriptor` object.
	* __Removed__: This property gets the removed `IFilterDescriptor` object.
	* __CardDataFieldFilterDescriptor__: This property gets the corresponding `CardDataFieldFilterDescriptor` object.

	__Example 13: Filtering event handler__
	```C#
		private void RadCardView_Filtering(object sender, Telerik.Windows.Controls.Data.CardView.CardViewFilteringEventArgs e)
        {
            bool isCanceled = e.Cancel;
            IEnumerable<IFilterDescriptor> addedDescriptors = e.Added;
            IEnumerable<IFilterDescriptor> removedDescriptors = e.Removed;
            ICardDataFieldFilterDescriptor dataFieldFilterDescritor = e.CardDataFieldFilterDescriptor;
        }
	```
	
* __Filtered__: Occurs after the filtering operation is executed. The event arguments are of type `CardViewFilteredEventArgs` which expose the following members:
	
	* __Added__: This property gets the added `IFilterDescriptor` object.
	* __Removed__: This property gets the removed `IFilterDescriptor` object.
	* __CardDataFieldFilterDescriptor__: This property gets the corresponding `CardDataFieldFilterDescriptor` object.

	__Example 14: Filtered event handler__
	```C#
		private void RadCardView_Filtered(object sender, CardViewFilteredEventArgs e)
        {
            IEnumerable<IFilterDescriptor> addedDescriptors = e.Added;
            IEnumerable<IFilterDescriptor> removedDescriptors = e.Removed;
            ICardDataFieldFilterDescriptor dataFieldFilterDescritor = e.CardDataFieldFilterDescriptor;
        }
	```
		
* __FilterOperatorsLoading__: Occurs before the filter operators are loaded. The event can be used to remove some of the default operators or change the currently selected one. The event arguments are of type `FilterOperatorsLoadingEventArgs` which expose the following members:
	
	* __AvailableOperators__: This property gets all available operators that will be displayed by default. You can remove operators from the collection in order to hide them from the UI. 	
	* __DefaultOperator1__: This property gets the first `FilterOperator` object. 
	* __DefaultOperator2__: This property gets the second `FilterOperator` object.
	* __CardDataFieldFilterDescriptor__: This property gets the corresponding `CardDataFieldFilterDescriptor` object.

	__Example 15: FilterOperatorsLoading event handler__
	```C#
		private void RadCardView_FilterOperatorsLoading(object sender, FilterOperatorsLoadingEventArgs e)
        {
            RemoveOnlyCollection<FilterOperator> availableOperators = e.AvailableOperators;
            CardDataFieldDescriptor dataFieldDescritor = e.CardDataFieldDescriptor;
            FilterOperator? operator1 = e.DefaultOperator1;
            FilterOperator? operator2 = e.DefaultOperator2;
        }
	```
	
* __DistinctValuesLoading__: Occurs before the distinct values of the associated data field descriptor are loaded. The event arguments are of type `CardViewDistinctValuesLoadingEventArgs` which expose the following members:
	
	* __ItemsSource__: Gets or sets the source collection containing the distinct values that will be loaded. This can be used to modify or replace the collection.
	* __CardDataFieldFilterDescriptor__: This property gets the corresponding `CardDataFieldFilterDescriptor` object.

	__Example 16: DistinctValuesLoading event handler__
	```C#
		private void RadCardView_DistinctValuesLoading(object sender, CardViewDistinctValuesLoadingEventArgs e)
        {
            bool isCanceled = e.Cancel;
            CardDataFieldDescriptor dataFieldDescritor = e.CardDataFieldDescriptor;
            IEnumerable distinctValuesSource = e.ItemsSource;
        }
	```

## Sorting

* __Sorting__: Occurs before the sorting operation is executed. The event can be used to cancel the sorting by setting the event arguments __Cancel__ property to `true`. The event arguments are of type `CardViewSortingEventArgs` which expose the following members:
	
	* __OldSortingState__: Gets the old sorting direction.
	* __NewSortingState__: Gets the new sorting direction.
	* __IsMultipleDataFieldDescriptorSorting__: Indicates if the current sorting is applied over multiple data field descriptors.
	* __DataFieldFilterDescriptor__: Gets the corresponding `CardDataFieldFilterDescriptor` object.

	__Example 17: Sorting event handler__
	```C#
		private void RadCardView_Sorting(object sender, CardViewSortingEventArgs e)
        {
            bool isCanceled = e.Cancel;
            CardDataFieldDescriptor dataFieldDescritor = e.DataFieldDescriptor;
            bool isMultipleSorting = e.IsMultipleDataFieldDescriptorSorting;
            SortingState previousSortingState = e.OldSortingState;
            SortingState newSortingState = e.NewSortingState;
        }
	```
		
* __Sorted__: Occurs after the sorting operation is executed. The event arguments are of type `CardViewSortedEventArgs` which expose the following members:	
	
	* __DataFieldFilterDescriptor__: Gets the corresponding `CardDataFieldFilterDescriptor` object.

	__Example 18: Sorted event handler__
	```C#
		private void RadCardView_Sorted(object sender, CardViewSortedEventArgs e)
        {
            CardDataFieldDescriptor dataFieldDescritor = e.DataFieldDescriptor;
        }
	```

## Grouping

* __Grouping__: Occurs before the grouping operation is executed. The event can be used to cancel the grouping action by setting the event arguments __Cancel__ property to `true`. The event arguments are of type `CardViewGroupingEventArgs` which expose the following members:
	
	* __Action__: Gets the `CardViewGroupingEventAction`.
	* __GroupDescriptor__: Gets the corresponding `IGroupDescriptor` object.
	* __Index__: Gets the group descriptor's position.

	__Example 19: Grouping event handler__
	```C#
		private void RadCardView_Grouping(object sender, CardViewGroupingEventArgs e)
        {
            bool isCanceled = e.Cancel;
            CardViewGroupingEventAction action = e.Action;
            IGroupDescriptor groupDescriptor = e.GroupDescriptor;
            int? groupDescriptorPosition = e.Index;
        }
	```
		
* __Grouped__: Occurs after the grouping operation is executed. The event arguments are of type `CardViewGroupedEventArgs` which expose the following members:	
	
	* __Action__: Gets the `CardViewGroupingEventAction`.
	* __GroupDescriptor__: Gets the corresponding `IGroupDescriptor` object.
	
	__Example 20: Grouped event handler__
	```C#
		private void RadCardView_Grouped(object sender, CardViewGroupedEventArgs e)
        {
            CardViewGroupingEventAction action = e.Action;
            IGroupDescriptor groupDescriptor = e.GroupDescriptor;
        }
	```

## See Also  
* [Getting Started]({%slug radcardview-getting-started%})
* [Visual Structure]({%slug radcardview-visual-structure%})