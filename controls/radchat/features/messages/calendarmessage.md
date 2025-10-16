---
title: CalendarMessage
page_title: CalendarMessage
description: Check our &quot;CalendarMessage&quot; documentation article for the RadChat {{ site.framework_name }} control.
slug: chat-items-calendarmessage
tags: messages,calendarmessage
published: True
position: 3
---

# Calendar Message

The __CalendarMessage__ operates with __DateTime__ value type. Its constructors accept the following parameters.

* __DateTime selectedDate__ 
* __MessageDisplayPosition displayPosition__ 
* __Author author__ 
* __DateTime creationDate__ 
* __DateTime displayDate__: the __creationDate__ and __displayDate__ parameters are optional. The __displayDate__ parameter is used to control the visible time period when adding the message. If the __selectedDate__ corresponds to a different time period, it would not be visible initially.

__Example 1: Defining a CalendarMessage__ 
```C#
	   DateTime time = new DateTime(2018, 6, 1);
       CalendarMessage calendarMessage = new CalendarMessage(MessageDisplayPosition.Popup, currentAuthor);
            
       this.chat.AddMessage(calendarMessage);
```

#### __Figure 1: Defining CalendarMessage__
![Defining CalendarMessage](images/RadChat_Messages_Calendar_01.png)

## See Also

* [Messages Overview]({%slug chat-items-messages-overview%})