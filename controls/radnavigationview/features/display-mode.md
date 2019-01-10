---
title: Display Mode
page_title: Display Mode
description: This article describes the DisplayMode property of the RadNavigationView and how you can control the layout adjustment.
slug: radnavigationview-display-mode
tags: threshold, mode, display, pane, size
position: 0
---

# Display Mode

The __RadNavigationView__ dynamically adjusts its layout depending on its size. It has three modes __Minimal__, __Compact__ and __Expanded__. 

#### __Figure 1: RadNavigationView in Minimal DisplayMode in the Office2016 theme__
![RadNavigationView in Minimal DisplayMode](images/NavigationView_DisplayMode_Minimal.png)

#### __Figure 2: RadNavigationView in Compact DisplayMode in the Office2016 theme__
![RadNavigationView in Compact DisplayMode](images/NavigationView_DisplayMode_Compact.png)

#### __Figure 3: RadNavigationView in Expanded DisplayMode in the Office2016 theme__
![RadNavigationView in Expanded DisplayMode](images/NavigationView_DisplayMode_Expanded.png)

## DisplayMode Thresholds

By default the RadNavigationView changes its DisplayMode when its size passes certain thresholds. Those are the __CompactModeThresholdWidth__ and __ExpandedModeThresholdWidth__.  When the width of the control reaches these thresholds, its __DisplayMode__ changes. The default value for __CompactModeThresholdWidth__ is __641__ and the default value for  __ExpandedModeThresholdWidth__ is __1008__. You can modify these values to customize the adaptive display mode behavior. __Figure 1__ illustrates how the DisplayMode changes while resizing.

#### __Figure 1: RadNavigationView DisplayModes__
![RadNaviationView DisplayModes](images/RadNavigationView_DisplayModes_Resizing.gif)

## AutoChangeDisplayMode

By default the __RadNavigationView__ handles its SizeChanged event in order to change its DisplayMode based on the values of the __CompactModeThresholdWidth__ and __ExpandedModeThresholdWidth__ properties. If you do not want this to be the case, you can set the __AutoChangeDisplayMode__ property to __False__ as demonstrated in __Example 3__.

#### __[XAML] Example 3: Setting the AutoChangeDisplayMode to False in xaml__
{{region xaml-radnavigationview-display-mode-3}}
    <telerik:RadNavigationView x:Name="navigationView" AutoChangeDisplayMode="False" />
{{endregion}}

#### __[C#] Example 4: Setting the AutoChangeDisplayMode to False in code__
{{region cs-radnavigationview-display-mode-3}}
    this.navigationView.AutoChangeDisplayMode = false;
{{endregion}}

#### __[VB.NET] Example 4: Setting the AutoChangeDisplayMode to False in code__
{{region vb-radnavigationview-display-mode-3}}
    Me.navigationView.AutoChangeDisplayMode = False
{{endregion}}

## See Also

* [Getting Started]({%slug radnavigationview-getting-started%})
* [DataBinding]({%slug radnavigationview-populating-with-data-databinding%})
* [Icon and IconTemplate]({%slug radnavigationview-icon-and-icontemplate%})