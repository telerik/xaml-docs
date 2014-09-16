---
title: Styling the Clock
page_title: Styling the Clock
description: Styling the Clock
slug: raddatetimepicker-styling-clock-view
tags: styling,the,clock
publish: True
position: 4
---

# Styling the Clock



To style the clock in your __RadDateTimePicker__ you can do the following:

* Create a __Style__ for it and set it to the __ClockStyle__ property of the __RadDateTimePicker__. To learn how to create a style that targets the __RadCalendar__ control read [here]({%slug raddatetimepicker-styling-raddatetimepicker%}).

* Modify the default resources for the __DateTimePickerClock__, that are generated together with the __RadDateTimePicker's____Style__.

>tipTo learn how to generate the default __Style__ for the __RadDateTimePicker__ read [here]({%slug raddatetimepicker-styling-raddatetimepicker%}). To learn how to modify the layout of the calendar, look [here]({%slug raddatetimepicker-styling-calendar%}).{% if site.site_name == 'Silverlight' %}

This topic will focus on the second approach.{% endif %}

## Modifying the default resources{% if site.site_name == 'Silverlight' %}

In order to see these resource you have to first generate the default style for the __RadDateTimePicker__ control. To learn how read this [topic]({%slug raddatetimepicker-styling-raddatetimepicker%}).{% endif %}{% if site.site_name == 'Silverlight' %}

Modifying some of the resources generated for the __RadDateTimePicker's__ style will allow you to change the appearance of the clock. Here are some of the resources: {% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/dateTimePicker_styling_styling_the_clock_view_010.png){% endif %}

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

* __RadClockDefaultStyleKey__ - defines the clock's default style which includes some of the above properties.{% if site.site_name == 'Silverlight' %}

Here is an example of the above resources modified:{% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/dateTimePicker_styling_styling_the_clock_view_020.png){% endif %}{% if site.site_name == 'Silverlight' %}

Here is the result:{% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/dateTimePicker_styling_styling_the_clock_view_030.png){% endif %}

# See Also

 * [Styles and Templates - Overview]({%slug raddatetimepicker-styling-overview%})

 * [Templates Structure]({%slug raddatetimepicker-styling-template-structure%})

 * [Features - Clock Items]({%slug raddatetimepicker-features-clock-items%})

 * [Styling RadDateTimePicker]({%slug raddatetimepicker-styling-raddatetimepicker%})

 * [Styling the Calendar]({%slug raddatetimepicker-styling-calendar%})
