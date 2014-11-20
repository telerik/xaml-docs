---
title: How to set the content from code behind
page_title: How to set the content from code behind
description: How to set the content from code behind
slug: how_to_set_the_content_from_code_behind
tags: how,to,set,the,content,from,code,behind
published: True
position: 2
---

# How to set the content from code behind





The __RadHtmlPlaceholer__ is declared on page this way:
	  

#### __XAML__

{{region How_to_set_the_content_from_code_behind_0}}
	<UserControl x:Class="RadHtmlPlaceholderDemo.Page"
	    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	    Width="700" Height="480"
	    >
	 <Grid x:Name="LayoutRoot" Background="White">
	  <Border BorderBrush="Black" BorderThickness="1">
	   <telerik:RadHtmlPlaceholder x:Name="RadHtmlPlaceholder1"/>
	   <Button Content="Set Content" Click="Button_Click" />
	  </Border>
	 </Grid>
	</UserControl>
	{{endregion}}



## To set external URL use the following code:

#### __C#__

{{region How_to_set_the_content_from_code_behind_1}}
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        RadHtmlPlaceholder1.SourceUrl = new Uri("http://www.bing.com");
    }
	{{endregion}}



#### __VB.NET__

{{region How_to_set_the_content_from_code_behind_1}}
    Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        RadHtmlPlaceholder1.SourceUrl = New Uri("http://www.bing.com")
    End Sub

## To set HTML string as a content use the following code:

#### __C#__

{{region How_to_set_the_content_from_code_behind_2}}
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        RadHtmlPlaceholder1.HtmlSource = @"<b>Hello World.</b>";
    }
	{{endregion}}



#### __VB.NET__

{{region How_to_set_the_content_from_code_behind_2}}
    Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        RadHtmlPlaceholder1.HtmlSource = "<b>Hello World.</b>"
    End Sub



# See Also

 * [Display external page in RadHtmlPlaceholder]({%slug radhtmlplaceholder-howto-displayexternalpage%})

 * [Display HTML string in RadHtmlPlaceholder]({%slug radhtmlplaceholder-howto-displayhtml%})
