---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadStepProgressBar control.
slug: stepprogressbar-events
tags: events
position: 3
---

# Events

This article lists the events specific for the __RadStepProgressBar__ control.

* __StepClicked__: Occurs when a __RadStepProgressBarItem__ is clicked. The event arguments are of type __StepClickedEventArgs__ and provide information about the clicked step, the new progress and whether the selection should be canceled or not.
	
	<snippet id='radstepprogressbar-events-block_1-cs' />

* __SelectionChanged__: Occurs after a __RadStepProgressBarItem__ is clicked (if the selection is not canceled) or after updating the SelectedIndex property of the control. The event arguments are of type __StepSelectionChangedEventArgs__ and provide information about the new progress and the clicked step.
	
	<snippet id='radstepprogressbar-events-block_2-cs' />

## See Also
* [Getting Started]({%slug stepprogressbar-getting-started%})
* [Layout]({%slug stepprogressbar-layout%})
* [Data Binding]({%slug stepprogressbar-data-binding%})