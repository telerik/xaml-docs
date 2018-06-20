---
title: WeatherCard
page_title: WeatherCard
description: WeatherCard
slug: chat-items-weathercard
tags: messages,weathercard
published: True
position: 4
---

# Weather Card

__Weather__ card extends __ImageCard__ by adding options to display weather data. The following set of properties is exposed for this purpose. They are all or of __string__ type.

* __Temperature__
* __Humidity__
* __Dew__
* __Pressure__
* __Wind__

#### __[C#] Example 1: Defining a WeatherCard__

{{region radchat-messages-productcard_01}}
	 WeatherCardMessage weatherCardMessage = new WeatherCardMessage(this.currentAuthor);
            weatherCardMessage.ActionResultsOrientation = Orientation.Vertical;
            weatherCardMessage.CardOrientation = CardOrientation.Portrait;
            weatherCardMessage.Dew = "6° C";
            weatherCardMessage.Humidity = "81 %";
            weatherCardMessage.ImageSource = new BitmapImage(new Uri("/Images/London.png", UriKind.RelativeOrAbsolute));
            weatherCardMessage.Pressure = "1008.00 mb";
            weatherCardMessage.Temperature = "9 °C";
            weatherCardMessage.Wind = "Wind: 0 mph from W";

            weatherCardMessage.SubTitle = "Partly cloudy";

            weatherCardMessage.Text = "Local Time: " + DateTime.Now.ToString("hh:mm tt");
            weatherCardMessage.Title = "London, UK";

            this.chat.AddMessage(weatherCardMessage);
{{endregion}}

Defining such __WeatherCardMessage__ will look as follows.

#### __Figure 1: Defining WeatherCard__
![Defining ImageCard](images/RadChat_WeatherCard_01.png)

## See Also

* [Messages Overview]({%slug chat-items-messages-overview%})