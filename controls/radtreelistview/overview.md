---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadTreeListView {{ site.framework_name }} control.
slug: radtreelistview-overview
tags: overview
published: True
position: 0
CTAControlName: RadTreeListView
---
# {{ site.framework_name }} TreeListView Overview

Thank you for choosing Telerik __RadTreeListView__! 

Telerik __RadTreeListView__ combines the powerful data-driven features from __RadGridView__ with the capabilities of showing a hierarchical data in a __TreeView__ manner. Native UI virtualization, LINQ-based data engine, filtering, sorting and built-in data validation are just a few of the features the control provides.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

![{{ site.framework_name }} RadTreeListView Overview](images/RadTreeListView_Overview_03.png)

## Key Features

* __LINQ-Based Data Engine__ and __Native UI Virtualization__: Telerik __RadTreeListView__ handles millions of records without affecting the user experience. The control utilizes horizontal and vertical UI virtualization and introduces container recycling for further improvement of speed and memory footprint, especially when bound to large data sets. The UI virtualization technique ensures that the __TreeListView__ creates only the needed containers (rows/cells) which are shown in the viewport of the grid. The container recycling pushes further the speed of scrolling horizontally and vertically. This feature enables __RadTreeListView__ to reuse the existing containers over and over for different data items, instead of creating new ones. These techniques combined with our outstanding LINQ-based data engine guarantee the exceptional fast performance of Telerik’s __RadTreeListView__. Read more about this in the [UI Virtualization]({%slug radtreelistview-features-ui-virtualization%}) article.

* __Hierarchy Column__: __RadTreeListView__ supports defining of hierarchy relations through the data binding system. Ability to change the hierarchy column index allows flexible tree grid structures similar to Windows Explorer or iTunes. Read more about this in the [Hierarchy Column]({%slug radtreelistview-features-hierarchy-column%}) article.

* __Data Binding__: Binding the __RadTreeListView__ is as simple as setting a single property. Read more about this in the [Data Binding]({%slug radtreelistview-features-data-binding%}) article.

* __Direct Data Operations__: With Telerik __RadTreeListView__ data operations ([Sorting]({%slug radtreelistview-features-sorting%}), [Filtering]({%slug radtreelistview-features-filtering%})) work directly with your data objects. In a common scenario when a control is performing data operations, you need to create your own collection view. With Telerik __RadTreeListView__ there is no requirement for wrapping your data in collection views to do sorting, grouping, and filtering.

* __Data Source Updates__: To achieve better testability and loose coupling in your code it may be more convenient to manipulate data in the original data source instead of using the __RadTreeListView__ API. Telerik __RadTreeListView__ supports that scenario by listening to data source collection change events and reflecting those changes in its visual representation.

* __Truly Lookless, Blend Skinnable, Completely Customizable Control__: Telerik __RadTreeListView__ can have its appearance and animations completely customized through __Microsoft Expression Blend__. You can use your own theme or you can use one of the several themes shipped with the control, which will help you deliver a consistent look and feel in your application. 

* __Aggregate Functions__: Telerik __RadTreeListView__ control offers a built-in totals row which makes it easy and fast to add a cell which represents the calculated values across a range of data. The summary row with aggregates is available for each column. The user can choose to show in the footer row from a variety of aggregate. Read more about this in the [Aggregates]({%slug radtreelistview-features-aggregates%}) article.

* __Sorting__: You can have Telerik __RadTreeListView__ automatically sort its columns by setting a single property. There are three sorting modes: __ascending__, __descending__ and __no sort__. In addition to the simple one-column sorting __RadTreeListView__ allows you to sort data by several columns. Sorting in __RadTreeListView__ is executed in a manner which respects the hierarchy structure of the data – when you sort by a certain column the main nodes are sorted first and then are sorted the child nodes. Read more about this in the [Sorting]({%slug radtreelistview-features-sorting%}) article.

* __Filtering__: Telerik __RadTreeListView__ allows end users to filter data by applying filter patterns or their own filter criteria. __RadTreeListView__ respects the nodes relations and if a child node matches the filter criteria, all higher parent nodes are shown. Read more about this in the [Filtering]({%slug radtreelistview-features-filtering%}) article.

* __Data Validation__: Telerik __RadTreeListView__ supports metadata-driven validation via data annotations. You can use the __RadTreeListView__ with the __Validation__ Summary class to implement the automatic validation UI provided by the platform and also benefit from the server-side validation attributes provided by __RIA Services__. The built-in validation operates on two layers – __UI__ and __Data__. Furthermore, using the extensible event based API of __RadTreeListView__ users can plug their own data validation mechanism. Read more about this in the [Managing Data]({%slug radtreelistview-features-managing-data%}) article.

* __Column Types__: The __RadTreeListView__ allows you to choose from several predefined column types. The supported out-of-the-box columns are __Data, Hyperlink, DynamicHyperlink, Image, Select, ToggleRowDetailsVisibility__ and __MaskedInput__. They provide a built-in validation support for editing which covers most of the editing scenarios. If there are specific requirements, the built-in columns can be inherited and their editing validation mechanism can be used without any problem. Furthermore, __RadTreeListView__ offers flexible appearance model through the __CellEditTemplate__ property of the column which allows any control to be used as the editor. Read more about this in the [Columns]({%slug radtreelistview-features-columns%}) article.

* __Frozen Columns__: __RadTreeListView__ allows you to keep part of your data always visible putting the rest of the data in context. To freeze columns, you simply set the __FrozenColumnCount__ property to the number of columns you want to freeze.

* __Row Details__: Telerik __RadTreeListView__ supports __Row Details__, which can be used to present additional information related to the row in a visually appealing manner. The __Row Details__ is a very convenient feature when the space at hand is insufficient for the data that needs to be presented. __Row Details__ can also be used for providing a more convenient editing environment for end-users. Defined through a data template, __Row Details__ can present virtually anything to the user, be it for viewing-only or editing. Read more about this in the [Row Details]({%slug radtreelistview-features-row-details%}) article.

* __Selection__: __RadTreeListView__ provides a familiar selection API that will make developers feel at home. The control supports single and multiple record selection that can be manipulated both with the mouse and the keyboard. Read more about this in the [Selection]({%slug radtreelistview-features-selection%}) article.

Check out the control's demos at: [https://demos.telerik.com/wpf/](https://demos.telerik.com/wpf/)

>tipYou can find more examples on how to implement various scenarios available for download from our online SDK repository [here](https://github.com/telerik/xaml-sdk/), the examples are listed under __TreeListView__.       

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Support and Learning Resources

* [Telerik UI for WPF TreeListView Homepage](https://www.telerik.com/products/wpf/treelistview.aspx)
* [Get Started with the Telerik UI for WPF TreeListView]({%slug radtreeliestview-getting-started%})
* [Telerik UI for WPF API Reference](https://docs.telerik.com/devtools/wpf/api/)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF TreeListView Forums](https://www.telerik.com/forums/wpf)
* [Telerik UI for WPF Knowledge Base](https://docs.telerik.com/devtools/wpf/knowledge-base)
{% endif %}

## See Also

 * [Visual Structure]({%slug radtreelistview-visual-structure%})
 * [Getting Started]({%slug radtreeliestview-getting-started%})
 * [Performance]({%slug radtreelistview-performance%})
 * [Events]({%slug radtreelistview-events%})
 * [Developer Focused Examples]({%slug radtreelistview-sdk-examples%})
