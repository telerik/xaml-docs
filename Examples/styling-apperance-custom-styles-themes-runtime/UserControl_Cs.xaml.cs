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

#region styling-apperance-custom-styles-themes-runtime_4
private void Office_Black_Click(object sender, RoutedEventArgs e)
{
    Application.Current.Resources.MergedDictionaries.Clear();
    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
    {
        Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
    });
    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
    {
        Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
    });
    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
    {
        Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Input.xaml", UriKind.RelativeOrAbsolute)
    });
    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
    {
        Source = new Uri("/CustomStyles;component/Themes/CustomStyles.xaml", UriKind.RelativeOrAbsolute)
    });
}

private void Office_Blue_Click(object sender, RoutedEventArgs e)
{
    Application.Current.Resources.MergedDictionaries.Clear();
    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
    {
        Source = new Uri("/Telerik.Windows.Themes.Office_Blue;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
    });
    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
    {
        Source = new Uri("/Telerik.Windows.Themes.Office_Blue;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
    });
    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
    {
        Source = new Uri("/Telerik.Windows.Themes.Office_Blue;component/Themes/Telerik.Windows.Controls.Input.xaml", UriKind.RelativeOrAbsolute)
    });
    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
    {
        Source = new Uri("/CustomStyles;component/Themes/CustomStyles.xaml", UriKind.RelativeOrAbsolute)
    });

}

#endregion

}
