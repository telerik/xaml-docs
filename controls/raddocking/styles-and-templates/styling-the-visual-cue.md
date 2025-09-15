---
title: Styling the Visual Cue
page_title: Styling the Visual Cue
description: This article demonstrates how to create a style targeting VisualCue.
slug: raddocking-styling-the-visual-cue
tags: styling,the,visual,cue
published: True
position: 7
---

# Styling the Visual Cue

The dropping area that you see, when rearranging the containers in the __RadDocking__ control, is represented by the __VisualCue__ control.  

## Targeting the VisualCue Element

In order to style all __VisualCues__ in a RadDocking, you should create a style targeting __VisualCue__.

__Example 1: Creating a style targeting VisualCue__

```XAML
    <Application.Resources>
        <!-- If you are using the NoXaml binaries, you will have to base the style on the default one for the theme like so: 
            <Style x:Key="CustomVisualCueStyle" TargetType="telerik:VisualCue" BasedOn="{StaticResource VisualCueStyle}">-->

        <Style x:Key="CustomVisualCueStyle" TargetType="telerik:VisualCue">
            <Setter Property="Background" Value="Red" />
        </Style>
    </Application.Resources>

    <telerik:RadDocking VisualCueStyle="{StaticResource CustomVisualCueStyle}">
		<telerik:RadSplitContainer InitialPosition="FloatingDockable">
			<telerik:RadPaneGroup >
				<telerik:RadPane Header="Pane 1"/>
			</telerik:RadPaneGroup>
		</telerik:RadSplitContainer>

		<telerik:RadSplitContainer >
			<telerik:RadPaneGroup >
				<telerik:RadPane Header="Pane 1"/>
			</telerik:RadPaneGroup>
		</telerik:RadSplitContainer>
	</telerik:RadDocking>
```

#### __Figure 1: RadDocking with styled VisualCue in the Office2016 theme__
![RadDocking with styled VisualCue](images/RadDocking_VisualCue_Style.png)

>tip In order to learn how to further modify the control by extracting its ControlTemplate, read the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) article.

## See Also  
 * [Compass]({%slug raddocking-features-compass%})
 * [Drag and Drop]({%slug raddocking-features-drag-and-drop%})
 * [Styling the Compass]({%slug raddocking-styling-the-compass%})
 * [Styling the RootCompass]({%slug raddocking-styling-the-root-compass%})