---
title: Programmatic Filtering
page_title: Programmatic Filtering
description: Programmatic Filtering
slug: gridview-filtering-programmatic
tags: programmatic,filtering
published: True
position: 10
---

# Programmatic Filtering



RadGridView provides a rich API that allows you to filter programmatically. Everything that can be achieved by the end user through the UI can also be done by using the code-behind API.

## Column Filtering

Sometimes a developer might want to pre-filter RadGridView so the end users start off with an already filtered grid. The UI of RadGridView has to be consistent with the programmatically defined filtering criteria of course. To achieve this, one has to use the IColumnFilterDescriptor contract. This is the only contract that a column can “understand” and reflect in its filtering UI.

### Filtering Single Column

The IColumnFilterDescriptor interface mimics the structure of the default Popup filtering control. It has two parts just like the filtering control does – distinct values and field filters. To obtain an IColumnFilterDescriptor you have to get it from the respective column by accessing its ColumnFilterDescriptor property. Once you have a reference to it, you can set its properties. Setting a property on the IColumnFilterDescriptor is the same as the end user performing the respective operation through the UI with the mouse and keyboard.

If you want to adjust many properties at once without triggering a data engine update after each one it might be a good idea to temporarily suspend the notifications of the IColumnFilterDescriptor, filter programmatically, and finally resume the notifications. When you resume the notifications the data engine will calculate the new filter. Here is an example of filtering a single column programmatically.

#### __C#__

{{region gridview-filtering-programmatic_0}}
	Telerik.Windows.Controls.GridViewColumn countryColumn = this.radGridView.Columns["Country"];
	Telerik.Windows.Controls.GridView.IColumnFilterDescriptor countryFilter = countryColumn.ColumnFilterDescriptor;
	
	// Suspend the notifications to avoid multiple data engine updates
	countryFilter.SuspendNotifications();
	
	// This is the same as the end user selecting a distinct value through the UI.
	countryFilter.DistinctFilter.AddDistinctValue("Poland");
	countryFilter.DistinctFilter.AddDistinctValue("Spain");
	countryFilter.DistinctFilter.AddDistinctValue("Uzbekistan");
	countryFilter.DistinctFilter.AddDistinctValue("Netherlands");
	countryFilter.DistinctFilter.AddDistinctValue("Austria");
	countryFilter.DistinctFilter.AddDistinctValue("Finland");
	countryFilter.DistinctFilter.AddDistinctValue("Pakistan");
	
	// This is the same as the end user configuring the upper field filter.
	countryFilter.FieldFilter.Filter1.Operator = Telerik.Windows.Data.FilterOperator.Contains;
	countryFilter.FieldFilter.Filter1.Value = "land";
	countryFilter.FieldFilter.Filter1.IsCaseSensitive = true;
	
	// This is the same as the end user changing the logical operator between the two field filters.
	countryFilter.FieldFilter.LogicalOperator = Telerik.Windows.Data.FilterCompositionLogicalOperator.Or;
					
	// This is the same as the end user configuring the lower field filter.
	countryFilter.FieldFilter.Filter2.Operator = Telerik.Windows.Data.FilterOperator.Contains;
	countryFilter.FieldFilter.Filter2.Value = "stan";
	countryFilter.FieldFilter.Filter2.IsCaseSensitive = true;
	
	// Resume the notifications to force the data engine to update the filter.
	countryFilter.ResumeNotifications();
	{{endregion}}



#### __VB.NET__

