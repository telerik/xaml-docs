---
title: Split Container
page_title: Split Container
description: Check our &quot;Split Container&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-features-split-container
tags: split,container
published: True
position: 2
---

# {{ site.framework_name }} RadDocking Split Container

The __RadSplitContainer__ allows you to use movable bars to divide the displayed area into resizable parts. With the __RadDocking__'s __SplitContainers__ you can build complex layouts like the one shown on **Figure 1**. Some practical examples of such layouts are Explorer-like and Outlook-like interfaces.

#### __Figure 1: RadDocking with complex layout__

![RadDocking with complex layout](images/RadDocking_Features_SplitContainer_010.png)

Each split container is painted in a different color.

>The class that represents the split container is __Telerik.Windows.Controls.RadSplitContainer__.

This topic covers the following features of the __RadSplitContainer__:

* [Setting the Orientation property](#setting-the-orientation-property)

* [Setting the InitialPosition of the RadSplitContainer](#setting-the-initialposition-of-the-radsplitcontainer)

* [Setting the InitialSize of the RadSplitContainer](#setting-the-initialsize-of-the-radsplitcontainer)

* [Setting the initial FloatingSize of the RadSplitContainer](#setting-the-initial-floatingsize-of-the-radsplitcontainer)

* [Setting the initial FloatingLocation of the RadSplitContainer](#setting-the-initial-floatinglocation-of-the-radsplitcontainer)

* [Setting the RelativeSize of the RadSplitContainer](#setting-the-relativesize-of-the-radsplitcontainer)

* [Adding PaneGroups/SplitContainers to the RadSplitContainer programmatically](#adding-panegroups/splitcontainers-to-the-radsplitcontainer-programmatically)

* [Other important properties exposed by the RadSplitContainer](#other-important-properties-exposed-by-the-radsplitcontainer)

* [Styling the RadSplitContainer](#styling-the-radsplitcontainer)

## Setting the Orientation Property

When you want to define the orientation (__Vertical__ or __Horizontal__) in which the panes are ordered inside the container, then you need to set the __Orientation__ property of the __RadSplitContainer__.

>tipSetting the __Orientation__ property of a __RadSplitContainer__ is similar to setting the __Orientation__ property of a __StackPanel__.

* Setting the __Orientation__ property to __Vertical__

When you want to achieve __vertically__ oriented layout, you need to set the __Orientation__ property to __Vertical__. See the example below:

#### __[XAML] Example 1: Setting the container's Orientation to Vertical__

{{region xaml-raddocking-features-split-container_0}}
	<telerik:RadDocking x:Name="radDocking">
	    <telerik:RadSplitContainer x:Name="radSplitContainer" Orientation="Vertical">
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 1" Content="Pane Left 1" />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 2" Content="Pane Left 2"  />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 3" Content="Pane Left 3" />
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

#### __Figure 2: Setting the container's Orientation to Vertical__

![Setting the container's Orientation to Vertical](images/RadDocking_Features_SplitContainer_020.png)

* Setting the __Orientation__ property to __Horizontal__

When you want to achieve __horizontally__ oriented layout, you need to set the __Orientation__ property to __Horizontal__. Consider the previous example. If you set the container's __Orientation__ to __Horizontal__:

#### __[XAML] Example 2: Setting the container's Orientation to Horizontal__

{{region xaml-raddocking-features-split-container_1}}
	<telerik:RadDocking x:Name="radDocking1">
	    <telerik:RadSplitContainer x:Name="radSplitContainer1" Orientation="Horizontal">
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 1" Content="Pane Left 1" />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 2" Content="Pane Left 2"  />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 3" Content="Pane Left 3" />
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

Then the result will be:

#### __Figure 3: Setting the container's Orientation to Horizontal__

![Setting the container's Orientation to Horizontal](images/RadDocking_Features_SplitContainer_030.png)

The __RadSplitContainer__'s __Orientation__ can also be set in the code-behind.

#### __[C#] Example 3: Setting Orientation to Vertical in code-behind__

{{region cs-raddocking-features-split-container_2}}
	private void SetOrientationToVertical()
	{
	    radSplitContainer.Orientation = Orientation.Vertical;
	}
{{endregion}}

#### __[VB.NET] Example 3: Setting Orientation to Vertical in code-behind__

{{region vb-raddocking-features-split-container_3}}
	Private Sub SetOrientationToVertical()
		radSplitContainer.Orientation = Orientation.Vertical
	End Sub
{{endregion}}

>tipThe default __Orientation__ for the __RadSplitContainer__ is __Horizontal__.

## Setting the InitialPosition of the RadSplitContainer

When you want to specify the initial __dock__ position of the __RadSplitContainer__ that is inside a __Telerik.Windows.Controls.RadDocking__, you need to set the __InitialPosition__ property.

The __InitialPosition__ is a __Telerik.Windows.Controls.DockState__ enumeration, which offers the following values:

* __DockedLeft__ - use this value, when you want the __RadSplitContainer__ to be positioned on the __left__ side of the __RadDocking__ control. 

#### __[XAML] Example 4: InitialPosition DockedLeft__

{{region xaml-raddocking-features-split-container_6}}
	<telerik:RadDocking x:Name="radDocking2">
	    <telerik:RadSplitContainer x:Name="radSplitContainer2" InitialPosition="DockedLeft">
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 1" Content="Pane Left 1" />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 2" Content="Pane Left 2"  />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 3" Content="Pane Left 3" />
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

![InitialPosition DockedLeft](images/RadDocking_Features_SplitContainer_040.png)

* __DockedTop__ - use this value, when you want the __RadSplitContainer__ to be positioned on the __top__ side of the __RadDocking__ control. 

#### __[XAML] Example 5: InitialPosition DockedTop__

{{region xaml-raddocking-features-split-container_7}}
	<telerik:RadDocking x:Name="radDocking3">
	    <telerik:RadSplitContainer x:Name="radSplitContainer3" InitialPosition="DockedTop">
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 1" Content="Pane Left 1" />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 2" Content="Pane Left 2"  />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 3" Content="Pane Left 3" />
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

![InitialPosition DockedTop](images/RadDocking_Features_SplitContainer_050.png)

* __DockedRight__ - use this value, when you want the __RadSplitContainer__ to be positioned on the __right__ side of the __RadDocking__ control. 

#### __[XAML] Example 5: InitialPosition DockedRight__

{{region xaml-raddocking-features-split-container_8}}
	<telerik:RadDocking x:Name="radDocking4">
	    <telerik:RadSplitContainer x:Name="radSplitContainer4" InitialPosition="DockedRight">
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 1" Content="Pane Left 1" />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 2" Content="Pane Left 2"  />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 3" Content="Pane Left 3" />
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

![InitialPosition DockedRight](images/RadDocking_Features_SplitContainer_060.png)

* __DockedBottom__ - use this value, when you want the __RadSplitContainer__ to be positioned on the __bottom__ side of the __RadDocking__ control. 

#### __[XAML] Example 6: InitialPosition DockedBottom__

{{region xaml-raddocking-features-split-container_9}}
	<telerik:RadDocking x:Name="radDocking5">
	    <telerik:RadSplitContainer x:Name="radSplitContainer5" InitialPosition="DockedBottom">
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 1" Content="Pane Left 1" />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 2" Content="Pane Left 2"  />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 3" Content="Pane Left 3" />
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

![{{ site.framework_name }} RadDocking RadSplitContainer](images/RadDocking_Features_SplitContainer_070.png)

* __FloatingOnly__ - use this value when you want the __RadSplitContainer__ to be initially hosted in a floatable [Tool Window]({%slug raddocking-features-tool-window%}). 

#### __[XAML] Example 7: InitialPosition FloatingOnly__

{{region xaml-raddocking-features-split-container_10}}
	<telerik:RadDocking x:Name="radDocking6">
	    <telerik:RadSplitContainer x:Name="radSplitContainer6" InitialPosition="FloatingOnly">
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 1" Content="Pane Left 1" />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 2" Content="Pane Left 2"  />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 3" Content="Pane Left 3" />
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

![InitialPosition FloatingOnly](images/RadDocking_Features_SplitContainer_080.png)

* __FloatingDockable__ - use this value when you want the __RadSplitContainer__ to be initially hosted in a floatable [Tool Window]({%slug raddocking-features-tool-window%}). 

#### __[XAML] Example 8: InitialPosition FloatingDockable__

{{region xaml-raddocking-features-split-container_11}}
	<telerik:RadDocking x:Name="radDocking7">
	    <telerik:RadSplitContainer x:Name="radSplitContainer7" InitialPosition="FloatingDockable">
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 1" Content="Pane Left 1" />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 2" Content="Pane Left 2"  />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 3" Content="Pane Left 3" />
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

![InitialPosition FloatingDockable](images/RadDocking_Features_SplitContainer_090.png)

>Note the difference between __FloatingOnly__ and __FloatingDockable__. The both will make your pane(s) [floatable]({%slug raddocking-features-panes-docked-floating-panes%}). However, when you set the __InitialPosition__ to be __FloatingOnly__, then during run-time the user __won't be able to dock the pane(s)__.

The __RadSplitContainer__'s __InitialPosition__ property can also be set in the code-behind.

#### __[C#] Example 9: Setting InitialPosition in code-behind__

{{region cs-raddocking-features-split-container_12}}
	private void SetInitialPositionToLeft()
	{
	    radSplitContainer.InitialPosition = Telerik.Windows.Controls.Docking.DockState.DockedLeft;
	}
{{endregion}}

#### __[VB.NET] Example 9: Setting InitialPosition in code-behind__

{{region vb-raddocking-features-split-container_13}}
	Private Sub SetInitialPositionToLeft()
		radSplitContainer.InitialPosition = Telerik.Windows.Controls.Docking.DockState.DockedLeft
	End Sub
{{endregion}}

>tipPlace each [RadPane]({%slug raddocking-panes-radpane%}) ([RadPaneGroup]({%slug raddocking-features-pane-groups%})) in a separate split container to have the power to initially dock them as desired using the __InitialPosition__ property.

## Setting the InitialSize of the RadSplitContainer

You can set the initial size of your split containers using the attached property __DockingPanel.InitialSize__.

#### __[XAML] Example 10: Setting InitialSize__

{{region xaml-raddocking-features-split-container_24}}
	<telerik:RadDocking x:Name="radDocking8">
	    <telerik:RadSplitContainer telerik:DockingPanel.InitialSize="80,200">
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Left Pane" Content="Pane Left 1" />
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

On the snapshot you can see that the pane titled "Left Pane" has width set to 80, while its height is equal to the height of the container to which it is docked, ignoring the height specified by the __DockingPanel.InitialSize__ property.

![Setting InitialSize](images/RadDocking_Features_SplitContainer_100.png)

## Setting the Initial FloatingSize of the RadSplitContainer

Similarly to the initial position, you have the ability to set the __initial floating size__ of the __RadSplitContainer__.

For this purpose you need to set the __RadDocking.FloatingSize__ attached property like it is shown in the example below:

#### __[XAML] Example 11: Setting FloatingSize__

{{region xaml-raddocking-features-split-container_25}}
	<telerik:RadDocking x:Name="radDocking9">
	    <telerik:RadSplitContainer x:Name="radSplitContainer9" InitialPosition="FloatingDockable"
	telerik:RadDocking.FloatingSize="300,300">
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 1" Content="Pane Left 1" />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 2" Content="Pane Left 2"  />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 3" Content="Pane Left 3" />
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

>Note that the __InitialPosition__ must be set either to __FloatingOnly__ or __FloatingDockable__. Otherwise setting the __RadDocking.FloatingSize__ attached property will not affect the size of the split container.

>tipIf you want to resize the __RadSplitContainer__ during run-time, then just use the [Resizer]({%slug raddocking-visual-structure%}).

## Setting the Initial FloatingLocation of the RadSplitContainer

Similarly to the initial floating size you have the ability to set the __initial floating location__ of the __RadSplitContainer__.
        
For this purpose you need to set the __RadDocking.FloatingLocation__ attached property like it is shown in the example below:
        
#### __[XAML] Example 12: Setting FloatingLocation__

{{region xaml-raddocking-features-split-container_26}}
	<telerik:RadDocking x:Name="radDocking10">
	    <telerik:RadSplitContainer x:Name="radSplitContainer10" InitialPosition="FloatingDockable"
	telerik:RadDocking.FloatingLocation="10,10">
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 1" Content="Pane Left 1" />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 2" Content="Pane Left 2"  />
	        </telerik:RadPaneGroup>
	        <telerik:RadPaneGroup>
	            <telerik:RadPane Header="Pane Left 3" Content="Pane Left 3" />
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

>Note that the __InitialPosition__ must be set either to __FloatingOnly__ or __FloatingDockable__. Otherwise setting the __RadDocking.FloatingLocation__ attached property will not affect the location of the split container.

## Setting the RelativeSize of the RadSplitContainer

For this purpose you need to set the __RelativeSize__ attached property of the __ProportionalStackPanel__ class. 
    		By using this property you can proportionally divide the width or the hight occupied by two or more __RadSplitContainers__ placed in the same RadSplitContainer. 
    		For example, if you have two split containtainers, the first one should occupy 1/3 of the available width and the second - the remaining 2/3, you have to set this proportion (1:2) in their widths as it is shown in the code snippet below.
        	
#### __[XAML] Example 13: Setting RelativeSize__

{{region xaml-raddocking-features-split-container_27}}
	<telerik:RadDocking x:Name="radDocking11">
	    <telerik:RadSplitContainer InitialPosition="DockedTop">
	        <telerik:RadSplitContainer telerik:ProportionalStackPanel.RelativeSize="200, 200">
	            <telerik:RadPaneGroup>
	                <telerik:RadPane Header="Width: 1/3"  />
	            </telerik:RadPaneGroup>
	        </telerik:RadSplitContainer>
	        <telerik:RadSplitContainer telerik:ProportionalStackPanel.RelativeSize="400, 200">
	            <telerik:RadPaneGroup>
	                <telerik:RadPane Header="Width: 2/3" />
	            </telerik:RadPaneGroup>
	        </telerik:RadSplitContainer>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

![Setting RelativeSize](images/Features_Panes_Tabbed_030.png)

The default value is 200, 200.

## Adding PaneGroups/SplitContainers to the RadSplitContainer Programmatically

In order to add a pane group or another split container in the code-behind, you need to use the __RadSplitContainer__'s __Items__ collection. 

## Other Important Properties Exposed by the RadSplitContainer

* __IsInDocumentHost__ - read-only boolean property. Returns whether the current __RadPaneGroup__ is placed in [DocumentHost]({%slug raddocking-features-document-host%}).

* __IsInToolWindow__ - read-only boolean property. Returns whether the current __RadPaneGroup__ is in [Tool Window]({%slug raddocking-features-tool-window%}).

* __SplitterPosition__ - read-only property. Returns the current dock position of the __RadSplitContainer__. If the container is in floatable window, the return value is null.  

## Styling the RadSplitContainer

To learn how to style the RadSplitContainer in your applications take a look at the [Styling the RadSplitContainer]({%slug raddocking-styling-the-radsplitcontainer%}) topic.

## See Also

 * [Tool Window]({%slug raddocking-features-tool-window%})

 * [Compass]({%slug raddocking-features-compass%})

 * [Pane Groups]({%slug raddocking-features-pane-groups%})

 * [Document Host]({%slug raddocking-features-document-host%})

 * [How to Freeze the Layout]({%slug raddocking-how-to-freeze-the-layout%})
