---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadCalculator {{ site.framework_name }} control.
slug: radcalculator-events
tags: events
published: True
position: 3
---

# Events

`RadCalculator` provides the `ValueChanged` event which is raised after the calculated value changes.

#### __[C#] ValueChanged event handler__  
{{region radcalculator-events-0}}
	private void RadCalculator_ValueChanged(object sender, Telerik.Windows.Controls.Calculator.ValueChangedEventArgs e)
	{
		decimal oldValue = e.OldValue;
		decimal newValue = e.NewValue;
	}
{{endregion}}