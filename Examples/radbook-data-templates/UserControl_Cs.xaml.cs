using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;
using System.Collections.ObjectModel;

namespace Application1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

	#region radbook-data-templates_0
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			InitializeComponent();

			// create the collection of photos
			ObservableCollection<PhotoItem> myPhotos = new ObservableCollection<PhotoItem>();
			myPhotos.Add(new PhotoItem()
			{
				Title = "Chrysanthemum",
				Image = "Chrysanthemum.jpg",
				DateTaken = DateTime.Parse("3/14/2008 1:59 PM"),
				Size = "858 KB"
			});
			myPhotos.Add(new PhotoItem()
			{
				Title = "Desert",
				Image = "Desert.jpg",
				DateTaken = DateTime.Parse("2/12/2008 3:12 PM"),
				Size = "458 KB"
			});
			myPhotos.Add(new PhotoItem()
			{
				Title = "Hydrangeas",
				Image = "Hydrangeas.jpg",
				DateTaken = DateTime.Parse("3/25/2008 2:22 PM"),
				Size = "843 KB"
			});
			myPhotos.Add(new PhotoItem()
			{
				Title = "Jellyfish",
				Image = "Jellyfish.jpg",
				DateTaken = DateTime.Parse("1/14/2008 4:32 PM"),
				Size = "456 KB"
			});
			myPhotos.Add(new PhotoItem()
			{
				Title = "Koala",
				Image = "Koala.jpg",
				DateTaken = DateTime.Parse("6/14/2008 2:46 PM"),
				Size = "654 KB"
			});
			myPhotos.Add(new PhotoItem()
			{
				Title = "LightHouse",
				Image = "LightHouse.jpg",
				DateTaken = DateTime.Parse("8/23/2008 3:59 PM"),
				Size = "930 KB"
			});
			myPhotos.Add(new PhotoItem()
			{
				Title = "Penguis",
				Image = "Penguis.jpg",
				DateTaken = DateTime.Parse("3/14/2008 1:59 PM"),
				Size = "623 KB"
			});
			RadBook1.ItemsSource = myPhotos;
		}
	}
	// create a class representing a single photo
	public class PhotoItem
	{
		public string Image { get; set; }
		public string Title { get; set; }
		public DateTime DateTaken { get; set; }
		public string Size { get; set; }
	}
	#endregion
}
