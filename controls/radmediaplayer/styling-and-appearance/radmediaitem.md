---
title: RadMediaItem
page_title: RadMediaItem
description: RadMediaItem
slug: radmediaplayer-radmediaitem
tags: radmediaitem
publish: True
position: 2
---

# RadMediaItem

__RadMediaItem__ derives from the __HeaderedSelector__ class, so you can control it's appearance by specifying the __Header__ and __HeaderTemplate__ properties.

#### __XAML__

{{region radmediaplayer-radmediaitem_0}}
	<telerik:RadMediaPlayer x:Name="telerik" 
							FullScreenChanged="telerik_FullScreenChanged"
							IsChaptersPanelPinned="True"
							IsVideoPanelPinned="True"
							SelectedIndex="0">
		<telerik:RadMediaItem Source="http: //ecn.channel9.msdn.com/o9/pdc09/wmv/CL16.wmv" VideoStretch="None">
			<telerik:RadMediaItem.Header>
				<StackPanel Orientation="Horizontal">
					<StackPanel Margin="8">
						<TextBlock FontWeight="Normal" Text="Name: " />
						<TextBlock Margin="4" 
								   FontWeight="Bold"
								   Text="Optimizing for Performance with the Windows Performance Toolkit" />
					</StackPanel>
					<StackPanel Margin="8">
						<TextBlock FontWeight="Normal" Text="Genre: " />
						<TextBlock Margin="4" 
								   FontWeight="Bold"
								   Text="Tech Video" />
					</StackPanel>
				</StackPanel>
			</telerik:RadMediaItem.Header>
		</telerik:RadMediaItem>
	</telerik:RadMediaPlayer>
{{endregion}}