---
title: RadPane
page_title: RadPane
description: This article describes the RadPane, its visual structure and the different states it can be in.
slug: raddocking-panes-radpane
tags: radpane
published: True
position: 0
---

# RadPane

The __RadPane__ is the main content unit of the __RadDocking__ control. Its main purpose is to act as a host for your content. That's why in order to have a functional RadDocking control, you need to have at least one RadPane placed inside it.

>important RadPanes cannot exist separately and should always be placed inside of a [RadPaneGroup]({%slug raddocking-features-pane-groups%}).

## Define RadPanes

**Example 1** demonstrates how to add two __RadPane__ instances to a __RadDocking__ control.

__Example 1: Add RadPanes to RadDocking__

```XAML
	<telerik:RadDocking x:Name="radDocking">
	    <telerik:RadSplitContainer x:Name="radSplitContainer">
	        <telerik:RadPaneGroup x:Name="radPaneGroup">
	            <telerik:RadPane x:Name="radPane1" Header="Document 1">
	                <TextBlock Text="Some simple text here"></TextBlock>
	            </telerik:RadPane>
	            <telerik:RadPane x:Name="radPane2" Header="Document 2">
	                <TextBlock Text="Some simple text here"></TextBlock>
	            </telerik:RadPane>
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
```

__Example 1: Add RadPanes to RadDocking__

```C#
	RadPane radPane1 = new RadPane();
	radPane1.Header = "Document 1";
	radPane1.Content = new TextBlock() { Text = "Some simple text here" };

	RadPane radPane2 = new RadPane();
	radPane2.Header = "Document 2";
	radPane2.Content = new TextBlock() { Text = "Some simple text here" };

	var radPaneGroup = new RadPaneGroup();
	radPaneGroup.Items.Add(radPane1);
	radPaneGroup.Items.Add(radPane2);
	var radSplitContainer = new RadSplitContainer();
	radSplitContainer.Items.Add(radPaneGroup);
	radDocking.Items.Add(radSplitContainer);
```
```VB.NET
	Dim radPane1 As New RadPane()
	radPane1.Header = "Document 1"
	radPane1.Content = New TextBlock() With {.Text = "Some simple text here"}

	Dim radPane2 As New RadPane()
	radPane2.Header = "Document 2"
	radPane2.Content = New TextBlock() With {.Text = "Some simple text here"}

	Dim radPaneGroup = New RadPaneGroup()
	radPaneGroup.Items.Add(radPane1)
	radPaneGroup.Items.Add(radPane2)
	Dim radSplitContainer = New RadSplitContainer()
	radSplitContainer.Items.Add(radPaneGroup)
	radDocking.Items.Add(radSplitContainer)
```

**Figure 1** displays the resulting RadDocking control.

#### Figure 1: RadDocking control with two panes

![RadDocking control with two panes](images/RadDocking_Features_Panes_RadPane_005.png)

The control structure defined in the above example is (from the root container to the top one):

__RadDocking__ -> __RadSplitContainer__ -> __RadPaneGroup__ -> __RadPane__

>important In order to have a functional control you should stick to this structure without skipping any of its elements.
        
## Styling and Appearance of the RadPane

If you need to customize or style your __RadPane__ instances  take a look at the following topics:
       

* [Styling the RadPane]({%slug raddocking-styling-the-radpane%})
* [How to Customize or Remove the RadPane's Menu]({%slug raddocking-how-to-add-menu-items-to-the-radpanes-menu%})
* [How to Add Buttons to the Pane Header]({%slug raddocking-how-to-add-buttons-to-the-pane-headers%})
* [How to Add Icon to the RadPane's Header]({%slug raddocking-how-to-add-icon-pane-header%})
* [How to Freeze the Layout]({%slug raddocking-how-to-freeze-the-layout%})
          
## See Also

 * [Visual Structure]({%slug raddocking-panes-visual-structure%})
 * [Pane States]({%slug raddocking-panes-pane-states%})
 * [RadDocumentPane]({%slug raddocking-panes-raddocumentpane%})
 * [Docked/Floating Panes]({%slug raddocking-features-panes-docked-floating-panes%})
 * [Pinned/Unpinned Panes]({%slug raddocking-panes-pinned-unpinned-panes%})
 * [Pane Activation]({%slug raddocking-features-panes-activation-mode%})
 * [How to Implement Conditional Docking]({%slug raddocking-how-to-implement-conditional-docking%})