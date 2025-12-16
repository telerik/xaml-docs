---
title: Pane Groups
page_title: Pane Groups
description: Check our &quot;Pane Groups&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-features-pane-groups
tags: pane,groups
published: True
position: 1
---

# Pane Groups

Each __RadPane__ provides built-in grouping functionality that allows you to place multiple panes inside a single container by organizing them in separate tab pages, similarly to the __RadTabControl__.

Each __RadPane__ can be grouped along with other __RadPanes__ inside of a single container like it is shown in the snapshot below.

>In order to group your panes, you should use the __Telerik.Windows.Controls.RadPaneGroup__ class.

## Grouping Panes Run-time

You can group panes during run-time by simply [dragging]({%slug raddocking-features-drag-and-drop%}) the pane to the desired container.

## Grouping Panes Programmatically

In order to group two or more panes, you should add them to the __RadPaneGroup__'s __Items__ collection like in the example below.

__Example 1: Adding panes to a RadPaneGroup__

```XAML
	<telerik:RadDocking x:Name="radDocking">
	    <telerik:RadSplitContainer>
	
	        <telerik:RadPaneGroup x:Name="Group1">
	            <telerik:RadPane x:Name="Pane1" Header="Server Explorer"/>
	            <telerik:RadPane x:Name="Pane2" Header="Toolbox"/>
	        </telerik:RadPaneGroup>
	
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
```

The same operation can be done in the code-behind. You can group panes using the __RadPaneGroup__'s __Items__ collection through procedural code:

__Example 2: Adding panes to a RadPaneGroup__

```C#
	private void GroupPanes()
	{
	    Telerik.Windows.Controls.RadPane pane3 = new Telerik.Windows.Controls.RadPane();
	    pane3.Header = "Properties";
	    Group1.Items.Add(pane3);
	}
```
```VB.NET
	Private Sub GroupPanes()
		Dim pane3 As New Telerik.Windows.Controls.RadPane()
		pane3.Header = "Properties"
		Group1.Items.Add(pane3)
	End Sub
```

## Removing Panes Run-Time

In order to remove panes run-time you should either close the pane or remove the pane from the group via [drag and drop]({%slug raddocking-features-drag-and-drop%}).

>tip If you want to restrict the user not to close panes, take a look at the [How to Disable the Close ("X") Button]({%slug raddocking-how-to-disable-the-close-button%}) topic.

## Removing Panes Programmatically

You can remove panes using procedural code in two ways:

* Using the __RadPaneGroup__'s __Items__ collection

__Example 3: Removing panes from a RadPaneGroup__

```C#
	private void RemovePane(RadPane paneToRemove)
	{
	    Group1.Items.Remove(paneToRemove);
	}
```
```VB.NET
	Private Sub RemovePane(ByVal paneToRemove As RadPane)
		Group1.Items.Remove(paneToRemove)
	End Sub
```

* Using the __RemoveFromParent__ method of the __RadPane__ class

__Example 4: Removing panes from a RadPaneGroup through the RemoveFromParent method__

```C#
	private void RemovePane(RadPane paneToRemove)
	{
	    paneToRemove.RemoveFromParent();
	}
```
```VB.NET
	Private Sub RemovePane(ByVal paneToRemove As RadPane)
		paneToRemove.RemoveFromParent()
	End Sub
```

## Hiding All Panes

The __RadPaneGroup__ class exposes __HideAllPanes__ method, which allows you to hide all visible panes belonging to the group.

__Example 5: Hiding all group panes__

```C#
	private void HideAllPanes()
	{
	    Group1.HideAllPanes();
	}
```
```VB.NET
	Private Sub HideAllPanes()
		Group1.HideAllPanes()
	End Sub
```

>__HideAllPanes__ method works only when all of the objects are constructed and added to the object tree. Which means that you should invoke it after the __Loaded__ event of the __RadDocking__ control has been fired.

## Showing All Panes

The __RadPaneGroup__ class exposes __ShowAllPanes__ method, which allows you to show all hidden panes belonging to the group.

__Example 6: Show all group panes__

```C#
	private void ShowAllPanes()
	{
	    Group1.ShowAllPanes();
	}
```
```VB.NET
	Private Sub ShowAllPanes()
		Group1.ShowAllPanes()
	End Sub
```

>__ShowAllPanes__ method works only when all of the objects are constructed and added to the object tree. Which means that you should invoke it after the __Loaded__ event of the __RadDocking__ control has been fired.

>tip If you need information about the events fired when showing and hiding panes, take a look at the [Events]({%slug raddocking-events-overview%}) topic.

## Pinning All Panes

The __RadPaneGroup__ class exposes __PinAllPanes__ method, which allows you to pin all panes belonging to the group.

__Example 7: Pin all group panes__

```C#
	private void PinAllPanes()
	{
	    Group1.PinAllPanes();
	}
```
```VB.NET
	Private Sub PinAllPanes()
		Group1.PinAllPanes()
	End Sub
```

>__PinAllPanes__ method works only when all of the objects are constructed and added to the object tree. Which means that you should invoke it after the __Loaded__ event has been fired.

## Unpining All Panes

The __RadPaneGroup__ class exposes __UnpinAllPanes__ method, which allows you to unpin all panes belonging to the group.

__Example 7: Unpin all group panes__

```C#
	private void UnpinAllPanes()
	{
	    Group1.UnpinAllPanes();
	}
```
```VB.NET
	Private Sub UnpinAllPanes()
		Group1.UnpinAllPanes()
	End Sub
```

>__UnpinAllPanes__ method works only when all of the objects are constructed and added to the object tree. Which means that you should invoke it after the __Loaded__ event of the __RadDocking__ control has been fired.

