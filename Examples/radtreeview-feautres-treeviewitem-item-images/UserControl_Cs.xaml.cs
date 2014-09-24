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

#region radtreeview-feautres-treeviewitem-item-images_2
private void radTreeView_ItemPrepared(object sender, RadTreeViewItemPreparedEventArgs e)
{
 e.PreparedItem.DefaultImageSrc = "/Examples/Common/Images/Vista Icons/Icon1.png";
 e.PreparedItem.ExpandedImageSrc = "/Examples/Common/Images/Vista Icons/Icon2.png";
 e.PreparedItem.SelectedImageSrc = "/Examples/Common/Images/Vista Icons/Icon3.png"; 
}
#endregion

#region radtreeview-feautres-treeviewitem-item-images_4
private void radTreeView_ItemPrepared(object sender, RadTreeViewItemPreparedEventArgs e)
{
 BitmapImage defaultImage = new BitmapImage(new Uri("Icon1.png", UriKind.Relative));
 e.PreparedItem.DefaultImageSrc = defaultImage;
 BitmapImage expandedImage = new BitmapImage(new Uri("Icon2.png", UriKind.Relative));
 e.PreparedItem.ExpandedImageSrc = expandedImage;
 BitmapImage selectedImage = new BitmapImage(new Uri("Icon3.png", UriKind.Relative));
 e.PreparedItem.SelectedImageSrc = selectedImage;
}
#endregion
}
