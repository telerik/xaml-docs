---
title: Document Host
page_title: Document Host
description: Check our &quot;Document Host&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-features-document-host
tags: document,host
published: True
position: 5
---

# Document Host

The `DocumentHost` is meant to be the default container for the editable documents in your application. By default it occupies the whole central area of the `RadDocking` control and each newly added pane is docked as a new tab page inside of it.

![{{ site.framework_name }} RadDocking Document Host](images/RadDocking_Features_DocumentHost_010.png)

Here is the XAML declaration of the above structure.



```XAML
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
```

>tipSince the DocumentHost is meant to host the editable documents in your application, it is good idea to use [RadDocumentPanes]({%slug raddocking-panes-raddocumentpane%}) instead of [RadPanes]({%slug raddocking-panes-radpane%}).

>Placing `RadPaneGroup` directly in the DocumentHost is not a supported scenario in the Docking control. The RadPaneGroup needs to be placed in a `RadSplitContainer`.

## Setting the CloseButtonPosition

You could easily set the close button position of the Panes that are placed in the DocumentHost by setting the `CloseButtonPosition` property of the Docking control to one of the three built-in predefined settings (InGroup, InPane and InPaneAndGroup).

The next code snippet shows how to set the CloseButtonPosition to InPane:
  


```XAML
	<telerik:RadDocking CloseButtonPosition="InPane">
	    <telerik:RadDocking.DocumentHost>
	        <telerik:RadSplitContainer>
	            <telerik:RadPaneGroup x:Name="radPaneGroup1" >
	                <telerik:RadPane x:Name="radPane11" Header="Document 1">
	                    <TextBlock TextWrapping="Wrap" Text=""></TextBlock>
	                </telerik:RadPane>
	                <telerik:RadPane x:Name="radPane21" Header="Document 2">
	                    <TextBlock TextWrapping="Wrap" Text=""></TextBlock>
	                </telerik:RadPane>
	                <telerik:RadPane x:Name="radPane31" Header="Document 3">
	                    <TextBlock TextWrapping="Wrap" Text=""></TextBlock>
	                </telerik:RadPane>
	            </telerik:RadPaneGroup>
	        </telerik:RadSplitContainer>
	    </telerik:RadDocking.DocumentHost>
	</telerik:RadDocking>
```

The next descriptions describe the built-in predefined CloseButtonPosition settings and their visual representation when they are set:

1. `InGroup`&mdash;This is the default value of the CloseButtonPosition property which causes the close button of the currently active Pane in the PaneGroup to be visible in the top right corner of the PaneGroup

	![raddocking-features-document-host-2](images/raddocking-features-document-host-2.png)

2. `InPane`&mdash;Places separate close button for each Pane in their tab

	![raddocking-features-document-host-3](images/raddocking-features-document-host-3.png)

3. `InPaneAndGroup`&mdash;Places separate close button for each Pane in their tab and a close button for the currently active Pane in the PaneGroup in the top right corner of the group.

	![raddocking-features-document-host-4](images/raddocking-features-document-host-4.png)
	
## Showing Arrows and DropDown Button

When the number of Panes inside the `DocumentHost` increases and there is not enough space available inside the tabstrip they begun to shrink. In order to see the whole Headers of the Panes you can use the `ScrollViewer.HorizontalScrollBarVisibility` attached property of the `PaneGroup` inside the DocumentHost. Arrows will be visualized on both sides of the tabstrip:



```XAML
	<telerik:RadPaneGroup ScrollViewer.HorizontalScrollBarVisibility="Auto"/>
```

__Figure 1: __ DocumentHost with a visible `HorizontalScrollBar`:
![{{ site.framework_name }} RadDocking DocumentHost with a visible `HorizontalScrollBar`:](images/raddocking-features-document-host-5.png)

By design the `HorizontalScrollBarVisibility` property is disabled and can be visualized either by setting it to `Visible` or `Auto` (the arrow buttons will become visible when the space is not enough).

In addition to this you could also display the drop down menu button that contains a list of all Panes inside the DocumentHost. For that purpose the `DropDownDisplayMode` property could be used:



```XAML
	<telerik:RadPaneGroup ScrollViewer.HorizontalScrollBarVisibility="Auto" DropDownDisplayMode="Visible"/>
```

The `DropDownDisplayMode` property could be set to any of the following values:
* `Collapsed`&mdash;The drop down will never be shown.
* `Visible`&mdash;The drop down will always be visible.
* `WhenNeeded`&mdash;The drop down will be shown only when there is not enough space the Tabs to be arranged. 

Figure 2 demonstrate the appearance of the DocumentHost when both properties are set.

__Figure 2: __ DocumentHost with visible `HorizontalScrollBar` and drop down menu button:
![{{ site.framework_name }} RadDocking DocumentHost with visible `HorizontalScrollBar` and drop down menu button:](images/raddocking-features-document-host-6.png)

## Controlling Content Margin

To control the extra space around the content of the panes inside a certain pane group, which is defined inside a `DocumentHost`, utilize the `Padding` property of the desired `RadPaneGroup` element.



```XAML
	<telerik:RadDocking.DocumentHost>
	    <telerik:RadSplitContainer>
	        <telerik:RadPaneGroup Padding="10">
	            <telerik:RadPane>
	                <ScrollViewer/>
	            </telerik:RadPane>
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking.DocumentHost>
```

Furthermore, if you need to apply this to all of the `RadPaneGroup` instances, create a new `Style` with a `Setter` for the `Padding` property.



```XAML
	<Application.Resources>
		<!-- If you're using the NoXaml binaries, you need to base the custom style on the default one for the control, like so:
		<Style TargetType="telerik:RadPaneGroup" BasedOn="{StaticResource RadPaneGroupStyle}"> -->
		<Style TargetType="telerik:RadPaneGroup">
		    <Setter Property="Padding" Value="10" />
		</Style>
	</Application.Resources>
```

> For the Fluent, Green, Material, Office2016 and Office2016Touch themes, the `RadPaneGroup` element's padding should be updated through a style trigger.



```XAML
	<Application.Resources>
		<!-- If you're using the NoXaml binaries, you need to base the custom style on the default one for the control, like so:
		<Style TargetType="telerik:RadPaneGroup" BasedOn="{StaticResource RadPaneGroupStyle}"> -->
		<Style TargetType="telerik:RadPaneGroup">
		    <Style.Triggers>
			<Trigger Property="IsInDocumentHost" Value="True">
			    <Setter Property="Padding" Value="10" />
			</Trigger>
		    </Style.Triggers>
		</Style>
	</Application.Resources>
```

## See Also

 * [Pane Groups]({%slug raddocking-features-pane-groups%})

 * [Split Container]({%slug raddocking-features-split-container%})

 * [Tool Window]({%slug raddocking-features-tool-window%})

 * [Compass]({%slug raddocking-features-compass%})

 * [RadDocumentPane]({%slug raddocking-panes-raddocumentpane%})
