---
title: FlightCard
page_title: FlightCard
description: Check our &quot;FlightCard&quot; documentation article for the RadChat {{ site.framework_name }} control.
slug: chat-items-flightcard
tags: messages,flightcard
published: True
position: 3
---

# Flight Card

__FlightCard__ is intended to display flight information in a structured user-friendly manner. Below are the properties exposed for this purpose. Specific for the __FlightCard__ card is that it exposes the __Flights__ collection which is an IList of __FlightInfo__ objects.

### FlightInfo

* __DepartureCity__
* __DepartureAirport__
* __DepartureDateTime__
* __ArrivalCity__
* __ArrivalAirport__
* __ArrivalDateTime__

### FlightCard

* __PassengerName__
* __Total__
* __IList<FlightInfo>__

A sample __FlightCard__ can be defined as follows.

__Example 1: Defining a FlightCard__

<snippet id='radchat-features-messages-card-messages-flightcard-example_1_defining_a_flightcard-cs' />

This sample data will result in the following __FlightCard__.

#### __Figure 1: Defining ImageCard__
![Defining ImageCard](images/RadChat_FlightCard_01.png)

## See Also

* [Messages Overview]({%slug chat-items-messages-overview%})