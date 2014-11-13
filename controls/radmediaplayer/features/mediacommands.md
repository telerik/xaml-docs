---
title: MediaCommands
page_title: MediaCommands
description: MediaCommands
slug: radmediaplayer-mediacommands
tags: mediacommands
publish: True
position: 6
---

# MediaCommands

__RadMediaPlayer__ supports all available commands in the __MediaCommands__ class.

#### __XAML__

{{region radmediaplayer-mediacommands_0}}
	<StackPanel Orientation="Vertical">
		<telerik:RadButton Command="telerik:MediaCommands.FastForward" 
						   CommandParameter="10"
						   CommandTarget="{Binding ElementName=player}"
						   Content="Fast Forward" />
		<telerik:RadButton Command="telerik:MediaCommands.Rewind" 
						   CommandParameter="10"
						   CommandTarget="{Binding ElementName=player}"
						   Content="Rewind" />
	</StackPanel>
{{endregion}}