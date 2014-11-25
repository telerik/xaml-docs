---
title: Smooth Streaming
page_title: Smooth Streaming
description: Smooth Streaming
slug: radmediaplayer-smoothstreaming
tags: smooth,streaming
publish: True
position: 5
---

# Smooth Streaming

__RadMediatelerik__ allows you to play [Smooth Streaming](http://smf.codeplex.com/) video. You have to provide implementaion of __MediaStreamSource__ that can handle Smooth streaming. Here is an example that uses __AdaptiveStreamingSource__. To enable smooth streaming set __IsStreamingSource__ to __true__ and handle the __StreamAttached__ event to provide some additional preparation.

#### __XAML__

{{region radmediaplayer-smoothstreaming_0}}
	<telerik:RadMediaPlayer x:Name="telerik">
		<telerik:RadMediaItem IsStreamingSource="True" 
							  Source="http://video3.smoothhd.com.edgesuite.net/ondemand/Big Buck Bunny Adaptive.ism/Manifest"
							  StreamAttached="RadMediaItem_StreamAttached" />
	</telerik:RadMediaPlayer>
{{endregion}}

#### __C#__

{{region radmediaplayer-smoothstreaming_1}}
	private void RadMediaItem_StreamAttached(object sender, EventArgs e)
	{
		var item = sender as RadMediaItem;
		if (item != null)
		{
			var adaptiveSource = new AdaptiveStreamingSource();
			adaptiveSource.MediaElement = player.MediaElement;
			adaptiveSource.ManifestUrl = item.Source;
			adaptiveSource.StartPlayback();
		}
	}
{{endregion}}

#### __VB.NET__

{{region radmediaplayer-smoothstreaming_1}}
	Private Sub RadMediaItem_StreamAttached(ByVal sender As Object, ByVal e As EventArgs)
		Dim item = TryCast(sender, RadMediaItem)
		If item IsNot Nothing Then
			Dim adaptiveSource = New AdaptiveStreamingSource()
			adaptiveSource.MediaElement = player.MediaElement
			adaptiveSource.ManifestUrl = item.Source
			adaptiveSource.StartPlayback()
		End If
	End Sub
{{endregion}}