>tip If you need information about the events fired when pinning and unpining panes, take a look at the [Events]({%slug raddocking-events-overview%}) topic.

## Persist Content with the IsContentPreserved Property

For performance optimization, the control template of the RadPaneGroup defines a single **ContentPresenter** which holds only the currently selected RadPane's content. Therefore each time the selection is changed, the content of the last active pane is unloaded in order to load the content of the newly-selected pane. Since the load/unload operations involve add/remove actions in the visual tree, the content does not keep its state.

You can, however, change this behavior by setting the **IsContentPreserved** property of the RadPaneGroup to **True**.

__Example 8: Persist panes' content__

```C#
    	Group1.IsContentPreserved = true;
```
```VB.NET
	Group1.IsContentPreserved = True
```

## Set Relative Size to the RadPaneGroup

The sizes of the __RadPaneGroups__ that are not directly set in the __RadDocking__ control, are set relatively. You can set relative size to a __RadPaneGroup__ by setting the __PropertionalStackPanel.RelativeSize__ attached property. By using this property you can proportionally divide the width or the hight occupied by two or more __RadPaneGroups__ docked to the same position. For example, if you have two pane groups docked to the top, the first one should occupy 1/3 of the available width and the second - the remaining 2/3, you have to set this proportion (1:2) in their widths as it is shown in the code snippet below.

__Example 9: Set relative size__

```XAML
	<telerik:RadDocking x:Name="radDocking1">
	    <telerik:RadSplitContainer Height="200" InitialPosition="DockedTop" Orientation="Horizontal">
	        <telerik:RadPaneGroup telerik:ProportionalStackPanel.RelativeSize="200, 200">
	            <telerik:RadPane Header="pane" />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup telerik:ProportionalStackPanel.RelativeSize="400, 200">
	            <telerik:RadPane Header="pane" />
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
```

**Figure 1** illustrates the result.

#### __Figure 1: Pane groups with proportional sizes__

![Pane groups with proportional sizes](images/Features_Panes_Tabbed_030.png)

As you can see, the first pane group occupies 1/3 of the available width, while the second occupies the rest 2/3. The height specified is ignored because the groups have the same height as the __RadSplitContainer__ in which they are hosted.

## Set (Min/Max)Width and (Min/Max)Height

Since version **R2 2017**, you can set fixed sizes to a __RadPaneGroup__ by setting the following attached properties of the **ProportionalStackPanel** class:

* **ElementWidth**

* **ElementMinWidth**

* **ElementMaxWidth**

* **ElementHeight**

* **ElementMinHeight**

* **ElementMaxHeight**

__Example 10: Setting ProportionalStackPanel.ElementWidth__

```XAML
	<telerik:RadSplitContainer>
		<telerik:RadPaneGroup telerik:ProportionalStackPanel.ElementWidth="300">
	        <telerik:RadPane Header="Pane Bottom">
	            <TextBlock Text="Pane Group with RelativeSize" />
	        </telerik:RadPane>
	    </telerik:RadPaneGroup>
		<telerik:RadPaneGroup>
		    <telerik:RadPane Header="Pane Bottom">
		        <TextBlock Text="Pane Group with fixed Width (300)" />
		    </telerik:RadPane>
		</telerik:RadPaneGroup>
		<telerik:RadPaneGroup>
		    <telerik:RadPane Header="Pane Bottom">
		        <TextBlock Text="Pane Group with RelativeSize" />
		    </telerik:RadPane>
		</telerik:RadPaneGroup>
	</telerik:RadSplitContainer>
```

As can be seen on **Figure 2**, even when pane groups with fixed sizes are present, the remaining groups with proportional sizes will still resize accordingly.

#### __Figure 2: Pane group with fixed size among groups with proportional sizes__

![Pane group with fixed size among groups with proportional sizes](images/pane-groups-fixed-widths-1.png)
![Pane group with fixed size among groups with proportional sizes](images/pane-groups-fixed-widths-2.png)

>important When the **Orientation** of the parent **RadSplitContainer** is set to **Vertical**, only the **(Min/Max)Height** properties are taken into account. Similarly, when the orientation is **Horizontal**, the container uses only the **(Min/Max)Width** attached properties.

>When both fixed and proportional sizes are set for a given group, the fixed size will take precedence.

## Other Properties and Methods Exposed by the RadPaneGroup class

* __IsInDocumentHost__: Read-only boolean property. Returns whether the current __RadPaneGroup__ is placed in [DocumentHost]({%slug raddocking-features-document-host%}).

* __IsInToolWindow__: Read-only boolean property. Returns whether the current __RadPaneGroup__ is in [Tool Window]({%slug raddocking-features-tool-window%}).

* __IsPaneHeaderVisible__: Read-only boolean property. Returns whether the pane's header is visible.

* __SelectedPane__: Returns the currently selected pane within the group.

* __EnumeratePanes()__: Returns __IEnumeratble__ of __RadPane__ objects. These are all the panes that currently belonging to the group.

* __PropagateItemDataContextToContent__: Specifies whether the DataContext of the RadPane should be assigned as the DataContext of its content when the selection changes. The default value of this property is __True__.

## Styling the RadPaneGroup

To learn how to style the __RadPaneGroup__ in your applications take a look at the [Styling the RadPaneGroup]({%slug raddocking-styling-the-radpanegroup%}) topic.

## See Also

 * [Split Container]({%slug raddocking-features-split-container%})

 * [Tool Window]({%slug raddocking-features-tool-window%})

 * [Compass]({%slug raddocking-features-compass%})

 * [Document Host]({%slug raddocking-features-document-host%})

 * [Styling the RadPaneGroup]({%slug raddocking-styling-the-radpanegroup%})
