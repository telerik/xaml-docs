---
title: Display external page in RadHtmlPlaceholder
page_title: Display external page in RadHtmlPlaceholder
description: Display external page in RadHtmlPlaceholder
slug: radhtmlplaceholder-howto-displayexternalpage
tags: display,external,page,in,radhtmlplaceholder
published: True
position: 1
---

# Display external page in RadHtmlPlaceholder



## 

Displaying an external page inside a Silverlight application can be achieved by setting the __SourceUrl__ property of __RadHtmlPlaceholder__.
		

#### __XAML__

{{region radhtmlplaceholder-howto-displayexternalpage_0}}
	<UserControl x:Class="RadHtmlPlaceholderDemo.Page" 
	             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	             xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	             Width="700"
	             Height="480">
	    <Grid x:Name="LayoutRoot" Background="White">
	        <Border BorderBrush="Black" BorderThickness="1">
	            <telerik:RadHtmlPlaceholder SourceUrl="http://www.bing.com" />
	        </Border>
	    </Grid>
	</UserControl>
{{endregion}}





![htmlplaceholder-getting-started](images/htmlplaceholder-getting-started.png)

## See Also

 * [Getting Started]({%slug radhtmlplaceholder-getting-started%})

 * [Display external page in RadHtmlPlaceholder]({%slug radhtmlplaceholder-howto-displayexternalpage%})

 * [Display HTML string in RadHtmlPlaceholder]({%slug radhtmlplaceholder-howto-displayhtml%})

 * [Display HTML string in RadHtmlPlaceholder]({%slug radhtmlplaceholder-howto-displayhtml%})

 * [Integrating RadHtmlPlaceholder and RadWindow]({%slug radhtmlplaceholder-howto-radwindowintegration%})

 * [How to set the content from code behind]({%slug how_to_set_the_content_from_code_behind%})
