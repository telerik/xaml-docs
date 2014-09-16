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
		public void BindPanelBar()
		{
			#region radpanelbar-object-data_0
			List<string> myListDataSource = new List<string>();
			myListDataSource.Add("Item 1");
			myListDataSource.Add("Item 2");
			myListDataSource.Add("Item 3");
			RadPanelBar myPanel = new RadPanelBar();
			myPanel.ItemsSource = myListDataSource;
			#endregion
		}
	}
	#region radpanelbar-object-data_1
	public partial class Example : UserControl
	{
		public Example()
		{
			InitializeComponent();

			List<SourceCollection> sourceCollection = new List<SourceCollection>();

			sourceCollection.Add(new SourceCollection());
			sourceCollection.Add(new SourceCollection());
			sourceCollection.Add(new SourceCollection());
			RadPanelBar myPanel = new RadPanelBar();
			myPanel.ItemsSource = sourceCollection;
			myPanel.DisplayMemberPath = "Text";

		}
	}
	public class SourceCollection
	{
		private Random number;
		public SourceCollection()
		{
			number = new Random((int)DateTime.Now.Ticks);
		}
		public DateTime Time
		{
			get { return DateTime.Now; }
		}
		public int Number
		{
			get
			{
				return number.Next(0, 1000);
			}
		}
		public string Text
		{
			get
			{
				// Return a string of 8 random characters from A to Z
				System.Text.StringBuilder randomText = new System.Text.StringBuilder(8);
				for (int i = 0; i < 8; i++)
				{
					randomText.Append((char)(65 + (number.NextDouble() * 25)));
				}
				return randomText.ToString();
			}
		}
	}
	#endregion
}
