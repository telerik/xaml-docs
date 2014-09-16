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

#region radribbonview-ribbon-gallery_6
private void QuickStyles_ActivatePreview(object sender, Telerik.Windows.RadRoutedEventArgs e)
{
 // Grab the RadRibbonGallery object
 RadRibbonGallery gallery = sender as RadRibbonGallery;
 // Get the selected item
 RadGalleryItem selectedItem = gallery.SelectedItem as RadGalleryItem;
}
private void QuickStyles_DeactivatePreview(object sender, Telerik.Windows.RadRoutedEventArgs e)
{
 // Grab the RadRibbonGallery object
 RadRibbonGallery gallery = sender as RadRibbonGallery;
 // Get the selected item
 RadGalleryItem selectedItem = gallery.SelectedItem as RadGalleryItem;
}
#endregion
}