{{region gridview-filtering-programmatic_0}}
		Dim countryColumn As Telerik.Windows.Controls.GridViewColumn = Me.radGridView.Columns("Country")
		Dim countryFilter As Telerik.Windows.Controls.GridView.IColumnFilterDescriptor = countryColumn.ColumnFilterDescriptor
	
		' Suspend the notifications to avoid multiple data engine updates
		countryFilter.SuspendNotifications()
	
		' This is the same as the end user selecting a distinct value through the UI.
		countryFilter.DistinctFilter.AddDistinctValue("Poland")
		countryFilter.DistinctFilter.AddDistinctValue("Spain")
		countryFilter.DistinctFilter.AddDistinctValue("Uzbekistan")
		countryFilter.DistinctFilter.AddDistinctValue("Netherlands")
		countryFilter.DistinctFilter.AddDistinctValue("Austria")
		countryFilter.DistinctFilter.AddDistinctValue("Finland")
		countryFilter.DistinctFilter.AddDistinctValue("Pakistan")
	
		' This is the same as the end user configuring the upper field filter.
		countryFilter.FieldFilter.Filter1.[Operator] = Telerik.Windows.Data.FilterOperator.Contains
		countryFilter.FieldFilter.Filter1.Value = "land"
		countryFilter.FieldFilter.Filter1.IsCaseSensitive = True
	
		' This is the same as the end user changing the logical operator between the two field filters.
		countryFilter.FieldFilter.LogicalOperator = Telerik.Windows.Data.FilterCompositionLogicalOperator.[Or]
	
		' This is the same as the end user configuring the lower field filter.
		countryFilter.FieldFilter.Filter2.[Operator] = Telerik.Windows.Data.FilterOperator.Contains
		countryFilter.FieldFilter.Filter2.Value = "stan"
		countryFilter.FieldFilter.Filter2.IsCaseSensitive = True
	
		' Resume the notifications to force the data engine to update the filter.
		countryFilter.ResumeNotifications()
	{{endregion}}



Programmatic Filtering Single Column![](images/gridview_filtering_programmatic_01.png)

The DistinctFilter object also has a method called RemoveDistinctValue which does the opposite of AddDistinctValue.

Note that if you are using RadGridView in its Filter Row mode, you only need to work with the FieldFilter.Filter1 object. The Filter Row only displays what is stored in FieldFilter.Filter1 – it has neither Distinct Values nor Filter2 and will simply ignore them.

### Clearing a Single Column Filter

If you want to programmatically clear an existing filter from a column, you simply need to call the ClearFilters method of the respective column. You don’t need to suspend or resume anything since this a batch operation in itself.

>If you have added a FilterDescriptor instead of an IColumnFilterDescriptor, then you need to Clear the FilterDescriptors collection.

### Filtering Multiple Columns

In case you want to pre-filter multiple columns at once without triggering a data engine update after each one, you can follow the same Suspend/Resume pattern, but this time with RadGridView.FilterDescriptors. Here is how you can filter many columns with a single batch operation:

#### __C#__

{{region gridview-filtering-programmatic_1}}
	this.radGridView.FilterDescriptors.SuspendNotifications();
	// ... filter as many columns as you wish here...
	this.radGridView.FilterDescriptors.ResumeNotifications();
	{{endregion}}



#### __VB.NET__

{{region gridview-filtering-programmatic_1}}
		Me.radGridView.FilterDescriptors.SuspendNotifications()
		' ... filter as many columns as you wish here...
		Me.radGridView.FilterDescriptors.ResumeNotifications()
	{{endregion}}



### Clearing Multiple (All) Column Filters

Clearing one or more column filters is again done by using the Suspend/Resume pattern.

#### __C#__

{{region gridview-filtering-programmatic_2}}
	this.radGridView.FilterDescriptors.SuspendNotifications();
	foreach (Telerik.Windows.Controls.GridViewColumn column in this.radGridView.Columns)
	{
		column.ClearFilters();
	}
	this.radGridView.FilterDescriptors.ResumeNotifications();
	{{endregion}}



#### __VB.NET__

{{region gridview-filtering-programmatic_2}}
		Me.radGridView.FilterDescriptors.SuspendNotifications()
		For Each column As Telerik.Windows.Controls.GridViewColumn In Me.radGridView.Columns
			column.ClearFilters()
		Next
		Me.radGridView.FilterDescriptors.ResumeNotifications()
	{{endregion}}



## Custom Filtering

The IColumnFilterDescriptor has its limitations since it mimics the UI structure of the Popup filtering control. Sometimes however, more complex filters have to be applied to RadGridView programmatically. While these filters cannot be reflected in the UI since they do not follow the IColumnFilterDescriptor contract, they can be arbitrarily complex. In order to filter RadGridView, you have to add an IFilterDescriptor instance to its FilterDescriptors collection property.

### IFilterDescriptor

This interface is the building block of filtering criteria trees. Its has a single method called CreateFilterExpression. Normally, you will never have to implement this yourself since we have provided the default implementations for all common cases. If you have a custom requirement which cannot be met by our default implementations though, you can always implement this interface and return any valid LINQ expression which will then be used by our data engine when composing the filter. More about implementing this interface you can learn from this advanced [topic]({%slug gridview-filtering-howto-filter-a-collection-property%}).

