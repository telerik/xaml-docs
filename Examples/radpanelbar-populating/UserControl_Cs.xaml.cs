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
		public void PopulatePanelBar()
		{

			#region radpanelbar-populating_2
			RadPanelBar myPanelBar = new RadPanelBar();
			RadPanelBarItem item1 = new RadPanelBarItem() { Header = "Item 1" };
			RadPanelBarItem item2 = new RadPanelBarItem() { Header = "Item 2" };
			RadPanelBarItem item3 = new RadPanelBarItem() { Header = "Item 3" };
			myPanelBar.Items.Add(item1);
			myPanelBar.Items.Add(item2);
			myPanelBar.Items.Add(item3);
			#endregion

			#region radpanelbar-populating_3
			List<string> myListDataSource = new List<string>();
			myListDataSource.Add("Item 1");
			myListDataSource.Add("Item 2");
			myListDataSource.Add("Item 3");
			RadPanelBar myPanel = new RadPanelBar();
			myPanel.ItemsSource = myListDataSource;
			#endregion
		}
	}
}
