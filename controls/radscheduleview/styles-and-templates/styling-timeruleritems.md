---
title: Styling the TimeRulerItems
page_title: Styling the TimeRulerItems
description: Check our &quot;Styling the TimeRulerItems&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-styles-and-templates-styling-timeruleritems
tags: styling,the,timeruleritems
published: True
position: 2
---

# Styling the TimeRulerItems

The __RadScheduleView__ control offers a wide range of customizable TimeRulerItems. The term TimeRulerItem in RadScheduleView encompasses the following elements: ticks and lines, date group item headers, day and expand buttons in month view.      

This article discusses how to use the TimeRulerItemStyleSelector to customize the appearance of TimeRulerItems. We will dig further into the customization process and create a custom TimeRulerItemStyleSelector, as well. This article covers the following topics:

* [How to generate and use the TimeRulerItemStyleSelector](#generate-and-use-the-timeruleritemstyleselector)

* [How to create a custom TimeRulerItemStyleSelector](#create-a-custom-timeruleritemstyleselector)

## Generate and use the TimeRulerItemStyleSelector

Any change on the appearance of a TimeRulerItem depends on the TimeRulerItemStyleSelector and the containing styles. The selector is oriented, meaning it contains orientation dependant styles – horizontal and vertical. The TimeRulerItemStyleSelector contains the following styles:        

* ExpandMonthViewButtonStyle: 

![radscheduleview timeruler 01](images/radscheduleview_timeruler_01.PNG)

* GoToDayButtonStyle: 

![radscheduleview timeruler 02](images/radscheduleview_timeruler_02.PNG)

* GoToDayTodayButtonStyle: 

![radscheduleview timeruler 03](images/radscheduleview_timeruler_03.PNG)

* GoToDayVerticalButtonStyle: 

![radscheduleview timeruler 04](images/radscheduleview_timeruler_04.PNG)

* MajorHorizontalTimeRulerItemStyle: 

![radscheduleview timeruler 05](images/radscheduleview_timeruler_05.PNG)

* MajorVerticalTimeRulerItemStyle: 

![radscheduleview timeruler 06](images/radscheduleview_timeruler_06.PNG)

* MinorHorizontalTimeRulerItemStyle: 

![radscheduleview timeruler 07](images/radscheduleview_timeruler_07.PNG)

* MinorVerticalTimeRulerItemStyle: 

![radscheduleview timeruler 08](images/radscheduleview_timeruler_08.PNG)

* TimeRulerGroupItemStyle: 

![radscheduleview timeruler 09](images/radscheduleview_timeruler_09.PNG)

* TimeRulerLineStyle: 

![radscheduleview timeruler 10](images/radscheduleview_timeruler_10.PNG)

* TimeRulerMonthViewGroupItemStyle: 

![radscheduleview timeruler 11](images/radscheduleview_timeruler_11.PNG)

* TimeRulerMonthViewItemStyle: 

![radscheduleview timeruler 12](images/radscheduleview_timeruler_12.PNG)

* TimeRulerMonthViewTodayItemStyle: 

![radscheduleview timeruler 13](images/radscheduleview_timeruler_13.PNG)

There are two ways to obtain the source code of RadScheduleView TimeRulerItemStyleSelector: from UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} installation folder and from the generated template for RadScheduleView in Expression Blend.

__Get TimeRulerItemStyleSelector source code from UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} installation folder__

Navigate to the installation folder of UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} on your computer. Go into the Themes folder and select the theme that you have chosen to use as a customization base for RadScheduleView. Drill down to find the __ScheduleView.xaml__ file in the directory that corresponds to your theme. From this resource dictionary extract the __TimeRulerItemStyleSelector__ and the resources it uses, such as brushes and styles, into your own project. 

__Get TimeRulerItemStyleSelector from RadScheduleView control template__

Generate the RadScheduleView template from Expression Blend by right clicking the control and selecting __Edit Template > Edit a Copy__. Search for the TimeRulerItemStyleSelector and copy the selector together with all needed resources, into your own project.

![{{ site.framework_name }} RadScheduleView Edit Template Copy](images/timeruler_13.PNG)

After choosing one of the two approaches the end result should include the following:



<snippet id='radscheduleview-styles-and-templates-styling-timeruleritems-block_1-xaml' />

Note the use of the __local__ namespace from the raw source:



<snippet id='radscheduleview-styles-and-templates-styling-timeruleritems-block_2-xaml' />

The selector is applied to our instance of RadScheduleView:



<snippet id='radscheduleview-styles-and-templates-styling-timeruleritems-block_3-xaml' />

Now that all TimeRulerItem styles are in place, we can apply any desired customizations and watch the TimeRulerItems change. Let’s modify the __TimeRulerGroupItemStyle__, for example – make the item bold and with a different font color:



<snippet id='radscheduleview-styles-and-templates-styling-timeruleritems-block_4-xaml' />

The TimeRulerGroupItemStyle has been modified:

![{{ site.framework_name }} RadScheduleView Custom Time Ruler Group Item Style](images/timeruler_10.PNG)

## Create a custom TimeRulerItemStyleSelector

Let’s say we wish to customize the lines that correspond to the minor and major ticks in Timeline view:

![{{ site.framework_name }} RadScheduleView Minor and Major Ticks](images/timeruler_11.PNG)

Because both lines share one and the same __TimeRulerLineStyle__, in order to style them differently, we are going to need two separate styles.  We need to create a custom TimeRulerItemStyleSelector that provides these additional styles.

To create a custom TimeRulerItemStyleSelector, inherit the __OrientedTimeRulerItemStyleSelector__ and override the __SelectStyle__ method. Also, prepare two properties of type Style that will hold the new styles:



<snippet id='radscheduleview-styles-and-templates-styling-timeruleritems-block_5-cs' />
<snippet id='radscheduleview-styles-and-templates-styling-timeruleritems-block_6-vb' />

>tip If you need to take advantage of the __activeViewDefinition__ in the body of the SelectStyle method, it is important to inherit the __OrientedTimeRulerItemStyleSelector__, which is located in __Telerik.Windows.Controls__ namespace, rather than the regular StyleSelector class.

We use the __Type__ property of the __TickData__ class to determine whether the item is a major or a minor tick. Other properties of the TickData class include: __DateData__, __DateTime__, __Duration__ and __Offset__.

We are going to use the default selector to create the XAML for the custom selector. 

The next step is to prepare the actual styles for both types of TimeRulerLines. Since it is the TimeRulerLineStyle we wish to divide into two styles, the TimeRulerLineStyle is copied into the new styles. Any subsequent changes are made upon the new tick line styles:

<snippet id='radscheduleview-styles-and-templates-styling-timeruleritems-block_7-xaml' />

![{{ site.framework_name }} RadScheduleView Time Ruler Item Style Selector](images/timeruler_12.PNG)