---
title: Drag and Drop from RadGridView to RadDiagram
page_title: Drag and Drop from RadGridView to RadDiagram
description: Check out our tutorial describing how to implement a drag/drop operation from a data-bound RadGridView to a RadDiagram control using DragDropManager.
slug: drag-and-drop-from-radgridview-to-raddiagram
tags: drag,and,drop,diagram
published: True
position: 1
---

# Drag and Drop from RadGridView to RadDiagram

This tutorial describes how to implement a drag/drop operation from a data-bound __RadGridView__ to a __RadDiagram__ control using __DragDropManager__.

>Please note that the examples in this tutorial are showcasing the Telerik Windows8 theme. In the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) article you can find more information on how to set an application-wide theme.

First we will specify the following ViewModels which are going to be used to populate the RadGridView and RadDiagram controls.

* __Employee:__ A class that will be the DataContext of the RadGridView rows.
* __EmployeeGraphSource:__ A class deriving from the __ObservableGraphSourceBase__ ViewModel that represents the RadDiagram __GraphSource__.
* __MainViewModel:__ The main ViewModel class of the application.
	
__Example 1: Creating ViewModels__
<snippet id='radgridview-how-to-drag-drop-gridview-diagram-example_1_creating_viewmodels-cs' />


Next, we can go ahead and define the __RadDiagram__ and __RadGridView__ controls in our view:

__Example 2: Defining RadDiagram and RadGridView in XAML__

<snippet id='radgridview-how-to-drag-drop-gridview-diagram-example_2_defining_raddiagram_and_radgridview_in_xaml-xaml' />


And finally, we need to set the DataContext of the MainWindow:

__Example 3: Setting DataContext__
<snippet id='radgridview-how-to-drag-drop-gridview-diagram-example_3_setting_datacontext-cs' />


If you run the application now, you should get a structure like in **Figure 1**:

#### Figure 1: RadGridView and RadDiagram
![Telerik UI for {{ site.framework_name }} RadGridView beside RadDiagram before drag and drop is implemented between the controls](images/drag-and-drop-from-radgridview-to-raddiagram_0.png)
	
You can observe that you still can't drag-drop a row from the RadGridView to the RadDiagram. This is expected as the drag-drop functionality is still not implemented. 

The next step is to make sure that the GridViewRows are draggable. We can do so by applying an implicit style that sets the __DragDropManager.AllowDrag__ attached property to __True__ on every __GridViewRow__.

__Example 4: Setting AllowDrag attached property__
<snippet id='radgridview-how-to-drag-drop-gridview-diagram-example_4_setting_allowdrag_attached_property-xaml' />

	
To create a visual clue that the user has started dragging a row, we can create a custom attached property. In the property changed callback we can subscribe to the __DragInitialize__ event of the __RadGridView__ using __DragDropManager__. In the event handler we can set the __DragVisual__ property from the event arguments.

__Example 5: Creating custom attached property__
<snippet id='radgridview-how-to-drag-drop-gridview-diagram-example_5_creating_custom_attached_property-cs' />


__Example 6: Setting the attached property to the RadGridView__
<snippet id='radgridview-how-to-drag-drop-gridview-diagram-example_6_setting_the_attached_property_to_the_radgridview-cs' />


The final step which we need to do is to subscribe to the **PreviewDrop** event of the RadDiagram. In the event handler we can get the current dragged row using the GetData() method of the Data property from the event arguments. Then you can add the item to the GraphSource of the RadDiagram.

__Example 7: Subcribe to the PreviewDrop event__
<snippet id='radgridview-how-to-drag-drop-gridview-diagram-example_7_subcribe_to_the_previewdrop_event-cs' />


__Example 8: PreviewDrop event handler__
<snippet id='radgridview-how-to-drag-drop-gridview-diagram-example_8_previewdrop_event_handler-cs' />


>For a more complex example, you can check out the [DragDropToDiagram](https://github.com/telerik/xaml-sdk/tree/master/GridView/DragDropToDiagram) example in the RadGridView SDK examples section.

## See Also
* [DragDropManager]({%slug dragdropmanager-getting-started%})
* [Use MVVM in RadDiagram]({%slug raddiagrams-howto-mvvm%})
* [Populating GridView with Data]({%slug gridview-data-overview%})
