---
title: Docked/Floating Panes
page_title: Docked/Floating Panes
description: Docked/Floating Panes
slug: raddocking-features-panes-docked-floating-panes
tags: docked/floating,panes
published: True
position: 2
---

# Docked/Floating Panes

__RadPane__ is flexible {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} control that can be either in docked or in floating state. Each newly created RadPane is docked by default in the root container but you can change this behavior either using the methods explained below or the properties (i.e. __InitialPosition__) exposed by the [RadSplitContainer]({%slug raddocking-features-split-container%}).

## Docking Panes

Docked panes are all these panes that are hosted inside the __RadDockng__ control.

The five possible docking positions are:

* __Left__ - the __RadPane__ will be placed in the left side of the container. 

* __Top__ - the __RadPane__ will be placed in the top side of the container. 

* __Right__ - the __RadPane__ will be placed in the right side of the container. 

* __Bottom__ - the __RadPane__ will be placed at the bottom side of the container. 

* __Tabbed document__ - the docked __RadPane__ will be inserted as a new tab page.

To dock your panes declaratively to a certain position you have to host your panes in __RadSplitContainer__ and define its __InitialPosition__ property as it is shown in the code snippet below:

#### __XAML__

{{region xaml-raddocking-features-panes-docked-floating-panes_0}}
	<telerik:RadDocking x:Name="radDocking">
	    <telerik:RadSplitContainer x:Name="radSplitContainer" InitialPosition="DockedRight">
	        <telerik:RadPaneGroup x:Name="radPaneGroup">
	            <telerik:RadPane x:Name="radPane" Header="Docked Pane">
	                <TextBlock Text="Docked Pane."></TextBlock>
	            </telerik:RadPane>
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

And here is the pane docked to the right:

In order to programmatically dock a __RadPane__ to a group, you have to remove it from its current parent first and then add it to the __RadPaneGroup__'s __Items__ collection:

#### __C#__

{{region cs-raddocking-features-panes-docked-floating-panes_1}}
	radPane.RemoveFromParent();
	radPaneGroup.Items.Add(radPane);
{{endregion}}

#### __VB.NET__

{{region vb-raddocking-features-panes-docked-floating-panes_2}}
	radPane.RemoveFromParent()
	radPaneGroup.Items.Add(radPane)
{{endregion}}

>tipIf you need to control the docking run-time (while the user is dragging a pane), you could use the __PreviewShowCompass__ event of the __RadDocking__ control in combination with the __Is<*>IndicatorVisible__ series of properties of the __Compass__ class. Where <*> could be one of the following: Left, Top, Right, Bottom, Center. To learn more take a look at the [How to Implement Conditional Docking]({%slug raddocking-how-to-implement-conditional-docking%}) topic.

## Floating Panes

Floating panes are all these panes hosted inside the floating [ToolWindows]({%slug raddocking-features-tool-window%}) right above the __RadDocking__'s main window.

Here is the XAML declaration of the above docking structure. Notice that each [RadPane]({%slug raddocking-panes-radpane%}) is added to a separate [RadPaneGroup]({%slug raddocking-features-pane-groups%}), which on the other side is hosted in a separate [RadSplitContainer]({%slug raddocking-features-split-container%}). The two panes are initially floatable (displayed in ToolWindows) because the __InitialPosiotion__ property of the respective __RadSplitContainers__ is set to __FloatingDockable__ or __FloatingOnly__.

#### __XAML__

{{region xaml-raddocking-features-panes-docked-floating-panes_5}}
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
{{endregion}}

>tipIf you want to specify the exact position and size of the floating panes set the attached properties __RadDocking.FloatingLocation__ and __RadDocking.FloatingSize__ inside the declaration of the containing __RadSplitContainer__.

#### __XAML__

{{region xaml-raddocking-features-panes-docked-floating-panes_10}}
	<telerik:RadSplitContainer x:Name="splitContainer1" InitialPosition="FloatingDockable"
	                           telerik:RadDocking.FloatingLocation="50,50"
	                           telerik:RadDocking.FloatingSize="200,200">
	
	    <telerik:RadPaneGroup x:Name="paneGroup1">
	        <telerik:RadPane x:Name="pane2" Header="Floating Pane">
	            <TextBlock TextWrapping="Wrap" Text="Floating pane hosted in a ToolWindow."></TextBlock>
	        </telerik:RadPane>
	    </telerik:RadPaneGroup>
	
	</telerik:RadSplitContainer>
{{endregion}}

You can also make a pane floatable programmatically by either calling __MakeFloatingDockable()__ or __MakeFloatingOnly()__. Both of these methods are doing one and the same thing - they undock your pane and host it in a separate ToolWindow.

>Note that __MakeFloatingOnly(), MakeFloatingDockable()__ and __MakeDockable()__ methods work only when all objects are constructed and added to the object tree. Which means that you should invoke them after the __Loaded__ event of the __RadDocking__ control has been fired.

#### __C#__

{{region cs-raddocking-features-panes-docked-floating-panes_6}}
	radPane.MakeFloatingDockable();
{{endregion}}

#### __VB.NET__

{{region vb-raddocking-features-panes-docked-floating-panes_7}}
	radPane.MakeFloatingDockable()
{{endregion}}

>tipIf you make your pane floating using the __MakeFloatingOnly()__ you will not be able to dock it back again using [drag and drop]({%slug raddocking-features-drag-and-drop%}). To make it dockable again you have to call the method __MakeDockable()__.

## Disable Floating

You can disable the floating functionality of a RadPane via the boolean property __CanFloat__.

#### __XAML__

{{region xaml-raddocking-features-panes-docked-floating-panes_8}}
	<telerik:RadPane x:Name="pane1" CanFloat="False"/>
{{endregion}}

#### __C#__

{{region cs-raddocking-features-panes-docked-floating-panes_9}}
	radPane.CanFloat = false;
{{endregion}}

#### __VB.NET__

{{region vb-raddocking-features-panes-docked-floating-panes_10}}
	radPane.CanFloat = False
{{endregion}}

# See Also

 * [RadPane]({%slug raddocking-panes-radpane%})

 * [RadDocumentPane]({%slug raddocking-panes-raddocumentpane%})

 * [Pinned/Unpinned Panes]({%slug raddocking-panes-pinned-unpinned-panes%})
