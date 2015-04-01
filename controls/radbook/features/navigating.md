---
title: Navigating
page_title: Navigating
description: Navigating
slug: radbook-navigating
tags: navigating
published: True
position: 3
---

# Navigating

To change the set of pages that are displayed, you should use the __RightPageIndex__ property. This property represents the index of the page that is displayed in the right side of the book. It is zero based. 

On initial load, when the first and second pages are displayed, the value of this property will be 1. When the next pages are displayed - e.g. 3rd and 4rh the value of this property will be 3.

If you want to display the 50th and 51st page you should set this property to 50.

When you want to make a prev/next navigation the property should be increased with 2 for the next pages, and decreased with 2 for the previous set of pages.

Below is a sample of a button which shows the next set of pages when clicked:

#### __XAML__
{{region radbook-navigating_0}}
	<Button Content="Next >>" Click="NextButton_Click"/>
{{endregion}}

#### __C#__
{{region radbook-navigating_0}}
	private void NextButton_Click(object sender, System.Windows.RoutedEventArgs e)
	{
		RadBook1.RightPageIndex += 2;
	}
{{endregion}}

#### __VB.NET__
{{region radbook-navigating_0}}
	Private Sub NextButton_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
		RadBook1.RightPageIndex += 2
	End Sub
{{endregion}}

# See Also
 * [Getting Started]({%slug radbook-getting-started%})