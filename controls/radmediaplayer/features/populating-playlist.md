---
title: Populating playlist
page_title: Populating playlist
description: Populating playlist
slug: radmediaplayer-populating-playlist
tags: populating,playlist
publish: True
position: 1
---

# Populating playlist

Populating __RadMediaPlayer's__ playlist can be done by adding items of type __RadMediaItem__ to the __Items__ collection of __RadMediaPlayer__. Below is an example of adding media items to a __RadMediaPlayer__:

#### __XAML__

{{region radmediaplayer-populating-playlist_0}}
	<telerik:RadMediaPlayer Width="600" 
							Height="400"
							Margin="20">
		<telerik:RadMediaItem Header="The Dynamics Duo talk about CRM and Silverlight" Source="http://mschnlnine.vo.llnwd.net/d1/ch9/7/1/5/1/2/4/DynamicsDuoCRMSilverlight_ch9.wmv" />
	</telerik:RadMediaPlayer>
{{endregion}}

#### __C#__

{{region radmediaplayer-populating-playlist_1}}
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
{{endregion}}

#### __VB.NET__

{{region radmediaplayer-populating-playlist_1}}
	Dim radMediaPlayer1 As New RadMediaPlayer()
	radMediaPlayer1.Width = 600
	radMediaPlayer1.Height = 400
	Dim mediaSource As String = "http://mschnlnine.vo.llnwd.net/d1/ch9/7/1/5/1/2/4/DynamicsDuoCRMSilverlight_ch9.wmv"
	Dim imageSource As String = "http://neosmart.net/blog/wp-content/uploads/microsoft-silverlight.png"
	Dim mediaItem As New RadMediaItem()
	mediaItem.Source = New Uri(mediaSource, UriKind.RelativeOrAbsolute)
	mediaItem.Header = "The Dynamics Duo talk about CRM and Silverlight"
	radMediaPlayer1.Items.Add(mediaItem)
	LayoutRoot.Children.Add(radMediaPlayer1)

	Public Sub New()
		InitializeComponent()
		player.ItemsSource = GetItems()
	End Sub

	Public Shared Function GetItems() As ObservableCollection(Of MediaItem)
		Dim item1 As New MediaItem() With {
		 .Source = "http://ecn.channel9.msdn.com/o9/pdc09/wmv/CL16.wmv",
		 .Image = "../../Images/0-0-0.png",
		 .Title = "Optimizing for Performance with the Windows Performance Toolkit"
		}
		Dim item2 As New MediaItem() With {
		 .Source = "http://ecn.channel9.msdn.com/o9/pdc09/wmv/CL06.wmv",
		 .Image = "../../Images/1-0-0.png",
		 .Title = "Networking and Web Services in Silverlight"
		}
		Dim item3 As New MediaItem() With {
		  .Source = "http://ecn.channel9.msdn.com/o9/pdc09/wmv/CL07.wmv",
		  .Image = "../../Images/2-0-0.png",
		  .Title = "Mastering Microsoft .NET RIA Services"
		}

		Dim items As New ObservableCollection(Of MediaItem)()
		items.Add(item1)
		items.Add(item2)
		items.Add(item3)
		Return items
	End Function

	Public Class MediaItem
		Public Property Image() As String
			Get
				Return m_Image
			End Get
			Set(ByVal value As String)
				m_Image = Value
			End Set
		End Property
		Private m_Image As String
		Public Property Source() As String
			Get
				Return m_Source
			End Get
			Set(ByVal value As String)
				m_Source = Value
			End Set
		End Property
		Private m_Source As String
		Public Property Title() As String
			Get
				Return m_Title
			End Get
			Set(ByVal value As String)
				m_Title = Value
			End Set
		End Property
		Private m_Title As String
	End Class
{{endregion}}


__RadMediaPlayer's__ playlist can also be bound to a collection of data items. Below is an example of how to use __RadMediaPlayer's ItemsSource__ property to populate a playlist and defining a DataTemplate to be used for each playlist item.

#### __XAML__

{{region radmediaplayer-populating-playlist_2}}
	<telerik:RadMediaPlayer x:Name="player" SelectedIndex="0">
		<telerik:RadMediaPlayer.ItemTemplate>
			<DataTemplate>
				<telerik:ContainerBinding.ContainerBindings>
					<telerik:ContainerBindingCollection>
						<telerik:ContainerBinding Binding="{Binding Source}" PropertyName="Source" />
					</telerik:ContainerBindingCollection>
				</telerik:ContainerBinding.ContainerBindings>
				<StackPanel HorizontalAlignment="Left" Orientation="Horizontal">
					<Image Margin="4" 
						   Source="{Binding Image}"
						   Stretch="Uniform" />
					<TextBlock Margin="4" 
							   VerticalAlignment="Center"
							   Text="{Binding Title}" />
				</StackPanel>
			</DataTemplate>
		</telerik:RadMediaPlayer.ItemTemplate>
	</telerik:RadMediaPlayer>
{{endregion}}

#### __C#__

{{region radmediaplayer-populating-playlist_3}}
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
{{endregion}}

#### __VB.NET__

{{region radmediaplayer-populating-playlist_3}}
	Public Sub New()
		InitializeComponent()
		player.ItemsSource = GetItems()
	End Sub

	Public Shared Function GetItems() As ObservableCollection(Of MediaItem)
		Dim item1 As New MediaItem() With {
		 .Source = "http://ecn.channel9.msdn.com/o9/pdc09/wmv/CL16.wmv",
		 .Image = "../../Images/0-0-0.png",
		 .Title = "Optimizing for Performance with the Windows Performance Toolkit"
		}
		Dim item2 As New MediaItem() With {
		 .Source = "http://ecn.channel9.msdn.com/o9/pdc09/wmv/CL06.wmv",
		 .Image = "../../Images/1-0-0.png",
		 .Title = "Networking and Web Services in Silverlight"
		}
		Dim item3 As New MediaItem() With {
		  .Source = "http://ecn.channel9.msdn.com/o9/pdc09/wmv/CL07.wmv",
		  .Image = "../../Images/2-0-0.png",
		  .Title = "Mastering Microsoft .NET RIA Services"
		}

		Dim items As New ObservableCollection(Of MediaItem)()
		items.Add(item1)
		items.Add(item2)
		items.Add(item3)
		Return items
	End Function

	Public Class MediaItem
		Public Property Image() As String
			Get
				Return m_Image
			End Get
			Set(ByVal value As String)
				m_Image = Value
			End Set
		End Property
		Private m_Image As String
		Public Property Source() As String
			Get
				Return m_Source
			End Get
			Set(ByVal value As String)
				m_Source = Value
			End Set
		End Property
		Private m_Source As String
		Public Property Title() As String
			Get
				Return m_Title
			End Get
			Set(ByVal value As String)
				m_Title = Value
			End Set
		End Property
		Private m_Title As String
	End Class
{{endregion}}