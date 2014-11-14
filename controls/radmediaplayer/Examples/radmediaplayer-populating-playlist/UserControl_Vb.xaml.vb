Public Class Default_Vb
#Region "radmediaplayer-populating-playlist_1"
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
#End Region

#Region "radmediaplayer-populating-playlist_3"
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
#End Region

End Class
