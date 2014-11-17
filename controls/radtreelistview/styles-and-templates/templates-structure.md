---
title: Templates Structure
page_title: Templates Structure
description: Templates Structure
slug: radtreelistview-templates-structure
tags: templates,structure
published: True
position: 1
---

# Templates Structure



This section is intended to give a broad understanding of the possible ways for modifying the appearance of the __RadTreeListView__ and its elements. This can be achieved either by using the resources exposed by the API or by changing the appropriate __ControlTemplates__. Once you decide on the later, you will be able to reorder some of the template parts or add your own elements. However, in this case you should be careful to include all required parts. 

Basically, this topic will make you familiar with:

* [RadTreeListView Template Structure](#radtreelistview);

* [TreeListViewRow Template Structure](#treelistviewrow);

As the __RadTreeListView__ inherits __RadGridView__, it uses the same styling mechanism and the rest of the templates are equal. You may take a look at the [Styles and Templates]({%slug radgridview-styles-and-templates-templates-structure%}) section of the __RadGridView__ for further reference.
      

>tip For more information about templating and how to modify the default template of the RadControls read [the common topics]({%slug styling-apperance-editing-control-templates%}) on this matter.
      

## RadTreeListView

![](images/TreeLisView_TreeListViewStructure.png)

* **PART_MasterGridContainer** - hosts the elements of the template. It is of type Border and represents the border of the __RadGridView__.

* __HierarchyBackground__ - provides columns and rows for the template elements. It is of type __Grid__ and represents the background of the __RadTreeListView__. 

* **PART_ITemsScrollViewer** - represent the control that handles the different types of rows(e.g. Header Row, Footer Row, New Row) and is of type __GridViewScrollViewer__.

* **PART_TreeListViewVirtualizingPanel** - displays the data items of the __RadTreeListView__ and is of type __GridViewVirtualizingPanel__.

* **PART_ScrollPositionIndicator** - represents the scrolling indicator that appears when using deferred scrolling in the __RadTreeListView__ and is of type __ScrollPositionIndicator__.

* **PART_FrozenColumnsPreview** - represents the drag preview of the draggable element that is used for freezing the __RadTreeListView__.

* **PART_GridViewLoadingIndicator** - represents the indicator that appears when the __RadTreeListView__ is loading its data.

* __DragBetweenItemsFeedback__ - represents the __RadTreeListView DragVisualCue__ that is enabled when the following properties are set to ___True___ - __IsDragDropEnabled__, __IsDragPreviewEnabled, IsDragToolTipEnabled__.  

## TreeListViewRow

![](images/TreeLisView_TreeListViewRowStructure.png)



* __Grid__ - host the element of the __TreeListViewRow__ template and it of type __SelectiveScrollingGrid__.

* __SelectionBackground__ - represents the default background of the row and is of type __Border__.

* **Background_Over** - represents the outer border of the row, when the mouse is over it and is of type __Border__.

* __[Border]__ - represents the inner border and the background of the row, when the mouse is over and is of type __Border__.

* **Background_Selected** - represents the outre border of the row, when it is selected and is of type __Border__.

* __[Border]__ - represents the inner border and the background of the row, when it is selected and is of type __Border__.

* **Background_Invalid** - represent the outer border of the row, when it is invalid and is of type __Border__.

* __[Border]__ - represent the inner border and the background of the row, when it is invalid and is of type __Border__.

* __[GridViewToggleButton]__ - represents the button that expands the row and is of type __GridViewToggleButton__.

* __[Border]__ 

* **PART_DataCellsPresenter** - displays the cells of the row and is of type __TreeListCellsPanel__.

* **PART_RowBorder** - represents the border at the bottom of the row and is of type __Border__.

* __[Border]__ - represents the border and the background of the hierarchy container and is of type __Border__.

* **PART_HierarchyChildPresenter** - displays the hierarchy children and is of type __ContentPresenter__.

* **PART_DetailsPResenter** - represents the row's details and is of type __DetailsPresenter__.

* **PART_IndicatorPResenter** - hosts the elements of the row's indicator and represents its outer border. It is of type __Border__.

* __[Border]__ - represents the inner border and the background of the row's indicator and is of type __Border__.

* __[Grid]__ - hosts the different indicators and is of type __Grid__.

* __ErrorIndicator__ - hosts the __Paths__ for the indicator, when the row is invalid. It is of type __Grid__.

* __[Path]__

* __[Path]__

* __[Path]__

* __NavigationIndicator__ - hosts the __Paths__ for the indicator, when the row is selected. It is of type __Grid__.

* __[Path]__

* __[Path]__

* __[Path]__

* __EditIndicator__ - hosts the Paths for the indicator, when the row is being edited. It is of type __Grid__.

* __[Path]__
  
* __[Path]__
  
* __[Path]__
  
* __[Path]__ 


