---
title: Structure
page_title: Structure
description: Structure
slug: radmediaplayer-structure
tags: structure
publish: True
position: 1
site_name: Silverlight
---

# Structure

This section defines terms and concepts used in the scope of __RadMediaPlayer,__ that you have to get familiar with prior to reading further. They can also be helpful when contacting our support service in order to describe your issue better. 

* __Chapters__ - points in time that represent beginning of new topics

* __Title/Header__- name of the movie

* __Toggle Playlist__ - button to control the playlist

* __Toggle FullScreen__ - button to toggle whether the control is in Full screen or not.

* __Toggle Play/Pause__ - button to start and pause the video

* __Volume__- button to control the volume of the video

* __Timeline__ - text to notify for elapsed and remaining time

__RadMediaPlayer__ is __ItemsControl__ where each item is of type __RadMediaItem__ - used to represent one item in the Playlist. __RadMediaItem__ is also an ItemsControl where each item is __RadMediaChapter__ - used to represent a point in time with some __Content__ to more clearly describe the chapter. __RadMediaItem__ also has __Header__ and __HeaderTemplate__ properties that specify how each item in the playlist will be rendered.

## See Also
 * [Getting Started]({%slug radmediaplayer-populating%})