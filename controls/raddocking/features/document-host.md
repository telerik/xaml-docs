---
title: Document Host
page_title: Document Host
description: Document Host
slug: raddocking-features-document-host
tags: document,host
published: True
position: 5
---

# Document Host

The __DocumentHost__ is meant to be the default container for the editable documents in your application. By default it occupies the whole central area of the __RadDocking__ control and each newly added pane is docked as a new tab page inside of it.

![](images/RadDocking_Features_DocumentHost_010.png)

Here is the XAML declaration of the above structure.

#### __XAML__

{{region xaml-raddocking-features-document-host_0}}
	<telerik:RadDocking x:Name="radDocking">
	    <telerik:RadDocking.DocumentHost>
	        <telerik:RadSplitContainer>
	            <telerik:RadPaneGroup x:Name="radPaneGroup" >
	                <telerik:RadPane x:Name="radPane1" Header="Document 1">
	                    <TextBlock TextWrapping="Wrap" Text=""></TextBlock>
	                </telerik:RadPane>
	                <telerik:RadPane x:Name="radPane2" Header="Document 2">
	                    <TextBlock TextWrapping="Wrap" Text=""></TextBlock>
	                </telerik:RadPane>
	                <telerik:RadPane x:Name="radPane3" Header="Document 3">
	                    <TextBlock TextWrapping="Wrap" Text=""></TextBlock>
	                </telerik:RadPane>
	            </telerik:RadPaneGroup>
	        </telerik:RadSplitContainer>
	    </telerik:RadDocking.DocumentHost>
	</telerik:RadDocking>
{{endregion}}

>tipSince the __DocumentHost__ is meant to host the editable documents in your application, it is good idea to use [RadDocumentPanes]({%slug raddocking-panes-raddocumentpane%}) instead of [RadPanes]({%slug raddocking-panes-radpane%}).

>Placing __RadPaneGroup__ directly in the __DocumentHost__ is not a supported scenario in the RadDocking control. The RadPaneGroup needs to be placed in a __RadSplitContainer__.

## Modifying DocumentHost

The __DocumentHost__ is part of the template of the __RadDocking__ control. To learn how to modify it, take a look at the [Templating the RadDocking]({%slug raddocking-styles-and-templates-templating-the-raddocking%}) topic.

## Setting the CloseButtonPosition

You could easily set the close button position of the Panes that are placed in the DocumentHost by setting the __CloseButtonPosition__ property of the __RadDocking__ control to one of the three built-in predefined settings (InGroup, InPane and InPaneAndGroup).

The next code snippet shows how to set the CloseButtonPosition to InPane:
  
#### __XAML__

{{region xaml-raddocking-features-document-host_1}}
	<telerik:RadDocking CloseButtonPosition="InPane">
		<telerik:RadDocking.DocumentHost>
			<telerik:RadSplitContainer>
				<telerik:RadPaneGroup x:Name="radPaneGroup" >
					<telerik:RadPane x:Name="radPane1" Header="Document 1">
						<TextBlock TextWrapping="Wrap" Text=""></TextBlock>
					</telerik:RadPane>
					<telerik:RadPane x:Name="radPane2" Header="Document 2">
						<TextBlock TextWrapping="Wrap" Text=""></TextBlock>
					</telerik:RadPane>
					<telerik:RadPane x:Name="radPane3" Header="Document 3">
						<TextBlock TextWrapping="Wrap" Text=""></TextBlock>
					</telerik:RadPane>
				</telerik:RadPaneGroup>
			</telerik:RadSplitContainer>
		</telerik:RadDocking.DocumentHost>
	</telerik:RadDocking>
{{endregion}}

The next descriptions describe the built-in predefined CloseButtonPosition settings and their visual representation when they are set:

1. __InGroup__ – this is the default value of the CloseButtonPosition property which causes the close button of the currently active Pane in the PaneGroup to be visible in the top right corner of the PaneGroup

	![raddocking-features-document-host-2](images/raddocking-features-document-host-2.png)

1. __InPane__ – places separate close button for each Pane in their tab

	![raddocking-features-document-host-3](images/raddocking-features-document-host-3.png)

1. __InPaneAndGroup__ – places separate close button for each Pane in their tab and a close button for the currently active Pane in the PaneGroup in the top right corner of the group.

	![raddocking-features-document-host-4](images/raddocking-features-document-host-4.png)
	
## Showing Arrows and DropDown Button

When the number of Panes inside the __DocumentHost__ increases and there is not enough space available inside the tabstrip they begun to shrink. In order to see the whole Headers of the Panes you can use the __ScrollViewer.HorizontalScrollBarVisibility__ attached property of the __PaneGroup__ inside the __DocumentHost__. Arrows will be visualized on both sides of the tabstrip:

#### __XAML__

{{region xaml-raddocking-features-document-host_2}}
	<telerik:RadPaneGroup ScrollViewer.HorizontalScrollBarVisibility="Auto">
{{endregion}}

__Figure 1:__ __DocumentHost__ with a visible __HorizontalScrollBar__:

![](images/raddocking-features-document-host-5.png)

By design the __HorizontalScrollBarVisibility__ property is disabled and can be visualized either by setting it to __Visible__ or __Auto__ (the arrow buttons will become visible when the space is not enough).

In addition to this you could also display the drop down menu button that contains a list of all Panes inside the __DocumentHost__. For that purpose the __DropDownDisplayMode__ property could be used:

#### __XAML__

{{region xaml-raddocking-features-document-host_3}}
	<telerik:RadPaneGroup ScrollViewer.HorizontalScrollBarVisibility="Auto" DropDownDisplayMode="Visible">
{{endregion}}

The __DropDownDisplayMode__ property could be set to any of the following values:
* __Collapsed__ – the drop down will never be shown.
* __Visible__ – the drop down will always be visible.
* __WhenNeeded__ – the drop down will be shown only when there is not enough space the Tabs to be arranged. 

Figure 2 demonstrate the appearance of the __DocumentHost__ when both properties are set.

__Figure 2:__ __DocumentHost__ with visible __HorizontalScrollBar__ and drop down menu button:

![](images/raddocking-features-document-host-6.png)

# See Also

 * [Pane Groups]({%slug raddocking-features-pane-groups%})

 * [Split Container]({%slug raddocking-features-split-container%})

 * [Tool Window]({%slug raddocking-features-tool-window%})

 * [Compass]({%slug raddocking-features-compass%})

 * [RadDocumentPane]({%slug raddocking-panes-raddocumentpane%})
