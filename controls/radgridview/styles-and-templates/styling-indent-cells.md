---
title: Styling Indent Cells
page_title: Styling Indent Cells
description: Learn how to alter the appearance of indent cells by modifying their default styles or by directly editing their control templates.
components: ["gridview"]
slug: radgridview-styling-indent-cells
tags: styling,indent,cells,in,radgridview
published: True
position: 17
---

# Styling Indent Cells

__RadGridView__ displays different indent cells when grouped, in a hierarchy, or when displaying footers. The following image identifies indent cells and row indicators in a grouped RadGridView with __ShowColumnFooters__ and __ShowGroupFooters__ set to True.

>caption RadGridView indent cells and indicator presenters

![Telerik UI for {{ site.framework_name }} RadGridView showing indent cells and indicator presenters in a grouped grid](images/RadGridView_StyleIndicators1.png)

## Indent Cells

RadGridView exposes four different indent cell types:

* **GridViewIndentCell**: It is part of the **GridViewRow**.

* **GridViewHeaderIndentCell**: It is part of the **GridViewHeaderRow**.

* **GridViewFooterIndentCell**: It is part of the **GridViewFooterRow**.

* **GridViewGroupFooterIndentCell**: It is part of the **GridViewGroupFooterRow**.

Create styles that target the indent cells to customize their appearance, as shown in __Example 1__. You can also [edit their control templates]({%slug styling-apperance-editing-control-templates%}).

__Example 1: Styling Indent Cells__

<snippet id='radgridview-styles-and-templates-styling-indent-cells-example_1_styling_indent_cells-xaml' />


>caption A grouped RadGridView with styled indent cells

![Telerik UI for {{ site.framework_name }} RadGridView with custom styles applied to grouped indent cells](images/gridview-styling-indent-cells.png)

## See Also

* [Styling Rows]({%slug gridview-styling-a-row%})

* [Styling Group Row]({%slug gridview-styling-group-row%})

* [Styling Header Row]({%slug gridview-styling-header-row%})