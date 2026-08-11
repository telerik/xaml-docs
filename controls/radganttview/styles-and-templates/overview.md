---
title: GanttView Styles
page_title: GanttView Styles
description: Check our &quot;GanttView Styles&quot; documentation article for the RadGanttView {{ site.framework_name }} control.
slug: radganttview-styles-and-templates-overview
tags: ganttview,styles
published: True
position: 1
---

# GanttView Styles

{% if site.site_name == 'Silverlight' %}__RadGanttView__ supports styling only with Implicit Styles.{% endif %} You can check how to set a theme to the control in [this topic]({%slug radganttview-styles-and-templates-setting-theme%}). Using implicit styles makes it much easier to customize different parts of the control.

>Before proceeding, check the {% if site.site_name == 'Silverlight' %}[Implicit Style]({%slug styling-apperance-implicit-styles-overview%}){% endif %}{% if site.site_name == 'WPF' %}[Implicit Style]({%slug styling-apperance-implicit-styles-overview%}){% endif %} article.

You can modify the look of the __RadGanttView__ and its elements separately by simply creating an implicit style with the correct TargetType. Also you will have the option to create a Style based on the default Style for a certain element.

Let’s for example have a GanttView control defined like this:



<snippet id='radganttview-styles-and-templates-overview-block_1-xaml' />


The following scheme shows the name of each element  that can be styled:

![ganttview styles 01](images/ganttview_styles_01.png)

In the next screenshots we will focus on the Columns part of the GanttView control:

>CellHighlight and TreeCellHighlight are used for both highlighted and selected states of the Cell/TreeCell respectively.

If we have CellTemplate and/or CellEditTemplate defined, the generated containers are different. For example, let&s change our GanttView Columns like this:



<snippet id='radganttview-styles-and-templates-overview-block_2-xaml' />


The containers in the grid will be Cell/TreeCell instead of SimpleCell/SimpleTreeCell. Also the containers for editing will be CellEditing/TreeCellEditing:

![ganttview styles 09](images/ganttview_styles_09.png)

In case we have SpecialSlots defined:



<snippet id='radganttview-styles-and-templates-overview-block_3-xaml' />


We can style them as well:

![ganttview styles 02](images/ganttview_styles_02.png)

The next screenshots show all the elements used for DragDrop and Resize functionality of the control:

![ganttview styles 03](images/ganttview_styles_03.png)![ganttview styles 04](images/ganttview_styles_04.png)

![ganttview styles 05](images/ganttview_styles_05.png)

In the following table you will find the corresponding TargetType for each of these elements:

<b>Element<b/>	|	<b>TargetType<b/>
---	|	---
Relation	|	RelationContainer
Event	|	EventContainer
Summary	|	SummaryContainer
Milestone	|	MilestoneContainer
ColumnHeader	|	ColumnHeaderContainer
SimpleCell	|	SimpleCellContainer
Cell	|	CellContainer
CellHighlight	|	CellHighlightContainer
CellEditing	|	CellEditingContainer
SimpleTreeCell	|	SimpleTreeCellContainer
TreeCell	|	TreeCellContainer
TreeCellHighlight	|	TreeCellHighlightContainer
TreeCellEditing	|	TreeCellEditingContainer
BorderContainer	|	BorderContainer
AlternatingBorderContainer	|	AlternatingBorderContainer
SpecialSlot	|	SpecialSlotContainer
GroupTick	|	GroupTickContainer
MinorTick	|	MinorTickContainer
MajorTick	|	MajorTickContainer
CurrentHourTick	|	CurrentHourTickContainer
RowHighlight	|	RowHighlightContainer
RowSelection	|	RowSelectionContainer
DragResizeSlotHighlight	|	DragResizeSlotHighlightContainer
DragResizeMilestoneSlotHighlight	|	DragResizeMilestoneSlotHighlightContainer
DragResizeSummarySlotHighlight	|	DragResizeSummarySlotHighlightContainer
GanttDragResizeVisualCue	|	GanttDragResizeVisualCue
GanttPresenterSplitter	|	GanttPresenterSplitter
ExpandToggleButton	|	ToggleButton
Deadline		|	DeadlineContainer

## Examples

We will go through two examples:

* [Basing Styles on a theme Style](#basing-styles-on-a-theme-style)

* [Setting implicit style to a certain element](#setting-implicit-style-to-a-certain-element)

### Basing Styles on a theme Style

Each of these containers listed in the table has a style formed by the name of the container type followed by a “Style” suffix. For example, for the EventContainer there is a style with x:Key=”EventContainerStyle”.

So, let’s create the following implicit style:



<snippet id='radganttview-styles-and-templates-overview-block_4-xaml' />


This will lead to the following result:

![ganttview styles 06](images/ganttview_styles_06.png)

### Setting implicit style to a certain element

In case you need to further customize an element, you could create an implicit style for it. Here is a simple example for the DragResizeSlotHighlightContainer element:



<snippet id='radganttview-styles-and-templates-overview-block_5-xaml' />


After adding this Style, the element will look like this:![ganttview styles 07](images/ganttview_styles_07.png)
