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

#region radmenu-binding-to-wcf-linq_0
using System;
using Telerik.Windows.Controls;
using System.Collections.ObjectModel;
namespace ItemsControlWithWcfAndLinq
{
public class RadMenuDataSource : ObservableCollection<RadMenuItem>
 {
  HierarchicalDataSource hierarchicalDataSource;
  public RadMenuDataSource()
  {
   hierarchicalDataSource = new HierarchicalDataSource();
   hierarchicalDataSource.HierarchicalDataSourcePopulated += new EventHandler(HierarchicalListPopulated);
  }
  private void HierarchicalListPopulated(object sender, EventArgs e)
  {
   foreach (TableItem tableItem in hierarchicalDataSource)
   {
    RadMenuItem menuItem = new RadMenuItem();
    menuItem.Header = tableItem.NodeText;
    GetSubItems(tableItem, menuItem);
    this.Add(menuItem);
   }
  }
  private void GetSubItems(TableItem node, RadMenuItem menuItem)
  {
   foreach (TableItem subNode in node.Children)
   {
    RadMenuItem subMenuItem = new RadMenuItem();
    subMenuItem.Header = subNode.NodeText;
    menuItem.Items.Add(subMenuItem);
    GetSubItems(subNode, subMenuItem);
   }
  }
 }
}
Once we have the RadMenuDataSource class constructed, there is not much left. Only to add a menu control to the page and bind its ItemsSource property to the RadMenuDataSource class.
<UserControl x:Class="ItemsControlWithWcfAndLinq.Page"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" 
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:telerik="clr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.Navigation" 
    xmlns:local="clr-namespace:ItemsControlWithWcfAndLinq"
    Width="400" Height="300">
<UserControl.Resources>
  <local:RadMenuDataSource x:Key="menuDataSource" />
 </UserControl.Resources>
  <Grid x:Name="LayoutRoot" Background="White">
   <telerik:RadMenu  ItemsSource="{StaticResource menuDataSource}" 
HorizontalAlignment="Stretch" VerticalAlignment="Top" />
 </Grid>
</UserControl>
#endregion
}
