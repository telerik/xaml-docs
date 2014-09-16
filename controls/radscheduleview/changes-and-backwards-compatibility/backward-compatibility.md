---
title: Backwards Compatibility
page_title: Backwards Compatibility
description: Backwards Compatibility
slug: radscheduleview-backward-compatibility
tags: backwards,compatibility
publish: True
position: 2
---

# Backwards Compatibility



This article lists the breaking changes of the control.

## Q3 2013

__Changed__

* In the __Telerik.Windows.Controls.Scheduling.ZIndexManager__ class the __GetZIndex__ has been changed.
                        

__What to do now:__

This method was returning wrong Framework element type. It is now fixed and returns the correct Integer type. No changes are required.
                

## Q2 2012

__Changed__

* The __FixedTickLengthProvider__ has been obsolete and removed.
                        

__What to do now:__

You should use __FixedTickLength__ instead.
                

__Changed__

* The __InvertedBooleanConverter__ in Telerik.Windows.Controls.ScheduleView.dll is marked as obsolete.
                        

__What to do now:__

The one from Telerik.Windows.Controls assembly should be used instead.
                
