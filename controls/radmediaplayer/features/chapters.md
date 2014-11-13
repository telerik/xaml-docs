---
title: Chapters
page_title: Chapters
description: Chapters
slug: radmediaplayer-chapters
tags: chapters
publish: True
position: 2
---

# Chapters

Each __RadMediaItem__ element can contain a number of chapters. A chapter is like a marker on the timeline of a movie, which can be used to jump to a specific moment in the movie. Each chapter has a __Position__ and __Content__ (__RadMediaChapter__ derives from __ContentControl__) properties. 

The __Position__ property is of type __TimeSpan__ and has to be defined like so:

* "00:00:20" - jumps to the 20th sec. of the movie

* "00:05:40" - jumps to the 5th min. and 40th sec. of the movie

The __Content__ property is used to display some generic content when a certain chapter has been reached.				

#### __XAML__

{{region radmediaplayer-chapters_0}}
	<telerik:RadMediaPlayer Width="600" Height="400" Margin="20">
	    <telerik:RadMediaItem 
	        	Source="http://mschnlnine.vo.llnwd.net/d1/ch9/7/1/5/1/2/4/DynamicsDuoCRMSilverlight_ch9.wmv"
	        	Header="The Dynamics Duo talk about CRM and Silverlight">
	        <telerik:RadMediaChapter Position="00:05:00" Content="5 min. has elapsed" />
	        <telerik:RadMediaChapter Position="00:10:00" Content="10 min. has elapsed" />
	        <telerik:RadMediaChapter Position="00:15:00" Content="15 min. has elapsed" />
	    </telerik:RadMediaItem>
	</telerik:RadMediaPlayer>
{{endregion}}

Moving the mouse over the timeline, causes a panel to open and show more information about the chapters. Can control the  duration that the chapters panel will stays open by specifying the __ChaptersStaysOpenInterval__ property.  The chapters panel can be pinned by setting the __IsChaptersPanelPinned__ property to __true__, so it will stays open while playing the video.Clicking on any of the chapters in the panel will cause the movie to jump to the specified position.