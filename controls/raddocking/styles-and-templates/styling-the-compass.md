---
title: Styling the Compass
page_title: Styling the Compass
description: This article describes how the Compass control can be styled. 
slug: raddocking-styling-the-compass
tags: styling,the,compass
published: True
position: 5
---

# Styling the Compass

The compasses that you see, when rearranging the containers in the __RadDocking__ control, are represented by the __Compass__ and __RootCompass__ controls. The one shown inside the container under the mouse is the [Compass]({%slug raddocking-features-compass%}#compass) control.

## Targeting the Compass Element

In order to style all __Compass__ elements in a RadDocking, you should create a style targeting __Compass__ and set it to the __CompassStyle__ property of the RadDocking.

__Example 1: Setting the CompassStyle property__

```XAML
	<Application.Resources>
		<!-- If you are using the NoXaml binaries, you will have to base the style on the default one for the theme like so: 
		<Style x:Key="CustomCompassStyle" TargetType="telerik:Compass" BasedOn="{StaticResource CompassStyle}">-->
		
		<Style x:Key="CustomCompassStyle" TargetType="telerik:Compass">
			<Setter Property="IsLeftIndicatorVisible" Value="False" />
			<Setter Property="IsRightIndicatorVisible" Value="False" />
		</Style>
	</Application.Resources>

	<Grid>
        <telerik:RadDocking  x:Name="radDocking" CompassStyle="{StaticResource CustomCompassStyle}">
            <telerik:RadDocking.DocumentHost>
                <telerik:RadSplitContainer >
                    <telerik:RadPaneGroup >
                        <telerik:RadPane Header="Pane 1" />
                        <telerik:RadPane Header="Test 2"/>
                        <telerik:RadPane Header="Test 3" />
                        <telerik:RadPane Header="Test 4" />
                    </telerik:RadPaneGroup>
                </telerik:RadSplitContainer>
            </telerik:RadDocking.DocumentHost>
        </telerik:RadDocking>
    </Grid>
```

#### __Figure 1: Compass without left and right indicator in the Office2016 theme__
![Compass without left and right indicator](images/RadDocking_Compass_CompassStyle.png)

>tip In order to learn how to further modify the control by extracting its ControlTemplate, read the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) article.

## See Also

 * [Compass]({%slug raddocking-features-compass%})
 * [Drag and Drop]({%slug raddocking-features-drag-and-drop%})
 * [Styling the RootCompass]({%slug raddocking-styling-the-root-compass%})
 * [Styling the Visual Cue]({%slug raddocking-styling-the-visual-cue%})
