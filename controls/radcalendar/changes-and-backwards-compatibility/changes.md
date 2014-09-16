---
title: Changes
page_title: Changes
description: Changes
slug: radcalendar-changes
tags: changes
publish: True
position: 0
---

# Changes



This article describes the release history of the control.

For the complete Release History of RadControls for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} go to
        {% if site.site_name == 'Silverlight' %}[What's New Section](http://www.telerik.com/products/silverlight/whats-new.aspx){% endif %}{% if site.site_name == 'WPF' %}[What's New Section](http://www.telerik.com/products/wpf/whats-new.aspx){% endif %}.
      

## Q1 2014

### What's New

* Calendar performance improvements
                

### What's Fixed

* When AreWeekNumbersVisible is false, not all months are displayed in YearView
                

* If the current month is, for example, January 2014 and you change the year and go again into January, the Calendar actually goes into January 2014 (instead of the newly selected year)
                {% if site.site_name == 'Silverlight' %}

* In "Single" SelectionMode when click and drag one day - two days are selected
                  {% endif %}

## Q3 2013

### What's Fixed

* The header navigation buttons do not work as expected when the properties DisplayDateStart or DisplayDateEnd
                

* Using Next button in RadCalendar is not working correctly when Columns are more than one
                

* When Rows or Columns of the control are above one, the left keyboard navigation is incorrect
                

## Q2 2013

### What's New

* Keyboard navigation improvements
                

### What's Fixed

* The Automation ID of the date buttons cannot be found when make a test using CodedUI
                

## Q1 2013

### What's Fixed

* FontSize property doesn't apply correctly

* Move initial focus in RadCalendar to current day

* Moving through code the SelectedDate in MonthSelectionMode into the calendar doesn't change the highlighted Month 

* The property IsTodayHighlighted doesn't have any effect

* SelectedDate border stays visible when changing the SelectedDate after runtime change of the theme 

* Change highlighted period in year/decade/century when SelectedDate changes 

* First calendar week of the year is not shown, if the year is starting at the middle of the week 
