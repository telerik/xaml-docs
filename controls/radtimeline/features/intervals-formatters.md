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

Every __RadTimeline's__ interval has a preset collection of formatting strings that creates the string representation of a given date to match the interval.
          RadTimeline automatically chooses the appropriate string formatter according to the control size and visible range.
        

The table shows the available formatters per Interval:

|  Intervals:         |  Formatters:                                                                                 |  Examples (en-US)                                                                                                                                                                                                                             |
|---------------------|----------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| MillisecondInterval |  fff                                                                                         |  7/21/2011 12:00:00.55 AM -> 055 ms                                                                                                                                                                                                           |
| SecondInterval      |  hh:mm:ss tt                                                                                 |  7/21/2011 12:00:00 AM -> 12:00:00 AM 7/21/2011 12:00:00 AM -> 12:00:00 7/21/2011 12:00:00 AM -> 00                                                                                                                                           |
					     hh:mm:ss
						 ss
| MinuteInterval      |  hh:mm tt hh:mm                                                                              |  7/21/2011 12:00:00 AM -> 12:00 AM 7/21/2011 12:00:00 AM -> 12:00                                                                                                                                                                             |
| HourInterval        |  hh tt ht                                                                                    |  7/21/2011 12:00:00 AM -> 12 AM 7/21/2011 12:00:00 AM -> 12A                                                                                                                                                                                  |
| DayInterval         |  dddd, MMMM d, yyyy ddd, MMM d, yyyy dddd, d ddd, d ("dddd").Substring(0, 1) default format  |  7/21/2011 12:00:00 AM -> Thursday, July 21, 2011 7/21/2011 12:00:00 AM -> Thu, Jul 21, 2011 7/21/2011 12:00:00 AM -> Thursday, 21 7/21/2011 12:00:00 AM -> Thu, 21 7/21/2011 12:00:00 AM -> T 7/21/2011 12:00:00 AM -> 7/21/2011 12:00:00 AM |
| WeekInterval        |  Week {1}, "MMMM, yyyy" Week {1}, "MMM, yyyy" Week {1} WeekShort{1}                          |  7/21/2011 12:00:00 AM -> Week 29, July, 2011 7/21/2011 12:00:00 AM -> Week 29, Jul, 2011 7/21/2011 12:00:00 AM -> Week 29 7/21/2011 12:00:00 AM -> WeekShort29                                                                               |
| MonthInterval       |  MMMM, yyyy MMMM MMM ("MMM").Substring(0, 1)                                                 |  7/21/2011 12:00:00 AM -> July, 2011 7/21/2011 12:00:00 AM -> July 7/21/2011 12:00:00 AM -> Jul 7/21/2011 12:00:00 AM -> J                                                                                                                    |
| QuarterInterval     |  Quarter {1}, "yyyy" Quarter {1} QuarterShort{1} "yyyy" QuarterShort{1}/"yy" QuarterShort{1} |  7/21/2011 12:00:00 AM -> Quarter 3, 2011 7/21/2011 12:00:00 AM -> Quarter 3 7/21/2011 12:00:00 AM -> QuarterShort3 2011 7/21/2011 12:00:00 AM -> QuarterShort3/11 7/21/2011 12:00:00 AM -> QuarterShort3                                     |
| YearInterval        |  yyyy yy                                                                                     |  7/21/2011 12:00:00 AM -> 2011 7/21/2011 12:00:00 AM -> 11                                                                                                                                                                                    |
| DecadeInterval      |  {0} - {1} {0}DecadeEnding "yy"DecadeEnding                                                  |  7/21/2011 12:00:00 AM -> 2010 - 2019 7/21/2011 12:00:00 AM -> 2010DecadeEnding 7/21/2011 12:00:00 AM -> 10DecadeEnding                                                                                                                       |
| CenturyInterval     |  {0} Century {0}                                                                             |  7/21/2011 12:00:00 AM -> 21st Century 7/21/2011 12:00:00 AM -> 21st     