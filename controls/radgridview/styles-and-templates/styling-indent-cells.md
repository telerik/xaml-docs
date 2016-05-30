---
title: Styling Indent Cells
page_title: Styling Indent Cells
description: Styling Indent Cells
slug: radgridview-styling-indent-cells
tags: styling,indent,cells,in,radgridview
published: True
position: 17
---

# Styling Indent Cells

RadGridView does expose different [indent cells](#indent-cells) and [indicator presenters](#indicator-presenters) depending on its current state - being grouped, in a hierarchy, or displaying the corresponding footers. Generally, the structure is as follows:

#### __Figure 1: RadGridView Indent Cells__

![RadGridView Indent Cells](images/RadGridView_StyleIndicators1.png)

## Indent Cells

RadGridView exposes four different indent cells:

* **GridViewIndentCell**: It is a part of the **GridViewRow**.

* **GridViewHeaderIndentCell**: It is a part of the **GridViewHeaderRow**.

* **GridViewFooterIndentCell**: It is a part of the **GridViewFooterRow**.

* **GridViewGroupFooterIndentCell**: It is a part of the **GridViewGroupFooterRow**.

Similarly to other RadGridView elements, you may alter their appearance by [modifying their default styles]({%slug gridview-modifying-default-styles%}) or by directly [editing their control templates]({%slug styling-apperance-editing-control-templates%}).

## Indicator Presenters

Furthermore, RadGridView exposes five indicator presenters each of them belonging to the corresponding row:

* **GridViewRow**

* **GridViewHeaderRow**

* **GridViewGroupRow**

* **GridViewGroupFooterRow**

* **GridViewFooterRow**

You may customize each of them by editing the control template of the respective row and modify the **Border** element named **PART_IndicatorPresenter** as illustrated below:

#### __Figure 2: Modifying indent presenters__

![Modifying indent presenters](images/RadGridView_HeaderRowIndicator.png)

**Figure 3** shows a RadGridView with styled indent cells and indicator presenters.

#### __Figure 3: RadGridView with styled indent cells and indicator presenters__

![RadGridView with styled indent cells and indicator presenters](images/RadGridView_IndentCells2.png)

## See Also

* [Styling Rows]({%slug gridview-styling-a-row%})

* [Styling Group Row]({%slug gridview-styling-group-row%})

* [Styling Header Row]({%slug gridview-styling-header-row%})