The IFilterDescriptor interface has two main implementations – the FilterDescriptor and the CompositeFilterDescriptor. These two classes allow you to build arbitrarily complex filter criteria trees by simply setting their properties.

### FilterDescriptor

The FilterDescriptor class represents a leaf terminal node in a filter criteria tree. It expresses a filtering criteria and has 5 important properties:

* Member specifies the name of the property to filter on. This is the left hand side operand.

* Operator specifies the comparison operator to be used.

* Value specifies the value that the Member will be compared against. This is the right hand side operand.

* IsCaseSensitive is only used when the MemberType of the filter descriptor is string.

* MemberType specifies what the actual Member  .NET Type is. You only need to set this if our data engine cannot automatically discover the type.

So a typical FilterDescriptor might look something like this:

#### __C#__

{{region gridview-filtering-programmatic_3}}
	// Give me all people that are named John.
	Telerik.Windows.Data.FilterDescriptor fd = new Telerik.Windows.Data.FilterDescriptor();
	fd.Member = "FirstName";
	fd.Operator = Telerik.Windows.Data.FilterOperator.IsEqualTo;
	fd.Value = "John";
	fd.IsCaseSensitive = true;
	// In most cases the data engine will discover this automatically so you do not need to set it.
	fd.MemberType = typeof(string);
	{{endregion}}



#### __VB.NET__

{{region gridview-filtering-programmatic_3}}
		' Give me all people that are named John.
		Dim fd As New Telerik.Windows.Data.FilterDescriptor()
		fd.Member = "FirstName"
		fd.[Operator] = Telerik.Windows.Data.FilterOperator.IsEqualTo
		fd.Value = "John"
		fd.IsCaseSensitive = True
		' In most cases the data engine will discover this automatically so you do not need to set it.
		fd.MemberType = GetType(String)
	{{endregion}}



When choosing the Operator, you have to make sure that the respective MemberType supports this operator. For example, you cannot use the Contains operator if your MemberType is Int32 because the data engine will crash. Here is a table of filter operators and the types that support them.
<table>Filter Operators and Types Supporting Them<th><tr><td>

Operators</td><td>

Types</td></tr></th><tr><td>

IsEqualTo, IsNotEqualTo</td><td>

All filterable types</td></tr><tr><td>

StartsWith, EndsWith, Contains, DoesNotContain, IsContainedIn, IsNotContainedIn, IsEmpty, IsNotEmpty</td><td>

String</td></tr><tr><td>

IsLessThan, IsLessThanOrEqualTo, IsGreaterThan, IsGreaterThanOrEqualTo</td><td>

Numeric types, DateTime, TimeSpan, all types that overload these .Net operators </td></tr><tr><td>

IsNull, IsNotNull</td><td>

All filterable null-able types</td></tr></table>

>tipYou could localize those strings. For the complete list of the localization strings please check this [how to topic]({%slug gridview-filtering-howto-localize-the-filtering-ui%}).
            

To help you understand how this FilterDescriptor is used by the data engine, let’s give a practical example with the one we have created above. The data engine will build a LINQ expression based on the information it reads from the FilterDescriptor instance. It will then execute this query against the query provider of RadGridView’s source collection. Here is what the expression would be for this FilterDescriptor in pseudo-code:

people.Where(person => person.FirstName == “John”)

The data engine builds, compiles and executes this LINQ expression at run-time. If the information stored in the FilterDescriptor is not consistent you will receive an exception at run-time.

There is one special singleton value called FilterDesciptor.UnsetValue. If you assign this special value to the Value property of the FilterDescriptor you are effectively turning it off. In other words, when the data engine encounters a FilterDescriptor whose Value is equal to FilterDesciptor.UnsetValue it will simply ignore it. This special value might be very useful when you don’t want to be constantly attaching and detaching a FilterDescriptor when you simply want to turn it on and off. You can check whether a FilterDescriptor is currently active by reading its IsActive property.

### CompositeFilterDescriptor

The CompositeFilterDescriptor is nothing more than a collection of other IFilterDescriptor’s combined with a logical operator (AND/OR). Its children are stored in its FilterDescriptors property and can be any valid implementation of the IFilterDescriptor interface, which allows you to construct unlimited filtering criteria trees. These child filters are combined together with the LogicalOperator which can be either AND or OR.

Imagine that we would like to get only people between the ages of 18 and 60 who are from Spain. Here is how this can be achieved:

