---
title: Display Mode
page_title: Display Mode
description: This article describes the DisplayMode property of the RadNavigationView and how you can control the layout adjustment.
slug: radnavigationview-display-mode
tags: threshold, mode, display, pane, size
position: 0
---

# Display Mode

The `RadNavigationView` control dynamically adjusts its layout depending on its size. It has three modes __Minimal__, __Compact__ and __Expanded__. 

__RadNavigationView in Minimal DisplayMode in the Office2016 theme__

![RadNavigationView in Minimal DisplayMode](images/NavigationView_DisplayMode_Minimal.png)

__RadNavigationView in Compact DisplayMode in the Office2016 theme__

![RadNavigationView in Compact DisplayMode](images/NavigationView_DisplayMode_Compact.png)

__RadNavigationView in Expanded DisplayMode in the Office2016 theme__

![RadNavigationView in Expanded DisplayMode](images/NavigationView_DisplayMode_Expanded.png)

## DisplayMode Thresholds

By default the RadNavigationView changes its DisplayMode when its size passes certain thresholds. Those are the `CompactModeThresholdWidth` and `ExpandedModeThresholdWidth`.  When the width of the control reaches these thresholds, its `DisplayMode` changes. The default value for CompactModeThresholdWidth is __641__ and the default value for  ExpandedModeThresholdWidth is __1008__. You can modify these values to customize the adaptive display mode behavior. 

The following GIF illustrates how the DisplayMode changes while resizing.

__RadNavigationView DisplayModes__

![RadNaviationView DisplayModes](images/RadNavigationView_DisplayModes_Resizing.gif)

## AutoChangeDisplayMode

By default, the RadNavigationView handles its `SizeChanged` event in order to change its DisplayMode based on the values of the CompactModeThresholdWidth and ExpandedModeThresholdWidth properties. If you do not want this to be the case, you can set the `AutoChangeDisplayMode` property to __False__ as demonstrated in the next example.

__Setting the AutoChangeDisplayMode to False in xaml__
```XAML
    <telerik:RadNavigationView x:Name="navigationView" AutoChangeDisplayMode="False" />
```

## See Also

* [Getting Started]({%slug radnavigationview-getting-started%})
* [DataBinding]({%slug radnavigationview-populating-with-data-databinding%})
* [Icon and IconTemplate]({%slug radnavigationview-icon-and-icontemplate%})