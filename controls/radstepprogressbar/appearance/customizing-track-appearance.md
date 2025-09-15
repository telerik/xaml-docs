---
title: Customizing Track Appearance
page_title: Customizing Track Appearance
description: Check our &quot;Customizing Track Appearance&quot; documentation article for the RadStepProgressBar control.
slug: stepprogressbar-appearance-track
tags: track,style,template
published: True
position: 1
---

# Customizing Track Appearance

RadStepProgressBar allows you to customize the color and size of the [track visual]({%slug stepprogressbar-visual-structure%}).

To change the color of the track's part that shows the progress, set the __TrackFill__ property of RadStepProgressBar.

To change the thickness of the track, set the __TrackThickness__ property of RadStepProgressBar.


```XAML
	<telerik:RadStepProgressBar TrackFill="#34A852" TrackThickness="30" SelectedIndex="1">
		<telerik:RadStepProgressBarItem Content="Step 1" />
		<telerik:RadStepProgressBarItem Content="Step 2" />
		<telerik:RadStepProgressBarItem Content="Step 3" />
	</telerik:RadStepProgressBar>
```

![{{ site.framework_name }} RadStepProgressBar Customizing Track Appearance](images/stepprogressbar-appearance-track-0.png)

## See Also
* [Getting Started]({%slug stepprogressbar-getting-started%})
* [Customizing Step Appearance]({%slug stepprogressbar-appearance-step%})
* [Data Binding]({%slug stepprogressbar-data-binding%})