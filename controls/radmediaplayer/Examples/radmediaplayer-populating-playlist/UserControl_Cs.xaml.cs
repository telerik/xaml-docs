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

#region radmediaplayer-populating-playlist_1
	RadMediaPlayer radMediaPlayer1 = new RadMediaPlayer();
	radMediaPlayer1.Width = 600;
	radMediaPlayer1.Height = 400;
	string mediaSource = "http://mschnlnine.vo.llnwd.net/d1/ch9/7/1/5/1/2/4/DynamicsDuoCRMSilverlight_ch9.wmv";
	string imageSource = "http://neosmart.net/blog/wp-content/uploads/microsoft-silverlight.png";
	RadMediaItem mediaItem = new RadMediaItem();
	mediaItem.Source = new Uri(mediaSource, UriKind.RelativeOrAbsolute);
	mediaItem.Header= "The Dynamics Duo talk about CRM and Silverlight";
	radMediaPlayer1.Items.Add(mediaItem);
	LayoutRoot.Children.Add(radMediaPlayer1);
#endregion

#region radmediaplayer-populating-playlist_3
public MainPage()
{
	InitializeComponent();
	player.ItemsSource = GetItems();
}

public static ObservableCollection<MediaItem> GetItems()
{
	MediaItem item1 = new MediaItem
	{
		Source = "http://ecn.channel9.msdn.com/o9/pdc09/wmv/CL16.wmv",
		Image = "../../Images/0-0-0.png",
		Title = "Optimizing for Performance with the Windows Performance Toolkit"
	};
	MediaItem item2 = new MediaItem
	{
		Source = "http://ecn.channel9.msdn.com/o9/pdc09/wmv/CL06.wmv",
		Image = "../../Images/1-0-0.png",
		Title = "Networking and Web Services in Silverlight"
	};
	MediaItem item3 = new MediaItem
	{
		Source = "http://ecn.channel9.msdn.com/o9/pdc09/wmv/CL07.wmv",
		Image = "../../Images/2-0-0.png",
		Title = "Mastering Microsoft .NET RIA Services"
	};
	
	ObservableCollection<MediaItem> items = new ObservableCollection<MediaItem>();
	items.Add(item1);
	items.Add(item2);
	items.Add(item3);
	return items;
}

public class MediaItem 
{
	public string Image { get; set; }
	public string Source { get; set; }
	public string Title { get; set; }
 }
#endregion
}
