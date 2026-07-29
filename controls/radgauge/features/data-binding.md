---
title: Data Binding
page_title: Data Binding
description: Check our &quot;Data Binding&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: radgauge-features-data-binding
tags: data,binding
published: True
position: 9
---

# Data Binding

The __RadGauge__ control allows you to bind it to a set of values, which to be displayed consecutive one after another. This feature is implemented via the indicator of the scale and its __ValueSource__ property. It is of type __IEnumerable__ and accepts the set of values you want to display.      

Additionally the indicators expose an API which allows you to control the display of the values in the __ValueSource__ collection. Via this API you can do the following:      

* [Start Playback](#start-playback)

* [Stop Playback](#stop-playback)

* [Move Next](#move-next)

* [Move Previous](#move-previous)

Here is the __RadGauge__ instance and the sample value collection, which will be used throughout the examples in this topic:      


<snippet id='radgauge-features-data-binding-block_1-xaml' />



<snippet id='radgauge-features-data-binding-block_2-cs' />

<snippet id='radgauge-features-data-binding-block_2-vb' />


## Start Playback

If you want to automatically display the values one after another with some predefined interval between them, you can use the __StartPlayback()__ method of the indicator.         

>Whenever called, this method will start displaying the values form the beginning of the collection. In that case it will resume.
   
Here is an example:   


<snippet id='radgauge-features-data-binding-block_3-cs' />

<snippet id='radgauge-features-data-binding-block_3-vb' />


## Stop Playback

To stop the automatic playback of the values you have simply to call the __StopPlayback()__ method.         

>Starting and stopping and than starting again the playback won't make it to contiunue from tha value it has stopped on. Instead, it will start from the beginning again.
			
Here is an example:          


<snippet id='radgauge-features-data-binding-block_4-cs' />

<snippet id='radgauge-features-data-binding-block_4-vb' />


## Move Next

The indicator's API also allows you to manually navigate through the values collection. On of the methods exposed is the __MoveNext()__ one. It changes the displayed value to the next value in the collection, if present. Here is an example.        


<snippet id='radgauge-features-data-binding-block_5-cs' />

<snippet id='radgauge-features-data-binding-block_5-vb' />


## Move Previous

The __MovePrevious()__ method is the other one used for manual navigation through the values collection. It displays the value previous to the current one. Here is an example.        


<snippet id='radgauge-features-data-binding-block_6-cs' />

<snippet id='radgauge-features-data-binding-block_6-vb' />


## Specifying the duration for each value

If you want every one of the values to be displayed a specific period of time you can use a colleciton PlaybackData objects as the ValueSource for the indicator. Every PlaybackData can specify own interval between values using __Duration__ property.        

Here is an example (a slight modification of the previous one):        


<snippet id='radgauge-features-data-binding-block_7-cs' />

<snippet id='radgauge-features-data-binding-block_7-vb' />
