---
title: Binding To Object
page_title: Binding To Object
description: Check our &quot;Binding To Object&quot; documentation article for the RadAutoCompleteBox {{ site.framework_name }} control.
slug: radautocompletebox-populating-with-data-binding-to-object
tags: binding,to,object
published: True
position: 2
---

# Binding To Object

To bind __RadAutoCompleteBox__ to a collection of business object, you should use its ItemsSource property.

The following example will guide you through the process of binding your RadAutoCompleteBox to a collection of business objects. The example includes:

* [Binding the ItemsSource](#binding-the-itemssource)

* [Using DisplayMemberPath and TextSearchPath](#using-displaymemberpath-and-textsearchpath)

>tip Before proceeding with this tutorial you should get familiar with the [Data Binding]({%slug radautocompletebox-populating-with-data-binding-support-overview%}) support of the RadAutoCompleteBox control.

## Binding the ItemsSource

1. First you will need to add __RadAutoCompleteBox__ to your project:

	__Add RadAutoCompleteBox__

<snippet id='radautocompletebox-populating-with-data-binding-to-object-block_1-xaml' />

1. Create a business object called Country:

	__Creation of the object__

<snippet id='radautocompletebox-populating-with-data-binding-to-object-block_2-cs' />

1. Create a new class named __ViewModel__. In fact, this will be the data source for the RadAutoCompleteBox and this class has only one purpose - to initialize a collection with sample data.

	__ViewModel creation__

<snippet id='radautocompletebox-populating-with-data-binding-to-object-block_3-cs' />

1. Declare the __ViewModel__ as a resource in your XAML: 

	__Declaring the ViewModel__

<snippet id='radautocompletebox-populating-with-data-binding-to-object-block_4-xaml' />

1. Update your __RadAutoCompleteBox__ declaration and its __ItemsSource__ property:

	__Update the ItemsSource property__

<snippet id='radautocompletebox-populating-with-data-binding-to-object-block_5-xaml' />

1. Set the DisplayMemberPath property of the control.

	__Setting the DisplayMemberPath__

<snippet id='radautocompletebox-populating-with-data-binding-to-object-block_6-xaml' />

The next screenshots show the final result:

![radautocompletebox-features-autocomplete-1](images/radautocompletebox-features-autocomplete-1.png)

![radautocompletebox-populating-with-data-binding-to-object-3](images/radautocompletebox-populating-with-data-binding-to-object-3.png)

![radautocompletebox-populating-with-data-binding-to-object-2](images/radautocompletebox-populating-with-data-binding-to-object-2.png)

## Using DisplayMemberPath and TextSearchPath

Setting both __DisplayMemberPath__ and __TextSearchPath__ properties will allow to search by specific property of the business object and at the same time display a different property in the DropDown and in the TextBox after selection.

In the next code snippets we will demonstrate how to use these properties together by extending the previous example from the [Binding the ItemsSource](#binding-the-itemssource) section:

1. Set the __DisplayMemberPath__ to a specific property of the used business object:

	__Setting the DisplayMemberPath__

<snippet id='radautocompletebox-populating-with-data-binding-to-object-block_7-xaml' />

1. Set the __TextSearchPath__ to a specific property of the used business object: 

	__Setting the TextSearchPath__

<snippet id='radautocompletebox-populating-with-data-binding-to-object-block_8-xaml' />

The next screenshots show how __RadAutoCompleteBox__ behaves when its DisplayMemberPath and TextSearchPath properties are set:

![radautocompletebox-features-autocomplete-1](images/radautocompletebox-features-autocomplete-1.png)

![radautocompletebox-populating-with-data-binding-to-object-1](images/radautocompletebox-populating-with-data-binding-to-object-1.png)

![radautocompletebox-populating-with-data-binding-to-object-2](images/radautocompletebox-populating-with-data-binding-to-object-2.png)
