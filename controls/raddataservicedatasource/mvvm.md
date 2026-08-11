---
title: MVVM Support
page_title: MVVM Support
description: Check our &quot;MVVM Support&quot; documentation article for the RadDataServiceDataSource {{ site.framework_name }} control.
slug: raddataservicedatasource-mvvm
tags: mvvm,support
published: True
position: 4
---

# MVVM Support

The assembly in which __RadDataServiceDataSource__ is located contains a class named __QueryableDataServiceCollectionView&lt;T&gt;.__ This is the collection view that the control uses internally. The only functionality that the control adds over this collection view is XAML-friendly API.

In case you are strictly following the __MVVM pattern__ and you cannot embed an UI control inside your view model, you can use the __QueryableDataServiceCollectionView&lt;T&gt;__ class. Like __RadDataServiceDataSource__, the __QueryableDataServiceCollectionView&lt;T&gt;__ needs a __DataServiceContext__ and a __DataServiceQuery&lt;T&gt;__ to be constructed.

>The examples in this article are based on the setup from the [Creating the Client Application]({%slug raddataservicedatasource-getting-started-creating-the-client-application%}) and [Creating the Data-bound Controls]({%slug raddataservicedatasource-getting-started-creating-the-data-bound-controls%}) article.

The __QueryableDataServiceCollectionView&lt;T&gt;__ class has the same API as the __RadDataServiceDataSource__ control so all operations are performed in the same way as with RadDataServiceDataSource. In fact, the public API of the control simply exposes the public API of its inner collection view, which is the one that really does the job.

**Example 1** demonstrates how to set up your viewmodel to use the QueryableDataServiceCollectionView class.

__Example 1: Creating the viewmodel class__

<snippet id='raddataservicedatasource-mvvm-example_1_creating_the_viewmodel_class-cs' />

<snippet id='raddataservicedatasource-mvvm-example_1_creating_the_viewmodel_class-vb' />


You can then set up your data controls in the same way you would if you were using the RadDataServiceDataSource control.

__Example 2: Binding the data controls__

<snippet id='raddataservicedatasource-mvvm-example_2_binding_the_data_controls-xaml' />


## See Also
* [ViewModelBase class]({%slug common-viewmodelbase-class%})
* [Creating the Client Application]({%slug raddataservicedatasource-getting-started-creating-the-client-application%})
* [Creating the Data-bound Controls]({%slug raddataservicedatasource-getting-started-creating-the-data-bound-controls%})
