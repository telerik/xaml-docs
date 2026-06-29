---
title: Overview
page_title: RadTreeListView Overview
description: Learn what Telerik UI for WPF RadTreeListView does, when to use it, and which features to explore first.
slug: radtreelistview-overview
tags: overview
published: True
position: 0
CTAControlName: RadTreeListView
---
# {{ site.framework_name }} TreeListView Overview

Use `RadTreeListView` to display hierarchical data in a tabular layout. The control combines the data operations and column model of `RadGridView` with tree-style expand and collapse behavior, which makes it suitable for scenarios such as file explorers, organizational structures, category trees, and nested business records.

This overview highlights the main capability areas of `RadTreeListView` and points you to the most relevant next article for setup, performance, and advanced data scenarios.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

![{{ site.framework_name }} RadTreeListView Overview](images/RadTreeListView_Overview_03.png)

## When to Use RadTreeListView

Use `RadTreeListView` when you need to:

* Show homogeneous hierarchical data in a single table.
* Combine expand and collapse behavior with sortable and filterable columns.
* Work with large hierarchical data sets while keeping the UI responsive.
* Let users edit, validate, select, and inspect nested records without switching controls.

If your scenario requires heterogeneous child structures, evaluate a hierarchical `RadGridView` instead of `RadTreeListView`.

## Key Features

### Performance for Large Data Sets

`RadTreeListView` combines native UI virtualization, container recycling, and a LINQ-based data engine to keep scrolling and interaction responsive even with large data sets. To learn how to tune performance-sensitive scenarios, see [Performance]({%slug radtreelistview-performance%}) and [UI Virtualization]({%slug radtreelistview-features-ui-virtualization%}).

### Hierarchical Data Binding

Define parent-child relationships through the data binding system and choose where the hierarchy column appears in the grid. This allows layouts similar to file explorers and other tree-based business views. See [Data Binding]({%slug radtreelistview-features-data-binding%}) and [Hierarchy Column]({%slug radtreelistview-features-hierarchy-column%}).

### Built-In Data Operations

Apply [sorting]({%slug radtreelistview-features-sorting%}) and [filtering]({%slug radtreelistview-features-filtering%}) directly to your bound data while preserving the hierarchy structure. Parent nodes remain visible when matching child nodes need their context.

### Columns, Details, and Aggregates

Choose from multiple built-in [column types]({%slug radtreelistview-features-columns%}), keep important values visible with frozen columns, show extra content through [row details]({%slug radtreelistview-features-row-details%}), and calculate summary values through [aggregates]({%slug radtreelistview-features-aggregates%}).

### Editing, Validation, and Selection

Use the built-in selection model for single or multiple records, and combine editing with metadata-driven validation and custom validation logic. For more detail, see [Selection]({%slug radtreelistview-features-selection%}) and [Managing Data]({%slug radtreelistview-features-managing-data%}).

### Appearance and Customization

Adapt `RadTreeListView` to your application theme and editing workflow through styling, templating, and custom editors. The control supports a flexible appearance model and integrates with the theming system used across Telerik UI for WPF.

## Common Next Steps

Start with the article that matches your immediate goal:

* To create your first tree grid and bind sample data, open [Getting Started]({%slug radtreeliestview-getting-started%}).
* To understand how the control behaves with larger data sets, open [Performance]({%slug radtreelistview-performance%}).
* To configure hierarchy relationships and columns, open [Data Binding]({%slug radtreelistview-features-data-binding%}) and [Columns]({%slug radtreelistview-features-columns%}).
* To inspect events and extensibility points, open [Events]({%slug radtreelistview-events%}).
* To see runnable examples, open [Developer Focused Examples]({%slug radtreelistview-sdk-examples%}).

>note Explore the control demos at [demos.telerik.com](https://demos.telerik.com/wpf/) to review RadTreeListView behavior before integrating it into your application.

>tip You can find additional implementation examples in the [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/) under `TreeListView`.

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
