---
title: Styling the Clock
page_title: Styling the Clock
description: Check our &quot;Styling the Clock&quot; documentation article for the RadDateTimePicker {{ site.framework_name }} control.
slug: raddatetimepicker-styling-clock-view
tags: styling,the,clock
published: True
position: 4
---

# Styling the Clock

To style the clock in your __RadDateTimePicker__ you can do the following:

* Create a __Style__ for it and set it to the __ClockStyle__ property of the __RadDateTimePicker__. 

* Modify the default resources for the __DateTimePickerClock__, that are generated together with the __RadDateTimePicker's Style__.

>tipTo learn how to generate the default __Style__ for the __RadDateTimePicker__ read [here]({%slug raddatetimepicker-styling-raddatetimepicker%}). To learn how to modify the layout of the calendar, look [here]({%slug raddatetimepicker-styling-calendar%}).

## Setting the ClockStyle property

__Example 1__ demonstrates how the flow direction the __RadClock__ in the dropdown of the RadDateTimePicker can be switched:

__Example 1: RadDateTimePicker with ClockStyle__

```XAML
	<Window.Resources>
        <!-- If you are using the Xaml binaries, you do not have to set the BasedOn attribute-->
        
        <Style x:Key="ClockStyle" TargetType="telerik:RadClock" BasedOn="{StaticResource RadClockStyle}">
            <Setter Property="FlowDirection" Value="RightToLeft" />
        </Style>
    </Window.Resources>
    <Grid>
        <telerik:RadDateTimePicker VerticalAlignment="Center" HorizontalAlignment="Center"  ClockStyle="{StaticResource ClockStyle}" />
    </Grid>
```

#### __Figure 1: Result from Example 1 in the Office2016 theme__
![RadClock with RightToLeft FlowDirection](images/DateTimePicker_StylingTheClock.png)

## Modifying the default resources

In order to see these resource you have to first generate the default style for the __RadDateTimePicker__ control. To learn how read this [topic]({%slug raddatetimepicker-styling-raddatetimepicker%}).

Modifying some of the resources generated for the __RadDateTimePicker's__ style will allow you to change the appearance of the clock. Here are some of the resources:

![{{ site.framework_name }} RadDateTimePicker Clock Blend Resources](images/dateTimePicker_styling_styling_the_clock_view_010.png)

* __HeaderOuterBorder__ - represents the __RadDateTimePicker__ content's header outer border brush.

* __CalendarHeaderBorderThickness__ - represents the described above border's thickness.

* __HeaderBackground__ - corresponds to the __RadDateTimePicker__ content's header background.

* __HeaderInnerBorder__ - represents the __RadDateTimePicker__ content's header inner border brush.

* __PanelBorderBrush__ - is the __BorderBrush__ used to outline the clock view.

* __ClockBackground__ - is the brush used as a background to the clock view.

* __ClockInnerBorderBrush__ - is the inner border brush applied to the clock view.

* __ClockInnerBorderCornerRadius__ - represents the inner border's corner radius of the __RadDateTimePicker's__ clock view.

* __ClockOuterBorderCornerRadius__ - represents the outer border's corner radius of the __RadDateTimePicker's__ clock view.

* __ClockItemsMargin__ - is the __Thickness__ applied to each item in the clock view.

* __RadClockDefaultStyleKey__ - defines the clock's default style which includes some of the above properties.

Here is an example of the above resources modified:

![{{ site.framework_name }} RadDateTimePicker Clock Customized Blend Resources](images/dateTimePicker_styling_styling_the_clock_view_020.png)

Here is the result:

![{{ site.framework_name }} RadDateTimePicker Clock with Customized Appearance](images/dateTimePicker_styling_styling_the_clock_view_030.png)

## See Also

 * [Styles and Templates - Overview]({%slug raddatetimepicker-styling-overview%})

 * [Features - Clock Items]({%slug raddatetimepicker-features-clock-items%})

 * [Styling RadDateTimePicker]({%slug raddatetimepicker-styling-raddatetimepicker%})

 * [Styling the Calendar]({%slug raddatetimepicker-styling-calendar%})
