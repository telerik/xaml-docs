---
title: Docked/Floating Panes
page_title: Docked/Floating Panes
description: Check our &quot;Docked/Floating Panes&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-features-panes-docked-floating-panes
tags: docked/floating,panes
published: True
position: 4
---

# Docked/Floating Panes

__RadPane__ is a flexible {{ site.framework_name }} control that can be either in docked or in floating state. Each newly created RadPane is docked by default in the root container but you can change this behavior either using the methods explained below or the properties (i.e. __InitialPosition__) exposed by the [RadSplitContainer]({%slug raddocking-features-split-container%}).

## Docking Panes

Docked panes are all these panes that are hosted inside the __RadDockng__ control.

The five possible docking positions are:

* __Left__: The __RadPane__ will be placed in the left side of the container. 

* __Top__: The __RadPane__ will be placed in the top side of the container. 

* __Right__: The __RadPane__ will be placed in the right side of the container. 

* __Bottom__: The __RadPane__ will be placed at the bottom side of the container. 

* __Tabbed document__: The docked __RadPane__ will be inserted as a new tab page.

To dock your panes declaratively to a certain position you have to host your panes in __RadSplitContainer__ and define its __InitialPosition__ property as it is shown in __Example 1__:

__Example 1: Set InitialPosition of RadSplitContainer__

```XAML
	<telerik:RadDocking x:Name="radDocking">
	    <telerik:RadSplitContainer x:Name="radSplitContainer" InitialPosition="DockedRight">
	        <telerik:RadPaneGroup x:Name="radPaneGroup">
	            <telerik:RadPane x:Name="radPane" Header="Docked Pane">
	                <TextBlock Text="Docked Pane."></TextBlock>
	            </telerik:RadPane>
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
```

In order to programmatically dock a __RadPane__ to a group, you have to remove it from its current parent first and then add it to the __RadPaneGroup__'s __Items__ collection as demonstrated in __Example 2__.

__Example 2: Remove RadPane from RadPaneGroup__

```C#
	radPane.RemoveFromParent();
	radPaneGroup.Items.Add(radPane);
```
```VB.NET
	radPane.RemoveFromParent()
	radPaneGroup.Items.Add(radPane)
```

>tipIf you need to control the docking run-time (while the user is dragging a pane), you could use the __PreviewShowCompass__ event of the __RadDocking__ control in combination with the __Is<*>IndicatorVisible__ series of properties of the __Compass__ class. Where <*> could be one of the following: Left, Top, Right, Bottom, Center. To learn more take a look at the [How to Implement Conditional Docking]({%slug raddocking-how-to-implement-conditional-docking%}) topic.

## Floating Panes

Floating panes are all these panes hosted inside the floating [ToolWindows]({%slug raddocking-features-tool-window%}) right above the __RadDocking__'s main window.

Here is the XAML declaration of the above docking structure. Notice that each [RadPane]({%slug raddocking-panes-radpane%}) is added to a separate [RadPaneGroup]({%slug raddocking-features-pane-groups%}), which on the other side is hosted in a separate [RadSplitContainer]({%slug raddocking-features-split-container%}). The two panes are initially floatable (displayed in ToolWindows) because the __InitialPosiotion__ property of the respective __RadSplitContainers__ is set to __FloatingDockable__ or __FloatingOnly__.

__Example 3: Create Floating Panes__

```XAML
	<telerik:RadDocking x:Name="radDocking1">
	    <telerik:RadSplitContainer x:Name="radSplitContainer1" InitialPosition="FloatingDockable">
	        <telerik:RadPaneGroup x:Name="radPaneGroup1">
	            <telerik:RadPane x:Name="radPane1" Header="Floating Pane">
	                <TextBlock TextWrapping="Wrap" Text="Floating pane hosted in a ToolWindow."></TextBlock>
	            </telerik:RadPane>
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	    <telerik:RadSplitContainer x:Name="radSplitContainer2" InitialPosition="FloatingDockable">
	        <telerik:RadPaneGroup x:Name="radPaneGroup2">
	            <telerik:RadPane x:Name="radPane2" Header="Floating Pane">
	                <TextBlock TextWrapping="Wrap" Text="Floating pane hosted in a ToolWindow."></TextBlock>
	            </telerik:RadPane>
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
```

>tipIf you want to specify the exact position and size of the floating panes set the attached properties __RadDocking.FloatingLocation__ and __RadDocking.FloatingSize__ inside the declaration of the containing __RadSplitContainer__.

__Example 4: Set the FloatingLocation and FloatingSize attached properties__

```XAML
	<telerik:RadSplitContainer x:Name="splitContainer1" InitialPosition="FloatingDockable"
	                           telerik:RadDocking.FloatingLocation="50,50"
	                           telerik:RadDocking.FloatingSize="200,200">
	
	    <telerik:RadPaneGroup x:Name="paneGroup1">
	        <telerik:RadPane x:Name="pane2" Header="Floating Pane">
	            <TextBlock TextWrapping="Wrap" Text="Floating pane hosted in a ToolWindow."></TextBlock>
	        </telerik:RadPane>
	    </telerik:RadPaneGroup>
	
	</telerik:RadSplitContainer>
```

You can also make a pane floatable programmatically by either calling __MakeFloatingDockable()__ or __MakeFloatingOnly()__. Both of these methods are doing one and the same thing - they undock your pane and host it in a separate ToolWindow.

More specifically, when the pane is floated, it is removed from its RadPaneGroup and its RadSplitContainer. The original group and split container, however, are not removed from the docking control, they are just hidden. Then a new RadPaneGroup is created by the control and the floated RadPane is added to that new group. After that, a new RadSplitContainer is created and the new group is added to it. Next, a new ToolWindow instance is created and the new split container is added to it. Finally, the window is added to the RadDocking control.

>Note that __MakeFloatingOnly(), MakeFloatingDockable()__ and __MakeDockable()__ methods work only when all objects are constructed and added to the object tree. Which means that you should invoke them after the __Loaded__ event of the __RadDocking__ control has been fired.

__Example 5: Make a RadPane FloatingDockable__

```C#
	radPane.MakeFloatingDockable();
```
```VB.NET
	radPane.MakeFloatingDockable()
```

>tipIf you make your pane floating using the __MakeFloatingOnly()__ you will not be able to dock it back again using [drag and drop]({%slug raddocking-features-drag-and-drop%}). To make it dockable again you have to call the method __MakeDockable()__.

>tipThe RadPane loses its DataContext when it's made floating since it is hosted in a ToolWindow. In order to preserve any bindings applied to the RadPane properties, you can explicitly set the DataContext on the RadPane itsself.

## Disable Floating

You can disable the floating functionality of a RadPane via the boolean property __CanFloat__.

__Example 6: Disable the floating of a RadPane__

```XAML
	<telerik:RadPane x:Name="pane1" CanFloat="False"/>
```

__Example 6: Disable the floating of a RadPane__

```C#
	radPane.CanFloat = false;
```
```VB.NET
	radPane.CanFloat = False
```

## See Also

 * [RadPane]({%slug raddocking-panes-radpane%})

 * [RadDocumentPane]({%slug raddocking-panes-raddocumentpane%})

 * [Pinned/Unpinned Panes]({%slug raddocking-panes-pinned-unpinned-panes%})