#### __C#__

{{region gridview-filtering-programmatic_4}}
	Telerik.Windows.Data.FilterDescriptor olderThan18Filter = new Telerik.Windows.Data.FilterDescriptor("Age", Telerik.Windows.Data.FilterOperator.IsGreaterThanOrEqualTo, 18);
	Telerik.Windows.Data.FilterDescriptor youngerThan60Filter = new Telerik.Windows.Data.FilterDescriptor("Age", Telerik.Windows.Data.FilterOperator.IsLessThan, 60);
	
	Telerik.Windows.Data.CompositeFilterDescriptor ageFilter = new Telerik.Windows.Data.CompositeFilterDescriptor();
	ageFilter.FilterDescriptors.Add(olderThan18Filter);
	ageFilter.FilterDescriptors.Add(youngerThan60Filter);
	ageFilter.LogicalOperator = Telerik.Windows.Data.FilterCompositionLogicalOperator.And;
	
	Telerik.Windows.Data.FilterDescriptor liveInSpainFilter = new Telerik.Windows.Data.FilterDescriptor("Country", Telerik.Windows.Data.FilterOperator.IsEqualTo, "Spain");
	
	Telerik.Windows.Data.CompositeFilterDescriptor mainFilter = new Telerik.Windows.Data.CompositeFilterDescriptor();
	mainFilter.FilterDescriptors.Add(ageFilter);
	mainFilter.FilterDescriptors.Add(liveInSpainFilter);
	mainFilter.LogicalOperator = Telerik.Windows.Data.FilterCompositionLogicalOperator.And;
	
	this.radGridView.FilterDescriptors.Add(mainFilter);
	{{endregion}}



#### __VB.NET__

{{region gridview-filtering-programmatic_4}}
		' Give me all people that are named John.
		Dim olderThan18Filter As New Telerik.Windows.Data.FilterDescriptor("Age", Telerik.Windows.Data.FilterOperator.IsGreaterThanOrEqualTo, 18)
		Dim youngerThan60Filter As New Telerik.Windows.Data.FilterDescriptor("Age", Telerik.Windows.Data.FilterOperator.IsLessThan, 60)
	
		Dim ageFilter As New Telerik.Windows.Data.CompositeFilterDescriptor()
		ageFilter.FilterDescriptors.Add(olderThan18Filter)
		ageFilter.FilterDescriptors.Add(youngerThan60Filter)
		ageFilter.LogicalOperator = Telerik.Windows.Data.FilterCompositionLogicalOperator.[And]
	
		Dim liveInSpainFilter As New Telerik.Windows.Data.FilterDescriptor("Country", Telerik.Windows.Data.FilterOperator.IsEqualTo, "Spain")
	
		Dim mainFilter As New Telerik.Windows.Data.CompositeFilterDescriptor()
		mainFilter.FilterDescriptors.Add(ageFilter)
		mainFilter.FilterDescriptors.Add(liveInSpainFilter)
		mainFilter.LogicalOperator = Telerik.Windows.Data.FilterCompositionLogicalOperator.[And]
	
		Me.radGridView.FilterDescriptors.Add(mainFilter)
	{{endregion}}



So in the end you will get the following filtering criteria tree:

Filtering Criteria Tree Concept![](images/gridview_filtering_programmatic_02.png)

The data engine will generate something similar in pseudo-code:

people.Where(person => (person.Country == "Spain" && (person.Age >= 18 && person.Age < 60)));

The lambda expression that you see inside the Where clause was build based upon the descriptors that we defined. But if you implement the IFilterDescriptor yourself you can supply any kind of custom expression that will be used by data engine as long as it is valid and can be compiled and executed at runtime.

As you might have already guessed, the IColumnFilterDescriptor that is used for column filtering also uses these classes under the hood to construct its expression. Honoring the interface contract makes sure that you can only add things that can be displayed in the fixed layout filtering UI. Deep down inside, the IColumnFilterDescriptor looks something like this:

Column Filter Descriptor Tree![](images/gridview_filtering_programmatic_03.png)

Notice how this hierarchy is the same as the Popup filtering control layout. Working through the IColumnFilterDescriptor interface makes sure that you cannot randomly add criteria which cannot be correctly displayed by the Popup filtering control.

# See Also

 * [Visual Structure]({%slug gridview-visual-structure%})

 * [Basic Filtering]({%slug gridview-filtering-basic%})
