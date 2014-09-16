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

#region contextmenu-programming-model_0
Border border = new Border();
border.Width = 200;
border.Height = 200;
border.Background = new SolidColorBrush(Colors.Brown);
border.BorderThickness = new Thickness(2);
border.BorderBrush = new SolidColorBrush(Colors.White);
LayoutRoot.Children.Add(border);
#endregion

#region contextmenu-programming-model_1
RadContextMenu contMenu = new RadContextMenu();
RadMenuItem option1 = new RadMenuItem() { Header = "Option1" };
RadMenuItem option2 = new RadMenuItem() { Header = "Option2" };
contMenu.Items.Add(option1);
contMenu.Items.Add(option2);
contMenu.EventName = "MouseLeftButtonDown";
#endregion
}
