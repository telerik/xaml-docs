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

#region raddocking-save-load-layout-overview_6
private byte[] layoutBytes;
private void RadMenuItemLoad_Click(object sender, RoutedEventArgs e)
{
 using (MemoryStream stream = new MemoryStream(this.layoutBytes))
 {
  this.docking.LoadLayout(stream);
 }
}
private void RadMenuItemSave_Click(object sender, RoutedEventArgs e)
{
 using (MemoryStream stream = new MemoryStream())
 {
  this.docking.SaveLayout(stream);
  this.layoutBytes = stream.GetBuffer();
  this.LoadLayout.IsEnabled = true;
 }
}
#endregion

#region raddocking-save-load-layout-overview_8
private ViewModels.WeatherStationViewModel viewModel;
public Page()
{
 InitializeComponent();
 this.viewModel = newViewModels.WeatherStationViewModel();
 IsolatedStoragePersister.LoadState(this.viewModel);
 this.DataContext = this.viewModel;
}
#endregion

#region raddocking-save-load-layout-overview_9
private void RadMenuItemLoad_Click(object sender, RoutedEventArgs e)
{
 var radArgs = e as RadRoutedEventArgs;
 if (radArgs != null)
 {
  RadMenuItem item = radArgs.Source as RadMenuItem;
  if (item != null && item.DataContext is KeyValuePair<string, byte[]>)
  {
   using (MemoryStream stream = new MemoryStream(((KeyValuePair<string, byte[]>)item.DataContext).Value))
   {
    this.docking.LoadLayout(stream);
   }
  }
 }
}
#endregion

#region raddocking-save-load-layout-overview_10
private void RadMenuItemSave_Click(object sender, RoutedEventArgs e)
{
 using (MemoryStream stream = new MemoryStream())
 {
  this.docking.SaveLayout(stream);
  byte[] layoutBytes = stream.GetBuffer();
  this.viewModel.SavedLayouts.Add(new KeyValuePair<string, byte[]>(args.PromptResult, layoutBytes));
IsolatedStoragePersister.SaveState(this.viewModel);
}
}
#endregion

#region raddocking-save-load-layout-overview_11
private void RadMenuItemClear_Click(object sender, RoutedEventArgs e)
{
 this.viewModel.SavedLayouts.Clear();
 IsolatedStoragePersister.SaveState(this.viewModel);
}
#endregion
}
