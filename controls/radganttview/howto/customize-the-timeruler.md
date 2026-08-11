---
title: Customize the TimeRuler Data and Containers
page_title: Customize the TimeRuler Data and Containers
description: Check our &quot;Customize the TimeRuler Data and Containers&quot; documentation article for the RadGanttView {{ site.framework_name }} control.
slug: radganttview-howto-customize-the-timeruler
tags: customize,the,timeruler,data,and,containers
published: True
position: 1
---

# Customize the TimeRuler Data and Containers

In __RadGanttView__ it is possible to customize the way items are rendered in the TimeRuler portion of the control and add additional custom elements by creating a custom __TimeRulerVisualizationBehavior__.
    
## Creating ProjectDeadLine

In the next example we will show how to create a project deadline marker in the TimeRuler portion of the GanttView control.

>Before proceeding with this tutorial you should get familiar with [Implementing View-ViewModel]({%slug radganttview-populating-with-data-viewmodel%}) help article.

The example will go through on the following key steps:

* Creating a custom __TimeRulerTickInfo__

* Creating a custom __TimeRulerContainer__

* Creating a custom __TimeRulerContainerSelector__

* Creating a custom __TimeRulerBehavior__

>It is important to note that when creating a custom TimeRulerVisualizationBehavior you will need to set a negative Margin to the Style for the custom TimeRulerContainer (Step 6) in order for the visual element to be visible in the TimeRuler portion of the control. Also you will need to set the Template of the container (Step 6).

The next steps go through on how to create a custom TimeRulerVisualizationBehavior, create a ProjectDeadline property and render a corresponding visual line in the TimeRuler of the GanttView control.

1. Create a ViewModel, initialize and populate its __Tasks__ and __VisibleTime__ properties with some sample data:

	<snippet id='radganttview-howto-customize-the-timeruler-block_1-cs' />


1. Create a __TimeRulerDeadlineTickInfo__ class that implements IEventInfo and ICellCoordinates interfaces. This class will hold the information for the container that needs to be rendered in the TimeRuler portion of the GanttView control:

	<snippet id='radganttview-howto-customize-the-timeruler-block_2-cs' />


1. Create __TimeRulerDeadlineBehavior__ class that inherits DefaultTimeRulerVisualizationBehavior class, override its GetVisibleItems () method and add a ProjectDeadline property of type DateTime:

	<snippet id='radganttview-howto-customize-the-timeruler-block_3-cs' />


	>The DefaultTimeRulerVisualizationBehavior is responsible for rendering the time ticks in the TimeRuler portion of the control.

1. Create a __TimeRulerDeadlineBehavior__ property, a __ProjectDeadline__ property of type DateTime and initialize them in the __ViewModel__.

	<snippet id='radganttview-howto-customize-the-timeruler-block_4-cs' />


1. Create a custom __TimeRulerDeadlineContainer__ that inherits Control class and implements IDataContainer interface:

	<snippet id='radganttview-howto-customize-the-timeruler-block_5-cs' />


1. Create a __Style__ that targets the newly created __TimeRulerDeadlineContainer__ and set its properties:

	<snippet id='radganttview-howto-customize-the-timeruler-block_6-xaml' />


1. Next you will need to create a custom TimeRulerDeadlineContainerSelector that inherits DefaultTimeRulerContainerSelector and override its GetContainerType() method in order to return the custom container.

	<snippet id='radganttview-howto-customize-the-timeruler-block_7-cs' />


1. Finally you will need to set the GanttView control in the XAML by setting its TasksSource, TimeLineVisualizationBehavior, VisibleRange and TimeRulerContainerSelector. The XAML for the GanttView should look like this:

	<snippet id='radganttview-howto-customize-the-timeruler-block_8-xaml' />


The next screenshot shows the final result (the red line represents the ProjectDeadline):

![radganttview-howto-customize-the-timeruler-1](images/radganttview-howto-customize-the-timeruler-1.png)