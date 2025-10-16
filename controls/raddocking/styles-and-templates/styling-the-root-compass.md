---
title: Styling the RootCompass
page_title: Styling the RootCompass
description: This article describes how the RootCompass element can be styled. 
slug: raddocking-styling-the-root-compass
tags: styling,the,rootcompass
published: True
position: 6
---

# Styling the RootCompass

The compasses that you see, when rearranging the containers in the __RadDocking__ control, are represented by the __Compass__ and __RootCompass__ controls. The one that marks the possible docking positions within the root container is the [RootCompass]({%slug raddocking-features-compass%}#root-compass) control. This article will demonstrate how to create a style targeting RootCompass.

## Targeting the RootCompass Element

In order to style the __RootCompass__ element in a RadDocking, you should create a style targeting __RootCompass__ and set it to the __RootCompassStyle__ property of the RadDocking.

__Example 1: Setting the RootCompassStyle property__

```XAML
	<Application.Resources>
		<!-- If you are using the NoXaml binaries, you will have to base the style on the default one for the theme like so: 
		<Style x:Key="CustomRootCompassStyle" TargetType="telerik:RootCompass" BasedOn="{StaticResource RootCompassStyle}">-->

		<Style x:Key="CustomRootCompassStyle" TargetType="telerik:RootCompass">
			<Setter Property="IsLeftIndicatorVisible" Value="False" />
			<Setter Property="IsRightIndicatorVisible" Value="False" />
		</Style>
	</Application.Resources>

	<Grid>
        <telerik:RadDocking RootCompassStyle="{StaticResource CustomRootCompassStyle}">
            <telerik:RadSplitContainer InitialPosition="FloatingDockable">
                <telerik:RadPaneGroup >
                    <telerik:RadPane Header="Pane 1"/>
                </telerik:RadPaneGroup>
            </telerik:RadSplitContainer>
        </telerik:RadDocking>
    </Grid>
```

#### __Figure 1: RootCompass without left and right indicator in the Office2016 theme__
![RootCompass without left and right indicator](images/RadDocking_RootCompass_RootCompassStyle.png)

>tip In order to learn how to further modify the control by extracting its ControlTemplate, read the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) article.

## See Also   
 * [Compass]({%slug raddocking-features-compass%})
 * [Drag and Drop]({%slug raddocking-features-drag-and-drop%})
 * [Styling the Compass]({%slug raddocking-styling-the-compass%})
 * [Styling the Visual Cue]({%slug raddocking-styling-the-visual-cue%})
