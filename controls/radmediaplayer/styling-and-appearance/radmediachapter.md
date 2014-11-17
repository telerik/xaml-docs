---
title: RadMediaChapter
page_title: RadMediaChapter
description: RadMediaChapter
slug: radmediaplayer-radmediachapter
tags: radmediachapter
publish: True
position: 3
---

# RadMediaChapter

__RadMediaChapter__ derives from the __ContentControl__ class, so you can control it's appearance by specifing the __Content__ and __ContentTemplate__ properties.

#### __XAML__

{{region radmediaplayer-radmediachapter_0}}
	<telerik:RadMediaChapter Position="00:07:30">
		<Grid MaxWidth="150">
			<Grid.ColumnDefinitions>
				<ColumnDefinition Width="Auto" />
				<ColumnDefinition />
			</Grid.ColumnDefinitions>
			<Image Width="50" 
				   Margin="4"
				   Source="../../Images/1-7-30" />
			<TextBlock Grid.Column="1" 
					   Margin="4"
					   Text="Resource-Centric Apps"
					   TextWrapping="Wrap" />
		</Grid>
	</telerik:RadMediaChapter>
{{endregion}}