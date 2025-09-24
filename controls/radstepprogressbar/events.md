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
	
	```C#
		private void RadStepProgressBar_StepClicked(object sender, Telerik.Windows.Controls.StepProgressBar.StepClickedEventArgs e)
        {
            RadStepProgressBarItem clickedItem = e.ClickedItem;
            double newProgress = e.NewProgress;
            bool isSelectionCanceled = e.CancelSelection; // You can set the CancelSelection property to True in order to stop the selection of the step.
        }
	```

* __SelectionChanged__: Occurs after a __RadStepProgressBarItem__ is clicked (if the selection is not canceled) or after updating the SelectedIndex property of the control. The event arguments are of type __StepSelectionChangedEventArgs__ and provide information about the new progress and the clicked step.
	
	```C#
		private void RadStepProgressBar_SelectionChanged(object sender, Telerik.Windows.Controls.StepProgressBar.StepSelectionChangedEventArgs e)
        {
            var stepProgressBar = (RadStepProgressBar)sender;
            object selectedItem = stepProgressBar.SelectedItem; // This can contain a RadStepProgressBarItem if the Items collection is populated, or any other object type if the ItemsSource is used.
            double newProgress = e.NewProgress;
        }
	```

## See Also
* [Getting Started]({%slug stepprogressbar-getting-started%})
* [Layout]({%slug stepprogressbar-layout%})
* [Data Binding]({%slug stepprogressbar-data-binding%})