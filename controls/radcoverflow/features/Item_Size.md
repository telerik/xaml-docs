---
title: Item Size
page_title: Item Size
description: Item Size
slug: coverflow-item_size
tags: item,size
published: True
position: 4
---

# Item Size

There are three different ways by which you can customize the Size of the RadCoverFlowItems. First of all, you are free to explicitly set the Width and Height of any RadCoverFlowItem like this:

#### __XAML__

{{region coverflow-Item_Size_0}}
	<telerik:RadCoverFlow>
	        <Image Source="/CoverFlow/Images/01.png" Stretch="None" Width="100" Height="100" />
	</telerik:RadCoverFlow>
{{endregion}}

You can also define the Width and Height of the RadCoverFlowItem in a style part of the resources. Then you should apply your style on all RadCoverFlowItems. However, none of the previous examples are not a good solution if you have a dynamic data or data with more than 3-4 items. In this scenario, you should better create an ItemTemplate that defines the exact DataTemplate of the items. Here is an example of how to achieve this:

#### __XAML__

{{region coverflow-Item_Size_1}}
	<telerik:RadCoverFlow x:Name="coverFlow" Background="Transparent" OffsetY="50" CameraViewpoint="Center" RotationY="40" ItemScale="0.85">
	       <telerik:RadCoverFlow.ItemTemplate>
	               <DataTemplate>
	                     <Image Source="{Binding}" Width="225" Height="225" Stretch="Uniform" telerik:RadCoverFlow.EnableLoadNotification="True" />
	               </DataTemplate>
	       </telerik:RadCoverFlow.ItemTemplate>
	</telerik:RadCoverFlow>
{{endregion}}


