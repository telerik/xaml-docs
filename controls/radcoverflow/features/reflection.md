---
title: Loading animation
page_title: Loading animation
description: Check our &quot;Loading animation&quot; documentation article for the RadCoverflow {{ site.framework_name }} control.
slug: coverflow-reflection
tags: loading,animation
published: True
position: 2
---

# {{ site.framework_name }} RadCoverflow Loading animation

If you want to benefit from the built-in loading bar and you use a ItemTemplate to define a specific layout of your RadCoverFlowItems you should use the attached property EnableNotification. Here is an example how to use the attached property with a custom ItemTemplate in RadCoverFlow:

#### __XAML__

{{region xaml-coverflow-Reflection_0}}
	<telerik:RadCoverFlow>
		<telerik:RadCoverFlow.ItemTemplate>
			<DataTemplate>
				 <Image Source="{Binding}" Width="225" Height="225" Stretch="None" telerik:RadCoverFlow.EnableLoadNotification="True" />
			</DataTemplate>
		</telerik:RadCoverFlow.ItemTemplate>
	</telerik:RadCoverFlow>
{{endregion}}

Now, if your source points to an image on the internet, the loading animation will be shown until the image is downloaded and displayed.
