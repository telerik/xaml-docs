---
title: Behavior
page_title: Behavior
description: Behavior
slug: radnumericupdown-behavior
tags: behavior
published: True
position: 3
---

# Behavior

There are several properties that describe the behavior of __RadNumericUpDown__.

Here is a brief list of all behavior properties defined in RadNumericUpDown.

* __Maximum__ - the maximum possible value of RadNumericUpDown.

* __Minimum__ - the minimum possible value of RadNumericUpDown.

* __SmallChange__ - the change used by the Up and Down keys as well as the increase and decrease repeat buttons of RadNumericUpDown. For more information see __Keyboard Navigation__.

* __LargeChange__ - the change used by the PageUp and PageDown keys. For more information see __Keyboard Navigation__.

* __AutoReverse__ - describes the behavior whether the control will start from the Minimum value whenever the Maximum is reached and vice versa.

* __ChangeAcceleration__ - whenever any of the PageUp, PageDown, Up, and Down buttons are hold for more than 20 clicks, the repeat interval will automatically start to decrease.

* __IsEditable__ - determines whether the user can input numeric data in the TextBox using the keyboard. Still the value could be changed using the increase and decrease repeat buttons and the Up and Down keys.

* __UpdateValueToMatchTextOnLostFocus__ - (available with SP1 Q2 2015) determines whether the selected __Value__ will be updated to match the displayed text when the focus gets lost and the text gets formatted.

* __IsReadOnly__ - (available with SP1 Q2 2015) determines whether the editing functionality of the control is enabled or disabled. When it is set to True both the increase and decrease repeat buttons are disabled – the user could no longer press them in order to increase/decrease the value. The __TextBox__ that contains the __ContentText__ becomes ReadOnly either and the value could no longer be changed using the keyboard or the Up/Down keys.

	#### __XAML__

	{{region xaml-radnumericupdown-behavior_0}}
		<telerik:RadNumericUpDown x:Name="radNumericUpDown" IsReadOnly="True"/>
	{{endregion}}

	#### __C#__

	{{region cs-radnumericupdown-behavior_1}}
		this.radNumericUpDown.IsReadOnly = true;
	{{endregion}}

	#### __VB__

	{{region vb-radnumericupdown-behavior_2}}
		Me.radNumericUpDown.IsReadOnly = True
	{{endregion}}

	__Figure 1:__ RadNumericUpDown with a set to True __IsReadOnly__ property:

	![Rad Numeric Up Down Features Behavior 01](images/RadNumericUpDown_Features_Behavior_01.png)

	As the TextBox becomes also ReadOnly the value of the control could no longer be changed, but still it could be selected and copied.

	__Figure 2:__ Selection of the value of __ReadOnly__ RadNumericUpDown:

	![Rad Numeric Up Down Features Behavior 02](images/RadNumericUpDown_Features_Behavior_02.png)
