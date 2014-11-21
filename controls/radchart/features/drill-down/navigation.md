---
title: Navigation
page_title: Navigation
description: Navigation
slug: radchart-features-drill-down-navigation
tags: navigation
published: True
position: 3
---

# Navigation



## 

The __RadChart__ provides you with an __API__ for navigating between the hierarchy levels when using its drill down feature. It can be used via the __HierarchicalManager__ property of the __RadChart__. The HierarchyManger tracks the history of the user navigation through the data. Using its __Back()__ and __Forward()__ methods you can enable him to go back through the levels of hierarchy or forward when he wants to follow the same navigation line.

Here is an example of two buttons, which call the respective methods.

#### __XAML__

{{region radchart-features-drill-down-navigation_0}}
	<StackPanel>
	    <Button x:Name="BackButton"
	            Content="Back"
	            Click="BackButton_Click" />
	    <Button x:Name="ForwardButton"
	            Content="Forward"
	            Click="ForwardButton_Click" />
	</StackPanel>
	{{endregion}}



#### __C#__

{{region radchart-features-drill-down-navigation_1}}
	private void BackButton_Click( object sender, RoutedEventArgs e )
	{
	    this.radChart.HierarchyManager.Back();
	}
	private void ForwardButton_Click( object sender, RoutedEventArgs e )
	{
	    this.radChart.HierarchyManager.Forward();
	}
	{{endregion}}



#### __VB.NET__

{{region radchart-features-drill-down-navigation_2}}
	Private Sub BackButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	 Me.radChart.HierarchyManager.Back()
	End Sub
	Private Sub ForwardButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	 Me.radChart.HierarchyManager.Forward()
	End Sub
	{{endregion}}


