---
title: Styling the RadNumericUpDown
page_title: Styling the RadNumericUpDown
description: This article demonstrates how to Style the RadNumericUpDown control. 
slug: styling-the-radnumericupdown
tags: styling, radnumericupdown
published: True
position: 0
---

# Styling the RadNumericUpDown

This article will demonstrate how to create a Style targeting the __RadNumericUpDown__ control.

## Targeting the RadNumericUpDown Element

In order to style the RadNumericUpDown, you can create a Style targeting __RadNumericUpDown__.

__Example 1: Creating a style targeting the RadNumericUpDown control__

```XAML
	<StackPanel>
        <StackPanel.Resources>
            <!-- If you are using the NoXaml binaries, you should base the style on the default one like so:-->
            <!--<Style TargetType="telerik:RadNumericUpDown" BasedOn="{StaticResource RadNumericUpDownStyle}">-->

            <Style TargetType="telerik:RadNumericUpDown">
                <Setter Property="Background" Value="Red" />
            </Style>
        </StackPanel.Resources>
        <telerik:RadNumericUpDown Value="1" />
    </StackPanel>
```

#### __Figure 1: RadNumericUpDown with custom style in the Office2016 theme__
![RadNumericUpDown with custom style in the Office2016 theme](images/RadNumericUpDown_Styling_The_Control.png)

>tip In order to learn how to further modify the control by extracting its ControlTemplate, read the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) article.
