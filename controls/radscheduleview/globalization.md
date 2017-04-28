---
title: Globalization
page_title: Globalization
description: Globalization
slug: radscheduleview-globalization
tags: globalization
published: True
position: 7
---

# Globalization

As of **R2 2017** RadScheduleView supports the following .NET Framework calendar implementations:

* **ChineseLunisolarCalendar**, which represents the **Chinese lunisolar** calendar.

* **GregorianCalendar**, which represents the **Gregorian** calendar. This calendar is further divided into subtypes (such as Arabic and Middle East French) that are defined by the *System.Globalization.GregorianCalendarTypes* enumeration. The **GregorianCalendar.CalendarType** property specifies the subtype of the Gregorian calendar.

* **HebrewCalendar**, which represents the **Hebrew** calendar.

* **HijriCalendar**, which represents the **Hijri** calendar.

* **JapaneseCalendar**, which represents the **Japanese** calendar.

* **JapaneseLunisolarCalendar**, which represents the **Japanese lunisolar** calendar.

* **JulianCalendar**, which represents the **Julian** calendar.

* **KoreanCalendar**, which represents the **Korean** calendar.

* **KoreanLunisolarCalendar**, which represents the **Korean lunisolar** calendar.

* **PersianCalendar**, which represents the **Persian** calendar.

* **TaiwanCalendar**, which represents the **Taiwan** calendar.

* **TaiwanLunisolarCalendar**, which represents the **Taiwan lunisolar** calendar.

* **ThaiBuddhistCalendar**, which represents the **Thai Buddhist** calendar.

* **UmAlQuraCalendar**, which represents the **Um Al Qura** calendar.

You can set the default calendar as demonstrated in **Example 1**.

#### __[C#] Example 1: Setting the default calendar__

	{{region cs-radcalendar-calendar-support-2}}
		CultureInfo arSA = CultureInfo.CreateSpecificCulture("ar-SA");
        Thread.CurrentThread.CurrentCulture = arSA;
        Thread.CurrentThread.CurrentUICulture = arSA;
        arSA.DateTimeFormat.Calendar = new HijriCalendar();
	{{endregion}}

#### __[VB.NET] Example 1: Setting the default calendar__

	{{region vb-radcalendar-calendar-support-2}}
		Dim arSA As CultureInfo = CultureInfo.CreateSpecificCulture("ar-SA")
		Thread.CurrentThread.CurrentCulture = arSA
		Thread.CurrentThread.CurrentUICulture = arSA
		arSA.DateTimeFormat.Calendar = New HijriCalendar()
	{{endregion}}

**Figure 1** demonstrates the final result:

#### __Figure 1: RadScheduleView with Hijri calendar__

![RadScheduleView with Hijri calendar](images/hijri-scheduleview.png)