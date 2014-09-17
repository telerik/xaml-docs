---
title: How to hide week numbers
page_title: How to hide week numbers
description: How to hide week numbers
slug: raddatetimepicker-how-to-hide-week-numbers
tags: how,to,hide,week,numbers
published: True
position: 6
---

# How to hide week numbers



## 

This article shows you how to hide week numbers in __RadDateTimePicker__ control. In the previous versions of __RadDatePicker__ control there was an __AreWeekNumbersVisible__ property which indicates whether the week numbers are visible or not. This property is __Obsolete__ in the current version of __RadDateTimePicker__(Q2 2010) and it will be removed in the future releases. From now on if you want to disable the week numbers in __RadDateTimePicker__ (and in __RadDatePicker__ as well) I would suggest you to use the __CalendarStyle__ property. This style affects the style of the __RadCalendar__, placed inside the __RadDateTimePicker__. Using this property is very useful, because it allows you to set more additional properties to the calendar. So, here are the steps to create a __CalendarStyle__ and disable week numbers:

* First, create a __Style__ for the __RadCalendar__:



#### __XAML__

{{region raddatetimepicker-how-to-hide-week-numbers_1}}
	<UserControl.Resources>
	     <Style x:Key="calendarStyle" TargetType="telerik:RadCalendar">
	      ....
	     </Style> 
	</UserControl.Resources>
	{{endregion}}



* Then, add a __Setter__ for __AreWeekNumbersProperty__ property and set the __Value__ to __False__

#### __XAML__

{{region raddatetimepicker-how-to-hide-week-numbers_3}}
	<UserControl.Resources>        
	    <Style x:Key="calendarStyle" TargetType="telerik:RadCalendar">            
	        <Setter Property="AreWeekNumbersVisible" Value="False" />        
	    </Style>
	</UserControl.Resources>
	{{endregion}}





* The final step is to create a __RadDateTimePicker__ control and set __CalendarStyle__ to the Style that you created. Please, pay attention that if the __InputMode__ is set to __TimePicker__, the __CalendarStyle__ will take no effect on the control.


#### __XAML__

{{region raddatetimepicker-how-to-hide-week-numbers_4}}
	<telerik:RadDateTimePicker Width="100"                            
	                           InputMode="DatePicker"                            
	                           CalendarStyle="{StaticResource calendarStyle}"                            
	                           VerticalAlignment="Center"/>
	{{endregion}}





Here is the result:
        ![](images/dateTimePicker_how_to_hide_week_numbers.png)

That's all! We created a simple __RadDateTimePicker__ control and hid the week numbers. You could use the same method to set whatever property you want to customize the __RadCalendar__ in the __RadDateTimePicker__ control. 
