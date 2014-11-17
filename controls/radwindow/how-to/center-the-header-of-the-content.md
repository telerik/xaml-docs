---
title: Center the Header of the RadWindow
page_title: Center the Header of the RadWindow
description: Center the Header of the RadWindow
slug: radwindow-how-to-center-the-header-of-the-content
tags: center,the,header,of,the,radwindow
published: True
position: 4
---

# Center the Header of the RadWindow

In order to allow the content in the header to be centered, you have to modify some elements in the __ControlTemplate__ of the __RadWindow__. Before continuing you might want to take a look at the template structure of the __RadWindow__. You might also find useful to learn [how to edit the default template of a control]({%slug styling-apperance-editing-control-templates%}).

In the __ControlTemplate__ for the __RadWindow__, find the __Grid__ with name "Header". It should have a __StackPanel__ placed in its first column:

#### __XAML__

{{region radwindow-how-to-center-the-header-of-the-content_0}}
	<StackPanel Margin="2 0 0 0"
	            Grid.Column="0"
	            Orientation="Horizontal">
	    <ContentPresenter x:Name="IconContent"
	                      HorizontalAlignment="Left"
	                      Margin="2"
	                      VerticalAlignment="Center"
	                      Content="{TemplateBinding Icon}"
	                      ContentTemplate="{TemplateBinding IconTemplate}" />
	    <ContentPresenter x:Name="HeaderContent"
	                      HorizontalAlignment="Left"
	                      VerticalAlignment="Center"
	                      Content="{TemplateBinding Header}"
	                      ContentTemplate="{TemplateBinding HeaderTemplate}" />
	</StackPanel>
{{endregion}}

Replace the __StackPanel__ with a __Grid__, having two columns. Place the __IconContent__ in the first column, then place the __HeaderContent__ in the second one and set the __HorizontalAlignment__ property of the __ContentPresenter__ to __Stretch__.

#### __XAML__

{{region radwindow-how-to-center-the-header-of-the-content_1}}
	<Grid Margin="2 0 0 0"
	      Grid.Column="0">
	    <Grid.ColumnDefinitions>
	        <ColumnDefinition Width="Auto" />
	        <ColumnDefinition Width="*" />
	    </Grid.ColumnDefinitions>
	    <ContentPresenter x:Name="IconContent"
	                      Grid.Column="0"
	                      HorizontalAlignment="Left"
	                      Margin="2"
	                      VerticalAlignment="Center"
	                      Content="{TemplateBinding Icon}"
	                      ContentTemplate="{TemplateBinding IconTemplate}" />
	    <ContentPresenter x:Name="HeaderContent"
	                      Grid.Column="1"
	                      HorizontalAlignment="Stretch"
	                      VerticalAlignment="Center"
	                      Content="{TemplateBinding Header}"
	                      ContentTemplate="{TemplateBinding HeaderTemplate}" />
	</Grid>
{{endregion}}

With this done, you can easily control the position of the content through the elements passed to the Header property:

#### __C#__

{{region radwindow-how-to-center-the-header-of-the-content_2}}
	TextBlock textBlock = new TextBlock();
	textBlock.Text = "My RadWindow";
	textBlock.HorizontalAlignment = HorizontalAlignment.Center;
	RadWindow radWindow = new RadWindow();
	radWindow.Width = 400;
	radWindow.Height = 300;
	radWindow.Style = this.Resources[ "RadWindowStyle" ] as Style;
	radWindow.Header = textBlock;
{{endregion}}

#### __VB.NET__

{{region radwindow-how-to-center-the-header-of-the-content_3}}
	Dim textBlock As New TextBlock()
	textBlock.Text = "My RadWindow"
	textBlock.HorizontalAlignment = HorizontalAlignment.Center
	Dim radWindow As New RadWindow()
	radWindow.Width = 400
	radWindow.Height = 300
	radWindow.Style = TryCast(Me.Resources("RadWindowStyle"), Style)
	radWindow.Header = textBlock
{{endregion}}

Here is a snapshot of the final result:

![](images/RadWindow_How_To_Center_the_Header_01.png)

# See Also

 * [Window Header]({%slug radwindow-features-window-header%})

 * [Close the RadWindow Through its Content]({%slug radwindow-how-to-close-the-radwidnow-through-its-content%})

 * [Hide the Maximize and Minimize buttons]({%slug radwindow-how-to-hide-minimize-maximize-buttons%})
