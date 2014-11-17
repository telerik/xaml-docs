using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radcarousel-how-to-change-scroll-buttons_1
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
#endregion
}
