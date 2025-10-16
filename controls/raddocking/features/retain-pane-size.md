---
title: Retain Pane Size
page_title: Retain Pane Size
description: Check our &quot;Retain Pane Size&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-features-retain-pane-size
tags: retain,size,pane
published: True
position: 7
---

# Retain Pane Size

With the official __Q2 2015__ release version of UI for WPF, __RadDocking__ introduced a brand new feature which provides the ability to easily retain the size of the Panes.

Using the __RetainPaneSizeMode__ property you could choose between the following three modes that provide different behaviours for retaining the size:

* [__None__](#none) – this is the default value of the property and uses the default behaviour of __RadDocking__.

* [__Floating__](#floating) – retains the last floating size of all Panes.

* [__DockingAndFloating__](#dockingandfloating) – when a RadPane instance is floated it will keep its current docked size, while when it is being docked it will keep the size of its floating state (the __ToolWindow__'s size). This mode provides a behaviour similar to the one observed in Microsoft's Visual Studio IDE.

The following snippets show how the __RetainPaneSizeMode__ property could be set in XAML and in code behind:



```XAML
	<telerik:RadDocking x:Name="radDocking" RetainPaneSizeMode="Floating">
	    ...
	</telerik:RadDocking>
```



```C#
	this.radDocking.RetainPaneSizeMode = RetainSizeMode.Floating;
```

## None

If the __RetainPaneSizeMode__ is set to __None__ and the Pane or Panes has set __FloatingSize__ that size will always be preserved when the Pane becomes floating. 

If a whole __PaneGroup__ (with multiple panes inside) is floated the __FloatingSize__ of the currently __SelectedPane__ of the __PaneGroup__ will be used.



```XAML
	<telerik:RadPane telerik:RadDocking.FloatingSize="200 200">
	    ...
	</telerik:RadPane>
```

__Figure 1: __ Floating Pane with a set __FloatingSize__:
![{{ site.framework_name }} RadDocking Floating Pane with a set __FloatingSize__:](images/raddocking-features-retain-pane-size-1.png)

__Figure 2: __ The Pane is docked:
![{{ site.framework_name }} RadDocking The Pane is docked:](images/raddocking-features-retain-pane-size-2.png)

__Figure 3: __ The pane retains its __FloatingSize__ when it becomes floating again:
![{{ site.framework_name }} RadDocking The pane retains its __FloatingSize__ when it becomes floating again:](images/raddocking-features-retain-pane-size-3.png)

>Please, notice that in this mode if there is a set __FloatingSize__ to __RadPane__ only that size will be considered and kept when the Pane becomes floating.

## Floating

If the __RetainPaneSizeMode__ is set to __Floating__ the last floating size of each Pane will be always preserved. 

In scenarios where the Pane has __FloatingSize__ initially set that size will be applied only with the first undocking. Afterwards if the user changes the size of the Pane and docks it again the last floating size will be used when undocked again.

If Panes with different sizes are docked in same __PaneGroup__ and the group is made floating, the size the __PaneGroup__ will receive is the last floating size of the current __SelectedPane__ of the group.

When there are several Panes docked in same __ToolWindow__ the size they will take when we drag them out is the size of that __ToolWindow__.

__Figure 1: __ The floating Pane is resized:
![{{ site.framework_name }} RadDocking The floating Pane is resized:](images/raddocking-features-retain-pane-size-4.png)

__Figure 2: __ The Pane is docked:
![{{ site.framework_name }} RadDocking The Pane is docked:](images/raddocking-features-retain-pane-size-5.png)

__Figure 3: __ The last floating size is kept when the Pane becomes floating again:
![{{ site.framework_name }} RadDocking The last floating size is kept when the Pane becomes floating again:](images/raddocking-features-retain-pane-size-6.png)

>importantWe recommend setting __FloatingSize__ only to the Pane when initial size needs to be applied. Please, notice that this size will be appplied just once when the Pane is undocked for the first time.

## DockingAndFloating

If you’re looking for a behavior similar to the one observed in Microsoft's Visual Studio IDE the third mode named __DockingAndFloating__ provides such behavior.

When __RetainPaneSizeMode__ is set to __DockingAndFloating__ if a __Pane__ or __PaneGroup__ is undocked the size that will be kept is the current docked size. On the other hand if the __Pane__ or __PaneGroup__ is being docked the current __ToolWindow__ size will be kept if possible:

* If the __Pane/PaneGroup__ is docked left or right the __Width__ of the __ToolWindow__ will be kept unless the __ToolWindow__ has Width larger than the half of the Docking’s __Width__. If so the half of the Docking’s __Width__ will be taken. Please, notice that if the Docking has __DocumentHost__ there will be same space preserved for it.

* If the __Pane/PaneGroup__ is docked top or bottom the __Height__ of the __ToolWindow__ will be kept unless the __ToolWindow__ has a __Height__ larger that the half of the Docking’s __Height__. If so the half of the Docking’s __Height__ will be taken. Again, please notice that if the Docking has __DocumentHost__ there will be some space preserved for it.

__Figure 1: __ The Pane is docked:
![{{ site.framework_name }} RadDocking The Pane is docked:](images/raddocking-features-retain-pane-size-7.png)

__Figure 2: __ The last docked size is preserved when the Pane becomes floating:
![{{ site.framework_name }} RadDocking The last docked size is preserved when the Pane becomes floating:](images/raddocking-features-retain-pane-size-8.png)

>tip Find a runnable project that demonstrates all described above modes in [the online SDK repository](https://github.com/telerik/xaml-sdk/tree/master/Docking/RetainPaneSize).

## See Also

 * [RadPane]({%slug raddocking-panes-radpane%})

 * [Pane Groups]({%slug raddocking-features-pane-groups%})

 * [Split Container]({%slug raddocking-features-split-container%})

 * [Tool Window]({%slug raddocking-features-tool-window%})