---
title: Intervals Formatters
page_title: Intervals Formatters
description: Check our &quot;Intervals Formatters&quot; documentation article for the RadTimeline {{ site.framework_name }} control.
slug: radtimeline-features-intervals-formatters
tags: intervals,formatters
published: True
position: 1
---

# Intervals Formatters

Every __RadTimeline's__ interval has a preset collection of formatting strings that creates the string representation of a given date to match the interval. RadTimeline automatically chooses the appropriate string formatter according to the control size and visible range.

The table shows the available formatters per Interval:

<table>
	<thead>
		<tr>
			<th>Intervals:</th>
			<th>Formatters:</th>
			<th>Examples (en-US)</th>
		</tr>
	</thead>
	<tbody>	
		<tr>
			<td>MillisecondInterval</td>
			<td>fff</td>
			<td>7/21/2011 12:00:00.55 AM -> 055 ms</td>
		</tr>
		<tr>
			<td>SecondInterval</td>
			<td>
				 hh:mm:ss tt <br/> 
				 hh:mm:ss <br/>
				 ss
			</td>
			<td>
				7/21/2011 12:00:00 AM -> 12:00:00 AM <br/>
				7/21/2011 12:00:00 AM -> 12:00:00 <br/>
				7/21/2011 12:00:00 AM -> 00
			</td>
		</tr>
		<tr>
			<td>MinuteInterval</td>
			<td>
				 hh:mm tt <br/>
				 hh:mm
			</td>
			<td>
				7/21/2011 12:00:00 AM -> 12:00 AM <br/>
				7/21/2011 12:00:00 AM -> 12:00
			</td>
		</tr>
		<tr>
			<td>HourInterval</td>
			<td>
				 hh tt <br/>
				 ht
			</td>
			<td>
				7/21/2011 12:00:00 AM -> 12 AM <br/>
				7/21/2011 12:00:00 AM -> 12A
			</td>
		</tr>
		<tr>
			<td>DayInterval</td>
			<td>
				 dddd, MMMM d, yyyy <br/>
				 ddd, MMM d, yyyy <br/>
				 dddd, d <br/>
				 ddd, d <br/>
				 ("dddd").Substring(0, 1) <br/>
				 default format
			</td>
			<td>
				 7/21/2011 12:00:00 AM -> Thursday, July 21, 2011 <br/>
				 7/21/2011 12:00:00 AM -> Thu, Jul 21, 2011 <br/>
				 7/21/2011 12:00:00 AM -> Thursday, 21 <br/>
				 7/21/2011 12:00:00 AM -> Thu, 21 <br/>
				 7/21/2011 12:00:00 AM -> T <br/>
				 7/21/2011 12:00:00 AM -> 7/21/2011 12:00:00 AM
			</td>
		</tr>
		<tr>
			<td>WeekInterval</td>
			<td>
				 Week {1}, "MMMM, yyyy" <br/>
				 Week {1}, "MMM, yyyy" <br/>
				 Week {1} <br/>
				 WeekShort{1}
			</td>
			<td>
				 7/21/2011 12:00:00 AM -> Week 29, July, 2011 <br/>
				 7/21/2011 12:00:00 AM -> Week 29, Jul, 2011 <br/>
				 7/21/2011 12:00:00 AM -> Week 29 <br/>
				 7/21/2011 12:00:00 AM -> WeekShort29
			</td>
		</tr>
		<tr>
			<td>MonthInterval</td>
			<td>
				 MMMM, yyyy <br/>
				 MMMM <br/>
				 MMM <br/>
				 ("MMM").Substring(0, 1)
			</td>
			<td>
				 7/21/2011 12:00:00 AM -> July, 2011 <br/>
				 7/21/2011 12:00:00 AM -> July <br/>
				 7/21/2011 12:00:00 AM -> Jul <br/>
				 7/21/2011 12:00:00 AM -> J
			</td>
		</tr>
		<tr>
			<td>QuarterInterval</td>
			<td>
				 Quarter {1}, "yyyy" <br/>
				 Quarter {1} <br/>
				 QuarterShort{1} "yyyy" <br/>
				 QuarterShort{1}/"yy" <br/>
				 QuarterShort{1}
			</td>
			<td>
				 7/21/2011 12:00:00 AM -> Quarter 3, 2011 <br/>
				 7/21/2011 12:00:00 AM -> Quarter 3 <br/>
				 7/21/2011 12:00:00 AM -> QuarterShort3 2011 <br/>
				 7/21/2011 12:00:00 AM -> QuarterShort3/11 <br/>
				 7/21/2011 12:00:00 AM -> QuarterShort3
			</td>
		</tr>
		<tr>
			<td>YearInterval</td>
			<td>
				 yyyy <br/>
				 yy
			</td>
			<td>
				 7/21/2011 12:00:00 AM -> 2011 <br/>
				 7/21/2011 12:00:00 AM -> 11
			</td>
		</tr>
		<tr>
			<td>DecadeInterval</td>
			<td>
				 {0} - {1} <br/>
				 {0}DecadeEnding <br/>
				 "yy"DecadeEnding
			</td>
			<td>
				 7/21/2011 12:00:00 AM -> 2010 - 2019 <br/>
				 7/21/2011 12:00:00 AM -> 2010DecadeEnding <br/>
				 7/21/2011 12:00:00 AM -> 10DecadeEnding
			</td>
		</tr>
		<tr>
			<td>CenturyInterval</td>
			<td>
				 {0} Century <br/>
				 {0}
			</td>
			<td>
				 7/21/2011 12:00:00 AM -> 21st Century <br/>
				 7/21/2011 12:00:00 AM -> 21st
			</td>
		</tr>
	</tbody>
</table>

>tip You can customize the interval formats through the [FormatterProvider]({%slug radtimeline-features-formatter-provider%}).