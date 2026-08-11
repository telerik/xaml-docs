---
title: Data Binding
page_title: Data Binding
description: This article demonstrates how to bind the RadTabbedWindow control to a collection of business objects.
slug: radtabbedwindow-data-binding
tags: getting,started
published: True
position: 2
---

# Data Binding

This article demonstrates how to bind the RadTabbedWindow control to a collection of business objects.

For the purposes of this example the control is bound to a collection of **Tab** objects. Please note that the class inherits from **ViewModelBase** which is the Telerik implementation of the **INotifyPropertyChanged** interface.

__Example 1: The Tab class__

<snippet id='radtabbedwindow-data-binding-block_1-cs' />

The next step is to create an __ObservableCollection__ of Tab objects in your viewmodel.

__Example 2: Create an ObservableCollection in the viewmodel__

<snippet id='radtabbedwindow-data-binding-block_2-cs' />

All that's left is to bind this collection to the RadTabbedWindow control. You also need to define the **DisplayMemberPath** and **ContentTemplate** properties so that the tabs appear as expected.

__Example 3: Bind the ItemsSource property__

<snippet id='radtabbedwindow-data-binding-block_3-xaml' />

>important As of **R2 2019 SP1** the control's **Items** property (populated when setting the control's **ItemsSource**) is of type **IList**. Prior to this version of the controls, it was of type **ObservableCollection<RadTabitem>**.

<!-- -->

>important Please note that you need to replace the **DataBinding** namespace with your namespace.

Upon running the application, your RadTabbedWindow will now be populated with tabs as shown on **Figure 1**.

__DataBound RadTabbedWindow__

![Telerik UI for WPF RadTabbedWindow data binding showing tabs generated from an ItemsSource collection](images/tabbedwindow-getting-started-2.png)

## See Also

* [Key Properties]({%slug radtabbedwindow-key-properties%})
* [Events]({%slug radtabbedwindow-events%})
* [Styles and Templates]({%slug radtabbedwindow-styles-and-templates%})