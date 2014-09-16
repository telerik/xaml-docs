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

#region radtabcontrol-appearance_6
public partial class Example : UserControl
{
public Example()
{
InitializeComponent();
Loaded += new RoutedEventHandler(HeaderContent_Loaded);
}
void HeaderContent_Loaded(object sender, RoutedEventArgs e)
{
ObservableCollection<TestData> source = GetItemsSource();
tabControl.ItemsSource = source;
}
/// <summary>
/// Generates the items source, this can be Observable Collection as well.
/// </summary>
private ObservableCollection<TestData> GetItemsSource()
{
ObservableCollection<TestData> source = new ObservableCollection<TestData>();
TestData data = new TestData();
data.HeaderText = "Summary";
data.IconSource = "/Examples/Common/Images/VistaIcons/chart-bar.png";
data.ContentSource = "/Examples/Common/Images/TabControl/SampleContent05.png";
source.Add(data);
data = new TestData();
data.HeaderText = "Details";
data.IconSource = "/Examples/Common/Images/VistaIcons/chart-pie.png";
data.ContentSource = "/Examples/Common/Images/TabControl/SampleContent04.png";
source.Add(data);
data = new TestData();
data.HeaderText = "Today";
data.IconSource = "/Examples/Common/Images/VistaIcons/calendar-1-day.png";
data.ContentSource = "/Examples/Common/Images/TabControl/SampleContent03.png";
source.Add(data);
return source;
}
}
/// <summary>
/// Test class to serve as data item for the binding.
/// </summary>
public class TestData
{
public string HeaderText
{
get;
set;
}
public string IconSource
{
get;
set;
}
public string ContentSource
{
get;
set;
}
public override string ToString()
{
return HeaderText;
}
}
#endregion
}
