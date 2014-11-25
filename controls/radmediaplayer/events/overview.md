---
title: Events Overview
page_title: Events Overview
description: Events Overview
slug: radmediaplayer-events-overview
tags: events,overview
publish: True
position: 0
---

# Events Overview

This topic covers the specific events exposed by the __RadMediaPlayer__ control. 

* __ChapterReached__ - occurs when a chapter is reached. The __ChapterReached__ event handler receives two arguments:
	* The sender argument contains the __RadMediaPlayer__. This argument is of type __object__, but can be cast to the __RadMediaPlayer__ type.
	* A __RadRoutedEventArgs__ object.

* __CurrentStateChanged__ - occurs when the state of the __RadMediaPlayer.MediaElement__ state is changed. The __CurrentStateChanged__ event handler receives two arguments:
	* The sender argument contains the __RadMediaPlayer__. This argument is of type __object__, but can be cast to the __RadMediaPlayer__ type.
	* A __RadRoutedEventArgs__ object.
	
* __DownloadProgressChanged__ - occurs when the download progress of the __RadMediaPlayer.MediaElement__ is changed. The __DownloadProgressChanged__ event handler receives two arguments:
	* The sender argument contains the __RadMediaPlayer__. This argument is of type __object__, but can be cast to the __RadMediaPlayer__ type.
	* A __RadRoutedEventArgs__ object.
	
* __FullScreenChanged__ - occurs when the FullScreen state of the __RadMediaPlayer__ is changed. The __FullScreenChanged__ event handler receives two arguments:
	* The sender argument contains the __RadMediaPlayer__. This argument is of type __object__, but can be cast to the __RadMediaPlayer__ type.
	* An __EventArgs__ object.

* __MediaEnded__ - occurs when the __RadMediaPlayer.MediaElement__ stops playing. The __MediaEnded__ event handler receives two arguments:
	* The sender argument contains the __RadMediaPlayer__. This argument is of type __object__, but can be cast to the __RadMediaPlayer__ type.
	* A __RadRoutedEventArgs__ object.							

* __MediaOpened__ - occurs when the __RadMediaPlayer.MediaElement__ starts playing. The __MediaOpened__ event handler receives two arguments:
	* The sender argument contains the __RadMediaPlayer__. This argument is of type __object__, but can be cast to the __RadMediaPlayer__ type.
	* A __RadRoutedEventArgs__ object.