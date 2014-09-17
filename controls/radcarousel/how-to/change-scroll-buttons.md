---
title: Change the predefined scroll buttons
page_title: Change the predefined scroll buttons
description: Change the predefined scroll buttons
slug: radcarousel-how-to-change-scroll-buttons
tags: change,the,predefined,scroll,buttons
published: True
position: 0
site_name: WPF
---

# Change the predefined scroll buttons



## 

The RadCarousel does provide a built-in scroll bar that enables you to move the items left, right or directly to the last or first page. However, if the default view does not meet your requirements, you may easily predefine them and change their style. Basically, you need to take a couple of steps:

* Set the HorizontalScrollBarVisibility property of the RadCarousel to "Hidden";

* Define the required CarouselScrollButtons and handle their Click events;

* Specify the ResourceDictionary so that the Themer is applied correctly.

Finally, the implementation should be as follows:

#### __XAML__

{{region radcarousel-how-to-change-scroll-buttons_0}}
	<Window.Resources>
	 <ResourceDictionary>
	  <ResourceDictionary.MergedDictionaries>
	   <ResourceDictionary Source="/Telerik.Windows.Controls.Navigation;component/Themes/GenericOfficeBlack.xaml"/>
	  </ResourceDictionary.MergedDictionaries>   
	 </ResourceDictionary>
	</Window.Resources>
	<Grid Background="Black">
	 <Grid.RowDefinitions>
	  <RowDefinition />
	  <RowDefinition Height="30"/>
	 </Grid.RowDefinitions>
	 <telerik:RadCarousel x:Name="RadCarousel1" HorizontalScrollBarVisibility="Hidden" Background="Black"
	    Grid.Row="0"/>
	   <StackPanel Grid.Row="1" Orientation="Horizontal" HorizontalAlignment="Center">
	  <telerik:CarouselScrollButton x:Name="pageDownButton"  CarouselScrollButtonType="PageLeft"Click="pageDownButton_Click"  Style="{StaticResource CarouselScrollButtonStyle}"/>
	  <telerik:CarouselScrollButton x:Name="pageLeftButton" CarouselScrollButtonType="LineUp"
	            Click="pageLeftButton_Click"  Style="{StaticResource CarouselScrollButtonStyle}"/>
	  <telerik:CarouselScrollButton x:Name="pageRightButton" CarouselScrollButtonType="LineDown" 
	            Click="pageRightButton_Click"  Style="{StaticResource CarouselScrollButtonStyle}"/>
	         <telerik:CarouselScrollButton x:Name="pageUpButton" CarouselScrollButtonType="PageRight" 
	            Click="pageUpButton_Click"  Style="{StaticResource CarouselScrollButtonStyle}"/>
	 </StackPanel>
	</Grid>
	{{endregion}}



#### __C#__

{{region radcarousel-how-to-change-scroll-buttons_1}}
	private void pageDownButton_Click(object sender, RoutedEventArgs e)
	 {
	  this.RadCarousel1.FindCarouselPanel().PageDown();
	 }
	private void pageLeftButton_Click(object sender, RoutedEventArgs e)
	 {
	  this.RadCarousel1.FindCarouselPanel().MoveBy(-1);
	 }
	private void pageRightButton_Click(object sender, RoutedEventArgs e)
	 {
	  this.RadCarousel1.FindCarouselPanel().MoveBy(1);
	 }
	private void pageUpButton_Click(object sender, RoutedEventArgs e)
	 {
	  this.RadCarousel1.FindCarouselPanel().PageUp();
	 }
	{{endregion}}



#### __VB.NET__

{{region radcarousel-how-to-change-scroll-buttons_2}}
	Private Sub pageDownButton_Click(sender As Object, e As RoutedEventArgs)
	 Me.RadCarousel1.FindCarouselPanel().PageDown()
	End Sub
	Private Sub pageLeftButton_Click(sender As Object, e As RoutedEventArgs)
	 Me.RadCarousel1.FindCarouselPanel().MoveBy(-1)
	End Sub
	Private Sub pageRightButton_Click(sender As Object, e As RoutedEventArgs)
	 Me.RadCarousel1.FindCarouselPanel().MoveBy(1)
	End Sub
	Private Sub pageUpButton_Click(sender As Object, e As RoutedEventArgs)
	 Me.RadCarousel1.FindCarouselPanel().PageUp()
	End Sub
	{{endregion}}



Once you are done, the RadCarousel should be visualized as the image below:




         
      ![](images/RadCarousel_ChangeScrollButtons.png)

Still, you are free to change the style of the buttons just as you want them to be. 


