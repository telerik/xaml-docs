---
title: Video size
page_title: Video size
description: Video size
slug: radmediaplayer-video-size
tags: video,size
publish: True
position: 3
---

# Video size

The __VideoWidth__ and __VideoHeight__ properties allow you to manipulate the size of the __MediaElement__ inside __RadMediaPlayer__. By default, the two properties have a value of __Double.NaN__ which means that the __MediaElement__ will take up as much space as the control has reserved for it. 

One additional property that allows you to tweak the __MediaElement__ is the __VideoStretch__ property, which allows you to manipulate __MediaElement's__ [Stretch](http://msdn.microsoft.com/en-us/library/system.windows.controls.mediaelement.stretch.aspx) property.

Below you can see examples of some common scenarios using the __VideoWidth__, __VideoHeight__ and __VideoStretch__ properties.

#### __XAML - default video size__

{{region radmediaplayer-video-size_0}}
	<telerik:RadMediaPlayer Width="400" Height="300">
		<telerik:RadMediaItem Header="C# 4.0: Meet the Design Team" Source="http://mschnlnine.vo.llnwd.net/d1/ch9/4/6/3/9/0/4/CSharp4DesignTeam_ch9.wmv" />
	</telerik:RadMediaPlayer>
{{endregion}}

#### __XAML - The video is stretched to fill the RadMediaPlayer control__

{{region radmediaplayer-video-size_1}}
	<telerik:RadMediaPlayer Width="400" Height="300">
		<telerik:RadMediaItem Header="C# 4.0: Meet the Design Team" 
							  Source="http://mschnlnine.vo.llnwd.net/d1/ch9/4/6/3/9/0/4/CSharp4DesignTeam_ch9.wmv"
							  VideoStretch="Fill" />
	</telerik:RadMediaPlayer>
{{endregion}}

In the next example, __RadMediaPlayer's Width__ and __Height__ are not set. The only hard-coded size is that of the media element. In this scenario, __RadMediaPlayer__ will be sized accordingly to the __MediaElement__'s size.

#### __XAML__

{{region radmediaplayer-video-size_2}}
	<telerik:RadMediaPlayer>
		<telerik:RadMediaItem Title="C# 4.0: Meet the Design Team" 
							  Source="http://mschnlnine.vo.llnwd.net/d1/ch9/4/6/3/9/0/4/CSharp4DesignTeam_ch9.wmv"
							  VideoHeight="250"
							  VideoStretch="Fill"
							  VideoWidth="500" />
	</telerik:RadMediaPlayer>
{{endregion}}