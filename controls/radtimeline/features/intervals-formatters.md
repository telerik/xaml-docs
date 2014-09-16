---
title: Intervals Formatters
page_title: Intervals Formatters
description: Intervals Formatters
slug: radtimeline-features-intervals-formatters
tags: intervals,formatters
published: True
position: 1
---

# Intervals Formatters



## 

Every __RadTimeline's__ interval has a preset collection of formatting strings that creates the string representation of a given date to match the interval.
          RadTimeline automatically choses the appropriate string formatter according to the control size and visible range.
        

The table shows the available formatters per Interval:


<table> <tr><td>

<b>Intervals:</b></td><td>

<b>Formatters:</b></td><td>

<b>Examples (en-US)</b></td></tr><tr><td>MillisecondInterval</td><td>

fff</td><td>

7/21/2011 12:00:00.55 AM -> 055 ms</td></tr><tr><td>SecondInterval</td><td>

hh:mm:ss tt

hh:mm:ss

ss</td><td>

7/21/2011 12:00:00 AM -> 12:00:00 AM

7/21/2011 12:00:00 AM -> 12:00:00

7/21/2011 12:00:00 AM -> 00</td></tr><tr><td>MinuteInterval</td><td>

hh:mm tt

hh:mm</td><td>

7/21/2011 12:00:00 AM -> 12:00 AM

7/21/2011 12:00:00 AM -> 12:00</td></tr><tr><td>HourInterval</td><td>

hh tt

ht</td><td>

7/21/2011 12:00:00 AM -> 12 AM 

7/21/2011 12:00:00 AM -> 12A</td></tr><tr><td>DayInterval</td><td>

dddd, MMMM d, yyyy 

ddd, MMM d, yyyy 

dddd, d 

ddd, d 

("dddd").Substring(0, 1) 

default format</td><td>

7/21/2011 12:00:00 AM -> Thursday, July 21, 2011 

7/21/2011 12:00:00 AM -> Thu, Jul 21, 2011 

7/21/2011 12:00:00 AM -> Thursday, 21 

7/21/2011 12:00:00 AM -> Thu, 21 

7/21/2011 12:00:00 AM -> T 

7/21/2011 12:00:00 AM -> 7/21/2011 12:00:00 AM</td></tr><tr><td>WeekInterval</td><td>

Week {1}, "MMMM, yyyy" 

Week {1}, "MMM, yyyy" 

Week {1} 

WeekShort{1}</td><td>

7/21/2011 12:00:00 AM -> Week 29, July, 2011 

7/21/2011 12:00:00 AM -> Week 29, Jul, 2011 

7/21/2011 12:00:00 AM -> Week 29 

7/21/2011 12:00:00 AM -> WeekShort29</td></tr><tr><td>MonthInterval</td><td>

MMMM, yyyy 

MMMM 

MMM 

("MMM").Substring(0, 1)</td><td>

7/21/2011 12:00:00 AM -> July, 2011 

7/21/2011 12:00:00 AM -> July 

7/21/2011 12:00:00 AM -> Jul 

7/21/2011 12:00:00 AM -> J</td></tr><tr><td>QuarterInterval</td><td>

Quarter {1}, "yyyy" 

Quarter {1} 

QuarterShort{1} "yyyy" 

QuarterShort{1}/"yy" 

QuarterShort{1}</td><td>

7/21/2011 12:00:00 AM -> Quarter 3, 2011 

7/21/2011 12:00:00 AM -> Quarter 3 

7/21/2011 12:00:00 AM -> QuarterShort3 2011 

7/21/2011 12:00:00 AM -> QuarterShort3/11 

7/21/2011 12:00:00 AM -> QuarterShort3</td></tr><tr><td>YearInterval</td><td>

yyyy 

yy</td><td>

7/21/2011 12:00:00 AM -> 2011 

7/21/2011 12:00:00 AM -> 11</td></tr><tr><td>DecadeInterval</td><td>

{0} - {1} 

{0}DecadeEnding 

"yy"DecadeEnding</td><td>

7/21/2011 12:00:00 AM -> 2010 - 2019 

7/21/2011 12:00:00 AM -> 2010DecadeEnding 

7/21/2011 12:00:00 AM -> 10DecadeEnding</td></tr><tr><td>CenturyInterval</td><td>

{0} Century 

{0}</td><td>

7/21/2011 12:00:00 AM -> 21st Century 

7/21/2011 12:00:00 AM -> 21st</td></tr></table>
